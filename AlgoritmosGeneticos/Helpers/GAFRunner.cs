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
    class GAFRunner 
    {
        //GAFRunner es un Singleton
        private static GAFRunner instance;

        private Logger logger;
        private long fitnessRequired;
        public ProgressBar progress;
        internal int cantIteraciones;
     
        private GAFRunner() 
        {
            this.logger = Logger.Instance;
        }

        public static GAFRunner Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GAFRunner();
                }
                return instance;
            }
        }

        public void correrAlgoritmoGenetico(ProgressBar progressBar, int cantPoblacion, int cantIteraciones)
        {
            this.progress = progressBar;
            this.cantIteraciones = cantIteraciones;
            this.fitnessRequired = 10;

            var population = new Population(populationSize: cantPoblacion,
              chromosomeLength: 63,
              reEvaluateAll: true,
              useLinearlyNormalisedFitness: true,
              selectionMethod: ParentSelectionMethod.TournamentSelection);

            var crossover = new Crossover(0.2)
            {
                AllowDuplicates = true,
                CrossoverType = CrossoverType.SinglePoint
            };

            var binaryMutate = new BinaryMutate(mutationProbability: 0.2D, allowDuplicates: true);

            var ga = new GeneticAlgorithm(population, CalculateFitness)
            {
                UseMemory = false
            };

            ga.OnGenerationComplete += ga_OnGenerationComplete;
            ga.OnRunComplete += ga_OnRunComplete;
            ga.Operators.Add(crossover);
            ga.Operators.Add(binaryMutate);
            ga.Run(Terminate);
        }

        void ga_OnGenerationComplete(object sender, GaEventArgs e)
        {
            this.progress.PerformStep();
        }

        void ga_OnRunComplete(object sender, GaEventArgs e)
        {
            this.logger.appendText(Color.Tomato, "TERMINO LA CORRIDA", true);
            if (e.Population.MaximumFitness >= fitnessRequired || e.Generation == this.cantIteraciones) this.logger.loguearResultados(e);
        }

        private bool Terminate(Population population, int currentGeneration, long currentEvaluation)
        {
            return population.MaximumFitness >= fitnessRequired || currentGeneration == this.cantIteraciones;
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
