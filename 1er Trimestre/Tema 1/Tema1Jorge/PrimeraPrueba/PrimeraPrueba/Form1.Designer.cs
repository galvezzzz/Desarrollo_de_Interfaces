namespace PrimeraPrueba
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
            this.components = new System.ComponentModel.Container();
            this.cajaTexto1 = new System.Windows.Forms.TextBox();
            this.boton1 = new System.Windows.Forms.Button();
            this.listaTexto1 = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listaTexto2 = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cajaTexto1
            // 
            this.cajaTexto1.Location = new System.Drawing.Point(12, 12);
            this.cajaTexto1.Name = "cajaTexto1";
            this.cajaTexto1.Size = new System.Drawing.Size(316, 20);
            this.cajaTexto1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cajaTexto1, "Prueba toolTip");
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(12, 85);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(316, 34);
            this.boton1.TabIndex = 1;
            this.boton1.Text = "Confirmar";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // listaTexto1
            // 
            this.listaTexto1.FormattingEnabled = true;
            this.listaTexto1.Location = new System.Drawing.Point(12, 125);
            this.listaTexto1.Name = "listaTexto1";
            this.listaTexto1.Size = new System.Drawing.Size(153, 95);
            this.listaTexto1.TabIndex = 3;
            // 
            // listaTexto2
            // 
            this.listaTexto2.FormattingEnabled = true;
            this.listaTexto2.Location = new System.Drawing.Point(175, 125);
            this.listaTexto2.Name = "listaTexto2";
            this.listaTexto2.Size = new System.Drawing.Size(153, 95);
            this.listaTexto2.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Izquierda";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Derecha";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 554);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.listaTexto2);
            this.Controls.Add(this.listaTexto1);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.cajaTexto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cajaTexto1;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.ListBox listaTexto1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox listaTexto2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

