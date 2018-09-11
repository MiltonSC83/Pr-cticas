using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i;
                int[] matriz1 = new int[] { 10, 8, 9, 10, 8 };
                string[] matriz2 = new string[] { "Juan", "Paco", "Pedro", "Anita", "Martha" };
                int[] matriz3 = new int[] { 9, 8, 9, 10, 9 };
                int[] matriz4 = new int[] { 0, 0, 0, 0, 0 };
                int[] matriz5 = new int[] { 0, 0, 0, 0, 0 };


                for (i = 0; i < matriz1.Length; i++)
                {
                    matriz4[i] = matriz1[i] + matriz3[i];
                    matriz5[i] = (matriz4[i]) / 2;

                }

                for (i = 0; i < matriz1.Length; i++)
                {
                    Console.WriteLine("El promedio de calificaciones de {0} es igual a: {1}", matriz2[i], matriz5[i]);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Has ingresado un carácter inválido");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Has ingresado un valor demasiado grande");
            }

            Console.ReadKey();

        }
    }
}
