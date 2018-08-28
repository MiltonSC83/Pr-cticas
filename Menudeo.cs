using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Menudeo : Mayoreo
    {
        public void Venta(int cantidad)
        {
            int precio;
            precio = 20;

            Console.WriteLine("El total a pagar por "+(cantidad)+" articulo(s) es de "+(cantidad*precio)+ " pesos.");
        }
    }
}
