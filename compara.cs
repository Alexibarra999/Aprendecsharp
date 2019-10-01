//autor: José Alejandro Ibarra Miranda
//Fecha de creación: 25/septiembre/19
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compara
{
    class Program
    {
        static void Main(string[] args)
        {
            string NUM1, NUM2;
            int NUMM1, NUMM2;
            Console.Write("Numero 1: ");
            NUM1 = Console.ReadLine();
            Console.Write("Numero 2: ");
            NUM2 = Console.ReadLine();
            NUMM1 = Convert.ToInt32(NUM1);
            NUMM2 = Convert.ToInt32(NUM2);
            if (NUMM1 == NUMM2)
            {
                Console.WriteLine(string.Format("Numeros proporcionados {0} y {1}. {2}", NUMM1 , NUMM2, "los numeros son iguales!"));
            }
            else
            {
                if (NUMM1 > NUMM2)
                {
                    Console.WriteLine(string.Format("Numeros proporcionados {0} y {1}. {2}", NUMM1, NUMM2, "el Mayor es el primero."));
                }
                else
                {
                    Console.WriteLine(string.Format("Numeros proporcionados {0} y {1}. {2}", NUMM1, NUMM2, "el Mayor es el segundo."));
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Presiona cualquier tecla para terminar...");
            Console.ReadKey();
        }
    }
}
