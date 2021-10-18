using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
namespace ServerStObr
{
    class Program
    {
        public static void Send(string msg)
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
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine(msg.ToString());
            
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
            Console.WriteLine(msg.ToString());
            return msg;

        }
        static void Main(string[] args)
        {
            string usernamekey = null;
            string connectionString = null;
            SqlConnection con;
            SqlCommand cmd;
            string sql;
            try
            {
                connectionString = null;
                connectionString = "Server= DESKTOP-623IG2E\\SQLEXPRESS; Database=Lica; Integrated Security=True;";
                con = new SqlConnection(connectionString);
                con.Open();
                sql = "CREATE TABLE UsersLogin" +
 "(Ime CHAR(255),Prezime CHAR(255), KorisnickoIme CHAR(255)PRIMARY KEY,Lozinka CHAR(255),Univerzitet CHAR(255),"
                + "MaticenBroj CHAR(255),TransakciskaSmetka CHAR(255))";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            connectionString= "Server= DESKTOP-623IG2E\\SQLEXPRESS; Database=Lica; Integrated Security=True;";
            con = new SqlConnection(connectionString);
            con.Open();
            while (true)
            {
                string poraka = null;
                try
                {
                    poraka = Accept();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                if (poraka == "register")
                {
                    string ime = Accept();
                    string prezime = Accept();
                    string korisnickoIme = Accept();
                    string lozinka = Accept();
                    string univerzitet = Accept();
                    string maticenBroj = Accept();
                    string transakciska = Accept();

                    sql = "SELECT count(*) as IsExists FROM dbo.sysobjects where UserName = object_UserName('UsersLogin')";
                    cmd = new SqlCommand(sql, con);
                    try
                    {
                        cmd.CommandText = @"INSERT INTO UsersLogin(Ime, Prezime, KorisnickoIme, Lozinka, Univerzitet, MaticenBroj, TransakciskaSmetka) VALUES (@ime, @prezime, @korisnickoIme, @lozinka, @univerzitet, @maticenBroj, @transakciska)";
                        cmd.Parameters.AddWithValue("@ime", ime);
                        cmd.Parameters.AddWithValue("@prezime", prezime);
                        cmd.Parameters.AddWithValue("@korisnickoIme", korisnickoIme);
                        cmd.Parameters.AddWithValue("@lozinka", lozinka);
                        cmd.Parameters.AddWithValue("@univerzitet", univerzitet);
                        cmd.Parameters.AddWithValue("@maticenBroj", maticenBroj);
                        cmd.Parameters.AddWithValue("@transakciska", transakciska);
                        cmd.ExecuteNonQuery();
                        Send("success");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        Send("failure");
                    }

                }
                if (poraka == "login")
                {
                    List<string> usernames = new List<string>();
                    List<string> passwords = new List<string>();
                    
                    sql = "SELECT KorisnickoIme, Lozinka FROM UsersLogin";
                    cmd = new SqlCommand(sql, con);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        string usr = dataReader.GetValue(0).ToString();
                        string psw = dataReader.GetValue(1).ToString();
                        usernames.Add(Regex.Replace(usr, @"\s", ""));
                        passwords.Add(Regex.Replace(psw, @"\s", ""));
                    }
                    dataReader.Close();
                    string username = Accept();
                    usernamekey = username;
                    username = Regex.Replace(username, @"\s", "");
                    string password = Accept();
                    password = Regex.Replace(password, @"\s", "");
                    if (usernames.IndexOf(username) > -1)
                    {
                        if (usernames.IndexOf(username) == passwords.IndexOf(password))
                        {
                            Send("success");
                        }
                        else
                            Send("failure");
                    }
                    else
                        Send("noregister");
                }

            }
        }
    }
}
