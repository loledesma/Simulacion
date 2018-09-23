using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4BatallaNaval.Generadores;

namespace TP4BatallaNaval.Distribuciones
{
    public class DistribucionUniforme : IDistribuciones
    {
        public double _a { get; protected set; }
        public double _b { get; protected set; }
        public IGeneradores _generator { get; protected set; }

        public DistribucionUniforme(double a, double b)
        {
            if (b <= a)
                throw new NotSupportedException ("El valor de A debe ser menor que B!");
            _a = a;
            _b = b;
        }

        public DistribucionUniforme(double a, double b, IGeneradores generador)
        {
            if (b <= a)
                throw new NotSupportedException ("El valor de A debe ser menor que B!");
            _a = a;
            _b = b;
            _generator = generador;
        }

        public void asignarGenerador(IGeneradores generador)
        {
            _generator = generador;
        }

        public double generar()
        {
            var _random = _generator.Generar();
            // Formula de Generacion de Variables Aleatorias
            var _variable = _a + _random * (_b - _a);
            return _variable;
        }

        public List<double> generar(int cantidad)
        {
            var _variables = new List<double>(cantidad);
            for (int i = 0; i < cantidad; i++)
            {
                _variables.Add(generar());
            }
            return _variables;
        }

        public List<double> getFrecuenciasEsperadas(List<Intervalo> intervalos)
        {
            var _n = intervalos.Count;
            var _frecuenciaEsperada = 1 / (double) _n;
            var _frecuencias = new List<double>(_n);
            for (int i = 0; i < _n; i++)
            {
                _frecuencias.Add(_frecuenciaEsperada);
            }
            return _frecuencias;
        }

        public int getCantidadParametros()
        {
            // Variable "a" y "b"
            return 2;
        }
    }
}