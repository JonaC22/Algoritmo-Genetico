using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos.Domain
{
    interface Pista
    {
        double validar(List<Modelo> modelos);
    }
}
