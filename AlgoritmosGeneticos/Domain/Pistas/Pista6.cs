using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos.Domain.Pistas
{
    public class Pista6 : Pista
    {
        public Pista6() { }

        public double validar(List<Modelo> modelos)
        {
            int valorRetorno = -1;
            List<Modelo> mods_bordo = modelos.FindAll(x => x.color == "bordo");

            foreach (Modelo mod in mods_bordo)
            {
                List<Modelo> mod_derecha = modelos.FindAll(x => x.posicion == mod.posicion + 1);

                if (mod_derecha.Count > 0 && mod_derecha.Exists(x => x.pertenencia == "notebook"))valorRetorno = 1;
                List<Modelo> mod_izq = modelos.FindAll(x => x.posicion == mod.posicion -1);

                if (mod_izq.Count > 0 && mod_izq.Exists(x => x.pertenencia == "notebook"))
                    valorRetorno = 1;
            }

            return valorRetorno;
        }
    }
}
