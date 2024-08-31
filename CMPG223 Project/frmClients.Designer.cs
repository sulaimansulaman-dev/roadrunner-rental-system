namespace CMPG223_Project
{
    partial class frmClients
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
            btnAdd_AddClients = new Button();
            lblClient_ID_Number_AddClient = new Label();
            lblFirst_Name_AddClient = new Label();
            lblLast_Name_AddClient = new Label();
            lblCell_Number_AddClient = new Label();
            lblEmail_AddClient = new Label();
            lblHasDriversLicense_AddClient = new Label();
            MaintainClient = new TabControl();
            AddClient = new TabPage();
            chkbYes_HasDriversLicense_AddClient = new CheckBox();
            btnBack_AddClients = new Button();
            btnClear_AddClients = new Button();
            cmbHasDriversLicense_AddClient = new ComboBox();
            txtEmail_AddClient = new TextBox();
            txtCellNumber_AddClient = new TextBox();
            txtLastName_AddClient = new TextBox();
            txtFirstName_AddClient = new TextBox();
            txtClient_ID_Number_AddClient = new TextBox();
            dgvAddClient = new DataGridView();
            UpdateClient = new TabPage();
            chkbYesHasDriversLicense_UpdateClient = new CheckBox();
            txtClient_ID_UpdateClient = new TextBox();
            btnBack_UpdateClient = new Button();
            btnClear_UpdateClient = new Button();
            btnUpdate_UpdateClient = new Button();
            lblClient_ID_UpdateClient = new Label();
            cmbHasDriversLicense_UpdateClient = new ComboBox();
            txtEmail_UpdateClient = new TextBox();
            txtCellNumber_UpdateClient = new TextBox();
            txtLastName_UpdateClient = new TextBox();
            txtFirstName_UpdateClient = new TextBox();
            txtClient_ID_Number_UpdateClient = new TextBox();
            dgvUpdateClient = new DataGridView();
            lblClient_ID_Number_UpdateClient = new Label();
            lblHasDriversLicense_UpdateClient = new Label();
            lblFirst_Name_UpdateClient = new Label();
            lblEmail_UpdateClient = new Label();
            lblLast_Name_UpdateClient = new Label();
            lblCell_Number_UpdateClient = new Label();
            DeleteClient = new TabPage();
            txtClient_ID_DeleteClient = new TextBox();
            btnClear_DeleteClient = new Button();
            btnDelete_DeleteClient = new Button();
            btnBack_DeleteClient = new Button();
            dgvDeleteClient = new DataGridView();
            lblClient_ID_DeleteClient = new Label();
            errorProvider1 = new ErrorProvider(components);
            txtSearch_UpdateClient = new TextBox();
            lblSearch_UpdateClient = new Label();
            txtSearch_DeleteClient = new TextBox();
            lblSearch_DeleteClient = new Label();
            MaintainClient.SuspendLayout();
            AddClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddClient).BeginInit();
            UpdateClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateClient).BeginInit();
            DeleteClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeleteClient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd_AddClients
            // 
            btnAdd_AddClients.Location = new Point(786, 545);
            btnAdd_AddClients.Name = "btnAdd_AddClients";
            btnAdd_AddClients.Size = new Size(117, 72);
            btnAdd_AddClients.TabIndex = 0;
            btnAdd_AddClients.Text = "Add";
            btnAdd_AddClients.UseVisualStyleBackColor = true;
            btnAdd_AddClients.Click += btnAdd_AddClients_Click;
            // 
            // lblClient_ID_Number_AddClient
            // 
            lblClient_ID_Number_AddClient.AutoSize = true;
            lblClient_ID_Number_AddClient.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblClient_ID_Number_AddClient.Location = new Point(14, 14);
            lblClient_ID_Number_AddClient.Name = "lblClient_ID_Number_AddClient";
            lblClient_ID_Number_AddClient.Size = new Size(324, 48);
            lblClient_ID_Number_AddClient.TabIndex = 4;
            lblClient_ID_Number_AddClient.Text = "Client ID Number:";
            // 
            // lblFirst_Name_AddClient
            // 
            lblFirst_Name_AddClient.AutoSize = true;
            lblFirst_Name_AddClient.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblFirst_Name_AddClient.Location = new Point(14, 80);
            lblFirst_Name_AddClient.Name = "lblFirst_Name_AddClient";
            lblFirst_Name_AddClient.Size = new Size(212, 48);
            lblFirst_Name_AddClient.TabIndex = 5;
            lblFirst_Name_AddClient.Text = "First Name:";
            // 
            // lblLast_Name_AddClient
            // 
            lblLast_Name_AddClient.AutoSize = true;
            lblLast_Name_AddClient.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLast_Name_AddClient.Location = new Point(14, 147);
            lblLast_Name_AddClient.Name = "lblLast_Name_AddClient";
            lblLast_Name_AddClient.Size = new Size(206, 48);
            lblLast_Name_AddClient.TabIndex = 6;
            lblLast_Name_AddClient.Text = "Last Name:";
            // 
            // lblCell_Number_AddClient
            // 
            lblCell_Number_AddClient.AutoSize = true;
            lblCell_Number_AddClient.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCell_Number_AddClient.Location = new Point(14, 216);
            lblCell_Number_AddClient.Name = "lblCell_Number_AddClient";
            lblCell_Number_AddClient.Size = new Size(240, 48);
            lblCell_Number_AddClient.TabIndex = 7;
            lblCell_Number_AddClient.Text = "Cell Number:";
            // 
            // lblEmail_AddClient
            // 
            lblEmail_AddClient.AutoSize = true;
            lblEmail_AddClient.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblEmail_AddClient.Location = new Point(14, 282);
            lblEmail_AddClient.Name = "lblEmail_AddClient";
            lblEmail_AddClient.Size = new Size(121, 48);
            lblEmail_AddClient.TabIndex = 8;
            lblEmail_AddClient.Text = "Email:";
            // 
            // lblHasDriversLicense_AddClient
            // 
            lblHasDriversLicense_AddClient.AutoSize = true;
            lblHasDriversLicense_AddClient.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHasDriversLicense_AddClient.Location = new Point(14, 358);
            lblHasDriversLicense_AddClient.Name = "lblHasDriversLicense_AddClient";
            lblHasDriversLicense_AddClient.Size = new Size(281, 48);
            lblHasDriversLicense_AddClient.TabIndex = 9;
            lblHasDriversLicense_AddClient.Text = "Drivers License:";
            // 
            // MaintainClient
            // 
            MaintainClient.Controls.Add(AddClient);
            MaintainClient.Controls.Add(UpdateClient);
            MaintainClient.Controls.Add(DeleteClient);
            MaintainClient.Location = new Point(0, -3);
            MaintainClient.Name = "MaintainClient";
            MaintainClient.SelectedIndex = 0;
            MaintainClient.Size = new Size(1177, 729);
            MaintainClient.TabIndex = 10;
            // 
            // AddClient
            // 
            AddClient.Controls.Add(chkbYes_HasDriversLicense_AddClient);
            AddClient.Controls.Add(btnBack_AddClients);
            AddClient.Controls.Add(btnClear_AddClients);
            AddClient.Controls.Add(cmbHasDriversLicense_AddClient);
            AddClient.Controls.Add(txtEmail_AddClient);
            AddClient.Controls.Add(txtCellNumber_AddClient);
            AddClient.Controls.Add(txtLastName_AddClient);
            AddClient.Controls.Add(txtFirstName_AddClient);
            AddClient.Controls.Add(txtClient_ID_Number_AddClient);
            AddClient.Controls.Add(dgvAddClient);
            AddClient.Controls.Add(lblClient_ID_Number_AddClient);
            AddClient.Controls.Add(lblHasDriversLicense_AddClient);
            AddClient.Controls.Add(lblFirst_Name_AddClient);
            AddClient.Controls.Add(btnAdd_AddClients);
            AddClient.Controls.Add(lblEmail_AddClient);
            AddClient.Controls.Add(lblLast_Name_AddClient);
            AddClient.Controls.Add(lblCell_Number_AddClient);
            AddClient.Location = new Point(4, 34);
            AddClient.Name = "AddClient";
            AddClient.Padding = new Padding(3);
            AddClient.Size = new Size(1169, 691);
            AddClient.TabIndex = 0;
            AddClient.Text = "Add";
            AddClient.UseVisualStyleBackColor = true;
            // 
            // chkbYes_HasDriversLicense_AddClient
            // 
            chkbYes_HasDriversLicense_AddClient.AutoSize = true;
            chkbYes_HasDriversLicense_AddClient.Location = new Point(344, 376);
            chkbYes_HasDriversLicense_AddClient.Name = "chkbYes_HasDriversLicense_AddClient";
            chkbYes_HasDriversLicense_AddClient.Size = new Size(63, 29);
            chkbYes_HasDriversLicense_AddClient.TabIndex = 19;
            chkbYes_HasDriversLicense_AddClient.Text = "Yes";
            chkbYes_HasDriversLicense_AddClient.UseVisualStyleBackColor = true;
            // 
            // btnBack_AddClients
            // 
            btnBack_AddClients.Location = new Point(1049, 619);
            btnBack_AddClients.Name = "btnBack_AddClients";
            btnBack_AddClients.Size = new Size(117, 72);
            btnBack_AddClients.TabIndex = 18;
            btnBack_AddClients.Text = "Back";
            btnBack_AddClients.UseVisualStyleBackColor = true;
            // 
            // btnClear_AddClients
            // 
            btnClear_AddClients.Location = new Point(926, 545);
            btnClear_AddClients.Name = "btnClear_AddClients";
            btnClear_AddClients.Size = new Size(117, 72);
            btnClear_AddClients.TabIndex = 17;
            btnClear_AddClients.Text = "Clear";
            btnClear_AddClients.UseVisualStyleBackColor = true;
            btnClear_AddClients.Click += btnClear_AddClients_Click;
            // 
            // cmbHasDriversLicense_AddClient
            // 
            cmbHasDriversLicense_AddClient.FormattingEnabled = true;
            cmbHasDriversLicense_AddClient.Items.AddRange(new object[] { "Yes", "No" });
            cmbHasDriversLicense_AddClient.Location = new Point(357, 506);
            cmbHasDriversLicense_AddClient.Name = "cmbHasDriversLicense_AddClient";
            cmbHasDriversLicense_AddClient.Size = new Size(198, 33);
            cmbHasDriversLicense_AddClient.TabIndex = 16;
            // 
            // txtEmail_AddClient
            // 
            txtEmail_AddClient.Location = new Point(344, 298);
            txtEmail_AddClient.Name = "txtEmail_AddClient";
            txtEmail_AddClient.Size = new Size(198, 31);
            txtEmail_AddClient.TabIndex = 15;
            // 
            // txtCellNumber_AddClient
            // 
            txtCellNumber_AddClient.Location = new Point(344, 232);
            txtCellNumber_AddClient.Name = "txtCellNumber_AddClient";
            txtCellNumber_AddClient.Size = new Size(198, 31);
            txtCellNumber_AddClient.TabIndex = 14;
            // 
            // txtLastName_AddClient
            // 
            txtLastName_AddClient.Location = new Point(344, 163);
            txtLastName_AddClient.Name = "txtLastName_AddClient";
            txtLastName_AddClient.Size = new Size(198, 31);
            txtLastName_AddClient.TabIndex = 13;
            // 
            // txtFirstName_AddClient
            // 
            txtFirstName_AddClient.Location = new Point(344, 97);
            txtFirstName_AddClient.Name = "txtFirstName_AddClient";
            txtFirstName_AddClient.Size = new Size(198, 31);
            txtFirstName_AddClient.TabIndex = 12;
            // 
            // txtClient_ID_Number_AddClient
            // 
            txtClient_ID_Number_AddClient.Location = new Point(344, 31);
            txtClient_ID_Number_AddClient.Name = "txtClient_ID_Number_AddClient";
            txtClient_ID_Number_AddClient.Size = new Size(198, 31);
            txtClient_ID_Number_AddClient.TabIndex = 11;
            // 
            // dgvAddClient
            // 
            dgvAddClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddClient.Location = new Point(662, 6);
            dgvAddClient.Name = "dgvAddClient";
            dgvAddClient.RowHeadersWidth = 62;
            dgvAddClient.Size = new Size(490, 297);
            dgvAddClient.TabIndex = 10;
            // 
            // UpdateClient
            // 
            UpdateClient.Controls.Add(txtSearch_UpdateClient);
            UpdateClient.Controls.Add(lblSearch_UpdateClient);
            UpdateClient.Controls.Add(chkbYesHasDriversLicense_UpdateClient);
            UpdateClient.Controls.Add(txtClient_ID_UpdateClient);
            UpdateClient.Controls.Add(btnBack_UpdateClient);
            UpdateClient.Controls.Add(btnClear_UpdateClient);
            UpdateClient.Controls.Add(btnUpdate_UpdateClient);
            UpdateClient.Controls.Add(lblClient_ID_UpdateClient);
            UpdateClient.Controls.Add(cmbHasDriversLicense_UpdateClient);
            UpdateClient.Controls.Add(txtEmail_UpdateClient);
            UpdateClient.Controls.Add(txtCellNumber_UpdateClient);
            UpdateClient.Controls.Add(txtLastName_UpdateClient);
            UpdateClient.Controls.Add(txtFirstName_UpdateClient);
            UpdateClient.Controls.Add(txtClient_ID_Number_UpdateClient);
            UpdateClient.Controls.Add(dgvUpdateClient);
            UpdateClient.Controls.Add(lblClient_ID_Number_UpdateClient);
            UpdateClient.Controls.Add(lblHasDriversLicense_UpdateClient);
            UpdateClient.Controls.Add(lblFirst_Name_UpdateClient);
            UpdateClient.Controls.Add(lblEmail_UpdateClient);
            UpdateClient.Controls.Add(lblLast_Name_UpdateClient);
            UpdateClient.Controls.Add(lblCell_Number_UpdateClient);
            UpdateClient.Location = new Point(4, 34);
            UpdateClient.Name = "UpdateClient";
            UpdateClient.Padding = new Padding(3);
            UpdateClient.Size = new Size(1169, 691);
            UpdateClient.TabIndex = 1;
            UpdateClient.Text = "Update";
            UpdateClient.UseVisualStyleBackColor = true;
            // 
            // chkbYesHasDriversLicense_UpdateClient
            // 
            chkbYesHasDriversLicense_UpdateClient.AutoSize = true;
            chkbYesHasDriversLicense_UpdateClient.Location = new Point(338, 444);
            chkbYesHasDriversLicense_UpdateClient.Name = "chkbYesHasDriversLicense_UpdateClient";
            chkbYesHasDriversLicense_UpdateClient.Size = new Size(63, 29);
            chkbYesHasDriversLicense_UpdateClient.TabIndex = 35;
            chkbYesHasDriversLicense_UpdateClient.Text = "Yes";
            chkbYesHasDriversLicense_UpdateClient.UseVisualStyleBackColor = true;
            // 
            // txtClient_ID_UpdateClient
            // 
            txtClient_ID_UpdateClient.Location = new Point(338, 36);
            txtClient_ID_UpdateClient.Name = "txtClient_ID_UpdateClient";
            txtClient_ID_UpdateClient.Size = new Size(198, 31);
            txtClient_ID_UpdateClient.TabIndex = 34;
            // 
            // btnBack_UpdateClient
            // 
            btnBack_UpdateClient.Location = new Point(1052, 616);
            btnBack_UpdateClient.Name = "btnBack_UpdateClient";
            btnBack_UpdateClient.Size = new Size(117, 72);
            btnBack_UpdateClient.TabIndex = 33;
            btnBack_UpdateClient.Text = "Back";
            btnBack_UpdateClient.UseVisualStyleBackColor = true;
            // 
            // btnClear_UpdateClient
            // 
            btnClear_UpdateClient.Location = new Point(936, 538);
            btnClear_UpdateClient.Name = "btnClear_UpdateClient";
            btnClear_UpdateClient.Size = new Size(117, 72);
            btnClear_UpdateClient.TabIndex = 32;
            btnClear_UpdateClient.Text = "Clear";
            btnClear_UpdateClient.UseVisualStyleBackColor = true;
            btnClear_UpdateClient.Click += btnClear_UpdateClient_Click;
            // 
            // btnUpdate_UpdateClient
            // 
            btnUpdate_UpdateClient.Location = new Point(794, 538);
            btnUpdate_UpdateClient.Name = "btnUpdate_UpdateClient";
            btnUpdate_UpdateClient.Size = new Size(117, 72);
            btnUpdate_UpdateClient.TabIndex = 31;
            btnUpdate_UpdateClient.Text = "Update";
            btnUpdate_UpdateClient.UseVisualStyleBackColor = true;
            btnUpdate_UpdateClient.Click += btnUpdate_UpdateClient_Click;
            // 
            // lblClient_ID_UpdateClient
            // 
            lblClient_ID_UpdateClient.AutoSize = true;
            lblClient_ID_UpdateClient.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblClient_ID_UpdateClient.Location = new Point(8, 19);
            lblClient_ID_UpdateClient.Name = "lblClient_ID_UpdateClient";
            lblClient_ID_UpdateClient.Size = new Size(175, 48);
            lblClient_ID_UpdateClient.TabIndex = 30;
            lblClient_ID_UpdateClient.Text = "Client ID:";
            // 
            // cmbHasDriversLicense_UpdateClient
            // 
            cmbHasDriversLicense_UpdateClient.FormattingEnabled = true;
            cmbHasDriversLicense_UpdateClient.Items.AddRange(new object[] { "Yes", "No" });
            cmbHasDriversLicense_UpdateClient.Location = new Point(394, 538);
            cmbHasDriversLicense_UpdateClient.Name = "cmbHasDriversLicense_UpdateClient";
            cmbHasDriversLicense_UpdateClient.Size = new Size(198, 33);
            cmbHasDriversLicense_UpdateClient.TabIndex = 29;
            // 
            // txtEmail_UpdateClient
            // 
            txtEmail_UpdateClient.Location = new Point(338, 366);
            txtEmail_UpdateClient.Name = "txtEmail_UpdateClient";
            txtEmail_UpdateClient.Size = new Size(198, 31);
            txtEmail_UpdateClient.TabIndex = 28;
            // 
            // txtCellNumber_UpdateClient
            // 
            txtCellNumber_UpdateClient.Location = new Point(338, 300);
            txtCellNumber_UpdateClient.Name = "txtCellNumber_UpdateClient";
            txtCellNumber_UpdateClient.Size = new Size(198, 31);
            txtCellNumber_UpdateClient.TabIndex = 27;
            // 
            // txtLastName_UpdateClient
            // 
            txtLastName_UpdateClient.Location = new Point(338, 231);
            txtLastName_UpdateClient.Name = "txtLastName_UpdateClient";
            txtLastName_UpdateClient.Size = new Size(198, 31);
            txtLastName_UpdateClient.TabIndex = 26;
            // 
            // txtFirstName_UpdateClient
            // 
            txtFirstName_UpdateClient.Location = new Point(338, 165);
            txtFirstName_UpdateClient.Name = "txtFirstName_UpdateClient";
            txtFirstName_UpdateClient.Size = new Size(198, 31);
            txtFirstName_UpdateClient.TabIndex = 25;
            // 
            // txtClient_ID_Number_UpdateClient
            // 
            txtClient_ID_Number_UpdateClient.Location = new Point(338, 99);
            txtClient_ID_Number_UpdateClient.Name = "txtClient_ID_Number_UpdateClient";
            txtClient_ID_Number_UpdateClient.Size = new Size(198, 31);
            txtClient_ID_Number_UpdateClient.TabIndex = 24;
            // 
            // dgvUpdateClient
            // 
            dgvUpdateClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpdateClient.Location = new Point(652, 99);
            dgvUpdateClient.Name = "dgvUpdateClient";
            dgvUpdateClient.RowHeadersWidth = 62;
            dgvUpdateClient.Size = new Size(490, 297);
            dgvUpdateClient.TabIndex = 23;
            dgvUpdateClient.CellClick += dgvUpdateClient_CellClick;
            // 
            // lblClient_ID_Number_UpdateClient
            // 
            lblClient_ID_Number_UpdateClient.AutoSize = true;
            lblClient_ID_Number_UpdateClient.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblClient_ID_Number_UpdateClient.Location = new Point(8, 82);
            lblClient_ID_Number_UpdateClient.Name = "lblClient_ID_Number_UpdateClient";
            lblClient_ID_Number_UpdateClient.Size = new Size(324, 48);
            lblClient_ID_Number_UpdateClient.TabIndex = 17;
            lblClient_ID_Number_UpdateClient.Text = "Client ID Number:";
            // 
            // lblHasDriversLicense_UpdateClient
            // 
            lblHasDriversLicense_UpdateClient.AutoSize = true;
            lblHasDriversLicense_UpdateClient.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHasDriversLicense_UpdateClient.Location = new Point(8, 426);
            lblHasDriversLicense_UpdateClient.Name = "lblHasDriversLicense_UpdateClient";
            lblHasDriversLicense_UpdateClient.Size = new Size(281, 48);
            lblHasDriversLicense_UpdateClient.TabIndex = 22;
            lblHasDriversLicense_UpdateClient.Text = "Drivers License:";
            // 
            // lblFirst_Name_UpdateClient
            // 
            lblFirst_Name_UpdateClient.AutoSize = true;
            lblFirst_Name_UpdateClient.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblFirst_Name_UpdateClient.Location = new Point(8, 149);
            lblFirst_Name_UpdateClient.Name = "lblFirst_Name_UpdateClient";
            lblFirst_Name_UpdateClient.Size = new Size(212, 48);
            lblFirst_Name_UpdateClient.TabIndex = 18;
            lblFirst_Name_UpdateClient.Text = "First Name:";
            // 
            // lblEmail_UpdateClient
            // 
            lblEmail_UpdateClient.AutoSize = true;
            lblEmail_UpdateClient.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblEmail_UpdateClient.Location = new Point(8, 350);
            lblEmail_UpdateClient.Name = "lblEmail_UpdateClient";
            lblEmail_UpdateClient.Size = new Size(121, 48);
            lblEmail_UpdateClient.TabIndex = 21;
            lblEmail_UpdateClient.Text = "Email:";
            // 
            // lblLast_Name_UpdateClient
            // 
            lblLast_Name_UpdateClient.AutoSize = true;
            lblLast_Name_UpdateClient.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLast_Name_UpdateClient.Location = new Point(8, 215);
            lblLast_Name_UpdateClient.Name = "lblLast_Name_UpdateClient";
            lblLast_Name_UpdateClient.Size = new Size(206, 48);
            lblLast_Name_UpdateClient.TabIndex = 19;
            lblLast_Name_UpdateClient.Text = "Last Name:";
            // 
            // lblCell_Number_UpdateClient
            // 
            lblCell_Number_UpdateClient.AutoSize = true;
            lblCell_Number_UpdateClient.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCell_Number_UpdateClient.Location = new Point(8, 284);
            lblCell_Number_UpdateClient.Name = "lblCell_Number_UpdateClient";
            lblCell_Number_UpdateClient.Size = new Size(240, 48);
            lblCell_Number_UpdateClient.TabIndex = 20;
            lblCell_Number_UpdateClient.Text = "Cell Number:";
            // 
            // DeleteClient
            // 
            DeleteClient.Controls.Add(txtSearch_DeleteClient);
            DeleteClient.Controls.Add(lblSearch_DeleteClient);
            DeleteClient.Controls.Add(txtClient_ID_DeleteClient);
            DeleteClient.Controls.Add(btnClear_DeleteClient);
            DeleteClient.Controls.Add(btnDelete_DeleteClient);
            DeleteClient.Controls.Add(btnBack_DeleteClient);
            DeleteClient.Controls.Add(dgvDeleteClient);
            DeleteClient.Controls.Add(lblClient_ID_DeleteClient);
            DeleteClient.Location = new Point(4, 34);
            DeleteClient.Name = "DeleteClient";
            DeleteClient.Padding = new Padding(3);
            DeleteClient.Size = new Size(1169, 691);
            DeleteClient.TabIndex = 2;
            DeleteClient.Text = "Delete";
            DeleteClient.UseVisualStyleBackColor = true;
            // 
            // txtClient_ID_DeleteClient
            // 
            txtClient_ID_DeleteClient.Enabled = false;
            txtClient_ID_DeleteClient.Location = new Point(207, 71);
            txtClient_ID_DeleteClient.Margin = new Padding(4);
            txtClient_ID_DeleteClient.MaxLength = 15;
            txtClient_ID_DeleteClient.Name = "txtClient_ID_DeleteClient";
            txtClient_ID_DeleteClient.Size = new Size(256, 31);
            txtClient_ID_DeleteClient.TabIndex = 33;
            // 
            // btnClear_DeleteClient
            // 
            btnClear_DeleteClient.Location = new Point(927, 547);
            btnClear_DeleteClient.Margin = new Padding(4);
            btnClear_DeleteClient.Name = "btnClear_DeleteClient";
            btnClear_DeleteClient.Size = new Size(117, 72);
            btnClear_DeleteClient.TabIndex = 32;
            btnClear_DeleteClient.Text = "Clear";
            btnClear_DeleteClient.UseVisualStyleBackColor = true;
            btnClear_DeleteClient.Click += btnClear_DeleteClient_Click;
            // 
            // btnDelete_DeleteClient
            // 
            btnDelete_DeleteClient.Location = new Point(789, 547);
            btnDelete_DeleteClient.Margin = new Padding(4);
            btnDelete_DeleteClient.Name = "btnDelete_DeleteClient";
            btnDelete_DeleteClient.Size = new Size(117, 72);
            btnDelete_DeleteClient.TabIndex = 31;
            btnDelete_DeleteClient.Text = "Delete";
            btnDelete_DeleteClient.UseVisualStyleBackColor = true;
            btnDelete_DeleteClient.Click += btnDelete_DeleteClient_Click;
            // 
            // btnBack_DeleteClient
            // 
            btnBack_DeleteClient.Location = new Point(1052, 619);
            btnBack_DeleteClient.Margin = new Padding(4);
            btnBack_DeleteClient.Name = "btnBack_DeleteClient";
            btnBack_DeleteClient.Size = new Size(117, 72);
            btnBack_DeleteClient.TabIndex = 30;
            btnBack_DeleteClient.Text = "Back";
            btnBack_DeleteClient.UseVisualStyleBackColor = true;
            // 
            // dgvDeleteClient
            // 
            dgvDeleteClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeleteClient.Location = new Point(548, 113);
            dgvDeleteClient.Margin = new Padding(4);
            dgvDeleteClient.Name = "dgvDeleteClient";
            dgvDeleteClient.RowHeadersWidth = 51;
            dgvDeleteClient.Size = new Size(591, 366);
            dgvDeleteClient.TabIndex = 29;
            dgvDeleteClient.CellClick += dgvDeleteClient_CellClick;
            // 
            // lblClient_ID_DeleteClient
            // 
            lblClient_ID_DeleteClient.AutoSize = true;
            lblClient_ID_DeleteClient.BackColor = Color.Transparent;
            lblClient_ID_DeleteClient.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClient_ID_DeleteClient.Location = new Point(19, 57);
            lblClient_ID_DeleteClient.Margin = new Padding(4, 0, 4, 0);
            lblClient_ID_DeleteClient.Name = "lblClient_ID_DeleteClient";
            lblClient_ID_DeleteClient.Size = new Size(171, 45);
            lblClient_ID_DeleteClient.TabIndex = 28;
            lblClient_ID_DeleteClient.Text = "Client ID: ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtSearch_UpdateClient
            // 
            txtSearch_UpdateClient.Location = new Point(818, 40);
            txtSearch_UpdateClient.Margin = new Padding(4);
            txtSearch_UpdateClient.MaxLength = 15;
            txtSearch_UpdateClient.Name = "txtSearch_UpdateClient";
            txtSearch_UpdateClient.Size = new Size(256, 31);
            txtSearch_UpdateClient.TabIndex = 37;
            txtSearch_UpdateClient.TextChanged += txtSearch_UpdateClient_TextChanged;
            // 
            // lblSearch_UpdateClient
            // 
            lblSearch_UpdateClient.AutoSize = true;
            lblSearch_UpdateClient.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSearch_UpdateClient.Location = new Point(652, 20);
            lblSearch_UpdateClient.Margin = new Padding(4, 0, 4, 0);
            lblSearch_UpdateClient.Name = "lblSearch_UpdateClient";
            lblSearch_UpdateClient.Size = new Size(151, 48);
            lblSearch_UpdateClient.TabIndex = 36;
            lblSearch_UpdateClient.Text = "Search: ";
            // 
            // txtSearch_DeleteClient
            // 
            txtSearch_DeleteClient.Location = new Point(714, 56);
            txtSearch_DeleteClient.Margin = new Padding(4);
            txtSearch_DeleteClient.MaxLength = 15;
            txtSearch_DeleteClient.Name = "txtSearch_DeleteClient";
            txtSearch_DeleteClient.Size = new Size(256, 31);
            txtSearch_DeleteClient.TabIndex = 35;
            txtSearch_DeleteClient.TextChanged += txtSearch_DeleteClient_TextChanged;
            // 
            // lblSearch_DeleteClient
            // 
            lblSearch_DeleteClient.AutoSize = true;
            lblSearch_DeleteClient.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSearch_DeleteClient.Location = new Point(548, 36);
            lblSearch_DeleteClient.Margin = new Padding(4, 0, 4, 0);
            lblSearch_DeleteClient.Name = "lblSearch_DeleteClient";
            lblSearch_DeleteClient.Size = new Size(151, 48);
            lblSearch_DeleteClient.TabIndex = 34;
            lblSearch_DeleteClient.Text = "Search: ";
            // 
            // frmClients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 728);
            Controls.Add(MaintainClient);
            Name = "frmClients";
            Text = "frmClients";
            Load += frmClients_Load;
            MaintainClient.ResumeLayout(false);
            AddClient.ResumeLayout(false);
            AddClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddClient).EndInit();
            UpdateClient.ResumeLayout(false);
            UpdateClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateClient).EndInit();
            DeleteClient.ResumeLayout(false);
            DeleteClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeleteClient).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd_AddClients;
        private Label lblClient_ID_Number_AddClient;
        private Label lblFirst_Name_AddClient;
        private Label lblLast_Name_AddClient;
        private Label lblCell_Number_AddClient;
        private Label lblEmail_AddClient;
        private Label lblHasDriversLicense_AddClient;
        private TabControl MaintainClient;
        private TabPage AddClient;
        private TabPage UpdateClient;
        private TabPage DeleteClient;
        private DataGridView dgvAddClient;
        private TextBox txtEmail_AddClient;
        private TextBox txtCellNumber_AddClient;
        private TextBox txtLastName_AddClient;
        private TextBox txtFirstName_AddClient;
        private TextBox txtClient_ID_Number_AddClient;
        private ComboBox cmbHasDriversLicense_AddClient;
        private ComboBox cmbHasDriversLicense_UpdateClient;
        private TextBox txtEmail_UpdateClient;
        private TextBox txtCellNumber_UpdateClient;
        private TextBox txtLastName_UpdateClient;
        private TextBox txtFirstName_UpdateClient;
        private TextBox txtClient_ID_Number_UpdateClient;
        private DataGridView dgvUpdateClient;
        private Label lblClient_ID_Number_UpdateClient;
        private Label lblHasDriversLicense_UpdateClient;
        private Label lblFirst_Name_UpdateClient;
        private Label lblEmail_UpdateClient;
        private Label lblLast_Name_UpdateClient;
        private Label lblCell_Number_UpdateClient;
        private Label lblClient_ID_UpdateClient;
        private Button btnBack_UpdateClient;
        private Button btnClear_UpdateClient;
        private Button btnUpdate_UpdateClient;
        private Button btnBack_AddClients;
        private Button btnClear_AddClients;
        private TextBox txtClient_ID_UpdateClient;
        private TextBox txtClient_ID_DeleteClient;
        private Button btnClear_DeleteClient;
        private Button btnDelete_DeleteClient;
        private Button btnBack_DeleteClient;
        private DataGridView dgvDeleteClient;
        private Label lblClient_ID_DeleteClient;
        private ErrorProvider errorProvider1;
        private CheckBox chkbYes_HasDriversLicense_AddClient;
        private CheckBox chkbYesHasDriversLicense_UpdateClient;
        private TextBox txtSearch_UpdateClient;
        private Label lblSearch_UpdateClient;
        private TextBox txtSearch_DeleteClient;
        private Label lblSearch_DeleteClient;
    }
}