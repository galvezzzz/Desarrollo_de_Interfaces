namespace PruebaImagen
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imagenLeyenda1 = new ControladorImagen.ImagenLeyenda();
            this.SuspendLayout();
            // 
            // imagenLeyenda1
            // 
            this.imagenLeyenda1.CambiarLeyenda = "label1";
            this.imagenLeyenda1.CambiarTamanyoLetra = 12F;
            this.imagenLeyenda1.Imagenes = ((System.Drawing.Image)(resources.GetObject("imagenLeyenda1.Imagenes")));
            this.imagenLeyenda1.Location = new System.Drawing.Point(149, 36);
            this.imagenLeyenda1.Name = "imagenLeyenda1";
            this.imagenLeyenda1.Size = new System.Drawing.Size(395, 367);
            this.imagenLeyenda1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imagenLeyenda1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ControladorImagen.ImagenLeyenda imagenLeyenda1;
    }
}

