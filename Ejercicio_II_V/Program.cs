using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_II_V
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<<<<< Programa que convierte de centímetros a pulgadas >>>>>>");
            double cm, plg;
            const double plgIncm = 2.54;

            Console.Write("Ingrese los centimetros: ");
            cm = double.Parse(Console.ReadLine());

            plg = cm / plgIncm;

            Console.WriteLine("{0} centimetros son {1} pulgada" , cm , plg);
            Console.ReadKey();
        }
    }
}
