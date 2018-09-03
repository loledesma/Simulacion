using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico3.Generadores;
using Meta.Numerics.Statistics.Distributions;

namespace TrabajoPractico3.Distribuciones
{
    public class DistribucionExponencialNegativa : IDistribuciones
    {
        public double _lambda { get; protected set; }
        public IGeneradores _generator { get; protected set; }

        public DistribucionExponencialNegativa(double lambda)
        {
            if (lambda <= 0)
                throw new NotSupportedException("El valor del Lambda debe ser un número positivo!");
            _lambda = lambda;
            _generator = new AleatorioSistema();
        }

        public DistribucionExponencialNegativa(double lambda, IGeneradores generador)
        {
            if (lambda <= 0)
                throw new NotSupportedException("El valor del Lambda debe ser un número positivo!");
            _lambda = lambda;
            _generator = generador;
        }

        public void asignarGenerador(IGeneradores generador)
        {
            _generator = generador;
        }

        public double generar()
        {
            var _random = _generator.Generar();
            // Formula de Generacion de Variable aleatoria
            var _variable = (-1 / _lambda) * Math.Log(1 - _random);
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
            var _frecuencias = new List<double>(intervalos.Count);
            ContinuousDistribution d = new ExponentialDistribution(1 / _lambda);
            foreach (var _intervalo in intervalos)
            {
                var _frecuencia = d.LeftProbability(_intervalo._fin) - d.LeftProbability(_intervalo._inicio);
                _frecuencias.Add(_frecuencia);
            }
            return _frecuencias;
        }

        public int getCantidadParametros()
        {
            // Variable Lambda
            return 1;
        }
    }
}