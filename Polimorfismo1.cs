using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Mayoreo compra1 = new Mayoreo();

            compra1.Venta(10);

            Menudeo compra2 = new Menudeo();

            compra2.Venta(0);

            Console.ReadKey();
        }
    }
}
