using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos.Domain
{ 
    [Serializable]
    class Modelo
    {
        public string nombre_modelo;
        public string color;
        public string posicion;
        public string pertenencia;

        public Modelo(string _modelo, string _color, string _posicion, string _pertenencia)
        {
            nombre_modelo = _modelo;
            color = _color;
            posicion = _posicion;
            pertenencia = _pertenencia;
        }
    }
}
