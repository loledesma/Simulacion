using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4BatallaNaval.Distribuciones;

namespace TP4BatallaNaval.Estrategias
{
    public class EstrategiaEquipo2 : IEstrategia
    {
        Coordenada ultMovAcertado;
        // ultimoResultado: "0" -> Agua | "1" -> Averiado | "2" -> Hundido | "-1" -> Repetido
        int ultimoResultado;
        int cant_movimientos;
        int cant_agua;
        int cant_barcos_enemigos;
        int cant_aciertos;
        Boolean finaliza_juego;
        List<Flota> flotas;
        int cant_repetidos;
        IDistribuciones distribucion;

        public EstrategiaEquipo2(List<Flota> _list_barcos, IDistribuciones _distrib)
        {
            cant_movimientos = 0;
            cant_agua = 0;
            flotas = _list_barcos;
            cant_barcos_enemigos = _list_barcos.Count();
            cant_aciertos = 0;
            cant_repetidos = 0;
            distribucion = _distrib;
            finaliza_juego = false;
        }

        public Coordenada realizarMovimiento()
        {
            // eso es con numeros aleatorios ES PARA MODIFICAR CON LA ESTRATEGIA DE CADA UNO
            int x = (int)Math.Round(distribucion.generar(), 0);
            int y = (int)Math.Round(distribucion.generar(), 0);
            Coordenada c = new Coordenada(x, y);
            return c;
        }

        public void resultadoMovimiento(Coordenada mov, int resultado)
        {
            ultimoResultado = resultado;
            cant_movimientos++;
            switch (resultado)
            {
                case 0:
                    cant_agua++;
                    break;
                case 1:
                    cant_aciertos++;
                    ultMovAcertado = mov;
                    break;
                case 2:
                    cant_aciertos++;
                    cant_barcos_enemigos--;
                    ultMovAcertado = mov;
                    break;
                case -1:
                    cant_repetidos++;
                    break;
            }

            if (cant_barcos_enemigos == 0)
            {
                finaliza_juego = true;
            }
        }
}
}
