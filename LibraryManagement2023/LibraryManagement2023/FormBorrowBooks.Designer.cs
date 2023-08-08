namespace LibraryManagement2023
{
    partial class FormBorrowBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBorrowBooks));
            this.toolStripBorrowBooks = new System.Windows.Forms.ToolStrip();
            this.buttonRefresh = new System.Windows.Forms.ToolStripButton();
            this.dataGVBorrow = new System.Windows.Forms.DataGridView();
            this.borrow_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrow_bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrow_memberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrow_userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrow_borrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrow_returnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrow_givenBack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrow_bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrow_memberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrow_userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditBorrow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonDeleteBorrow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddBorrow = new System.Windows.Forms.Button();
            this.comboBoxGivenback = new System.Windows.Forms.ComboBox();
            this.dateTimeBorrow = new Atf.UI.DateTimeSelector();
            this.dateTimeReturn = new Atf.UI.DateTimeSelector();
            this.comboBoxMemberID = new System.Windows.Forms.ComboBox();
            this.comboBoxBookID = new System.Windows.Forms.ComboBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStripBorrowBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVBorrow)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripBorrowBooks
            // 
            this.toolStripBorrowBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonRefresh});
            this.toolStripBorrowBooks.Location = new System.Drawing.Point(0, 0);
            this.toolStripBorrowBooks.Name = "toolStripBorrowBooks";
            this.toolStripBorrowBooks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripBorrowBooks.Size = new System.Drawing.Size(980, 25);
            this.toolStripBorrowBooks.TabIndex = 0;
            this.toolStripBorrowBooks.Text = "toolStrip1";
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
            // dataGVBorrow
            // 
            this.dataGVBorrow.AllowUserToAddRows = false;
            this.dataGVBorrow.AllowUserToDeleteRows = false;
            this.dataGVBorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVBorrow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGVBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrow_id,
            this.borrow_bookId,
            this.borrow_memberId,
            this.borrow_userId,
            this.borrow_borrowDate,
            this.borrow_returnDate,
            this.borrow_givenBack,
            this.borrow_bookName,
            this.borrow_memberName,
            this.borrow_userName,
            this.buttonEditBorrow,
            this.buttonDeleteBorrow});
            this.dataGVBorrow.Location = new System.Drawing.Point(12, 168);
            this.dataGVBorrow.Name = "dataGVBorrow";
            this.dataGVBorrow.ReadOnly = true;
            this.dataGVBorrow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGVBorrow.Size = new System.Drawing.Size(956, 392);
            this.dataGVBorrow.TabIndex = 1;
            this.dataGVBorrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVBorrow_CellContentClick);
            this.dataGVBorrow.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGVBorrow_CellFormatting);
            // 
            // borrow_id
            // 
            this.borrow_id.DataPropertyName = "BorrowID";
            this.borrow_id.HeaderText = "شناسه";
            this.borrow_id.Name = "borrow_id";
            this.borrow_id.ReadOnly = true;
            // 
            // borrow_bookId
            // 
            this.borrow_bookId.DataPropertyName = "BookID";
            this.borrow_bookId.HeaderText = "شناسه کتاب";
            this.borrow_bookId.Name = "borrow_bookId";
            this.borrow_bookId.ReadOnly = true;
            this.borrow_bookId.Visible = false;
            // 
            // borrow_memberId
            // 
            this.borrow_memberId.DataPropertyName = "MemberID";
            this.borrow_memberId.HeaderText = "شناسه عضو";
            this.borrow_memberId.Name = "borrow_memberId";
            this.borrow_memberId.ReadOnly = true;
            this.borrow_memberId.Visible = false;
            // 
            // borrow_userId
            // 
            this.borrow_userId.DataPropertyName = "UserID";
            this.borrow_userId.HeaderText = "شناسه کاربر";
            this.borrow_userId.Name = "borrow_userId";
            this.borrow_userId.ReadOnly = true;
            this.borrow_userId.Visible = false;
            // 
            // borrow_borrowDate
            // 
            this.borrow_borrowDate.DataPropertyName = "BorrowDate";
            this.borrow_borrowDate.HeaderText = "تاریخ امانت";
            this.borrow_borrowDate.Name = "borrow_borrowDate";
            this.borrow_borrowDate.ReadOnly = true;
            // 
            // borrow_returnDate
            // 
            this.borrow_returnDate.DataPropertyName = "ReturnDate";
            this.borrow_returnDate.HeaderText = "تاریخ برگشت";
            this.borrow_returnDate.Name = "borrow_returnDate";
            this.borrow_returnDate.ReadOnly = true;
            // 
            // borrow_givenBack
            // 
            this.borrow_givenBack.DataPropertyName = "Givenback";
            this.borrow_givenBack.HeaderText = "وضعیت تحویل";
            this.borrow_givenBack.Name = "borrow_givenBack";
            this.borrow_givenBack.ReadOnly = true;
            // 
            // borrow_bookName
            // 
            this.borrow_bookName.DataPropertyName = "BookName";
            this.borrow_bookName.HeaderText = "نام کتاب";
            this.borrow_bookName.Name = "borrow_bookName";
            this.borrow_bookName.ReadOnly = true;
            // 
            // borrow_memberName
            // 
            this.borrow_memberName.DataPropertyName = "MemberName";
            this.borrow_memberName.HeaderText = "نام عضو";
            this.borrow_memberName.Name = "borrow_memberName";
            this.borrow_memberName.ReadOnly = true;
            // 
            // borrow_userName
            // 
            this.borrow_userName.DataPropertyName = "UserName";
            this.borrow_userName.HeaderText = "نام کاربر";
            this.borrow_userName.Name = "borrow_userName";
            this.borrow_userName.ReadOnly = true;
            // 
            // buttonEditBorrow
            // 
            this.buttonEditBorrow.HeaderText = "ویرایش";
            this.buttonEditBorrow.Name = "buttonEditBorrow";
            this.buttonEditBorrow.ReadOnly = true;
            // 
            // buttonDeleteBorrow
            // 
            this.buttonDeleteBorrow.HeaderText = "حذف";
            this.buttonDeleteBorrow.Name = "buttonDeleteBorrow";
            this.buttonDeleteBorrow.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(900, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام عضو";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(714, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام کتاب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(514, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاریخ امانت";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(330, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "تاریخ برگشت";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(152, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "وضعیت تحویل";
            // 
            // buttonAddBorrow
            // 
            this.buttonAddBorrow.Location = new System.Drawing.Point(12, 48);
            this.buttonAddBorrow.Name = "buttonAddBorrow";
            this.buttonAddBorrow.Size = new System.Drawing.Size(78, 41);
            this.buttonAddBorrow.TabIndex = 3;
            this.buttonAddBorrow.Text = "افزودن";
            this.buttonAddBorrow.UseVisualStyleBackColor = true;
            this.buttonAddBorrow.Click += new System.EventHandler(this.buttonAddBorrow_Click);
            // 
            // comboBoxGivenback
            // 
            this.comboBoxGivenback.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGivenback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGivenback.FormattingEnabled = true;
            this.comboBoxGivenback.Items.AddRange(new object[] {
            "در دست امانت",
            "برگشت داده شده"});
            this.comboBoxGivenback.Location = new System.Drawing.Point(133, 65);
            this.comboBoxGivenback.Name = "comboBoxGivenback";
            this.comboBoxGivenback.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxGivenback.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGivenback.TabIndex = 5;
            // 
            // dateTimeBorrow
            // 
            this.dateTimeBorrow.CustomFormat = "dd/MM/yyyy";
            this.dateTimeBorrow.Format = Atf.UI.DateTimeSelectorFormat.Custom;
            this.dateTimeBorrow.Location = new System.Drawing.Point(494, 66);
            this.dateTimeBorrow.Name = "dateTimeBorrow";
            this.dateTimeBorrow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimeBorrow.Size = new System.Drawing.Size(100, 23);
            this.dateTimeBorrow.TabIndex = 6;
            this.dateTimeBorrow.UsePersianFormat = true;
            // 
            // dateTimeReturn
            // 
            this.dateTimeReturn.CustomFormat = "dd/MM/yyyy";
            this.dateTimeReturn.Format = Atf.UI.DateTimeSelectorFormat.Custom;
            this.dateTimeReturn.Location = new System.Drawing.Point(321, 67);
            this.dateTimeReturn.Name = "dateTimeReturn";
            this.dateTimeReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimeReturn.Size = new System.Drawing.Size(100, 23);
            this.dateTimeReturn.TabIndex = 6;
            this.dateTimeReturn.UsePersianFormat = true;
            // 
            // comboBoxMemberID
            // 
            this.comboBoxMemberID.DisplayMember = "Name";
            this.comboBoxMemberID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMemberID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMemberID.ForeColor = System.Drawing.Color.Black;
            this.comboBoxMemberID.FormattingEnabled = true;
            this.comboBoxMemberID.Location = new System.Drawing.Point(838, 66);
            this.comboBoxMemberID.Name = "comboBoxMemberID";
            this.comboBoxMemberID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxMemberID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMemberID.TabIndex = 7;
            this.comboBoxMemberID.ValueMember = "MemberID";
            // 
            // comboBoxBookID
            // 
            this.comboBoxBookID.DisplayMember = "Name";
            this.comboBoxBookID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBookID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBookID.FormattingEnabled = true;
            this.comboBoxBookID.Location = new System.Drawing.Point(658, 66);
            this.comboBoxBookID.Name = "comboBoxBookID";
            this.comboBoxBookID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxBookID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBookID.TabIndex = 7;
            this.comboBoxBookID.ValueMember = "BookID";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Controls.Add(this.label6);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 114);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxSearch.Size = new System.Drawing.Size(956, 48);
            this.groupBoxSearch.TabIndex = 8;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "جستجوی کلی";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(611, 16);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(167, 22);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Zar", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(784, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "پیدا کن";
            // 
            // FormBorrowBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(980, 572);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.comboBoxBookID);
            this.Controls.Add(this.comboBoxMemberID);
            this.Controls.Add(this.dateTimeReturn);
            this.Controls.Add(this.dateTimeBorrow);
            this.Controls.Add(this.comboBoxGivenback);
            this.Controls.Add(this.buttonAddBorrow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGVBorrow);
            this.Controls.Add(this.toolStripBorrowBooks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormBorrowBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "امانت دادن کتاب ها";
            this.Load += new System.EventHandler(this.FormBorrowBooks_Load);
            this.toolStripBorrowBooks.ResumeLayout(false);
            this.toolStripBorrowBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVBorrow)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripBorrowBooks;
        private System.Windows.Forms.ToolStripButton buttonRefresh;
        private System.Windows.Forms.DataGridView dataGVBorrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddBorrow;
        private System.Windows.Forms.ComboBox comboBoxGivenback;
        private Atf.UI.DateTimeSelector dateTimeBorrow;
        private Atf.UI.DateTimeSelector dateTimeReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrow_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrow_bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrow_memberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrow_userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrow_borrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrow_returnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrow_givenBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrow_bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrow_memberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrow_userName;
        private System.Windows.Forms.DataGridViewButtonColumn buttonEditBorrow;
        private System.Windows.Forms.DataGridViewButtonColumn buttonDeleteBorrow;
        private System.Windows.Forms.ComboBox comboBoxMemberID;
        private System.Windows.Forms.ComboBox comboBoxBookID;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label6;
    }
}