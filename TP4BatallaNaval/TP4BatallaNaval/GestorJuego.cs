using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4BatallaNaval.Estrategias;
using System.Drawing;
using TP4BatallaNaval.Generadores;
using TP4BatallaNaval.Distribuciones;

namespace TP4BatallaNaval
{    
    public class GestorJuego
    {
        int[,] tablero1 = new int[64, 64];
        int[,] tablero2 = new int[64, 64];
        // modo: FALSE-> Semi-Automatico | TRUE-> Automatico
        Boolean modo;
        // cantidad de barcos de cada tipo
        const int cant_barcosxtipo = 2;
        const int long_max_barco = 6;
        const int long_min_barco = 2;
        public IEstrategia estrategia_j1;
        public IEstrategia estrategia_j2;
        public List<Flota> flotas_estrategia1;
        public List<Flota> flotas_estrategia2;
        // bUltimoJugador: 0-> Jugador1 | 1-> Jugador2
        public Boolean bUltimoJugador = false;
        const int seed = 1000;
        const int a = 12;
        const int c = 17;
        const int m = 5000;
        const int a1 = 13;
        const int c1 = 19;
        const int m1 = 6000;
        const int a2 = 11;
        const int c2 = 18;
        const int m2 = 4500;
        IDistribuciones distrEstrategias;
        IDistribuciones distribucionCoordenadas;
        IDistribuciones distribucionSentidos;
        IGeneradores generadorEstrategia1;
        IGeneradores generadorEstrategia2;
        IGeneradores generadorCoordenadas;
        IGeneradores generadorSentidos;
        public Coordenada movimiento;

        //_modo False ->SemiAutomatico True -> Automatico
        public GestorJuego(Boolean _modo)
        {
            modo = _modo;
        }

        public void cargar_barcos(int jugador)
        {
            int _barcos = 1;
            int _longitud = 0;
            Flota _flotaCargada;
            if (jugador == 1)
            {
                flotas_estrategia1 = new List<Flota>();
                tablero1 = new int[64, 64];
            }
            else
            {
                flotas_estrategia2 = new List<Flota>();
                tablero2 = new int[64, 64];
            }
            while (_barcos <= cant_barcosxtipo)  
            {
                _longitud = long_max_barco;
                while (_longitud >= long_min_barco)
                {
                    List<Coordenada> coordenadas = posicionarFlota(_longitud, jugador);
                    string nombreflota = obtenerNombre(_longitud);
                    Color colorflota = obtenerColor(_longitud);
                    _flotaCargada = new Flota(_longitud, nombreflota, coordenadas, colorflota);
                    if (jugador == 1)
                    {
                        flotas_estrategia1.Add(_flotaCargada);                        
                    }
                    else
                    {
                        flotas_estrategia2.Add(_flotaCargada);
                    }
                    _longitud--;
                }
                _barcos++;
            }
            if (jugador == 1)
            {
                //generadorEstrategia1 = new CongruencialMixto(seed, a1, c1, m1);
                generadorEstrategia1 = new AleatorioSistema();
                distrEstrategias = new DistribucionUniforme(0, 63, generadorEstrategia1);
                //distrEstrategias = new DistribucionNormal(32, 16, generadorEstrategia1);
                //distrEstrategias = new DistribucionExponencialNegativa((0.03125), generadorEstrategia1);
                estrategia_j1 = new EstrategiaEquipo1(flotas_estrategia1, distrEstrategias);
            }
            else
            {
                generadorEstrategia2 = new CongruencialMixto(seed, a2, c2, m2);
                distrEstrategias = new DistribucionUniforme(0, 63, generadorEstrategia2);
                //distrEstrategias = new DistribucionNormal(32, 16, generadorEstrategia2);
                //distrEstrategias = new DistribucionExponencialNegativa((0.03125), generadorEstrategia2);
                estrategia_j2 = new EstrategiaAleatoria(flotas_estrategia2, distrEstrategias);
            }
        }

