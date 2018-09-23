﻿using System;
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
    public partial class Batalla_Naval : Form
    {
        List<Flota> flotas_tablero1;
        List<Flota> flotas_tablero2;
        public GestorJuego controlador;

        public Batalla_Naval()
        {
            InitializeComponent();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            flotas_tablero1.Clear();
            flotas_tablero2.Clear();
            controlador = null;
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
            if (cb_avanzarmovs.CheckState == CheckState.Checked)
            {
                int cantmovs = 0;
                int movstotal;
                if (int.TryParse(txt_cantmovs.Text, out movstotal))
                {
                    while (cantmovs < movstotal)
                    {

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

            }
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
                    Control pos = tablero1.GetControlFromPosition(posicion.y, posicion.x);
                    pos.BackColor = _flota.color;
                }
            }
            foreach (Flota _flota in flotas_tablero2)
            {
                foreach (Coordenada posicion in _flota.posicionesFlota)
                {
                    Control pos = tablero1.GetControlFromPosition(posicion.y, posicion.x);
                    pos.BackColor = _flota.color;
                }
            }
            MessageBox.Show("Se cargaron los barcos en ambos tableros.");
        }
    }
}
