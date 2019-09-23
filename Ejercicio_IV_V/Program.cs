using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_IV_V
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Programa que muestra la tabla de multiplicar del 1 al 12");
            Console.WriteLine("tabla de multiplicar");
            Console.Write("Hasta donde multiplicar: ");
            a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("Tabla del {0}", i);

                for (int j = 0; j < a; j++)
                {
                    Console.WriteLine("{0} X {1}= {2}", i, j, i * j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
