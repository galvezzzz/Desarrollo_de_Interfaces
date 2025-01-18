namespace UsoMarcador
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
            this.trackBarVisitante = new System.Windows.Forms.TrackBar();
            this.trackBarLocal = new System.Windows.Forms.TrackBar();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.periodoCombo = new System.Windows.Forms.ComboBox();
            this.marcador1 = new ControlExamen.Marcador();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarVisitante
            // 
            this.trackBarVisitante.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarVisitante.LargeChange = 1;
            this.trackBarVisitante.Location = new System.Drawing.Point(808, 31);
            this.trackBarVisitante.Maximum = 9;
            this.trackBarVisitante.Name = "trackBarVisitante";
            this.trackBarVisitante.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVisitante.Size = new System.Drawing.Size(45, 444);
            this.trackBarVisitante.TabIndex = 8;
            this.trackBarVisitante.Scroll += new System.EventHandler(this.trackBarVisitante_Scroll);
            // 
            // trackBarLocal
            // 
            this.trackBarLocal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarLocal.LargeChange = 1;
            this.trackBarLocal.Location = new System.Drawing.Point(34, 31);
            this.trackBarLocal.Name = "trackBarLocal";
            this.trackBarLocal.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarLocal.Size = new System.Drawing.Size(45, 444);
            this.trackBarLocal.TabIndex = 9;
            this.trackBarLocal.Scroll += new System.EventHandler(this.trackBarLocal_Scroll);
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnComenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnComenzar.Location = new System.Drawing.Point(313, 413);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(251, 62);
            this.btnComenzar.TabIndex = 11;
            this.btnComenzar.Text = "COMENZAR";
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // periodoCombo
            // 
            this.periodoCombo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.periodoCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodoCombo.ForeColor = System.Drawing.Color.Yellow;
            this.periodoCombo.FormattingEnabled = true;
            this.periodoCombo.Items.AddRange(new object[] {
            "1",
            "2"});
            this.periodoCombo.Location = new System.Drawing.Point(375, 31);
            this.periodoCombo.Name = "periodoCombo";
            this.periodoCombo.Size = new System.Drawing.Size(121, 50);
            this.periodoCombo.TabIndex = 12;
            this.periodoCombo.SelectedIndexChanged += new System.EventHandler(this.periodoCombo_SelectedIndexChanged_1);
            // 
            // marcador1
            // 
            this.marcador1.escudoLocal = global::UsoMarcador.Properties.Resources.madridPNG;
            this.marcador1.escudoVisitante = global::UsoMarcador.Properties.Resources.bilbaoPNG;
            this.marcador1.Location = new System.Drawing.Point(147, 113);
            this.marcador1.marcadorLocal = "0";
            this.marcador1.marcadorVisitante = "0";
            this.marcador1.Name = "marcador1";
            this.marcador1.nombreLocal = "LOCAL";
            this.marcador1.nombreVisitante = "VISITANTE";
            this.marcador1.periodo = "1";
            this.marcador1.Size = new System.Drawing.Size(588, 262);
            this.marcador1.TabIndex = 13;
            this.marcador1.tiempo = "00:00";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UsoMarcador.Properties.Resources.santiago_bernabeu;
            this.ClientSize = new System.Drawing.Size(865, 534);
            this.Controls.Add(this.marcador1);
            this.Controls.Add(this.periodoCombo);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.trackBarLocal);
            this.Controls.Add(this.trackBarVisitante);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVisitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLocal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarVisitante;
        private System.Windows.Forms.TrackBar trackBarLocal;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.ComboBox periodoCombo;
        private ControlExamen.Marcador marcador1;
        private System.Windows.Forms.Timer timer;
    }
}

