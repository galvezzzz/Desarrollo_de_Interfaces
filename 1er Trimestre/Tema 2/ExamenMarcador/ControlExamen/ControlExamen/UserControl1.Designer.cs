namespace ControlExamen
{
    partial class Marcador
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mLocalLbl = new System.Windows.Forms.Label();
            this.mVisitanteLbl = new System.Windows.Forms.Label();
            this.periodoLbl = new System.Windows.Forms.Label();
            this.localLbl = new System.Windows.Forms.Label();
            this.visitanteLbl = new System.Windows.Forms.Label();
            this.tiempoLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.escudoVisitanteImg = new System.Windows.Forms.PictureBox();
            this.escudoLocalImg = new System.Windows.Forms.PictureBox();
            this.periodoMarcador = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escudoVisitanteImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escudoLocalImg)).BeginInit();
            this.SuspendLayout();
            // 
            // mLocalLbl
            // 
            this.mLocalLbl.AutoSize = true;
            this.mLocalLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mLocalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLocalLbl.ForeColor = System.Drawing.Color.Lime;
            this.mLocalLbl.Location = new System.Drawing.Point(3, 45);
            this.mLocalLbl.Name = "mLocalLbl";
            this.mLocalLbl.Size = new System.Drawing.Size(260, 180);
            this.mLocalLbl.TabIndex = 0;
            this.mLocalLbl.Text = "0";
            this.mLocalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mVisitanteLbl
            // 
            this.mVisitanteLbl.AutoSize = true;
            this.mVisitanteLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mVisitanteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mVisitanteLbl.ForeColor = System.Drawing.Color.Lime;
            this.mVisitanteLbl.Location = new System.Drawing.Point(535, 45);
            this.mVisitanteLbl.Name = "mVisitanteLbl";
            this.mVisitanteLbl.Size = new System.Drawing.Size(262, 180);
            this.mVisitanteLbl.TabIndex = 1;
            this.mVisitanteLbl.Text = "0";
            this.mVisitanteLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // periodoLbl
            // 
            this.periodoLbl.AutoSize = true;
            this.periodoLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.periodoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodoLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.periodoLbl.Location = new System.Drawing.Point(269, 0);
            this.periodoLbl.Name = "periodoLbl";
            this.periodoLbl.Size = new System.Drawing.Size(260, 45);
            this.periodoLbl.TabIndex = 2;
            this.periodoLbl.Text = "PERIODO";
            this.periodoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // localLbl
            // 
            this.localLbl.AutoSize = true;
            this.localLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.localLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.localLbl.Location = new System.Drawing.Point(3, 225);
            this.localLbl.Name = "localLbl";
            this.localLbl.Size = new System.Drawing.Size(260, 45);
            this.localLbl.TabIndex = 4;
            this.localLbl.Text = "LOCAL";
            this.localLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // visitanteLbl
            // 
            this.visitanteLbl.AutoSize = true;
            this.visitanteLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visitanteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitanteLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.visitanteLbl.Location = new System.Drawing.Point(535, 225);
            this.visitanteLbl.Name = "visitanteLbl";
            this.visitanteLbl.Size = new System.Drawing.Size(262, 45);
            this.visitanteLbl.TabIndex = 5;
            this.visitanteLbl.Text = "VISITANTE";
            this.visitanteLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tiempoLbl
            // 
            this.tiempoLbl.AutoSize = true;
            this.tiempoLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tiempoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tiempoLbl.Location = new System.Drawing.Point(269, 270);
            this.tiempoLbl.Name = "tiempoLbl";
            this.tiempoLbl.Size = new System.Drawing.Size(260, 180);
            this.tiempoLbl.TabIndex = 6;
            this.tiempoLbl.Text = "00:00";
            this.tiempoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.periodoLbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tiempoLbl, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.mLocalLbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.visitanteLbl, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.mVisitanteLbl, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.localLbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.escudoVisitanteImg, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.escudoLocalImg, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.periodoMarcador, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // escudoVisitanteImg
            // 
            this.escudoVisitanteImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.escudoVisitanteImg.Location = new System.Drawing.Point(535, 273);
            this.escudoVisitanteImg.Name = "escudoVisitanteImg";
            this.escudoVisitanteImg.Size = new System.Drawing.Size(262, 174);
            this.escudoVisitanteImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.escudoVisitanteImg.TabIndex = 10;
            this.escudoVisitanteImg.TabStop = false;
            // 
            // escudoLocalImg
            // 
            this.escudoLocalImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.escudoLocalImg.Location = new System.Drawing.Point(3, 273);
            this.escudoLocalImg.Name = "escudoLocalImg";
            this.escudoLocalImg.Size = new System.Drawing.Size(260, 174);
            this.escudoLocalImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.escudoLocalImg.TabIndex = 11;
            this.escudoLocalImg.TabStop = false;
            // 
            // periodoMarcador
            // 
            this.periodoMarcador.AutoSize = true;
            this.periodoMarcador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.periodoMarcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodoMarcador.ForeColor = System.Drawing.Color.Yellow;
            this.periodoMarcador.Location = new System.Drawing.Point(269, 45);
            this.periodoMarcador.Name = "periodoMarcador";
            this.periodoMarcador.Size = new System.Drawing.Size(260, 180);
            this.periodoMarcador.TabIndex = 12;
            this.periodoMarcador.Text = "1";
            this.periodoMarcador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Marcador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Marcador";
            this.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escudoVisitanteImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escudoLocalImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mLocalLbl;
        private System.Windows.Forms.Label mVisitanteLbl;
        private System.Windows.Forms.Label periodoLbl;
        private System.Windows.Forms.Label localLbl;
        private System.Windows.Forms.Label visitanteLbl;
        private System.Windows.Forms.Label tiempoLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox escudoVisitanteImg;
        private System.Windows.Forms.PictureBox escudoLocalImg;
        private System.Windows.Forms.Label periodoMarcador;
        private System.Windows.Forms.Timer timer1;
    }
}
