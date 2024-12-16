namespace DEINT_T1_DatosPersonales
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelrelleno = new System.Windows.Forms.Label();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.groupBox_hijos = new System.Windows.Forms.GroupBox();
            this.progressBar_hijos = new System.Windows.Forms.ProgressBar();
            this.button_modificar = new System.Windows.Forms.Button();
            this.label_10 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_errores = new System.Windows.Forms.Label();
            this.treeView_hijos = new System.Windows.Forms.TreeView();
            this.textBox_hijo = new System.Windows.Forms.TextBox();
            this.label_introduce = new System.Windows.Forms.Label();
            this.trackBar_hijos = new System.Windows.Forms.TrackBar();
            this.checkBox_hijos = new System.Windows.Forms.CheckBox();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label_telefono = new System.Windows.Forms.Label();
            this.label_direccion = new System.Windows.Forms.Label();
            this.label_apellido = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_datos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHijos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hijos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_buscar = new System.Windows.Forms.Button();
            this.dataGridView_buscar = new System.Windows.Forms.DataGridView();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.label_buscar = new System.Windows.Forms.Label();
            this.NombreBusqueda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosBusqueda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionBusqueda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoBusqueda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHijosBusqueda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_errorBuscar = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox_hijos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_hijos)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_datos)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(804, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos personales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(6, 33);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(47, 13);
            this.label_nombre.TabIndex = 1;
            this.label_nombre.Text = "Nombre:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 531);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelrelleno);
            this.panel1.Controls.Add(this.button_aceptar);
            this.panel1.Controls.Add(this.groupBox_hijos);
            this.panel1.Controls.Add(this.checkBox_hijos);
            this.panel1.Controls.Add(this.textBox_telefono);
            this.panel1.Controls.Add(this.textBox_direccion);
            this.panel1.Controls.Add(this.textBox_apellido);
            this.panel1.Controls.Add(this.textBox_nombre);
            this.panel1.Controls.Add(this.label_telefono);
            this.panel1.Controls.Add(this.label_direccion);
            this.panel1.Controls.Add(this.label_apellido);
            this.panel1.Controls.Add(this.label_nombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 525);
            this.panel1.TabIndex = 2;
            // 
            // labelrelleno
            // 
            this.labelrelleno.AutoSize = true;
            this.labelrelleno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelrelleno.Location = new System.Drawing.Point(6, 10);
            this.labelrelleno.Name = "labelrelleno";
            this.labelrelleno.Size = new System.Drawing.Size(0, 13);
            this.labelrelleno.TabIndex = 12;
            // 
            // button_aceptar
            // 
            this.button_aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_aceptar.Location = new System.Drawing.Point(18, 480);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(362, 36);
            this.button_aceptar.TabIndex = 11;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // groupBox_hijos
            // 
            this.groupBox_hijos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_hijos.Controls.Add(this.progressBar_hijos);
            this.groupBox_hijos.Controls.Add(this.button_modificar);
            this.groupBox_hijos.Controls.Add(this.label_10);
            this.groupBox_hijos.Controls.Add(this.label_1);
            this.groupBox_hijos.Controls.Add(this.label_errores);
            this.groupBox_hijos.Controls.Add(this.treeView_hijos);
            this.groupBox_hijos.Controls.Add(this.textBox_hijo);
            this.groupBox_hijos.Controls.Add(this.label_introduce);
            this.groupBox_hijos.Controls.Add(this.trackBar_hijos);
            this.groupBox_hijos.Enabled = false;
            this.groupBox_hijos.Location = new System.Drawing.Point(9, 176);
            this.groupBox_hijos.Name = "groupBox_hijos";
            this.groupBox_hijos.Size = new System.Drawing.Size(374, 298);
            this.groupBox_hijos.TabIndex = 10;
            this.groupBox_hijos.TabStop = false;
            // 
            // progressBar_hijos
            // 
            this.progressBar_hijos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_hijos.Location = new System.Drawing.Point(9, 117);
            this.progressBar_hijos.Name = "progressBar_hijos";
            this.progressBar_hijos.Size = new System.Drawing.Size(359, 23);
            this.progressBar_hijos.TabIndex = 8;
            // 
            // button_modificar
            // 
            this.button_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_modificar.Location = new System.Drawing.Point(149, 66);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(219, 23);
            this.button_modificar.TabIndex = 7;
            this.button_modificar.Text = "Parar de modificar";
            this.button_modificar.UseVisualStyleBackColor = true;
            this.button_modificar.Visible = false;
            this.button_modificar.Click += new System.EventHandler(this.button_modificar_Click);
            // 
            // label_10
            // 
            this.label_10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_10.AutoSize = true;
            this.label_10.Location = new System.Drawing.Point(346, 41);
            this.label_10.Name = "label_10";
            this.label_10.Size = new System.Drawing.Size(19, 13);
            this.label_10.TabIndex = 6;
            this.label_10.Text = "10";
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(13, 40);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(13, 13);
            this.label_1.TabIndex = 5;
            this.label_1.Text = "1";
            // 
            // label_errores
            // 
            this.label_errores.AutoSize = true;
            this.label_errores.ForeColor = System.Drawing.Color.Red;
            this.label_errores.Location = new System.Drawing.Point(6, 150);
            this.label_errores.Name = "label_errores";
            this.label_errores.Size = new System.Drawing.Size(0, 13);
            this.label_errores.TabIndex = 4;
            // 
            // treeView_hijos
            // 
            this.treeView_hijos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView_hijos.Location = new System.Drawing.Point(9, 171);
            this.treeView_hijos.Name = "treeView_hijos";
            this.treeView_hijos.Size = new System.Drawing.Size(359, 121);
            this.treeView_hijos.TabIndex = 3;
            this.treeView_hijos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView_hijos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView_hijos_KeyDown);
            // 
            // textBox_hijo
            // 
            this.textBox_hijo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_hijo.Location = new System.Drawing.Point(9, 91);
            this.textBox_hijo.Name = "textBox_hijo";
            this.textBox_hijo.Size = new System.Drawing.Size(359, 20);
            this.textBox_hijo.TabIndex = 2;
            this.textBox_hijo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_hijo_KeyPress);
            // 
            // label_introduce
            // 
            this.label_introduce.AutoSize = true;
            this.label_introduce.Location = new System.Drawing.Point(6, 70);
            this.label_introduce.Name = "label_introduce";
            this.label_introduce.Size = new System.Drawing.Size(140, 13);
            this.label_introduce.TabIndex = 1;
            this.label_introduce.Text = "Introduce el nombre del hijo:";
            // 
            // trackBar_hijos
            // 
            this.trackBar_hijos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_hijos.LargeChange = 1;
            this.trackBar_hijos.Location = new System.Drawing.Point(6, 19);
            this.trackBar_hijos.Minimum = 1;
            this.trackBar_hijos.Name = "trackBar_hijos";
            this.trackBar_hijos.Size = new System.Drawing.Size(362, 45);
            this.trackBar_hijos.TabIndex = 0;
            this.trackBar_hijos.Value = 1;
            this.trackBar_hijos.Scroll += new System.EventHandler(this.trackBar_hijos_Scroll);
            // 
            // checkBox_hijos
            // 
            this.checkBox_hijos.AutoSize = true;
            this.checkBox_hijos.Location = new System.Drawing.Point(6, 153);
            this.checkBox_hijos.Name = "checkBox_hijos";
            this.checkBox_hijos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_hijos.Size = new System.Drawing.Size(52, 17);
            this.checkBox_hijos.TabIndex = 9;
            this.checkBox_hijos.Text = ":Hijos";
            this.checkBox_hijos.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox_hijos.UseVisualStyleBackColor = true;
            this.checkBox_hijos.CheckedChanged += new System.EventHandler(this.checkBox_hijos_CheckedChanged);
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_telefono.Location = new System.Drawing.Point(67, 117);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(316, 20);
            this.textBox_telefono.TabIndex = 8;
            this.textBox_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_telefono_KeyPress);
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_direccion.Location = new System.Drawing.Point(67, 89);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(316, 20);
            this.textBox_direccion.TabIndex = 7;
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_apellido.Location = new System.Drawing.Point(67, 59);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(316, 20);
            this.textBox_apellido.TabIndex = 6;
            this.textBox_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_apellido_KeyPress);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_nombre.Location = new System.Drawing.Point(67, 30);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(316, 20);
            this.textBox_nombre.TabIndex = 5;
            this.textBox_nombre.TextChanged += new System.EventHandler(this.textBox_nombre_TextChanged);
            this.textBox_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nombre_KeyPress);
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.Location = new System.Drawing.Point(6, 120);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(52, 13);
            this.label_telefono.TabIndex = 4;
            this.label_telefono.Text = "Teléfono:";
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Location = new System.Drawing.Point(6, 92);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(55, 13);
            this.label_direccion.TabIndex = 3;
            this.label_direccion.Text = "Dirección:";
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Location = new System.Drawing.Point(6, 62);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(52, 13);
            this.label_apellido.TabIndex = 2;
            this.label_apellido.Text = "Apellidos:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(405, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 525);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.38095F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.61905F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(396, 525);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView_datos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 227);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView_datos
            // 
            this.dataGridView_datos.AllowUserToAddRows = false;
            this.dataGridView_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellidos,
            this.Direccion,
            this.Telefono,
            this.NHijos,
            this.hijos});
            this.dataGridView_datos.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_datos.MultiSelect = false;
            this.dataGridView_datos.Name = "dataGridView_datos";
            this.dataGridView_datos.ReadOnly = true;
            this.dataGridView_datos.RowHeadersVisible = false;
            this.dataGridView_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_datos.Size = new System.Drawing.Size(381, 221);
            this.dataGridView_datos.TabIndex = 3;
            this.dataGridView_datos.SelectionChanged += new System.EventHandler(this.dataGridView_datos_SelectionChanged);
            this.dataGridView_datos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_datos_KeyDown);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // NHijos
            // 
            this.NHijos.HeaderText = "Nº Hijos";
            this.NHijos.Name = "NHijos";
            this.NHijos.ReadOnly = true;
            // 
            // hijos
            // 
            this.hijos.HeaderText = "hijos";
            this.hijos.Name = "hijos";
            this.hijos.ReadOnly = true;
            this.hijos.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_errorBuscar);
            this.panel4.Controls.Add(this.button_buscar);
            this.panel4.Controls.Add(this.dataGridView_buscar);
            this.panel4.Controls.Add(this.textBox_buscar);
            this.panel4.Controls.Add(this.label_buscar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 236);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 286);
            this.panel4.TabIndex = 1;
            // 
            // button_buscar
            // 
            this.button_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_buscar.Location = new System.Drawing.Point(0, 54);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(384, 25);
            this.button_buscar.TabIndex = 8;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // dataGridView_buscar
            // 
            this.dataGridView_buscar.AllowUserToAddRows = false;
            this.dataGridView_buscar.AllowUserToDeleteRows = false;
            this.dataGridView_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_buscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_buscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_buscar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreBusqueda,
            this.ApellidosBusqueda,
            this.DireccionBusqueda,
            this.TelefonoBusqueda,
            this.NHijosBusqueda});
            this.dataGridView_buscar.Location = new System.Drawing.Point(0, 85);
            this.dataGridView_buscar.MultiSelect = false;
            this.dataGridView_buscar.Name = "dataGridView_buscar";
            this.dataGridView_buscar.ReadOnly = true;
            this.dataGridView_buscar.RowHeadersVisible = false;
            this.dataGridView_buscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_buscar.Size = new System.Drawing.Size(384, 195);
            this.dataGridView_buscar.TabIndex = 4;
            // 
            // textBox_buscar
            // 
            this.textBox_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_buscar.Location = new System.Drawing.Point(139, 29);
            this.textBox_buscar.Name = "textBox_buscar";
            this.textBox_buscar.Size = new System.Drawing.Size(245, 20);
            this.textBox_buscar.TabIndex = 9;
            // 
            // label_buscar
            // 
            this.label_buscar.AutoSize = true;
            this.label_buscar.Location = new System.Drawing.Point(0, 32);
            this.label_buscar.Name = "label_buscar";
            this.label_buscar.Size = new System.Drawing.Size(133, 13);
            this.label_buscar.TabIndex = 7;
            this.label_buscar.Text = "Introduce lo que buscaras:";
            // 
            // NombreBusqueda
            // 
            this.NombreBusqueda.HeaderText = "Nombre";
            this.NombreBusqueda.Name = "NombreBusqueda";
            this.NombreBusqueda.ReadOnly = true;
            // 
            // ApellidosBusqueda
            // 
            this.ApellidosBusqueda.HeaderText = "Apellidos";
            this.ApellidosBusqueda.Name = "ApellidosBusqueda";
            this.ApellidosBusqueda.ReadOnly = true;
            // 
            // DireccionBusqueda
            // 
            this.DireccionBusqueda.HeaderText = "Dirección";
            this.DireccionBusqueda.Name = "DireccionBusqueda";
            this.DireccionBusqueda.ReadOnly = true;
            // 
            // TelefonoBusqueda
            // 
            this.TelefonoBusqueda.HeaderText = "Teléfono";
            this.TelefonoBusqueda.Name = "TelefonoBusqueda";
            this.TelefonoBusqueda.ReadOnly = true;
            // 
            // NHijosBusqueda
            // 
            this.NHijosBusqueda.HeaderText = "Nº Hijos";
            this.NHijosBusqueda.Name = "NHijosBusqueda";
            this.NHijosBusqueda.ReadOnly = true;
            // 
            // label_errorBuscar
            // 
            this.label_errorBuscar.AutoSize = true;
            this.label_errorBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_errorBuscar.Location = new System.Drawing.Point(3, 11);
            this.label_errorBuscar.Name = "label_errorBuscar";
            this.label_errorBuscar.Size = new System.Drawing.Size(0, 13);
            this.label_errorBuscar.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 581);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(820, 620);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_hijos.ResumeLayout(false);
            this.groupBox_hijos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_hijos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_datos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_datos;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.GroupBox groupBox_hijos;
        private System.Windows.Forms.CheckBox checkBox_hijos;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label_telefono;
        private System.Windows.Forms.TrackBar trackBar_hijos;
        private System.Windows.Forms.TextBox textBox_hijo;
        private System.Windows.Forms.Label label_introduce;
        private System.Windows.Forms.TreeView treeView_hijos;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Label label_errores;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelrelleno;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label_10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHijos;
        private System.Windows.Forms.DataGridViewTextBoxColumn hijos;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.ProgressBar progressBar_hijos;
        private System.Windows.Forms.DataGridView dataGridView_buscar;
        private System.Windows.Forms.TextBox textBox_buscar;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Label label_buscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHijosBusqueda;
        private System.Windows.Forms.Label label_errorBuscar;
    }
}

