using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4BatallaNaval
{    
    class GestorJuego
    {
        int[,] tablero1 = new int[64, 32];
        int[,] mov_tablero1 = new int[64,32];
        int[,] tablero2 = new int[64,32];
        int[,] mov_tablero2 = new int[64,32];
        int cant_disparos_estrategia1;
        int cant_disparos_estrategia2;
        int cant_aciertos_estrategia1;
        int cant_aciertos_estrategia2;
        // Cantidad de Casilleros de Barcos 
        int cant_casillas_flota;
        // modo: 0-> Semi-Automatico | 1-> Automatico
        Boolean modo;
        Batalla_Naval grafico;
        // cantidad de barcos de cada tipo
        const int cant_barcos = 2;
        const int long_max_barco = 6;
        const int long_min_barco = 2;

        public GestorJuego(Boolean _modo)
        {
            modo = _modo;
        }
        public void cargar_barcos()
        {
            int _barcos = 1;
            int _longitud = long_max_barco;
            while (_barcos <= cant_barcos)
            {
                while (_longitud >= long_min_barco)
                {

                    _longitud--;
                }
            }
            if (modo == false)
            {
                grafico.Show();
            }
        }
    }
}
