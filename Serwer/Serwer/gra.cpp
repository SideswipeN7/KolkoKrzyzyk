#pragma warning(disable:4244)
#pragma warning(disable:4996 4005)
#define _CRT_SECURE_NO_WARNINGS
#define _USE_MATH_DEFINES
#ifdef UNICODE
#undef UNICODE
#define _MBCS
#endif
#include <string>
#include <vector>
#include <cstdio>
#include <cstdlib>
#include <cstring>
using namespace std;
#include <WinSock2.h>
#include <stdio.h>
#include <iostream>
#pragma comment(lib,"ws2_32.lib")
#define LINE_MAX 1000

const u_short iPort = 500;

//KLASA Zajmujaca siê przekazaniem po³¹czenia
class  Game
{
public:
	Game(SOCKET pol1, SOCKET pol2);
	~Game();
	SOCKET GetPolaczenie(int x);

private:
	SOCKET  polaczenie1, polaczenie2;
};

Game::Game(SOCKET pol1, SOCKET pol2)
{
	this->polaczenie1 = pol1;
	this->polaczenie2 = pol2;
}
SOCKET Game::GetPolaczenie(int x) {
	if (x == 1)		return this->polaczenie1;
	if (x == 2)		return this->polaczenie2;
}

Game::~Game()
{
}

int CheckWin(int x, int gra[9]) {
	bool remis;

	//POZIOMO
	if (gra[0] == x&& gra[1] == x&&gra[2] == x)
	{
		cout << "WYGRANA" << endl;
		return x;
	}
	if (gra[3] == x&& gra[4] == x&& gra[5] == x)
	{
		cout << "WYGRANA" << endl;
		return x;
	}
	if (gra[6] == x&&gra[7] == x&& gra[8] == x)
	{
		cout << "WYGRANA" << endl;
		return x;
	}
	//PIONOWO
	if (gra[0] == x&& gra[3] == x&&gra[6] == x)
	{
		cout << "WYGRANA" << endl;
		return x;
	}
	if (gra[1] == x&&gra[4] == x&& gra[7] == x)
	{
		cout << "WYGRANA" << endl;
		return x;
	}
	if (gra[2] == x&& gra[5] == x&& gra[8] == x)
	{
		cout << "WYGRANA" << endl;
		return x;
	}
	//NA UKOS
	if (gra[0] == x&&gra[4] == x&& gra[8] == x)
	{
		cout << "WYGRANA" << endl;
		return x;
	}
	if (gra[2] == x&& gra[4] == x&& gra[6] == x)
	{
		cout << "WYGRANA" << endl;
		return x;
	}
	remis = true;
	//SPRAWD CZY JEST REMIS
	for (int i = 0; i < 9; i++) {
		if (gra[i] == 0)
			remis = false;
	}
	if (remis)
	{
		return 25;
	}


	//BRAK WYGRANEJ
	return 0;
}

//WYSLIJ DANE
int SendData(int x, SOCKET gracz) {
	//char *data = (char*)&x;
	//int zwrot, wszystko = strlen(data), biezacy = 0;
	cout << "DO WYSLANIA (INT):" << x << endl;
	int zwrot, biezacy = 0, wszystko;
	char data[20];
	/*memcpy(&x, data, sizeof(int));
	wszystko = strlen(data);*/
	itoa(x, data, 10);
	wszystko = strlen(data);

	int const nBufor = 10;
	char bufor[nBufor] = { '\0' };

	//cout << "WYSALANO (CHAR[]): " << data << endl;

	//WYSY£AMY KOD
	//while (wszystko > 0) {
	zwrot = send(gracz, data, wszystko, 0);
	//if (zwrot == 0) break;
	/*else*/ if (zwrot <= SOCKET_ERROR) abort;
	/*wszystko -= zwrot;
	biezacy += zwrot;*/
	//}

	//ODBIERAMY POTWIERDZENIE LUB KOD	
	zwrot = recv(gracz, bufor, nBufor, 0);
	if (zwrot <= SOCKET_ERROR)abort();
	bufor[zwrot] = '\0';

	if (bufor == "ack") {
		return 30;
		//POTWIERDZENIE ¯E JEST GRACZEM NR x
	}
	else {
		int liczba = atoi(bufor);
		//cout << "ODEBRANO: " << bufor << endl;
		return liczba;
		//ZWROT POLA ZAZNACZONEGO
	}
}

//Powiadom o koñcu gry graczy
void NotifyEnd(int wygral, SOCKET gracz1, SOCKET gracz2) {
	if (wygral == 21) {
		SendData(24, gracz1);
		SendData(23, gracz2);
	}
	if (wygral == 22)
	{
		SendData(23, gracz1);
		SendData(24, gracz2);
	}
	if (wygral == 25)
	{
		SendData(25, gracz1);
		SendData(25, gracz2);
	}
}


