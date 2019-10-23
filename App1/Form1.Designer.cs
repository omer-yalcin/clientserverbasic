namespace App1
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
            this.tbxSvIP = new System.Windows.Forms.TextBox();
            this.tbxSvPort = new System.Windows.Forms.TextBox();
            this.tbxClIP = new System.Windows.Forms.TextBox();
            this.tbxClPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSvStart = new System.Windows.Forms.Button();
            this.btnClConnect = new System.Windows.Forms.Button();
            this.tbxChat = new System.Windows.Forms.RichTextBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.bgw1 = new System.ComponentModel.BackgroundWorker();
            this.bgw2 = new System.ComponentModel.BackgroundWorker();
            this.tbxMsg = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxSvIP
            // 
            this.tbxSvIP.Location = new System.Drawing.Point(69, 24);
            this.tbxSvIP.Name = "tbxSvIP";
            this.tbxSvIP.Size = new System.Drawing.Size(100, 20);
            this.tbxSvIP.TabIndex = 0;
            // 
            // tbxSvPort
            // 
            this.tbxSvPort.Location = new System.Drawing.Point(69, 50);
            this.tbxSvPort.Name = "tbxSvPort";
            this.tbxSvPort.Size = new System.Drawing.Size(100, 20);
            this.tbxSvPort.TabIndex = 1;
            // 
            // tbxClIP
            // 
            this.tbxClIP.Location = new System.Drawing.Point(73, 24);
            this.tbxClIP.Name = "tbxClIP";
            this.tbxClIP.Size = new System.Drawing.Size(100, 20);
            this.tbxClIP.TabIndex = 2;
            // 
            // tbxClPort
            // 
            this.tbxClPort.Location = new System.Drawing.Point(73, 50);
            this.tbxClPort.Name = "tbxClPort";
            this.tbxClPort.Size = new System.Drawing.Size(100, 20);
            this.tbxClPort.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sunucu IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "İstemci IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port";
            // 
            // btnSvStart
            // 
            this.btnSvStart.Location = new System.Drawing.Point(94, 76);
            this.btnSvStart.Name = "btnSvStart";
            this.btnSvStart.Size = new System.Drawing.Size(75, 23);
            this.btnSvStart.TabIndex = 8;
            this.btnSvStart.Text = "Başlat";
            this.btnSvStart.UseVisualStyleBackColor = true;
            this.btnSvStart.Click += new System.EventHandler(this.BtnSvStart_Click);
            // 
            // btnClConnect
            // 
            this.btnClConnect.Location = new System.Drawing.Point(98, 76);
            this.btnClConnect.Name = "btnClConnect";
            this.btnClConnect.Size = new System.Drawing.Size(75, 23);
            this.btnClConnect.TabIndex = 9;
            this.btnClConnect.Text = "Bağlan";
            this.btnClConnect.UseVisualStyleBackColor = true;
            this.btnClConnect.Click += new System.EventHandler(this.BtnClConnect_Click);
            // 
            // tbxChat
            // 
            this.tbxChat.Location = new System.Drawing.Point(12, 201);
            this.tbxChat.Name = "tbxChat";
            this.tbxChat.Size = new System.Drawing.Size(508, 197);
            this.tbxChat.TabIndex = 10;
            this.tbxChat.Text = "";
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(445, 404);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(75, 23);
            this.btnSendMsg.TabIndex = 11;
            this.btnSendMsg.Text = "Gönder";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.BtnSendMsg_Click);
            // 
            // bgw1
            // 
            this.bgw1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Bgw1_DoWork);
            // 
            // bgw2
            // 
            this.bgw2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Bgw2_DoWork);
            // 
            // tbxMsg
            // 
            this.tbxMsg.Location = new System.Drawing.Point(12, 407);
            this.tbxMsg.Name = "tbxMsg";
            this.tbxMsg.Size = new System.Drawing.Size(427, 20);
            this.tbxMsg.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxSvIP);
            this.groupBox1.Controls.Add(this.tbxSvPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSvStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 124);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sunucu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxClIP);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbxClPort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnClConnect);
            this.groupBox2.Location = new System.Drawing.Point(332, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 124);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İstemci";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxMsg);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.tbxChat);
            this.Name = "Form1";
            this.Text = "Mesajcı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSvIP;
        private System.Windows.Forms.TextBox tbxSvPort;
        private System.Windows.Forms.TextBox tbxClIP;
        private System.Windows.Forms.TextBox tbxClPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSvStart;
        private System.Windows.Forms.Button btnClConnect;
        private System.Windows.Forms.RichTextBox tbxChat;
        private System.Windows.Forms.Button btnSendMsg;
        private System.ComponentModel.BackgroundWorker bgw1;
        private System.ComponentModel.BackgroundWorker bgw2;
        private System.Windows.Forms.TextBox tbxMsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

