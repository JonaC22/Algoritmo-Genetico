using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosGeneticos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            consolaTexto.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);
            correrGAF();
        }
        
        private void correrGAF()
        {
            GAFManager gaf = GAFManager.Instance;
            Logger.Instance.setTextBox(this.consolaTexto);
            Logger.Instance.appendText(Color.DarkGreen, "Inicio algoritmo", true);
            gaf.exampleFunction();
            Logger.Instance.appendText(Color.DarkGreen, "Fin algoritmo", true);
        }
    }
}
