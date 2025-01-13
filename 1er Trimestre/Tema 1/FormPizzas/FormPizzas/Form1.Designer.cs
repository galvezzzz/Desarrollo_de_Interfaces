namespace FormPizzas
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            comboTamanyo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboPostre = new ComboBox();
            comboBebida = new ComboBox();
            label7 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tbIngrediente = new TextBox();
            btnAnyadir = new Button();
            labelError = new Label();
            listBox1 = new ListBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            tbHora = new TextBox();
            tbFecha = new TextBox();
            tbTelefono = new TextBox();
            tbDireccion = new TextBox();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            tbNombre = new TextBox();
            btnAceptar = new Button();
            cbDomicilio = new CheckBox();
            btnReset = new Button();
            dataGridView1 = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            hora = new DataGridViewTextBoxColumn();
            domicilio = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.5077362F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.4922638F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(1390, 948);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 233F));
            tableLayoutPanel2.Controls.Add(comboTamanyo, 2, 4);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 2, 1);
            tableLayoutPanel2.Controls.Add(label5, 1, 3);
            tableLayoutPanel2.Controls.Add(label6, 0, 3);
            tableLayoutPanel2.Controls.Add(comboPostre, 1, 4);
            tableLayoutPanel2.Controls.Add(comboBebida, 0, 4);
            tableLayoutPanel2.Controls.Add(label7, 2, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel2.Controls.Add(labelError, 1, 1);
            tableLayoutPanel2.Controls.Add(listBox1, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 61.363636F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 38.636364F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 248F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tableLayoutPanel2.Size = new Size(689, 461);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // comboTamanyo
            // 
            comboTamanyo.Dock = DockStyle.Fill;
            comboTamanyo.FormattingEnabled = true;
            comboTamanyo.Items.AddRange(new object[] { "Pequeña (5€)", "Mediana (7€)", "Grande (9€)" });
            comboTamanyo.Location = new Point(459, 376);
            comboTamanyo.Margin = new Padding(3, 4, 3, 4);
            comboTamanyo.Name = "comboTamanyo";
            comboTamanyo.Size = new Size(227, 28);
            comboTamanyo.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label1, 3);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(683, 58);
            label1.TabIndex = 0;
            label1.Text = "Pedido";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(3, 58);
            label2.Name = "label2";
            label2.Size = new Size(222, 37);
            label2.TabIndex = 1;
            label2.Text = "Crea tu pizza";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(459, 58);
            label3.Name = "label3";
            label3.Size = new Size(227, 37);
            label3.TabIndex = 3;
            label3.Text = "Ingredientes añadidos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(231, 343);
            label5.Name = "label5";
            label5.Size = new Size(222, 29);
            label5.TabIndex = 6;
            label5.Text = "Postre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 343);
            label6.Name = "label6";
            label6.Size = new Size(222, 29);
            label6.TabIndex = 7;
            label6.Text = "Bebida";
            // 
            // comboPostre
            // 
            comboPostre.Dock = DockStyle.Fill;
            comboPostre.FormattingEnabled = true;
            comboPostre.Items.AddRange(new object[] { "Tiramisú (3€)", "Helado (3€)", "Fruta (3€)", "Arroz con leche (3€)" });
            comboPostre.Location = new Point(231, 376);
            comboPostre.Margin = new Padding(3, 4, 3, 4);
            comboPostre.Name = "comboPostre";
            comboPostre.Size = new Size(222, 28);
            comboPostre.TabIndex = 8;
            // 
            // comboBebida
            // 
            comboBebida.Dock = DockStyle.Fill;
            comboBebida.FormattingEnabled = true;
            comboBebida.Items.AddRange(new object[] { "Agua (1€)", "Cerveza (1€)", "CocaCola (1€)", "Fanta (1€)" });
            comboBebida.Location = new Point(3, 376);
            comboBebida.Margin = new Padding(3, 4, 3, 4);
            comboBebida.Name = "comboBebida";
            comboBebida.Size = new Size(222, 28);
            comboBebida.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(459, 343);
            label7.Name = "label7";
            label7.Size = new Size(227, 29);
            label7.TabIndex = 10;
            label7.Text = "Tamaño pizza";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tbIngrediente, 0, 0);
            tableLayoutPanel3.Controls.Add(btnAnyadir, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 99);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(222, 240);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // tbIngrediente
            // 
            tbIngrediente.Dock = DockStyle.Fill;
            tbIngrediente.Location = new Point(3, 4);
            tbIngrediente.Margin = new Padding(3, 4, 3, 4);
            tbIngrediente.Name = "tbIngrediente";
            tbIngrediente.Size = new Size(216, 27);
            tbIngrediente.TabIndex = 16;
            // 
            // btnAnyadir
            // 
            btnAnyadir.Dock = DockStyle.Fill;
            btnAnyadir.Location = new Point(3, 196);
            btnAnyadir.Margin = new Padding(3, 4, 3, 4);
            btnAnyadir.Name = "btnAnyadir";
            btnAnyadir.Size = new Size(216, 40);
            btnAnyadir.TabIndex = 17;
            btnAnyadir.Text = "Añadir";
            btnAnyadir.UseVisualStyleBackColor = true;
            btnAnyadir.Click += btnAnyadir_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Dock = DockStyle.Fill;
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(231, 58);
            labelError.Name = "labelError";
            labelError.Size = new Size(222, 37);
            labelError.TabIndex = 5;
            labelError.Text = "No puedes añadir más ";
            labelError.Visible = false;
            // 
            // listBox1
            // 
            tableLayoutPanel2.SetColumnSpan(listBox1, 2);
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(231, 99);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(455, 240);
            listBox1.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tbHora, 0, 6);
            tableLayoutPanel4.Controls.Add(tbFecha, 1, 4);
            tableLayoutPanel4.Controls.Add(tbTelefono, 0, 4);
            tableLayoutPanel4.Controls.Add(tbDireccion, 1, 2);
            tableLayoutPanel4.Controls.Add(label10, 1, 1);
            tableLayoutPanel4.Controls.Add(label8, 0, 0);
            tableLayoutPanel4.Controls.Add(label9, 0, 1);
            tableLayoutPanel4.Controls.Add(label11, 0, 3);
            tableLayoutPanel4.Controls.Add(label12, 1, 3);
            tableLayoutPanel4.Controls.Add(label13, 0, 5);
            tableLayoutPanel4.Controls.Add(tbNombre, 0, 2);
            tableLayoutPanel4.Controls.Add(btnAceptar, 0, 7);
            tableLayoutPanel4.Controls.Add(cbDomicilio, 1, 6);
            tableLayoutPanel4.Controls.Add(btnReset, 0, 8);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 473);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 9;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 67.21311F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 32.7868843F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 149F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel4.Size = new Size(689, 471);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // tbHora
            // 
            tbHora.Dock = DockStyle.Fill;
            tbHora.Location = new Point(3, 222);
            tbHora.Margin = new Padding(3, 4, 3, 4);
            tbHora.MaxLength = 5;
            tbHora.Name = "tbHora";
            tbHora.Size = new Size(338, 27);
            tbHora.TabIndex = 13;
            tbHora.KeyPress += tbHora_KeyPress;
            // 
            // tbFecha
            // 
            tbFecha.Dock = DockStyle.Fill;
            tbFecha.Location = new Point(347, 147);
            tbFecha.Margin = new Padding(3, 4, 3, 4);
            tbFecha.MaxLength = 5;
            tbFecha.Name = "tbFecha";
            tbFecha.Size = new Size(339, 27);
            tbFecha.TabIndex = 12;
            tbFecha.KeyPress += tbFecha_KeyPress;
            // 
            // tbTelefono
            // 
            tbTelefono.Dock = DockStyle.Fill;
            tbTelefono.Location = new Point(3, 147);
            tbTelefono.Margin = new Padding(3, 4, 3, 4);
            tbTelefono.MaxLength = 9;
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(338, 27);
            tbTelefono.TabIndex = 10;
            tbTelefono.KeyPress += tbTelefono_KeyPress;
            // 
            // tbDireccion
            // 
            tbDireccion.Dock = DockStyle.Fill;
            tbDireccion.Location = new Point(347, 77);
            tbDireccion.Margin = new Padding(3, 4, 3, 4);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(339, 27);
            tbDireccion.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(347, 49);
            label10.Name = "label10";
            label10.Size = new Size(339, 24);
            label10.TabIndex = 3;
            label10.Text = "Dirección";
            // 
            // label8
            // 
            label8.AutoSize = true;
            tableLayoutPanel4.SetColumnSpan(label8, 4);
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(683, 49);
            label8.TabIndex = 1;
            label8.Text = "Datos cliente";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(3, 49);
            label9.Name = "label9";
            label9.Size = new Size(338, 24);
            label9.TabIndex = 2;
            label9.Text = "Nombre";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(3, 112);
            label11.Name = "label11";
            label11.Size = new Size(338, 31);
            label11.TabIndex = 4;
            label11.Text = "Teléfono";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(347, 112);
            label12.Name = "label12";
            label12.Size = new Size(339, 31);
            label12.TabIndex = 5;
            label12.Text = "Fecha (dd/MM)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Location = new Point(3, 195);
            label13.Name = "label13";
            label13.Size = new Size(338, 23);
            label13.TabIndex = 6;
            label13.Text = "Hora (XX:XX)";
            // 
            // tbNombre
            // 
            tbNombre.Dock = DockStyle.Fill;
            tbNombre.Location = new Point(3, 77);
            tbNombre.Margin = new Padding(3, 4, 3, 4);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(338, 27);
            tbNombre.TabIndex = 8;
            // 
            // btnAceptar
            // 
            tableLayoutPanel4.SetColumnSpan(btnAceptar, 2);
            btnAceptar.Dock = DockStyle.Fill;
            btnAceptar.Location = new Point(3, 371);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(683, 47);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cbDomicilio
            // 
            cbDomicilio.AutoSize = true;
            cbDomicilio.Location = new Point(347, 222);
            cbDomicilio.Margin = new Padding(3, 4, 3, 4);
            cbDomicilio.Name = "cbDomicilio";
            cbDomicilio.Size = new Size(161, 24);
            cbDomicilio.TabIndex = 11;
            cbDomicilio.Text = "Entrega a domicilio";
            cbDomicilio.TextAlign = ContentAlignment.TopLeft;
            cbDomicilio.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            tableLayoutPanel4.SetColumnSpan(btnReset, 2);
            btnReset.Dock = DockStyle.Fill;
            btnReset.Location = new Point(3, 426);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(683, 41);
            btnReset.TabIndex = 15;
            btnReset.Text = "Reiniciar";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombre, direccion, telefono, fecha, hora, domicilio });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(698, 4);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dataGridView1, 2);
            dataGridView1.Size = new Size(689, 940);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // direccion
            // 
            direccion.HeaderText = "Dirección";
            direccion.MinimumWidth = 6;
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.HeaderText = "Teléfono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha ";
            fecha.MinimumWidth = 6;
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            // 
            // hora
            // 
            hora.HeaderText = "Hora";
            hora.MinimumWidth = 6;
            hora.Name = "hora";
            hora.ReadOnly = true;
            // 
            // domicilio
            // 
            domicilio.HeaderText = "Entrega domicilio";
            domicilio.MinimumWidth = 6;
            domicilio.Name = "domicilio";
            domicilio.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 948);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Label label3;
        private Label labelError;
        private Label label5;
        private Label label6;
        private ComboBox comboPostre;
        private ComboBox comboBebida;
        private Label label7;
        private ComboBox comboTamanyo;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label10;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox tbHora;
        private TextBox tbFecha;
        private TextBox tbTelefono;
        private TextBox tbDireccion;
        private TextBox tbNombre;
        private CheckBox cbDomicilio;
        private Button btnAceptar;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox tbIngrediente;
        private Button btnAnyadir;
        private Button btnReset;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn hora;
        private DataGridViewTextBoxColumn domicilio;
    }
}
