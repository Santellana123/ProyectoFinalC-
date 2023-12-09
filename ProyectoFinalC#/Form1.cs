using Microsoft.VisualBasic;

namespace ProyectoFinalC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGrafos a = new FormGrafos();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormArboles a = new FormArboles();
            a.ShowDialog();
        }

        private void btnPilas_Click(object sender, EventArgs e)
        {
            FormPilas a = new FormPilas();
            a.ShowDialog();
        }

        private void btnColas_Click(object sender, EventArgs e)
        {
            FormsColas a = new FormsColas();
            a.ShowDialog();
        }

        private void btnADO_Click(object sender, EventArgs e)
        {
            FormsAlgoritmosDeOredenamiento a=new FormsAlgoritmosDeOredenamiento();
            a.ShowDialog();
        }
    }
}