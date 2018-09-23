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
        int cant_disparos_estrategia1;
        int cant_disparos_estrategia2;
        int cant_aciertos_estrategia1;
        int cant_aciertos_estrategia2;
        int cant_repetidos_estrategia1;
        int cant_repetidos_estrategia2;
        // Cantidad de Casilleros de Barcos 
        int cant_casillas_flota;
        // modo: FALSE-> Semi-Automatico | TRUE-> Automatico
        Boolean modo;
        // cantidad de barcos de cada tipo
        const int cant_barcosxtipo = 2;
        const int long_max_barco = 6;
        const int long_min_barco = 2;
        IEstrategia estrategia_j1;
        IEstrategia estrategia_j2;
        public List<Flota> flotas_estrategia1;
        public List<Flota> flotas_estrategia2;
        // bUltimoJugador: 0-> Jugador1 | 1-> Jugador2
        public Boolean bUltimoJugador;
        const int seed = 1000;
        const int a = 12;
        const int c = 17;
        const int m = 5000;

        public GestorJuego(Boolean _modo)
        {
            modo = _modo;
        }

        public void cargar_barcos(int jugador)
        {
            int _barcos = 1;
            int _longitud = long_max_barco;
            Flota _flotaCargada;
            while (_barcos <= cant_barcosxtipo)
            {
                while (_longitud >= long_min_barco)
                {
                    _flotaCargada = new Flota(_longitud, obtenerNombre(_longitud), posicionarFlota(_longitud, jugador), obtenerColor(_longitud));
                    if (jugador == 1)
                    {
                        flotas_estrategia1.Add(_flotaCargada);
                    } else
                    {
                        flotas_estrategia2.Add(_flotaCargada);
                    }
                    _longitud--;
                }
            }
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

        public Coordenada obtenerCoordenada()
        {
            CongruencialMixto generador = new CongruencialMixto(seed, a, c, m);
            DistribucionUniforme distr = new DistribucionUniforme(1, 64, generador);
            int _x = (int) Math.Round(distr.generar(), 0);
            int _y = (int) Math.Round(distr.generar(), 0);
            Coordenada coord = new Coordenada(_x, _y);
            return coord;
        }

        public int obtenerSentido()
        {
            int retorno = 0;
            CongruencialMixto generador = new CongruencialMixto(seed, a, c, m);
            DistribucionUniforme distr = new DistribucionUniforme(1, 4, generador);
            retorno = int.Parse(distr.generar().ToString(), System.Globalization.NumberStyles.Integer);
            return retorno;
        }

        public Boolean validarFlota(Coordenada _posini, int _tamaño, int _direccion, int _jugador)
        {
            Boolean retorno = true;
            Boolean flag = true;
            //_direccion: 1-> Arriba | 2-> Abajo | 3-> Izquierda | 4-> Derecha
            switch (_direccion)
            {
                case 0:
                    if (_posini.y - _tamaño < 1)
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
                        }
                    }
                    break;
                case 1:
                    if (_posini.y + _tamaño > 64)
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
                        }
                    }
                    break;
                case 2:
                    if (_posini.x - _tamaño < 1)
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
                        }
                    }
                    break;
                case 3:
                    if (_posini.y + _tamaño > 64)
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
                        while (i <= tamaño)
                        {
                            int val = posori.y - i;
                            Coordenada c = new Coordenada(posori.x, val);
                            lista.Add(c);
                            tablero1[c.x, c.y] = 1;
                            i++;
                        }
                        break;
                    case 2:
                        while (i <= tamaño)
                        {
                            int val = posori.y + i;
                            Coordenada c = new Coordenada(posori.x, val);
                            lista.Add(c);
                            tablero1[c.x, c.y] = 1;
                            i++;
                        }
                        break;
                    case 3:
                        while (i <= tamaño)
                        {
                            int val = posori.x - i;
                            Coordenada c = new Coordenada(val, posori.y);
                            lista.Add(c);
                            tablero1[c.x, c.y] = 1;
                            i++;
                        }
                        break;
                    case 4:
                        while (i <= tamaño)
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
                        while (i <= tamaño)
                        {
                            int val = posori.y - i;
                            Coordenada c = new Coordenada(posori.x, val);
                            lista.Add(c);
                            tablero2[c.x, c.y] = 1;
                            i++;
                        }
                        break;
                    case 2:
                        while (i <= tamaño)
                        {
                            int val = posori.y + i;
                            Coordenada c = new Coordenada(posori.x, val);
                            lista.Add(c);
                            tablero2[c.x, c.y] = 1;
                            i++;
                        }
                        break;
                    case 3:
                        while (i <= tamaño)
                        {
                            int val = posori.x - i;
                            Coordenada c = new Coordenada(val, posori.y);
                            lista.Add(c);
                            tablero2[c.x, c.y] = 1;
                            i++;
                        }
                        break;
                    case 4:
                        while (i <= tamaño)
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
    }
}
