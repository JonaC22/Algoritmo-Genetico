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
        internal int cantPoblacion = 2;
        internal int cantIteraciones = 1;
        private List<Control> controles = new List<Control>();

        public MainForm()
        {
            InitializeComponent();
            inicializarBarra();
            consolaTexto.Hide();
            agregarControles();
        }

        private void agregarControles()
        {
            controles.Add(label1);
            controles.Add(label2);
            controles.Add(trackPoblacion);
            controles.Add(trackIteraciones);
            controles.Add(botonIniciar);
            controles.Add(labelCantIndividuos);
            controles.Add(labelCantIteraciones);
        }
        private void inicializarBarra()
        {
            progressBar.Visible = true;
            progressBar.Minimum = 1;
            progressBar.Maximum = 100;
            progressBar.Value = 1;
            progressBar.Step = 1;
        }
        
        private void correrGAF()
        {
            GAFRunner gaf = GAFRunner.Instance;
            Logger.Instance.setTextBox(this.consolaTexto);
            Logger.Instance.appendText(Color.DarkGreen, "Inicio algoritmo", true);           
            gaf.correrAlgoritmoGenetico(progressBar, cantPoblacion, cantIteraciones);
            Logger.Instance.appendText(Color.DarkGreen, "Fin algoritmo", true);
        }

        private void botonIniciar_Click(object sender, EventArgs e)
        {
            deshabilitarGUI();
            consolaTexto.Clear();
            correrGAF();
            ocultarGUI();
            consolaTexto.Show();
        }

        private void deshabilitarGUI()
        {
            foreach (Control control in controles)
            {
                control.Enabled = false;
            }
        }

        private void ocultarGUI()
        {
            foreach (Control control in controles)
            {
                control.Hide();
            }
            progressBar.Hide();
        }

        private void trackPoblacion_ValueChanged(object sender, EventArgs e)
        {
            this.cantPoblacion = trackPoblacion.Value;
            this.labelCantIndividuos.Text = trackPoblacion.Value.ToString();
            asignarMaxBarra();
        }

        private void trackIteraciones_ValueChanged(object sender, EventArgs e)
        {
            this.cantIteraciones = trackIteraciones.Value;
            this.labelCantIteraciones.Text = trackIteraciones.Value.ToString();
            asignarMaxBarra();
        }

        private void asignarMaxBarra()
        {
            progressBar.Maximum = cantIteraciones;
        }

        private void trackPoblacion_Scroll(object sender, EventArgs e)
        {
            int valor = trackPoblacion.Value % 2;

            if(valor != 0)
            {
                trackPoblacion.Value++;
            }
        }
    }
}
