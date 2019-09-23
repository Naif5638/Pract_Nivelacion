using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_VI_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que Imprime un tabla con nombres de personas");
            string[,] tabla = new string[2,3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Indice [{0},{1}] ingrese un nombre: ", i, j);
                    tabla[i, j] = Console.ReadLine();
                }
            }

            //Impresion de nombres 
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tabla[i, j] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
