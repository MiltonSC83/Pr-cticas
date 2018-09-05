using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    class Program
    {
        static void Main(string[] args)
        {

            double numero1 = 0;
            string numero1String = "";
            double numero2 = 0;
            string numero2String = "";

            Console.WriteLine("Este programa realiza la division de dos numeros dados por el usuario");

            try
            {
                Console.WriteLine("Introduce el dividendo");
                numero1String = Console.ReadLine();
                numero1 = Convert.ToInt16(numero1String);

                Console.WriteLine("Introduce el divisor");
                numero2String = Console.ReadLine();
                numero2 = Convert.ToInt16(numero2String);
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Has ingresado un carácter inválido");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El valor ingresado es demasiado grande");
            }

            Console.ReadLine();

            division Sum = new division();

            Sum.setnumero1(numero1);
            Sum.setnumero2(numero2);
            
            Console.WriteLine("La division es = {0}", Sum.getDividendo());
            Console.ReadKey();
        }
        
    }
}
