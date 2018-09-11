using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[2, 2];
            string[,] matriz6 = new string[2, 2];
            int[,] matriz2 = { { 1, 2 }, { 2, 0 } };
            int[,] matriz3 = { { 3, 5 }, { 7, 2 } };
            string[,] matriz4 = { { "Alberto", "15" }, {"rojo","2003" } };
            string[,] matriz5 = { { "Nombre", "Edad" }, { "Color favorito", "Año de nacimiento" } };
            int i;
            int j;
            //Suma de dos matrices
            for(i=0; i<2; i++)
            {
            for(j=0; j<2; j++)
                {
                    matriz1[i, j] = matriz2[i, j] + matriz3[i, j];
                    Console.WriteLine(matriz1[i,j]);
                }
            }
            Console.WriteLine("---------------------");
            //Resta de dos matrices
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    matriz1[i, j] = matriz2[i, j] - matriz3[i, j];
                    Console.WriteLine(matriz1[i, j]);
                }
            }

            Console.WriteLine("---------------------");
            //Operación entre dos objetos
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("El dato {0} tiene como resultado {1}", matriz5[i,j],matriz4[i,j] );
                }
            }

            Console.ReadKey();
        }
    }
}
