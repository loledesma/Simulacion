using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPractico3.Generadores;
using TrabajoPractico3.Distribuciones;
using System.Globalization;

namespace TrabajoPractico3
{
    public partial class frmTP3 : Form
    {
        private IGeneradores _generadorAleatorio;
        private IDistribuciones _distribucion;
        private PruebaChiCuadrado _pruebaChiCuadrado;

        public frmTP3()
        {
            InitializeComponent();
            btn_grafico.Enabled = false;
        }

        private void btn_grafico_Click(object sender, EventArgs e)
        {
            grafico graficoDistribucion = new grafico(_pruebaChiCuadrado); 
            graficoDistribucion.Show();
        }
      
        private bool ValidarFormulario()
        {
            if (radioButton3.Checked)
                return true;
            int semilla;
            int a;
            int c;
            int m;
            if (!int.TryParse(txt_mA.Text, out m) || m <= 0)
            {
                MessageBox.Show(@"El valor de M debe ser un entero positivo");
                txt_mA.Focus();
                return false;
            }

            if (!int.TryParse(txt_semillaA.Text, out semilla) || semilla <= 0 || semilla >= m)
            {
                MessageBox.Show(@"El valor de semilla debe ser un entero positivo menor a M");
                txt_semillaA.Focus();
                return false;
            }

            if (!int.TryParse(txt_aA.Text, out a) || a <= 0 || a >= m)
            {
                MessageBox.Show(@"El valor de A debe ser un entero positivo menor a M");
                txt_aA.Focus();
                return false;
            }

            if (radioButton1.Checked && (!int.TryParse(txt_cA.Text, out c) || c <= 0 || c >= m))
            {
                MessageBox.Show(@"El valor de C debe ser un entero positivo menor a M");
                txt_cA.Focus();
                return false;
            }

            int muestra;
            int intervalos;
            double alfa;
            if (!int.TryParse(txt_cant_nroC.Text, out muestra) || muestra <= 0)
            {
                MessageBox.Show(@"El tamaño de la muestra debe ser un entero positivo");
                txt_cant_nroC.Focus();
                return false;
            }

            if (!int.TryParse(txt_IntC.Text, out intervalos) || intervalos <= 0)
            {
                MessageBox.Show(@"La cantidad de intervalos debe ser un entero positivo");
                txt_IntC.Focus();
                return false;
            }

            alfa = double.Parse(txt_chicierto.Text, CultureInfo.InvariantCulture);
            if (alfa <= 0 || alfa >= 1)
            {
                MessageBox.Show(@"El valor de alfa debe estar entre 0 y 1");
                txt_chicierto.Focus();
                return false;
            }
            return true;
        }

        private bool ValidarDistribucion()
        {
            if (rad_uniforme.Checked)
            {
                double _a;
                double _b;
                if (!double.TryParse(txt_a.Text, out _a))
                {
                    MessageBox.Show(@"El valor de A debe ser un número válido");
                    txt_a.Focus();
                    return false;
                }
                if (!double.TryParse(txt_b.Text, out _b) || _b <= _a)
                {
                    MessageBox.Show(@"El valor de B debe ser mayor que A");
                    txt_b.Focus();
                    return false;
                }
            }
            if (rad_normal.Checked)
            {
                double media;
                double varianza;
                if (!double.TryParse(txt_media.Text, out media))
                {
                    MessageBox.Show(@"La Media debe ser un número válido");
                    txt_media.Focus();
                    return false;
                }
                if (!double.TryParse(txt_varianza.Text, out varianza) || varianza < 0)
                {
                    MessageBox.Show(@"La Varianza no puede ser negativa");
                    txt_varianza.Focus();
                    return false;
                }
            }
            if (rad_exponencial.Checked)
            {
                double lambda;
                if (!double.TryParse(txt_lambda.Text, out lambda) || lambda <= 0)
                {
                    MessageBox.Show(@"Lambda debe ser positiva");
                    txt_lambda.Focus();
                    return false;
                }
            }
            return true;
        }

        private void LimpiarDatosGenerador()
        {
            txt_semillaA.Text = "";
            txt_aA.Text = "";
            txt_cA.Text = "";
            txt_mA.Text = "";
            txt_cant_nroC.Text = "";
            txt_IntC.Text = "";
        }

