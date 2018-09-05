using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    class operaciondiv
    {
        protected double numero1;
        protected double numero2;

        public void setnumero1(double n1)
        {
            numero1 = n1;
        }
        public void setnumero2(double n2)
        {
            numero2 = n2;
            if (numero2 == 0)
            {
                Console.WriteLine("No es posible realizar una división entre cero");
                Console.ReadKey();
                throw new System.DivideByZeroException();

            }
        }
    }
}
