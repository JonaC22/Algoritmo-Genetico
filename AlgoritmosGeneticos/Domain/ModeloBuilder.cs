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
        public int indice_modelo;
        public string binario_pertenencia;
        public string binario_posicion;
        public string binario_color;
        private ModeloBuilder() { }

        public static ModeloBuilder Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ModeloBuilder();
                }
                return instance;
            }
        }

        public void configurar(int indice, string _binario_color, string _binario_pertenencia, string _binario_posicion)
        {
            indice_modelo = indice;
            binario_color = _binario_color;
            binario_pertenencia = _binario_pertenencia;
            binario_posicion = _binario_posicion;
        }

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
