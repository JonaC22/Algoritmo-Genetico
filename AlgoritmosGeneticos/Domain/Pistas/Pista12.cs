using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos.Domain.Pistas
{
    class Pista12  : Pista
    {   public Pista12() { }
        public double validar(List<Modelo> modelos)
        {
            int valorRetorno = -1;
            List<Modelo> resultados;
            int indice=modelos.IndexOf(modelos.FindLast(x => (x.nombre_modelo=="Renault 19")));
            if (modelos[indice].nombre_modelo == "Renault 19")
            {
                int pos = modelos[indice].posicion;
                resultados = modelos.FindAll(x => ((x.posicion == pos - 1) || (x.posicion == pos + 1)));
                if (resultados.Any(x => x.nombre_modelo == "Fiat Uno")) valorRetorno = 1;
                else valorRetorno = -1;
            }
            return valorRetorno;
        }
    }
}
