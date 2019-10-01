//autor: José Alejandro Ibarra Miranda
//Fecha de creación: 25/septiembre/19
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleatorio
{
    class Program
    {
        static public float NUM1 = 38.5f;
        static void Main(string[] args)
        {
            float NUM2 = 0.0f;
            Random numeroAlea = new Random();
            NUM2 = (float)numeroAlea.Next(1, 11);
            Console.WriteLine(string.Format("la suma de {0} y {1} es {2}", NUM1, NUM2, NUM1 + NUM2));
            Console.ReadKey();
        }
    }
}
