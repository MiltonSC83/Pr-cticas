using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            Compra Cliente;
            Cliente = new Compra();
            Cliente.Nombre = "Margarita";
            Cliente.Edad = 19;
            Cliente.Sexo = "Femenino";
            Cliente.MarcaDeCalzado = "Zara";
            Cliente.NumeroCalzado = 5.5;
            Cliente.PrecioCalzado = 995;

            Console.WriteLine(Cliente.Nombre + " de " + Cliente.Edad + " años, de sexo " +Cliente.Sexo);
            Console.WriteLine("Ordenó calzado " + Cliente.MarcaDeCalzado + " de tamaño " + Cliente.NumeroCalzado);
            Console.WriteLine("Con un precio de " + Cliente.PrecioCalzado + " pesos. ");
            Console.ReadKey();


        }
    }
}