DWORD WINAPI KolkoKrzyzk(LPVOID parametr) {
	int kody[6] = { 21,22,23,24,25,26 };//21-O,22-X,23-przegrana,24-wygrana,25-remis,26-gra
	Game obecna = *(Game*)(parametr);
	SOCKET  gracz1 = obecna.GetPolaczenie(1), gracz2 = obecna.GetPolaczenie(2);
	int gra[9] = { 0,0,0,0,0,0,0,0,0 };
	int koniec;

	SendData(22, gracz2);
	SendData(21, gracz1);

	int liczba = SendData(kody[5], gracz1);
	//Co zanacza gracz1
	gra[liczba] = 21;

	while (true) {
		//Przeœlij do gracza 2 zaznaczony numer gracza 1

		//Co zanacza gracz2
		liczba = SendData(liczba, gracz2);
		gra[liczba] = 22;
		//SprawdŸ czy jest wygrana
		koniec = CheckWin(22, gra);
		if (koniec != 0) {
			//Powiadom graczy o koñcu gry
			NotifyEnd(koniec, gracz1, gracz2);
			SendData(liczba, gracz1);
			//Koniec gry
			break;
		}
		//Przeœlij do gracza 1 zaznaczony numer gracza 2

		//Co zanacza gracz1
		liczba = SendData(liczba, gracz1);
		gra[liczba] = 21;
		//SprawdŸ czy jest wygrana
		koniec = CheckWin(21, gra);
		if (koniec != 0) {
			//Powiadom graczy o koñcu gry
			NotifyEnd(koniec, gracz1, gracz2);
			liczba = SendData(liczba, gracz2);
			//Koniec gry
			break;
		}

	}
	return 0;
}




int main() {
	printf(">> Poczatek programu <<\n\n\n");

	WSADATA info;
	SOCKET nasluch, polaczenie1, polaczenie2;
	sockaddr_in lokalny, zdalny1, zdalny2; // struktura adres ip + port
	int rozmiar1, rozmiar2;
	vector<HANDLE> watki;
	if (WSAStartup(MAKEWORD(2, 2), &info) != 00) abort();
	nasluch = socket(AF_INET, SOCK_STREAM, IPPROTO_IP);
	if (nasluch == SOCKET_ERROR) abort();

	lokalny.sin_family = AF_INET;
	lokalny.sin_addr.s_addr = INADDR_ANY;
	lokalny.sin_port = htons(iPort);
	if (bind(nasluch, (sockaddr *)&lokalny, sizeof lokalny) != 0) abort;

	while (true) {
		printf("Oczekiwanie na polaczenie \n");
		listen(nasluch, SOMAXCONN);
		//CZEKAJ NA GRACZ 1
		rozmiar1 = sizeof zdalny1;

		polaczenie1 = accept(nasluch, (sockaddr *)&zdalny1, &rozmiar1);
		if (polaczenie1 == INVALID_SOCKET) abort();

		printf("Zaakceptowane polaczenie o adresie: %s i porcie: %d - GRACZ 1\n\n", inet_ntoa(zdalny1.sin_addr), ntohs(zdalny1.sin_port));
		//Poczekaj na drugiego gracza
		Sleep(100);

		//CZEKAJ NA GRACZ 2
		rozmiar2 = sizeof zdalny2;

		polaczenie2 = accept(nasluch, (sockaddr *)&zdalny2, &rozmiar2);
		if (polaczenie2 == INVALID_SOCKET) abort();

		printf("Zaakceptowane polaczenie o adresie: %s i porcie: %d - GRACZ 2\n\n", inet_ntoa(zdalny2.sin_addr), ntohs(zdalny2.sin_port));

		////////////////////////////////////////////--KOD DLA TWORZENIA WATKA--\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

		//int biezacy = 1;
		HANDLE watek; // uchwyt watka
		//DWORD dane = 
		Game nowa = Game(polaczenie1, polaczenie2); // dane wejsciowe dla funkcji watka
		DWORD ident; // identyfikator liczbowy watka

					 // utworzenie watka roboczego w procesie programu:
		watek = CreateThread(NULL, // wskaznik do rekordu z atrybutami opisujacymi bezpieczenstwo watka
			0, // rozmiar prywatnego stosu watka lub zero dla rozmiaru domyslnego
			KolkoKrzyzk, // procedura (funkcja) wykonywana w ramach watka
			//(&polaczenie1,&polaczenie2), // wskaznik do wejsciowych danych przekazywanych procedurze lub NULL, gdy nieuzywane
			&nowa,
			CREATE_SUSPENDED, // flagi stanu poczatkowego watka, np. CREATE_SUSPENDED daje watek zawieszony, zero daje watek od razu wykonywany 
			&ident // identyfikator nowego watka przekazany przez system lub NULL, gdy nieuzywane
		);
		///////////////////////////////////////////////--------------------------\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\



		watki.push_back(watek);
		ResumeThread(watek); // dopiero od tego punktu watek bedzie wykonywany
		Sleep(100);
	}

	shutdown(nasluch, SD_BOTH);
	closesocket(nasluch);
	if (WSACleanup() != 0) abort;

	printf("\n\nKoniec programu.\n");
	cin.ignore(2);
	return 0;


}