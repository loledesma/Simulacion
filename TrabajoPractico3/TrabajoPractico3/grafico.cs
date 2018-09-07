using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico3
{
    public partial class grafico : Form
    {
        private PruebaChiCuadrado _pruebaChiCuadrado;

        public grafico()
        {
            InitializeComponent();
        }

        public grafico(PruebaChiCuadrado pruebachi)
        {
            InitializeComponent();
            _pruebaChiCuadrado = pruebachi;
            cargarHistograma(3);
        }

        private void cargarHistograma(int decimales)
        {
            histogramaGenerado.Series.Add("Frecuecias Observadas");
            histogramaGenerado.Series.Add("Frecuecias Esperadas");
            for (var i = 0; i < _pruebaChiCuadrado._cantidadIntervalos; i++)
            {
                histogramaGenerado.Series[0].Points.Add(_pruebaChiCuadrado._frecuenciasObservadasAbsolutas[i]);
                histogramaGenerado.Series[1].Points.Add((double)decimal.Round((decimal)_pruebaChiCuadrado._frecuenciasEsperadasAbsolutas[i], decimales));
                histogramaGenerado.Series[0].Points[i].AxisLabel = $"[{decimal.Round((decimal)_pruebaChiCuadrado._intervalos[i]._marca, decimales)}]";
                histogramaGenerado.Series[0].IsValueShownAsLabel = true;
                histogramaGenerado.Series[1].IsValueShownAsLabel = true;
            }
            histogramaGenerado.ChartAreas[0].AxisY.Maximum = _pruebaChiCuadrado._frecuenciasObservadasAbsolutas.Max();
            histogramaGenerado.Series[0].Color = Color.Aqua;
            histogramaGenerado.Series[1].Color = Color.LightGreen;
        }
    }
}
