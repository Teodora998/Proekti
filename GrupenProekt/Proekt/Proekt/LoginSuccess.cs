using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text.RegularExpressions;

namespace Proekt
{
    public partial class LoginSuccess : Form
    {
        
        public static string Accept()
        {
            IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
            TcpListener server = new TcpListener(ip, 8085);
            TcpClient client = default(TcpClient);
            try
            {
                server.Start();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
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
                // Console.WriteLine("Vnesete string koj sakte da bide ispraten");
                string str = msg;
                int byteCount = Encoding.ASCII.GetByteCount(str);
                byte[] sendData = Encoding.ASCII.GetBytes(str);

                //sendData = new byte[byteCount];

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
        public int podatoci()
        {
            int razlika = 20;
            Send("dashboard");
            textBoxIme.Text = Regex.Replace(Accept(), @"\s", "");
            textBoxPrezime.Text = Regex.Replace(Accept(), @"\s", "");
            textBoxMB.Text = Regex.Replace(Accept(), @"\s", "");
            textBoxAdresa.Text = Regex.Replace(Accept(), @"\s", "");
            textBoxGrad.Text = Regex.Replace(Accept(), @"\s", "");
            textBoxGodini.Text = Regex.Replace(Accept(), @"\s", "");
            label10.Text = Accept();
            label11.Text = Accept();
            
            if (label10.Text.Length < 5 && label11.Text.Length < 5)
            {
                label10.Text = "Не сте пријавени за вакцина";
                label11.Text = "Не сте пријавени за вакцина";
            }
            else
            {
                DateTime pd = new DateTime();
                DateTime vd = new DateTime();
                DateTime.TryParse(label10.Text, out pd);
                DateTime.TryParse(label11.Text, out vd);
                if (pd < DateTime.Today)
                {
                    label10.Text = "Примена ви е првата доза";
                }
                if (vd < DateTime.Today)
                {
                    label11.Text = "Примена ви е втората доза";
                }
            }
            string poraka = Regex.Replace(Accept(), @"\s", "");
            if (poraka == "karantin")
            {

                DateTime denesenden = DateTime.Today;
                string datum = Accept();
                DateTime dk = new DateTime();
                DateTime.TryParse(datum, out dk);
                dk = dk.AddDays(14);
                razlika = (dk - denesenden).Days;
                if (razlika <= 0)
                {
                    Send("zavrsikarantin");
                }
                else
                {
                    Send("ustetrae");
                }

            }
            if(poraka=="nemakarantin")
            {
                Send("ustetrae");
            }
            return razlika;
        }
        public LoginSuccess()
        {
            InitializeComponent();
        }
        private void LoginSuccess_Shown(object sender, EventArgs e)
        {
            
        }
        private void LoginSuccess_Load(object sender, EventArgs e)
        {
            Show();
            int razlika=podatoci();
            if(razlika==20)
            {

            }
            else
            {
                if (razlika <= 0)
                {
                    MessageBox.Show("Вашиот карантин заврши. Слободни сте!");
                }
                else
                {
                    MessageBox.Show("Имате уште " + razlika + " дена.");
                }
            }
            Send("proveridozi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label10.Text == "Примена ви е првата доза")
            {
                if (label11.Text == "Примена ви е втората доза")
                {
                    MessageBox.Show("Вие веќе сте ја примиле првата и втората доза и не можи да се пријавите за вакцина уште еднаш!");
                }
                else
                    MessageBox.Show("Вие веќе сте ја примиле првата доза и не можи да се пријавите за вакцина уште еднаш!");
            }
            else
            {
                Send("proverkavakcina");
                int milliseconds = 1000;
                Thread.Sleep(milliseconds);
                string message = Accept();
                if (message == "success")
                {
                    PrijavaVakcina obj = new PrijavaVakcina();
                    obj.Show();
                }
                else
                    MessageBox.Show("Вие сте веќе пријавени за вакцина.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (label11.Text == "Примена ви е втората доза")
            {
                MessageBox.Show("Вие веќе сте ја примиле првата и втората доза и нема потреба да бидите во карантин бидејќи сте веќе имунизирани од COVID-19!");
            }
            else
            {
                PrijavaKarantin obj = new PrijavaKarantin();
                obj.Show();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (label10.Text == "Примена ви е првата доза")
            {
                if (label11.Text == "Примена ви е втората доза")
                {
                    MessageBox.Show("Вие веќе сте ја примиле првата и втората доза и нема која резервација да ја откажете за вакцина!");
                }
                else
                    MessageBox.Show("Вие веќе сте ја примиле првата доза и не можи да ја откажете резервацијата за втората доза!");
            }
            else
            {
                OtkaziVakcina obj = new OtkaziVakcina();
                obj.Show();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Send("logout");
            Hide();
            Form1 obj = new Form1();
            obj.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Send("refresh");
            textBoxIme.Text = Regex.Replace(Accept(), @"\s", "");
            textBoxPrezime.Text = Regex.Replace(Accept(), @"\s", "");
            textBoxMB.Text = Regex.Replace(Accept(), @"\s", "");
            textBoxAdresa.Text = Regex.Replace(Accept(), @"\s", "");
            textBoxGrad.Text = Regex.Replace(Accept(), @"\s", "");
            textBoxGodini.Text = Regex.Replace(Accept(), @"\s", "");
            label10.Text = Accept();
            label11.Text = Accept();

            if (label10.Text.Length < 5 && label11.Text.Length < 5)
            {
                label10.Text = "Не сте пријавени за вакцина";
                label11.Text = "Не сте пријавени за вакцина";
            }
            else
            {
                DateTime pd = new DateTime();
                DateTime vd = new DateTime();
                DateTime.TryParse(label10.Text, out pd);
                DateTime.TryParse(label11.Text, out vd);
                if (pd < DateTime.Today)
                {
                    label10.Text = "Примена ви е првата доза";
                }
                if (vd < DateTime.Today)
                {
                    label11.Text = "Примена ви е втората доза";
                }
            }
        }
    }
}
