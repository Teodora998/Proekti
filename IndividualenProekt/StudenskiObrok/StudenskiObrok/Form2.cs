using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace StudenskiObrok
{
    public partial class Form2 : Form
    {
        public Form2()
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
                Console.WriteLine(ex.ToString());
            }
            client = server.AcceptTcpClient();
            byte[] receiverdBuffer = new byte[1024];
            NetworkStream stream = client.GetStream();
            stream.Read(receiverdBuffer, 0, receiverdBuffer.Length);
            int count = Array.IndexOf<byte>(receiverdBuffer, 0, 0);

            string msg = Encoding.ASCII.GetString(receiverdBuffer, 0, count);
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
                stream.Write(sendData, 0 ,sendData.Length);
                client.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> registrirani = new List<string>();
            registrirani.Add(textBox1.Text);
            registrirani.Add(textBox2.Text);
            registrirani.Add(textBox3.Text);
            registrirani.Add(textBox4.Text);
            registrirani.Add(textBox5.Text);
            registrirani.Add(textBox6.Text);
            registrirani.Add(textBox7.Text);
            Send("register");
            foreach(string str in registrirani)
            {
                Send(str);
            }
            
            string message = Accept();
            if (message == "success")
            {
                MessageBox.Show("Успешно се регистриравте!");
                Close();
            }
            else
            {
                MessageBox.Show("Корисничкото име веќе постои. Направете промена!");

            }
        }
    }
}
