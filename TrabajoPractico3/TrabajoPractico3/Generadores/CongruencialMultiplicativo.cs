using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3.Generadores
{
    public class CongruencialMultiplicativo : IGeneradores
    {
        public double _seed { get; protected set; }
        public double _a { get; protected set; }
        public double _m { get; protected set; }

        public CongruencialMultiplicativo(double seed, double a, double m)
        {
            _seed = seed;
            _a = a;
            _m = m;
        }
        public double Generar()
        {
            var _random = (_a * _seed) % _m;
            _seed = _random;
            return _random / _m;
        }
        public int Generar(int cifras)
        {
            var _random = Generar();
            return (int)(_random * Math.Pow(10, cifras));
        }
    }
}