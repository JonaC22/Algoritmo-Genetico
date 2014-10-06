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
        private Dictionary<string, string> pertenencias = new Dictionary<string,string>();
        private Dictionary<string, string> colores = new Dictionary<string,string>();
        private Dictionary<string, string> posicion = new Dictionary<string,string>();
        private RichTextBox box;
        private Logger() 
        {
            inicializarPertenencias();
            inicializarColores();
            iniciarlizarPosicion();
        }

        private void iniciarlizarPosicion()
        {
 	        posicion.Add("000", "1");
            posicion.Add("001", "2");
            posicion.Add("010", "3");
            posicion.Add("011", "4");
            posicion.Add("100", "5");
            posicion.Add("101", "6");
            posicion.Add("110", "7");
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
        }

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
                appendText(Color.Black, "   ---> "+ modelos[i], false);
                var genesAuxiliares = partition(genes,3);
                int t = 0;
                foreach (var genAuxiliar in genesAuxiliares)
                {
                    cromo.Genes.Clear();
                    cromo.Genes.AddRange(genAuxiliar);
                    string cadenaBits = cromo.ToBinaryString();
                    if (cadenaBits == "111")
                    {
                        appendText(Color.YellowGreen, ", INVALIDO", false);
                    }
                    else
                    {
                        switch (t)
                        {
                            case 0:
                                appendText(Color.Black, ", " + colores[cadenaBits], false);
                                break;
                            case 1:
                                appendText(Color.Black, ", " + pertenencias[cadenaBits], false);
                                break;
                            case 2:
                                appendText(Color.Black, ", Posicion: " + posicion[cadenaBits], false);
                                break;
                            default:
                                appendText(Color.White, ", INVALIDO", false);
                                break;
                        }
                    }
                    t++;
                }
                i++;
                appendText(Color.Black, " ", true);
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
