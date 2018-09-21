namespace TCPIPClient
{
    partial class frmClient
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
            this.components = new System.ComponentModel.Container();
            this.imageListStatusLights = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxServerListeningPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStatusInfo = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.buttonConnectToServer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Clear_Rx_Btn = new System.Windows.Forms.Button();
            this.Clear_Tx_Btn = new System.Windows.Forms.Button();
            this.Rx_Txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tx_Txt = new System.Windows.Forms.TextBox();
            this.buttonSendDataToServer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Target_Position_Txt = new System.Windows.Forms.TextBox();
            this.Current_Position_Txt = new System.Windows.Forms.TextBox();
            this.Target_Speed_Txt = new System.Windows.Forms.TextBox();
            this.Current_Speed_Txt = new System.Windows.Forms.TextBox();
            this.Move_Motor_Btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListStatusLights
            // 
            this.imageListStatusLights.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListStatusLights.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListStatusLights.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxServerListeningPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxClientName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelStatusInfo);
            this.groupBox1.Controls.Add(this.textBoxServer);
            this.groupBox1.Controls.Add(this.buttonConnectToServer);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 149);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(170, 89);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 21);
            this.buttonDisconnect.TabIndex = 19;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(53, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 22);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "Server\'s Listening Port:";
            // 
            // textBoxServerListeningPort
            // 
            this.textBoxServerListeningPort.Location = new System.Drawing.Point(132, 60);
            this.textBoxServerListeningPort.Name = "textBoxServerListeningPort";
            this.textBoxServerListeningPort.Size = new System.Drawing.Size(50, 19);
            this.textBoxServerListeningPort.TabIndex = 16;
            this.textBoxServerListeningPort.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "Client Name";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(227, 40);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(100, 19);
            this.textBoxClientName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "Address to the Server(name or IP)";
            // 
            // labelStatusInfo
            // 
            this.labelStatusInfo.AutoSize = true;
            this.labelStatusInfo.Location = new System.Drawing.Point(130, 126);
            this.labelStatusInfo.Name = "labelStatusInfo";
            this.labelStatusInfo.Size = new System.Drawing.Size(172, 12);
            this.labelStatusInfo.TabIndex = 12;
            this.labelStatusInfo.Text = "Click \'Connect to Server\'  button";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(9, 39);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(173, 19);
            this.textBoxServer.TabIndex = 11;
            this.textBoxServer.Text = "192.168.1.10";
            // 
            // buttonConnectToServer
            // 
            this.buttonConnectToServer.Location = new System.Drawing.Point(9, 89);
            this.buttonConnectToServer.Name = "buttonConnectToServer";
            this.buttonConnectToServer.Size = new System.Drawing.Size(149, 21);
            this.buttonConnectToServer.TabIndex = 10;
            this.buttonConnectToServer.Text = "Connect To Server";
            this.buttonConnectToServer.UseVisualStyleBackColor = true;
            this.buttonConnectToServer.Click += new System.EventHandler(this.buttonConnectToServer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Clear_Rx_Btn);
            this.groupBox2.Controls.Add(this.Clear_Tx_Btn);
            this.groupBox2.Controls.Add(this.Rx_Txt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Tx_Txt);
            this.groupBox2.Controls.Add(this.buttonSendDataToServer);
            this.groupBox2.Location = new System.Drawing.Point(375, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(817, 374);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication";
            // 
            // Clear_Rx_Btn
            // 
            this.Clear_Rx_Btn.Location = new System.Drawing.Point(458, 336);
            this.Clear_Rx_Btn.Name = "Clear_Rx_Btn";
            this.Clear_Rx_Btn.Size = new System.Drawing.Size(75, 23);
            this.Clear_Rx_Btn.TabIndex = 28;
            this.Clear_Rx_Btn.Text = "Clear";
            this.Clear_Rx_Btn.UseVisualStyleBackColor = true;
            this.Clear_Rx_Btn.Click += new System.EventHandler(this.Clear_Rx_Btn_Click);
            // 
            // Clear_Tx_Btn
            // 
            this.Clear_Tx_Btn.Location = new System.Drawing.Point(99, 336);
            this.Clear_Tx_Btn.Name = "Clear_Tx_Btn";
            this.Clear_Tx_Btn.Size = new System.Drawing.Size(75, 23);
            this.Clear_Tx_Btn.TabIndex = 27;
            this.Clear_Tx_Btn.Text = "Clear";
            this.Clear_Tx_Btn.UseVisualStyleBackColor = true;
            this.Clear_Tx_Btn.Click += new System.EventHandler(this.Clear_Tx_Btn_Click);
            // 
            // Rx_Txt
            // 
            this.Rx_Txt.Location = new System.Drawing.Point(358, 54);
            this.Rx_Txt.Multiline = true;
            this.Rx_Txt.Name = "Rx_Txt";
            this.Rx_Txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Rx_Txt.Size = new System.Drawing.Size(333, 277);
            this.Rx_Txt.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "Text to send:";
            // 
            // Tx_Txt
            // 
            this.Tx_Txt.Location = new System.Drawing.Point(13, 54);
            this.Tx_Txt.Multiline = true;
            this.Tx_Txt.Name = "Tx_Txt";
            this.Tx_Txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Tx_Txt.Size = new System.Drawing.Size(323, 276);
            this.Tx_Txt.TabIndex = 20;
            // 
            // buttonSendDataToServer
            // 
            this.buttonSendDataToServer.Enabled = false;
            this.buttonSendDataToServer.Location = new System.Drawing.Point(13, 28);
            this.buttonSendDataToServer.Name = "buttonSendDataToServer";
            this.buttonSendDataToServer.Size = new System.Drawing.Size(185, 21);
            this.buttonSendDataToServer.TabIndex = 19;
            this.buttonSendDataToServer.Text = "Send Data To Server";
            this.buttonSendDataToServer.UseVisualStyleBackColor = true;
            this.buttonSendDataToServer.Click += new System.EventHandler(this.buttonSendDataToServer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Move_Motor_Btn);
            this.groupBox3.Controls.Add(this.Current_Speed_Txt);
            this.groupBox3.Controls.Add(this.Target_Speed_Txt);
            this.groupBox3.Controls.Add(this.Current_Position_Txt);
            this.groupBox3.Controls.Add(this.Target_Position_Txt);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 199);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motor Control";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Target Position";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "Current Position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "Target Speed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(122, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "Current Speed";
            // 
            // Target_Position_Txt
            // 
            this.Target_Position_Txt.Location = new System.Drawing.Point(11, 43);
            this.Target_Position_Txt.Name = "Target_Position_Txt";
            this.Target_Position_Txt.Size = new System.Drawing.Size(100, 19);
            this.Target_Position_Txt.TabIndex = 4;
            this.Target_Position_Txt.Text = "90.23";
            // 
            // Current_Position_Txt
            // 
            this.Current_Position_Txt.Location = new System.Drawing.Point(122, 43);
            this.Current_Position_Txt.Name = "Current_Position_Txt";
            this.Current_Position_Txt.Size = new System.Drawing.Size(100, 19);
            this.Current_Position_Txt.TabIndex = 5;
            // 
            // Target_Speed_Txt
            // 
            this.Target_Speed_Txt.Location = new System.Drawing.Point(9, 97);
            this.Target_Speed_Txt.Name = "Target_Speed_Txt";
            this.Target_Speed_Txt.Size = new System.Drawing.Size(100, 19);
            this.Target_Speed_Txt.TabIndex = 6;
            this.Target_Speed_Txt.Text = "20.6";
            // 
            // Current_Speed_Txt
            // 
            this.Current_Speed_Txt.Location = new System.Drawing.Point(122, 97);
            this.Current_Speed_Txt.Name = "Current_Speed_Txt";
            this.Current_Speed_Txt.Size = new System.Drawing.Size(100, 19);
            this.Current_Speed_Txt.TabIndex = 7;
            // 
            // Move_Motor_Btn
            // 
            this.Move_Motor_Btn.Location = new System.Drawing.Point(73, 136);
            this.Move_Motor_Btn.Name = "Move_Motor_Btn";
            this.Move_Motor_Btn.Size = new System.Drawing.Size(75, 23);
            this.Move_Motor_Btn.TabIndex = 8;
            this.Move_Motor_Btn.Text = "Move";
            this.Move_Motor_Btn.UseVisualStyleBackColor = true;
            this.Move_Motor_Btn.Click += new System.EventHandler(this.Move_Motor_Btn_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 411);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmClient";
            this.Text = "TCPIP Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClient_FormClosing);
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageListStatusLights;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxServerListeningPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStatusInfo;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Button buttonConnectToServer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Clear_Rx_Btn;
        private System.Windows.Forms.Button Clear_Tx_Btn;
        private System.Windows.Forms.TextBox Rx_Txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tx_Txt;
        private System.Windows.Forms.Button buttonSendDataToServer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Move_Motor_Btn;
        private System.Windows.Forms.TextBox Current_Speed_Txt;
        private System.Windows.Forms.TextBox Target_Speed_Txt;
        private System.Windows.Forms.TextBox Current_Position_Txt;
        private System.Windows.Forms.TextBox Target_Position_Txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

