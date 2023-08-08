namespace LibraryManagement2023
{
    partial class FormUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            this.toolStripUsers = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFamily = new System.Windows.Forms.TextBox();
            this.comboBoxAccess = new System.Windows.Forms.ComboBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGVUsers = new System.Windows.Forms.DataGridView();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_access = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditUser = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonDeleteUser = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripUsers.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripUsers
            // 
            this.toolStripUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonRefresh});
            this.toolStripUsers.Location = new System.Drawing.Point(0, 0);
            this.toolStripUsers.Name = "toolStripUsers";
            this.toolStripUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripUsers.Size = new System.Drawing.Size(1007, 25);
            this.toolStripUsers.TabIndex = 0;
            this.toolStripUsers.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(523, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "رمز عبور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(767, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام خانوادگی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(967, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "نام";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(650, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "نام کاربری";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(357, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "سطح دسترسی";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(285, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "سن";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(101, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "شماره موبایل";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(482, 66);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPassword.Size = new System.Drawing.Size(106, 22);
            this.textBoxPassword.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(621, 66);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxUsername.Size = new System.Drawing.Size(106, 22);
            this.textBoxUsername.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(889, 66);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxName.Size = new System.Drawing.Size(106, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxFamily
            // 
            this.textBoxFamily.Location = new System.Drawing.Point(754, 66);
            this.textBoxFamily.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFamily.Name = "textBoxFamily";
            this.textBoxFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxFamily.Size = new System.Drawing.Size(106, 22);
            this.textBoxFamily.TabIndex = 2;
            // 
            // comboBoxAccess
            // 
            this.comboBoxAccess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAccess.FormattingEnabled = true;
            this.comboBoxAccess.Items.AddRange(new object[] {
            "کاربر ساده",
            "مدیر"});
            this.comboBoxAccess.Location = new System.Drawing.Point(347, 64);
            this.comboBoxAccess.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAccess.Name = "comboBoxAccess";
            this.comboBoxAccess.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxAccess.Size = new System.Drawing.Size(106, 24);
            this.comboBoxAccess.TabIndex = 3;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(212, 64);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAge.MaxLength = 3;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxAge.Size = new System.Drawing.Size(106, 22);
            this.textBoxAge.TabIndex = 2;
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Location = new System.Drawing.Point(84, 64);
            this.textBoxMobile.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMobile.MaxLength = 11;
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxMobile.Size = new System.Drawing.Size(106, 22);
            this.textBoxMobile.TabIndex = 2;
            this.textBoxMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMobile_KeyPress);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Controls.Add(this.label8);
            this.groupBoxSearch.Location = new System.Drawing.Point(13, 112);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxSearch.Size = new System.Drawing.Size(981, 48);
            this.groupBoxSearch.TabIndex = 5;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "جستجوی کلی";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(644, 16);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(167, 22);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Zar", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(817, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "پیدا کن";
            // 
            // dataGVUsers
            // 
            this.dataGVUsers.AllowUserToAddRows = false;
            this.dataGVUsers.AllowUserToDeleteRows = false;
            this.dataGVUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.user_name,
            this.user_family,
            this.user_userName,
            this.user_password,
            this.user_access,
            this.user_age,
            this.user_mobile,
            this.buttonEditUser,
            this.buttonDeleteUser});
            this.dataGVUsers.Location = new System.Drawing.Point(12, 168);
            this.dataGVUsers.Name = "dataGVUsers";
            this.dataGVUsers.ReadOnly = true;
            this.dataGVUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGVUsers.Size = new System.Drawing.Size(983, 392);
            this.dataGVUsers.TabIndex = 6;
            this.dataGVUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVUsers_CellContentClick);
            this.dataGVUsers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGVUsers_CellFormatting);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(12, 45);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(65, 41);
            this.buttonAddUser.TabIndex = 7;
            this.buttonAddUser.Text = "افزودن";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "UserID";
            this.user_id.HeaderText = "شناسه";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            // 
            // user_name
            // 
            this.user_name.DataPropertyName = "Name";
            this.user_name.HeaderText = "نام";
            this.user_name.Name = "user_name";
            this.user_name.ReadOnly = true;
            // 
            // user_family
            // 
            this.user_family.DataPropertyName = "Family";
            this.user_family.HeaderText = "نام خانوادگی";
            this.user_family.Name = "user_family";
            this.user_family.ReadOnly = true;
            // 
            // user_userName
            // 
            this.user_userName.DataPropertyName = "Username";
            this.user_userName.HeaderText = "نام کاربری";
            this.user_userName.Name = "user_userName";
            this.user_userName.ReadOnly = true;
            // 
            // user_password
            // 
            this.user_password.DataPropertyName = "Password";
            this.user_password.HeaderText = "رمز عبور";
            this.user_password.Name = "user_password";
            this.user_password.ReadOnly = true;
            // 
            // user_access
            // 
            this.user_access.DataPropertyName = "Access";
            this.user_access.HeaderText = "سطح دسترسی";
            this.user_access.Name = "user_access";
            this.user_access.ReadOnly = true;
            // 
            // user_age
            // 
            this.user_age.DataPropertyName = "Age";
            this.user_age.HeaderText = "سن";
            this.user_age.Name = "user_age";
            this.user_age.ReadOnly = true;
            // 
            // user_mobile
            // 
            this.user_mobile.DataPropertyName = "Mobile";
            this.user_mobile.HeaderText = "موبایل";
            this.user_mobile.Name = "user_mobile";
            this.user_mobile.ReadOnly = true;
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.HeaderText = "ویرایش";
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.ReadOnly = true;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.HeaderText = "حذف";
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.ReadOnly = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(69, 22);
            this.buttonRefresh.Text = "به روزرسانی";
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1007, 572);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.dataGVUsers);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.comboBoxAccess);
            this.Controls.Add(this.textBoxMobile);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxFamily);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStripUsers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کاربران";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            this.toolStripUsers.ResumeLayout(false);
            this.toolStripUsers.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFamily;
        private System.Windows.Forms.ComboBox comboBoxAccess;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxMobile;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.DataGridView dataGVUsers;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.ToolStripButton buttonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_family;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_access;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_mobile;
        private System.Windows.Forms.DataGridViewButtonColumn buttonEditUser;
        private System.Windows.Forms.DataGridViewButtonColumn buttonDeleteUser;
    }
}