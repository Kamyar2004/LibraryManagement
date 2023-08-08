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
    public partial class FormUsers : Form
    {
        int positionId = 0;    //حالت ویرایش یا درچ
        Database db = new Database();
        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            dataGVUsers.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            BindGrid();
        }

        private void BindGrid()
        {
            dataGVUsers.AutoGenerateColumns = false;
            dataGVUsers.DataSource = db.selectAll("Users", "UserID");
            dataGVUsers.Columns["user_id"].DisplayIndex = 0;
            dataGVUsers.Columns["user_name"].DisplayIndex = 1;
            dataGVUsers.Columns["user_family"].DisplayIndex = 2;
            dataGVUsers.Columns["user_userName"].DisplayIndex = 3;
            dataGVUsers.Columns["user_password"].DisplayIndex = 4;
            dataGVUsers.Columns["user_access"].DisplayIndex = 5;
            dataGVUsers.Columns["user_age"].DisplayIndex = 6;
            dataGVUsers.Columns["user_mobile"].DisplayIndex = 7;
            dataGVUsers.Columns["buttonEditUser"].DisplayIndex = 8;
            dataGVUsers.Columns["buttonDeleteUser"].DisplayIndex = 9;
        }

        private void dataGVUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGVUsers.Columns[e.ColumnIndex].Name == "user_access" && e.Value != null)
            {
                string dataAccess = e.Value.ToString();

                if (dataAccess == "0" || dataAccess == string.Empty)
                {
                    e.Value = "کاربر ساده";
                }

                if (dataAccess == "1")
                {
                    e.Value = "مدیر";
                }
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == string.Empty)
            {
                Message.errorMessage("لطفا نام را وارد کنید!");
                return;
            }

            if (textBoxFamily.Text == string.Empty)
            {
                Message.errorMessage("لطفا نام خانوادگی را وارد کنید!");
                return;
            }

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

            if (comboBoxAccess.SelectedIndex == -1)
            {
                Message.errorMessage("لطفا سطح دسترسی را انتخاب کنید!");
                return;
            }

            if (textBoxAge.Text == string.Empty)
            {
                Message.errorMessage("لطفا سن را وارد کنید!");
                return;
            }

            if (textBoxMobile.Text == string.Empty)
            {
                Message.errorMessage("لطفا شماره موبایل را وارد کنید!");
                return;
            }

            if (positionId == 0)
            {
                if (db.countRow("Users", "Username", textBoxUsername.Text) > 0)
                {
                    Message.errorMessage("نام کاربری وارد شده تکراری است!");
                    return;
                }

                db.dbConnection("insert into Users (Name,Family,Username,Password,Access,Age,Mobile) values (@Name,@Family,@Username,@Password,@Access,@Age,@Mobile)",
                    out SqlConnection connection, out SqlCommand command);
                command.Parameters.AddWithValue("@Name", textBoxName.Text);
                command.Parameters.AddWithValue("@Family", textBoxFamily.Text);
                command.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                command.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                command.Parameters.AddWithValue("@Access", comboBoxAccess.SelectedIndex);
                command.Parameters.AddWithValue("@Age", textBoxAge.Text);
                command.Parameters.AddWithValue("@Mobile", textBoxMobile.Text);
                command.ExecuteNonQuery();
                connection.Close();
                Message.addMessage();
            }

            else
            {
                if (comboBoxAccess.SelectedIndex != 1)
                {
                    if (db.countRow("Users", "Access", "1") <= 1)
                    {
                        Message.errorMessage("نمی توانید این مدیر را برکنار کنید زیرا مدیر دیگری وجود ندارد!");
                        return;
                    }
                }

                db.dbConnection("select count(*) from Users where Username=@Username and UserID!=@ID", out SqlConnection connection, out SqlCommand command);
                command.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                command.Parameters.AddWithValue("@ID", positionId);
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    Message.errorMessage("نام کاربری تکراری وارد شده است!");
                    return;
                }

                db.dbConnection("update Users set Name=@Name,Family=@Family,Username=@Username,Password=@Password,Access=@Access,Age=@Age,Mobile=@Mobile where UserID=@ID",
                    out SqlConnection connection2, out SqlCommand command2);
                command2.Parameters.AddWithValue("@Name", textBoxName.Text);
                command2.Parameters.AddWithValue("@Family", textBoxFamily.Text);
                command2.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                command2.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                command2.Parameters.AddWithValue("@Access", comboBoxAccess.SelectedIndex);
                command2.Parameters.AddWithValue("@Age", textBoxAge.Text);
                command2.Parameters.AddWithValue("@Mobile", textBoxMobile.Text);
                command2.Parameters.AddWithValue("@ID", positionId);
                command2.ExecuteNonQuery();
                connection2.Close();
                buttonAddUser.Text = "افزودن";
                positionId = 0;
                Message.editMessage();
            }

            BindGrid();
            textBoxName.Clear();
            textBoxFamily.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            comboBoxAccess.SelectedIndex = -1;
            textBoxAge.Clear();
            textBoxMobile.Clear();
        }

        private void dataGVUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGVUsers.Columns[e.ColumnIndex].Name == "buttonEditUser" && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGVUsers.Rows[e.RowIndex].Cells["user_id"].Value);
                var dataUsers = db.selectRow("Users", "UserID", id.ToString());
                textBoxName.Text = dataUsers["Name"].ToString();
                textBoxFamily.Text = dataUsers["Family"].ToString();
                textBoxUsername.Text = dataUsers["Username"].ToString();
                textBoxPassword.Text = dataUsers["Password"].ToString();
                comboBoxAccess.SelectedIndex = Convert.ToInt32(dataUsers["Access"]);
                textBoxAge.Text = dataUsers["Age"].ToString();
                textBoxMobile.Text = dataUsers["Mobile"].ToString();

                positionId = Convert.ToInt32(dataUsers["UserID"]);    //پیدا کردن حالت
                buttonAddUser.Text = "ویرایش";
            }

            if (dataGVUsers.Columns[e.ColumnIndex].Name == "buttonDeleteUser" && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGVUsers.Rows[e.RowIndex].Cells["user_id"].Value);

                if (LoginInfo.userId == id)
                {
                    Message.errorMessage("حذف کردن خود ممکن نیست :(");
                    return;
                }

                if (Message.delQuestion() == DialogResult.Yes)
                {
                    if (db.countRow("BorrowBooks", "UserID", id.ToString()) == 0)
                    {
                        db.deleteRow("Users", "UserID", id.ToString());
                        BindGrid();
                        Message.delMessage();
                    }
                    else
                    {
                        Message.usedMessage();
                    }
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            db.dbConnection("select * from Users where UserID like @parameter or Name like @parameter or Family like @parameter" +
                " or Username like @parameter or Age like @parameter or Mobile like @parameter",
                out SqlConnection connection, out SqlCommand command);
            command.Parameters.AddWithValue("@parameter", "%" + textBoxSearch.Text + "%");
            db.adapter.SelectCommand = command;
            DataTable data = new DataTable();
            db.adapter.Fill(data);
            dataGVUsers.DataSource = data;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = string.Empty;
            BindGrid();
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
