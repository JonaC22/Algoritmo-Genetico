using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAF;
using System.Drawing;
using AlgoritmosGeneticos.Domain.Pistas;

namespace AlgoritmosGeneticos.Domain
{
    class Acertijo
    {
        private static Acertijo instance;
        private List<Pista> pistas = new List<Pista>();
        private int constanteFitness;
        private Acertijo()
        {
            agregarPistas();
            constanteFitness = 10;
        }

        public static Acertijo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Acertijo();
                }
                return instance;
            }
        }

        private void agregarPistas()
        {
            pistas.Add(new Pista1());
            pistas.Add(new Pista2());
            pistas.Add(new Pista3());
            pistas.Add(new Pista4());
            pistas.Add(new Pista5());
            pistas.Add(new Pista6());
            pistas.Add(new Pista7());
            pistas.Add(new Pista8());
            pistas.Add(new Pista9());
            pistas.Add(new Pista10());
            pistas.Add(new Pista11());
            pistas.Add(new Pista12());
            pistas.Add(new Pista13());
        }

        public double FitnessFunction(Chromosome cromosoma)
        {
            double valor = 200;

            List<Modelo> modelos = crearModelos(cromosoma);

            //Polimorfismo para las validaciones
            foreach (var pista in pistas)
            {
                valor += constanteFitness * pista.validar(modelos);
            }

            //me fijo si tiene partes invalidas => decremento el valor
            foreach (var pista in pistas)
            {
                valor += constanteFitness * validarInvalidos(modelos);
            }

            if (valor < 0) valor = 0;
            return valor;
        }

        private int validarInvalidos(List<Modelo> modelos)
        {
            //valido que no tenga cadena de bits invalidas
            int valor =
            modelos.Count(x => x.color == "INVALIDO") +
            modelos.Count(x => x.pertenencia == "INVALIDO") +
            modelos.Count(x => x.posicion == -1);
            return valor * -10;
        }

        private List<Modelo> crearModelos(Chromosome cromosoma)
        {
            var particiones = particionar(cromosoma.Genes, 9);
            List<Modelo> modelos = new List<Modelo>();
            int indice = 0;

            foreach (var particion in particiones)
            {
                List<string> genesAuxiliares = obtenerGenesAuxiliares(particion.ToList<Gene>());
                ModeloBuilder builder = ModeloBuilder.Instance;
                builder.configurar(indice, genesAuxiliares[0], genesAuxiliares[1], genesAuxiliares[2]);
                Modelo modelo = builder.build();
                modelos.Add(modelo);
                indice++;
            }
            return modelos;
        }

        private List<string> obtenerGenesAuxiliares(List<Gene> particion)
        {
            Chromosome cromosoma = new Chromosome();
            List<string> caracteristicas = new List<string>();
            var genes = particionar(particion, 3);
            int i = 0;
            foreach (var gen in genes)
            {
                cromosoma.Genes.Clear();
                cromosoma.Genes.AddRange(gen.ToList<Gene>());
                string cadenaBits = cromosoma.ToBinaryString();
                caracteristicas.Insert(i, cadenaBits);
                i++;
            }
            return caracteristicas;
        }

        //metodo para particionar el cromosoma en particiones mas chicas (genes principales y genes auxiliares)
        public static IEnumerable<IEnumerable<T>> particionar<T>(IEnumerable<T> items,
                                                       int partitionSize)
        {
            if (partitionSize <= 0)
                throw new ArgumentOutOfRangeException("partitionSize");

            int innerListCounter = 0;
            int numberOfPackets = 0;
            foreach (var item in items)
            {
                innerListCounter++;
                if (innerListCounter == partitionSize)
                {
                    yield return items.Skip(numberOfPackets * partitionSize).Take(partitionSize);
                    innerListCounter = 0;
                    numberOfPackets++;
                }
            }

            if (innerListCounter > 0)
                yield return items.Skip(numberOfPackets * partitionSize);
        }
    }
}
