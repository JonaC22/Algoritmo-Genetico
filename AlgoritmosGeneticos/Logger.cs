using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void loguearDatos(double x, double y, double fitnessValue)
        {
            textbox.Text += "Valor de x: " + x + ",Valor de y: " + y + ", FitnessValue: " + fitnessValue + "\r\n";
        }

    }
}
