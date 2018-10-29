
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4BatallaNaval.Distribuciones;
using TP4BatallaNaval.Estrategias;

namespace TP4BatallaNaval.Estrategias
{
    public class EstrategiaEquipo2 : IEstrategia
    {
        // ultimoResultado: "0" -> Agua | "1" -> Averiado | "2" -> Hundido | "-1" -> Repetido
        private Coordenada ultMovAcertado;
        public int ultimoResultado;
        public int cant_movimientos;
        public int cant_agua;
        public int cant_aciertos;
        public int cant_barcos_hundidos;
        List<Flota> flotas;
        public int cant_repetidos;
        IDistribuciones distribucion;
        List<Coordenada> DisparosProgramados;
        int ultimo_desplazamiento_acertado;
        Coordenada primerMov;
        Coordenada origen;
        //Boolean bpar = true;
        int ultimo_desplazamiento;
        int posicionLista;
        Coordenada movimiento;

        public EstrategiaEquipo2(List<Flota> _list_barcos, IDistribuciones _distrib)
        {
            cant_movimientos = 0;
            cant_movimientos = 0;
            cant_agua = 0;
            flotas = _list_barcos;
            cant_barcos_hundidos = 0;
            cant_aciertos = 0;
            cant_repetidos = 0;
            distribucion = _distrib;
            posicionLista = -1;
        }

        public Coordenada realizarMovimiento()
        {
            // esta estrategia siempre genera un aleatorio, no le interesan los movimientos anteriores.
            int x = 0;
            int y = 0;
            Coordenada c = new Coordenada(x, y);

            if (ultMovAcertado == null)
            {
                //if (cant_repetidos >= 2000)
                //{
                //    if (origen.y < 62)
                //    {
                //        origen.y = origen.y + 2;
                //    }
                //    else
                //    {
                //        if (origen.x < 62)
                //        {
                //            origen.x = origen.x + 2;
                //            if (bpar == true)
                //            {
                //                origen.y = 0;
                //            }
                //            else
                //            {
                //                origen.y = 1;
                //            }

                //        }
                //        else
                //        {
                //            origen.x = 1;
                //            origen.y = 1;
                //            bpar = false;
                //        }
                //    }
                //    c = origen;
                //    return c;
                //}
                //else
                //{
                //    x = (int)Math.Round(distribucion.generar(), 0);
                //    y = (int)Math.Round(distribucion.generar(), 0);
                //    c.x = x;
                //    c.y = y;
                //    return c;
                //}
                if (movimiento == null )
                {
                    x = (int)Math.Round(distribucion.generar(), 0);
                    y = (int)Math.Round(distribucion.generar(), 0);                    
                }
                else
                {
                    if (movimiento.x == 63 || movimiento.y == 63 )
                    {
                        x = (int)Math.Round(distribucion.generar(), 0);
                        y = (int)Math.Round(distribucion.generar(), 0);                       
                        
                    }
                    else
                    {
                        x = movimiento.x + 1;
                        y = movimiento.y + 1;
                    }              
                }
                c.x = x;
                c.y = y;
                movimiento = c;
                return c;
            }
            else
            {// arriba = 1 derecha = 2 abajo = 3 izquierda = 4
                if (ultimo_desplazamiento_acertado != 0)
                {
                    if (ultimoResultado == 0 || ultimoResultado == -1)
                    {
                        ultMovAcertado = primerMov;
                        if (ultimo_desplazamiento_acertado < 4)
                        {
                            ultimo_desplazamiento = ultimo_desplazamiento_acertado + 1;
                        }
                        else
                        {
                            ultimo_desplazamiento = 1;
                        }
                    }
                    else
                    {
                        ultimo_desplazamiento = ultimo_desplazamiento_acertado - 1;
                    }
                }
                ultimo_desplazamiento = validarFinGrilla();
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
                        y = ultMovAcertado.y + 1;
                        c.x = x;
                        c.y = y;
                        ultimo_desplazamiento = 2;
                        break;
                    case 2:
                        x = ultMovAcertado.x + 1;
                        y = ultMovAcertado.y;
                        c.x = x;
                        c.y = y;
                        ultimo_desplazamiento = 3;
                        break;
                    case 3:
                        x = ultMovAcertado.x;
                        y = ultMovAcertado.y - 1;
                        c.x = x;
                        c.y = y;
                        ultimo_desplazamiento = 4;
                        break;
                }
            }
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
                    movimiento = null;
                    break;
                case -1:
                    cant_repetidos++;
                    break;
            }
        }

        public Boolean controlarFlotas(Flota flota)
        {
            Boolean retorno = false;
            // retorno: FALSE -> tocado | TRUE -> hundido

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
        public int validarFinGrilla()
        {
            int desplazamiento = ultimo_desplazamiento;
            if (ultMovAcertado.x == 0 && ultimo_desplazamiento == 0)
            {
                desplazamiento = 1;
            }
            else if (ultMovAcertado.x == 63 && ultimo_desplazamiento == 2)
            {
                desplazamiento = 3;
            }
            else if (ultMovAcertado.y == 0 && ultimo_desplazamiento == 3)
            {
                desplazamiento = 0;
            }
            else if (ultMovAcertado.y == 63 && ultimo_desplazamiento == 1)
            {
                desplazamiento = 2;
            }
            return desplazamiento;
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
