using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tecnologia
{
    class Celular
    {
        public string Gama;
        public string Color;
        public string Marca;
        public int TamañoPantalla;
        public int Memoria;
        public enum TIPOSDECONEXION {AUXILIAR, CARGADOR }

        public Celular()
        {
            Gama = "Alta";
            Color = "Dorado";
            Marca = "Samsung";
            TamañoPantalla = 6;
            Memoria = 128;
        }

        public Celular(string Gama, string Color, string Marca, int TamañoPantalla, int Memoria)
        {
            Gama = "Media";
            Color = "Gris";
            Marca = "Motorola";
            TamañoPantalla = 5;
            Memoria = 32;
        }

        public bool ReproducirMusica (int musica)
        {
            bool resultado = false;
            if (musica == (int)TIPOSDECONEXION.CARGADOR)
            {
                resultado = false;
            }
            else if (musica == (int)TIPOSDECONEXION.AUXILIAR)
            {
                resultado = true;
            }
            return resultado;
        }

        public bool Cargar (int bateria)
        {
            bool resultado1 = false;
            if (bateria == (int)TIPOSDECONEXION.AUXILIAR)
            {
                resultado1 = false;
            }
            else if (bateria == (int)TIPOSDECONEXION.CARGADOR)
            {
                resultado1 = true;
            }
            return resultado1;
        }
        public void Encender ()
        {

        }

        public void Llamar ()
        {

        }
    }
}
