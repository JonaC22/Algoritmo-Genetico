using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos.Domain.Pistas
{
    public class Pista10 : Pista
    {
        public Pista10() { }

        public double validar(List<Modelo> modelos)
        {
            int valorRetorno = -1;
            int pos_max = buscarPosicionMax(modelos);
            List<Modelo> mods_gol = modelos.Where(x => x.nombre_modelo.ToLower() == "volkswagen gol").ToList();

            foreach (Modelo mod in mods_gol)
            {
                if (mod.posicion == pos_max - 2)
                    valorRetorno = 1;
            }

            return valorRetorno;
        }

        private int buscarPosicionMax(List<Modelo> modelos)
        {
            int pos_max = -1;

            foreach (Modelo mod in modelos)
            {
                if (pos_max < mod.posicion)
                    pos_max = mod.posicion;
            }

            return pos_max;
        }
    }
}
