namespace InformesClase1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.empleadosDataSet = new InformesClase1.EmpleadosDataSet();
            this.empleadosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentoTableAdapter = new InformesClase1.EmpleadosDataSetTableAdapters.departamentoTableAdapter();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new InformesClase1.EmpleadosDataSetTableAdapters.empleadoTableAdapter();
            this.departamentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.departamentoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // empleadosDataSet
            // 
            this.empleadosDataSet.DataSetName = "EmpleadosDataSet";
            this.empleadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosDataSetBindingSource
            // 
            this.empleadosDataSetBindingSource.DataSource = this.empleadosDataSet;
            this.empleadosDataSetBindingSource.Position = 0;
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "departamento";
            this.departamentoBindingSource.DataSource = this.empleadosDataSet;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "empleado";
            this.empleadoBindingSource.DataSource = this.empleadosDataSet;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // departamentoBindingSource1
            // 
            this.departamentoBindingSource1.DataMember = "departamento";
            this.departamentoBindingSource1.DataSource = this.empleadosDataSetBindingSource;
            // 
            // departamentoBindingSource2
            // 
            this.departamentoBindingSource2.DataMember = "departamento";
            this.departamentoBindingSource2.DataSource = this.empleadosDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetEmpleados";
            reportDataSource1.Value = this.empleadoBindingSource;
            reportDataSource2.Name = "DataSetDepartamento";
            reportDataSource2.Value = this.departamentoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InformesClase1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private EmpleadosDataSet empleadosDataSet;
        private System.Windows.Forms.BindingSource empleadosDataSetBindingSource;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private EmpleadosDataSetTableAdapters.departamentoTableAdapter departamentoTableAdapter;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private EmpleadosDataSetTableAdapters.empleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.BindingSource departamentoBindingSource1;
        private System.Windows.Forms.BindingSource departamentoBindingSource2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}

