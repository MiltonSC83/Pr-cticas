using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Compra : Clientes
    {
        private string _MarcaDeCalzado;

        public string MarcaDeCalzado { get => _MarcaDeCalzado; set => _MarcaDeCalzado = value; }

        private double _NumeroCalzado;

        public double NumeroCalzado { get => _NumeroCalzado; set => _NumeroCalzado = value; }

        private string _ColorCalzado;

        public string ColorCalzado { get => _ColorCalzado; set => _ColorCalzado = value; }

        private int _PrecioCalzado;

        public int PrecioCalzado { get => _PrecioCalzado; set => _PrecioCalzado = value; }


    }
}
