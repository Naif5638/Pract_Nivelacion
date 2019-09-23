using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_II_I
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            Console.WriteLine("------>> Programa que solicita nombre y saluda <<-------");
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola {0}", nombre);
            Console.ReadKey();
        }
    }
}
