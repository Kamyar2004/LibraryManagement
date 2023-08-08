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
    public partial class FormMembers : Form
    {
        int positionId = 0;    //حالت ویرایش یا درچ
        Database db = new Database();
        public FormMembers()
        {
            InitializeComponent();
        }

        private void FormMembers_Load(object sender, EventArgs e)
        {
            dataGVMembers.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            BindGrid();
        }

        private void BindGrid()
        {
            dataGVMembers.AutoGenerateColumns = false;
            dataGVMembers.DataSource = db.selectAll("Members", "MemberID");
            dataGVMembers.Columns["member_id"].DisplayIndex = 0;
            dataGVMembers.Columns["member_name"].DisplayIndex = 1;
            dataGVMembers.Columns["member_family"].DisplayIndex = 2;
            dataGVMembers.Columns["member_codeMeli"].DisplayIndex = 3;
            dataGVMembers.Columns["member_age"].DisplayIndex = 4;
            dataGVMembers.Columns["member_mobile"].DisplayIndex = 5;
            dataGVMembers.Columns["member_address"].DisplayIndex = 6;
            dataGVMembers.Columns["buttonEditMember"].DisplayIndex = 7;
            dataGVMembers.Columns["buttonDeleteMember"].DisplayIndex = 8;
        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == string.Empty)
            {
                Message.errorMessage("لطفا نام را وارد کنید!");
                return;
            }

            if (textBoxFamily.Text == string.Empty)
            {
                Message.errorMessage("لطفا نام را وارد کنید!");
                return;
            }

            if (textBoxCodemeli.Text == string.Empty)
            {
                Message.errorMessage("لطفا نام را وارد کنید!");
                return;
            }

            if (textBoxAge.Text == string.Empty)
            {
                Message.errorMessage("لطفا نام را وارد کنید!");
                return;
            }

            if (positionId == 0)
            {
                if (db.countRow("Members", "Codemeli", textBoxCodemeli.Text) > 0)
                {
                    Message.errorMessage("کد ملی وارد شده تکراری است!");
                    return;
                }

                db.dbConnection("insert into Members (Name,Family,Codemeli,Age,Mobile,Address) values (@Name,@Family,@Codemeli,@Age,@Mobile,@Address)",
                    out SqlConnection connection, out SqlCommand command);
                command.Parameters.AddWithValue("@Name", textBoxName.Text);
                command.Parameters.AddWithValue("@Family", textBoxFamily.Text);
                command.Parameters.AddWithValue("@Codemeli", textBoxCodemeli.Text);
                command.Parameters.AddWithValue("@Age", textBoxAge.Text);
                command.Parameters.AddWithValue("@Mobile", textBoxMobile.Text);
                command.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                command.ExecuteNonQuery();
                connection.Close();
                Message.addMessage();
            }

            else
            {
                db.dbConnection("select count(*) from Members where Codemeli=@Codemeli and MemberID!=@ID", out SqlConnection connection, out SqlCommand command);
                command.Parameters.AddWithValue("@Codemeli", textBoxCodemeli.Text);
                command.Parameters.AddWithValue("@ID", positionId);
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    Message.errorMessage("کد ملی وارد شده تکراری است!");
                    return;
                }

                db.dbConnection("update Members set Name=@Name,Family=@Family,Codemeli=@Codemeli,Age=@Age,Mobile=@Mobile,Address=@Address where MemberID=@ID",
                    out SqlConnection connection2, out SqlCommand command2);
                command2.Parameters.AddWithValue("@Name", textBoxName.Text);
                command2.Parameters.AddWithValue("@Family", textBoxFamily.Text);
                command.Parameters.AddWithValue("@Codemeli", textBoxCodemeli.Text);
                command.Parameters.AddWithValue("@Age", textBoxAge.Text);
                command.Parameters.AddWithValue("@Mobile", textBoxMobile.Text);
                command.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                command2.Parameters.AddWithValue("@ID", positionId);
                command2.ExecuteNonQuery();
                connection2.Close();
                buttonAddMember.Text = "افزودن";
                positionId = 0;
                Message.editMessage();
            }

            BindGrid();
            textBoxName.Clear();
            textBoxFamily.Clear();
            textBoxCodemeli.Clear();
            textBoxAge.Clear();
            textBoxMobile.Clear();
            textBoxAddress.Clear();
        }

        private void dataGVMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGVMembers.Columns[e.ColumnIndex].Name == "buttonEditMember" && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGVMembers.Rows[e.RowIndex].Cells["member_id"].Value);
                var dataMembers = db.selectRow("Members", "MemberID", id.ToString());
                textBoxName.Text = dataMembers["Name"].ToString();
                textBoxFamily.Text = dataMembers["Family"].ToString();
                textBoxCodemeli.Text = dataMembers["Codemeli"].ToString();
                textBoxAge.Text = dataMembers["Age"].ToString();
                textBoxMobile.Text = dataMembers["Mobile"].ToString();
                textBoxAddress.Text = dataMembers["Address"].ToString();

                positionId = Convert.ToInt32(dataMembers["MemberID"]);    //پیدا کردن حالت
                buttonAddMember.Text = "ویرایش";
            }

            if (dataGVMembers.Columns[e.ColumnIndex].Name == "buttonDeleteMember" && e.RowIndex >= 0)
            {
                if (Message.delQuestion() == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGVMembers.Rows[e.RowIndex].Cells["member_id"].Value);

                    if (db.countRow("BorrowBooks", "MemberID", id.ToString()) == 0)
                    {
                        db.deleteRow("Members", "MemberID", id.ToString());
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
            db.dbConnection("select * from Members where MemberID like @parameter or Name like @parameter or Family like @parameter" +
                " or Codemeli like @parameter or Age like @parameter or Mobile like @parameter or Address like @parameter",
                out SqlConnection connection, out SqlCommand command);
            command.Parameters.AddWithValue("@parameter", "%" + textBoxSearch.Text + "%");
            db.adapter.SelectCommand = command;
            DataTable data = new DataTable();
            db.adapter.Fill(data);
            dataGVMembers.DataSource = data;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = string.Empty;
            BindGrid();
        }

        private void textBoxCodemeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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
