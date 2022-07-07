using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeiro_Programa
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 dois = new Form2();
            dois.Show();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form1 um = new Form1();
            um.ShowDialog();
        }
    }
}
