//autor: José Alejandro Ibarra Miranda
//Fecha de creación: 25/septiembre/19
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabla
{
    class Program
    {
        static void Main(string[] args)
        {
            string NUM;
            int NUMERO;
            Console.Write("ingresa un numero del 1 al 9: ");
            NUM = Console.ReadLine();
            NUMERO = Convert.ToInt32(NUM);
            for (int i = 1; i <=10;  i++)
            {
                Console.WriteLine(string.Format("{0} x {1} = {2}", NUMERO, i, NUMERO * i)); 
            }
            Console.WriteLine("presiona cualquier tecla para terminar...");
            Console.ReadKey();
        }   
             
    }
}
