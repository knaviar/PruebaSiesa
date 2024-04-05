using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol
{

    public class Arbol
    {
        public int Peso { get; set; }
        public List<Arbol> Arboles { get; set; }

        public Arbol()
        {
            Arboles = new List<Arbol>();
        }

        public void CrearRama(int Peso)
        {
            Arbol arbol1 = new Arbol();
            arbol1.Peso = Peso;
            Arboles.Add(arbol1);
        }

        public Arbol ObtenerRama(int posicion)
        {
            return Arboles[posicion];
        }

        public bool TieneRama()
        {
            return Arboles.Count > 0;
        }

        public int CantidadRamas()
        {
            return Arboles.Count;
        }
    }

    public class MainClass
    {
        public static void Main(string[] args)
        {
            Arbol Arbol1 = new Arbol();
            Arbol Arbol2 = new Arbol();
            Arbol Arbol3 = new Arbol();

            Arbol1.Peso = 4;

            Arbol2.Peso = 4;
            Arbol2.CrearRama(2);
            Arbol2.CrearRama(1);

            Arbol3.Peso = 4;
            Arbol3.CrearRama(1);
            Arbol3.CrearRama(2);
            Arbol3.CrearRama(5);
            Arbol3.ObtenerRama(1).CrearRama(3);
            Arbol3.ObtenerRama(2).CrearRama(1);
            Arbol3.ObtenerRama(2).CrearRama(4);

            Console.WriteLine("Peso de Arbol1: " + ObtenerPeso(Arbol1));
            Console.WriteLine("Peso de Arbol2: " + ObtenerPeso(Arbol2));
            Console.WriteLine("Peso de Arbol3: " + ObtenerPeso(Arbol3));
            Console.WriteLine("Peso Promedio de Arbol1: " + ObtenerPromedioPeso(Arbol1));
            Console.WriteLine("Peso Promedio de Arbol2: " + ObtenerPromedioPeso(Arbol2));
            Console.WriteLine("Peso Promedio de Arbol3: " + ObtenerPromedioPeso(Arbol3));
            Console.WriteLine("Altura de Arbol1: " + ObtenerAltura(Arbol1));
            Console.WriteLine("Altura de Arbol2: " + ObtenerAltura(Arbol2));
            Console.WriteLine("Altura de Arbol3: " + ObtenerAltura(Arbol3));
            Console.ReadLine(); 
        }

        public static int ObtenerPeso(Arbol arbol)
        {
            int pesoTotal = arbol.Peso;

            if (arbol.TieneRama())
            {
                foreach (var rama in arbol.Arboles)
                {
                    pesoTotal += ObtenerPeso(rama);
                }
            }

            return pesoTotal;
        }

        public static double ObtenerPromedioPeso(Arbol arbol)
        {
            int[] pesoYCantidad = ObtenerPesoYCantidad(arbol);
            int totalPeso = pesoYCantidad[0];
            int cantidadArboles = pesoYCantidad[1];

            double promedioPeso = (double)totalPeso / cantidadArboles;

            return promedioPeso;
        }

        public static int[] ObtenerPesoYCantidad(Arbol arbol)
        {
            int totalPeso = arbol.Peso;
            int cantidadArboles = 1;

            if (arbol.TieneRama())
            {
                foreach (var rama in arbol.Arboles)
                {
                    int[] pesoYCantidadRama = ObtenerPesoYCantidad(rama);
                    totalPeso += pesoYCantidadRama[0];
                    cantidadArboles += pesoYCantidadRama[1];
                }
            }

            return new int[] { totalPeso, cantidadArboles };
        }

        public static int ObtenerAltura(Arbol arbol)
        {
            int alturaTotal = 1;

            if (arbol.TieneRama())
            {
                alturaTotal++;

                foreach (var rama in arbol.Arboles)
                {
                    alturaTotal = Math.Max(alturaTotal, 1 + ObtenerAltura(rama));
                }
            }

            return alturaTotal;
        }
    }
}

    

    




