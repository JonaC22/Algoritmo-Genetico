using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos.Domain.Pistas
{
    public class Pista10 : Pista
    {
        public Pista10() { }

        public double validar(List<Modelo> modelos)
        {
            int valorRetorno = -1;
            int pos_max = 7;
            if (modelos[4].posicion == pos_max - 2 || modelos[4].posicion == pos_max) valorRetorno = 1;
            return valorRetorno;
        }
    }
}
