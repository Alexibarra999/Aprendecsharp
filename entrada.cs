//autor: José Alejandro Ibarra Miranda
//Fecha de creación: 25/septiembre/19
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            string VALOR;
            int R = 0;
            Console.Write("Escribe: ");
            VALOR = Console.ReadLine();

            if (int.TryParse(VALOR, out R))
            {
                Console.WriteLine(string.Format("DATO ENTERO {0}, MUY BIEN!!", R));
            }
            else
            {
                Console.WriteLine("DATO NO ES ENTERO. INTENTAR DE NUEVO");
            }
           
            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR...");
            Console.ReadKey();
           
        }
    }
}
