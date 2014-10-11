using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos.Domain.Pistas
{
    public class Pista7 : Pista
    {
        public Pista7() { }

        public double validar(List<Modelo> modelos)
        {
            int valorRetorno = -1;
            List<Modelo> mods_con_tele = modelos.Where(x => x.pertenencia.ToLower() == "televisor").ToList();

            foreach (Modelo mod in mods_con_tele)
            {
                List<Modelo> mods_derecha = modelos.Where(x => x.posicion == mod.posicion + 1).ToList();

                if (mods_derecha != null && mods_derecha.Exists(x => x.pertenencia.ToLower() == "tostadora"))
                    valorRetorno = 1;

                List<Modelo> mods_izq = modelos.Where(x => x.posicion == mod.posicion - 1).ToList();

                if (mods_izq != null && mods_izq.Exists(x => x.pertenencia.ToLower() == "tostadora"))
                    valorRetorno = 1;
            }

            return valorRetorno;
        }
    }
}
