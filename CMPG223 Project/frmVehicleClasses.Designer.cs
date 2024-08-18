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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicleClasses));
            tabControlVehicleClasses = new TabControl();
            tabAdd = new TabPage();
            tabUpdate = new TabPage();
            tabDelete = new TabPage();
            lblClassName_Add = new Label();
            txtClassName_Add = new TextBox();
            lblDescription_Add = new Label();
            txtDescription_Add = new RichTextBox();
            btnBack_Add = new Button();
            btnAdd_Add = new Button();
            btnClear_Add = new Button();
            dgvVehicleClasses_Add = new DataGridView();
            dgvVehicleClasses_Update = new DataGridView();
            btnClear_Update = new Button();
            btnUpdate_Update = new Button();
            btnBack_Update = new Button();
            txtDescription_Update = new RichTextBox();
            label1 = new Label();
            txtClassName_Update = new TextBox();
            label2 = new Label();
            lblClassID_Update = new Label();
            cmbClassID_Update = new ComboBox();
            lblClassID_Delete = new Label();
            cmbClassID_Delete = new ComboBox();
            dgvVehicleClasses_Delete = new DataGridView();
            btnClear_Delete = new Button();
            btnDelete_Delete = new Button();
            btnBack_Delete = new Button();
            tabControlVehicleClasses.SuspendLayout();
            tabAdd.SuspendLayout();
            tabUpdate.SuspendLayout();
            tabDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleClasses_Add).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleClasses_Update).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleClasses_Delete).BeginInit();
            SuspendLayout();
            // 
            // tabControlVehicleClasses
            // 
            tabControlVehicleClasses.Controls.Add(tabAdd);
            tabControlVehicleClasses.Controls.Add(tabUpdate);
            tabControlVehicleClasses.Controls.Add(tabDelete);
            tabControlVehicleClasses.Dock = DockStyle.Fill;
            tabControlVehicleClasses.Location = new Point(0, 0);
            tabControlVehicleClasses.Name = "tabControlVehicleClasses";
            tabControlVehicleClasses.SelectedIndex = 0;
            tabControlVehicleClasses.Size = new Size(960, 606);
            tabControlVehicleClasses.TabIndex = 0;
            // 
            // tabAdd
            // 
            tabAdd.BackgroundImage = (Image)resources.GetObject("tabAdd.BackgroundImage");
            tabAdd.BackgroundImageLayout = ImageLayout.Stretch;
            tabAdd.Controls.Add(dgvVehicleClasses_Add);
            tabAdd.Controls.Add(btnClear_Add);
            tabAdd.Controls.Add(btnAdd_Add);
            tabAdd.Controls.Add(btnBack_Add);
            tabAdd.Controls.Add(txtDescription_Add);
            tabAdd.Controls.Add(lblDescription_Add);
            tabAdd.Controls.Add(txtClassName_Add);
            tabAdd.Controls.Add(lblClassName_Add);
            tabAdd.Location = new Point(4, 29);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new Padding(3);
            tabAdd.Size = new Size(952, 573);
            tabAdd.TabIndex = 0;
            tabAdd.Text = "Add";
            tabAdd.UseVisualStyleBackColor = true;
            // 
            // tabUpdate
            // 
            tabUpdate.BackgroundImage = (Image)resources.GetObject("tabUpdate.BackgroundImage");
            tabUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            tabUpdate.Controls.Add(cmbClassID_Update);
            tabUpdate.Controls.Add(lblClassID_Update);
            tabUpdate.Controls.Add(dgvVehicleClasses_Update);
            tabUpdate.Controls.Add(btnClear_Update);
            tabUpdate.Controls.Add(btnUpdate_Update);
            tabUpdate.Controls.Add(btnBack_Update);
            tabUpdate.Controls.Add(txtDescription_Update);
            tabUpdate.Controls.Add(label1);
            tabUpdate.Controls.Add(txtClassName_Update);
            tabUpdate.Controls.Add(label2);
            tabUpdate.Location = new Point(4, 29);
            tabUpdate.Name = "tabUpdate";
            tabUpdate.Padding = new Padding(3);
            tabUpdate.Size = new Size(952, 573);
            tabUpdate.TabIndex = 1;
            tabUpdate.Text = "Update";
            tabUpdate.UseVisualStyleBackColor = true;
            // 
            // tabDelete
            // 
            tabDelete.BackgroundImage = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            tabDelete.BackgroundImageLayout = ImageLayout.Stretch;
            tabDelete.Controls.Add(btnClear_Delete);
            tabDelete.Controls.Add(btnDelete_Delete);
            tabDelete.Controls.Add(btnBack_Delete);
            tabDelete.Controls.Add(dgvVehicleClasses_Delete);
            tabDelete.Controls.Add(cmbClassID_Delete);
            tabDelete.Controls.Add(lblClassID_Delete);
            tabDelete.Location = new Point(4, 29);
            tabDelete.Name = "tabDelete";
            tabDelete.Size = new Size(952, 573);
            tabDelete.TabIndex = 2;
            tabDelete.Text = "Delete";
            tabDelete.UseVisualStyleBackColor = true;
            // 
            // lblClassName_Add
            // 
            lblClassName_Add.AutoSize = true;
            lblClassName_Add.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassName_Add.Location = new Point(-4, 19);
            lblClassName_Add.Name = "lblClassName_Add";
            lblClassName_Add.Size = new Size(195, 41);
            lblClassName_Add.TabIndex = 0;
            lblClassName_Add.Text = "Class Name: ";
            // 
            // txtClassName_Add
            // 
            txtClassName_Add.Location = new Point(183, 33);
            txtClassName_Add.MaxLength = 15;
            txtClassName_Add.Name = "txtClassName_Add";
            txtClassName_Add.Size = new Size(206, 27);
            txtClassName_Add.TabIndex = 1;
            // 
            // lblDescription_Add
            // 
            lblDescription_Add.AutoSize = true;
            lblDescription_Add.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription_Add.Location = new Point(-4, 73);
            lblDescription_Add.Name = "lblDescription_Add";
            lblDescription_Add.Size = new Size(196, 41);
            lblDescription_Add.TabIndex = 2;
            lblDescription_Add.Text = "Description: ";
            // 
            // txtDescription_Add
            // 
            txtDescription_Add.Location = new Point(183, 87);
            txtDescription_Add.MaxLength = 50;
            txtDescription_Add.Name = "txtDescription_Add";
            txtDescription_Add.Size = new Size(206, 120);
            txtDescription_Add.TabIndex = 3;
            txtDescription_Add.Text = "";
            // 
            // btnBack_Add
            // 
            btnBack_Add.Location = new Point(395, 429);
            btnBack_Add.Name = "btnBack_Add";
            btnBack_Add.Size = new Size(94, 29);
            btnBack_Add.TabIndex = 4;
            btnBack_Add.Text = "Back";
            btnBack_Add.UseVisualStyleBackColor = true;
            // 
            // btnAdd_Add
            // 
            btnAdd_Add.Location = new Point(339, 373);
            btnAdd_Add.Name = "btnAdd_Add";
            btnAdd_Add.Size = new Size(94, 29);
            btnAdd_Add.TabIndex = 5;
            btnAdd_Add.Text = "Add";
            btnAdd_Add.UseVisualStyleBackColor = true;
            // 
            // btnClear_Add
            // 
            btnClear_Add.Location = new Point(451, 373);
            btnClear_Add.Name = "btnClear_Add";
            btnClear_Add.Size = new Size(94, 29);
            btnClear_Add.TabIndex = 6;
            btnClear_Add.Text = "Clear";
            btnClear_Add.UseVisualStyleBackColor = true;
            // 
            // dgvVehicleClasses_Add
            // 
            dgvVehicleClasses_Add.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicleClasses_Add.Location = new Point(452, 19);
            dgvVehicleClasses_Add.Name = "dgvVehicleClasses_Add";
            dgvVehicleClasses_Add.RowHeadersWidth = 51;
            dgvVehicleClasses_Add.Size = new Size(473, 294);
            dgvVehicleClasses_Add.TabIndex = 7;
            // 
            // dgvVehicleClasses_Update
            // 
            dgvVehicleClasses_Update.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicleClasses_Update.Location = new Point(463, 26);
            dgvVehicleClasses_Update.Name = "dgvVehicleClasses_Update";
            dgvVehicleClasses_Update.RowHeadersWidth = 51;
            dgvVehicleClasses_Update.Size = new Size(473, 294);
            dgvVehicleClasses_Update.TabIndex = 15;
            // 
            // btnClear_Update
            // 
            btnClear_Update.Location = new Point(462, 380);
            btnClear_Update.Name = "btnClear_Update";
            btnClear_Update.Size = new Size(94, 29);
            btnClear_Update.TabIndex = 14;
            btnClear_Update.Text = "Clear";
            btnClear_Update.UseVisualStyleBackColor = true;
            // 
            // btnUpdate_Update
            // 
            btnUpdate_Update.Location = new Point(350, 380);
            btnUpdate_Update.Name = "btnUpdate_Update";
            btnUpdate_Update.Size = new Size(94, 29);
            btnUpdate_Update.TabIndex = 13;
            btnUpdate_Update.Text = "Update";
            btnUpdate_Update.UseVisualStyleBackColor = true;
            // 
            // btnBack_Update
            // 
            btnBack_Update.Location = new Point(406, 436);
            btnBack_Update.Name = "btnBack_Update";
            btnBack_Update.Size = new Size(94, 29);
            btnBack_Update.TabIndex = 12;
            btnBack_Update.Text = "Back";
            btnBack_Update.UseVisualStyleBackColor = true;
            // 
            // txtDescription_Update
            // 
            txtDescription_Update.Location = new Point(208, 200);
            txtDescription_Update.MaxLength = 50;
            txtDescription_Update.Name = "txtDescription_Update";
            txtDescription_Update.Size = new Size(206, 120);
            txtDescription_Update.TabIndex = 11;
            txtDescription_Update.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 186);
            label1.Name = "label1";
            label1.Size = new Size(196, 41);
            label1.TabIndex = 10;
            label1.Text = "Description: ";
            // 
            // txtClassName_Update
            // 
            txtClassName_Update.Location = new Point(208, 128);
            txtClassName_Update.MaxLength = 15;
            txtClassName_Update.Name = "txtClassName_Update";
            txtClassName_Update.Size = new Size(206, 27);
            txtClassName_Update.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 114);
            label2.Name = "label2";
            label2.Size = new Size(195, 41);
            label2.TabIndex = 8;
            label2.Text = "Class Name: ";
            // 
            // lblClassID_Update
            // 
            lblClassID_Update.AutoSize = true;
            lblClassID_Update.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassID_Update.Location = new Point(20, 41);
            lblClassID_Update.Name = "lblClassID_Update";
            lblClassID_Update.Size = new Size(144, 41);
            lblClassID_Update.TabIndex = 16;
            lblClassID_Update.Text = "Class ID: ";
            // 
            // cmbClassID_Update
            // 
            cmbClassID_Update.FormattingEnabled = true;
            cmbClassID_Update.Location = new Point(205, 56);
            cmbClassID_Update.Name = "cmbClassID_Update";
            cmbClassID_Update.Size = new Size(209, 28);
            cmbClassID_Update.TabIndex = 17;
            // 
            // lblClassID_Delete
            // 
            lblClassID_Delete.AutoSize = true;
            lblClassID_Delete.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassID_Delete.Location = new Point(308, 344);
            lblClassID_Delete.Name = "lblClassID_Delete";
            lblClassID_Delete.Size = new Size(135, 38);
            lblClassID_Delete.TabIndex = 17;
            lblClassID_Delete.Text = "Class ID: ";
            // 
            // cmbClassID_Delete
            // 
            cmbClassID_Delete.FormattingEnabled = true;
            cmbClassID_Delete.Location = new Point(449, 354);
            cmbClassID_Delete.Name = "cmbClassID_Delete";
            cmbClassID_Delete.Size = new Size(209, 28);
            cmbClassID_Delete.TabIndex = 18;
            // 
            // dgvVehicleClasses_Delete
            // 
            dgvVehicleClasses_Delete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicleClasses_Delete.Location = new Point(237, 30);
            dgvVehicleClasses_Delete.Name = "dgvVehicleClasses_Delete";
            dgvVehicleClasses_Delete.RowHeadersWidth = 51;
            dgvVehicleClasses_Delete.Size = new Size(473, 294);
            dgvVehicleClasses_Delete.TabIndex = 19;
            // 
            // btnClear_Delete
            // 
            btnClear_Delete.Location = new Point(475, 430);
            btnClear_Delete.Name = "btnClear_Delete";
            btnClear_Delete.Size = new Size(94, 29);
            btnClear_Delete.TabIndex = 22;
            btnClear_Delete.Text = "Clear";
            btnClear_Delete.UseVisualStyleBackColor = true;
            // 
            // btnDelete_Delete
            // 
            btnDelete_Delete.Location = new Point(363, 430);
            btnDelete_Delete.Name = "btnDelete_Delete";
            btnDelete_Delete.Size = new Size(94, 29);
            btnDelete_Delete.TabIndex = 21;
            btnDelete_Delete.Text = "Delete";
            btnDelete_Delete.UseVisualStyleBackColor = true;
            // 
            // btnBack_Delete
            // 
            btnBack_Delete.Location = new Point(419, 486);
            btnBack_Delete.Name = "btnBack_Delete";
            btnBack_Delete.Size = new Size(94, 29);
            btnBack_Delete.TabIndex = 20;
            btnBack_Delete.Text = "Back";
            btnBack_Delete.UseVisualStyleBackColor = true;
            // 
            // frmVehicleClasses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 606);
            Controls.Add(tabControlVehicleClasses);
            Name = "frmVehicleClasses";
            Text = "frmVehicleClasses";
            tabControlVehicleClasses.ResumeLayout(false);
            tabAdd.ResumeLayout(false);
            tabAdd.PerformLayout();
            tabUpdate.ResumeLayout(false);
            tabUpdate.PerformLayout();
            tabDelete.ResumeLayout(false);
            tabDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleClasses_Add).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleClasses_Update).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicleClasses_Delete).EndInit();
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
        private ComboBox cmbClassID_Update;
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
        private ComboBox cmbClassID_Delete;
        private Label lblClassID_Delete;
    }
}