        private void LimpiarDatosDistribucion()
        {
            txt_a.Text = "";
            txt_b.Text = "";
            txt_media.Text = "";
            txt_varianza.Text = "";
            txt_lambda.Text = "";
        }

        private void LimpiarTablas()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            txt_chi_observado.Text = "";
            txt_esperado.Text = "";
            txt_chi_observado.Enabled = false;
            txt_esperado.Enabled = false;
            txt_chicierto.Text = @"0.05";
            btn_compro.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt_semillaA.Enabled = true;
            txt_aA.Enabled = true;
            txt_cA.Enabled = true;
            txt_mA.Enabled = true;
            LimpiarDatosGenerador();
            txt_semillaA.Focus();
            HabilitarGenerador();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_semillaA.Enabled = true;
            txt_aA.Enabled = true;
            txt_cA.Enabled = false;
            txt_mA.Enabled = true;
            LimpiarDatosGenerador();
            txt_semillaA.Focus();
            HabilitarGenerador();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txt_semillaA.Enabled = false;
            txt_aA.Enabled = false;
            txt_cA.Enabled = false;
            txt_mA.Enabled = false;
            LimpiarDatosGenerador();
            HabilitarGenerador();
        }

        private void rad_uniforme_CheckedChanged(object sender, EventArgs e)
        {
            txt_a.Enabled = true;
            txt_b.Enabled = true;
            txt_media.Enabled = false;
            txt_varianza.Enabled = false;
            txt_lambda.Enabled = false;
            LimpiarDatosDistribucion();
            txt_a.Focus();
            HabilitarGenerador();
        }

        private void rad_normal_CheckedChanged(object sender, EventArgs e)
        {
            txt_a.Enabled = false;
            txt_b.Enabled = false;
            txt_media.Enabled = true;
            txt_varianza.Enabled = true;
            txt_lambda.Enabled = false;
            LimpiarDatosDistribucion();
            txt_media.Focus();
            HabilitarGenerador();
        }

        private void rad_exponencial_CheckedChanged(object sender, EventArgs e)
        {
            txt_a.Enabled = false;
            txt_b.Enabled = false;
            txt_media.Enabled = false;
            txt_varianza.Enabled = false;
            txt_lambda.Enabled = true;
            LimpiarDatosDistribucion();
            txt_lambda.Focus();
            HabilitarGenerador();
        }

        private void HabilitarGenerador()
        {
            var generador = radioButton1.Checked || radioButton2.Checked || radioButton3.Checked;
            var distribucion = rad_uniforme.Checked || rad_normal.Checked || rad_exponencial.Checked;
            btn_PuntoC.Enabled = generador && distribucion;
        }

