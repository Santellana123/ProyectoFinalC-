using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalC_
{
    internal class Grafo
    {
        private Dictionary<int, List<(int, int)>> grafo = new Dictionary<int, List<(int, int)>>();
        private Dictionary<int, int> pesos = new Dictionary<int, int>();


        public void AgregarVertice(int vertice)
        {

            if (!grafo.ContainsKey(vertice))
            {
                grafo[vertice] = new List<(int, int)>();
            }
        }


        public void AgregarArista(int origen, int destino, int peso)
        {
            if (grafo.ContainsKey(origen) && grafo.ContainsKey(destino))
            {
                grafo[origen].Add((destino, peso));
            }
        }
        public void EliminarArista(int origen, int destino)
        {
            if (grafo.ContainsKey(origen))
            {
                grafo[origen].RemoveAll(a => a.Item1 == destino);
            }
        }
        public IEnumerable<(int, int)> ObtenerVecinos(int vertice)
        {
            if (grafo.ContainsKey(vertice))
            {
                return grafo[vertice];
            }
            else
            {
                return Enumerable.Empty<(int, int)>();
            }
        }
        public IEnumerable<int> ObtenerVertices()
        {
            return grafo.Keys;
        }
        public void EliminarVertice(int vertice)
        {
            if (grafo.ContainsKey(vertice))
            {
                grafo.Remove(vertice);


                foreach (var key in grafo.Keys)
                {
                    grafo[key].RemoveAll(tupla => tupla.Item1 == vertice);
                }
            }
        }
        public (List<int> mejorCamino, List<List<int>> pasos) DFS(int origen, int objetivo)
        {
            if (!grafo.ContainsKey(origen))
            {
                Console.WriteLine($"El vértice de origen {origen} no está presente en el grafo.");
                return (new List<int>(), new List<List<int>>());
            }

            Stack<int> stack = new Stack<int>();
            Dictionary<int, int> padres = new Dictionary<int, int>();
            pesos.Clear();

            stack.Push(origen);
            padres[origen] = -1;

            List<List<int>> pasos = new List<List<int>>();

            while (stack.Count > 0)
            {
                int nodoActual = stack.Pop();
                List<int> pasoActual = new List<int> { nodoActual };

                foreach ((int vecino, int peso) in grafo[nodoActual])
                {
                    if (!padres.ContainsKey(vecino))
                    {
                        stack.Push(vecino);
                        padres[vecino] = nodoActual;
                        pesos[vecino] = peso;

                        // Agregar el nodo al paso actual
                        pasoActual.Add(vecino);
                    }
                    else
                    {
                        if (peso < pesos[vecino])
                        {
                            pesos[vecino] = peso;
                            padres[vecino] = nodoActual;
                        }
                    }
                }

                // Agregar el paso actual a la lista de pasos
                pasos.Add(new List<int>(pasoActual));
            }

            List<int> mejorCamino = ConstruirCamino(padres, objetivo);
            return (mejorCamino, pasos);
        }
        private void ImprimirPasosDFS(List<List<int>> pasos)
        {
            Console.WriteLine("Pasos de la Búsqueda de Profundidad (DFS):");
            for (int i = 0; i < pasos.Count; i++)
            {
                Console.WriteLine($"Paso {i + 1}: {string.Join(" -> ", pasos[i])}");
            }
        }
        private List<int> ConstruirCamino(Dictionary<int, int> padres, int objetivo)
        {
            List<int> camino = new List<int>();

            int actual = objetivo;
            while (actual != -1)
            {
                camino.Insert(0, actual);

                // Verificar si la clave está presente en el diccionario
                if (padres.ContainsKey(actual))
                {
                    actual = padres[actual];
                }
                else
                {
                    // Manejar el caso donde la clave no está presente
                    break;
                }
            }

            return camino;
        }
        public List<string> ObtenerMatrizAdyacencia()
        {
            List<string> matrizStrings = new List<string>();
            int numVertices = grafo.Count;


            StringBuilder header = new StringBuilder("   ");
            foreach (var vertice in grafo.Keys)
            {
                header.Append($"{vertice} ");
            }
            matrizStrings.Add(header.ToString());

            foreach (var vertice in grafo.Keys)
            {
                StringBuilder row = new StringBuilder($"{vertice} ");
                foreach (var otroVertice in grafo.Keys)
                {
                    bool tieneArista = grafo[vertice].Any(a => a.Item1 == otroVertice);
                    row.Append(tieneArista ? "1 " : "0 ");
                }
                matrizStrings.Add(row.ToString().Trim());
            }

            return matrizStrings;
        }
    }
}
