using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ServerAplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Ime", 100);
            listView1.Columns.Add("Prezime", 100);
            listView1.Columns.Add("Godini", 100);
            listView1.Columns.Add("MaticenBroj", 100);
            listView1.Columns.Add("Adresa", 100);
            listView1.Columns.Add("Grad", 100);
            listView1.Columns.Add("VidVakcina", 100);
            listView1.Columns.Add("PrijavenVakcina", 100);
            listView1.Columns.Add("PrijavenKarantin", 100);
            listView1.Columns.Add("DatumKarantin", 100);
            listView1.Columns.Add("DatumZaVakcina", 100);
            listView1.Columns.Add("PrimenaPD", 100);
            listView1.Columns.Add("DatumZaVtoraDoza", 100);
            listView1.Columns.Add("PrimenaVD", 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string connectionString = null;
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dataReader;
            string sql;
            connectionString = null;
            connectionString = "Server=DESKTOP-KT8CCEC\\SQLEXPRESS; Database= Licnosti; Integrated Security=True;";
            con = new SqlConnection(connectionString);
            con.Open();
            sql = "Select Ime, Prezime, Godini, MaticenBroj, Adresa, Grad,VidVakcina ,PrijavenVakcina,PrijavenKarantin,DatumKarantin,DatumZaVakcina,PrimenaPD,DatumZaVtoraDoza,PrimenaVD from UsersLogin";
            cmd = new SqlCommand(sql, con);
            dataReader = cmd.ExecuteReader();
            try
            {
                while (dataReader.Read())
                {
                    listView1.Items.Add(dataReader.GetValue(0).ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dataReader.GetValue(1).ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dataReader.GetValue(2).ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dataReader.GetValue(3).ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dataReader.GetValue(4).ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dataReader.GetValue(5).ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dataReader.GetValue(6).ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dataReader.GetValue(7).ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dataReader.GetValue(8).ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dataReader.GetValue(9).ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dataReader.GetValue(10).ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dataReader.GetValue(11).ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dataReader.GetValue(12).ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dataReader.GetValue(13).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<string> iminja = new List<string>();
            List<string> preziminja = new List<string>();
            List<string> godini = new List<string>();
            List<string> embg = new List<string>();
            List<string> adresi = new List<string>();
            List<string> gradovi = new List<string>();
            List<string> vakcina = new List<string>();
            List<string> prijavenvakcina = new List<string>();
            List<string> karantin = new List<string>();
            List<string> datumkarantin = new List<string>();
            List<string> datumvakcina = new List<string>();
            List<string> primenapd = new List<string>();
            List<string> datumvtoravakcina = new List<string>();
            List<string> primenavd = new List<string>();

            string connectionString = null;
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dataReader;
            string sql;
            connectionString = null;
            connectionString = "Server=DESKTOP-KT8CCEC\\SQLEXPRESS; Database= Licnosti; Integrated Security=True;";
            con = new SqlConnection(connectionString);
            con.Open();
            sql = "Select Ime, Prezime, Godini, MaticenBroj, Adresa, Grad, VidVakcina,PrijavenVakcina,PrijavenKarantin,DatumKarantin,DatumZaVakcina,PrimenaPD,DatumZaVtoraDoza,PrimenaVD from UsersLogin";
            cmd = new SqlCommand(sql, con);
            cmd = new SqlCommand(sql, con);
            cmd = new SqlCommand(sql, con);
            dataReader = cmd.ExecuteReader();
            try
            {
                while (dataReader.Read())
                {
                    iminja.Add(Regex.Replace(dataReader.GetValue(0).ToString(), @"\s", ""));
                    preziminja.Add(Regex.Replace(dataReader.GetValue(1).ToString(), @"\s", ""));
                    godini.Add(Regex.Replace(dataReader.GetValue(2).ToString(), @"\s", ""));
                    embg.Add(Regex.Replace(dataReader.GetValue(3).ToString(), @"\s", ""));
                    adresi.Add(Regex.Replace(dataReader.GetValue(4).ToString(), @"\s", ""));
                    gradovi.Add(Regex.Replace(dataReader.GetValue(5).ToString(), @"\s", ""));
                    vakcina.Add(Regex.Replace(dataReader.GetValue(6).ToString(), @"\s", ""));
                    prijavenvakcina.Add(Regex.Replace(dataReader.GetValue(7).ToString(), @"\s", ""));
                    karantin.Add(Regex.Replace(dataReader.GetValue(8).ToString(), @"\s", ""));
                    datumkarantin.Add(Regex.Replace(dataReader.GetValue(9).ToString(), @"\s", ""));
                    datumvakcina.Add(Regex.Replace(dataReader.GetValue(10).ToString(), @"\s", ""));
                    primenapd.Add(Regex.Replace(dataReader.GetValue(11).ToString(), @"\s", ""));
                    datumvtoravakcina.Add(Regex.Replace(dataReader.GetValue(12).ToString(), @"\s", ""));
                    primenavd.Add(Regex.Replace(dataReader.GetValue(13).ToString(), @"\s", ""));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //IMINJA
            if (radioButton1.Checked == true)
            {
                string sortkey = textBox1.Text;
                int indeks = iminja.IndexOf(sortkey);
                if (indeks > -1)
                {
                    listView1.Items.Clear();
                    for (int i = indeks; i < iminja.Count; i++)
                    {
                        if (iminja[i] == sortkey)
                        {
                            listView1.Items.Add(iminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(preziminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(godini[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(embg[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(adresi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(gradovi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(vakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(prijavenvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(karantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumkarantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenapd[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvtoravakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenavd[i]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Името не е достапно во базата на податоци!");
                }
            }
            //Preziminja
            if (radioButton2.Checked == true)
            {
                string sortkeyp = textBox1.Text;
                int indeksp = preziminja.IndexOf(sortkeyp);
                if (indeksp > -1)
                {
                    listView1.Items.Clear();
                    for (int i = indeksp; i < preziminja.Count; i++)
                    {
                        if (preziminja[i] == sortkeyp)
                        {
                            listView1.Items.Add(iminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(preziminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(godini[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(embg[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(adresi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(gradovi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(vakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(prijavenvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(karantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumkarantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenapd[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvtoravakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenavd[i]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Презимето не е достапно во базата на податоци!");
                }
            }
            //GODINI
            if (radioButton3.Checked == true)
            {
                string sortkeygo = textBox1.Text;
                int indeksgo = godini.IndexOf(sortkeygo);
                if (indeksgo > -1)
                {
                    listView1.Items.Clear();
                    for (int i = indeksgo; i < godini.Count; i++)
                    {
                        if (godini[i] == sortkeygo)
                        {
                            listView1.Items.Add(iminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(preziminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(godini[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(embg[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(adresi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(gradovi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(vakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(prijavenvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(karantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumkarantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenapd[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvtoravakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenavd[i]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Годината не е достапна во базата на податоци!");
                }
            }
            //GRADOVI
            if (radioButton4.Checked == true)
            {
                string sortkeyg = textBox1.Text;
                int indeksg = gradovi.IndexOf(sortkeyg);
                if (indeksg > -1)
                {
                    listView1.Items.Clear();
                    for (int i = indeksg; i < gradovi.Count; i++)
                    {
                        if (gradovi[i] == sortkeyg)
                        {
                            listView1.Items.Add(iminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(preziminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(godini[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(embg[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(adresi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(gradovi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(vakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(prijavenvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(karantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumkarantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenapd[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvtoravakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenavd[i]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Градот не постои во базата на податоци!");
                }
            }
            //VAKCINA
            if (radioButton5.Checked == true)
            {
                string sortkeyv = textBox1.Text;
                int indeksv = vakcina.IndexOf(sortkeyv);
                if (indeksv > -1)
                {
                    listView1.Items.Clear();
                    for (int i = indeksv; i < vakcina.Count; i++)
                    {
                        if (vakcina[i] == sortkeyv)
                        {
                            listView1.Items.Add(iminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(preziminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(godini[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(embg[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(adresi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(gradovi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(vakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(prijavenvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(karantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumkarantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenapd[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvtoravakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenavd[i]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Грешка, обидете се повторно!");
                }

            }
            //PRIJAVEN ZA VAKCINA
            if (radioButton6.Checked == true)
            {
                string sortkeya = textBox1.Text;
                int indeksa = prijavenvakcina.IndexOf(sortkeya);
                if (indeksa > -1)
                {
                    listView1.Items.Clear();
                    for (int i = indeksa; i < prijavenvakcina.Count; i++)
                    {
                        if (prijavenvakcina[i] == sortkeya)
                        {
                            listView1.Items.Add(iminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(preziminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(godini[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(embg[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(adresi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(gradovi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(vakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(prijavenvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(karantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumkarantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenapd[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvtoravakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenavd[i]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Грешка, обидете се повторно!");
                }
            }
            //PRIJAVEN vo karantin
            if (radioButton7.Checked == true)
            {
                string sortkeyk = textBox1.Text;
                int indeksk = karantin.IndexOf(sortkeyk);
                if (indeksk > -1)
                {
                    listView1.Items.Clear();
                    for (int i = indeksk; i < karantin.Count; i++)
                    {
                        if (karantin[i] == sortkeyk)
                        {
                            listView1.Items.Add(iminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(preziminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(godini[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(embg[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(adresi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(gradovi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(vakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(prijavenvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(karantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumkarantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenapd[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvtoravakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenavd[i]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Грешка, обидете се повторно!");
                }
            }
            //Data vo karantin
            if (radioButton8.Checked == true)
            {
                string sortkeyd = textBox1.Text;
                int indeksd = datumkarantin.IndexOf(sortkeyd);
                if (indeksd > -1)
                {
                    listView1.Items.Clear();
                    for (int i = indeksd; i < datumkarantin.Count; i++)
                    {
                        if (datumkarantin[i] == sortkeyd)
                        {
                            listView1.Items.Add(iminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(preziminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(godini[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(embg[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(adresi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(gradovi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(vakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(prijavenvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(karantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumkarantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenapd[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvtoravakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenavd[i]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Грешка, обидете се повторно!");
                }
            }
            //Data vakcina
            if (radioButton9.Checked == true)
            {
                string sortkeydv = textBox1.Text;
                int indeksdv = datumvakcina.IndexOf(sortkeydv);
                if (indeksdv > -1)
                {
                    listView1.Items.Clear();
                    for (int i = indeksdv; i < datumvakcina.Count; i++)
                    {
                        if (datumvakcina[i] == sortkeydv)
                        {
                            listView1.Items.Add(iminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(preziminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(godini[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(embg[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(adresi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(gradovi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(vakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(prijavenvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(karantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumkarantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenapd[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvtoravakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenavd[i]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Грешка, обидете се повторно!");
                }
            }
            //Primena prva doza
            if (radioButton10.Checked == true)
            {
                string sortkeyq = textBox1.Text;
                int indeksq = primenapd.IndexOf(sortkeyq);
                if (indeksq > -1)
                {
                    listView1.Items.Clear();
                    for (int i = indeksq; i < primenapd.Count; i++)
                    {
                        if (primenapd[i] == sortkeyq)
                        {
                            listView1.Items.Add(iminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(preziminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(godini[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(embg[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(adresi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(gradovi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(vakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(prijavenvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(karantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumkarantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenapd[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvtoravakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenavd[i]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Грешка, обидете се повторно!");
                }
            }
            //Primena prva doza
            if (radioButton11.Checked == true)
            {
                string sortkeyl = textBox1.Text;
                int indeksl = datumvtoravakcina.IndexOf(sortkeyl);
                if (indeksl > -1)
                {
                    listView1.Items.Clear();
                    for (int i = indeksl; i < datumvtoravakcina.Count; i++)
                    {
                        if (datumvtoravakcina[i] == sortkeyl)
                        {
                            listView1.Items.Add(iminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(preziminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(godini[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(embg[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(adresi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(gradovi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(vakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(prijavenvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(karantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumkarantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenapd[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvtoravakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenavd[i]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Грешка, обидете се повторно!");
                }
            }
            //Primena prva doza
            if (radioButton12.Checked == true)
            {
                string sortkeyt = textBox1.Text;
                int indekst = primenavd.IndexOf(sortkeyt);
                if (indekst > -1)
                {
                    listView1.Items.Clear();
                    for (int i = indekst; i < primenavd.Count; i++)
                    {
                        if (primenavd[i] == sortkeyt)
                        {
                            listView1.Items.Add(iminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(preziminja[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(godini[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(embg[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(adresi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(gradovi[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(vakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(prijavenvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(karantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumkarantin[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenapd[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(datumvtoravakcina[i]);
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(primenavd[i]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Грешка, обидете се повторно!");
                }
            }
        }
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

