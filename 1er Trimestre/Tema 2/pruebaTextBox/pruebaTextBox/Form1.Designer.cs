namespace pruebaTextBox
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
            this.textBoxPersonalizado2 = new ControlTextBox.TextBoxPersonalizado();
            this.SuspendLayout();
            // 
            // textBoxPersonalizado2
            // 
            this.textBoxPersonalizado2.cambiarPosicion = ControlTextBox.TextBoxPersonalizado.Position.Izquierda;
            this.textBoxPersonalizado2.Location = new System.Drawing.Point(12, 12);
            this.textBoxPersonalizado2.Name = "textBoxPersonalizado2";
            this.textBoxPersonalizado2.Size = new System.Drawing.Size(418, 55);
            this.textBoxPersonalizado2.TabIndex = 1;
            this.textBoxPersonalizado2.textoLabel = "Hola";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPersonalizado2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlTextBox.TextBoxPersonalizado textBoxPersonalizado2;
    }
}

