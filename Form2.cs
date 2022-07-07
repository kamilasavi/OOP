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
    public partial class Form2 : Form
    {
        public Form2()
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

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form1 um = new Form1();
            um.ShowDialog();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 tres = new Form3();
            tres.ShowDialog();
        }
    }
}
