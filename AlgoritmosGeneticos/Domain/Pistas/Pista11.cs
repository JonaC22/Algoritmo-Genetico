using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos.Domain.Pistas
{
   public class Pista11 : Pista
    {   public Pista11() { }
        public double validar(List<Modelo> modelos)
        {
            int valorRetorno = -1;
            List<Modelo> mods_azul = modelos.Where(x => x.color.ToLower() == "azul").ToList();

            foreach (Modelo mod in mods_azul)
            {
                if (mod.posicion == 1) { valorRetorno=1; }
            }

            return valorRetorno;
        }
    }
}
