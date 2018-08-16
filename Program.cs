using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tecnologia
{
    class Program
    {
        enum TIPOSDECONEXION {AUXILIAR, CARGADOR}
        static void Main(string[] args)
        {
            bool cargado = false;

            Celular Celular1 = new Celular();

            Celular1.Gama = "Media";
            Celular1.Marca = "Motorola";
            Celular1.Color = "Gris";
            Celular1.Memoria = 32;
            Celular1.TamañoPantalla = 5;

            cargado = Celular1.Cargar((int)TIPOSDECONEXION.CARGADOR);

            if(cargado)
            {
                Console.WriteLine("El celular " + Celular1.Marca + " ha sido conectado a " + Convert.ToString(TIPOSDECONEXION.CARGADOR));
            }
            else
            {
                Console.WriteLine("El celular " + Celular1.Marca + " NO HA SIDO CARGADO");
            }

            Celular Celular2 = new Celular();
            Console.WriteLine("El celular " + Celular2.Marca + " ha sido conectado a " + Convert.ToString(TIPOSDECONEXION.AUXILIAR));

            Console.Read();

        }
    }
}
