using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace StudenskiObrok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Accept()
        {
            IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
            TcpListener server = new TcpListener(ip, 8085);
            TcpClient client = default(TcpClient);
            try
            {
                server.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            client = server.AcceptTcpClient();
            byte[] receivedBuffer = new byte[1024];
            NetworkStream stream = client.GetStream();
            stream.Read(receivedBuffer, 0, receivedBuffer.Length);
            int count = Array.IndexOf<byte>(receivedBuffer, 0, 0);

            string msg = Encoding.ASCII.GetString(receivedBuffer, 0, count);
            byte[] sendData = Encoding.ASCII.GetBytes(msg);
            int b = sendData.Length;
            server.Stop();
            return msg;
        }
        public void Send(string msg)
        {
            try
            {
                IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
                TcpClient client = new TcpClient("localhost", 8085);
                string str = msg;
                int byteCount = Encoding.ASCII.GetByteCount(str);
                byte[] sendData = Encoding.ASCII.GetBytes(str);

                int broj = sendData.Length;
                NetworkStream stream = client.GetStream();
                stream.Write(sendData, 0, sendData.Length);
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 reg = new Form2();
            reg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            StOb lg = new StOb();
            List<string> loginitems = new List<string>();
            loginitems.Add(textBox1.Text);
            loginitems.Add(textBox2.Text);
            Send("login");
            foreach (string str in loginitems)
            {
                Send(str);
            }
            string message = Accept();
            if (message == "success")
            {
                Hide();
                MessageBox.Show("Успешна најава!");
                lg.Show();
            }
            else if (message == "failure")
            {
                MessageBox.Show("Неуспешна најава! Погрешна лозинка!");
                textBox2.Text = null;
            }
            else if (message == "noregister")
            {
                MessageBox.Show("Корисничкото име не е регистрирано!");
                textBox1.Text = null;
                textBox2.Text = null;
            }
        }
    }
}