        public string obtenerEstadistica()
        {
            string retorno;
            retorno = "+ El Jugador 1:" + "\n\r";
            retorno += "   - Realizó " + ((EstrategiaEquipo1)estrategia_j1).cant_movimientos.ToString() + " movimientos totales. " + "\n\r";
            retorno += "   - Realizó " + ((EstrategiaEquipo1)estrategia_j1).cant_agua.ToString() + " movimientos en Agua. " + "\n\r";
            retorno += "   - Realizó " + ((EstrategiaEquipo1)estrategia_j1).cant_repetidos.ToString() + " movimientos Repetidos. " + "\n\r";
            retorno += "   - Realizó " + ((EstrategiaEquipo1)estrategia_j1).cant_aciertos.ToString() + " movimientos en Flotas. " + "\n\r";
            retorno += "   - Hundió " + ((EstrategiaAleatoria)estrategia_j2).cant_barcos_hundidos.ToString() + " Flotas Enemigas. " + "\n\r";
            retorno += "+ El Jugador 2:" + "\n\r";
            retorno += "   - Realizó " + ((EstrategiaAleatoria)estrategia_j2).cant_movimientos.ToString() + " movimientos totales. " + "\n\r";
            retorno += "   - Realizó " + ((EstrategiaAleatoria)estrategia_j2).cant_agua.ToString() + " movimientos en Agua. " + "\n\r";
            retorno += "   - Realizó " + ((EstrategiaAleatoria)estrategia_j2).cant_repetidos.ToString() + " movimientos Repetidos. " + "\n\r";
            retorno += "   - Realizó " + ((EstrategiaAleatoria)estrategia_j2).cant_aciertos.ToString() + " movimientos en Flotas. " + "\n\r";
            retorno += "   - Hundió " + ((EstrategiaEquipo1)estrategia_j1).cant_barcos_hundidos.ToString() + " Flotas Enemigas. " + "\n\r";
            return retorno;
        }

        public string obtenerNombre(int _tamaño)
        {
            string _nombre = "";
            switch (_tamaño)
            {
                case 2:
                    _nombre = "Destructor";
                    break;
                case 3:
                    _nombre = "Corbeta";
                    break;
                case 4:
                    _nombre = "Submarino";
                    break;
                case 5:
                    _nombre = "Fragata";
                    break;
                case 6:
                    _nombre = "Portaaviones";
                    break;
                default:
                    _nombre = "Navío";
                    break;
            }
            return _nombre;
        }

        public Color obtenerColor(int _tamaño)
        {
            Color _color;
            switch (_tamaño)
            {
                case 2:
                    _color = Color.BlueViolet;
                    break;
                case 3:
                    _color = Color.Chocolate;
                    break;
                case 4:
                    _color = Color.DarkGoldenrod;
                    break;
                case 5:
                    _color = Color.LimeGreen;
                    break;
                case 6:
                    _color = Color.MidnightBlue;
                    break;
                default:
                    _color = Color.Indigo;
                    break;
            }
            return _color;
        }

        public List<Coordenada> posicionarFlota(int _longitud, int _jugador)
        {
            List<Coordenada> retorno = new List<Coordenada>();
            Coordenada xy;
            int sentido;
            do
            {
                xy = obtenerCoordenada();
                sentido = obtenerSentido();
            }
            while (validarFlota(xy, _longitud, sentido, _jugador) == false);
            retorno = colocarFlotaEnTablero(xy, sentido, _longitud, _jugador);
            return retorno;
        }

        // para posicionar el barco.
        public Coordenada obtenerCoordenada()
        {
            if (generadorCoordenadas == null)
            {
                generadorCoordenadas = new CongruencialMixto(seed, a, c, m);
                distribucionCoordenadas = new DistribucionUniforme(0, 63, generadorCoordenadas);
            }             
            int _x = (int) Math.Round(distribucionCoordenadas.generar(), 0);
            int _y = (int) Math.Round(distribucionCoordenadas.generar(), 0);
            Coordenada coord = new Coordenada(_x, _y);
            return coord;
        }

        public int obtenerSentido()
        {
            int retorno = 0;
            if (generadorSentidos == null)
            {
                generadorSentidos = new CongruencialMixto(seed, a, c, m);
                distribucionSentidos = new DistribucionUniforme(1, 4, generadorSentidos);
            }
            retorno = Convert.ToInt32(distribucionSentidos.generar());
            return retorno;
        }

