using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos.Domain
{ 
    [Serializable]
    public class Modelo
    {
        public string nombre_modelo;
        public string color;
        public int posicion;
        public string pertenencia;

        public Modelo(string _modelo, string _color, int _posicion, string _pertenencia)
        {
            nombre_modelo = _modelo;
            color = _color;
            posicion = _posicion;
            pertenencia = _pertenencia;
        }
    }
}
