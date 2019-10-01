//autor: José Alejandro Ibarra Miranda
//Fecha de creación: 25/septiembre/19
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("");
                Console.WriteLine(string.Format("TABLA DEL {0}: ", i));
                Console.WriteLine("");
                for (int j = 1; j <= 10; j++)

                {
                    Console.WriteLine(string.Format("{0} x {1} = {2}", i, j, i * j));
                }
            }
            Console.WriteLine("presiona cualquier tecla para terminar...");
            Console.ReadKey();
        }
    }
}
