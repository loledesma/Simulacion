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
                gestor.cargar_barcos();

            }
            else 
            {
                gestor = new GestorJuego(true);
                int _cant_ingresada = int.Parse (txt_cant_simulaciones.Text);
                while (cant_simulaciones <= _cant_ingresada)
                {

                }
            }
        }
    }
}
