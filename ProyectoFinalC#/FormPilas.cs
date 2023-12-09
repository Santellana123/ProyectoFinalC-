using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalC_
{
    public partial class FormPilas : Form
    {
        private Stack<int> pila = new Stack<int>();
        public FormPilas()
        {
            InitializeComponent();
        }

        private void UpdateListBox()
        {
            listBoxPila.Items.Clear();
            foreach (var elemento in pila)
            {
                listBoxPila.Items.Add(elemento);
            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(txtValor.Text);
                pila.Push(valor);
                UpdateListBox();
                txtValor.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor entero válido.");
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                int valorPop = pila.Pop();
                UpdateListBox();
                MessageBox.Show($"Elemento retirado: {valorPop}");
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }
    }
}
