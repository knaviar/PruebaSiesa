using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepresentacionenBase
{
    using System;

    class Program
    {
        static void Main()
        {
            int numero;
            int baseK;

            Console.WriteLine("Ingrese numero: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la base: ");
            baseK = int.Parse(Console.ReadLine());

            string representacion = ConvertirBaseK(numero, baseK);

            Console.WriteLine("La representación de {0} en base {1} es: {2}", numero, baseK, representacion);
            Console.ReadLine(); /*espera a que el usuario presione enter antes de salir*/
        }

        static string ConvertirBaseK(int numero, int baseK)
        {
            string resultado = "";

            while (numero > 0)
            {
                int residuo = numero % baseK;
                resultado = residuo.ToString() + resultado;
                numero = numero / baseK;
            }

            return resultado;
        }
    }

}

