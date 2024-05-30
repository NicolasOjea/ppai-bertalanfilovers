namespace WindowsFormsApp1.Pantalla
{
    partial class PantallaImportarActualizacion
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
            this.lstBodegas = new System.Windows.Forms.ListBox();
            this.lblSeleccionarBodega = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBodegas
            // 
            this.lstBodegas.FormattingEnabled = true;
            this.lstBodegas.Location = new System.Drawing.Point(84, 76);
            this.lstBodegas.Name = "lstBodegas";
            this.lstBodegas.Size = new System.Drawing.Size(216, 238);
            this.lstBodegas.TabIndex = 0;
            this.lstBodegas.SelectedIndexChanged += new System.EventHandler(this.lstBodegas_SelectedIndexChanged);
            // 
            // lblSeleccionarBodega
            // 
            this.lblSeleccionarBodega.AutoSize = true;
            this.lblSeleccionarBodega.Location = new System.Drawing.Point(307, 76);
            this.lblSeleccionarBodega.Name = "lblSeleccionarBodega";
            this.lblSeleccionarBodega.Size = new System.Drawing.Size(103, 13);
            this.lblSeleccionarBodega.TabIndex = 1;
            this.lblSeleccionarBodega.Text = "Seleccionar Bodega";
            this.lblSeleccionarBodega.Visible = false;
            // 
            // PantallaImportarActualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSeleccionarBodega);
            this.Controls.Add(this.lstBodegas);
            this.Name = "PantallaImportarActualizacion";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBodegas;
        private System.Windows.Forms.Label lblSeleccionarBodega;
    }
}