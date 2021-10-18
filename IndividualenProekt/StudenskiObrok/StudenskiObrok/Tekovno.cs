using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudenskiObrok
{
    public partial class Tekovno : Form
    {
        public Tekovno()
        {
            InitializeComponent();
        }

        private void Tekovno_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            string mesec;
            dt = monthCalendar1.TodayDate;
            mesec = dt.Month.ToString();
            if (mesec == "1")
            {
                Mesecno obj = new Mesecno();
                textBox1.Text = (obj.RabotniDenovi(1) * 120).ToString();
            }
            else if (mesec == "2")
            {
                Mesecno obj = new Mesecno();
                textBox1.Text = (obj.RabotniDenovi(2) * 120).ToString();
            }
            else if (mesec == "3")
            {
                Mesecno obj = new Mesecno();
                textBox1.Text = (obj.RabotniDenovi(3) * 120).ToString();
            }
            else if (mesec == "4")
            {
                Mesecno obj = new Mesecno();
                textBox1.Text = (obj.RabotniDenovi(4) * 120).ToString();
            }
            else if (mesec == "5")
            {
                Mesecno obj = new Mesecno();
                textBox1.Text = (obj.RabotniDenovi(5) * 120).ToString();
            }
            else if (mesec == "6")
            {
                Mesecno obj = new Mesecno();
                textBox1.Text = (obj.RabotniDenovi(6) * 120).ToString();
            }
            else if (mesec == "7")
            {
                Mesecno obj = new Mesecno();
                textBox1.Text = (obj.RabotniDenovi(7) * 120).ToString();
            }
            else if (mesec == "8")
            {
                Mesecno obj = new Mesecno();
                textBox1.Text = (obj.RabotniDenovi(8) * 120).ToString();
            }
            else if (mesec == "9")
            {
                Mesecno obj = new Mesecno();
                textBox1.Text = (obj.RabotniDenovi(9) * 120).ToString();
            }
            else if (mesec == "10")
            {
                Mesecno obj = new Mesecno();
                textBox1.Text = (obj.RabotniDenovi(10) * 120).ToString();
            }
            else if (mesec == "11")
            {
                Mesecno obj = new Mesecno();
                textBox1.Text = (obj.RabotniDenovi(11) * 120).ToString();
            }
            else if (mesec == "12")
            {
                Mesecno obj = new Mesecno();
                textBox1.Text = (obj.RabotniDenovi(12) * 120).ToString();
            }
        }
    }
}
