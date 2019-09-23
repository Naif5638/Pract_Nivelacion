using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_VI_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tablaA = new int[2, 2];
            int[,] tablaB = new int[2, 2];
            int[,] tablaC = new int[2, 2];
            tablaA[0, 0] = 70;
            tablaA[0, 1] = 60;
            tablaA[1, 0] = 80;
            tablaA[1, 1] = 70;

            tablaB[0, 0] = 68;
            tablaB[0, 1] = 90;
            tablaB[1, 0] = 80;
            tablaB[1, 1] = 70;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    tablaC[i, j] = tablaA[i, j] + tablaB[i, j];
                }
            }

            //Impresion de tablas
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(tablaA[i, j] + " ");
                }

                for (int j = 0; j < 2; j++)
                {
                    Console.Write(tablaB[i, j] + " ");
                }

                for (int j = 0; j < 2; j++)
                {
                    Console.Write(tablaC[i, j] + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
