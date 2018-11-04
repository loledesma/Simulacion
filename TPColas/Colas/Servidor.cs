using System;
using System.Diagnostics.CodeAnalysis;
using Colas.Colas;
using NumerosAleatorios.VariablesAleatorias;

namespace Colas
{
    public class Servidor
    {
        public IDistribucion DistribucionAtencion { get; protected set; }
        public IDistribucion DistribucionBloqueo { get; protected set; }
        public string Nombre { get; protected set; }
        public DateTime? ProximoFinAtencion { get; protected set; }
        public string Estado { get; protected set; }
        public ICola Cola { get; protected set; }
        public Cliente ClienteActual { get; protected set; }
        public int CantidadAtendidos { get; protected set; }
        public Boolean bContinua { get; protected set; }
        public IDistribucion DistribucionLitros { get; protected set; }
        public int nTipoContinua { get; protected set; } 
        public IDistribucion DistribucionK { get; protected set; }

        public Servidor(IDistribucion atencion, ICola cola, string nombre, Boolean cont)
        {
            DistribucionAtencion = atencion;
            Cola = cola;
            Nombre = nombre;
            Estado = "Libre";
            CantidadAtendidos = 0;
            bContinua = cont;
        }

        public Servidor(IDistribucion atencion, ICola cola, string nombre, Boolean cont, IDistribucion bloqueo, IDistribucion litros, IDistribucion distrK, int tipoCont)
        {
            DistribucionAtencion = atencion;
            Cola = cola;
            Nombre = nombre;
            Estado = "Libre";
            DistribucionBloqueo = bloqueo;
            CantidadAtendidos = 0;
            bContinua = cont;
            DistribucionLitros = litros;
            nTipoContinua = tipoCont;
            DistribucionK = distrK;
        }

        public bool EstaLibre()
        {
            return Estado.Equals("Libre");
        }

        public bool EstaBloqueado()
        {
            return Estado.Equals("Bloqueado");
        }

        private void ActualizarFinAtencion(DateTime hora)
        {
            var demora = 0.0;
            if (!bContinua)
            {
                demora = DistribucionAtencion.Generar();
            }
            else
            {
                demora = CalcularDemoraSegunLitros() / 60;
            }
            ProximoFinAtencion = hora.AddMinutes(demora);
        }

        public void LlegadaCliente(DateTime hora, Cliente cliente)
        {
            if (EstaLibre())
            {
                ClienteActual = cliente;
                Estado = $"Atendiendo a {cliente.Nombre}";
                cliente.ComenzarAtencion(hora, Nombre); 
                if (bContinua)
                    cliente.SetLitros(DistribucionLitros.Generar());
                ActualizarFinAtencion(hora);
            }
            else
            {
                Cola.AgregarCliente(cliente);
            }
        }        

        [SuppressMessage("ReSharper", "PossibleInvalidOperationException")]
        public Cliente FinAtencion()
        {
            var cliente = ClienteActual;
            if (cliente != null)
            {
                cliente.FinalizarAtencion(ProximoFinAtencion.Value);
                CantidadAtendidos++;
            }
            if (DistribucionBloqueo != null && CantidadAtendidos % 15 == 0 && !EstaBloqueado())
            {
                Estado = "Bloqueado";
                ClienteActual = null;
                ActualizarFinBloqueo(ProximoFinAtencion.Value);
            }
            else
            {
                if (Cola.Vacia())
                {
                    Estado = "Libre";
                    ClienteActual = null;
                    ProximoFinAtencion = null;
                }
                else
                {
                    ClienteActual = Cola.ProximoCliente();
                    Estado = $"Atendiendo a {ClienteActual.Nombre}";
                    ClienteActual.ComenzarAtencion(ProximoFinAtencion.Value, Nombre);
                    if (bContinua)
                        ClienteActual.SetLitros(DistribucionLitros.Generar());
                    ActualizarFinAtencion(ProximoFinAtencion.Value);
                }
            }            
            return cliente;
        }

        public void ActualizarFinBloqueo(DateTime hora)
        {
            var demora = DistribucionBloqueo.Generar();
            ProximoFinAtencion = hora.AddMinutes(demora);
        }

        public double CalcularDemoraSegunLitros()
        {
            double retorno = 0.0;
            double litros = ClienteActual.LitrosCombustible;
            double h = 0.1;
            double k = 0.0;
            do
            {
                k = DistribucionK.Generar();
            } while (k > 0.25 || k < 0.15);
            switch (nTipoContinua)
            {
                case 1:
                    // Metodo de Euler:
                    double z1 = litros;
                    double z2 = 0.0;
                    double z3 = (-20 * z2) - (k * z1);
                    double tiempo = 0.0;
                    while (z1 > 1)
                    {
                        tiempo = tiempo + h;
                        z1 = z1 + (h * z2);
                        z2 = z2 + (h * z3);
                        z3 = (-20 * z2) - (k * z1);
                    }
                    retorno = tiempo;
                    break;
                case 2:
                    // Metodo de Runge Kutta
                    break;
            }
            return retorno;
        }
    }
}
