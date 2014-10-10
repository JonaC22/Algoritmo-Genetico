using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmosGeneticos.Helpers;

namespace AlgoritmosGeneticos.Domain
{
    [Serializable]
    class ModeloBuilder
    {
        private static ModeloBuilder instance;
        private ModeloBuilder() { }

        public int indice_modelo;
        public string binario_pertenencia;
        public string binario_posicion;
        public string binario_color;

        public Modelo build()
        {
            AdapterModelo adapter = AdapterModelo.Instance;
            return new Modelo(
                adapter.getModelo(indice_modelo),
                adapter.getColor(binario_color), 
                adapter.getPosicion(binario_posicion), 
                adapter.getPertenencia(binario_pertenencia));
        }
    }
}
