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
    public partial class FormArboles : Form
    {
        private class Nodo
        {
            public int Valor;
            public Nodo Izquierda, Derecha;

            public Nodo(int valor)
            {
                Valor = valor;
                Izquierda = Derecha = null;
            }
        }

        private Nodo raiz;

        public FormArboles()
        {
            InitializeComponent();
            raiz = null;
        }

        private void Insertar(int valor)
        {
            raiz = InsertarRec(raiz, valor);
        }

        private Nodo InsertarRec(Nodo raiz, int valor)
        {
            if (raiz == null)
            {
                raiz = new Nodo(valor);
                return raiz;
            }

            if (valor < raiz.Valor)
                raiz.Izquierda = InsertarRec(raiz.Izquierda, valor);
            else if (valor > raiz.Valor)
                raiz.Derecha = InsertarRec(raiz.Derecha, valor);

            return raiz;
        }

        private bool Buscar(int valor)
        {
            return BuscarRec(raiz, valor);
        }

        private bool BuscarRec(Nodo raiz, int valor)
        {
            if (raiz == null)
                return false;

            if (valor == raiz.Valor)
                return true;

            if (valor < raiz.Valor)
                return BuscarRec(raiz.Izquierda, valor);
            else
                return BuscarRec(raiz.Derecha, valor);
        }

        private void RecorridoEnOrden(Nodo raiz, ref string recorrido)
        {
            if (raiz != null)
            {
                RecorridoEnOrden(raiz.Izquierda, ref recorrido);
                recorrido += raiz.Valor + " ";
                RecorridoEnOrden(raiz.Derecha, ref recorrido);
            }
        }

        private void Eliminar(int valor)
        {
            raiz = EliminarRec(raiz, valor);
        }

        private Nodo EliminarRec(Nodo raiz, int valor)
        {
            if (raiz == null)
                return raiz;

            if (valor < raiz.Valor)
                raiz.Izquierda = EliminarRec(raiz.Izquierda, valor);
            else if (valor > raiz.Valor)
                raiz.Derecha = EliminarRec(raiz.Derecha, valor);
            else
            {
                if (raiz.Izquierda == null)
                    return raiz.Derecha;
                else if (raiz.Derecha == null)
                    return raiz.Izquierda;

                raiz.Valor = ValorMinimo(raiz.Derecha);

                raiz.Derecha = EliminarRec(raiz.Derecha, raiz.Valor);
            }

            return raiz;
        }

        private int ValorMinimo(Nodo raiz)
        {
            int minValue = raiz.Valor;
            while (raiz.Izquierda != null)
            {
                minValue = raiz.Izquierda.Valor;
                raiz = raiz.Izquierda;
            }
            return minValue;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                Insertar(valor);
                MessageBox.Show($"Valor {valor} insertado en el árbol.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor entero válido.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                string recorrido = "";
                if (Buscar(valor))
                {
                    RecorridoEnOrden(raiz, ref recorrido);
                    MessageBox.Show($"Valor {valor} encontrado en el árbol. Recorrido en orden: {recorrido}");
                }
                else
                    MessageBox.Show($"Valor {valor} no encontrado en el árbol.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor entero válido.");
            }
        }

        

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                Eliminar(valor);
                MessageBox.Show($"Valor {valor} eliminado del árbol.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor entero válido.");
            }
        }
    }
}
