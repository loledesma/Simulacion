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



namespace TrabajoPractico3
{
    public partial class frmTP3 : Form
    {
        private IGeneradores _generadorAleatorio;
        private IDistribuciones _distribucion;

        public frmTP3()
        {
            InitializeComponent();
        }
        private void btn_grafico_Click(object sender, EventArgs e)
        {
            grafico graficoDistribucion = new grafico(); 
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

            if (!int.TryParse(txt_mA.Text, out m) ||
                m <= 0)
            {
                MessageBox.Show(@"El valor de M debe ser un entero positivo");
                txt_mA.Focus();
                return false;
            }

            if (!int.TryParse(txt_semillaA.Text, out semilla) ||
                semilla <= 0 || semilla >= m)
            {
                MessageBox.Show(@"El valor de semilla debe ser un entero positivo menor a M");
                txt_semillaA.Focus();
                return false;
            }

            if (!int.TryParse(txt_aA.Text, out a) ||
                a <= 0 || a >= m)
            {
                MessageBox.Show(@"El valor de A debe ser un entero positivo menor a M");
                txt_aA.Focus();
                return false;
            }

            if (radioButton1.Checked && (!int.TryParse(txt_cA.Text, out c) ||
                c <= 0 || c >= m))
            {
                MessageBox.Show(@"El valor de C debe ser un entero positivo menor a M");
                txt_cA.Focus();
                return false;
            }
            int muestra;
            int intervalos;
            double alfa;

            if (!int.TryParse(txt_cant_nroC.Text, out muestra)
                || muestra <= 0)
            {
                MessageBox.Show(@"El tamaño de la muestra debe ser un entero positivo");
                txt_cant_nroC.Focus();
                return false;
            }

            if (!int.TryParse(txt_IntC.Text, out intervalos)
                || intervalos <= 0)
            {
                MessageBox.Show(@"La cantidad de intervalos debe ser un entero positivo");
                txt_IntC.Focus();
                return false;
            }

            if (!double.TryParse(txt_chicierto.Text, out alfa)
                || alfa <= 0 || alfa >= 1)
            {
                MessageBox.Show(@"El valor de alfa debe estar entre 0 y 1");
                txt_chicierto.Focus();
                return false;
            }

            if (rad_uniforme.Checked)
            {
                double a;
                double b;

                if (!double.TryParse(txt_a.Text, out a))
                {
                    MessageBox.Show(@"El valor de A debe ser un número válido");
                    txt_a.Focus();
                    return false;
                }

                if (!double.TryParse(txt_b.Text, out b) || b <= a)
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
                    MessageBox.Show(@"La Varianza debe ser positiva");
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

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
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
                btn_cancelar.Enabled = true;
                GenerarNumeros();
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

        }

        private void btn_compro_Click(object sender, EventArgs e)
        {
            var chiObtenido = 0;
            var chiEsperado = 0;
            var mensaje = "";

            if (chiObtenido < chiEsperado) {
                mensaje = "Se acepta la hipótesis";
  
            }else
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
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
