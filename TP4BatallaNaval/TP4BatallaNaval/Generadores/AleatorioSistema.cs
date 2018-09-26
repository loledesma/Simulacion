using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TP4BatallaNaval.Generadores
{
    public class AleatorioSistema : IGeneradores
    {
        public double Generar()
        {
            Thread.Sleep(1);
            var _random = new Random().NextDouble();
            return _random;
        }

        public int Generar(int cifras)
        {
            var _random = Generar();
            return (int)(_random * Math.Pow(10, cifras));
        }
    }
}