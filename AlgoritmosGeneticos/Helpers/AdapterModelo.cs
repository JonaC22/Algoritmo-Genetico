using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGeneticos.Helpers
{
    [Serializable]
    public sealed class AdapterModelo
    {

        private static AdapterModelo instance = null;
        private String[] modelos = { "Chevrolet Corsa", "Ford F100", "Toyota Corolla", "Honda Civic", "Volkswagen Gol", "Renault 19", "Fiat Uno" };
        private Dictionary<string, string> pertenencias = new Dictionary<string, string>();
        private Dictionary<string, string> colores = new Dictionary<string, string>();
        private Dictionary<string, string> posiciones = new Dictionary<string, string>();

        private AdapterModelo()
        {
            inicializarPertenencias();
            inicializarColores();
            iniciarlizarPosicion();
        }

        public static AdapterModelo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AdapterModelo();
                }
                return instance;
            }
        }

        private void iniciarlizarPosicion()
        {
            posiciones.Add("000", "1");
            posiciones.Add("001", "2");
            posiciones.Add("010", "3");
            posiciones.Add("011", "4");
            posiciones.Add("100", "5");
            posiciones.Add("101", "6");
            posiciones.Add("110", "7");
            posiciones.Add("111", "INVALIDO");
        }

        private void inicializarColores()
        {
            colores.Add("000", "verde");
            colores.Add("001", "rojo");
            colores.Add("010", "negro");
            colores.Add("011", "bordo");
            colores.Add("100", "gris");
            colores.Add("101", "azul");
            colores.Add("110", "blanco");
            colores.Add("111", "INVALIDO");
        }

        private void inicializarPertenencias()
        {
            pertenencias.Add("000", "palo de golf");
            pertenencias.Add("001", "jaula");
            pertenencias.Add("010", "pelota de futbol");
            pertenencias.Add("011", "notebook");
            pertenencias.Add("100", "tostadora");
            pertenencias.Add("101", "botiquin");
            pertenencias.Add("110", "televisor");
            pertenencias.Add("111", "INVALIDO");
        }

        public string getModelo(int indice)
        {
            return modelos[indice];
        }

        public string getColor(string binario_color)
        {
            return colores[binario_color];
        }

        public string getPertenencia(string binario_pertenencia)
        {
            return pertenencias[binario_pertenencia];
        }

        public string getPosicion(string binario_posicion)
        {
            return posiciones[binario_posicion];
        }
    }
}
