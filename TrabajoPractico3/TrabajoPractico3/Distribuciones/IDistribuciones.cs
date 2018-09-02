using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3.Distribuciones
{
    public interface IDistribuciones
    {
        void asignarGenerador (Generadores.IGeneradores generador);
        double generar();
        List<double> generar(int cantidad);
        List<double> getFrecuenciasEsperadas(List<Intervalo> intervalos);
        int getCantidadParametros();
    }
}