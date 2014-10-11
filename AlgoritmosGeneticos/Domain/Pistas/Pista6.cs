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
            List<Modelo> mods_bordo = modelos.Where(x => x.color.ToLower() == "bordo").ToList();

            foreach (Modelo mod in mods_bordo)
            {
                List<Modelo> mod_derecha = modelos.Where(x => x.posicion == mod.posicion + 1).ToList();

                if (mod_derecha != null && mod_derecha.Exists(x => x.pertenencia.ToLower() == "notebook"))
                    valorRetorno = 1;

                List<Modelo> mod_izq = modelos.Where(x => x.posicion == mod.posicion -1).ToList();

                if (mod_izq != null && mod_izq.Exists(x => x.pertenencia.ToLower() == "notebook"))
                    valorRetorno = 1;
            }

            return valorRetorno;
        }
    }
}
