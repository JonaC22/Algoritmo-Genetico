using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos.Domain.Pistas
{
    public class Pista12 : Pista
    {
        public double validar(List<Modelo> modelos)
        {
            int valorRetorno = -1;
            List<Modelo> resultados;
            int pos = modelos[5].posicion;
            resultados = modelos.FindAll(x => ((x.posicion == pos - 1) || (x.posicion == pos + 1)));
            if (resultados.Any(x => x.nombre_modelo == "Fiat Uno")) return valorRetorno = 1;
            return valorRetorno;
        }
    }
}
