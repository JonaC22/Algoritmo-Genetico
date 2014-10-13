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
            List<Modelo> mods_gris = modelos.FindAll(x => x.color == "gris");

            foreach (Modelo mod in mods_gris)
            {
                List<Modelo> mods_derecha = modelos.FindAll(x => x.posicion == mod.posicion + 1);

                if (mods_derecha != null && mods_derecha.Exists(x => x.pertenencia == "botiquin"))
                    return valorRetorno = 1;

                List<Modelo> mods_izq = modelos.FindAll(x => x.posicion == mod.posicion - 1);

                if (mods_izq != null && mods_izq.Exists(x => x.pertenencia == "botiquin"))
                    return valorRetorno = 1;
            }

            return valorRetorno;
        }
    }
}
