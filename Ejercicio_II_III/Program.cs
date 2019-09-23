using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_II_III
{
    class Program
    {
        static void Main(string[] args)
        {
            string producto;
            double precio, sTotal, mItbis, total, itbis = 18.0;
            int cantidad;
            Console.WriteLine("<<<<<<<<<<< Programa que imprime subtotal, monto itbis y total de un producto >>>>>>>>>>>>>");
            Console.Write("Ingrese el nombre del producto: ");
            producto = Console.ReadLine();
            Console.Write("Ingrese el precio: ");
            precio = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            sTotal = precio * cantidad;
            mItbis = (sTotal * (itbis / 100));
            total = sTotal + mItbis;

            Console.WriteLine("\nImpresion de producto:");
            Console.WriteLine("Producto: {0}",producto);
            Console.WriteLine("Sub-Total: {0}", sTotal);
            Console.WriteLine("Monto Itbis: {0}", mItbis);
            Console.WriteLine("Total a Pagar: {0}", total);
            Console.ReadKey();
        }
    }
}
