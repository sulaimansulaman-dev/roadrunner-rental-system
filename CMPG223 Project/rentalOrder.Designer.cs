namespace CMPG223_Project
{
    partial class rentalOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            label7 = new Label();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            buttonBack = new Button();
            buttonClear = new Button();
            buttonCreate = new Button();
            label6 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            tabControl1 = new TabControl();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(188, 170, 148);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1001, 464);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Update Orders";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(188, 170, 146);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(buttonBack);
            tabPage1.Controls.Add(buttonClear);
            tabPage1.Controls.Add(buttonCreate);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1001, 464);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create Order";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(262, 179);
            label7.Name = "label7";
            label7.Size = new Size(250, 30);
            label7.TabIndex = 18;
            label7.Text = "Please Select a Valid Date";
            label7.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(266, 102);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(525, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(463, 319);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(415, 399);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(104, 43);
            buttonBack.TabIndex = 15;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(512, 332);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(104, 43);
            buttonClear.TabIndex = 14;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(323, 332);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(104, 43);
            buttonCreate.TabIndex = 13;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 3);
            label6.Name = "label6";
            label6.Size = new Size(289, 40);
            label6.TabIndex = 11;
            label6.Text = "Create Rental Order";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(156, 188);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 179);
            label5.Name = "label5";
            label5.Size = new Size(150, 32);
            label5.TabIndex = 9;
            label5.Text = "Order Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(297, 136);
            label4.Name = "label4";
            label4.Size = new Size(67, 32);
            label4.TabIndex = 8;
            label4.Text = "until";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(0, 135);
            label3.Name = "label3";
            label3.Size = new Size(136, 32);
            label3.TabIndex = 7;
            label3.Text = "Rent from:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(0, 93);
            label2.Name = "label2";
            label2.Size = new Size(254, 32);
            label2.TabIndex = 6;
            label2.Text = "Please Select Vehicle:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(0, 53);
            label1.Name = "label1";
            label1.Size = new Size(240, 32);
            label1.TabIndex = 5;
            label1.Text = "Please Select Client:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(370, 143);
            dateTimePicker2.MinDate = new DateTime(2024, 8, 26, 4, 36, 40, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(149, 23);
            dateTimePicker2.TabIndex = 4;
            dateTimePicker2.Value = new DateTime(2024, 8, 26, 4, 36, 40, 0);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(142, 143);
            dateTimePicker1.MinDate = new DateTime(2024, 8, 26, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(149, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(266, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 23);
            comboBox1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1009, 492);
            tabControl1.TabIndex = 0;
            // 
            // rentalOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1008, 495);
            Controls.Add(tabControl1);
            Name = "rentalOrder";
            Text = "rentalOrder";
            Load += rentalOrder_Load;
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TabPage tabPage1;
        private Button buttonBack;
        private Button buttonClear;
        private Button buttonCreate;
        private Label label6;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private TabControl tabControl1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Label label7;
    }
}