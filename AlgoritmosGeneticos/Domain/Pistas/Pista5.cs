using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos.Domain.Pistas
{
    public class Pista5 : Pista
    {
        public Pista5() { }

        public double validar(List<Modelo> modelos)
        {
            int valorRetorno = -1;
            if (modelos[2].color == "negro") valorRetorno = 1;
            return valorRetorno;
        }
    }
}
