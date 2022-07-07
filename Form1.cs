namespace Primeiro_Programa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Close(); //Serve para fehcar a janela
            Application.Exit(); //Serve para encerrar o programa;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 tres = new Form3();
            tres.ShowDialog();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 dois = new Form2();
            dois.ShowDialog();
        }

        private void fORM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 um = new Form1();
            um.ShowDialog();
        }

        private void fORM2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dois = new Form2();
            dois.ShowDialog();
        }

        private void fORM3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 tres = new Form3();
            tres.ShowDialog();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bLOCODENOTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void cALCULADORAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
    }
}