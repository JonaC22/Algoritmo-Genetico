using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos.Domain.Pistas
{
    public class Pista1 : Pista
    {
        public Pista1() { }

        public double validar(List<Modelo> modelos)
        {
            int valorRetorno = -1;
            List<Modelo> resultados;
            int pos = modelos[0].posicion;
            resultados = modelos.FindAll(x => ((x.posicion == pos - 1) || (x.posicion == pos + 1)));
            if (resultados.Any(x => x.pertenencia == "palo de golf")) valorRetorno = 1;
            return valorRetorno;
        }
    }
}
