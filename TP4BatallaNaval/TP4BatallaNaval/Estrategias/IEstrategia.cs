using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4BatallaNaval.Estrategias
{
    interface IEstrategia
    {
        Coordenada realizarMovimiento();
        void resultadoMovimiento(int resultado);
    }
}
