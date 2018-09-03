using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TrabajoPractico3.Generadores
{
    public class AleatorioSistema : IGeneradores
    {
        public double Generar()
        {
            Thread.Sleep(20);
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