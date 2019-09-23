using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_III_I
{
    class Program
    {
        static void Main(string[] args)
        {
            double sb, sn, dd, ht, th;
            Console.WriteLine("<<<<<<<<<< Programa que imprime el calculo de horas trabajadas");
            Console.Write("Ingrese la tarifa por horas: ");
            ht = double.Parse(Console.ReadLine());
            Console.Write("Ingrese las horas trabajadas: ");
            th = double.Parse(Console.ReadLine());

            sb = ht * th;
            if (sb > 5000)
            {
                dd = sb * 0.10;
            }
            else
            {
                dd = sb * 0.05;
            }
            
            sn = sb - dd;

            Console.WriteLine("\nDetalle pago de horas trabajadas: ");
            Console.WriteLine("Sueldo Bruto: {0}", sb);
            Console.WriteLine("Descuento: {0}", dd);
            Console.WriteLine("Sueldo Neto: {0}", sn);
            Console.ReadKey();
        }
    }
}
