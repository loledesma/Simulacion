using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4BatallaNaval
{
    public partial class Grafico : Form
    {
        List<Flota> flotas_tablero1;
        List<Flota> flotas_tablero2;
        GestorJuego controlador;

        public Grafico()
        {
            InitializeComponent();
            for (int a = 0; a < 64; a++)
            {
                DataGridViewColumn col = new DataGridViewColumn();
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                col.CellTemplate = cell;
                col.Name = a.ToString();
                tablero1.Columns.Insert(a, col);
                tablero1.Columns[a].Width = 10;
            }
            for (int b = 0; b < 64; b++)
            {
                tablero1.Rows.Add();               
                tablero1.Rows[b].Height = 10;
            }

            for (int a = 0; a < 64; a++)
            {
                DataGridViewColumn col = new DataGridViewColumn();
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                col.CellTemplate = cell;
                col.Name = a.ToString();
                tablero2.Columns.Insert(a, col);
                tablero2.Columns[a].Width = 10;
            }
            for (int b = 0; b < 64; b++)
            {
                tablero2.Rows.Add();
                tablero2.Rows[b].Height = 10;
            }
        }

        public void asignarFlotas(List<Flota> _flotajugador, int jugador)
        {
            if (jugador == 1)
            {
                flotas_tablero1 = _flotajugador;
            }
            else
            {
                flotas_tablero2 = _flotajugador;
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            flotas_tablero1.Clear();
            flotas_tablero2.Clear();
            tablero1.Controls.Clear();
            tablero2.Controls.Clear();
            btn_cargar_barcos.Enabled = true;
            btn_limpiar.Enabled = false;
            btn_play.Enabled = false;
            cb_avanzarmovs.Enabled = false;
            cb_avanzarmovs.CheckState = CheckState.Unchecked;
            txt_cantmovs.Text = "";
            txt_cantmovs.Enabled = false;
            lbl_estado.Visible = false;
        }

        private void btn_cargar_barcos_Click(object sender, EventArgs e)
        {
            btn_limpiar.Enabled = true;
            btn_cargar_barcos.Enabled = false;
            foreach (Flota _flota in flotas_tablero1)
            {
                foreach (Coordenada posicion in _flota.posicionesFlota)
                {
                    tablero1[posicion.y, posicion.x].Style.BackColor = _flota.color;
                }
            }
            foreach (Flota _flota in flotas_tablero2)
            {
                foreach (Coordenada posicion in _flota.posicionesFlota)
                {
                    tablero2[posicion.y, posicion.x].Style.BackColor = _flota.color;
                }
            }
            MessageBox.Show("Se cargaron los barcos en ambos tableros.");
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            btn_limpiar_Click(sender, e);
            Close();
        }

        private void cb_avanzarmovs_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_avanzarmovs.CheckState == CheckState.Checked)
            {
                txt_cantmovs.Enabled = true;
            }
            else
            {
                txt_cantmovs.Enabled = false;
            }
            txt_cantmovs.Text = "";
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            controlador = new GestorJuego(false);
            if (cb_avanzarmovs.CheckState == CheckState.Checked)
            {
                int cantmovs = 0;
                int movstotal;
                if (int.TryParse(txt_cantmovs.Text, out movstotal))
                {
                    while (cantmovs < movstotal)
                    {
                        int jugador_ganador = controlador.jugarBatallaNaval(false);
                        if (jugador_ganador != 0)
                        {
                            MessageBox.Show("El jugador ganador es el N° " + jugador_ganador.ToString() + ".");
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un valor Numerico en la cantida de movimientos a anvanzar!");
                    txt_cantmovs.Text = "";
                    txt_cantmovs.Focus();
                }
            }
            else
            {
                int jugador_ganador = controlador.jugarBatallaNaval(false);
                if (jugador_ganador != 0)
                {
                    MessageBox.Show("El jugador ganador es el N° " + jugador_ganador.ToString() + ".");
                }
            }
        }
    }
}
