using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_II_VI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<<<<<< Programa que calcula la cuota de un prestamo simple >>>>>>>>");
            double m, i, c;
            int t;

            Console.WriteLine("Ingresar Datos del Prestamo:");
            Console.Write("Monto: ");
            m = double.Parse(Console.ReadLine());
            Console.Write("Interés: ");
            i = double.Parse(Console.ReadLine());
            Console.Write("Tiempo: ");
            t = int.Parse(Console.ReadLine());
            i = (i / 100);
            c = ((m * i) / t) + (m / t);

            Console.WriteLine("La cuota del prestamos sera igual a: {0}", c);

            Console.ReadKey();
        }
    }
}
