using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAF;
using GAF.Operators;
using GAF.Extensions;
using GAF.Threading;
using System.Windows.Forms;
using System.Drawing;
using AlgoritmosGeneticos.Domain;

namespace AlgoritmosGeneticos
{
    class GAFManager 
    {
        //GAFManager es un Singleton
        private Logger logger;
        public ProgressBar progress;
        internal int cantIteraciones;
        private static GAFManager instance;
        private GAFManager() 
        {
            this.logger = Logger.Instance;
        }

        public static GAFManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GAFManager();
                }
                return instance;
            }
        }

        public void exampleFunction(ProgressBar progressBar, int cantPoblacion, int cantIteraciones)
        {
            this.progress = progressBar;
            this.cantIteraciones = cantIteraciones;

            var population = new Population(populationSize: cantPoblacion,
              chromosomeLength: 63,
              reEvaluateAll: false,
              useLinearlyNormalisedFitness: false,
              selectionMethod: ParentSelectionMethod.TournamentSelection);

            var crossover = new Crossover(0.2)
            {
                AllowDuplicates = true,
                CrossoverType = CrossoverType.SinglePoint,
                ReplacementMethod = ReplacementMethod.GenerationalReplacement
            };

            var binaryMutate = new BinaryMutate(mutationProbability: 0.2D, allowDuplicates: true);
            var randomReplace = new RandomReplace(numberToReplace: 12, allowDuplicates: true);

            var ga = new GeneticAlgorithm(population, CalculateFitness)
            {
                UseMemory = false
            };

            ga.OnGenerationComplete += ga_OnGenerationComplete;
            ga.Operators.Add(crossover);
            ga.Operators.Add(binaryMutate);
            ga.Operators.Add(randomReplace);
            ga.Run(Terminate);
        }

        void ga_OnGenerationComplete(object sender, GaEventArgs e)
        {
            this.logger.loguearResultados(e);
        }

        private bool Terminate(Population population, int currentGeneration, long currentEvaluation)
        {
            this.progress.PerformStep();
            return population.MaximumFitness == 210 || currentGeneration == this.cantIteraciones;
        }

        private double CalculateFitness(Chromosome chromosome)
        {
            double fitnessValue = -1;
            
            if (chromosome != null)
            {
                if (chromosome.Count == 63)
                {
                    fitnessValue = Acertijo.Instance.FitnessFunction(chromosome);
                }
                else
                {
                    throw new ApplicationException("The Chromosome length is incorrect.");
                }
            }
            else
            {
                //chromosome is null
                throw new ArgumentNullException("chromosome", "The specified Chromosome is null.");
            }
            
            return fitnessValue;
        }
    }
}
