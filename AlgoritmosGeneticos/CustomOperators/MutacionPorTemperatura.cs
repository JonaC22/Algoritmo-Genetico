using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAF;
using GAF.Operators;

namespace AlgoritmosGeneticos.CustomOperators
{
    public class MutacionPorTemperatura : BinaryMutate
    {
        private readonly object _syncLock = new object();
        private long cantidadVueltasMax = 0;
        private long cantidadVueltas = 0;
        private double mutationProbabilityMax;

        public MutacionPorTemperatura(double mutationProbability, double mutationProbabilityMax, long cantidadVueltasMax, bool allowDuplicates)
            : base(mutationProbability, allowDuplicates)
        {
            this.cantidadVueltasMax = cantidadVueltasMax;
            this.mutationProbabilityMax = mutationProbabilityMax;
        }

        public override void Invoke(Population currentPopulation, ref Population newPopulation, FitnessFunction fitnesFunctionDelegate)
        {
            cantidadVueltas++;
            base.Invoke(currentPopulation, ref newPopulation, fitnesFunctionDelegate);
        }

        protected override void Mutate(Chromosome chromosome, double mutationProbability)
        {
            var newMutationProbability = 0.0;
            newMutationProbability = mutationProbability + cantidadVueltas/cantidadVueltasMax;
            if (newMutationProbability > mutationProbabilityMax) newMutationProbability = mutationProbabilityMax;
            base.Mutate(chromosome, newMutationProbability);
        }
    }
}
