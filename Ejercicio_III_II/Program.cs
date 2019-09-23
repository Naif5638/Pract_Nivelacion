using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_III_II
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota_enero = 0, nota_febrero = 0, nota_marzo = 0, nota_abril = 0, promedio = 0;
            string estado;
            Console.WriteLine("<<<<<<<<<< Programa que calcula el promedio de cuatro notas >>>>>>>>>>>>");
            Console.Write("Ingrese la nota de Enero: ");
            nota_enero = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota de Febrero: ");
            nota_febrero = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota de Marzo: ");
            nota_marzo = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota de Abril: ");
            nota_abril = double.Parse(Console.ReadLine());
            promedio = (nota_enero + nota_febrero + nota_marzo + nota_abril) / 4;

            if (promedio <= 65)
            {
                estado = "Reprobado";
            }
            else if (promedio > 65 && promedio <= 75 )
            {
                estado = "Aprobado";
            }
            else if (promedio > 75 && promedio <= 85)
            {
                estado = "Muy Bueno";
            }
            else if (promedio > 85 && promedio <= 90)
            {
                estado = "Sobresaliente";
            }
            else
            {
                estado = "Excelente";
            }

            Console.WriteLine("El promedio es {0} '{1}'", promedio, estado);
            Console.ReadKey();
        }
    }
}
