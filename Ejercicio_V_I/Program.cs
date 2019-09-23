using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_V_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,i = 0;
            Console.WriteLine("Programa que muestra la tabla de multiplicar del numero 4");
            Console.WriteLine("tabla de multiplicar 4");
            Console.Write("Hasta donde multiplicar: ");
            a = int.Parse(Console.ReadLine());
            
            while (i <= a)
            {
                Console.WriteLine("{0} X {1}= {2}", 4, i, 4 * i);
                i++;
            }

            Console.ReadKey();
        }
    }
}
