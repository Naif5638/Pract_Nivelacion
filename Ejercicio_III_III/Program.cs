using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_III_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que te pide la edad y muestra la etapa de desarrollo");
            int edad;
            Console.Write("Ingrese la edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad == 0 || edad == 1)
            {
                Console.WriteLine("Bebé");
            }
            else if (edad >= 2 && edad <= 12)
            {
                Console.WriteLine("niño");
            }
            else if (edad >= 13 && edad <= 17)
            {
                Console.WriteLine("Adolescente");
            }
            else if (edad >= 18 && edad <= 30)
            {
                Console.WriteLine("Joven");
            }
            else if (edad >= 31 && edad <= 64)
            {
                Console.WriteLine("Adulto");
            }
            else if (edad >= 65 && edad <= 120)
            {
                Console.WriteLine("Anciano");
            }
            else if (edad < 0 || edad > 125)
            {
                Console.WriteLine("Error");
            }

            Console.ReadKey();
        }
    }
}
