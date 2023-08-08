namespace LibraryManagement2023
{
    partial class FormMain
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
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.buttonSubjects = new System.Windows.Forms.Button();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonMembers = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelShowDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.BackColor = System.Drawing.Color.Lavender;
            this.buttonBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonBorrow.Location = new System.Drawing.Point(538, 309);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(158, 53);
            this.buttonBorrow.TabIndex = 4;
            this.buttonBorrow.Text = "امانت دادن کتاب ها";
            this.buttonBorrow.UseVisualStyleBackColor = false;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // buttonSubjects
            // 
            this.buttonSubjects.BackColor = System.Drawing.Color.Lavender;
            this.buttonSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonSubjects.Location = new System.Drawing.Point(442, 212);
            this.buttonSubjects.Name = "buttonSubjects";
            this.buttonSubjects.Size = new System.Drawing.Size(158, 53);
            this.buttonSubjects.TabIndex = 3;
            this.buttonSubjects.Text = "موضوعات";
            this.buttonSubjects.UseVisualStyleBackColor = false;
            this.buttonSubjects.Click += new System.EventHandler(this.buttonSubjects_Click);
            // 
            // buttonBooks
            // 
            this.buttonBooks.BackColor = System.Drawing.Color.Lavender;
            this.buttonBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonBooks.Location = new System.Drawing.Point(351, 309);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(158, 53);
            this.buttonBooks.TabIndex = 5;
            this.buttonBooks.Text = "مخزن کتاب ها";
            this.buttonBooks.UseVisualStyleBackColor = false;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.BackColor = System.Drawing.Color.Lavender;
            this.buttonUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonUsers.Location = new System.Drawing.Point(538, 115);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(158, 53);
            this.buttonUsers.TabIndex = 1;
            this.buttonUsers.Text = "کاربران";
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonMembers
            // 
            this.buttonMembers.BackColor = System.Drawing.Color.Lavender;
            this.buttonMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonMembers.Location = new System.Drawing.Point(351, 115);
            this.buttonMembers.Name = "buttonMembers";
            this.buttonMembers.Size = new System.Drawing.Size(158, 53);
            this.buttonMembers.TabIndex = 2;
            this.buttonMembers.Text = "اعضا";
            this.buttonMembers.UseVisualStyleBackColor = false;
            this.buttonMembers.Click += new System.EventHandler(this.buttonMembers_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = global::LibraryManagement2023.Properties.Resources._1689535184794_resize_;
            this.buttonExit.Image = global::LibraryManagement2023.Properties.Resources._1689535184794_edited_1;
            this.buttonExit.Location = new System.Drawing.Point(678, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(44, 44);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("B Zar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelUser.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelUser.Location = new System.Drawing.Point(487, 44);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(69, 33);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "کاربر ۱";
            // 
            // labelShowDate
            // 
            this.labelShowDate.AutoSize = true;
            this.labelShowDate.BackColor = System.Drawing.Color.Transparent;
            this.labelShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelShowDate.Location = new System.Drawing.Point(12, 3);
            this.labelShowDate.Name = "labelShowDate";
            this.labelShowDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelShowDate.Size = new System.Drawing.Size(66, 24);
            this.labelShowDate.TabIndex = 7;
            this.labelShowDate.Text = "label1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagement2023.Properties.Resources._1689535677285;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 428);
            this.Controls.Add(this.labelShowDate);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBorrow);
            this.Controls.Add(this.buttonSubjects);
            this.Controls.Add(this.buttonBooks);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.buttonMembers);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحه اصلی";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.Button buttonSubjects;
        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonMembers;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelShowDate;
    }
}

