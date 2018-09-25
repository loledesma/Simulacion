using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4BatallaNaval;

namespace TP4BatallaNaval
{
    public partial class Main : Form
    {
        GestorJuego gestor;
        int cant_simulaciones;
        int cant_ganados_est1;
        int cant_ganados_est2;
        Grafico grafico;

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // True -> Semi-Automatico     False -> Automatico
            if (rdb_semiautomatico.Checked == true)
            {
                grafico = new Grafico();
                grafico.Show();
            }
            else if (rdb_automatico.Checked == true)
            {
                gestor = new GestorJuego(true);
                cant_simulaciones = 0;
                int _cant_ingresada = int.Parse(txt_cant_simulaciones.Text);
                while (cant_simulaciones < _cant_ingresada)
                {
                    gestor.cargar_barcos(1);
                    gestor.cargar_barcos(2);
                    if (gestor.jugarBatallaNaval(true) == 1)
                    {
                        cant_ganados_est1++;
                    }
                    else
                    {
                        cant_ganados_est2++;
                    }
                    cant_simulaciones++;
                }
                if (cant_ganados_est1 > cant_ganados_est2)
                {
                    MessageBox.Show("Gano el Jugador con la estrategia N° 1 con " + cant_ganados_est1.ToString() + " partidas ganadas de " + cant_simulaciones.ToString() + " partidas simuladas.");
                }
                else if (cant_ganados_est1 < cant_ganados_est2)
                {
                    MessageBox.Show("Gano el Jugador con la estrategia N° 2 con " + cant_ganados_est2.ToString() + " partidas ganadas de " + cant_simulaciones.ToString() + " partidas simuladas.");
                }
                else if (cant_ganados_est1 == cant_ganados_est2)
                {
                    MessageBox.Show("Hubo empate entre ambas estrategias en las " + cant_simulaciones.ToString() + " partidas simuladas.");
                }
            } 
            else if (rdb_automatico.Checked == false || rdb_semiautomatico.Checked == false )
            {
                MessageBox.Show("Debe elegir una modalidad juego" );

            }
        }
    }
}
