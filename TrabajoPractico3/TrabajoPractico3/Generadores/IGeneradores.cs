using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3.Generadores
{
    public interface IGeneradores
    {
        double Generar();
        int Generar(int cifras);
    }
}