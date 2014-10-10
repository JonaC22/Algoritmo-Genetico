using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAF;
using System.Drawing;

namespace AlgoritmosGeneticos.Domain
{
    class Acertijo
    {
        private static Acertijo instance;
        private Acertijo() {}

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

        public double FitnessFunction(Chromosome cromosoma)
        {
            double valor = 0;
            var particiones = partition(cromosoma.Genes, 9);
            Chromosome cromo = new Chromosome();
            int i = 0;
            foreach (var particion in particiones)
            {
                cromo.Genes.Clear();
                List<Gene> genes = particion.ToList<Gene>();
                cromo.Genes.AddRange(genes);
                var genesAuxiliares = partition(genes, 3);
                int t = 0;
                foreach (var genAuxiliar in genesAuxiliares)
                {
                    cromo.Genes.Clear();
                    cromo.Genes.AddRange(genAuxiliar);
                    string cadenaBits = cromo.ToBinaryString();
                    if (cadenaBits == "111")
                    {
                        valor -= 100;
                    }
                    else
                    {
                        switch (t)
                        {
                            case 0:
                                valor += 10;
                                break;
                            case 1:
                                valor += 10;
                                break;
                            case 2:
                                valor += 10;
                                break;
                            default:
                                valor += 10;
                                break;
                        }
                    }
                    t++;
                }
                i++;
            }

            if (valor < 0) valor = 0;
            return valor;
        }


        //metodo para particionar el cromosoma en particiones mas chicas (genes principales y genes auxiliares)
        public static IEnumerable<IEnumerable<T>> partition<T>(IEnumerable<T> items,
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
