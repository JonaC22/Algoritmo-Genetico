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
            return cromosoma.Genes.Count<Gene>(Func);
        }

        private bool Func(Gene arg)
        {
            return arg.BinaryValue == 0;
        }
    }
}