        public Boolean validarFlota(Coordenada _posini, int _tamaño, int _direccion, int _jugador)
        {
            Boolean retorno = true;
            Boolean flag = true;
            //_direccion: 1-> Arriba | 2-> Abajo | 3-> Izquierda | 4-> Derecha
            switch (_direccion)
            {
                case 1:
                    if (_posini.y - _tamaño < 0)
                    {
                        retorno = false;
                    }
                    else
                    {
                        int i = 1;
                        while (i <= _tamaño)
                        {
                            flag = validarColisiones(_posini.x, _posini.y - i, _jugador);
                            if (flag == false)
                            {
                                retorno = false;
                            }
                            i++;
                        }
                    }
                    break;
                case 2:
                    if (_posini.y + _tamaño > 63)
                    {
                        retorno = false;
                    }
                    else
                    {
                        int i = 1;
                        while (i <= _tamaño)
                        {
                            flag = validarColisiones(_posini.x, _posini.y + i, _jugador);
                            if (flag == false)
                            {
                                retorno = false;
                            }
                            i++;
                        }
                      
                    }
                    break;
                case 3:
                    if (_posini.x - _tamaño < 0)
                    {
                        retorno = false;
                    }
                    else
                    {
                        int i = 1;
                        while (i <= _tamaño)
                        {
                            flag = validarColisiones(_posini.x - i, _posini.y, _jugador);
                            if (flag == false)
                            {
                                retorno = false;
                            }
                            i++;
                        }
                    
                    }
                    break;
                case 4:
                    if (_posini.x + _tamaño > 63)
                    {
                        retorno = false;
                    }
                    else
                    {
                        int i = 1;
                        while (i <= _tamaño)
                        {
                            flag = validarColisiones(_posini.x + i, _posini.y, _jugador);
                            if (flag == false)
                            {
                                retorno = false;
                            }
                            i++;
                        }                       
                    }
                    break;
            }
            return retorno;
        }

        public Boolean validarColisiones(int _x, int _y, int _jugador)
        {
            Boolean bReturn = true;
            if (_jugador == 1)
            {
                if (tablero1[_x, _y] == 1)
                {
                    return false;
                }
            }
            else
            {
                if (tablero2[_x, _y] == 1)
                {
                    return false;
                }
            }
            return bReturn;
        }

        public List<Coordenada> colocarFlotaEnTablero(Coordenada posori, int sentido, int tamaño, int jugador)
        {
            List<Coordenada> lista = new List<Coordenada>();
            lista.Add(posori);
            int i = 1;
            if (jugador == 1)
            {
                tablero1[posori.x, posori.y] = 1;
                switch (sentido)
                {
                    case 1:
                        while (i < tamaño)
                        {
                            int val = posori.y - i;
                            Coordenada c = new Coordenada(posori.x, val);
                            lista.Add(c);
                            tablero1[c.x, c.y] = 1;
                            i++;
                        }
                        break;
                    case 2:
                        while (i < tamaño)
                        {
                            int val = posori.y + i;
                            Coordenada c = new Coordenada(posori.x, val);
                            lista.Add(c);
                            tablero1[c.x, c.y] = 1;
                            i++;
                        }
                        break;
                    case 3:
                        while (i < tamaño)
                        {
                            int val = posori.x - i;
                            Coordenada c = new Coordenada(val, posori.y);
                            lista.Add(c);
                            tablero1[c.x, c.y] = 1;
                            i++;
                        }
                        break;
                    case 4:
                        while (i < tamaño)
                        {
                            int val = posori.x + i;
                            Coordenada c = new Coordenada(val, posori.y);
                            lista.Add(c);
                            tablero1[c.x, c.y] = 1;
                            i++;
                        }
                        break;
                }
            }
            else
            {
                tablero2[posori.x, posori.y] = 1;
                switch (sentido)
                {
                    case 1:
                        while (i < tamaño)
                        {
                            int val = posori.y - i;
                            Coordenada c = new Coordenada(posori.x, val);
                            lista.Add(c);
                            tablero2[c.x, c.y] = 1;
                            i++;
                        }
                        break;
                    case 2:
                        while (i < tamaño)
                        {
                            int val = posori.y + i;
                            Coordenada c = new Coordenada(posori.x, val);
                            lista.Add(c);
                            tablero2[c.x, c.y] = 1;
                            i++;
                        }
                        break;
                    case 3:
                        while (i < tamaño)
                        {
                            int val = posori.x - i;
                            Coordenada c = new Coordenada(val, posori.y);
                            lista.Add(c);
                            tablero2[c.x, c.y] = 1;
                            i++;
                        }
                        break;
                    case 4:
                        while (i < tamaño)
                        {
                            int val = posori.x + i;
                            Coordenada c = new Coordenada(val, posori.y);
                            lista.Add(c);
                            tablero2[c.x, c.y] = 1;
                            i++;
                        }
                        break;
                }
            }
            return lista;
        }

