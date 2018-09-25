using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica9
{
    class Prestamo: IBiblioteca
    {
        private string nombre;
        private string fecha;
        private double numerodecuenta;
        private string libros;
        private double adeudos;
        

        public Prestamo()
        {
            nombre = "";
            fecha = "";
            libros = "";
            numerodecuenta = 0.00;
            adeudos = 0.0;
        }

        public Prestamo(string n, string f, double a, string l, double nc)
        {
            nombre = n;
            fecha = f;
            numerodecuenta = nc;
            libros = l;
            adeudos = a;
            
            
        }

        public void muestraPrestamo()
        {
            Console.WriteLine("Alumno: {0}", nombre);
            Console.WriteLine("Fecha: {0}", fecha);
            Console.WriteLine("Número de cuenta: {0}", adeudos);
            Console.WriteLine("Libros: {0}", libros);
            Console.WriteLine("Debe: $ {0} ", getnumerodecuenta());
            
        }
        public double getnumerodecuenta()
        {
            return numerodecuenta;
        }
    }
}
