using System;
using System.Collections;
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
    public partial class FormsColas : Form
    {
        private Queue cola = new Queue();
        public FormsColas()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            // Obtener el elemento desde el TextBox
            string elemento = txtElemento.Text;

            // Verificar si el TextBox no está vacío
            if (!string.IsNullOrEmpty(elemento))
            {
                // Encolar el elemento
                cola.Enqueue(elemento);

                // Actualizar la lista para mostrar la cola actualizada
                MostrarCola();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un elemento para encolar.");
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            // Verificar si la cola no está vacía
            if (cola.Count > 0)
            {
                // Desencolar el elemento
                cola.Dequeue();

                // Actualizar la lista para mostrar la cola actualizada
                MostrarCola();
            }
            else
            {
                MessageBox.Show("La cola está vacía. No se pueden desencolar más elementos.");
            }
        }

        private void MostrarCola()
        {
            // Mostrar la cola en la ListBox
            lstCola.Items.Clear();
            foreach (var elemento in cola)
            {
                lstCola.Items.Add(elemento);
            }
        }
    }
}
