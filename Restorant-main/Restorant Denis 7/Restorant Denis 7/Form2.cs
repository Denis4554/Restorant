using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restorant_Denis_7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            grpBoxSalad.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalad_Click(object sender, EventArgs e)
        {
            grpBoxSalad.Show();
        }
        private void btnAddSalad_Click(object sender, EventArgs e)
        {
            if (txtSaladBuratta.Text != "0")
            {
                listBox1.Items.Add($"{lblSaladBurata.Text} - {txtSaladBuratta.Text}бр.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
