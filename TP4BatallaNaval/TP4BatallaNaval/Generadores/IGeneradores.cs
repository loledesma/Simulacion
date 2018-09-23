using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4BatallaNaval.Generadores
{
    public interface IGeneradores
    {
        double Generar();
        int Generar(int cifras);
    }
}