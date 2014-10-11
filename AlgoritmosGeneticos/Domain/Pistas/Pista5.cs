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
            List<Modelo> mods_negros = modelos.Where(x => x.color.ToLower() == "negro" && x.nombre_modelo.ToLower() == "toyota corolla").ToList();

            foreach (Modelo mod in mods_negros)
            {
                List<Modelo> mods_derecha = modelos.Where(x => x.posicion == mod.posicion + 1).ToList();

                if (mods_derecha != null && mods_derecha.Exists(x => x.color.ToLower() == "blanco"))
                    valorRetorno = 1;

                List<Modelo> mods_izq = modelos.Where(x => x.posicion == mod.posicion - 1).ToList();

                if (mods_izq != null && mods_izq.Exists(x => x.color.ToLower() == "blanco"))
                    valorRetorno = 1;
            }

            return valorRetorno;
        }
    }
}
