namespace FormularioFamilias
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            Aceptar = new Button();
            groupBox2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            trackBar1 = new TrackBar();
            label1 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            treeView1 = new TreeView();
            label2 = new Label();
            labelHijo = new Label();
            textBox5 = new TextBox();
            nombreHijos = new Label();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            checkBox1 = new CheckBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            nombre = new Label();
            apellidos = new Label();
            telefono = new Label();
            direccion = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            labelBuscar = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            buscaNombre = new Label();
            textBox6 = new TextBox();
            buscaApellidos = new Label();
            textBox7 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel5);
            splitContainer1.Size = new Size(1412, 783);
            splitContainer1.SplitterDistance = 697;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Aceptar, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 363F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.Size = new Size(697, 783);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Aceptar
            // 
            Aceptar.Dock = DockStyle.Fill;
            Aceptar.Location = new Point(3, 734);
            Aceptar.Margin = new Padding(3, 4, 3, 4);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(691, 45);
            Aceptar.TabIndex = 3;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            Aceptar.Click += Aceptar_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 371);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.RightToLeft = RightToLeft.No;
            groupBox2.Size = new Size(691, 355);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información hijos";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62F));
            tableLayoutPanel3.Controls.Add(trackBar1, 0, 0);
            tableLayoutPanel3.Controls.Add(label1, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 24);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 17.045454F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 82.9545441F));
            tableLayoutPanel3.Size = new Size(685, 327);
            tableLayoutPanel3.TabIndex = 1;
            tableLayoutPanel3.Tag = "";
            // 
            // trackBar1
            // 
            trackBar1.Dock = DockStyle.Fill;
            trackBar1.Enabled = false;
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(3, 4);
            trackBar1.Margin = new Padding(3, 4, 3, 4);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(617, 47);
            trackBar1.TabIndex = 1;
            trackBar1.Value = 1;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(626, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 55);
            label1.TabIndex = 2;
            label1.Text = "1";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel3.SetColumnSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 231F));
            tableLayoutPanel4.Controls.Add(treeView1, 2, 0);
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(labelHijo, 1, 0);
            tableLayoutPanel4.Controls.Add(textBox5, 0, 2);
            tableLayoutPanel4.Controls.Add(nombreHijos, 0, 1);
            tableLayoutPanel4.Controls.Add(button1, 0, 4);
            tableLayoutPanel4.Controls.Add(progressBar1, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 59);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel4.Size = new Size(679, 264);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(451, 4);
            treeView1.Margin = new Padding(3, 4, 3, 4);
            treeView1.Name = "treeView1";
            tableLayoutPanel4.SetRowSpan(treeView1, 5);
            treeView1.Size = new Size(225, 256);
            treeView1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 0;
            label2.Text = "Datos hijos";
            // 
            // labelHijo
            // 
            labelHijo.AutoSize = true;
            labelHijo.Dock = DockStyle.Fill;
            labelHijo.ForeColor = Color.Green;
            labelHijo.Location = new Point(208, 0);
            labelHijo.Name = "labelHijo";
            labelHijo.Size = new Size(237, 39);
            labelHijo.TabIndex = 11;
            labelHijo.Text = "Hijo añadido con éxito";
            labelHijo.TextAlign = ContentAlignment.MiddleRight;
            labelHijo.Visible = false;
            // 
            // textBox5
            // 
            tableLayoutPanel4.SetColumnSpan(textBox5, 2);
            textBox5.Dock = DockStyle.Fill;
            textBox5.Enabled = false;
            textBox5.Location = new Point(3, 82);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(442, 27);
            textBox5.TabIndex = 5;
            // 
            // nombreHijos
            // 
            nombreHijos.AutoSize = true;
            nombreHijos.Dock = DockStyle.Fill;
            nombreHijos.Location = new Point(3, 39);
            nombreHijos.Name = "nombreHijos";
            nombreHijos.Size = new Size(199, 39);
            nombreHijos.TabIndex = 12;
            nombreHijos.Text = "Nombre hijos";
            // 
            // button1
            // 
            tableLayoutPanel4.SetColumnSpan(button1, 2);
            button1.Dock = DockStyle.Fill;
            button1.Enabled = false;
            button1.Location = new Point(3, 224);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(442, 36);
            button1.TabIndex = 8;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Fill;
            progressBar1.Location = new Point(208, 43);
            progressBar1.Margin = new Padding(3, 4, 3, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(237, 31);
            progressBar1.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(691, 359);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos personales";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(checkBox1, 0, 8);
            tableLayoutPanel2.Controls.Add(textBox4, 0, 7);
            tableLayoutPanel2.Controls.Add(textBox3, 0, 5);
            tableLayoutPanel2.Controls.Add(textBox2, 0, 3);
            tableLayoutPanel2.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel2.Controls.Add(nombre, 0, 0);
            tableLayoutPanel2.Controls.Add(apellidos, 0, 2);
            tableLayoutPanel2.Controls.Add(telefono, 0, 4);
            tableLayoutPanel2.Controls.Add(direccion, 0, 6);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 24);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 32.727272F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 67.27273F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(685, 331);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Tag = "";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 294);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(110, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Añadir hijos";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox4
            // 
            textBox4.Dock = DockStyle.Fill;
            textBox4.Location = new Point(3, 235);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(679, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(3, 166);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.MaxLength = 15;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(679, 27);
            textBox3.TabIndex = 1;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(3, 100);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(679, 27);
            textBox2.TabIndex = 2;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 27);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(679, 27);
            textBox1.TabIndex = 0;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Dock = DockStyle.Fill;
            nombre.Location = new Point(3, 0);
            nombre.Name = "nombre";
            nombre.Size = new Size(679, 23);
            nombre.TabIndex = 7;
            nombre.Text = "Nombre";
            // 
            // apellidos
            // 
            apellidos.AutoSize = true;
            apellidos.Dock = DockStyle.Fill;
            apellidos.Location = new Point(3, 71);
            apellidos.Name = "apellidos";
            apellidos.Size = new Size(679, 25);
            apellidos.TabIndex = 8;
            apellidos.Text = "Apellidos";
            // 
            // telefono
            // 
            telefono.AutoSize = true;
            telefono.Dock = DockStyle.Fill;
            telefono.Location = new Point(3, 141);
            telefono.Name = "telefono";
            telefono.Size = new Size(679, 21);
            telefono.TabIndex = 9;
            telefono.Text = "Teléfono";
            // 
            // direccion
            // 
            direccion.AutoSize = true;
            direccion.Dock = DockStyle.Fill;
            direccion.Location = new Point(3, 211);
            direccion.Name = "direccion";
            direccion.Size = new Size(679, 20);
            direccion.TabIndex = 10;
            direccion.Text = "Dirección";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 278F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel5.Controls.Add(labelBuscar, 0, 0);
            tableLayoutPanel5.Controls.Add(dataGridView1, 1, 3);
            tableLayoutPanel5.Controls.Add(buscaNombre, 0, 1);
            tableLayoutPanel5.Controls.Add(textBox6, 0, 2);
            tableLayoutPanel5.Controls.Add(buscaApellidos, 1, 1);
            tableLayoutPanel5.Controls.Add(textBox7, 1, 2);
            tableLayoutPanel5.Controls.Add(button2, 3, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 93.22034F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 643F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(710, 783);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // labelBuscar
            // 
            labelBuscar.AutoSize = true;
            tableLayoutPanel5.SetColumnSpan(labelBuscar, 4);
            labelBuscar.Dock = DockStyle.Fill;
            labelBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBuscar.Location = new Point(3, 0);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Size = new Size(704, 42);
            labelBuscar.TabIndex = 5;
            labelBuscar.Text = "BÚSQUEDA";
            labelBuscar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            tableLayoutPanel5.SetColumnSpan(dataGridView1, 4);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 144);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(704, 635);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Apellidos";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Teléfono";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Dirección";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Hijos";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // buscaNombre
            // 
            buscaNombre.AutoSize = true;
            buscaNombre.Location = new Point(3, 42);
            buscaNombre.Name = "buscaNombre";
            buscaNombre.Size = new Size(64, 20);
            buscaNombre.TabIndex = 9;
            buscaNombre.Text = "Nombre";
            // 
            // textBox6
            // 
            textBox6.Dock = DockStyle.Fill;
            textBox6.Location = new Point(3, 72);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(158, 27);
            textBox6.TabIndex = 6;
            // 
            // buscaApellidos
            // 
            buscaApellidos.AutoSize = true;
            buscaApellidos.Location = new Point(167, 42);
            buscaApellidos.Name = "buscaApellidos";
            buscaApellidos.Size = new Size(72, 20);
            buscaApellidos.TabIndex = 11;
            buscaApellidos.Text = "Apellidos";
            // 
            // textBox7
            // 
            textBox7.Dock = DockStyle.Fill;
            textBox7.Location = new Point(167, 72);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 27);
            textBox7.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(601, 72);
            button2.Name = "button2";
            button2.Size = new Size(93, 35);
            button2.TabIndex = 10;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 783);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private CheckBox checkBox1;
        private TrackBar trackBar1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox textBox5;
        private Label label2;
        private Button Aceptar;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label labelHijo;
        private TreeView treeView1;
        private Label nombre;
        private Label apellidos;
        private Label telefono;
        private Label direccion;
        private Label nombreHijos;
        private ProgressBar progressBar1;
        private Label labelBuscar;
        private TextBox textBox6;
        private Label buscaNombre;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button2;
        private Label buscaApellidos;
        private TextBox textBox7;
    }
}
