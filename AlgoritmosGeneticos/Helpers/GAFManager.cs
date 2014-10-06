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

namespace AlgoritmosGeneticos
{
    class GAFManager 
    {
        //GAFManager es un Singleton
        private Logger logger;
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

        public void exampleFunction()
        {
            var population = new Population(populationSize: 30,
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

            var randomReplace = new RandomReplace(numberToReplace: 16, allowDuplicates: true);

            var ga = new GeneticAlgorithm(population, CalculateFitness)
            {
                UseMemory = false
            };

            ga.Operators.Add(crossover);
            ga.Operators.Add(binaryMutate);
            ga.Operators.Add(randomReplace);

            ga.Run(Terminate);
            Console.ReadLine();
        }

        private bool Terminate(Population population, int currentGeneration, long currentEvaluation)
        {
            this.logger.loguearResultados(population, currentGeneration, currentEvaluation);
            return currentEvaluation >= 1000;
        }

        private double CalculateFitness(Chromosome chromosome)
        {
            double fitnessValue = -1;  

            if (chromosome != null)
            {
                double rangeConst = 200 / (System.Math.Pow(2, chromosome.Count / 2) - 1);

                if (chromosome.Count == 63)
                {
                    //get x and y from the solution
                    int x1 = Convert.ToInt32(chromosome.ToBinaryString(0, chromosome.Count / 2), 2);
                    int y1 = Convert.ToInt32(chromosome.ToBinaryString(chromosome.Count / 2, chromosome.Count / 2), 2);

                    //Adjust range to -100 to +100
                    double x = (x1 * rangeConst) - 100; double y = (y1 * rangeConst) - 100;

                    //using binary F6 for fitness.
                    fitnessValue = FitnessFunctions.BinaryF6(x, y);
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
