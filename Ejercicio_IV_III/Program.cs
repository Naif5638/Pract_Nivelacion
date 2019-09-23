using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_IV_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que muestra los numeros del 3 al 20 y cubo al lado");
            Console.WriteLine("Numeros del 3 al 20 y su cubo");
            for (int i = 3; i <= 20; i++)
            {
                Console.WriteLine("{0} {1}", i, Math.Pow(i,3));
            }
            Console.ReadKey();
        }
    }
}
