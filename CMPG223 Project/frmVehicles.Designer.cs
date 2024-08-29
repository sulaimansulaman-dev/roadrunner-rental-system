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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicles));
            tabControlVehicleClasses = new TabControl();
            tabAdd = new TabPage();
            txtYear = new TextBox();
            lblLicenseNo = new Label();
            lblCostPerDay = new Label();
            txtLicenseNo = new TextBox();
            lblNoSeats = new Label();
            lblYear = new Label();
            cmbClassSelect = new ComboBox();
            dgvVehicles_Add = new DataGridView();
            btnClear_Add = new Button();
            btnAdd_Add = new Button();
            btnBack_Add = new Button();
            lblClassSelect = new Label();
            tabUpdate = new TabPage();
            cmbClass_Update = new ComboBox();
            label3 = new Label();
            pbxImage_Update = new PictureBox();
            txtYear_Update = new TextBox();
            label1 = new Label();
            label2 = new Label();
            hsbCostPerDay_Update = new HScrollBar();
            label8 = new Label();
            txtLicenseNo_Update = new TextBox();
            cmbNoOfSeats_Update = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            cmbVehicleID_Update = new ComboBox();
            lblVehicle = new Label();
            dgvVehicles_Update = new DataGridView();
            btnClear_Update = new Button();
            btnUpdate_Update = new Button();
            btnBack_Update = new Button();
            tabDelete = new TabPage();
            btnClear_Delete = new Button();
            btnDelete_Delete = new Button();
            btnBack_Delete = new Button();
            dgvVehicles_Delete = new DataGridView();
            cmbVehicleID_Delete = new ComboBox();
            lblClassID_Delete = new Label();
            txtName = new TextBox();
            label5 = new Label();
            txtCostPerDay = new TextBox();
            cmbNoOfSeats = new ComboBox();
            tabControlVehicleClasses.SuspendLayout();
            tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles_Add).BeginInit();
            tabUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxImage_Update).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles_Update).BeginInit();
            tabDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles_Delete).BeginInit();
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
            tabControlVehicleClasses.Size = new Size(1102, 761);
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
            tabAdd.Controls.Add(txtYear);
            tabAdd.Controls.Add(lblLicenseNo);
            tabAdd.Controls.Add(lblCostPerDay);
            tabAdd.Controls.Add(txtLicenseNo);
            tabAdd.Controls.Add(cmbNoOfSeats);
            tabAdd.Controls.Add(lblNoSeats);
            tabAdd.Controls.Add(lblYear);
            tabAdd.Controls.Add(cmbClassSelect);
            tabAdd.Controls.Add(dgvVehicles_Add);
            tabAdd.Controls.Add(btnClear_Add);
            tabAdd.Controls.Add(btnAdd_Add);
            tabAdd.Controls.Add(btnBack_Add);
            tabAdd.Controls.Add(lblClassSelect);
            tabAdd.Location = new Point(4, 29);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new Padding(3);
            tabAdd.Size = new Size(1094, 728);
            tabAdd.TabIndex = 0;
            tabAdd.Text = "Add";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(362, 138);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 19;
            // 
            // lblLicenseNo
            // 
            lblLicenseNo.AutoSize = true;
            lblLicenseNo.BackColor = Color.Transparent;
            lblLicenseNo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicenseNo.Location = new Point(6, 300);
            lblLicenseNo.Name = "lblLicenseNo";
            lblLicenseNo.Size = new Size(274, 41);
            lblLicenseNo.TabIndex = 17;
            lblLicenseNo.Text = "Licencse Number: ";
            // 
            // lblCostPerDay
            // 
            lblCostPerDay.AutoSize = true;
            lblCostPerDay.BackColor = Color.Transparent;
            lblCostPerDay.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCostPerDay.Location = new Point(6, 240);
            lblCostPerDay.Name = "lblCostPerDay";
            lblCostPerDay.Size = new Size(211, 41);
            lblCostPerDay.TabIndex = 14;
            lblCostPerDay.Text = "Cost Per Day: ";
            // 
            // txtLicenseNo
            // 
            txtLicenseNo.Location = new Point(362, 308);
            txtLicenseNo.Name = "txtLicenseNo";
            txtLicenseNo.Size = new Size(125, 27);
            txtLicenseNo.TabIndex = 13;
            // 
            // lblNoSeats
            // 
            lblNoSeats.AutoSize = true;
            lblNoSeats.BackColor = Color.Transparent;
            lblNoSeats.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoSeats.Location = new Point(6, 177);
            lblNoSeats.Name = "lblNoSeats";
            lblNoSeats.Size = new Size(275, 41);
            lblNoSeats.TabIndex = 11;
            lblNoSeats.Text = "Number Of Seats: ";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.BackColor = Color.Transparent;
            lblYear.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYear.Location = new Point(6, 118);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(94, 41);
            lblYear.TabIndex = 9;
            lblYear.Text = "Year: ";
            // 
            // cmbClassSelect
            // 
            cmbClassSelect.FormattingEnabled = true;
            cmbClassSelect.Location = new Point(364, 74);
            cmbClassSelect.Name = "cmbClassSelect";
            cmbClassSelect.Size = new Size(123, 28);
            cmbClassSelect.TabIndex = 8;
            cmbClassSelect.SelectedIndexChanged += cmbClassSelect_SelectedIndexChanged;
            // 
            // dgvVehicles_Add
            // 
            dgvVehicles_Add.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles_Add.Location = new Point(525, 18);
            dgvVehicles_Add.Name = "dgvVehicles_Add";
            dgvVehicles_Add.RowHeadersWidth = 51;
            dgvVehicles_Add.Size = new Size(473, 293);
            dgvVehicles_Add.TabIndex = 7;
            // 
            // btnClear_Add
            // 
            btnClear_Add.Location = new Point(535, 544);
            btnClear_Add.Name = "btnClear_Add";
            btnClear_Add.Size = new Size(203, 68);
            btnClear_Add.TabIndex = 6;
            btnClear_Add.Text = "Clear";
            btnClear_Add.UseVisualStyleBackColor = true;
            btnClear_Add.Click += btnClear_Add_Click;
            // 
            // btnAdd_Add
            // 
            btnAdd_Add.Location = new Point(295, 544);
            btnAdd_Add.Name = "btnAdd_Add";
            btnAdd_Add.Size = new Size(203, 68);
            btnAdd_Add.TabIndex = 5;
            btnAdd_Add.Text = "Add";
            btnAdd_Add.UseVisualStyleBackColor = true;
            btnAdd_Add.Click += btnAdd_Add_Click;
            // 
            // btnBack_Add
            // 
            btnBack_Add.Location = new Point(407, 633);
            btnBack_Add.Name = "btnBack_Add";
            btnBack_Add.Size = new Size(203, 68);
            btnBack_Add.TabIndex = 4;
            btnBack_Add.Text = "Back";
            btnBack_Add.UseVisualStyleBackColor = true;
            // 
            // lblClassSelect
            // 
            lblClassSelect.AutoSize = true;
            lblClassSelect.BackColor = Color.Transparent;
            lblClassSelect.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassSelect.Location = new Point(6, 61);
            lblClassSelect.Name = "lblClassSelect";
            lblClassSelect.Size = new Size(104, 41);
            lblClassSelect.TabIndex = 0;
            lblClassSelect.Text = "Class: ";
            // 
            // tabUpdate
            // 
            tabUpdate.BackColor = Color.FromArgb(188, 170, 146);
            tabUpdate.BackgroundImage = (Image)resources.GetObject("tabUpdate.BackgroundImage");
            tabUpdate.BackgroundImageLayout = ImageLayout.Zoom;
            tabUpdate.Controls.Add(cmbClass_Update);
            tabUpdate.Controls.Add(label3);
            tabUpdate.Controls.Add(pbxImage_Update);
            tabUpdate.Controls.Add(txtYear_Update);
            tabUpdate.Controls.Add(label1);
            tabUpdate.Controls.Add(label2);
            tabUpdate.Controls.Add(hsbCostPerDay_Update);
            tabUpdate.Controls.Add(label8);
            tabUpdate.Controls.Add(txtLicenseNo_Update);
            tabUpdate.Controls.Add(cmbNoOfSeats_Update);
            tabUpdate.Controls.Add(label9);
            tabUpdate.Controls.Add(label10);
            tabUpdate.Controls.Add(cmbVehicleID_Update);
            tabUpdate.Controls.Add(lblVehicle);
            tabUpdate.Controls.Add(dgvVehicles_Update);
            tabUpdate.Controls.Add(btnClear_Update);
            tabUpdate.Controls.Add(btnUpdate_Update);
            tabUpdate.Controls.Add(btnBack_Update);
            tabUpdate.Location = new Point(4, 29);
            tabUpdate.Name = "tabUpdate";
            tabUpdate.Padding = new Padding(3);
            tabUpdate.Size = new Size(1094, 728);
            tabUpdate.TabIndex = 1;
            tabUpdate.Text = "Update";
            // 
            // cmbClass_Update
            // 
            cmbClass_Update.FormattingEnabled = true;
            cmbClass_Update.Location = new Point(298, 86);
            cmbClass_Update.Name = "cmbClass_Update";
            cmbClass_Update.Size = new Size(209, 28);
            cmbClass_Update.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 72);
            label3.Name = "label3";
            label3.Size = new Size(104, 41);
            label3.TabIndex = 31;
            label3.Text = "Class: ";
            // 
            // pbxImage_Update
            // 
            pbxImage_Update.Location = new Point(338, 359);
            pbxImage_Update.Name = "pbxImage_Update";
            pbxImage_Update.Size = new Size(169, 148);
            pbxImage_Update.TabIndex = 30;
            pbxImage_Update.TabStop = false;
            // 
            // txtYear_Update
            // 
            txtYear_Update.Location = new Point(382, 144);
            txtYear_Update.Name = "txtYear_Update";
            txtYear_Update.Size = new Size(125, 27);
            txtYear_Update.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 359);
            label1.Name = "label1";
            label1.Size = new Size(230, 41);
            label1.TabIndex = 28;
            label1.Text = "Add an image: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 306);
            label2.Name = "label2";
            label2.Size = new Size(274, 41);
            label2.TabIndex = 27;
            label2.Text = "Licencse Number: ";
            // 
            // hsbCostPerDay_Update
            // 
            hsbCostPerDay_Update.Location = new Point(346, 263);
            hsbCostPerDay_Update.Maximum = 10000;
            hsbCostPerDay_Update.Name = "hsbCostPerDay_Update";
            hsbCostPerDay_Update.Size = new Size(161, 26);
            hsbCostPerDay_Update.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(26, 246);
            label8.Name = "label8";
            label8.Size = new Size(211, 41);
            label8.TabIndex = 25;
            label8.Text = "Cost Per Day: ";
            // 
            // txtLicenseNo_Update
            // 
            txtLicenseNo_Update.Location = new Point(382, 314);
            txtLicenseNo_Update.Name = "txtLicenseNo_Update";
            txtLicenseNo_Update.Size = new Size(125, 27);
            txtLicenseNo_Update.TabIndex = 24;
            // 
            // cmbNoOfSeats_Update
            // 
            cmbNoOfSeats_Update.FormattingEnabled = true;
            cmbNoOfSeats_Update.Items.AddRange(new object[] { "2", "4", "6", "13" });
            cmbNoOfSeats_Update.Location = new Point(402, 198);
            cmbNoOfSeats_Update.Name = "cmbNoOfSeats_Update";
            cmbNoOfSeats_Update.Size = new Size(105, 28);
            cmbNoOfSeats_Update.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(26, 183);
            label9.Name = "label9";
            label9.Size = new Size(275, 41);
            label9.TabIndex = 22;
            label9.Text = "Number Of Seats: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(26, 124);
            label10.Name = "label10";
            label10.Size = new Size(94, 41);
            label10.TabIndex = 21;
            label10.Text = "Year: ";
            // 
            // cmbVehicleID_Update
            // 
            cmbVehicleID_Update.FormattingEnabled = true;
            cmbVehicleID_Update.Location = new Point(298, 32);
            cmbVehicleID_Update.Name = "cmbVehicleID_Update";
            cmbVehicleID_Update.Size = new Size(209, 28);
            cmbVehicleID_Update.TabIndex = 17;
            // 
            // lblVehicle
            // 
            lblVehicle.AutoSize = true;
            lblVehicle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehicle.Location = new Point(26, 18);
            lblVehicle.Name = "lblVehicle";
            lblVehicle.Size = new Size(174, 41);
            lblVehicle.TabIndex = 16;
            lblVehicle.Text = "Vehicle ID: ";
            // 
            // dgvVehicles_Update
            // 
            dgvVehicles_Update.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles_Update.Location = new Point(528, 32);
            dgvVehicles_Update.Name = "dgvVehicles_Update";
            dgvVehicles_Update.RowHeadersWidth = 51;
            dgvVehicles_Update.Size = new Size(473, 293);
            dgvVehicles_Update.TabIndex = 15;
            // 
            // btnClear_Update
            // 
            btnClear_Update.Location = new Point(542, 560);
            btnClear_Update.Name = "btnClear_Update";
            btnClear_Update.Size = new Size(203, 68);
            btnClear_Update.TabIndex = 14;
            btnClear_Update.Text = "Clear";
            btnClear_Update.UseVisualStyleBackColor = true;
            // 
            // btnUpdate_Update
            // 
            btnUpdate_Update.Location = new Point(298, 560);
            btnUpdate_Update.Name = "btnUpdate_Update";
            btnUpdate_Update.Size = new Size(203, 68);
            btnUpdate_Update.TabIndex = 13;
            btnUpdate_Update.Text = "Update";
            btnUpdate_Update.UseVisualStyleBackColor = true;
            // 
            // btnBack_Update
            // 
            btnBack_Update.Location = new Point(403, 649);
            btnBack_Update.Name = "btnBack_Update";
            btnBack_Update.Size = new Size(203, 68);
            btnBack_Update.TabIndex = 12;
            btnBack_Update.Text = "Back";
            btnBack_Update.UseVisualStyleBackColor = true;
            // 
            // tabDelete
            // 
            tabDelete.BackColor = Color.FromArgb(188, 170, 146);
            tabDelete.BackgroundImage = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            tabDelete.BackgroundImageLayout = ImageLayout.Zoom;
            tabDelete.Controls.Add(btnClear_Delete);
            tabDelete.Controls.Add(btnDelete_Delete);
            tabDelete.Controls.Add(btnBack_Delete);
            tabDelete.Controls.Add(dgvVehicles_Delete);
            tabDelete.Controls.Add(cmbVehicleID_Delete);
            tabDelete.Controls.Add(lblClassID_Delete);
            tabDelete.Location = new Point(4, 29);
            tabDelete.Name = "tabDelete";
            tabDelete.Size = new Size(1094, 728);
            tabDelete.TabIndex = 2;
            tabDelete.Text = "Delete";
            // 
            // btnClear_Delete
            // 
            btnClear_Delete.Location = new Point(525, 548);
            btnClear_Delete.Name = "btnClear_Delete";
            btnClear_Delete.Size = new Size(203, 68);
            btnClear_Delete.TabIndex = 22;
            btnClear_Delete.Text = "Clear";
            btnClear_Delete.UseVisualStyleBackColor = true;
            // 
            // btnDelete_Delete
            // 
            btnDelete_Delete.Location = new Point(297, 548);
            btnDelete_Delete.Name = "btnDelete_Delete";
            btnDelete_Delete.Size = new Size(203, 68);
            btnDelete_Delete.TabIndex = 21;
            btnDelete_Delete.Text = "Delete";
            btnDelete_Delete.UseVisualStyleBackColor = true;
            // 
            // btnBack_Delete
            // 
            btnBack_Delete.Location = new Point(405, 634);
            btnBack_Delete.Name = "btnBack_Delete";
            btnBack_Delete.Size = new Size(203, 68);
            btnBack_Delete.TabIndex = 20;
            btnBack_Delete.Text = "Back";
            btnBack_Delete.UseVisualStyleBackColor = true;
            // 
            // dgvVehicles_Delete
            // 
            dgvVehicles_Delete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles_Delete.Location = new Point(250, 37);
            dgvVehicles_Delete.Name = "dgvVehicles_Delete";
            dgvVehicles_Delete.RowHeadersWidth = 51;
            dgvVehicles_Delete.Size = new Size(529, 363);
            dgvVehicles_Delete.TabIndex = 19;
            // 
            // cmbVehicleID_Delete
            // 
            cmbVehicleID_Delete.FormattingEnabled = true;
            cmbVehicleID_Delete.Location = new Point(485, 480);
            cmbVehicleID_Delete.Name = "cmbVehicleID_Delete";
            cmbVehicleID_Delete.Size = new Size(209, 28);
            cmbVehicleID_Delete.TabIndex = 18;
            // 
            // lblClassID_Delete
            // 
            lblClassID_Delete.AutoSize = true;
            lblClassID_Delete.BackColor = Color.Transparent;
            lblClassID_Delete.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassID_Delete.Location = new Point(315, 470);
            lblClassID_Delete.Name = "lblClassID_Delete";
            lblClassID_Delete.Size = new Size(164, 38);
            lblClassID_Delete.TabIndex = 17;
            lblClassID_Delete.Text = "Vehicle ID: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(364, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(8, 5);
            label5.Name = "label5";
            label5.Size = new Size(225, 41);
            label5.TabIndex = 22;
            label5.Text = "Vehicle Name: ";
            // 
            // txtCostPerDay
            // 
            txtCostPerDay.Location = new Point(362, 248);
            txtCostPerDay.Name = "txtCostPerDay";
            txtCostPerDay.Size = new Size(125, 27);
            txtCostPerDay.TabIndex = 24;
            // 
            // cmbNoOfSeats
            // 
            cmbNoOfSeats.FormattingEnabled = true;
            cmbNoOfSeats.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" });
            cmbNoOfSeats.Location = new Point(362, 192);
            cmbNoOfSeats.Name = "cmbNoOfSeats";
            cmbNoOfSeats.Size = new Size(125, 28);
            cmbNoOfSeats.TabIndex = 12;
            // 
            // frmVehicles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1102, 761);
            Controls.Add(tabControlVehicleClasses);
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
            ((System.ComponentModel.ISupportInitialize)pbxImage_Update).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles_Update).EndInit();
            tabDelete.ResumeLayout(false);
            tabDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles_Delete).EndInit();
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
        private ComboBox cmbVehicleID_Update;
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
        private ComboBox cmbVehicleID_Delete;
        private Label lblClassID_Delete;
        private ComboBox cmbClassSelect;
        private Label lblYear;
        private Label lblNoSeats;
        private Label lblCostPerDay;
        private TextBox txtLicenseNo;
        private Label lblLicenseNo;
        private TextBox txtYear;
        private PictureBox pbxImage_Update;
        private TextBox txtYear_Update;
        private Label label1;
        private Label label2;
        private HScrollBar hsbCostPerDay_Update;
        private Label label8;
        private TextBox txtLicenseNo_Update;
        private ComboBox cmbNoOfSeats_Update;
        private Label label9;
        private Label label10;
        private ComboBox cmbClass_Update;
        private Label label3;
        private TextBox txtCostPerDay;
        private TextBox txtName;
        private Label label5;
        private ComboBox cmbNoOfSeats;
    }
}