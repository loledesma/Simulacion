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
        Coordenada ultimoMovimiento;

        public Grafico()
        {
            InitializeComponent();
            generarGrilla();
            controlador = new GestorJuego(false);
        }

        private void generarGrilla()
        {
            int a = 0;
            for (a = 0; a < 64; a++)
            {
                DataGridViewColumn col = new DataGridViewColumn();
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.Style.BackColor = Color.White;
                col.CellTemplate = cell;
                col.Name = a.ToString();
                tablero1.Columns.Insert(a, col);
                tablero1.Columns[a].Width = 10;
            }
            int b = 0;
            for (b = 0; b < 64; b++)
            {
                tablero1.Rows.Add();
                tablero1.Rows[b].Height = 10;
            }
            a = 0;
            for (a = 0; a < 64; a++)
            {
                DataGridViewColumn col = new DataGridViewColumn();
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.Style.BackColor = Color.White;
                col.CellTemplate = cell;
                col.Name = a.ToString();
                tablero2.Columns.Insert(a, col);
                tablero2.Columns[a].Width = 10;
            }
            b = 0;
            for (b = 0; b < 64; b++)
            {
                tablero2.Rows.Add();
                tablero2.Rows[b].Height = 10;
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            flotas_tablero1.Clear();
            flotas_tablero2.Clear();
            tablero1.Rows.Clear();
            tablero1.Columns.Clear();
            tablero1.Refresh();
            tablero2.Rows.Clear();
            tablero2.Columns.Clear();
            tablero2.Refresh();
            generarGrilla();
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
            controlador.cargar_barcos(1);
            controlador.cargar_barcos(2);
            flotas_tablero1 = controlador.flotas_estrategia1;
            flotas_tablero2 = controlador.flotas_estrategia2;
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
            btn_play.Enabled = true;
            cb_avanzarmovs.Enabled = true;
            txt_cantmovs.Enabled = true;
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
            btn_play.Enabled = false;
            if (cb_avanzarmovs.CheckState == CheckState.Checked)
            {
                int cantmovs = 0;
                int movstotal;
                int.TryParse(txt_cantmovs.Text, out movstotal);
                if (movstotal > 0)
                {
                    while (cantmovs < movstotal)
                    {
                        int jugador_ganador = controlador.jugarBatallaNaval(false);
                        ultimoMovimiento = controlador.movimiento;
                        if (controlador.bUltimoJugador == true)
                        {
                            if (tablero2.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor == Color.White)
                            {
                                tablero2.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor = Color.LightBlue;
                            }
                            else if (tablero2.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor == Color.LightBlue)
                            {
                                tablero2.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                tablero2.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor = Color.Red;
                            }
                        }
                        else
                        {
                            if (tablero1.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor == Color.White)
                            {
                                tablero1.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor = Color.LightBlue;
                            }
                            else if (tablero1.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor == Color.LightBlue)
                            {
                                tablero1.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                tablero1.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor = Color.Red;
                            }
                        }
                        if (jugador_ganador != 0) 
                        {
                            MessageBox.Show("El jugador ganador es el N° " + jugador_ganador.ToString() + ".");
                            break;
                        }
                        cantmovs++;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un valor Numerico positivo en la cantida de movimientos a anvanzar!");
                    txt_cantmovs.Text = "";
                    txt_cantmovs.Focus();
                }
            }
            else
            {
                int jugador_ganador = controlador.jugarBatallaNaval(false);
                ultimoMovimiento = controlador.movimiento;
                if (controlador.bUltimoJugador == true)
                {
                    if (tablero2.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor == Color.White)
                    {
                        tablero2.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor = Color.LightBlue;
                    }
                    else if (tablero2.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor == Color.LightBlue)
                    {
                        tablero2.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor = Color.LightBlue;
                    }
                    else
                    {
                        tablero2.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor = Color.Red;
                    }
                }
                else
                {
                    if (tablero1.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor == Color.White)
                    {
                        tablero1.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor = Color.LightBlue;
                    }
                    else if (tablero1.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor == Color.LightBlue)
                    {
                        tablero1.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor = Color.LightBlue;
                    }
                    else
                    {
                        tablero1.Rows[ultimoMovimiento.x].Cells[ultimoMovimiento.y].Style.BackColor = Color.Red;
                    }
                }
                if (jugador_ganador != 0)
                {
                    MessageBox.Show("El jugador ganador es el N° " + jugador_ganador.ToString() + ".");
                }
            }
            btn_play.Enabled = true;
        }

        private void Grafico_Load(object sender, EventArgs e)
        {
            btn_play.Enabled = false;
            btn_limpiar.Enabled = false;
        }
    }
}
