using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_VI_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[5];
            int suma = 0;
            Console.WriteLine("Programa que cactura 5 numeros en un arreglo y suma");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese el vector {0}: ", i + 1);
                vector[i] = int.Parse(Console.ReadLine());
            }

            foreach (int v in vector)
            {
                suma += v;
            }

            Console.WriteLine();
            Console.WriteLine("La sumatoria de los valores es {0}", suma);
            Console.ReadKey();
        }
    }
}
