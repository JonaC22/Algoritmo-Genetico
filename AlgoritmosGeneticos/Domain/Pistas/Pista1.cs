using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos.Domain
{
    public class Pista1 : Pista
    {
        public Pista1() { }

        public double validar(List<Modelo> modelos)
        {
            int valorRetorno = 0;
            List<Modelo> resultados;
            if (modelos[0].nombre_modelo == "Chevrolet Corsa")
            {
                int pos = modelos[0].posicion;
                resultados = modelos.FindAll(x => ((x.posicion == pos - 1) || (x.posicion == pos + 1)));
                if (resultados.Any(x => x.pertenencia == "palo de golf")) valorRetorno = 1;
                else valorRetorno = -1;
            }
            return valorRetorno;
        }
    }
}
