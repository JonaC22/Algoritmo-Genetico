using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GAF;

namespace AlgoritmosGeneticos
{
    class Logger
    {
        private static Logger instance;
        private TextBox textbox;
        private Logger() { }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }

        public void setTextBox(TextBox consola)
        {
            this.textbox = consola;
        }

        internal void loguearResultados(Population population, int currentGeneration, long currentEvaluation)
        {
            textbox.Text += "Current Generation: " + currentGeneration + " ";
            textbox.Text += "Current Evaluation: " + currentEvaluation + "\r\n";
            textbox.Text += "Poblacion:\r\n";
            foreach (Chromosome cromosoma in population.Solutions)
            {
                textbox.Text += cromosoma.ToBinaryString() + "\r\n";
            }

        }
    }
}
