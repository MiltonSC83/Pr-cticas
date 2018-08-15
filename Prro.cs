using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mascota
{
    class Prro
    {
        public string Tamaño;
        public string Raza;
        public string Sexo;
        public int Peso;
        public string Color;
        public enum TIPOSDECOMIDA {CROQUETAS, BASURA, AGUA }

        public Prro()
        {
            Raza = "Pitbull";
            Peso = 8;
            Sexo = "Macho";
            Tamaño = "Grande";
        }

        public Prro(string raza, int peso, string sexo, string tamaño)
        {
            Raza = "French Puddle";
            Peso = 7;
            Sexo = "Macho";
            Tamaño = "Pequeño";
        }

        void Ladrar ()
        {

        }

        void Correr ()
        {

        }

        public bool Comer (int alimento)
        {
            bool resultado = false;
            if (alimento == (int)TIPOSDECOMIDA.AGUA)
            {
                resultado = false;
            }
            else if (alimento == (int)TIPOSDECOMIDA.BASURA)
            {
                resultado = true;
            }
       
            else if(alimento == (int)TIPOSDECOMIDA.CROQUETAS)
            {
                resultado = true;
            }
            return resultado;
        }
        public void Cagar ()
        {

        }
    }
}
