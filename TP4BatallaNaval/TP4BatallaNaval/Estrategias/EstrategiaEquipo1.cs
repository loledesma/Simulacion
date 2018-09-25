using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4BatallaNaval.Distribuciones;

namespace TP4BatallaNaval.Estrategias
{
     public class EstrategiaEquipo1 : IEstrategia
    {
        Coordenada ultMovAcertado;
        // ultimoResultado: "0" -> Agua | "1" -> Averiado | "2" -> Hundido | "-1" -> Repetido
        int ultimoResultado;
        int cant_movimientos;
        int cant_agua;
        int cant_barcos_hundidos;
        int cant_aciertos;
        int ultimo_desplazamiento_acertado;
        List<Flota> flotas;
        Coordenada primerMov;
        Coordenada origen;
        int cant_repetidos;
        int ultimo_desplazamiento;
        IDistribuciones distribucion;

        public EstrategiaEquipo1(List<Flota> _list_barcos, IDistribuciones _distrib)
        {
            cant_movimientos = 0;
            cant_agua = 0;
            flotas = _list_barcos;
            cant_barcos_hundidos = 0;
            cant_aciertos = 0;
            cant_repetidos = 0;
            distribucion = _distrib;
            ultimo_desplazamiento = 0;
            ultimo_desplazamiento_acertado = 0;
            origen = new Coordenada(0,0);
        }

        public Coordenada realizarMovimiento()
        {
            int x = 0;
            int y = 0;
            Coordenada c = new Coordenada(x, y);
            if (ultMovAcertado == null)
            {
                if (cant_repetidos >= 2000)
                {
                    if (origen.y != 63)
                    {
                        origen.y = origen.y + 1;
                    } else
                    {
                        origen.x = origen.x + 1;
                        origen.y = 0;
                    }
                    c = origen;
                    return c;
                } else
                {
                    x = (int)Math.Round(distribucion.generar(), 0);
                    y = (int)Math.Round(distribucion.generar(), 0);
                    c.x = x;
                    c.y = y;
                    return c;
                }
               
            } else
            {// arriba = 1 derecha = 2 abajo = 3 izquierda = 4
                if (ultimo_desplazamiento_acertado != 0)
                {
                    if (ultimoResultado == 0 || ultimoResultado == -1)
                    {
                        ultMovAcertado = primerMov;
                        if (ultimo_desplazamiento_acertado < 4)
                        {

                            ultimo_desplazamiento = ultimo_desplazamiento_acertado +1 ;
                        }
                        else
                        {
                            ultimo_desplazamiento = 1;
                        }
                    } else
                    {
                        ultimo_desplazamiento = ultimo_desplazamiento_acertado - 1;
                    }
                }
                switch (ultimo_desplazamiento)
                {
                    case 0:
                        x = ultMovAcertado.x - 1;
                        y = ultMovAcertado.y;
                        c.x = x;
                        c.y = y;
                        ultimo_desplazamiento = 1;
                        break;

                    case 1:
                        x = ultMovAcertado.x;
                        y = ultMovAcertado.y +1;
                        c.x = x;
                        c.y = y;
                        ultimo_desplazamiento = 2;
                        break;
                    case 2:
                        x = ultMovAcertado.x +1 ;
                        y = ultMovAcertado.y;
                        c.x = x;
                        c.y = y;
                        ultimo_desplazamiento = 3;
                        break;
                    case 3:
                        x = ultMovAcertado.x;
                        y = ultMovAcertado.y -1 ;
                        c.x = x;
                        c.y = y;
                        ultimo_desplazamiento = 4;
                        break;
                }
                return c;    
            }
            
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
                    if (ultMovAcertado == null)
                    {
                        primerMov = mov;
                    }
                    ultMovAcertado = mov;
                    ultimo_desplazamiento_acertado = ultimo_desplazamiento;
                    ultimo_desplazamiento = 0;
                    break;
                case 2:
                    cant_aciertos++;
                    ultMovAcertado = null;
                    primerMov = null;
                    ultimo_desplazamiento = 0;
                    ultimo_desplazamiento_acertado = 0;
                    break;
                case -1:
                    cant_repetidos++;
                    break;
            }
        }

        public Boolean controlarFlotas(Flota flota)
        {
            // retorno: FALSE -> tocado | TRUE -> hundido
            Boolean retorno = false;
            if (flota.canttoques == flota.tamaño)
            {
                retorno = true;
                cant_barcos_hundidos++;
            }
            return retorno;
        }

        public Flota obtenerFlota(Coordenada c)
        {
            Flota fRet = null;
            foreach (Flota f in flotas)
            {
                foreach (Coordenada co in f.posicionesFlota)
                {
                    if (co.x == c.x && co.y == c.y)
                    {
                        fRet = f;
                    }
                }
            }
            return fRet;
        }

        public Boolean finalizoJuego()
        {
            if (cant_barcos_hundidos == flotas.Count())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
