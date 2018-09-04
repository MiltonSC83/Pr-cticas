using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaDeOperadores
{
    class Compra
    {
        //Programa que realiza la compra de dos articulos diferentes, aplicando el 10% de descuento a uno de ellos
        private double Articulo1;
        private double Articulo2;
        private double Total;


       
        public Compra(double Art1, double Art2 )
        {
            Articulo1 = Art1;
            Articulo2 = Art2;

            Total = Articulo1 + Articulo2;
        }

        public double Articulo11 { get => Articulo1; set => Articulo1 = value; }
        public double Articulo21 { get => Articulo2; set => Articulo2 = value; }
        public double Total1 { get => Total; set => Total = value; }

        public override string ToString()
        {
            return string.Format("{0} + {1} ={2}", Articulo1, Articulo2, Total);
        }

        public static Compra operator +(Compra A1, Compra A2)
        {
            double sum = 0;
            double sumDesc = 0;

            sum = A1.Articulo1 * (1);
            sumDesc = A2.Articulo2 * (.90);

            Compra temp = new Compra(sum, sumDesc);
            return temp;


        }
    }
}