        public int jugarBatallaNaval(Boolean modo)
        {
            int jugador_ganador = 0;
            //bUltimoJugador: FALSE -> Jugador1 | True -> Jugador2
            int jugador_actual = 1;

            if (modo == true)
            {
                do
                {
                    if (bUltimoJugador == false)
                    {
                        movimiento = estrategia_j1.realizarMovimiento();
                        jugador_actual = 1;
                    }
                    else
                    {
                        movimiento = estrategia_j2.realizarMovimiento();
                        jugador_actual = 2;
                    }
                    bUltimoJugador = !bUltimoJugador;
                }
                while (analizarJugada(jugador_actual, movimiento) == 0);
                jugador_ganador = jugador_actual;
            }
            else
            {
                if (bUltimoJugador == false)
                {
                    movimiento = estrategia_j1.realizarMovimiento();
                    jugador_actual = 1;
                }
                else
                {
                    movimiento = estrategia_j2.realizarMovimiento();
                    jugador_actual = 2;
                }
                int res = analizarJugada(jugador_actual, movimiento);
                if (res != 0)
                {
                    jugador_ganador = jugador_actual;
                }
                bUltimoJugador = !bUltimoJugador;
            }
            return jugador_ganador;
        }

        public int analizarJugada(int nJugador, Coordenada movim)
        {
            int Result = 0;
            if (nJugador == 2)
            {
                if (tablero1[movim.x, movim.y] == 0)
                {
                    tablero1[movim.x, movim.y] = -1;
                    estrategia_j2.resultadoMovimiento(movim, 0);
                }
                else if (tablero1[movim.x, movim.y] == 1)
                {
                    tablero1[movim.x, movim.y] = 2;
                    Flota f = estrategia_j1.obtenerFlota(movim);
                    f.canttoques++;
                    if (estrategia_j1.controlarFlotas(f) == false)
                    {
                        estrategia_j2.resultadoMovimiento(movim, 1);
                    }
                    else
                    {
                        estrategia_j2.resultadoMovimiento(movim, 2);
                    }
                }
                else if (tablero1[movim.x, movim.y] == -1 || tablero1[movim.x, movim.y] == 2)
                {
                    estrategia_j2.resultadoMovimiento(movim, -1);
                }
                if (estrategia_j1.finalizoJuego() == true)
                {
                    Result = nJugador;
                }
                else
                {
                    Result = 0;
                }
            }
            else
            {
                if (tablero2[movim.x, movim.y] == 0)
                {
                    tablero2[movim.x, movim.y] = -1;
                    estrategia_j1.resultadoMovimiento(movim, 0);
                }
                else if (tablero2[movim.x, movim.y] == 1)
                {
                    tablero2[movim.x, movim.y] = 2;
                    Flota f = estrategia_j2.obtenerFlota(movim);
                    f.canttoques++;
                    if (estrategia_j2.controlarFlotas(f) == false)
                    {
                        estrategia_j1.resultadoMovimiento(movim, 1);
                    }
                    else
                    {
                        estrategia_j1.resultadoMovimiento(movim, 2);
                    }
                }
                else if (tablero2[movim.x, movim.y] == -1 || tablero2[movim.x, movim.y] == 2)
                {
                    estrategia_j1.resultadoMovimiento(movim, -1);
                }
                if (estrategia_j2.finalizoJuego() == true)
                {
                    Result = nJugador;
                }
                else
                {
                    Result = 0;
                }
            }
            return Result;
        }
    }
}