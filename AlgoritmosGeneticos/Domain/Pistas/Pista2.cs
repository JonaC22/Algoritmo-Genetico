using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos.Domain.Pistas
{
    public class Pista2 : Pista
    {
        public Pista2() { }

        public double validar(List<Modelo> modelos)
        {
            int valorRetorno = -1;
            
            if(modelos.Exists(x => x.posicion == 7 && x.color == "verde")) valorRetorno = 1;
           
            return valorRetorno;
        }

    }
}
