using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            double valor1 = 0, valor2 = 0, resultado = 0;
            Console.WriteLine("========>> PROGRAMA QUE SUMA DOS NUMEROS <<=======");
            Console.WriteLine("Ingrese el primer valor: ");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());
            resultado = valor1 + valor2;
            Console.WriteLine("El resultado es {0}", resultado);
            Console.ReadKey();
        }
    }
}
