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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 382);
            this.Controls.Add(this.consolaTexto);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox consolaTexto;



    }
}