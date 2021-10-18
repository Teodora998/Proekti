using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudenskiObrok
{
    public partial class StOb : Form
    {
        public StOb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Informacii obj = new Informacii();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tekovno obj = new Tekovno();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mesecno obj = new Mesecno();
            obj.Show();
        }
    }
}
