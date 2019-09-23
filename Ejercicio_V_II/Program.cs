using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_V_II
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Console.WriteLine("**************MENÚ DE OPCIONES ****************");
                Console.WriteLine("Tabla de Multiplicar [T]");
                Console.WriteLine("Calcular Promedio [P] de una tabla generada");
                Console.WriteLine("SALIR [S]");
                Console.WriteLine("*****************************************************");
                Console.Write("Elija una Opción: ");
                opcion = Console.ReadLine();
                Console.WriteLine();
                switch (opcion)
                {
                    case "t":
                    case "T":
                        int a = 0, b, i;
                        Console.WriteLine("Programa que imprime la tabla deseada");
                        Console.Write("Tabla a imprimir: ");
                        b = int.Parse(Console.ReadLine());

                        Console.WriteLine("tabla de multiplicar del {0}", b);
                        Console.Write("Hasta donde multiplicar: ");
                        a = int.Parse(Console.ReadLine());
                        for (i = 1; i <= a; i++)
                        {
                            Console.WriteLine("{0} X {1}= {2}", b, i, b * i);
                        }
                        Console.WriteLine();
                        break;
                    case "p":
                    case "P":
                        double n = 0.0, p = 0.0;
                        Console.WriteLine("Calculo de Promedio de 4 notas.");
                        
                        Console.Write("Ingresar la cantidad de notas a calcular: ");
                        n = double.Parse(Console.ReadLine());
                        for (int j = 1; j <= n; j++)
                        {
                            Console.Write("Ingresar la nota {0}: ", j);
                            p += double.Parse(Console.ReadLine());
                        }
                        p /= n;
                        Console.WriteLine("El promedio es {0}", p);
                        Console.WriteLine();
                        break;
                    case "s":
                    case "S":
                        Console.WriteLine("Hasta la proxima....");
                        break;
                    default:
                        break;
                }                
            } while (opcion != "s" & opcion != "S");

            Console.ReadKey();
        }
    }
}
