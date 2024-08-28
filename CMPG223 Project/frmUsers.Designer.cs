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
            cmbUserID_UpdateUser = new ComboBox();
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
            btnBack_DeleteUsers = new Button();
            btnClear_DeleteUsers = new Button();
            btnDelete_DeleteUsers = new Button();
            cmbUsername_DeleteUsers = new ComboBox();
            lblUserID_DeleteUser = new Label();
            dgvDelete_DeleteUsers = new DataGridView();
            MaintainUsers.SuspendLayout();
            AddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddUsers).BeginInit();
            UpdateUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateUsers).BeginInit();
            DeleteUsers.SuspendLayout();
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
            MaintainUsers.Size = new Size(1070, 523);
            MaintainUsers.TabIndex = 0;
            // 
            // AddUser
            // 
            AddUser.BackColor = Color.FromArgb(188, 170, 146);
            AddUser.BackgroundImage = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            AddUser.BackgroundImageLayout = ImageLayout.Zoom;
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
            AddUser.Size = new Size(1062, 490);
            AddUser.TabIndex = 0;
            AddUser.Text = "Add";
            AddUser.Click += AddUser_Click;
            // 
            // dgvAddUsers
            // 
            dgvAddUsers.Anchor = AnchorStyles.None;
            dgvAddUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddUsers.Location = new Point(563, 11);
            dgvAddUsers.Margin = new Padding(3, 4, 3, 4);
            dgvAddUsers.Name = "dgvAddUsers";
            dgvAddUsers.RowHeadersWidth = 51;
            dgvAddUsers.Size = new Size(437, 208);
            dgvAddUsers.TabIndex = 11;
            // 
            // btnBack_AddUsers
            // 
            btnBack_AddUsers.Anchor = AnchorStyles.None;
            btnBack_AddUsers.Location = new Point(512, 427);
            btnBack_AddUsers.Margin = new Padding(3, 4, 3, 4);
            btnBack_AddUsers.Name = "btnBack_AddUsers";
            btnBack_AddUsers.Size = new Size(86, 31);
            btnBack_AddUsers.TabIndex = 10;
            btnBack_AddUsers.Text = "Back";
            btnBack_AddUsers.UseVisualStyleBackColor = true;
            // 
            // btnClear_AddUsers
            // 
            btnClear_AddUsers.Anchor = AnchorStyles.None;
            btnClear_AddUsers.Location = new Point(563, 361);
            btnClear_AddUsers.Margin = new Padding(3, 4, 3, 4);
            btnClear_AddUsers.Name = "btnClear_AddUsers";
            btnClear_AddUsers.Size = new Size(86, 31);
            btnClear_AddUsers.TabIndex = 9;
            btnClear_AddUsers.Text = "Clear";
            btnClear_AddUsers.UseVisualStyleBackColor = true;
            btnClear_AddUsers.Click += btnClear_AddUsers_Click;
            // 
            // btnAdd_AddUsers
            // 
            btnAdd_AddUsers.Anchor = AnchorStyles.None;
            btnAdd_AddUsers.Location = new Point(451, 361);
            btnAdd_AddUsers.Margin = new Padding(3, 4, 3, 4);
            btnAdd_AddUsers.Name = "btnAdd_AddUsers";
            btnAdd_AddUsers.Size = new Size(86, 31);
            btnAdd_AddUsers.TabIndex = 8;
            btnAdd_AddUsers.Text = "Add";
            btnAdd_AddUsers.UseVisualStyleBackColor = true;
            btnAdd_AddUsers.Click += btnAdd_AddUsers_Click;
            // 
            // txtCellNumber_AddUsers
            // 
            txtCellNumber_AddUsers.Anchor = AnchorStyles.None;
            txtCellNumber_AddUsers.Location = new Point(266, 195);
            txtCellNumber_AddUsers.Margin = new Padding(3, 4, 3, 4);
            txtCellNumber_AddUsers.Name = "txtCellNumber_AddUsers";
            txtCellNumber_AddUsers.Size = new Size(196, 27);
            txtCellNumber_AddUsers.TabIndex = 7;
            // 
            // txtLastName_AddUsers
            // 
            txtLastName_AddUsers.Anchor = AnchorStyles.None;
            txtLastName_AddUsers.Location = new Point(266, 137);
            txtLastName_AddUsers.Margin = new Padding(3, 4, 3, 4);
            txtLastName_AddUsers.Name = "txtLastName_AddUsers";
            txtLastName_AddUsers.Size = new Size(196, 27);
            txtLastName_AddUsers.TabIndex = 6;
            // 
            // txtFirstName_AddUsers
            // 
            txtFirstName_AddUsers.Anchor = AnchorStyles.None;
            txtFirstName_AddUsers.Location = new Point(266, 83);
            txtFirstName_AddUsers.Margin = new Padding(3, 4, 3, 4);
            txtFirstName_AddUsers.Name = "txtFirstName_AddUsers";
            txtFirstName_AddUsers.Size = new Size(196, 27);
            txtFirstName_AddUsers.TabIndex = 5;
            // 
            // txtUsername_AddUsers
            // 
            txtUsername_AddUsers.Anchor = AnchorStyles.None;
            txtUsername_AddUsers.Location = new Point(266, 23);
            txtUsername_AddUsers.Margin = new Padding(3, 4, 3, 4);
            txtUsername_AddUsers.Name = "txtUsername_AddUsers";
            txtUsername_AddUsers.Size = new Size(196, 27);
            txtUsername_AddUsers.TabIndex = 4;
            // 
            // lblCellNumber_Users
            // 
            lblCellNumber_Users.Anchor = AnchorStyles.None;
            lblCellNumber_Users.AutoSize = true;
            lblCellNumber_Users.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCellNumber_Users.Location = new Point(8, 180);
            lblCellNumber_Users.Name = "lblCellNumber_Users";
            lblCellNumber_Users.Size = new Size(204, 41);
            lblCellNumber_Users.TabIndex = 3;
            lblCellNumber_Users.Text = "Cell Number:";
            // 
            // lblLastName_Users
            // 
            lblLastName_Users.Anchor = AnchorStyles.None;
            lblLastName_Users.AutoSize = true;
            lblLastName_Users.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLastName_Users.Location = new Point(8, 123);
            lblLastName_Users.Name = "lblLastName_Users";
            lblLastName_Users.Size = new Size(173, 41);
            lblLastName_Users.TabIndex = 2;
            lblLastName_Users.Text = "Last Name:";
            // 
            // lblFirstName_Users
            // 
            lblFirstName_Users.Anchor = AnchorStyles.None;
            lblFirstName_Users.AutoSize = true;
            lblFirstName_Users.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblFirstName_Users.Location = new Point(8, 68);
            lblFirstName_Users.Name = "lblFirstName_Users";
            lblFirstName_Users.Size = new Size(179, 41);
            lblFirstName_Users.TabIndex = 1;
            lblFirstName_Users.Text = "First Name:";
            // 
            // lblUsername_AddUsers
            // 
            lblUsername_AddUsers.Anchor = AnchorStyles.None;
            lblUsername_AddUsers.AutoSize = true;
            lblUsername_AddUsers.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblUsername_AddUsers.Location = new Point(8, 11);
            lblUsername_AddUsers.Name = "lblUsername_AddUsers";
            lblUsername_AddUsers.Size = new Size(166, 41);
            lblUsername_AddUsers.TabIndex = 0;
            lblUsername_AddUsers.Text = "Username:";
            // 
            // UpdateUsers
            // 
            UpdateUsers.BackColor = Color.FromArgb(188, 170, 146);
            UpdateUsers.BackgroundImage = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            UpdateUsers.BackgroundImageLayout = ImageLayout.Zoom;
            UpdateUsers.Controls.Add(cmbUserID_UpdateUser);
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
            UpdateUsers.Size = new Size(1062, 490);
            UpdateUsers.TabIndex = 1;
            UpdateUsers.Text = "Update";
            // 
            // cmbUserID_UpdateUser
            // 
            cmbUserID_UpdateUser.FormattingEnabled = true;
            cmbUserID_UpdateUser.Location = new Point(225, 28);
            cmbUserID_UpdateUser.Margin = new Padding(3, 4, 3, 4);
            cmbUserID_UpdateUser.Name = "cmbUserID_UpdateUser";
            cmbUserID_UpdateUser.Size = new Size(196, 28);
            cmbUserID_UpdateUser.TabIndex = 17;
            // 
            // lblUserID_UpdateUsers
            // 
            lblUserID_UpdateUsers.AutoSize = true;
            lblUserID_UpdateUsers.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblUserID_UpdateUsers.ForeColor = SystemColors.ControlText;
            lblUserID_UpdateUsers.Location = new Point(9, 16);
            lblUserID_UpdateUsers.Name = "lblUserID_UpdateUsers";
            lblUserID_UpdateUsers.Size = new Size(129, 41);
            lblUserID_UpdateUsers.TabIndex = 16;
            lblUserID_UpdateUsers.Text = "User ID:";
            // 
            // btnBack_UpdateUsers
            // 
            btnBack_UpdateUsers.Anchor = AnchorStyles.None;
            btnBack_UpdateUsers.Location = new Point(491, 395);
            btnBack_UpdateUsers.Margin = new Padding(3, 4, 3, 4);
            btnBack_UpdateUsers.Name = "btnBack_UpdateUsers";
            btnBack_UpdateUsers.Size = new Size(86, 31);
            btnBack_UpdateUsers.TabIndex = 15;
            btnBack_UpdateUsers.Text = "Back";
            btnBack_UpdateUsers.UseVisualStyleBackColor = true;
            // 
            // btnClearUsers_UpdateUsers
            // 
            btnClearUsers_UpdateUsers.Anchor = AnchorStyles.None;
            btnClearUsers_UpdateUsers.Location = new Point(552, 335);
            btnClearUsers_UpdateUsers.Margin = new Padding(3, 4, 3, 4);
            btnClearUsers_UpdateUsers.Name = "btnClearUsers_UpdateUsers";
            btnClearUsers_UpdateUsers.Size = new Size(86, 31);
            btnClearUsers_UpdateUsers.TabIndex = 14;
            btnClearUsers_UpdateUsers.Text = "Clear";
            btnClearUsers_UpdateUsers.UseVisualStyleBackColor = true;
            // 
            // btnUpdateUsers_UpdateUsers
            // 
            btnUpdateUsers_UpdateUsers.Anchor = AnchorStyles.None;
            btnUpdateUsers_UpdateUsers.Location = new Point(435, 335);
            btnUpdateUsers_UpdateUsers.Margin = new Padding(3, 4, 3, 4);
            btnUpdateUsers_UpdateUsers.Name = "btnUpdateUsers_UpdateUsers";
            btnUpdateUsers_UpdateUsers.Size = new Size(86, 31);
            btnUpdateUsers_UpdateUsers.TabIndex = 13;
            btnUpdateUsers_UpdateUsers.Text = "Update";
            btnUpdateUsers_UpdateUsers.UseVisualStyleBackColor = true;
            // 
            // dgvUpdateUsers
            // 
            dgvUpdateUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUpdateUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpdateUsers.Location = new Point(538, 31);
            dgvUpdateUsers.Margin = new Padding(3, 4, 3, 4);
            dgvUpdateUsers.Name = "dgvUpdateUsers";
            dgvUpdateUsers.RowHeadersWidth = 51;
            dgvUpdateUsers.Size = new Size(499, 163);
            dgvUpdateUsers.TabIndex = 12;
            // 
            // txtCellNumber_UpdateUsers
            // 
            txtCellNumber_UpdateUsers.Location = new Point(225, 252);
            txtCellNumber_UpdateUsers.Margin = new Padding(3, 4, 3, 4);
            txtCellNumber_UpdateUsers.Name = "txtCellNumber_UpdateUsers";
            txtCellNumber_UpdateUsers.Size = new Size(196, 27);
            txtCellNumber_UpdateUsers.TabIndex = 8;
            // 
            // txtLastName_UpdateUsers
            // 
            txtLastName_UpdateUsers.Location = new Point(225, 195);
            txtLastName_UpdateUsers.Margin = new Padding(3, 4, 3, 4);
            txtLastName_UpdateUsers.Name = "txtLastName_UpdateUsers";
            txtLastName_UpdateUsers.Size = new Size(196, 27);
            txtLastName_UpdateUsers.TabIndex = 7;
            // 
            // txtFirstName_UpdateUsers
            // 
            txtFirstName_UpdateUsers.Location = new Point(225, 139);
            txtFirstName_UpdateUsers.Margin = new Padding(3, 4, 3, 4);
            txtFirstName_UpdateUsers.Name = "txtFirstName_UpdateUsers";
            txtFirstName_UpdateUsers.Size = new Size(196, 27);
            txtFirstName_UpdateUsers.TabIndex = 6;
            // 
            // txtUsername_UpdateUsers
            // 
            txtUsername_UpdateUsers.Location = new Point(225, 81);
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
            lblCellNumber_UpdateUsers.Location = new Point(7, 240);
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
            lblLastName_UpdateUsers.Location = new Point(9, 183);
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
            lblFirstName_UpdateUsers.Location = new Point(9, 127);
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
            lblUserName_UpdateUsers.Location = new Point(9, 69);
            lblUserName_UpdateUsers.Name = "lblUserName_UpdateUsers";
            lblUserName_UpdateUsers.Size = new Size(166, 41);
            lblUserName_UpdateUsers.TabIndex = 1;
            lblUserName_UpdateUsers.Text = "Username:";
            // 
            // DeleteUsers
            // 
            DeleteUsers.BackColor = Color.FromArgb(188, 170, 146);
            DeleteUsers.BackgroundImage = Properties.Resources.e1aab579_d2ed_4896_8ccf_1b708d71abc9;
            DeleteUsers.BackgroundImageLayout = ImageLayout.Zoom;
            DeleteUsers.Controls.Add(btnBack_DeleteUsers);
            DeleteUsers.Controls.Add(btnClear_DeleteUsers);
            DeleteUsers.Controls.Add(btnDelete_DeleteUsers);
            DeleteUsers.Controls.Add(cmbUsername_DeleteUsers);
            DeleteUsers.Controls.Add(lblUserID_DeleteUser);
            DeleteUsers.Controls.Add(dgvDelete_DeleteUsers);
            DeleteUsers.Location = new Point(4, 29);
            DeleteUsers.Margin = new Padding(3, 4, 3, 4);
            DeleteUsers.Name = "DeleteUsers";
            DeleteUsers.Padding = new Padding(3, 4, 3, 4);
            DeleteUsers.Size = new Size(1062, 490);
            DeleteUsers.TabIndex = 2;
            DeleteUsers.Text = "Delete";
            DeleteUsers.Click += DeleteUsers_Click;
            // 
            // btnBack_DeleteUsers
            // 
            btnBack_DeleteUsers.Anchor = AnchorStyles.None;
            btnBack_DeleteUsers.Location = new Point(491, 415);
            btnBack_DeleteUsers.Margin = new Padding(3, 4, 3, 4);
            btnBack_DeleteUsers.Name = "btnBack_DeleteUsers";
            btnBack_DeleteUsers.Size = new Size(86, 31);
            btnBack_DeleteUsers.TabIndex = 21;
            btnBack_DeleteUsers.Text = "Back";
            btnBack_DeleteUsers.UseVisualStyleBackColor = true;
            // 
            // btnClear_DeleteUsers
            // 
            btnClear_DeleteUsers.Anchor = AnchorStyles.None;
            btnClear_DeleteUsers.Location = new Point(547, 363);
            btnClear_DeleteUsers.Margin = new Padding(3, 4, 3, 4);
            btnClear_DeleteUsers.Name = "btnClear_DeleteUsers";
            btnClear_DeleteUsers.Size = new Size(86, 31);
            btnClear_DeleteUsers.TabIndex = 20;
            btnClear_DeleteUsers.Text = "Clear";
            btnClear_DeleteUsers.UseVisualStyleBackColor = true;
            // 
            // btnDelete_DeleteUsers
            // 
            btnDelete_DeleteUsers.Anchor = AnchorStyles.None;
            btnDelete_DeleteUsers.Location = new Point(432, 363);
            btnDelete_DeleteUsers.Margin = new Padding(3, 4, 3, 4);
            btnDelete_DeleteUsers.Name = "btnDelete_DeleteUsers";
            btnDelete_DeleteUsers.Size = new Size(86, 31);
            btnDelete_DeleteUsers.TabIndex = 19;
            btnDelete_DeleteUsers.Text = "Delete";
            btnDelete_DeleteUsers.UseVisualStyleBackColor = true;
            btnDelete_DeleteUsers.Click += btnDelete_DeleteUsers_Click;
            // 
            // cmbUsername_DeleteUsers
            // 
            cmbUsername_DeleteUsers.Anchor = AnchorStyles.None;
            cmbUsername_DeleteUsers.FormattingEnabled = true;
            cmbUsername_DeleteUsers.Location = new Point(521, 315);
            cmbUsername_DeleteUsers.Margin = new Padding(3, 4, 3, 4);
            cmbUsername_DeleteUsers.Name = "cmbUsername_DeleteUsers";
            cmbUsername_DeleteUsers.Size = new Size(196, 28);
            cmbUsername_DeleteUsers.TabIndex = 18;
            cmbUsername_DeleteUsers.SelectedIndexChanged += cmbUsername_DeleteUsers_SelectedIndexChanged;
            // 
            // lblUserID_DeleteUser
            // 
            lblUserID_DeleteUser.Anchor = AnchorStyles.None;
            lblUserID_DeleteUser.AutoSize = true;
            lblUserID_DeleteUser.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblUserID_DeleteUser.Location = new Point(358, 303);
            lblUserID_DeleteUser.Name = "lblUserID_DeleteUser";
            lblUserID_DeleteUser.Size = new Size(90, 41);
            lblUserID_DeleteUser.TabIndex = 17;
            lblUserID_DeleteUser.Text = "User:";
            // 
            // dgvDelete_DeleteUsers
            // 
            dgvDelete_DeleteUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDelete_DeleteUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDelete_DeleteUsers.Location = new Point(237, 33);
            dgvDelete_DeleteUsers.Margin = new Padding(3, 4, 3, 4);
            dgvDelete_DeleteUsers.Name = "dgvDelete_DeleteUsers";
            dgvDelete_DeleteUsers.RowHeadersWidth = 51;
            dgvDelete_DeleteUsers.Size = new Size(589, 223);
            dgvDelete_DeleteUsers.TabIndex = 13;
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 523);
            Controls.Add(MaintainUsers);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmUsers";
            Text = "frmUsers";
            Load += frmUsers_Load;
            MaintainUsers.ResumeLayout(false);
            AddUser.ResumeLayout(false);
            AddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddUsers).EndInit();
            UpdateUsers.ResumeLayout(false);
            UpdateUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpdateUsers).EndInit();
            DeleteUsers.ResumeLayout(false);
            DeleteUsers.PerformLayout();
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
        private ComboBox cmbUserID_UpdateUser;
        private ComboBox cmbUsername_DeleteUsers;
        private Label lblUserID_DeleteUser;
        private Button btnBack_DeleteUsers;
        private Button btnClear_DeleteUsers;
        private Button btnDelete_DeleteUsers;
    }
}