namespace LibraryManagement2023
{
    partial class FormMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMembers));
            this.toolStripMembers = new System.Windows.Forms.ToolStrip();
            this.buttonRefresh = new System.Windows.Forms.ToolStripButton();
            this.dataGVMembers = new System.Windows.Forms.DataGridView();
            this.member_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_codeMeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditMember = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonDeleteMember = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFamily = new System.Windows.Forms.TextBox();
            this.textBoxCodemeli = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.toolStripMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMembers)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMembers
            // 
            this.toolStripMembers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonRefresh});
            this.toolStripMembers.Location = new System.Drawing.Point(0, 0);
            this.toolStripMembers.Name = "toolStripMembers";
            this.toolStripMembers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripMembers.Size = new System.Drawing.Size(988, 25);
            this.toolStripMembers.TabIndex = 0;
            this.toolStripMembers.Text = "toolStrip1";
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
            // dataGVMembers
            // 
            this.dataGVMembers.AllowUserToAddRows = false;
            this.dataGVMembers.AllowUserToDeleteRows = false;
            this.dataGVMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVMembers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGVMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.member_id,
            this.member_name,
            this.member_family,
            this.member_codeMeli,
            this.member_age,
            this.member_mobile,
            this.member_address,
            this.buttonEditMember,
            this.buttonDeleteMember});
            this.dataGVMembers.Location = new System.Drawing.Point(12, 168);
            this.dataGVMembers.Name = "dataGVMembers";
            this.dataGVMembers.ReadOnly = true;
            this.dataGVMembers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGVMembers.Size = new System.Drawing.Size(964, 392);
            this.dataGVMembers.TabIndex = 1;
            this.dataGVMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVMembers_CellContentClick);
            // 
            // member_id
            // 
            this.member_id.DataPropertyName = "MemberID";
            this.member_id.HeaderText = "شناسه";
            this.member_id.Name = "member_id";
            this.member_id.ReadOnly = true;
            // 
            // member_name
            // 
            this.member_name.DataPropertyName = "Name";
            this.member_name.HeaderText = "نام";
            this.member_name.Name = "member_name";
            this.member_name.ReadOnly = true;
            // 
            // member_family
            // 
            this.member_family.DataPropertyName = "Family";
            this.member_family.HeaderText = "نام خانوادگی";
            this.member_family.Name = "member_family";
            this.member_family.ReadOnly = true;
            // 
            // member_codeMeli
            // 
            this.member_codeMeli.DataPropertyName = "Codemeli";
            this.member_codeMeli.HeaderText = "کد ملی";
            this.member_codeMeli.Name = "member_codeMeli";
            this.member_codeMeli.ReadOnly = true;
            // 
            // member_age
            // 
            this.member_age.DataPropertyName = "Age";
            this.member_age.HeaderText = "سن";
            this.member_age.Name = "member_age";
            this.member_age.ReadOnly = true;
            // 
            // member_mobile
            // 
            this.member_mobile.DataPropertyName = "Mobile";
            this.member_mobile.HeaderText = "موبایل";
            this.member_mobile.Name = "member_mobile";
            this.member_mobile.ReadOnly = true;
            // 
            // member_address
            // 
            this.member_address.DataPropertyName = "Address";
            this.member_address.HeaderText = "آدرس";
            this.member_address.Name = "member_address";
            this.member_address.ReadOnly = true;
            // 
            // buttonEditMember
            // 
            this.buttonEditMember.HeaderText = "ویرایش";
            this.buttonEditMember.Name = "buttonEditMember";
            this.buttonEditMember.ReadOnly = true;
            // 
            // buttonDeleteMember
            // 
            this.buttonDeleteMember.HeaderText = "حذف";
            this.buttonDeleteMember.Name = "buttonDeleteMember";
            this.buttonDeleteMember.ReadOnly = true;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Controls.Add(this.label1);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 114);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxSearch.Size = new System.Drawing.Size(964, 48);
            this.groupBoxSearch.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Zar", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(817, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "پیدا کن";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(948, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(730, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "نام خانوادگی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(614, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "کد ملی";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(478, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "سن";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(268, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 27);
            this.label6.TabIndex = 3;
            this.label6.Text = "شماره موبایل";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(158, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 27);
            this.label7.TabIndex = 3;
            this.label7.Text = "آدرس";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(852, 66);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxName.Size = new System.Drawing.Size(124, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxFamily
            // 
            this.textBoxFamily.Location = new System.Drawing.Point(699, 66);
            this.textBoxFamily.Name = "textBoxFamily";
            this.textBoxFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxFamily.Size = new System.Drawing.Size(124, 22);
            this.textBoxFamily.TabIndex = 4;
            // 
            // textBoxCodemeli
            // 
            this.textBoxCodemeli.Location = new System.Drawing.Point(548, 66);
            this.textBoxCodemeli.MaxLength = 10;
            this.textBoxCodemeli.Name = "textBoxCodemeli";
            this.textBoxCodemeli.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCodemeli.Size = new System.Drawing.Size(124, 22);
            this.textBoxCodemeli.TabIndex = 4;
            this.textBoxCodemeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodemeli_KeyPress);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(387, 66);
            this.textBoxAge.MaxLength = 3;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxAge.Size = new System.Drawing.Size(124, 22);
            this.textBoxAge.TabIndex = 4;
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Location = new System.Drawing.Point(233, 66);
            this.textBoxMobile.MaxLength = 11;
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxMobile.Size = new System.Drawing.Size(124, 22);
            this.textBoxMobile.TabIndex = 4;
            this.textBoxMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMobile_KeyPress);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(85, 65);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxAddress.Size = new System.Drawing.Size(124, 22);
            this.textBoxAddress.TabIndex = 4;
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.Location = new System.Drawing.Point(12, 50);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(66, 38);
            this.buttonAddMember.TabIndex = 5;
            this.buttonAddMember.Text = "افزودن";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            this.buttonAddMember.Click += new System.EventHandler(this.buttonAddMember_Click);
            // 
            // FormMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(988, 572);
            this.Controls.Add(this.buttonAddMember);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxMobile);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxCodemeli);
            this.Controls.Add(this.textBoxFamily);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.dataGVMembers);
            this.Controls.Add(this.toolStripMembers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعضا";
            this.Load += new System.EventHandler(this.FormMembers_Load);
            this.toolStripMembers.ResumeLayout(false);
            this.toolStripMembers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMembers)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMembers;
        private System.Windows.Forms.ToolStripButton buttonRefresh;
        private System.Windows.Forms.DataGridView dataGVMembers;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFamily;
        private System.Windows.Forms.TextBox textBoxCodemeli;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxMobile;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button buttonAddMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_family;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_codeMeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_address;
        private System.Windows.Forms.DataGridViewButtonColumn buttonEditMember;
        private System.Windows.Forms.DataGridViewButtonColumn buttonDeleteMember;
    }
}