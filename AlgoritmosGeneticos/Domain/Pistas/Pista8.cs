using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos.Domain.Pistas
{
    public class Pista8 : Pista
    {
        public Pista8() { }

        public double validar(List<Modelo> modelos)
        {
            int valorRetorno = -1;
            List<Modelo> mods_gris = modelos.Where(x => x.color.ToLower() == "gris").ToList();

            foreach (Modelo mod in mods_gris)
            {
                List<Modelo> mods_derecha = modelos.Where(x => x.posicion == mod.posicion + 1).ToList();

                if (mods_derecha != null && mods_derecha.Exists(x => x.pertenencia.ToLower() == "botiquin"))
                    valorRetorno = 1;

                List<Modelo> mods_izq = modelos.Where(x => x.posicion == mod.posicion - 1).ToList();

                if (mods_izq != null && mods_izq.Exists(x => x.pertenencia.ToLower() == "botiquin"))
                    valorRetorno = 1;
            }

            return valorRetorno;
        }
    }
}
