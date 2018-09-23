using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4BatallaNaval.Generadores
{
    public class CongruencialMixto : IGeneradores
    {
        public double _seed { get; protected set; }
        public double _a { get; protected set; }
        public double _c { get; protected set; }
        public double _m { get; protected set; }
        public CongruencialMixto(double seed, double a, double c, double m)
        {
            _seed = seed;
            _a = a;
            _c = c;
            _m = m;
        }
        public double Generar()
        {
            var _random = (_a * _seed + _c) % _m;
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