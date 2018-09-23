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
        Batalla_Naval grafico;
        public Main()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // False -> Semi-Automatico     True -> Automatico
            if (rdb_semiautomatico.Checked == true)
            {
                gestor = new GestorJuego(false);
                grafico = new Batalla_Naval();
                grafico.controlador = gestor;
                grafico.Show();
            }
            else 
            {
                gestor = new GestorJuego(true);
                cant_simulaciones = 1;
                int _cant_ingresada = int.Parse (txt_cant_simulaciones.Text);
                while (cant_simulaciones <= _cant_ingresada)
                {
                    gestor.cargar_barcos(1);
                    gestor.cargar_barcos(2);
                }
            }
        }
    }
}
