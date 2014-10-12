using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos.Domain.Pistas
{
    public class Pista11 : Pista
    {   
        public double validar(List<Modelo> modelos)
        {
            int valorRetorno = -1;
            List<Modelo> mods_azul = modelos.FindAll(x => x.posicion == 1);

            foreach (Modelo mod in mods_azul)
            {
                if (mod.color == "azul") return valorRetorno = 1;
            }

            return valorRetorno;
        }
    }
}
