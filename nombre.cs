//autor: José Alejandro Ibarra Miranda
//Fecha de creación: 25/septiembre/19
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nom;
            string ape;
            Console.Write("escribe un nombre: ");
            Nom = Console.ReadLine();
            Console.Write("escribe los apellidos: ");
            ape = Console.ReadLine();
            Nom = Nom.ToUpper();
            ape = ape.ToUpper();
            StringBuilder nombcomplet = new StringBuilder(Nom);
            nombcomplet.Append("");
            nombcomplet.Append(ape);
            Console.WriteLine(nombcomplet);

            Console.WriteLine("presiona cualquier tecla para continuar...");
            Console.ReadKey();      

        }
    }
}

