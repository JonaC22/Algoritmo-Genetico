using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GAF;
using System.Drawing;

namespace AlgoritmosGeneticos
{
    public sealed class Logger
    {
        private static Logger instance = null;
        private static object padlock = new object();
        private String[] modelos = {"Chevrolet Corsa", "Ford F100", "Toyota Corolla", "Honda Civic", "Volkswagen Gol", "Renault 19", "Fiat Uno"};
        private RichTextBox box;
        private Logger() { }

        public static Logger Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                    return instance;
                }
            }
        }

        public void setTextBox(RichTextBox consola)
        {
            this.box = consola;
        }

        internal void loguearResultados(Population population, int currentGeneration, long currentEvaluation)
        {
            appendText(Color.Red,"Current Generation: " + currentGeneration + " ", false);
            appendText(Color.Red, "Current Evaluation: " + currentEvaluation, true);
            appendText(Color.Black, "Poblacion:", true);

            foreach (Chromosome cromosoma in population.Solutions)
            {
                appendText(Color.Blue, cromosoma.ToBinaryString(), true);
                loguearCromosomas(cromosoma);
            }

        }

        private void loguearCromosomas(Chromosome cromosoma)
        {
            var particiones = partition(cromosoma.Genes, 9);
            Chromosome cromo = new Chromosome();
            int i = 0;
            foreach (var particion in particiones)
            {
                cromo.Genes.Clear();
                List<Gene> genes = particion.ToList<Gene>();
                cromo.Genes.AddRange(genes);
                appendText(Color.DarkMagenta, cromo.ToBinaryString(), false);
                appendText(Color.Black, "   ---> "+ modelos[i], true);
                i++;
            }
        }

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

        // Append text of the given color.
        public void appendText(Color color, string text, bool AddNewLine = false)
        {
            if (AddNewLine)
            {
                text += Environment.NewLine;
            }

            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
