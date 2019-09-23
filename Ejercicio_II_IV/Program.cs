using System;

namespace Ejercicio_II_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            double sb, sn, dd, ht, th;
            Console.WriteLine("<<<<<<<<<< Programa que imprime el calculo de horas trabajadas");
            Console.WriteLine("Ingrese la tarifa por horas: ");
            ht = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las horas trabajadas: ");
            th = double.Parse(Console.ReadLine());

            sb = ht * th;
            dd = sb * 0.10;
            sn = sb - dd;

            Console.WriteLine("\nDetalle pago de horas trabajadas: ");
            Console.WriteLine("Sueldo Bruto: {0}", sb);
            Console.WriteLine("Descuento: {0}", dd);
            Console.WriteLine("Sueldo Neto: {0}", sn);
            Console.ReadKey();
        }
    }
}
