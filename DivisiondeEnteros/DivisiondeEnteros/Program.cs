using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisiondeEnteros
{
    class Program
    {
        static void Main(string[] args)
        {


            Program programaDivision;
            int numero1;
            int numero2;
            int division;

            programaDivision = new Program(); // instanciar el objeto 

            Console.WriteLine("Ingrese numerador: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese denominador: ");
            numero2 = int.Parse(Console.ReadLine());

            division = programaDivision.CacularDivision(numero1, numero2);
            Console.WriteLine("El resultado de la division es: " + division);

            Console.ReadLine(); /*espera a que el usuario presione enter antes de salir*/
        }
        public int CacularDivision(int a, int b)
        {

            return a / b;
            
        }
    }
}
