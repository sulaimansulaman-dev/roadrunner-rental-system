namespace CMPG223_Project
{
    partial class frmVehicleClasses
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
            components = new System.ComponentModel.Container();
            tabControlVehicleClasses = new TabControl();
            tabAdd = new TabPage();
            txtSearch_Add = new TextBox();
            label8 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            dgvVehicleClasses_Add = new DataGridView();
            btnClear_Add = new Button();
            btnAdd_Add = new Button();
            btnBack_Add = new Button();
            txtDescription_Add = new RichTextBox();
            lblDescription_Add = new Label();
            txtClassName_Add = new TextBox();
            lblClassName_Add = new Label();
            tabUpdate = new TabPage();
            txtSearch_Update = new TextBox();
            label6 = new Label();
            txtClassID_Update = new TextBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            lblClassID_Update = new Label();
            dgvVehicleClasses_Update = new DataGridView();
            btnClear_Update = new Button();
            btnUpdate_Update = new Button();
            btnBack_Update = new Button();
            txtDescription_Update = new RichTextBox();
            label1 = new Label();
            txtClassName_Update = new TextBox();
            label2 = new Label();
            tabDelete = new TabPage();
            txtSearch_Delete = new TextBox();
            label7 = new Label();
            txtClassName_Delete = new TextBox();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            btnClear_Delete = new Button();
            btnDelete_Delete = new Button();
            btnBack_Delete = new Button();
            dgvVehicleClasses_Delete = new DataGridView();
            lblClassID_Delete = new Label();
            errorProvider1 = new ErrorProvider(components);
            tabControlVehicleClasses.SuspendLayout();
            tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleClasses_Add).BeginInit();
            tabUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleClasses_Update).BeginInit();
            tabDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleClasses_Delete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControlVehicleClasses
            // 
            tabControlVehicleClasses.Controls.Add(tabAdd);
            tabControlVehicleClasses.Controls.Add(tabUpdate);
            tabControlVehicleClasses.Controls.Add(tabDelete);
            tabControlVehicleClasses.Dock = DockStyle.Fill;
            tabControlVehicleClasses.Location = new Point(0, 0);
            tabControlVehicleClasses.Margin = new Padding(3, 2, 3, 2);
            tabControlVehicleClasses.Name = "tabControlVehicleClasses";
            tabControlVehicleClasses.SelectedIndex = 0;
            tabControlVehicleClasses.Size = new Size(899, 438);
            tabControlVehicleClasses.TabIndex = 0;
            // 
            // tabAdd
            // 
            tabAdd.BackColor = Color.FromArgb(188, 170, 146);
            tabAdd.BackgroundImageLayout = ImageLayout.Zoom;
            tabAdd.Controls.Add(txtSearch_Add);
            tabAdd.Controls.Add(label8);
            tabAdd.Controls.Add(label3);
            tabAdd.Controls.Add(pictureBox1);
            tabAdd.Controls.Add(dgvVehicleClasses_Add);
            tabAdd.Controls.Add(btnClear_Add);
            tabAdd.Controls.Add(btnAdd_Add);
            tabAdd.Controls.Add(btnBack_Add);
            tabAdd.Controls.Add(txtDescription_Add);
            tabAdd.Controls.Add(lblDescription_Add);
            tabAdd.Controls.Add(txtClassName_Add);
            tabAdd.Controls.Add(lblClassName_Add);
            tabAdd.Location = new Point(4, 24);
            tabAdd.Margin = new Padding(3, 2, 3, 2);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new Padding(3, 2, 3, 2);
            tabAdd.Size = new Size(891, 410);
            tabAdd.TabIndex = 0;
            tabAdd.Text = "Add";
            // 
            // txtSearch_Add
            // 
            txtSearch_Add.Location = new Point(583, 62);
            txtSearch_Add.Margin = new Padding(3, 2, 3, 2);
            txtSearch_Add.MaxLength = 15;
            txtSearch_Add.Name = "txtSearch_Add";
            txtSearch_Add.Size = new Size(181, 23);
            txtSearch_Add.TabIndex = 28;
            txtSearch_Add.TextChanged += txtSearch_Add_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label8.Location = new Point(534, 28);
            label8.Name = "label8";
            label8.Size = new Size(276, 32);
            label8.TabIndex = 22;
            label8.Text = "Search By Class Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 2);
            label3.Name = "label3";
            label3.Size = new Size(273, 37);
            label3.TabIndex = 9;
            label3.Text = "Add Vehicle Classes ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            pictureBox1.Location = new Point(17, 323);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // dgvVehicleClasses_Add
            // 
            dgvVehicleClasses_Add.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicleClasses_Add.Location = new Point(460, 86);
            dgvVehicleClasses_Add.Margin = new Padding(3, 2, 3, 2);
            dgvVehicleClasses_Add.Name = "dgvVehicleClasses_Add";
            dgvVehicleClasses_Add.RowHeadersWidth = 51;
            dgvVehicleClasses_Add.Size = new Size(414, 220);
            dgvVehicleClasses_Add.TabIndex = 7;
            dgvVehicleClasses_Add.CellClick += dgvVehicleClasses_Add_CellClick;
            // 
            // btnClear_Add
            // 
            btnClear_Add.Location = new Point(620, 330);
            btnClear_Add.Margin = new Padding(3, 2, 3, 2);
            btnClear_Add.Name = "btnClear_Add";
            btnClear_Add.Size = new Size(91, 39);
            btnClear_Add.TabIndex = 6;
            btnClear_Add.Text = "Clear";
            btnClear_Add.UseVisualStyleBackColor = true;
            btnClear_Add.Click += btnClear_Add_Click;
            // 
            // btnAdd_Add
            // 
            btnAdd_Add.Location = new Point(460, 330);
            btnAdd_Add.Margin = new Padding(3, 2, 3, 2);
            btnAdd_Add.Name = "btnAdd_Add";
            btnAdd_Add.Size = new Size(91, 39);
            btnAdd_Add.TabIndex = 5;
            btnAdd_Add.Text = "Add";
            btnAdd_Add.UseVisualStyleBackColor = true;
            btnAdd_Add.Click += btnAdd_Add_Click;
            // 
            // btnBack_Add
            // 
            btnBack_Add.Location = new Point(783, 330);
            btnBack_Add.Margin = new Padding(3, 2, 3, 2);
            btnBack_Add.Name = "btnBack_Add";
            btnBack_Add.Size = new Size(91, 39);
            btnBack_Add.TabIndex = 4;
            btnBack_Add.Text = "Back";
            btnBack_Add.UseVisualStyleBackColor = true;
            btnBack_Add.Click += btnBack_Add_Click;
            // 
            // txtDescription_Add
            // 
            txtDescription_Add.Location = new Point(197, 123);
            txtDescription_Add.Margin = new Padding(3, 2, 3, 2);
            txtDescription_Add.MaxLength = 50;
            txtDescription_Add.Name = "txtDescription_Add";
            txtDescription_Add.Size = new Size(181, 91);
            txtDescription_Add.TabIndex = 3;
            txtDescription_Add.Text = "";
            // 
            // lblDescription_Add
            // 
            lblDescription_Add.AutoSize = true;
            lblDescription_Add.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription_Add.Location = new Point(32, 112);
            lblDescription_Add.Name = "lblDescription_Add";
            lblDescription_Add.Size = new Size(160, 32);
            lblDescription_Add.TabIndex = 2;
            lblDescription_Add.Text = "Description: ";
            // 
            // txtClassName_Add
            // 
            txtClassName_Add.Location = new Point(197, 82);
            txtClassName_Add.Margin = new Padding(3, 2, 3, 2);
            txtClassName_Add.MaxLength = 15;
            txtClassName_Add.Name = "txtClassName_Add";
            txtClassName_Add.Size = new Size(181, 23);
            txtClassName_Add.TabIndex = 1;
            // 
            // lblClassName_Add
            // 
            lblClassName_Add.AutoSize = true;
            lblClassName_Add.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassName_Add.Location = new Point(32, 72);
            lblClassName_Add.Name = "lblClassName_Add";
            lblClassName_Add.Size = new Size(159, 32);
            lblClassName_Add.TabIndex = 0;
            lblClassName_Add.Text = "Class Name: ";
            lblClassName_Add.Click += lblClassName_Add_Click;
            // 
            // tabUpdate
            // 
            tabUpdate.BackColor = Color.FromArgb(188, 170, 146);
            tabUpdate.BackgroundImageLayout = ImageLayout.Zoom;
            tabUpdate.Controls.Add(txtSearch_Update);
            tabUpdate.Controls.Add(label6);
            tabUpdate.Controls.Add(txtClassID_Update);
            tabUpdate.Controls.Add(label4);
            tabUpdate.Controls.Add(pictureBox2);
            tabUpdate.Controls.Add(lblClassID_Update);
            tabUpdate.Controls.Add(dgvVehicleClasses_Update);
            tabUpdate.Controls.Add(btnClear_Update);
            tabUpdate.Controls.Add(btnUpdate_Update);
            tabUpdate.Controls.Add(btnBack_Update);
            tabUpdate.Controls.Add(txtDescription_Update);
            tabUpdate.Controls.Add(label1);
            tabUpdate.Controls.Add(txtClassName_Update);
            tabUpdate.Controls.Add(label2);
            tabUpdate.Location = new Point(4, 24);
            tabUpdate.Margin = new Padding(3, 2, 3, 2);
            tabUpdate.Name = "tabUpdate";
            tabUpdate.Padding = new Padding(3, 2, 3, 2);
            tabUpdate.Size = new Size(891, 410);
            tabUpdate.TabIndex = 1;
            tabUpdate.Text = "Update";
            // 
            // txtSearch_Update
            // 
            txtSearch_Update.Location = new Point(550, 64);
            txtSearch_Update.Margin = new Padding(3, 2, 3, 2);
            txtSearch_Update.MaxLength = 15;
            txtSearch_Update.Name = "txtSearch_Update";
            txtSearch_Update.Size = new Size(181, 23);
            txtSearch_Update.TabIndex = 22;
            txtSearch_Update.TextChanged += txtSearch_Update_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label6.Location = new Point(499, 31);
            label6.Name = "label6";
            label6.Size = new Size(276, 32);
            label6.TabIndex = 21;
            label6.Text = "Search By Class Name: ";
            // 
            // txtClassID_Update
            // 
            txtClassID_Update.Enabled = false;
            txtClassID_Update.Location = new Point(190, 78);
            txtClassID_Update.Margin = new Padding(3, 2, 3, 2);
            txtClassID_Update.MaxLength = 15;
            txtClassID_Update.Name = "txtClassID_Update";
            txtClassID_Update.Size = new Size(181, 23);
            txtClassID_Update.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(315, 37);
            label4.TabIndex = 19;
            label4.Text = "Update Vehicle Classes ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            pictureBox2.Location = new Point(15, 327);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // lblClassID_Update
            // 
            lblClassID_Update.AutoSize = true;
            lblClassID_Update.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassID_Update.Location = new Point(26, 68);
            lblClassID_Update.Name = "lblClassID_Update";
            lblClassID_Update.Size = new Size(118, 32);
            lblClassID_Update.TabIndex = 16;
            lblClassID_Update.Text = "Class ID: ";
            // 
            // dgvVehicleClasses_Update
            // 
            dgvVehicleClasses_Update.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicleClasses_Update.Location = new Point(433, 88);
            dgvVehicleClasses_Update.Margin = new Padding(3, 2, 3, 2);
            dgvVehicleClasses_Update.Name = "dgvVehicleClasses_Update";
            dgvVehicleClasses_Update.RowHeadersWidth = 51;
            dgvVehicleClasses_Update.Size = new Size(414, 220);
            dgvVehicleClasses_Update.TabIndex = 15;
            dgvVehicleClasses_Update.CellClick += dgvVehicleClasses_Update_CellClick;
            dgvVehicleClasses_Update.CellContentClick += dgvVehicleClasses_Update_CellContentClick;
            // 
            // btnClear_Update
            // 
            btnClear_Update.Location = new Point(596, 344);
            btnClear_Update.Margin = new Padding(3, 2, 3, 2);
            btnClear_Update.Name = "btnClear_Update";
            btnClear_Update.Size = new Size(91, 39);
            btnClear_Update.TabIndex = 14;
            btnClear_Update.Text = "Clear";
            btnClear_Update.UseVisualStyleBackColor = true;
            btnClear_Update.Click += btnClear_Update_Click;
            // 
            // btnUpdate_Update
            // 
            btnUpdate_Update.Location = new Point(433, 344);
            btnUpdate_Update.Margin = new Padding(3, 2, 3, 2);
            btnUpdate_Update.Name = "btnUpdate_Update";
            btnUpdate_Update.Size = new Size(91, 39);
            btnUpdate_Update.TabIndex = 13;
            btnUpdate_Update.Text = "Update";
            btnUpdate_Update.UseVisualStyleBackColor = true;
            btnUpdate_Update.Click += btnUpdate_Update_Click;
            // 
            // btnBack_Update
            // 
            btnBack_Update.Location = new Point(756, 344);
            btnBack_Update.Margin = new Padding(3, 2, 3, 2);
            btnBack_Update.Name = "btnBack_Update";
            btnBack_Update.Size = new Size(91, 39);
            btnBack_Update.TabIndex = 12;
            btnBack_Update.Text = "Back";
            btnBack_Update.UseVisualStyleBackColor = true;
            btnBack_Update.Click += btnBack_Update_Click;
            // 
            // txtDescription_Update
            // 
            txtDescription_Update.Location = new Point(190, 187);
            txtDescription_Update.Margin = new Padding(3, 2, 3, 2);
            txtDescription_Update.MaxLength = 50;
            txtDescription_Update.Name = "txtDescription_Update";
            txtDescription_Update.Size = new Size(181, 91);
            txtDescription_Update.TabIndex = 11;
            txtDescription_Update.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 177);
            label1.Name = "label1";
            label1.Size = new Size(160, 32);
            label1.TabIndex = 10;
            label1.Text = "Description: ";
            // 
            // txtClassName_Update
            // 
            txtClassName_Update.Location = new Point(190, 133);
            txtClassName_Update.Margin = new Padding(3, 2, 3, 2);
            txtClassName_Update.MaxLength = 15;
            txtClassName_Update.Name = "txtClassName_Update";
            txtClassName_Update.Size = new Size(181, 23);
            txtClassName_Update.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 123);
            label2.Name = "label2";
            label2.Size = new Size(159, 32);
            label2.TabIndex = 8;
            label2.Text = "Class Name: ";
            // 
            // tabDelete
            // 
            tabDelete.BackColor = Color.FromArgb(188, 170, 146);
            tabDelete.BackgroundImageLayout = ImageLayout.Zoom;
            tabDelete.Controls.Add(txtSearch_Delete);
            tabDelete.Controls.Add(label7);
            tabDelete.Controls.Add(txtClassName_Delete);
            tabDelete.Controls.Add(label5);
            tabDelete.Controls.Add(pictureBox3);
            tabDelete.Controls.Add(btnClear_Delete);
            tabDelete.Controls.Add(btnDelete_Delete);
            tabDelete.Controls.Add(btnBack_Delete);
            tabDelete.Controls.Add(dgvVehicleClasses_Delete);
            tabDelete.Controls.Add(lblClassID_Delete);
            tabDelete.Location = new Point(4, 24);
            tabDelete.Margin = new Padding(3, 2, 3, 2);
            tabDelete.Name = "tabDelete";
            tabDelete.Size = new Size(891, 410);
            tabDelete.TabIndex = 2;
            tabDelete.Text = "Delete";
            // 
            // txtSearch_Delete
            // 
            txtSearch_Delete.Location = new Point(324, 71);
            txtSearch_Delete.Margin = new Padding(3, 2, 3, 2);
            txtSearch_Delete.MaxLength = 15;
            txtSearch_Delete.Name = "txtSearch_Delete";
            txtSearch_Delete.Size = new Size(181, 23);
            txtSearch_Delete.TabIndex = 27;
            txtSearch_Delete.TextChanged += txtSearch_Delete_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label7.Location = new Point(269, 34);
            label7.Name = "label7";
            label7.Size = new Size(276, 32);
            label7.TabIndex = 26;
            label7.Text = "Search By Class Name: ";
            // 
            // txtClassName_Delete
            // 
            txtClassName_Delete.Enabled = false;
            txtClassName_Delete.Location = new Point(385, 322);
            txtClassName_Delete.Margin = new Padding(3, 2, 3, 2);
            txtClassName_Delete.MaxLength = 15;
            txtClassName_Delete.Name = "txtClassName_Delete";
            txtClassName_Delete.Size = new Size(181, 23);
            txtClassName_Delete.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(-4, 0);
            label5.Name = "label5";
            label5.Size = new Size(304, 37);
            label5.TabIndex = 24;
            label5.Text = "Delete Vehicle Classes ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            pictureBox3.Location = new Point(17, 322);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(109, 77);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // btnClear_Delete
            // 
            btnClear_Delete.Location = new Point(374, 360);
            btnClear_Delete.Margin = new Padding(3, 2, 3, 2);
            btnClear_Delete.Name = "btnClear_Delete";
            btnClear_Delete.Size = new Size(91, 39);
            btnClear_Delete.TabIndex = 22;
            btnClear_Delete.Text = "Clear";
            btnClear_Delete.UseVisualStyleBackColor = true;
            btnClear_Delete.Click += btnClear_Delete_Click;
            // 
            // btnDelete_Delete
            // 
            btnDelete_Delete.Location = new Point(209, 360);
            btnDelete_Delete.Margin = new Padding(3, 2, 3, 2);
            btnDelete_Delete.Name = "btnDelete_Delete";
            btnDelete_Delete.Size = new Size(91, 39);
            btnDelete_Delete.TabIndex = 21;
            btnDelete_Delete.Text = "Delete";
            btnDelete_Delete.UseVisualStyleBackColor = true;
            btnDelete_Delete.Click += btnDelete_Delete_Click;
            // 
            // btnBack_Delete
            // 
            btnBack_Delete.Location = new Point(532, 360);
            btnBack_Delete.Margin = new Padding(3, 2, 3, 2);
            btnBack_Delete.Name = "btnBack_Delete";
            btnBack_Delete.Size = new Size(91, 39);
            btnBack_Delete.TabIndex = 20;
            btnBack_Delete.Text = "Back";
            btnBack_Delete.UseVisualStyleBackColor = true;
            btnBack_Delete.Click += btnBack_Delete_Click;
            // 
            // dgvVehicleClasses_Delete
            // 
            dgvVehicleClasses_Delete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicleClasses_Delete.Location = new Point(209, 96);
            dgvVehicleClasses_Delete.Margin = new Padding(3, 2, 3, 2);
            dgvVehicleClasses_Delete.Name = "dgvVehicleClasses_Delete";
            dgvVehicleClasses_Delete.RowHeadersWidth = 51;
            dgvVehicleClasses_Delete.Size = new Size(414, 220);
            dgvVehicleClasses_Delete.TabIndex = 19;
            dgvVehicleClasses_Delete.CellClick += dgvVehicleClasses_Delete_CellClick;
            dgvVehicleClasses_Delete.CellContentClick += dgvVehicleClasses_Delete_CellContentClick;
            // 
            // lblClassID_Delete
            // 
            lblClassID_Delete.AutoSize = true;
            lblClassID_Delete.BackColor = Color.Transparent;
            lblClassID_Delete.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassID_Delete.Location = new Point(270, 318);
            lblClassID_Delete.Name = "lblClassID_Delete";
            lblClassID_Delete.Size = new Size(106, 30);
            lblClassID_Delete.TabIndex = 17;
            lblClassID_Delete.Text = "Class ID: ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmVehicleClasses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 438);
            Controls.Add(tabControlVehicleClasses);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmVehicleClasses";
            Text = "frmVehicleClasses";
            Load += frmVehicleClasses_Load;
            tabControlVehicleClasses.ResumeLayout(false);
            tabAdd.ResumeLayout(false);
            tabAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleClasses_Add).EndInit();
            tabUpdate.ResumeLayout(false);
            tabUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleClasses_Update).EndInit();
            tabDelete.ResumeLayout(false);
            tabDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleClasses_Delete).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlVehicleClasses;
        private TabPage tabAdd;
        private TabPage tabUpdate;
        private TabPage tabDelete;
        private Button btnClear_Add;
        private Button btnAdd_Add;
        private Button btnBack_Add;
        private RichTextBox txtDescription_Add;
        private Label lblDescription_Add;
        private TextBox txtClassName_Add;
        private Label lblClassName_Add;
        private DataGridView dgvVehicleClasses_Add;
        private Label lblClassID_Update;
        private DataGridView dgvVehicleClasses_Update;
        private Button btnClear_Update;
        private Button btnUpdate_Update;
        private Button btnBack_Update;
        private RichTextBox txtDescription_Update;
        private Label label1;
        private TextBox txtClassName_Update;
        private Label label2;
        private Button btnClear_Delete;
        private Button btnDelete_Delete;
        private Button btnBack_Delete;
        private DataGridView dgvVehicleClasses_Delete;
        private Label lblClassID_Delete;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label5;
        private PictureBox pictureBox3;
        private ErrorProvider errorProvider1;
        private TextBox txtClassID_Update;
        private TextBox txtClassName_Delete;
        private Label label6;
        private TextBox txtSearch_Update;
        private Label label7;
        private TextBox txtSearch_Delete;
        private TextBox txtSearch_Add;
        private Label label8;
    }
}