using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace KlientCS
{
    public partial class Form1 : Form
    {
        //obiekt klasy rezlizujący połączenie
        public GetSocket client = new GetSocket();

        //Znak używany przez gamecza O lub X
        private string playerSign;

        //Znak używany przez drugiego gamecza O lub X
        private string enemySign;

        //Kod otrzymany z serwera
        private int code;

        //Tablica przycisków do gry
        private Button[] buttonList;

        //Blokada klawiszy
        private bool lockButtons = false;

        //tablica opisująca kombinacje 1-gamecz 2-wróg
        private int[] game = new int[9];

        //Czy czekać na dane z serwera
        private bool isWin = false;

        public Form1()
        {
            InitializeComponent();
            buttonList = new Button[] { bt0, bt1, bt2, bt3, bt4, bt5, bt5, bt6, bt7, bt8 };
            panel1.Location = new Point(0, 0);
            panel2.Location = new Point(0, 0);
            this.CenterToScreen();
            BeginNewGame();
        }


        private void DrawEndLine()
        {
            foreach (Button bt in buttonList)
            {
                int number = Convert.ToInt32(bt.Tag);
                if (bt.Text == playerSign)
                {
                    game[number] = 1;
                }
                if (bt.Text == enemySign)
                {
                    game[number] = 2;
                }
            }
            CheckAndDraw();
        }

        private void CheckAndDraw()
        {
            Point p;
            //POZIOMO
            if (game[0] == game[1] && game[1] == game[2])
            {
                if (game[0] == 1 || game[0] == 2)
                {
                    p = buttonList[0].Location;
                    p.Y = -187;
                    pbHor.BeginInvoke(new MethodInvoker(() =>
                    {
                        pbHor.Location = p;
                        pbHor.Visible = true;
                    }));
                }
            }
            if (game[3] == game[4] && game[4] == game[5])
            {
                if (game[3] == 1 || game[3] == 2)
                {
                    p = buttonList[3].Location;
                    p.Y = p.Y - 275;
                    pbHor.BeginInvoke(new MethodInvoker(() =>
                    {
                        pbHor.Location = p;
                        pbHor.Visible = true;
                    }));
                }
            }
            if (game[6] == game[7] && game[7] == game[8])
            {
                if (game[6] == 1 || game[6] == 2)
                {
                    p = buttonList[6].Location;
                    p.Y = p.Y - 100;
                    p.X = p.X - 420;
                    pbHor.BeginInvoke(new MethodInvoker(() =>
                    {
                        pbHor.Location = p;
                        pbHor.Visible = true;
                    }));
                }
            }
            //PIONOWO
            if (game[0] == game[3] && game[3] == game[6])
            {
                if (game[0] == 1 || game[0] == 2)
                {
                    p = buttonList[0].Location;
                    p.X = p.X + 50;
                    pbVert.BeginInvoke(new MethodInvoker(() =>
                    {
                        pbVert.Location = p;
                        pbVert.Visible = true;
                    }));
                }
            }
            if (game[1] == game[4] && game[4] == game[7])
            {
                if (game[1] == 1 || game[1] == 2)
                {
                    p = buttonList[1].Location;
                    p.X = p.X + 50;
                    pbVert.BeginInvoke(new MethodInvoker(() =>
                    {
                        pbVert.Location = p;
                        pbVert.Visible = true;
                    }));
                }
            }
            if (game[2] == game[5] && game[5] == game[8])
            {
                if (game[2] == 1 || game[2] == 2)
                {
                    p = buttonList[2].Location;
                    p.X = p.X + 50;
                    pbVert.BeginInvoke(new MethodInvoker(() =>
                    {
                        pbVert.Location = p;
                        pbVert.Visible = true;
                    }));
                }
            }
            //NA UKOS
            if (game[0] == game[4] && game[4] == game[8])
            {
                if (game[0] == 1 || game[0] == 2)
                {
                    pbDiag1.BeginInvoke(new MethodInvoker(() =>
                {
                    pbDiag1.Visible = true;
                }));
                }
            }
            if (game[2] == game[4] && game[4] == game[6])
            {
                if (game[2] == 1 || game[2] == 2)
                {
                    pbDiag2.BeginInvoke(new MethodInvoker(() =>
                {
                    pbDiag2.Visible = true;
                }));
                }
            }
        }

        private void IsWin()
        {
            foreach (Button bt in buttonList)
            {
                int number = Convert.ToInt32(bt.Tag);
                if (bt.Text == playerSign)
                {
                    game[number] = 1;
                }
                if (bt.Text == enemySign)
                {
                    game[number] = 2;
                }
            }
            //POZIOMO
            if (game[0] == game[1] && game[1] == game[2])
            {
                if (game[0] == 1 || game[0] == 2)
                    isWin = true;
            }
            if (game[3] == game[4] && game[4] == game[5])
            {
                if (game[3] == 1 || game[3] == 2)
                    isWin = true;
            }
            if (game[6] == game[7] && game[7] == game[8])
            {
                if (game[6] == 1 || game[6] == 2)
                    isWin = true;
            }
            //PIONOWO
            if (game[0] == game[3] && game[3] == game[6])
            {
                if (game[0] == 1 || game[0] == 2)
                    isWin = true;
            }
            if (game[1] == game[4] && game[4] == game[7])
            {
                if (game[1] == 1 || game[1] == 2)
                    isWin = true;
            }
            if (game[2] == game[5] && game[5] == game[8])
            {
                if (game[2] == 1 || game[2] == 2)
                    isWin = true;
            }
            //NA UKOS
            if (game[0] == game[4] && game[4] == game[8])
            {
                if (game[0] == 1 || game[0] == 2)
                    isWin = true;
            }
            if (game[2] == game[4] && game[4] == game[6])
            {
                if (game[2] == 1 || game[2] == 2)
                    isWin = true;
            }
        }

        private void ReciveData()
        {
            if (ValidateData(client.SocketReceive()))
            {
                //Zaznacz odpowiedznij button
                foreach (Button bt in buttonList)
                {
                    if (((string)bt.Tag).Trim() == (code + "").Trim())
                    {
                        bt.BeginInvoke(new MethodInvoker(() =>
                        {
                            bt.Text = enemySign;
                            lockButtons = false;
                        }));
                    }
                    lbMove.BeginInvoke(new MethodInvoker(() =>
                    {
                        lbMove.Text = "Twoja tura - "+playerSign;
                    }));
                }
            }
            //Koniec Gry
            else
            {
                client.SocketSend("ack");
                string message = "";
                switch (code)
                {
                    case 23: message = "Przegrałeś"; break;
                    case 24: message = "Wygrałeś"; break;
                    case 25: message = "Bez roztrzygnięcia"; break;
                }

                IsWin();
                if (isWin)
                {
                    DrawEndLine();
                    panel3.BeginInvoke(new MethodInvoker(() =>
                    {
                        panel3.Location = new Point(0, 0);
                    }));

                    panel3.BeginInvoke(new MethodInvoker(() =>
                    {
                        panel3.Visible = true;
                    }));

                    lbData.BeginInvoke(new MethodInvoker(() =>
                    {
                        lbData.Text = message + "  Nowa game?";
                    }));
                }
                else
                {
                    if (playerSign.Equals("X"))
                    {
                        if (code == 23 || code == 25)
                        {
                            
                                //Odbierz Ostatni
                                code = Int32.Parse(client.SocketReceive());
                            client.SocketSend("ack");
                            //Zaznacz odpowiedznij button
                            foreach (Button bt in buttonList)
                            {
                                if ((string)bt.Tag == (code + "").Trim())
                                {
                                    bt.BeginInvoke(new MethodInvoker(() =>
                                    {
                                        bt.Text = enemySign;
                                        DrawEndLine();
                                    }));
                                    lockButtons = true;

                                }


                                //client.DisconnectSocket();
                            }
                        }
                    }
                    if (playerSign.Equals("O"))
                    {
                        if (code == 23 || code == 25)
                        {

                            //Odbierz Ostatni
                            if(code==23)
                            code = Int32.Parse(client.SocketReceive());
                            client.SocketSend("ack");
                            //Zaznacz odpowiedznij button
                            foreach (Button bt in buttonList)
                            {
                                if ((string)bt.Tag == (code + "").Trim())
                                {
                                    bt.BeginInvoke(new MethodInvoker(() =>
                                    {
                                        bt.Text = enemySign;
                                        DrawEndLine();
                                    }));
                                    lockButtons = true;

                                }


                                //client.DisconnectSocket();
                            }
                        }

                    }

                        panel3.BeginInvoke(new MethodInvoker(() =>
                    {
                        panel3.Location = new Point(0, 0);
                    }));

                    panel3.BeginInvoke(new MethodInvoker(() =>
                    {
                        panel3.Visible = true;
                    }));

                    lbData.BeginInvoke(new MethodInvoker(() =>
                    {
                        lbData.Text = message + "  Nowa game?";
                    }));
                }
            }
        }

        private void bt_Click(object sender, EventArgs e)
        {
            if (!lockButtons)
            {
                if (((Button)sender).Text != "O" && ((Button)sender).Text != "X")
                {
                    //Zaznacz pole znakiem
                    ((Button)sender).Text = playerSign;
                    //Wyslij numer
                    client.SocketSend((string)((Button)sender).Tag);
                    lockButtons = true;
                    //Czekaj na odbior kodu gamecza 2
                    Thread oThread = new Thread(new ThreadStart(ReciveData));
                    // Start the thread
                    lbMove.Text = "Tura przeciwnika - "+enemySign;
                    oThread.Start();
                    oThread.Join();
                }
            }
        }

        private void BeginNewGame()
        {
            //Zeruj dane gry
            playerSign = "";
            enemySign = "";
            code = 0;
            lockButtons = true;
            pbDiag1.Visible = false;
            pbDiag2.Visible = false;
            pbHor.Visible = false;
            pbVert.Visible = false;
            isWin = false;
            for (int i = 0; i < game.Length; i++)
            {
                game[i] = 0;
            }
            foreach (Button bt in buttonList)
            {
                bt.Text = "";
            }
            //Pokaż odpowiednie panele
            panel1.Visible = true;
            this.Width = panel1.Width + 10;
            this.Height = panel1.Height + 35;

            panel2.Visible = false;
            panel3.Visible = false;
        }

        private bool ValidateData(string v)
        {
            //sprawdź kod
            //21-O,22-X,23-przegamena,24-wygamena,25-remis,26-game
            code = Int32.Parse(v);
            if (code > 22 && code < 26)
            {
                //Koniec gry
                return false;
            }
            //Graj dalej
            return true;
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            //Pobierz adres IP
            string ip = textBox1.Text;
            //Pobierz numer portu serwera
            Int32 port = Convert.ToInt32(textBox2.Text);
            //Połącz z serwerem
            client.ConnectSocket(ip, port);

            //Odbierz numer gamecza
            string player = client.SocketReceive();

            //Wyslij potwierdzenie otrzymania danych
            client.SocketSend("ack");
            //Potwierdź znak gamecza
            SetPlayerSign(player);
            if (playerSign == "X") lbMove.Text = "Tura przeciwnika";
            if (playerSign == "O") lbMove.Text = "Twoja tura";

            //Start Gry
            panel1.Visible = false;
            panel2.Visible = true;
            this.Width = panel2.Width;
            this.Height = panel2.Height;
            lockButtons = true;
            panel3.Location = new Point(this.Height % 2, this.Width % 2);

            Thread oThread = new Thread(new ThreadStart(this.GameBegins));
            oThread.Start();
            oThread.Join();
        }

        private void GameBegins()
        {
            //Początek rozgrywki
            code = Int32.Parse(client.SocketReceive());

            //Gracz 2
            if (code != 26)
            {
                foreach (Button bt in buttonList)
                {
                    if ((string)bt.Tag == (code + "").Trim())
                    {
                        bt.BeginInvoke(new MethodInvoker(() =>
                        {
                            bt.Text = enemySign;
                            lockButtons = false;
                        }));
                    }
                }
            }
            else
            {
                lockButtons = false;
            }
            //Gracz 1
        }

        private void SetPlayerSign(string player)
        {
            //Ustaw znak jakim posługuje się gamecz
            if (player == "21")
            {
                playerSign = "O";
                enemySign = "X";
            }
            if (player == "22")
            {
                playerSign = "X";
                enemySign = "O";
            }
        }

        private void btYes_Click(object sender, EventArgs e)
        {
            //Nowa game
            BeginNewGame();
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            //Koniec gry
            Application.Exit();
        }
    }
}