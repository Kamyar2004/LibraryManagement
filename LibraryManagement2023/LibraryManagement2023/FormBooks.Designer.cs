namespace LibraryManagement2023
{
    partial class FormBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBooks));
            this.toolStripBooks = new System.Windows.Forms.ToolStrip();
            this.buttonRefresh = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBook = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxPublish_year = new System.Windows.Forms.TextBox();
            this.comboBoxSubjectID = new System.Windows.Forms.ComboBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.dataGVBooks = new System.Windows.Forms.DataGridView();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_publishYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_subjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditBook = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonDeleteBook = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStripBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVBooks)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripBooks
            // 
            this.toolStripBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonRefresh});
            this.toolStripBooks.Location = new System.Drawing.Point(0, 0);
            this.toolStripBooks.Name = "toolStripBooks";
            this.toolStripBooks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripBooks.Size = new System.Drawing.Size(972, 25);
            this.toolStripBooks.TabIndex = 0;
            this.toolStripBooks.Text = "toolStrip1";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(878, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام کتاب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(700, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام نویسنده";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(557, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "موضوع";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(385, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "سال چاپ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Zar", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(253, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "قیمت";
            // 
            // textBoxBook
            // 
            this.textBoxBook.Location = new System.Drawing.Point(810, 69);
            this.textBoxBook.Name = "textBoxBook";
            this.textBoxBook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxBook.Size = new System.Drawing.Size(133, 22);
            this.textBoxBook.TabIndex = 2;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(646, 69);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxAuthor.Size = new System.Drawing.Size(133, 22);
            this.textBoxAuthor.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(168, 69);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPrice.Size = new System.Drawing.Size(133, 22);
            this.textBoxPrice.TabIndex = 2;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // textBoxPublish_year
            // 
            this.textBoxPublish_year.Location = new System.Drawing.Point(324, 69);
            this.textBoxPublish_year.MaxLength = 4;
            this.textBoxPublish_year.Name = "textBoxPublish_year";
            this.textBoxPublish_year.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPublish_year.Size = new System.Drawing.Size(133, 22);
            this.textBoxPublish_year.TabIndex = 2;
            this.textBoxPublish_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPublish_year_KeyPress);
            // 
            // comboBoxSubjectID
            // 
            this.comboBoxSubjectID.DisplayMember = "Name";
            this.comboBoxSubjectID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubjectID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubjectID.FormattingEnabled = true;
            this.comboBoxSubjectID.Location = new System.Drawing.Point(483, 69);
            this.comboBoxSubjectID.Name = "comboBoxSubjectID";
            this.comboBoxSubjectID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxSubjectID.Size = new System.Drawing.Size(133, 24);
            this.comboBoxSubjectID.TabIndex = 3;
            this.comboBoxSubjectID.ValueMember = "SubjectID";
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(30, 52);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(109, 41);
            this.buttonAddBook.TabIndex = 4;
            this.buttonAddBook.Text = "افزودن";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // dataGVBooks
            // 
            this.dataGVBooks.AllowUserToAddRows = false;
            this.dataGVBooks.AllowUserToDeleteRows = false;
            this.dataGVBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGVBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_id,
            this.book_name,
            this.book_author,
            this.book_publishYear,
            this.book_price,
            this.book_subject,
            this.book_subjectID,
            this.buttonEditBook,
            this.buttonDeleteBook});
            this.dataGVBooks.Location = new System.Drawing.Point(12, 168);
            this.dataGVBooks.Name = "dataGVBooks";
            this.dataGVBooks.ReadOnly = true;
            this.dataGVBooks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGVBooks.Size = new System.Drawing.Size(948, 392);
            this.dataGVBooks.TabIndex = 5;
            this.dataGVBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVBooks_CellContentClick);
            this.dataGVBooks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGVBooks_CellFormatting);
            // 
            // book_id
            // 
            this.book_id.DataPropertyName = "BookID";
            this.book_id.HeaderText = "شناسه";
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            // 
            // book_name
            // 
            this.book_name.DataPropertyName = "Name";
            this.book_name.HeaderText = "نام کتاب";
            this.book_name.Name = "book_name";
            this.book_name.ReadOnly = true;
            // 
            // book_author
            // 
            this.book_author.DataPropertyName = "Author";
            this.book_author.HeaderText = "نام نویسنده";
            this.book_author.Name = "book_author";
            this.book_author.ReadOnly = true;
            // 
            // book_publishYear
            // 
            this.book_publishYear.DataPropertyName = "Publish_year";
            this.book_publishYear.HeaderText = "سال چاپ";
            this.book_publishYear.Name = "book_publishYear";
            this.book_publishYear.ReadOnly = true;
            // 
            // book_price
            // 
            this.book_price.DataPropertyName = "Price";
            this.book_price.HeaderText = "قیمت";
            this.book_price.Name = "book_price";
            this.book_price.ReadOnly = true;
            // 
            // book_subject
            // 
            this.book_subject.DataPropertyName = "Subject";
            this.book_subject.HeaderText = "موضوع";
            this.book_subject.Name = "book_subject";
            this.book_subject.ReadOnly = true;
            // 
            // book_subjectID
            // 
            this.book_subjectID.DataPropertyName = "SubjectID";
            this.book_subjectID.HeaderText = "شناسه موضوع";
            this.book_subjectID.Name = "book_subjectID";
            this.book_subjectID.ReadOnly = true;
            this.book_subjectID.Visible = false;
            // 
            // buttonEditBook
            // 
            this.buttonEditBook.HeaderText = "ویرایش";
            this.buttonEditBook.Name = "buttonEditBook";
            this.buttonEditBook.ReadOnly = true;
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.HeaderText = "حذف";
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.ReadOnly = true;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Controls.Add(this.label6);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 114);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxSearch.Size = new System.Drawing.Size(948, 48);
            this.groupBoxSearch.TabIndex = 6;
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
            // FormBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(972, 572);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.dataGVBooks);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.comboBoxSubjectID);
            this.Controls.Add(this.textBoxPublish_year);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStripBooks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مخزن کتاب ها";
            this.Load += new System.EventHandler(this.FormBooks_Load);
            this.toolStripBooks.ResumeLayout(false);
            this.toolStripBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVBooks)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBook;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxPublish_year;
        private System.Windows.Forms.ComboBox comboBoxSubjectID;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.DataGridView dataGVBooks;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripButton buttonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_author;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_publishYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_subjectID;
        private System.Windows.Forms.DataGridViewButtonColumn buttonEditBook;
        private System.Windows.Forms.DataGridViewButtonColumn buttonDeleteBook;
    }
}