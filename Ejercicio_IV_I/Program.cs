using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_IV_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que muestra los numeros del 1 al 100");
            Console.WriteLine("Numeros del 1 al 100");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + 1);
            }
            Console.ReadKey();
        }
    }
}
