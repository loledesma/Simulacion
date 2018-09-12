using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meta.Numerics.Statistics.Distributions;
using TrabajoPractico3.Distribuciones;

namespace TrabajoPractico3
{
    public class PruebaChiCuadrado
    {
        public IDistribuciones _distribucion { get; protected set; }
        public int _nTamañoMuestra { get; protected set; }
        public int _cantidadIntervalos { get; protected set; }
        public string _alfa { get; protected set; }
        public List<double> _valores { get; protected set; }
        public List<Intervalo> _intervalos { get; protected set; }
        public List<int> _frecuenciasObservadasAbsolutas { get; protected set; }
        public List<double> _frecuenciasObservadasRelativas { get; protected set; }
        public List<double> _frecuenciasEsperadasAbsolutas { get; protected set; }
        public List<double> _frecuenciasEsperadasRelativas { get; protected set; }
        public List<double> _valoresChiCuadrado { get; protected set; }
        public double _tablaChiCuadrado { get; protected set; }

        public PruebaChiCuadrado (IDistribuciones distribucion, int tamañoMuestra, int cantidadIntervalos, string alfa)
        {
            _distribucion = distribucion;
            _nTamañoMuestra = tamañoMuestra;
            _cantidadIntervalos = cantidadIntervalos;
            _alfa = alfa;
            CalcularValores();
            CalcularIntervalos();
            CalcularFrecuenciasObservadas();
            ObtenerFrecuenciasEsperadas();
            CalcularValoresChiCuadrado();
            ObtenerValorDeTablaChiCuadrado();
        }

        private void CalcularIntervalos()
        {
            var intervalos = new List<Intervalo>(_cantidadIntervalos);
            var min = _valores.Min();
            var max = _valores.Max();
            var paso = (max - min) / _cantidadIntervalos;
            var inicio = min;
            var fin = min + paso;
            // Armo los intervalos.
            for (var i = 0; i < _cantidadIntervalos; i++)
            {
                intervalos.Add(new Intervalo(inicio, fin));
                inicio = fin;
                fin += paso;
            }
            intervalos.Last()._fin = max;
            _intervalos = intervalos;
        }

        private void CalcularValores()
        {
            var val = _distribucion.generar(_nTamañoMuestra);
            _valores = val;
        }

        private void CalcularFrecuenciasObservadas()
        {
            var absolutas = new List<int>(_cantidadIntervalos);
            var relativas = new List<double>(_cantidadIntervalos);
            foreach (var intervalo in _intervalos)
            {
                var encontrados = _valores.Where(valor => valor >= intervalo._inicio && valor < intervalo._fin);
                var absoluta = encontrados.Count();
                var relativa = (double)absoluta / _nTamañoMuestra;
                absolutas.Add(absoluta);
                relativas.Add(relativa);
            }
            //Corrección para contar el máximo valor
            absolutas[_cantidadIntervalos - 1] += 1;
            relativas[_cantidadIntervalos - 1] = (double)absolutas.Last() / _nTamañoMuestra;
            _frecuenciasObservadasAbsolutas = absolutas;
            _frecuenciasObservadasRelativas = relativas;
        }

        private void ObtenerFrecuenciasEsperadas()
        {
            var relativas = _distribucion.getFrecuenciasEsperadas(_intervalos);
            var absolutas = new List<double>(_cantidadIntervalos);
            foreach (var frecuencia in relativas)
            {
                var absoluta = frecuencia * _nTamañoMuestra;
                absolutas.Add(absoluta);
            }
            _frecuenciasEsperadasAbsolutas = absolutas;
            _frecuenciasEsperadasRelativas = relativas;
        }

        private void CalcularValoresChiCuadrado()
        {
            var chiCuadrado = new List<double>();
            for (var i = 0; i < _cantidadIntervalos; i++)
            {
                var observada = _frecuenciasObservadasAbsolutas[i];
                var esperada = _frecuenciasEsperadasAbsolutas[i];
                var valor = calcular(observada, esperada);
                chiCuadrado.Add(valor);
            }
            _valoresChiCuadrado = chiCuadrado;
        }

        public void ObtenerValorDeTablaChiCuadrado()
        {
            var grados = _cantidadIntervalos - _distribucion.getCantidadParametros() - 1;
            var valor = valorDeTabla(grados, _alfa);
            _tablaChiCuadrado = valor;
        }

        public static double calcular(double observada, double esperada)
        {
            if (!(esperada > 0))
                throw new NotSupportedException("La frecuencia esperada debe ser mayor a cero!");
            // Calculo de la Frecuencia.
            var valor = Math.Pow(esperada - observada, 2) / esperada;
            return valor;
        }

        public static double valorDeTabla(int grados, string alfa)
        {
            double confianza = double.Parse(alfa,System.Globalization.CultureInfo.InvariantCulture);
            if (!(grados > 0))
                throw new NotSupportedException("Los grados de libertad deben ser mayores a cero!");

            ContinuousDistribution d = new ChiSquaredDistribution(grados);
            var valor = d.InverseRightProbability(confianza);
            return valor;
        }
    }
}
