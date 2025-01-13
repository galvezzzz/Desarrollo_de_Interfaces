namespace Formulario3
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            groupBox1 = new GroupBox();
            listBox3 = new ListBox();
            textBox1 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Reem Kufi", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(14, 30);
            label1.Name = "label1";
            label1.Size = new Size(177, 86);
            label1.TabIndex = 0;
            label1.Text = "FORD";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Rubik", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kuga", "Mustang", "Fiesta", "Puma" });
            comboBox1.Location = new Point(33, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 27);
            comboBox1.TabIndex = 1;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.ImageLocation = "C:\\Users\\Alberto\\Desktop\\Interfaces";
            pictureBox1.Location = new Point(565, 222);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(344, 304);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.ImageLocation = "C:\\Users\\Alberto\\Desktop\\Interfaces\\Formulario3\\ImgCoches\\pngegg.png";
            pictureBox2.Location = new Point(833, 48);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.DisplayMember = "1";
            listBox1.Font = new Font("Reem Kufi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(33, 253);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(217, 165);
            listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Reem Kufi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 23;
            listBox2.Location = new Point(301, 253);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(217, 165);
            listBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 222);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 7;
            label2.Text = "Añadir extras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(301, 223);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 8;
            label3.Text = "Extras añadidos";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(33, 422);
            button1.Name = "button1";
            button1.Size = new Size(41, 38);
            button1.TabIndex = 9;
            button1.Text = ">>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(301, 423);
            button2.Name = "button2";
            button2.Size = new Size(42, 37);
            button2.TabIndex = 10;
            button2.Text = "<<";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Reem Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(33, 511);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(217, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Reem Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Location = new Point(33, 593);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(217, 25);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 480);
            label4.Name = "label4";
            label4.Size = new Size(131, 28);
            label4.TabIndex = 13;
            label4.Text = "Fecha de entrega";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(301, 480);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(217, 147);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Descuentos";
            // 
            // listBox3
            // 
            listBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox3.Font = new Font("Reem Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 22;
            listBox3.Location = new Point(6, 68);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(205, 70);
            listBox3.TabIndex = 1;
            listBox3.KeyDown += listBox3_KeyDown;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox1.Font = new Font("Reem Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(6, 31);
            textBox1.MaxLength = 5;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 25);
            textBox1.TabIndex = 0;
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.KeyPress += textBox1_KeyPress_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 562);
            label5.Name = "label5";
            label5.Size = new Size(108, 28);
            label5.TabIndex = 15;
            label5.Text = "Nº de puertas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 774);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private GroupBox groupBox1;
        private Label label5;
        private ListBox listBox3;
        private TextBox textBox1;
    }
}
