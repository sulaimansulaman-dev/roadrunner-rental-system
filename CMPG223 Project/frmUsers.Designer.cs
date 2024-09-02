namespace CMPG223_Project
{
    partial class frmUsers
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
            MaintainUsers = new TabControl();
            AddUser = new TabPage();
            txtSearch_Add = new TextBox();
            label4 = new Label();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            dgvAddUsers = new DataGridView();
            btnBack_AddUsers = new Button();
            btnClear_AddUsers = new Button();
            btnAdd_AddUsers = new Button();
            txtCellNumber_AddUsers = new TextBox();
            txtLastName_AddUsers = new TextBox();
            txtFirstName_AddUsers = new TextBox();
            txtUsername_AddUsers = new TextBox();
            lblCellNumber_Users = new Label();
            lblLastName_Users = new Label();
            lblFirstName_Users = new Label();
            lblUsername_AddUsers = new Label();
            UpdateUsers = new TabPage();
            txtSearch_Update = new TextBox();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtUserID_UpdateUser = new TextBox();
            lblUserID_UpdateUsers = new Label();
            btnBack_UpdateUsers = new Button();
            btnClearUsers_UpdateUsers = new Button();
            btnUpdateUsers_UpdateUsers = new Button();
            dgvUpdateUsers = new DataGridView();
            txtCellNumber_UpdateUsers = new TextBox();
            txtLastName_UpdateUsers = new TextBox();
            txtFirstName_UpdateUsers = new TextBox();
            txtUsername_UpdateUsers = new TextBox();
            lblCellNumber_UpdateUsers = new Label();
            lblLastName_UpdateUsers = new Label();
            lblFirstName_UpdateUsers = new Label();
            lblUserName_UpdateUsers = new Label();
            DeleteUsers = new TabPage();
            txtSearch_Delete = new TextBox();
            label7 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            btnBack_DeleteUsers = new Button();
            btnClear_DeleteUsers = new Button();
            btnDelete_DeleteUsers = new Button();
            cmbUsername_DeleteUsers = new ComboBox();
            dgvDelete_DeleteUsers = new DataGridView();
            lblUserID_DeleteUser = new Label();
            MaintainUsers.SuspendLayout();
            AddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAddUsers).BeginInit();
            UpdateUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateUsers).BeginInit();
            DeleteUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDelete_DeleteUsers).BeginInit();
            SuspendLayout();
            // 
            // MaintainUsers
            // 
            MaintainUsers.AllowDrop = true;
            MaintainUsers.Controls.Add(AddUser);
            MaintainUsers.Controls.Add(UpdateUsers);
            MaintainUsers.Controls.Add(DeleteUsers);
            MaintainUsers.Dock = DockStyle.Fill;
            MaintainUsers.Location = new Point(0, 0);
            MaintainUsers.Margin = new Padding(3, 4, 3, 4);
            MaintainUsers.Name = "MaintainUsers";
            MaintainUsers.SelectedIndex = 0;
            MaintainUsers.Size = new Size(1027, 584);
            MaintainUsers.TabIndex = 0;
            // 
            // AddUser
            // 
            AddUser.BackColor = Color.FromArgb(188, 170, 146);
            AddUser.BackgroundImageLayout = ImageLayout.Zoom;
            AddUser.Controls.Add(txtSearch_Add);
            AddUser.Controls.Add(label4);
            AddUser.Controls.Add(label10);
            AddUser.Controls.Add(pictureBox2);
            AddUser.Controls.Add(dgvAddUsers);
            AddUser.Controls.Add(btnBack_AddUsers);
            AddUser.Controls.Add(btnClear_AddUsers);
            AddUser.Controls.Add(btnAdd_AddUsers);
            AddUser.Controls.Add(txtCellNumber_AddUsers);
            AddUser.Controls.Add(txtLastName_AddUsers);
            AddUser.Controls.Add(txtFirstName_AddUsers);
            AddUser.Controls.Add(txtUsername_AddUsers);
            AddUser.Controls.Add(lblCellNumber_Users);
            AddUser.Controls.Add(lblLastName_Users);
            AddUser.Controls.Add(lblFirstName_Users);
            AddUser.Controls.Add(lblUsername_AddUsers);
            AddUser.Location = new Point(4, 29);
            AddUser.Margin = new Padding(3, 4, 3, 4);
            AddUser.Name = "AddUser";
            AddUser.Padding = new Padding(3, 4, 3, 4);
            AddUser.Size = new Size(1019, 551);
            AddUser.TabIndex = 0;
            AddUser.Text = "Add";
            // 
            // txtSearch_Add
            // 
            txtSearch_Add.Location = new Point(693, 38);
            txtSearch_Add.Name = "txtSearch_Add";
            txtSearch_Add.Size = new Size(168, 27);
            txtSearch_Add.TabIndex = 47;
            txtSearch_Add.TextChanged += txtSearch_Add_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(579, 27);
            label4.Name = "label4";
            label4.Size = new Size(119, 41);
            label4.TabIndex = 46;
            label4.Text = "Search:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(182, 46);
            label10.TabIndex = 42;
            label10.Text = "Add Users";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            pictureBox2.Location = new Point(0, 448);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // dgvAddUsers
            // 
            dgvAddUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddUsers.Location = new Point(476, 72);
            dgvAddUsers.Margin = new Padding(3, 4, 3, 4);
            dgvAddUsers.Name = "dgvAddUsers";
            dgvAddUsers.RowHeadersWidth = 51;
            dgvAddUsers.Size = new Size(506, 355);
            dgvAddUsers.TabIndex = 11;
            // 
            // btnBack_AddUsers
            // 
            btnBack_AddUsers.Location = new Point(877, 435);
            btnBack_AddUsers.Margin = new Padding(3, 4, 3, 4);
            btnBack_AddUsers.Name = "btnBack_AddUsers";
            btnBack_AddUsers.Size = new Size(105, 55);
            btnBack_AddUsers.TabIndex = 10;
            btnBack_AddUsers.Text = "Back";
            btnBack_AddUsers.UseVisualStyleBackColor = true;
            btnBack_AddUsers.Click += btnBack_AddUsers_Click_1;
            // 
            // btnClear_AddUsers
            // 
            btnClear_AddUsers.Location = new Point(679, 435);
            btnClear_AddUsers.Margin = new Padding(3, 4, 3, 4);
            btnClear_AddUsers.Name = "btnClear_AddUsers";
            btnClear_AddUsers.Size = new Size(105, 55);
            btnClear_AddUsers.TabIndex = 9;
            btnClear_AddUsers.Text = "Clear";
            btnClear_AddUsers.UseVisualStyleBackColor = true;
            btnClear_AddUsers.Click += btnClear_AddUsers_Click;
            // 
            // btnAdd_AddUsers
            // 
            btnAdd_AddUsers.Location = new Point(476, 435);
            btnAdd_AddUsers.Margin = new Padding(3, 4, 3, 4);
            btnAdd_AddUsers.Name = "btnAdd_AddUsers";
            btnAdd_AddUsers.Size = new Size(105, 55);
            btnAdd_AddUsers.TabIndex = 8;
            btnAdd_AddUsers.Text = "Add";
            btnAdd_AddUsers.UseVisualStyleBackColor = true;
            btnAdd_AddUsers.Click += btnAdd_AddUsers_Click;
            // 
            // txtCellNumber_AddUsers
            // 
            txtCellNumber_AddUsers.Location = new Point(261, 256);
            txtCellNumber_AddUsers.Margin = new Padding(3, 4, 3, 4);
            txtCellNumber_AddUsers.Name = "txtCellNumber_AddUsers";
            txtCellNumber_AddUsers.Size = new Size(196, 27);
            txtCellNumber_AddUsers.TabIndex = 7;
            // 
            // txtLastName_AddUsers
            // 
            txtLastName_AddUsers.Location = new Point(261, 198);
            txtLastName_AddUsers.Margin = new Padding(3, 4, 3, 4);
            txtLastName_AddUsers.Name = "txtLastName_AddUsers";
            txtLastName_AddUsers.Size = new Size(196, 27);
            txtLastName_AddUsers.TabIndex = 6;
            // 
            // txtFirstName_AddUsers
            // 
            txtFirstName_AddUsers.Location = new Point(261, 144);
            txtFirstName_AddUsers.Margin = new Padding(3, 4, 3, 4);
            txtFirstName_AddUsers.Name = "txtFirstName_AddUsers";
            txtFirstName_AddUsers.Size = new Size(196, 27);
            txtFirstName_AddUsers.TabIndex = 5;
            // 
            // txtUsername_AddUsers
            // 
            txtUsername_AddUsers.Location = new Point(261, 84);
            txtUsername_AddUsers.Margin = new Padding(3, 4, 3, 4);
            txtUsername_AddUsers.Name = "txtUsername_AddUsers";
            txtUsername_AddUsers.Size = new Size(196, 27);
            txtUsername_AddUsers.TabIndex = 4;
            // 
            // lblCellNumber_Users
            // 
            lblCellNumber_Users.AutoSize = true;
            lblCellNumber_Users.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCellNumber_Users.Location = new Point(3, 241);
            lblCellNumber_Users.Name = "lblCellNumber_Users";
            lblCellNumber_Users.Size = new Size(204, 41);
            lblCellNumber_Users.TabIndex = 3;
            lblCellNumber_Users.Text = "Cell Number:";
            // 
            // lblLastName_Users
            // 
            lblLastName_Users.AutoSize = true;
            lblLastName_Users.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLastName_Users.Location = new Point(3, 184);
            lblLastName_Users.Name = "lblLastName_Users";
            lblLastName_Users.Size = new Size(173, 41);
            lblLastName_Users.TabIndex = 2;
            lblLastName_Users.Text = "Last Name:";
            // 
            // lblFirstName_Users
            // 
            lblFirstName_Users.AutoSize = true;
            lblFirstName_Users.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblFirstName_Users.Location = new Point(3, 129);
            lblFirstName_Users.Name = "lblFirstName_Users";
            lblFirstName_Users.Size = new Size(179, 41);
            lblFirstName_Users.TabIndex = 1;
            lblFirstName_Users.Text = "First Name:";
            // 
            // lblUsername_AddUsers
            // 
            lblUsername_AddUsers.AutoSize = true;
            lblUsername_AddUsers.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblUsername_AddUsers.Location = new Point(3, 72);
            lblUsername_AddUsers.Name = "lblUsername_AddUsers";
            lblUsername_AddUsers.Size = new Size(166, 41);
            lblUsername_AddUsers.TabIndex = 0;
            lblUsername_AddUsers.Text = "Username:";
            // 
            // UpdateUsers
            // 
            UpdateUsers.BackColor = Color.FromArgb(188, 170, 146);
            UpdateUsers.BackgroundImageLayout = ImageLayout.Zoom;
            UpdateUsers.Controls.Add(txtSearch_Update);
            UpdateUsers.Controls.Add(label3);
            UpdateUsers.Controls.Add(label1);
            UpdateUsers.Controls.Add(pictureBox1);
            UpdateUsers.Controls.Add(txtUserID_UpdateUser);
            UpdateUsers.Controls.Add(lblUserID_UpdateUsers);
            UpdateUsers.Controls.Add(btnBack_UpdateUsers);
            UpdateUsers.Controls.Add(btnClearUsers_UpdateUsers);
            UpdateUsers.Controls.Add(btnUpdateUsers_UpdateUsers);
            UpdateUsers.Controls.Add(dgvUpdateUsers);
            UpdateUsers.Controls.Add(txtCellNumber_UpdateUsers);
            UpdateUsers.Controls.Add(txtLastName_UpdateUsers);
            UpdateUsers.Controls.Add(txtFirstName_UpdateUsers);
            UpdateUsers.Controls.Add(txtUsername_UpdateUsers);
            UpdateUsers.Controls.Add(lblCellNumber_UpdateUsers);
            UpdateUsers.Controls.Add(lblLastName_UpdateUsers);
            UpdateUsers.Controls.Add(lblFirstName_UpdateUsers);
            UpdateUsers.Controls.Add(lblUserName_UpdateUsers);
            UpdateUsers.Location = new Point(4, 29);
            UpdateUsers.Margin = new Padding(3, 4, 3, 4);
            UpdateUsers.Name = "UpdateUsers";
            UpdateUsers.Padding = new Padding(3, 4, 3, 4);
            UpdateUsers.Size = new Size(1019, 551);
            UpdateUsers.TabIndex = 1;
            UpdateUsers.Text = "Update";
            // 
            // txtSearch_Update
            // 
            txtSearch_Update.Location = new Point(701, 38);
            txtSearch_Update.Name = "txtSearch_Update";
            txtSearch_Update.Size = new Size(168, 27);
            txtSearch_Update.TabIndex = 47;
            txtSearch_Update.TextChanged += txtSearch_Update_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(587, 27);
            label3.Name = "label3";
            label3.Size = new Size(119, 41);
            label3.TabIndex = 46;
            label3.Text = "Search:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 46);
            label1.TabIndex = 43;
            label1.Text = "Update Users";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            pictureBox1.Location = new Point(0, 448);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // txtUserID_UpdateUser
            // 
            txtUserID_UpdateUser.Location = new Point(222, 85);
            txtUserID_UpdateUser.Name = "txtUserID_UpdateUser";
            txtUserID_UpdateUser.ReadOnly = true;
            txtUserID_UpdateUser.Size = new Size(196, 27);
            txtUserID_UpdateUser.TabIndex = 17;
            // 
            // lblUserID_UpdateUsers
            // 
            lblUserID_UpdateUsers.AutoSize = true;
            lblUserID_UpdateUsers.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblUserID_UpdateUsers.ForeColor = SystemColors.ControlText;
            lblUserID_UpdateUsers.Location = new Point(6, 72);
            lblUserID_UpdateUsers.Name = "lblUserID_UpdateUsers";
            lblUserID_UpdateUsers.Size = new Size(121, 41);
            lblUserID_UpdateUsers.TabIndex = 16;
            lblUserID_UpdateUsers.Text = "UserID:";
            // 
            // btnBack_UpdateUsers
            // 
            btnBack_UpdateUsers.Location = new Point(879, 454);
            btnBack_UpdateUsers.Margin = new Padding(3, 4, 3, 4);
            btnBack_UpdateUsers.Name = "btnBack_UpdateUsers";
            btnBack_UpdateUsers.Size = new Size(103, 52);
            btnBack_UpdateUsers.TabIndex = 15;
            btnBack_UpdateUsers.Text = "Back";
            btnBack_UpdateUsers.UseVisualStyleBackColor = true;
            btnBack_UpdateUsers.Click += btnBack_UpdateUsers_Click_1;
            // 
            // btnClearUsers_UpdateUsers
            // 
            btnClearUsers_UpdateUsers.Location = new Point(676, 454);
            btnClearUsers_UpdateUsers.Margin = new Padding(3, 4, 3, 4);
            btnClearUsers_UpdateUsers.Name = "btnClearUsers_UpdateUsers";
            btnClearUsers_UpdateUsers.Size = new Size(103, 52);
            btnClearUsers_UpdateUsers.TabIndex = 14;
            btnClearUsers_UpdateUsers.Text = "Clear";
            btnClearUsers_UpdateUsers.UseVisualStyleBackColor = true;
            // 
            // btnUpdateUsers_UpdateUsers
            // 
            btnUpdateUsers_UpdateUsers.Location = new Point(476, 454);
            btnUpdateUsers_UpdateUsers.Margin = new Padding(3, 4, 3, 4);
            btnUpdateUsers_UpdateUsers.Name = "btnUpdateUsers_UpdateUsers";
            btnUpdateUsers_UpdateUsers.Size = new Size(103, 52);
            btnUpdateUsers_UpdateUsers.TabIndex = 13;
            btnUpdateUsers_UpdateUsers.Text = "Update";
            btnUpdateUsers_UpdateUsers.UseVisualStyleBackColor = true;
            btnUpdateUsers_UpdateUsers.Click += btnUpdateUsers_UpdateUsers_Click;
            // 
            // dgvUpdateUsers
            // 
            dgvUpdateUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpdateUsers.Location = new Point(476, 72);
            dgvUpdateUsers.Margin = new Padding(3, 4, 3, 4);
            dgvUpdateUsers.Name = "dgvUpdateUsers";
            dgvUpdateUsers.RowHeadersWidth = 51;
            dgvUpdateUsers.Size = new Size(506, 355);
            dgvUpdateUsers.TabIndex = 12;
            dgvUpdateUsers.CellClick += dgvUpdateUsers_CellClick;
            dgvUpdateUsers.CellContentClick += dgvUpdateUsers_CellContentClick;
            // 
            // txtCellNumber_UpdateUsers
            // 
            txtCellNumber_UpdateUsers.Location = new Point(222, 308);
            txtCellNumber_UpdateUsers.Margin = new Padding(3, 4, 3, 4);
            txtCellNumber_UpdateUsers.Name = "txtCellNumber_UpdateUsers";
            txtCellNumber_UpdateUsers.Size = new Size(196, 27);
            txtCellNumber_UpdateUsers.TabIndex = 8;
            // 
            // txtLastName_UpdateUsers
            // 
            txtLastName_UpdateUsers.Location = new Point(222, 251);
            txtLastName_UpdateUsers.Margin = new Padding(3, 4, 3, 4);
            txtLastName_UpdateUsers.Name = "txtLastName_UpdateUsers";
            txtLastName_UpdateUsers.Size = new Size(196, 27);
            txtLastName_UpdateUsers.TabIndex = 7;
            // 
            // txtFirstName_UpdateUsers
            // 
            txtFirstName_UpdateUsers.Location = new Point(222, 195);
            txtFirstName_UpdateUsers.Margin = new Padding(3, 4, 3, 4);
            txtFirstName_UpdateUsers.Name = "txtFirstName_UpdateUsers";
            txtFirstName_UpdateUsers.Size = new Size(196, 27);
            txtFirstName_UpdateUsers.TabIndex = 6;
            // 
            // txtUsername_UpdateUsers
            // 
            txtUsername_UpdateUsers.Location = new Point(222, 137);
            txtUsername_UpdateUsers.Margin = new Padding(3, 4, 3, 4);
            txtUsername_UpdateUsers.Name = "txtUsername_UpdateUsers";
            txtUsername_UpdateUsers.Size = new Size(196, 27);
            txtUsername_UpdateUsers.TabIndex = 5;
            // 
            // lblCellNumber_UpdateUsers
            // 
            lblCellNumber_UpdateUsers.AutoSize = true;
            lblCellNumber_UpdateUsers.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCellNumber_UpdateUsers.ForeColor = SystemColors.ControlText;
            lblCellNumber_UpdateUsers.Location = new Point(4, 296);
            lblCellNumber_UpdateUsers.Name = "lblCellNumber_UpdateUsers";
            lblCellNumber_UpdateUsers.Size = new Size(204, 41);
            lblCellNumber_UpdateUsers.TabIndex = 4;
            lblCellNumber_UpdateUsers.Text = "Cell Number:";
            // 
            // lblLastName_UpdateUsers
            // 
            lblLastName_UpdateUsers.AutoSize = true;
            lblLastName_UpdateUsers.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLastName_UpdateUsers.ForeColor = SystemColors.ControlText;
            lblLastName_UpdateUsers.Location = new Point(6, 239);
            lblLastName_UpdateUsers.Name = "lblLastName_UpdateUsers";
            lblLastName_UpdateUsers.Size = new Size(173, 41);
            lblLastName_UpdateUsers.TabIndex = 3;
            lblLastName_UpdateUsers.Text = "Last Name:";
            // 
            // lblFirstName_UpdateUsers
            // 
            lblFirstName_UpdateUsers.AutoSize = true;
            lblFirstName_UpdateUsers.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblFirstName_UpdateUsers.ForeColor = SystemColors.ControlText;
            lblFirstName_UpdateUsers.Location = new Point(6, 183);
            lblFirstName_UpdateUsers.Name = "lblFirstName_UpdateUsers";
            lblFirstName_UpdateUsers.Size = new Size(179, 41);
            lblFirstName_UpdateUsers.TabIndex = 2;
            lblFirstName_UpdateUsers.Text = "First Name:";
            // 
            // lblUserName_UpdateUsers
            // 
            lblUserName_UpdateUsers.AutoSize = true;
            lblUserName_UpdateUsers.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblUserName_UpdateUsers.ForeColor = SystemColors.ControlText;
            lblUserName_UpdateUsers.Location = new Point(6, 125);
            lblUserName_UpdateUsers.Name = "lblUserName_UpdateUsers";
            lblUserName_UpdateUsers.Size = new Size(166, 41);
            lblUserName_UpdateUsers.TabIndex = 1;
            lblUserName_UpdateUsers.Text = "Username:";
            // 
            // DeleteUsers
            // 
            DeleteUsers.BackColor = Color.FromArgb(188, 170, 146);
            DeleteUsers.BackgroundImageLayout = ImageLayout.Zoom;
            DeleteUsers.Controls.Add(txtSearch_Delete);
            DeleteUsers.Controls.Add(label7);
            DeleteUsers.Controls.Add(label2);
            DeleteUsers.Controls.Add(pictureBox3);
            DeleteUsers.Controls.Add(btnBack_DeleteUsers);
            DeleteUsers.Controls.Add(btnClear_DeleteUsers);
            DeleteUsers.Controls.Add(btnDelete_DeleteUsers);
            DeleteUsers.Controls.Add(cmbUsername_DeleteUsers);
            DeleteUsers.Controls.Add(dgvDelete_DeleteUsers);
            DeleteUsers.Controls.Add(lblUserID_DeleteUser);
            DeleteUsers.Location = new Point(4, 29);
            DeleteUsers.Margin = new Padding(3, 4, 3, 4);
            DeleteUsers.Name = "DeleteUsers";
            DeleteUsers.Padding = new Padding(3, 4, 3, 4);
            DeleteUsers.Size = new Size(1019, 551);
            DeleteUsers.TabIndex = 2;
            DeleteUsers.Text = "Delete";
            // 
            // txtSearch_Delete
            // 
            txtSearch_Delete.Location = new Point(510, 42);
            txtSearch_Delete.Name = "txtSearch_Delete";
            txtSearch_Delete.Size = new Size(168, 27);
            txtSearch_Delete.TabIndex = 45;
            txtSearch_Delete.TextChanged += txtSearch_Delete_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(396, 31);
            label7.Name = "label7";
            label7.Size = new Size(119, 41);
            label7.TabIndex = 44;
            label7.Text = "Search:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(218, 46);
            label2.TabIndex = 43;
            label2.Text = "Delete Users";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            pictureBox3.Location = new Point(0, 448);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 103);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 42;
            pictureBox3.TabStop = false;
            // 
            // btnBack_DeleteUsers
            // 
            btnBack_DeleteUsers.Location = new Point(689, 489);
            btnBack_DeleteUsers.Margin = new Padding(3, 4, 3, 4);
            btnBack_DeleteUsers.Name = "btnBack_DeleteUsers";
            btnBack_DeleteUsers.Size = new Size(105, 53);
            btnBack_DeleteUsers.TabIndex = 21;
            btnBack_DeleteUsers.Text = "Back";
            btnBack_DeleteUsers.UseVisualStyleBackColor = true;
            btnBack_DeleteUsers.Click += btnBack_DeleteUsers_Click_1;
            // 
            // btnClear_DeleteUsers
            // 
            btnClear_DeleteUsers.Location = new Point(492, 490);
            btnClear_DeleteUsers.Margin = new Padding(3, 4, 3, 4);
            btnClear_DeleteUsers.Name = "btnClear_DeleteUsers";
            btnClear_DeleteUsers.Size = new Size(105, 53);
            btnClear_DeleteUsers.TabIndex = 20;
            btnClear_DeleteUsers.Text = "Clear";
            btnClear_DeleteUsers.UseVisualStyleBackColor = true;
            btnClear_DeleteUsers.Click += btnClear_DeleteUsers_Click;
            // 
            // btnDelete_DeleteUsers
            // 
            btnDelete_DeleteUsers.Location = new Point(288, 489);
            btnDelete_DeleteUsers.Margin = new Padding(3, 4, 3, 4);
            btnDelete_DeleteUsers.Name = "btnDelete_DeleteUsers";
            btnDelete_DeleteUsers.Size = new Size(105, 53);
            btnDelete_DeleteUsers.TabIndex = 19;
            btnDelete_DeleteUsers.Text = "Delete";
            btnDelete_DeleteUsers.UseVisualStyleBackColor = true;
            btnDelete_DeleteUsers.Click += btnDelete_DeleteUsers_Click;
            // 
            // cmbUsername_DeleteUsers
            // 
            cmbUsername_DeleteUsers.FormattingEnabled = true;
            cmbUsername_DeleteUsers.Location = new Point(492, 448);
            cmbUsername_DeleteUsers.Margin = new Padding(3, 4, 3, 4);
            cmbUsername_DeleteUsers.Name = "cmbUsername_DeleteUsers";
            cmbUsername_DeleteUsers.Size = new Size(196, 28);
            cmbUsername_DeleteUsers.TabIndex = 18;
            // 
            // dgvDelete_DeleteUsers
            // 
            dgvDelete_DeleteUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDelete_DeleteUsers.Location = new Point(288, 76);
            dgvDelete_DeleteUsers.Margin = new Padding(3, 4, 3, 4);
            dgvDelete_DeleteUsers.Name = "dgvDelete_DeleteUsers";
            dgvDelete_DeleteUsers.RowHeadersWidth = 51;
            dgvDelete_DeleteUsers.Size = new Size(506, 355);
            dgvDelete_DeleteUsers.TabIndex = 13;
            dgvDelete_DeleteUsers.CellClick += dgvDelete_DeleteUsers_CellClick;
            // 
            // lblUserID_DeleteUser
            // 
            lblUserID_DeleteUser.AutoSize = true;
            lblUserID_DeleteUser.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblUserID_DeleteUser.Location = new Point(396, 435);
            lblUserID_DeleteUser.Name = "lblUserID_DeleteUser";
            lblUserID_DeleteUser.Size = new Size(90, 41);
            lblUserID_DeleteUser.TabIndex = 17;
            lblUserID_DeleteUser.Text = "User:";
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 584);
            Controls.Add(MaintainUsers);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUsers";
            Load += frmUsers_Load;
            MaintainUsers.ResumeLayout(false);
            AddUser.ResumeLayout(false);
            AddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAddUsers).EndInit();
            UpdateUsers.ResumeLayout(false);
            UpdateUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateUsers).EndInit();
            DeleteUsers.ResumeLayout(false);
            DeleteUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDelete_DeleteUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl MaintainUsers;
        private TabPage AddUser;
        private TabPage UpdateUsers;
        private TabPage DeleteUsers;
        private Label lblUsername_AddUsers;
        private Label lblFirstName_Users;
        private Label lblCellNumber_Users;
        private Label lblLastName_Users;
        private TextBox txtCellNumber_AddUsers;
        private TextBox txtLastName_AddUsers;
        private TextBox txtFirstName_AddUsers;
        private TextBox txtUsername_AddUsers;
        private Button btnBack_AddUsers;
        private Button btnClear_AddUsers;
        private Button btnAdd_AddUsers;
        private DataGridView dgvAddUsers;
        private Label lblCellNumber_UpdateUsers;
        private Label lblLastName_UpdateUsers;
        private Label lblFirstName_UpdateUsers;
        private Label lblUserName_UpdateUsers;
        private TextBox txtCellNumber_UpdateUsers;
        private TextBox txtLastName_UpdateUsers;
        private TextBox txtFirstName_UpdateUsers;
        private TextBox txtUsername_UpdateUsers;
        private DataGridView dgvUpdateUsers;
        private Button btnBack_UpdateUsers;
        private Button btnClearUsers_UpdateUsers;
        private Button btnUpdateUsers_UpdateUsers;
        private Label lblUserID_UpdateUsers;
        private TextBox txtUserID_UpdateUsers;
        private DataGridView dgvDelete_DeleteUsers;
        private ComboBox cmbUsername_DeleteUsers;
        private Label lblUserID_DeleteUser;
        private Button btnBack_DeleteUsers;
        private Button btnClear_DeleteUsers;
        private Button btnDelete_DeleteUsers;
        private TextBox txtUserID_UpdateUser;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label10;
        private Label label1;
        private Label label2;
        private Label label7;
        private TextBox txtSearch_Add;
        private Label label4;
        private TextBox txtSearch_Update;
        private Label label3;
        private TextBox txtSearch_Delete;
    }
}