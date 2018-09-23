using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4BatallaNaval.Generadores;
using TP4BatallaNaval.Distribuciones;

namespace TP4BatallaNaval.Estrategias
{
    public class EstrategiaAleatoria : IEstrategia
    {
        Coordenada ultMovAcertado;
        // ultimoResultado: "0" -> Agua | "1" -> Averiado | "2" -> Hundido | "-1" -> Repetido
        int ultimoResultado;
        int cant_movimientos;
        int cant_agua;
        int cant_barcos_enemigos;
        int cant_aciertos;
        List<Flota> flotas;
        int cant_dañados;
        int cant_repetidos;

        public EstrategiaAleatoria(List<Flota> _list_barcos)
        {
            cant_movimientos = 0;
            cant_agua = 0;
            flotas = _list_barcos;
            cant_barcos_enemigos = _list_barcos.Count();
            cant_aciertos = 0;
        }

        public Coordenada realizarMovimiento(IGeneradores _generador)
        {
            Coordenada c;
            DistribucionUniforme distribucion = new DistribucionUniforme(1, 64, _generador);
            int x;
            int y;
            switch (ultimoResultado)
            {
                case 0:
                    x = (int)Math.Round(distribucion.generar(), 0);
                    y = (int)Math.Round(distribucion.generar(), 0);
                    c = new Coordenada(x, y);
                    return c;
                case 1:
                    c = new Coordenada(1, 1);
                    return c;
                case 2:
                    x = (int)Math.Round(distribucion.generar(), 0);
                    y = (int)Math.Round(distribucion.generar(), 0);
                    c = new Coordenada(x, y);
                    return c;
                case -1:
                    x = (int)Math.Round(distribucion.generar(), 0);
                    y = (int)Math.Round(distribucion.generar(), 0);
                    c = new Coordenada(x, y);
                    return c;
                default:
                    x = (int)Math.Round(distribucion.generar(), 0);
                    y = (int)Math.Round(distribucion.generar(), 0);
                    c = new Coordenada(x, y);
                    return c;
            }
        }

        public void resultadoMovimiento(Coordenada mov, int resultado)
        {
            ultimoResultado = resultado;
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
        }
    }
}
