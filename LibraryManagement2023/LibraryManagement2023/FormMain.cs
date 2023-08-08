using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement2023
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSubjects_Click(object sender, EventArgs e)
        {
            FormSubjects subjects = new FormSubjects();
            subjects.ShowDialog();
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            FormBooks books = new FormBooks();
            books.ShowDialog();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            FormUsers users = new FormUsers();
            users.ShowDialog();
        }

        private void buttonMembers_Click(object sender, EventArgs e)
        {
            FormMembers members = new FormMembers();
            members.ShowDialog();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelUser.Text = "کاربر : " + LoginInfo.name;

            if (LoginInfo.access == 0)
            {
                buttonUsers.Enabled = false;
                buttonSubjects.Enabled = false;
            }

            labelShowDate.Text = DateTime.Now.Year + " - " + DateTime.Now.Month + " - " + DateTime.Now.Day;
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            FormBorrowBooks borrowBooks = new FormBorrowBooks();
            borrowBooks.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("آیا میخواهید خارج شوید ؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
