using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4BatallaNaval
{
    class Flota
    {
        public int tamaño { get; set; }
        public string nombre { get; set; }
        public int color { get; set; }
        public Flota (int _tamaño)
        {
            tamaño = _tamaño;
        }
        public Flota(int _tamaño, int _color, string _nombre)
        {
            tamaño = _tamaño;
            color = _color;
            nombre = _nombre;
        }
    }
}