        private void btn_PuntoC_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                if (ValidarDistribucion())
                {
                    btn_grafico.Enabled = false;
                    GenerarNumeros();
                    if (!(_pruebaChiCuadrado is null))
                    {
                        btn_grafico.Enabled = true;
                    }
                }        
            }
        }
        
        private void GenerarNumeros()
        {
            LimpiarTablas();
            if (radioButton3.Checked)
            {
                _generadorAleatorio = new AleatorioSistema();
            }
            else
            {
                var a = int.Parse(txt_aA.Text);
                var m = int.Parse(txt_mA.Text);
                var semilla = double.Parse(txt_semillaA.Text);
                //Congruencial Multiplicativo : Xn = (A * Xn-1 ) Mod M
                if (radioButton2.Checked)
                {
                    _generadorAleatorio = new CongruencialMultiplicativo(semilla, a, m);
                }
                //Congruencial Mixto : Xn = (A * Xn-1 + C ) Mod M
                else if (radioButton1.Checked)
                {
                    var c = int.Parse(txt_cA.Text);
                    _generadorAleatorio = new CongruencialMixto(semilla, a, c, m);
                }
            }
            generarDistribucion();
        }

        private void generarDistribucion()
        {
            if (rad_uniforme.Checked)
            {
                var a = double.Parse(txt_a.Text);
                var b = double.Parse(txt_b.Text);
                _distribucion = new DistribucionUniforme(a, b, _generadorAleatorio);
            }

            if (rad_normal.Checked)
            {
                var media = double.Parse(txt_media.Text);
                var varianza = double.Parse(txt_varianza.Text);
                _distribucion = new DistribucionNormal(media, varianza, _generadorAleatorio);
            }

            if (rad_exponencial.Checked)
            {
                var lambda = double.Parse(txt_lambda.Text);
                _distribucion = new DistribucionExponencialNegativa(lambda, _generadorAleatorio);
            }

            var tamañoMuestra = int.Parse(txt_cant_nroC.Text);
            var cantidadIntervalos = int.Parse(txt_IntC.Text);
            var alfa = txt_chicierto.Text;
            try
            {
                _pruebaChiCuadrado = new PruebaChiCuadrado(_distribucion, tamañoMuestra, cantidadIntervalos, alfa);
            }
            catch (Exception)
            {
               
                var grados = int.Parse(txt_IntC.Text) - _distribucion.getCantidadParametros() - 1;

                MessageBox.Show(grados <= 0
                    ? @"Grados de libertad insuficientes, utilice más intervalos"
                    : @"Falla la prueba de Chi Cuadrado porque las frecuencias esperadas tienden a cero, utilice menos intervalos");

                txt_mA.Focus();
                return;
            }
            for (var i = 0; i < tamañoMuestra; i++)
            {
                var valor = _pruebaChiCuadrado._valores[i];
                dataGridView1.Rows.Add(i + 1, valor);
            }
            CompletarTabla(4);
        }

        private void CompletarTabla(int decimales)
        {
            for (var i = 0; i < _pruebaChiCuadrado._cantidadIntervalos; i++)
            {
                var subint = $"{decimal.Round((decimal)_pruebaChiCuadrado._intervalos[i]._inicio, decimales)} - " +
                             $"{decimal.Round((decimal)_pruebaChiCuadrado._intervalos[i]._fin, decimales)}";
                var freObs = _pruebaChiCuadrado._frecuenciasObservadasAbsolutas[i];
                var freEsp = decimal.Round((decimal)_pruebaChiCuadrado._frecuenciasEsperadasAbsolutas[i], decimales);
                var freObsRel = decimal.Round((decimal)_pruebaChiCuadrado._frecuenciasObservadasRelativas[i], decimales);
                var freEspRel = decimal.Round((decimal)_pruebaChiCuadrado._frecuenciasEsperadasRelativas[i], decimales);
                var chiCuad = decimal.Round((decimal)_pruebaChiCuadrado._valoresChiCuadrado[i], decimales);

                dataGridView2.Rows.Add(subint, freObs, freEsp, freObsRel, freEspRel, chiCuad);
            }
            dataGridView2.Rows.Add(
                "Totales",
                decimal.Round((decimal)_pruebaChiCuadrado._frecuenciasObservadasAbsolutas.Sum(), decimales),
                decimal.Round((decimal)_pruebaChiCuadrado._frecuenciasEsperadasAbsolutas.Sum(), decimales),
                decimal.Round((decimal)_pruebaChiCuadrado._frecuenciasObservadasRelativas.Sum(), decimales),
                decimal.Round((decimal)_pruebaChiCuadrado._frecuenciasEsperadasRelativas.Sum(), decimales),
                decimal.Round((decimal)_pruebaChiCuadrado._valoresChiCuadrado.Sum(), decimales)
            );
            txt_chi_observado.Text = decimal.Round((decimal)_pruebaChiCuadrado._valoresChiCuadrado.Sum(), decimales)
                .ToString(CultureInfo.InvariantCulture);
            txt_esperado.Text = decimal.Round((decimal)_pruebaChiCuadrado._tablaChiCuadrado, decimales)
                .ToString(CultureInfo.InvariantCulture);
            btn_compro.Enabled = true;
        }

        private void btn_compro_Click(object sender, EventArgs e)
        {
            var chiObtenido = _pruebaChiCuadrado._valoresChiCuadrado.Sum();
            var chiEsperado = _pruebaChiCuadrado._tablaChiCuadrado;
            var mensaje = "";
            if (chiObtenido < chiEsperado)
            {
                mensaje = "Se acepta la hipótesis";  
            }
            else
            {
                mensaje = "Se rechaza la hipótesis";
            }
            MessageBox.Show(mensaje);
        }

        private void btn_limpiar_todo_Click(object sender, EventArgs e)
        {
            LimpiarDatosDistribucion();
            LimpiarDatosGenerador();
            LimpiarTablas();
            btn_grafico.Enabled = false;
        }
    }
}
