using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos.Domain.Pistas
{
    public class Pista9 : Pista
    {
        public Pista9() { }

        public double validar(List<Modelo> modelos)
        {
            int valorRetorno = -1;
            List<Modelo> mods_hondaCivic = modelos.Where(x => x.nombre_modelo.ToLower() == "honda civic").ToList();

            foreach (Modelo mod in mods_hondaCivic)
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
