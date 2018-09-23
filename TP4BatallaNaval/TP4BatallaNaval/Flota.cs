using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP4BatallaNaval
{
    public class Flota
    {
        public int tamaño { get; set; }
        public string nombre { get; set; }
        public Color color { get; set; }
        public List<Coordenada> posicionesFlota { get; set; }

        public Flota (int _tamaño)
        {
            tamaño = _tamaño;
        }
        public Flota(int _tamaño, string _nombre, List<Coordenada> _posiciones)
        {
            tamaño = _tamaño;
            posicionesFlota = _posiciones;
            nombre = _nombre;
        }
        public Flota(int _tamaño, string _nombre, List<Coordenada> _posiciones, Color _color)
        {
            tamaño = _tamaño;
            posicionesFlota = _posiciones;
            nombre = _nombre;
            color = _color;
        }
    }
}
