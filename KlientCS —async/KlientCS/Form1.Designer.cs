namespace KlientCS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbIP = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btNo = new System.Windows.Forms.Button();
            this.btYes = new System.Windows.Forms.Button();
            this.lbData = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.pbDiag2 = new System.Windows.Forms.PictureBox();
            this.pbDiag1 = new System.Windows.Forms.PictureBox();
            this.pbHor = new System.Windows.Forms.PictureBox();
            this.pbVert = new System.Windows.Forms.PictureBox();
            this.lbMove = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiag2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiag1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVert)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lbInfo);
            this.panel1.Controls.Add(this.lbPort);
            this.panel1.Controls.Add(this.lbIP);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btConnect);
            this.panel1.Location = new System.Drawing.Point(12, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 181);
            this.panel1.TabIndex = 0;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(15, 7);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(218, 30);
            this.lbInfo.TabIndex = 4;
            this.lbInfo.Text = "Kółko Krzyżyk";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPort.Location = new System.Drawing.Point(17, 90);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(45, 17);
            this.lbPort.TabIndex = 3;
            this.lbPort.Text = "Port";
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIP.Location = new System.Drawing.Point(17, 50);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(66, 17);
            this.lbIP.TabIndex = 3;
            this.lbIP.Text = "Adres IP";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btConnect
            // 
            this.btConnect.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConnect.FlatAppearance.BorderSize = 0;
            this.btConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConnect.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnect.Location = new System.Drawing.Point(86, 120);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(113, 43);
            this.btConnect.TabIndex = 0;
            this.btConnect.Text = "Połącz";
            this.btConnect.UseVisualStyleBackColor = false;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbMove);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bt3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bt8);
            this.panel2.Controls.Add(this.bt5);
            this.panel2.Controls.Add(this.bt2);
            this.panel2.Controls.Add(this.bt7);
            this.panel2.Controls.Add(this.bt4);
            this.panel2.Controls.Add(this.bt1);
            this.panel2.Controls.Add(this.bt6);
            this.panel2.Controls.Add(this.bt0);
            this.panel2.Controls.Add(this.pbVert);
            this.panel2.Controls.Add(this.pbHor);
            this.panel2.Controls.Add(this.pbDiag2);
            this.panel2.Controls.Add(this.pbDiag1);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(395, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 671);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btNo);
            this.panel3.Controls.Add(this.btYes);
            this.panel3.Controls.Add(this.lbData);
            this.panel3.Location = new System.Drawing.Point(262, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 83);
            this.panel3.TabIndex = 2;
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Transparent;
            this.btNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNo.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNo.Location = new System.Drawing.Point(166, 49);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(80, 32);
            this.btNo.TabIndex = 7;
            this.btNo.Text = "Nie";
            this.btNo.UseVisualStyleBackColor = false;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // btYes
            // 
            this.btYes.BackColor = System.Drawing.Color.Transparent;
            this.btYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btYes.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btYes.Location = new System.Drawing.Point(0, 49);
            this.btYes.Name = "btYes";
            this.btYes.Size = new System.Drawing.Size(80, 32);
            this.btYes.TabIndex = 6;
            this.btYes.Text = "Tak";
            this.btYes.UseVisualStyleBackColor = false;
            this.btYes.Click += new System.EventHandler(this.btYes_Click);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.BackColor = System.Drawing.Color.Transparent;
            this.lbData.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(3, 3);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(70, 23);
            this.lbData.TabIndex = 5;
            this.lbData.Text = "Wygrałeś";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(-4, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(875, 35);
            this.label4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(-1, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(860, 35);
            this.label3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(503, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 669);
            this.label2.TabIndex = 2;
            // 
            // bt3
            // 
            this.bt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt3.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold);
            this.bt3.ForeColor = System.Drawing.Color.White;
            this.bt3.Location = new System.Drawing.Point(143, 265);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(135, 98);
            this.bt3.TabIndex = 0;
            this.bt3.Tag = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(296, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 671);
            this.label1.TabIndex = 1;
            // 
            // bt8
            // 
            this.bt8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt8.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold);
            this.bt8.ForeColor = System.Drawing.Color.White;
            this.bt8.Location = new System.Drawing.Point(558, 447);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(135, 98);
            this.bt8.TabIndex = 0;
            this.bt8.Tag = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt5
            // 
            this.bt5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt5.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold);
            this.bt5.ForeColor = System.Drawing.Color.White;
            this.bt5.Location = new System.Drawing.Point(558, 265);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(135, 98);
            this.bt5.TabIndex = 0;
            this.bt5.Tag = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt2
            // 
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt2.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold);
            this.bt2.ForeColor = System.Drawing.Color.White;
            this.bt2.Location = new System.Drawing.Point(558, 94);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(135, 98);
            this.bt2.TabIndex = 0;
            this.bt2.Tag = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt7
            // 
            this.bt7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt7.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold);
            this.bt7.ForeColor = System.Drawing.Color.White;
            this.bt7.Location = new System.Drawing.Point(352, 446);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(135, 98);
            this.bt7.TabIndex = 0;
            this.bt7.Tag = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt4
            // 
            this.bt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt4.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold);
            this.bt4.ForeColor = System.Drawing.Color.White;
            this.bt4.Location = new System.Drawing.Point(352, 264);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(135, 98);
            this.bt4.TabIndex = 0;
            this.bt4.Tag = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt1
            // 
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold);
            this.bt1.ForeColor = System.Drawing.Color.White;
            this.bt1.Location = new System.Drawing.Point(352, 92);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(135, 98);
            this.bt1.TabIndex = 0;
            this.bt1.Tag = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt6
            // 
            this.bt6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt6.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold);
            this.bt6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt6.Location = new System.Drawing.Point(143, 447);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(135, 98);
            this.bt6.TabIndex = 0;
            this.bt6.Tag = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt0
            // 
            this.bt0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt0.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.ForeColor = System.Drawing.Color.White;
            this.bt0.Location = new System.Drawing.Point(143, 94);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(135, 89);
            this.bt0.TabIndex = 0;
            this.bt0.Tag = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt_Click);
            // 
            // pbDiag2
            // 
            this.pbDiag2.Image = ((System.Drawing.Image)(resources.GetObject("pbDiag2.Image")));
            this.pbDiag2.Location = new System.Drawing.Point(216, 139);
            this.pbDiag2.Name = "pbDiag2";
            this.pbDiag2.Size = new System.Drawing.Size(477, 433);
            this.pbDiag2.TabIndex = 6;
            this.pbDiag2.TabStop = false;
            this.pbDiag2.Visible = false;
            // 
            // pbDiag1
            // 
            this.pbDiag1.Image = ((System.Drawing.Image)(resources.GetObject("pbDiag1.Image")));
            this.pbDiag1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbDiag1.InitialImage")));
            this.pbDiag1.Location = new System.Drawing.Point(250, 146);
            this.pbDiag1.Name = "pbDiag1";
            this.pbDiag1.Size = new System.Drawing.Size(388, 387);
            this.pbDiag1.TabIndex = 5;
            this.pbDiag1.TabStop = false;
            this.pbDiag1.Visible = false;
            // 
            // pbHor
            // 
            this.pbHor.Image = ((System.Drawing.Image)(resources.GetObject("pbHor.Image")));
            this.pbHor.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbHor.InitialImage")));
            this.pbHor.Location = new System.Drawing.Point(133, -187);
            this.pbHor.Name = "pbHor";
            this.pbHor.Size = new System.Drawing.Size(550, 584);
            this.pbHor.TabIndex = 7;
            this.pbHor.TabStop = false;
            // 
            // pbVert
            // 
            this.pbVert.Image = ((System.Drawing.Image)(resources.GetObject("pbVert.Image")));
            this.pbVert.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbVert.InitialImage")));
            this.pbVert.Location = new System.Drawing.Point(185, 146);
            this.pbVert.Name = "pbVert";
            this.pbVert.Size = new System.Drawing.Size(137, 362);
            this.pbVert.TabIndex = 8;
            this.pbVert.TabStop = false;
            // 
            // lbMove
            // 
            this.lbMove.AutoSize = true;
            this.lbMove.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbMove.Location = new System.Drawing.Point(0, 0);
            this.lbMove.Name = "lbMove";
            this.lbMove.Size = new System.Drawing.Size(138, 37);
            this.lbMove.TabIndex = 9;
            this.lbMove.Text = "Twoja Tura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 716);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Kołko Krzyżyk - The Video Game";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiag2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiag1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button btYes;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.PictureBox pbDiag2;
        private System.Windows.Forms.PictureBox pbDiag1;
        private System.Windows.Forms.PictureBox pbHor;
        private System.Windows.Forms.PictureBox pbVert;
        private System.Windows.Forms.Label lbMove;
    }
}

