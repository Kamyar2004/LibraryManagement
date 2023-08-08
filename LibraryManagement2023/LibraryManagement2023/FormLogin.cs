using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagement2023
{
    public partial class FormLogin : Form
    {
        Database db = new Database();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == string.Empty)
            {
                Message.errorMessage("لطفا نام کاربری را وارد کنید!");
                return;
            }

            if (textBoxPassword.Text == string.Empty)
            {
                Message.errorMessage("لطفا رمز عبور را وارد کنید!");
                return;
            }

            if (db.countRow("Users", "Username", textBoxUsername.Text) > 0)
            {
                var dataLogin = db.selectRow("Users", "Username", textBoxUsername.Text);

                if (dataLogin["Password"].ToString() == textBoxPassword.Text)
                {
                    LoginInfo.access = Convert.ToInt32(dataLogin["Access"]);
                    LoginInfo.userId = Convert.ToInt32(dataLogin["UserID"]);
                    LoginInfo.name = Convert.ToString(dataLogin["Name"]);

                    this.Hide();
                    FormMain main = new FormMain();
                    main.ShowDialog();
                }

                else
                {
                    Message.errorMessage("رمز عبور وارد شده صحیح نیست!");
                }
            }

            else
            {
                Message.errorMessage("نام کاربری وارد شده موجود نیست!");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
