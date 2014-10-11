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
            int pos_max = -1;
            int valorRetorno = 0;
            
            foreach (Modelo mod in modelos)
            {
                if (pos_max <= mod.posicion)
                {
                    pos_max = mod.posicion;
                    if (mod.color.ToLower() == "verde")
                        valorRetorno = 1;
                    else
                        valorRetorno = -1;
                }
            }

            return valorRetorno;
        }

    }
}
