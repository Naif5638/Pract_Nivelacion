using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_VI_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[5];
            Console.WriteLine("Programa que cactura 5 numeros en un arreglo");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese el vector {0}: ", i + 1);
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vectores ingresados: ");
            foreach (int v in vector)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }
}
