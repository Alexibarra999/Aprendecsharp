//autor: José Alejandro Ibarra Miranda
//Fecha de creación: 25/septiembre/19
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acumulado
{
    class Program
    {
        static void Main(string[] args)
        {
            string NUM_ERO;
            int NUM;
            int ACU = 0;
            Console.WriteLine("INGRESE LOS ENTEROS A ACUMULAR: ");
            Console.WriteLine("Dejar vacio y dar enter para salir...");
            Console.WriteLine("");
            while (true)
            {
                Console.Write("ingresa un numero entero: ");
                NUM_ERO = Console.ReadLine();
                if (NUM_ERO == "")
                {
                    break;
                }
                else
                {
                    if (int.TryParse(NUM_ERO, out NUM))
                    {
                        ACU += NUM;
                        Console.WriteLine(string.Format("monto acumulado: {0}", ACU));

                    }
                    else
                    {
                        Console.WriteLine("el dato proporcionado no es un numero entero.");
                        Console.WriteLine("intenta de nuevo.");
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("presiona cualquier tecla para terminar...");
            Console.ReadKey();
        }   
    }
}

