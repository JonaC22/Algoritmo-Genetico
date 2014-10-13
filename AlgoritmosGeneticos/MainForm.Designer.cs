namespace AlgoritmosGeneticos
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.consolaTexto = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.botonIniciar = new System.Windows.Forms.Button();
            this.trackPoblacion = new System.Windows.Forms.TrackBar();
            this.trackIteraciones = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCantIndividuos = new System.Windows.Forms.Label();
            this.labelCantIteraciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackPoblacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackIteraciones)).BeginInit();
            this.SuspendLayout();
            // 
            // consolaTexto
            // 
            this.consolaTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consolaTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consolaTexto.Location = new System.Drawing.Point(0, 0);
            this.consolaTexto.Name = "consolaTexto";
            this.consolaTexto.ReadOnly = true;
            this.consolaTexto.Size = new System.Drawing.Size(643, 382);
            this.consolaTexto.TabIndex = 0;
            this.consolaTexto.Text = "";
            this.consolaTexto.WordWrap = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(55, 271);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(543, 28);
            this.progressBar.TabIndex = 1;
            // 
            // botonIniciar
            // 
            this.botonIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonIniciar.Location = new System.Drawing.Point(492, 327);
            this.botonIniciar.Name = "botonIniciar";
            this.botonIniciar.Size = new System.Drawing.Size(106, 33);
            this.botonIniciar.TabIndex = 2;
            this.botonIniciar.Text = "Iniciar";
            this.botonIniciar.UseVisualStyleBackColor = true;
            this.botonIniciar.Click += new System.EventHandler(this.botonIniciar_Click);
            // 
            // trackPoblacion
            // 
            this.trackPoblacion.LargeChange = 10;
            this.trackPoblacion.Location = new System.Drawing.Point(55, 179);
            this.trackPoblacion.Maximum = 500;
            this.trackPoblacion.Minimum = 2;
            this.trackPoblacion.Name = "trackPoblacion";
            this.trackPoblacion.Size = new System.Drawing.Size(543, 45);
            this.trackPoblacion.SmallChange = 4;
            this.trackPoblacion.TabIndex = 4;
            this.trackPoblacion.Value = 2;
            this.trackPoblacion.Scroll += new System.EventHandler(this.trackPoblacion_Scroll);
            this.trackPoblacion.ValueChanged += new System.EventHandler(this.trackPoblacion_ValueChanged);
            // 
            // trackIteraciones
            // 
            this.trackIteraciones.Location = new System.Drawing.Point(55, 72);
            this.trackIteraciones.Maximum = 200;
            this.trackIteraciones.Minimum = 1;
            this.trackIteraciones.Name = "trackIteraciones";
            this.trackIteraciones.Size = new System.Drawing.Size(543, 45);
            this.trackIteraciones.TabIndex = 4;
            this.trackIteraciones.Value = 1;
            this.trackIteraciones.ValueChanged += new System.EventHandler(this.trackIteraciones_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad de iteraciones: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad de individuos:";
            // 
            // labelCantIndividuos
            // 
            this.labelCantIndividuos.AutoSize = true;
            this.labelCantIndividuos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantIndividuos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelCantIndividuos.Location = new System.Drawing.Point(221, 157);
            this.labelCantIndividuos.Name = "labelCantIndividuos";
            this.labelCantIndividuos.Size = new System.Drawing.Size(18, 20);
            this.labelCantIndividuos.TabIndex = 7;
            this.labelCantIndividuos.Text = "2";
            // 
            // labelCantIteraciones
            // 
            this.labelCantIteraciones.AutoSize = true;
            this.labelCantIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantIteraciones.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelCantIteraciones.Location = new System.Drawing.Point(231, 50);
            this.labelCantIteraciones.Name = "labelCantIteraciones";
            this.labelCantIteraciones.Size = new System.Drawing.Size(18, 20);
            this.labelCantIteraciones.TabIndex = 8;
            this.labelCantIteraciones.Text = "1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 382);
            this.Controls.Add(this.labelCantIteraciones);
            this.Controls.Add(this.labelCantIndividuos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackIteraciones);
            this.Controls.Add(this.trackPoblacion);
            this.Controls.Add(this.botonIniciar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.consolaTexto);
            this.Name = "MainForm";
            this.Text = "Algoritmo Genético";
            ((System.ComponentModel.ISupportInitialize)(this.trackPoblacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackIteraciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.RichTextBox consolaTexto;
        public System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button botonIniciar;
        private System.Windows.Forms.TrackBar trackPoblacion;
        private System.Windows.Forms.TrackBar trackIteraciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCantIndividuos;
        private System.Windows.Forms.Label labelCantIteraciones;



    }
}