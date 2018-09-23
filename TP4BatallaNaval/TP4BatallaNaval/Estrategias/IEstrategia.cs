using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4BatallaNaval.Distribuciones;
using TP4BatallaNaval.Generadores;

namespace TP4BatallaNaval.Estrategias
{
    public interface IEstrategia
    {
        Coordenada realizarMovimiento();
        void resultadoMovimiento(Coordenada movim, int resultado);
    }
}
