using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica9
{
    class Program
    {
        static void Main(string[] args)
        {
            Prestamo p1 = new Prestamo("Milton Osmar Sosa Corona", "25/09/2018",314308067, "El gesticulador", 0.00);
            Prestamo p2 = new Prestamo("José Esteban Flores Toriz", "24/09/2018", 314265789, "El seductor de la patria", 12.50);

            p1.muestraPrestamo();
            p2.muestraPrestamo();
            Console.ReadLine();
        }
    }
}
