using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos.Domain.Pistas
{
    public class Pista3 : Pista
    {
        public Pista3() { }

        public double validar(List<Modelo> modelos)
        {
            int valorRetorno = -1;
            List<Modelo> mods_con_jaulas = modelos.FindAll(x => x.pertenencia == "jaula");

            foreach (Modelo mod in mods_con_jaulas)
            {
                List<Modelo> mod_derecha = modelos.FindAll(x => x.posicion == mod.posicion + 1);

                if (mod_derecha != null && mod_derecha.Exists(x => x.nombre_modelo == "Ford F100"))
                    valorRetorno = 1;

                List<Modelo> mod_izq = modelos.FindAll(x => x.posicion == mod.posicion - 1);

                if (mod_izq != null && mod_izq.Exists(x => x.nombre_modelo == "Ford F100"))
                    valorRetorno = 1;
            }

            return valorRetorno;
        }
    }
}
