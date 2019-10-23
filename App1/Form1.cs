using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace App1
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public String TextToSend;
        public Form1()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    tbxSvIP.Text = address.ToString();
                }
            }

        }

        private void BtnSvStart_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(tbxSvPort.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;

            bgw1.RunWorkerAsync();
            bgw2.WorkerSupportsCancellation = true;
        }

        private void BtnClConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(tbxClIP.Text), int.Parse(tbxClPort.Text));

            try
            {
                client.Connect(IpEnd);

                if (client.Connected)
                {
                    tbxChat.AppendText("Sunucuya bağlanıldı" + "\n", Color.Red, FontStyle.Bold);
                    STW = new StreamWriter(client.GetStream());
                    STR = new StreamReader(client.GetStream());
                    STW.AutoFlush = true;
                    bgw1.RunWorkerAsync();
                    bgw2.WorkerSupportsCancellation = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Bgw1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recieve = STR.ReadLine();
                    this.tbxChat.Invoke(new MethodInvoker(delegate ()
                        {
                            tbxChat.AppendText("Diğer kişi: ", Color.Green, FontStyle.Bold);
                            tbxChat.AppendText(recieve + "\n");
                        }));
                    recieve = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Bgw2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(TextToSend);
                this.tbxChat.Invoke(new MethodInvoker(delegate ()
                {
                    tbxChat.AppendText("Ben: ", Color.Blue, FontStyle.Bold);
                    tbxChat.AppendText(TextToSend + "\n");
                }));
            }
            else
            {
                MessageBox.Show("Gönderilemedi.");
            }
            bgw2.CancelAsync();
        }


        private void BtnSendMsg_Click(object sender, EventArgs e)
        {
            if (tbxMsg.Text != "")
            {
                TextToSend = tbxMsg.Text;
                bgw2.RunWorkerAsync();
            }
            tbxMsg.Text = "";
        }
    }
}
