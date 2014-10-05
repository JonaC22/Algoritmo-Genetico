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
    class Logger
    {
        private static Logger instance;
        private RichTextBox box;
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
            }

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
