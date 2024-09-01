namespace CMPG223_Project
{
    partial class frmVehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicles));
            tabControlVehicleClasses = new TabControl();
            tabAdd = new TabPage();
            txtCostPerDay = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            lblLicenseNo = new Label();
            lblCostPerDay = new Label();
            txtLicenseNo = new TextBox();
            cmbNoOfSeats = new ComboBox();
            lblNoSeats = new Label();
            cmbClassSelect = new ComboBox();
            dgvVehicles_Add = new DataGridView();
            btnClear_Add = new Button();
            btnAdd_Add = new Button();
            btnBack_Add = new Button();
            lblClassSelect = new Label();
            tabUpdate = new TabPage();
            txtVehicleID_Update = new TextBox();
            txtCostPerDay_Update = new TextBox();
            txtVehicleName_Update = new TextBox();
            label1 = new Label();
            cmbClass_Update = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label8 = new Label();
            txtLicenseNo_Update = new TextBox();
            cmbNoOfSeats_Update = new ComboBox();
            label9 = new Label();
            lblVehicle = new Label();
            dgvVehicles_Update = new DataGridView();
            btnClear_Update = new Button();
            btnUpdate_Update = new Button();
            btnBack_Update = new Button();
            tabDelete = new TabPage();
            cmbVehicleID_Delete = new ComboBox();
            btnClear_Delete = new Button();
            btnDelete_Delete = new Button();
            btnBack_Delete = new Button();
            dgvVehicles_Delete = new DataGridView();
            lblClassID_Delete = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            tabControlVehicleClasses.SuspendLayout();
            tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles_Add).BeginInit();
            tabUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles_Update).BeginInit();
            tabDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles_Delete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
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
            tabControlVehicleClasses.Size = new Size(964, 571);
            tabControlVehicleClasses.TabIndex = 1;
            // 
            // tabAdd
            // 
            tabAdd.BackColor = Color.FromArgb(188, 170, 146);
            tabAdd.BackgroundImage = (Image)resources.GetObject("tabAdd.BackgroundImage");
            tabAdd.BackgroundImageLayout = ImageLayout.Zoom;
            tabAdd.Controls.Add(txtCostPerDay);
            tabAdd.Controls.Add(txtName);
            tabAdd.Controls.Add(label5);
            tabAdd.Controls.Add(lblLicenseNo);
            tabAdd.Controls.Add(lblCostPerDay);
            tabAdd.Controls.Add(txtLicenseNo);
            tabAdd.Controls.Add(cmbNoOfSeats);
            tabAdd.Controls.Add(lblNoSeats);
            tabAdd.Controls.Add(cmbClassSelect);
            tabAdd.Controls.Add(dgvVehicles_Add);
            tabAdd.Controls.Add(btnClear_Add);
            tabAdd.Controls.Add(btnAdd_Add);
            tabAdd.Controls.Add(btnBack_Add);
            tabAdd.Controls.Add(lblClassSelect);
            tabAdd.Location = new Point(4, 24);
            tabAdd.Margin = new Padding(3, 2, 3, 2);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new Padding(3, 2, 3, 2);
            tabAdd.Size = new Size(956, 543);
            tabAdd.TabIndex = 0;
            tabAdd.Text = "Add";
            // 
            // txtCostPerDay
            // 
            txtCostPerDay.Location = new Point(318, 140);
            txtCostPerDay.Margin = new Padding(3, 2, 3, 2);
            txtCostPerDay.Name = "txtCostPerDay";
            txtCostPerDay.Size = new Size(110, 23);
            txtCostPerDay.TabIndex = 24;
            // 
            // txtName
            // 
            txtName.Location = new Point(318, 19);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 23);
            txtName.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(7, 4);
            label5.Name = "label5";
            label5.Size = new Size(182, 32);
            label5.TabIndex = 22;
            label5.Text = "Vehicle Name: ";
            // 
            // lblLicenseNo
            // 
            lblLicenseNo.AutoSize = true;
            lblLicenseNo.BackColor = Color.Transparent;
            lblLicenseNo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicenseNo.Location = new Point(7, 179);
            lblLicenseNo.Name = "lblLicenseNo";
            lblLicenseNo.Size = new Size(225, 32);
            lblLicenseNo.TabIndex = 17;
            lblLicenseNo.Text = "Licencse Number: ";
            // 
            // lblCostPerDay
            // 
            lblCostPerDay.AutoSize = true;
            lblCostPerDay.BackColor = Color.Transparent;
            lblCostPerDay.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCostPerDay.Location = new Point(7, 134);
            lblCostPerDay.Name = "lblCostPerDay";
            lblCostPerDay.Size = new Size(173, 32);
            lblCostPerDay.TabIndex = 14;
            lblCostPerDay.Text = "Cost Per Day: ";
            // 
            // txtLicenseNo
            // 
            txtLicenseNo.Location = new Point(318, 185);
            txtLicenseNo.Margin = new Padding(3, 2, 3, 2);
            txtLicenseNo.Name = "txtLicenseNo";
            txtLicenseNo.Size = new Size(110, 23);
            txtLicenseNo.TabIndex = 13;
            // 
            // cmbNoOfSeats
            // 
            cmbNoOfSeats.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNoOfSeats.FormattingEnabled = true;
            cmbNoOfSeats.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" });
            cmbNoOfSeats.Location = new Point(318, 98);
            cmbNoOfSeats.Margin = new Padding(3, 2, 3, 2);
            cmbNoOfSeats.Name = "cmbNoOfSeats";
            cmbNoOfSeats.Size = new Size(110, 23);
            cmbNoOfSeats.TabIndex = 12;
            // 
            // lblNoSeats
            // 
            lblNoSeats.AutoSize = true;
            lblNoSeats.BackColor = Color.Transparent;
            lblNoSeats.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoSeats.Location = new Point(7, 87);
            lblNoSeats.Name = "lblNoSeats";
            lblNoSeats.Size = new Size(222, 32);
            lblNoSeats.TabIndex = 11;
            lblNoSeats.Text = "Number Of Seats: ";
            // 
            // cmbClassSelect
            // 
            cmbClassSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClassSelect.FormattingEnabled = true;
            cmbClassSelect.Location = new Point(318, 56);
            cmbClassSelect.Margin = new Padding(3, 2, 3, 2);
            cmbClassSelect.Name = "cmbClassSelect";
            cmbClassSelect.Size = new Size(108, 23);
            cmbClassSelect.TabIndex = 8;
            cmbClassSelect.SelectedIndexChanged += cmbClassSelect_SelectedIndexChanged;
            // 
            // dgvVehicles_Add
            // 
            dgvVehicles_Add.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles_Add.Location = new Point(459, 14);
            dgvVehicles_Add.Margin = new Padding(3, 2, 3, 2);
            dgvVehicles_Add.Name = "dgvVehicles_Add";
            dgvVehicles_Add.RowHeadersWidth = 51;
            dgvVehicles_Add.Size = new Size(414, 220);
            dgvVehicles_Add.TabIndex = 7;
            // 
            // btnClear_Add
            // 
            btnClear_Add.Location = new Point(468, 408);
            btnClear_Add.Margin = new Padding(3, 2, 3, 2);
            btnClear_Add.Name = "btnClear_Add";
            btnClear_Add.Size = new Size(178, 51);
            btnClear_Add.TabIndex = 6;
            btnClear_Add.Text = "Clear";
            btnClear_Add.UseVisualStyleBackColor = true;
            btnClear_Add.Click += btnClear_Add_Click;
            // 
            // btnAdd_Add
            // 
            btnAdd_Add.Location = new Point(258, 408);
            btnAdd_Add.Margin = new Padding(3, 2, 3, 2);
            btnAdd_Add.Name = "btnAdd_Add";
            btnAdd_Add.Size = new Size(178, 51);
            btnAdd_Add.TabIndex = 5;
            btnAdd_Add.Text = "Add";
            btnAdd_Add.UseVisualStyleBackColor = true;
            btnAdd_Add.Click += btnAdd_Add_Click;
            // 
            // btnBack_Add
            // 
            btnBack_Add.Location = new Point(356, 475);
            btnBack_Add.Margin = new Padding(3, 2, 3, 2);
            btnBack_Add.Name = "btnBack_Add";
            btnBack_Add.Size = new Size(178, 51);
            btnBack_Add.TabIndex = 4;
            btnBack_Add.Text = "Back";
            btnBack_Add.UseVisualStyleBackColor = true;
            btnBack_Add.Click += btnBack_Add_Click;
            // 
            // lblClassSelect
            // 
            lblClassSelect.AutoSize = true;
            lblClassSelect.BackColor = Color.Transparent;
            lblClassSelect.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassSelect.Location = new Point(5, 46);
            lblClassSelect.Name = "lblClassSelect";
            lblClassSelect.Size = new Size(85, 32);
            lblClassSelect.TabIndex = 0;
            lblClassSelect.Text = "Class: ";
            // 
            // tabUpdate
            // 
            tabUpdate.BackColor = Color.FromArgb(188, 170, 146);
            tabUpdate.BackgroundImage = (Image)resources.GetObject("tabUpdate.BackgroundImage");
            tabUpdate.BackgroundImageLayout = ImageLayout.Zoom;
            tabUpdate.Controls.Add(txtVehicleID_Update);
            tabUpdate.Controls.Add(txtCostPerDay_Update);
            tabUpdate.Controls.Add(txtVehicleName_Update);
            tabUpdate.Controls.Add(label1);
            tabUpdate.Controls.Add(cmbClass_Update);
            tabUpdate.Controls.Add(label3);
            tabUpdate.Controls.Add(label2);
            tabUpdate.Controls.Add(label8);
            tabUpdate.Controls.Add(txtLicenseNo_Update);
            tabUpdate.Controls.Add(cmbNoOfSeats_Update);
            tabUpdate.Controls.Add(label9);
            tabUpdate.Controls.Add(lblVehicle);
            tabUpdate.Controls.Add(dgvVehicles_Update);
            tabUpdate.Controls.Add(btnClear_Update);
            tabUpdate.Controls.Add(btnUpdate_Update);
            tabUpdate.Controls.Add(btnBack_Update);
            tabUpdate.Location = new Point(4, 24);
            tabUpdate.Margin = new Padding(3, 2, 3, 2);
            tabUpdate.Name = "tabUpdate";
            tabUpdate.Padding = new Padding(3, 2, 3, 2);
            tabUpdate.Size = new Size(956, 543);
            tabUpdate.TabIndex = 1;
            tabUpdate.Text = "Update";
            // 
            // txtVehicleID_Update
            // 
            txtVehicleID_Update.Enabled = false;
            txtVehicleID_Update.Location = new Point(334, 24);
            txtVehicleID_Update.Margin = new Padding(3, 2, 3, 2);
            txtVehicleID_Update.Name = "txtVehicleID_Update";
            txtVehicleID_Update.Size = new Size(110, 23);
            txtVehicleID_Update.TabIndex = 36;
            // 
            // txtCostPerDay_Update
            // 
            txtCostPerDay_Update.Location = new Point(334, 192);
            txtCostPerDay_Update.Margin = new Padding(3, 2, 3, 2);
            txtCostPerDay_Update.Name = "txtCostPerDay_Update";
            txtCostPerDay_Update.Size = new Size(110, 23);
            txtCostPerDay_Update.TabIndex = 35;
            // 
            // txtVehicleName_Update
            // 
            txtVehicleName_Update.Location = new Point(334, 66);
            txtVehicleName_Update.Margin = new Padding(3, 2, 3, 2);
            txtVehicleName_Update.Name = "txtVehicleName_Update";
            txtVehicleName_Update.Size = new Size(110, 23);
            txtVehicleName_Update.TabIndex = 34;
            txtVehicleName_Update.Validating += txtVehicleName_Update_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 51);
            label1.Name = "label1";
            label1.Size = new Size(182, 32);
            label1.TabIndex = 33;
            label1.Text = "Vehicle Name: ";
            // 
            // cmbClass_Update
            // 
            cmbClass_Update.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClass_Update.FormattingEnabled = true;
            cmbClass_Update.Location = new Point(334, 100);
            cmbClass_Update.Margin = new Padding(3, 2, 3, 2);
            cmbClass_Update.Name = "cmbClass_Update";
            cmbClass_Update.Size = new Size(110, 23);
            cmbClass_Update.TabIndex = 32;
            cmbClass_Update.Validating += cmbClass_Update_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 90);
            label3.Name = "label3";
            label3.Size = new Size(85, 32);
            label3.TabIndex = 31;
            label3.Text = "Class: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 226);
            label2.Name = "label2";
            label2.Size = new Size(225, 32);
            label2.TabIndex = 27;
            label2.Text = "Licencse Number: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(23, 182);
            label8.Name = "label8";
            label8.Size = new Size(173, 32);
            label8.TabIndex = 25;
            label8.Text = "Cost Per Day: ";
            // 
            // txtLicenseNo_Update
            // 
            txtLicenseNo_Update.Location = new Point(334, 232);
            txtLicenseNo_Update.Margin = new Padding(3, 2, 3, 2);
            txtLicenseNo_Update.Name = "txtLicenseNo_Update";
            txtLicenseNo_Update.Size = new Size(110, 23);
            txtLicenseNo_Update.TabIndex = 24;
            // 
            // cmbNoOfSeats_Update
            // 
            cmbNoOfSeats_Update.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNoOfSeats_Update.FormattingEnabled = true;
            cmbNoOfSeats_Update.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" });
            cmbNoOfSeats_Update.Location = new Point(334, 146);
            cmbNoOfSeats_Update.Margin = new Padding(3, 2, 3, 2);
            cmbNoOfSeats_Update.Name = "cmbNoOfSeats_Update";
            cmbNoOfSeats_Update.Size = new Size(110, 23);
            cmbNoOfSeats_Update.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(23, 134);
            label9.Name = "label9";
            label9.Size = new Size(222, 32);
            label9.TabIndex = 22;
            label9.Text = "Number Of Seats: ";
            // 
            // lblVehicle
            // 
            lblVehicle.AutoSize = true;
            lblVehicle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehicle.Location = new Point(23, 14);
            lblVehicle.Name = "lblVehicle";
            lblVehicle.Size = new Size(141, 32);
            lblVehicle.TabIndex = 16;
            lblVehicle.Text = "Vehicle ID: ";
            // 
            // dgvVehicles_Update
            // 
            dgvVehicles_Update.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles_Update.Location = new Point(496, 24);
            dgvVehicles_Update.Margin = new Padding(3, 2, 3, 2);
            dgvVehicles_Update.Name = "dgvVehicles_Update";
            dgvVehicles_Update.RowHeadersWidth = 51;
            dgvVehicles_Update.Size = new Size(414, 220);
            dgvVehicles_Update.TabIndex = 15;
            dgvVehicles_Update.CellClick += dgvVehicles_Update_CellClick;
            // 
            // btnClear_Update
            // 
            btnClear_Update.Location = new Point(474, 420);
            btnClear_Update.Margin = new Padding(3, 2, 3, 2);
            btnClear_Update.Name = "btnClear_Update";
            btnClear_Update.Size = new Size(178, 51);
            btnClear_Update.TabIndex = 14;
            btnClear_Update.Text = "Clear";
            btnClear_Update.UseVisualStyleBackColor = true;
            // 
            // btnUpdate_Update
            // 
            btnUpdate_Update.Location = new Point(261, 420);
            btnUpdate_Update.Margin = new Padding(3, 2, 3, 2);
            btnUpdate_Update.Name = "btnUpdate_Update";
            btnUpdate_Update.Size = new Size(178, 51);
            btnUpdate_Update.TabIndex = 13;
            btnUpdate_Update.Text = "Update";
            btnUpdate_Update.UseVisualStyleBackColor = true;
            btnUpdate_Update.Click += btnUpdate_Update_Click;
            // 
            // btnBack_Update
            // 
            btnBack_Update.Location = new Point(353, 487);
            btnBack_Update.Margin = new Padding(3, 2, 3, 2);
            btnBack_Update.Name = "btnBack_Update";
            btnBack_Update.Size = new Size(178, 51);
            btnBack_Update.TabIndex = 12;
            btnBack_Update.Text = "Back";
            btnBack_Update.UseVisualStyleBackColor = true;
            btnBack_Update.Click += btnBack_Update_Click;
            // 
            // tabDelete
            // 
            tabDelete.BackColor = Color.FromArgb(188, 170, 146);
            tabDelete.BackgroundImage = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            tabDelete.BackgroundImageLayout = ImageLayout.Zoom;
            tabDelete.Controls.Add(cmbVehicleID_Delete);
            tabDelete.Controls.Add(btnClear_Delete);
            tabDelete.Controls.Add(btnDelete_Delete);
            tabDelete.Controls.Add(btnBack_Delete);
            tabDelete.Controls.Add(dgvVehicles_Delete);
            tabDelete.Controls.Add(lblClassID_Delete);
            tabDelete.Location = new Point(4, 24);
            tabDelete.Margin = new Padding(3, 2, 3, 2);
            tabDelete.Name = "tabDelete";
            tabDelete.Size = new Size(956, 543);
            tabDelete.TabIndex = 2;
            tabDelete.Text = "Delete";
            // 
            // cmbVehicleID_Delete
            // 
            cmbVehicleID_Delete.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicleID_Delete.FormattingEnabled = true;
            cmbVehicleID_Delete.Location = new Point(443, 361);
            cmbVehicleID_Delete.Margin = new Padding(3, 2, 3, 2);
            cmbVehicleID_Delete.Name = "cmbVehicleID_Delete";
            cmbVehicleID_Delete.Size = new Size(108, 23);
            cmbVehicleID_Delete.TabIndex = 23;
            // 
            // btnClear_Delete
            // 
            btnClear_Delete.Location = new Point(459, 411);
            btnClear_Delete.Margin = new Padding(3, 2, 3, 2);
            btnClear_Delete.Name = "btnClear_Delete";
            btnClear_Delete.Size = new Size(178, 51);
            btnClear_Delete.TabIndex = 22;
            btnClear_Delete.Text = "Clear";
            btnClear_Delete.UseVisualStyleBackColor = true;
            // 
            // btnDelete_Delete
            // 
            btnDelete_Delete.Location = new Point(260, 411);
            btnDelete_Delete.Margin = new Padding(3, 2, 3, 2);
            btnDelete_Delete.Name = "btnDelete_Delete";
            btnDelete_Delete.Size = new Size(178, 51);
            btnDelete_Delete.TabIndex = 21;
            btnDelete_Delete.Text = "Delete";
            btnDelete_Delete.UseVisualStyleBackColor = true;
            btnDelete_Delete.Click += btnDelete_Delete_Click;
            // 
            // btnBack_Delete
            // 
            btnBack_Delete.Location = new Point(354, 476);
            btnBack_Delete.Margin = new Padding(3, 2, 3, 2);
            btnBack_Delete.Name = "btnBack_Delete";
            btnBack_Delete.Size = new Size(178, 51);
            btnBack_Delete.TabIndex = 20;
            btnBack_Delete.Text = "Back";
            btnBack_Delete.UseVisualStyleBackColor = true;
            btnBack_Delete.Click += btnBack_Delete_Click;
            // 
            // dgvVehicles_Delete
            // 
            dgvVehicles_Delete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles_Delete.Location = new Point(219, 28);
            dgvVehicles_Delete.Margin = new Padding(3, 2, 3, 2);
            dgvVehicles_Delete.Name = "dgvVehicles_Delete";
            dgvVehicles_Delete.RowHeadersWidth = 51;
            dgvVehicles_Delete.Size = new Size(463, 272);
            dgvVehicles_Delete.TabIndex = 19;
            dgvVehicles_Delete.CellClick += dgvVehicles_Delete_CellClick;
            // 
            // lblClassID_Delete
            // 
            lblClassID_Delete.AutoSize = true;
            lblClassID_Delete.BackColor = Color.Transparent;
            lblClassID_Delete.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassID_Delete.Location = new Point(252, 352);
            lblClassID_Delete.Name = "lblClassID_Delete";
            lblClassID_Delete.Size = new Size(166, 30);
            lblClassID_Delete.TabIndex = 17;
            lblClassID_Delete.Text = "Vehicle Name: ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // frmVehicles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(964, 571);
            Controls.Add(tabControlVehicleClasses);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmVehicles";
            Text = "Vehicles";
            FormClosed += frmVehicles_FormClosed;
            Load += frmVehicles_Load;
            tabControlVehicleClasses.ResumeLayout(false);
            tabAdd.ResumeLayout(false);
            tabAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles_Add).EndInit();
            tabUpdate.ResumeLayout(false);
            tabUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles_Update).EndInit();
            tabDelete.ResumeLayout(false);
            tabDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles_Delete).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlVehicleClasses;
        private TabPage tabAdd;
        private DataGridView dgvVehicles_Add;
        private Button btnClear_Add;
        private Button btnAdd_Add;
        private Button btnBack_Add;
        private Label lblClassSelect;
        private TabPage tabUpdate;
        private Label lblVehicle;
        private DataGridView dgvVehicles_Update;
        private Button btnClear_Update;
        private Button btnUpdate_Update;
        private Button btnBack_Update;
        private TabPage tabDelete;
        private Button btnClear_Delete;
        private Button btnDelete_Delete;
        private Button btnBack_Delete;
        private DataGridView dgvVehicles_Delete;
        private Label lblClassID_Delete;
        private ComboBox cmbClassSelect;
        private Label lblNoSeats;
        private Label lblCostPerDay;
        private TextBox txtLicenseNo;
        private Label lblLicenseNo;
        private Label label2;
        private Label label8;
        private TextBox txtLicenseNo_Update;
        private ComboBox cmbNoOfSeats_Update;
        private Label label9;
        private ComboBox cmbClass_Update;
        private Label label3;
        private TextBox txtCostPerDay;
        private TextBox txtName;
        private Label label5;
        private ComboBox cmbNoOfSeats;
        private TextBox txtCostPerDay_Update;
        private TextBox txtVehicleName_Update;
        private Label label1;
        private ErrorProvider errorProvider1;
        private TextBox txtVehicleID_Update;
        private ComboBox cmbVehicleID_Delete;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
    }
}