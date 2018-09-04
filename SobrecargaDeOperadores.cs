using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaDeOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Compra C1 = new Compra(1,0);
            Compra C2 = new Compra(0, 3);
            Compra C3;

            C3 = C1 + C2;

            Console.WriteLine("El total de la compra es de: {0}", C3);
            Console.ReadKey();
        }
    }
}
