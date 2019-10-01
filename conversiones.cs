//autor: José Alejandro Ibarra Miranda
//Fecha de creación: 25/septiembre/19
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "1234";
            Console.WriteLine(num.GetType().ToString());
            int intnum = Convert.ToInt32(num);
            Console.WriteLine(intnum.GetType().ToString());
            Console.WriteLine(string.Format("el numero es {0}", intnum));
            Console.ReadKey();
        }
    }
}
