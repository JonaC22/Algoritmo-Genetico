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

            List<Modelo> mods_derecha = modelos.FindAll(x => x.posicion == modelos[3].posicion + 1);

            if (mods_derecha != null && mods_derecha.Exists(x => x.pertenencia == "tostadora"))
                return valorRetorno = 1;

            List<Modelo> mods_izq = modelos.FindAll(x => x.posicion == modelos[3].posicion - 1);

            if (mods_izq != null && mods_izq.Exists(x => x.pertenencia == "tostadora"))
                return valorRetorno = 1;


            return valorRetorno;
        }
    }
}
