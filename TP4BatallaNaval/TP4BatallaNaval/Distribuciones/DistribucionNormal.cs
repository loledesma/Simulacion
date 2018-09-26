using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4BatallaNaval.Generadores;
using Meta.Numerics.Statistics.Distributions;

namespace TP4BatallaNaval.Distribuciones
{
    public class DistribucionNormal : IDistribuciones
    {
        public double _media { get; protected set; }
        public double _varianza { get; protected set; }
        public IGeneradores _generator { get; protected set; }

        public DistribucionNormal (double media, double varianza)
        {
            if (varianza < 0)
                throw new NotSupportedException ("El valor de la varianza no puede ser negativo!");
            _media = media;
            _varianza = varianza;
            _generator = new AleatorioSistema();
        }

        public DistribucionNormal (double media, double varianza, IGeneradores generador)
        {
            if (varianza < 0)
                throw new NotSupportedException ("El valor de la varianza no puede ser negativo!");
            _media = media;
            _varianza = varianza;
            _generator = generador;
        }

        public void asignarGenerador(IGeneradores generador)
        {
            _generator = generador;
        }

        public double generar()
        {
            var _firstRandom = _generator.Generar();
            var _secondRandom = _generator.Generar();            
            var z = Math.Sqrt(-2 * Math.Log(_firstRandom)) * Math.Cos(2 * Math.PI * _secondRandom);
            // Formula de Generacion de Variables Aleatorias
            var _variable = _media + z * Math.Sqrt(_varianza);
            return _variable;
        }

        public List<double> generar(int cantidad)
        {
            var _variable = new List<double>(cantidad);
            for (int i = 0; i < cantidad; i++)
            {
                _variable.Add(generar());
            }
            return _variable;
        }

        public List<double> getFrecuenciasEsperadas(List<Intervalo> intervalos)
        {
            var _frecuencias = new List<double>(intervalos.Count);
            ContinuousDistribution d = new NormalDistribution (_media, _varianza);
            foreach (var intervalo in intervalos)
            {
                var _frecuencia = d.LeftProbability(intervalo._fin) - d.LeftProbability(intervalo._inicio);
                _frecuencias.Add(_frecuencia);
            }            
            return _frecuencias;
        }

        public int getCantidadParametros()
        {
            // Media y Varianza
            return 2;
        }
    }
}