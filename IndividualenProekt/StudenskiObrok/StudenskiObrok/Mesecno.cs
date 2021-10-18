using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudenskiObrok
{
    public partial class Mesecno : Form
    {
        public Mesecno()
        {
            InitializeComponent();


        }
        public int RabotniDenovi(int mesec)
        {
            if (mesec == 1)
                return 10;
            else if(mesec == 2)
                return 20;
            else if (mesec == 3)
                return 23;
            else if (mesec == 4)
                return 19;
            else if (mesec == 5)
                return 20;
            else if (mesec == 6)
                return 15;
            else if (mesec == 7)
                return 0;
            else if (mesec == 8)
                return 0;
            else if (mesec == 9)
                return 15;
            else if (mesec == 10)
                return 19;
            else if (mesec == 11)
                return 21;
            else if (mesec == 12)
                return 20;
            else
                return 0;

        }
        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          //  throw new NotImplementedException();
        }
        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }
        public void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
          //  throw new NotImplementedException();
        }
        public void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
        public void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
         //   throw new NotImplementedException();
        }
        public void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }
        public void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
        public void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
        public void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
        public void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
        public void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }
        public void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
        public void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            if (radioButton1.Checked == true)
            {
                
                int suma = 1;
                suma = 10 * 120;
                listBox1.Items.Add(suma);

            }
            if (radioButton2.Checked == true)
            {
        
                int suma = 0;
                suma = 20 * 120;
                listBox1.Items.Add(suma);
            }

            if (radioButton3.Checked == true)
            {
                int suma = 0;
                suma = 23 * 120;
                listBox1.Items.Add(suma);
            }
            if (radioButton4.Checked == true)
            {
                int suma = 0;
                suma = 19 * 120;
                listBox1.Items.Add(suma);
            }
            if (radioButton5.Checked == true)
            {
                
                int suma = 0;
                suma = 20 * 120;
                listBox1.Items.Add(suma);
            }
            if (radioButton6.Checked == true)
            {
                
                int suma = 0;
                suma = 15 * 120;
                listBox1.Items.Add(suma);
            }
            if (radioButton7.Checked == true)
            {
                
                listBox1.Items.Add("Овој месец на вашата сметка нема да се изврши трансфер!");
            }
            if (radioButton8.Checked == true)
            {
                
                listBox1.Items.Add("Овој месец на вашата сметка нема да се изврши трансфер!");
            }
            if (radioButton9.Checked == true)
            {
                
                int suma = 0;
                suma = 15 * 120;
                listBox1.Items.Add(suma);
            }
            if (radioButton10.Checked == true)
            {
                
                int suma = 0;
                suma = 19 * 120;
                listBox1.Items.Add(suma);
            }
            if (radioButton11.Checked == true)
            {
                int suma = 0;
                suma = 21 * 120;
                listBox1.Items.Add(suma);
            }
            if (radioButton12.Checked == true)
            {
                int suma = 0;
                suma = 20 * 120;
                listBox1.Items.Add(suma);
            }
        }
    }
}
