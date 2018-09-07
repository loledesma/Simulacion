using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3
{
    public class Intervalo
    {
        public double _inicio { get; set; }
        public double _fin { get; set; }
        public double _marca { get; set; }

        public Intervalo (double inicio, double fin)
        {
            if (fin <= inicio)
                throw new NotSupportedException ("El final del intervalo debe ser mayor al inicio del intervalo!");
            _inicio = inicio;
            _fin = fin;
            _marca = _inicio + ((_fin - _inicio) / 2);
        }
    }
}
