using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalC_
{
    public partial class FormsAlgoritmosDeOredenamiento : Form
    {
        private List<int> numeros = new List<int>();
        private Random random = new Random();

        public FormsAlgoritmosDeOredenamiento()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAñadir.Text))
            {
                int numero = Convert.ToInt32(txtAñadir.Text);
                numeros.Add(numero);

                // Agrega el número como un nuevo elemento en el ListView
                ListViewItem item = new ListViewItem(numero.ToString());
                listViewOrdenamiento.Items.Add(item);

                txtAñadir.Clear();
            }
            else
            {
                MessageBox.Show("Ingresa un número válido");
            }
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            QuickSort(numeros, 0, numeros.Count - 1);

            stopwatch.Stop();

            ActualizarListView();

            MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos");
        }

        private void QuickSort(List<int> array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);

                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        private int Partition(List<int> array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;

                    // Swap array[i] and array[j]
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            // Swap array[i + 1] and array[high] (or pivot)
            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }

        private void ActualizarListView()
        {
            listViewOrdenamiento.Items.Clear();
            foreach (int numero in numeros)
            {
                // Agrega el número como un nuevo elemento en el ListView
                ListViewItem item = new ListViewItem(numero.ToString());
                listViewOrdenamiento.Items.Add(item);
            }
        }

        private void btnHeapsort_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            HeapSort(numeros);

            stopwatch.Stop();

            ActualizarListView();

            MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos");
        }
        private void HeapSort(List<int> array)
        {
            int n = array.Count;

            // Construir el montículo (heap)
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i);
            }

            // Extraer elementos del montículo uno por uno
            for (int i = n - 1; i > 0; i--)
            {
                // Mover la raíz actual al final
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                // Llamar a Heapify en el montículo reducido
                Heapify(array, i, 0);
            }
        }

        private void Heapify(List<int> array, int n, int i)
        {
            int largest = i; // Inicializar el nodo raíz como el más grande
            int left = 2 * i + 1; // Índice del hijo izquierdo
            int right = 2 * i + 2; // Índice del hijo derecho

            // Si el hijo izquierdo es más grande que el nodo raíz
            if (left < n && array[left] > array[largest])
            {
                largest = left;
            }

            // Si el hijo derecho es más grande que el nodo raíz
            if (right < n && array[right] > array[largest])
            {
                largest = right;
            }

            // Si el nodo raíz no es el más grande, intercambiar con el más grande
            if (largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;

                // Recursivamente Heapify el subárbol afectado
                Heapify(array, n, largest);
            }
        }

        private void btnSelectionsort_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            SelectionSort(numeros);

            stopwatch.Stop();

            ActualizarListView();

            MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos");
        }
        private void SelectionSort(List<int> array)
        {
            int n = array.Count;

            for (int i = 0; i < n - 1; i++)
            {
                // Encuentra el mínimo elemento en el subarray no ordenado
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Intercambia el mínimo elemento encontrado con el primer elemento del subarray no ordenado
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }

        private void btnShellsort_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            ShellSort(numeros);

            stopwatch.Stop();

            ActualizarListView();

            MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos");
        }
        private void ShellSort(List<int> array)
        {
            int n = array.Count;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j = i;

                    while (j >= gap && array[j - gap] > temp)
                    {
                        array[j] = array[j - gap];
                        j -= gap;
                    }

                    array[j] = temp;
                }

                gap /= 2;
            }
        }

        private void btnRadixsort_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            RadixSort(numeros);

            stopwatch.Stop();

            ActualizarListView();

            MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos");
        }
        private void RadixSort(List<int> array)
        {
            // Encuentra el número máximo para conocer el número de dígitos
            int max = array.Max();
            int exp = 1;

            while (max / exp > 0)
            {
                CountSort(array, exp);
                exp *= 10;
            }
        }

        private void CountSort(List<int> array, int exp)
        {
            int n = array.Count;
            List<int> output = new List<int>(new int[n]);
            int[] count = new int[10];

            // Inicializa el array de cuenta
            for (int i = 0; i < 10; i++)
            {
                count[i] = 0;
            }

            // Almacena la cuenta de ocurrencias en el array de cuenta
            for (int i = 0; i < n; i++)
            {
                count[(array[i] / exp) % 10]++;
            }

            // Cambia count[i] para que ahora contenga la posición actual del dígito en output[]
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            // Construye el array de salida
            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(array[i] / exp) % 10] - 1] = array[i];
                count[(array[i] / exp) % 10]--;
            }

            // Copia el array de salida al array original
            for (int i = 0; i < n; i++)
            {
                array[i] = output[i];
            }
        }

        private void btnBinarytreesort_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            BinaryTreeSort(numeros);

            stopwatch.Stop();

            ActualizarListView();

            MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos");
        }
        private class Nodo
        {
            public int Valor;
            public Nodo Izquierdo, Derecho;

            public Nodo(int valor)
            {
                Valor = valor;
                Izquierdo = Derecho = null;
            }
        }

        private void BinaryTreeSort(List<int> array)
        {
            Nodo raiz = null;

            // Construir el árbol
            foreach (int valor in array)
            {
                raiz = Insertar(raiz, valor);
            }

            // Recorrer el árbol en orden y actualizar la lista
            InOrder(raiz, array);
        }

        private Nodo Insertar(Nodo raiz, int valor)
        {
            if (raiz == null)
            {
                return new Nodo(valor);
            }

            if (valor < raiz.Valor)
            {
                raiz.Izquierdo = Insertar(raiz.Izquierdo, valor);
            }
            else if (valor > raiz.Valor)
            {
                raiz.Derecho = Insertar(raiz.Derecho, valor);
            }

            return raiz;
        }

        private void InOrder(Nodo raiz, List<int> array)
        {
            if (raiz != null)
            {
                InOrder(raiz.Izquierdo, array);
                array.Add(raiz.Valor);
                InOrder(raiz.Derecho, array);
            }
        }

        private void btnMergesort_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            MergeSort(numeros);

            stopwatch.Stop();

            ActualizarListView();

            MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos");
        }
        private void MergeSort(List<int> array)
        {
            if (array.Count <= 1)
            {
                return;
            }

            int medio = array.Count / 2;
            List<int> izquierda = new List<int>(array.GetRange(0, medio));
            List<int> derecha = new List<int>(array.GetRange(medio, array.Count - medio));

            MergeSort(izquierda);
            MergeSort(derecha);

            Merge(array, izquierda, derecha);
        }

        private void Merge(List<int> array, List<int> izquierda, List<int> derecha)
        {
            int i = 0, j = 0, k = 0;

            while (i < izquierda.Count && j < derecha.Count)
            {
                if (izquierda[i] < derecha[j])
                {
                    array[k] = izquierda[i];
                    i++;
                }
                else
                {
                    array[k] = derecha[j];
                    j++;
                }
                k++;
            }

            while (i < izquierda.Count)
            {
                array[k] = izquierda[i];
                i++;
                k++;
            }

            while (j < derecha.Count)
            {
                array[k] = derecha[j];
                j++;
                k++;
            }
        }

        private void btnCountingsort_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            CountingSort(numeros);

            stopwatch.Stop();

            ActualizarListView();

            MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos");
        }
        private void CountingSort(List<int> array)
        {
            int n = array.Count;
            int max = array.Max();

            int[] count = new int[max + 1];
            List<int> output = new List<int>(new int[n]);

            // Contar la frecuencia de cada elemento
            foreach (int num in array)
            {
                count[num]++;
            }

            // Actualizar count[i] para que contenga la posición real de este elemento en output[]
            for (int i = 1; i <= max; i++)
            {
                count[i] += count[i - 1];
            }

            // Construir el array de salida
            for (int i = n - 1; i >= 0; i--)
            {
                output[count[array[i]] - 1] = array[i];
                count[array[i]]--;
            }

            // Copiar el array de salida al array original
            for (int i = 0; i < n; i++)
            {
                array[i] = output[i];
            }
        }

        private void btnBucketsort_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            BucketSort(numeros);

            stopwatch.Stop();

            ActualizarListView();

            MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos");
        }
        private void BucketSort(List<int> array)
        {
            int n = array.Count;

            // Crear un número de buckets
            List<List<int>> buckets = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                buckets.Add(new List<int>());
            }

            // Colocar los elementos en los buckets
            foreach (int num in array)
            {
                int bucketIndex = (num * n) / (array.Max() + 1);
                buckets[bucketIndex].Add(num);
            }

            // Ordenar cada bucket individualmente (puede usar otro algoritmo de ordenación o recursión)
            foreach (List<int> bucket in buckets)
            {
                bucket.Sort();
            }

            // Concatenar los buckets ordenados para obtener el array ordenado final
            int index = 0;
            foreach (List<int> bucket in buckets)
            {
                foreach (int num in bucket)
                {
                    array[index++] = num;
                }
            }
        }

        private void btnInsertionsort_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            InsertionSort(numeros);

            stopwatch.Stop();

            ActualizarListView();

            MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos");
        }
        private void InsertionSort(List<int> array)
        {
            int n = array.Count;

            for (int i = 1; i < n; ++i)
            {
                int key = array[i];
                int j = i - 1;

                // Mover los elementos mayores que key a una posición hacia adelante
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }

                // Colocar key en su posición correcta
                array[j + 1] = key;
            }
        }

        private void btnCocktailsort_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            CocktailSort(numeros);

            stopwatch.Stop();

            ActualizarListView();

            MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos");

        }
        private void CocktailSort(List<int> array)
        {
            bool swapped;
            do
            {
                // Fase de izquierda a derecha
                swapped = false;
                for (int i = 0; i < array.Count - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                        swapped = true;
                    }
                }

                // Si no hubo intercambios, el array ya está ordenado
                if (!swapped)
                {
                    break;
                }

                // Fase de derecha a izquierda
                swapped = false;
                for (int i = array.Count - 2; i >= 0; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                        swapped = true;
                    }
                }
            } while (swapped);
        }

       

        private void btnBubblesort_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            BubbleSort(numeros);

            stopwatch.Stop();

            ActualizarListView();

            MessageBox.Show($"Ordenamiento completado en {stopwatch.ElapsedMilliseconds} milisegundos");
        }
        private static void Swap(List<int> array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private static void BubbleSort(List<int> array)
        {
            int n = array.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Swap(array, j, j + 1);
                }
            }
        }
    }
}
