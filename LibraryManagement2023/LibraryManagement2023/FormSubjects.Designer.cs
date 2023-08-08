namespace LibraryManagement2023
{
    partial class FormSubjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSubjects));
            this.dataGVContacts = new System.Windows.Forms.DataGridView();
            this.subject_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditSubject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonDeleteSubject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.toolStripSubjects = new System.Windows.Forms.ToolStrip();
            this.buttonRefresh = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVContacts)).BeginInit();
            this.toolStripSubjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGVContacts
            // 
            this.dataGVContacts.AllowUserToAddRows = false;
            this.dataGVContacts.AllowUserToDeleteRows = false;
            this.dataGVContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVContacts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGVContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject_id,
            this.subject_name,
            this.buttonEditSubject,
            this.buttonDeleteSubject});
            this.dataGVContacts.Location = new System.Drawing.Point(13, 82);
            this.dataGVContacts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGVContacts.Name = "dataGVContacts";
            this.dataGVContacts.ReadOnly = true;
            this.dataGVContacts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGVContacts.Size = new System.Drawing.Size(445, 335);
            this.dataGVContacts.TabIndex = 0;
            this.dataGVContacts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVContacts_CellContentClick);
            // 
            // subject_id
            // 
            this.subject_id.DataPropertyName = "SubjectID";
            this.subject_id.HeaderText = "شناسه";
            this.subject_id.Name = "subject_id";
            this.subject_id.ReadOnly = true;
            // 
            // subject_name
            // 
            this.subject_name.DataPropertyName = "Name";
            this.subject_name.HeaderText = "نام موضوع";
            this.subject_name.Name = "subject_name";
            this.subject_name.ReadOnly = true;
            // 
            // buttonEditSubject
            // 
            this.buttonEditSubject.HeaderText = "ویرایش";
            this.buttonEditSubject.Name = "buttonEditSubject";
            this.buttonEditSubject.ReadOnly = true;
            this.buttonEditSubject.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.buttonEditSubject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // buttonDeleteSubject
            // 
            this.buttonDeleteSubject.HeaderText = "حذف";
            this.buttonDeleteSubject.Name = "buttonDeleteSubject";
            this.buttonDeleteSubject.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(370, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام موضوع";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(191, 38);
            this.textBoxSubject.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxSubject.Size = new System.Drawing.Size(162, 22);
            this.textBoxSubject.TabIndex = 2;
            this.textBoxSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSubject.Location = new System.Drawing.Point(36, 35);
            this.buttonAddSubject.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(130, 29);
            this.buttonAddSubject.TabIndex = 3;
            this.buttonAddSubject.Text = "افزودن";
            this.buttonAddSubject.UseVisualStyleBackColor = true;
            this.buttonAddSubject.Click += new System.EventHandler(this.buttonAddSubject_Click);
            // 
            // toolStripSubjects
            // 
            this.toolStripSubjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonRefresh});
            this.toolStripSubjects.Location = new System.Drawing.Point(0, 0);
            this.toolStripSubjects.Name = "toolStripSubjects";
            this.toolStripSubjects.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSubjects.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripSubjects.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripSubjects.Size = new System.Drawing.Size(470, 25);
            this.toolStripSubjects.TabIndex = 4;
            this.toolStripSubjects.Text = "toolStrip1";
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
            // FormSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(470, 430);
            this.Controls.Add(this.toolStripSubjects);
            this.Controls.Add(this.buttonAddSubject);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGVContacts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormSubjects";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "موضوعات کتاب ها";
            this.Load += new System.EventHandler(this.FormSubjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVContacts)).EndInit();
            this.toolStripSubjects.ResumeLayout(false);
            this.toolStripSubjects.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVContacts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Button buttonAddSubject;
        private System.Windows.Forms.ToolStrip toolStripSubjects;
        private System.Windows.Forms.ToolStripButton buttonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_name;
        private System.Windows.Forms.DataGridViewButtonColumn buttonEditSubject;
        private System.Windows.Forms.DataGridViewButtonColumn buttonDeleteSubject;
    }
}