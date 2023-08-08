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
    public partial class FormBorrowBooks : Form
    {
        int positionId = 0;    //حالت ویرایش یا درچ
        Database db = new Database();
        public FormBorrowBooks()
        {
            InitializeComponent();
        }

        private void FormBorrowBooks_Load(object sender, EventArgs e)
        {
            dataGVBorrow.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            comboBoxMemberID.DataSource = db.selectAll("Members", "MemberID");
            comboBoxMemberID.DisplayMember = "Name";
            comboBoxMemberID.ValueMember = "MemberID";
            comboBoxMemberID.SelectedIndex = -1;
            comboBoxBookID.DataSource = db.selectAll("Books", "BookID");
            comboBoxBookID.DisplayMember = "Name";
            comboBoxBookID.ValueMember = "BookID";
            comboBoxBookID.SelectedIndex = -1;
            BindGrid();
        }

        private void BindGrid()
        {
            dataGVBorrow.AutoGenerateColumns = false;
            dataGVBorrow.DataSource = db.selectAll("BorrowBook_view", "BorrowID");
            dataGVBorrow.Columns["borrow_id"].DisplayIndex = 0;
            dataGVBorrow.Columns["borrow_bookName"].DisplayIndex = 1;
            dataGVBorrow.Columns["borrow_memberName"].DisplayIndex = 2;
            dataGVBorrow.Columns["borrow_userName"].DisplayIndex = 3;
            dataGVBorrow.Columns["borrow_borrowDate"].DisplayIndex = 4;
            dataGVBorrow.Columns["borrow_returnDate"].DisplayIndex = 5;
            dataGVBorrow.Columns["borrow_givenBack"].DisplayIndex = 6;
            dataGVBorrow.Columns["buttonEditBorrow"].DisplayIndex = 7;
            dataGVBorrow.Columns["buttonDeleteBorrow"].DisplayIndex = 8;
        }

        private void buttonAddBorrow_Click(object sender, EventArgs e)
        {
            if (comboBoxMemberID.SelectedIndex == -1)
            {
                Message.errorMessage("لطفا شخص امانت گیرنده را انتخاب کنید!");
                return;
            }

            if (comboBoxBookID.SelectedIndex == -1)
            {
                Message.errorMessage("لطفا کتاب را انتخاب کنید!");
                return;
            }

            if (dateTimeBorrow.Value == null)
            {
                Message.errorMessage("لطفا تاریخ امانت را تعیین کنید!");
                return;
            }

            if (dateTimeReturn.Value == null)
            {
                Message.errorMessage("لطفا تاریخ برگشت را تعیین کنید!");
                return;
            }

            if (dateTimeBorrow.Value > dateTimeReturn.Value)
            {
                Message.errorMessage("نمیتوانید تاریخ برگشت را زودتر از تاریخ امانت تعیین کنید!");
                return;
            }

            if (comboBoxGivenback.SelectedIndex == -1)
            {
                Message.errorMessage("لطفا وضعیت کتاب را مشخص کنید!");
                return;
            }

            if (positionId == 0)
            {
                db.dbConnection("select * from BorrowBook_view where BookID=@BookID and Givenback=0",
                out SqlConnection connection, out SqlCommand command);
                command.Parameters.AddWithValue("@BookID", comboBoxBookID.SelectedValue);
                db.adapter.SelectCommand = command;
                DataTable data = new DataTable();
                db.adapter.Fill(data);
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    Message.errorMessage("کتاب " + row["BookName"].ToString() + " توسط عضو : " + row["MemberName"].ToString() + " در دست امانت میباشد!");
                    return;
                }

                db.dbConnection("insert into BorrowBooks (BookID,MemberID,UserID,BorrowDate,ReturnDate,Givenback) values (@BookID,@MemberID,@UserID,@BorrowDate,@ReturnDate,@Givenback)",
                    out SqlConnection connection2, out SqlCommand command2);
                command2.Parameters.AddWithValue("@BookID", comboBoxBookID.SelectedValue);
                command2.Parameters.AddWithValue("@MemberID", comboBoxMemberID.SelectedValue);
                command2.Parameters.AddWithValue("@UserID", LoginInfo.userId);
                command2.Parameters.AddWithValue("@BorrowDate", dateTimeBorrow.Value.ToString());
                command2.Parameters.AddWithValue("@ReturnDate", dateTimeReturn.Value.ToString());
                command2.Parameters.AddWithValue("@Givenback", comboBoxGivenback.SelectedIndex);
                command2.ExecuteNonQuery();
                connection2.Close();
                Message.addMessage();
            }

            else
            {
                db.dbConnection("select * from BorrowBook_view where BookID=@BookID and Givenback=0 and BorrowID!=@ID",
                out SqlConnection connection, out SqlCommand command);
                command.Parameters.AddWithValue("@BookID", comboBoxBookID.SelectedValue);
                command.Parameters.AddWithValue("@ID", positionId);
                db.adapter.SelectCommand = command;
                DataTable data = new DataTable();
                db.adapter.Fill(data);
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    Message.errorMessage("کتاب " + row["BookName"].ToString() + " توسط عضو : " + row["MemberName"].ToString() + " در دست امانت میباشد!");
                    return;
                }

                db.dbConnection("update BorrowBooks set BookID=@BookID,MemberID=@MemberID,UserID=@UserID,BorrowDate=@BorrowDate,ReturnDate=@ReturnDate,Givenback=@Givenback where BorrowID=@ID",
                    out SqlConnection connection2, out SqlCommand command2);
                command2.Parameters.AddWithValue("@BookID", comboBoxBookID.SelectedValue);
                command2.Parameters.AddWithValue("@MemberID", comboBoxMemberID.SelectedValue);
                command2.Parameters.AddWithValue("@UserID", LoginInfo.userId);
                command2.Parameters.AddWithValue("@BorrowDate", dateTimeBorrow.Value.ToString());
                command2.Parameters.AddWithValue("@ReturnDate", dateTimeReturn.Value.ToString());
                command2.Parameters.AddWithValue("@Givenback", comboBoxGivenback.SelectedIndex);
                command2.Parameters.AddWithValue("@ID", positionId);
                command2.ExecuteNonQuery();
                connection2.Close();
                buttonAddBorrow.Text = "افزودن";
                positionId = 0;
                Message.editMessage();
            }

            BindGrid();
            comboBoxMemberID.SelectedIndex = -1;
            comboBoxBookID.SelectedIndex = -1;
            dateTimeBorrow.Value = null;
            dateTimeReturn.Value = null;
            comboBoxGivenback.SelectedIndex = -1;
        }

        private void dataGVBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGVBorrow.Columns[e.ColumnIndex].Name == "buttonEditBorrow" && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGVBorrow.Rows[e.RowIndex].Cells["borrow_id"].Value);
                var dataBorrow = db.selectRow("BorrowBook_view", "BorrowID", id.ToString());
                comboBoxMemberID.SelectedValue = dataBorrow["MemberID"].ToString();
                comboBoxBookID.SelectedValue = dataBorrow["BookID"].ToString();
                dateTimeBorrow.Value = (DateTime)dataBorrow["BorrowDate"];
                dateTimeReturn.Value = (DateTime)dataBorrow["ReturnDate"];
                comboBoxGivenback.SelectedIndex = Convert.ToInt32(dataBorrow["Givenback"]);

                positionId = Convert.ToInt32(dataBorrow["BorrowID"]);    //پیدا کردن حالت
                buttonAddBorrow.Text = "ویرایش";
            }

            if (dataGVBorrow.Columns[e.ColumnIndex].Name == "buttonDeleteBorrow" && e.RowIndex >= 0)
            {
                if (Message.delQuestion() == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGVBorrow.Rows[e.RowIndex].Cells["borrow_id"].Value);

                    db.deleteRow("BorrowBooks", "BorrowID", id.ToString());
                    BindGrid();
                    Message.delMessage();
                }
            }
        }

        private void dataGVBorrow_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGVBorrow.Columns[e.ColumnIndex].Name == "borrow_givenBack" && e.Value != null)
            {
                string dataBorrow = e.Value.ToString();

                if (dataBorrow == "0" || dataBorrow == string.Empty)
                {
                    e.Value = "در دست امانت";
                }

                if (dataBorrow == "1")
                {
                    e.Value = "برگشت داده شده";
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            db.dbConnection("select * from BorrowBook_view where BorrowID like @parameter or MemberName like @parameter or BookName like @parameter" +
                " or UserName like @parameter",
                out SqlConnection connection, out SqlCommand command);
            command.Parameters.AddWithValue("@parameter", "%" + textBoxSearch.Text + "%");
            db.adapter.SelectCommand = command;
            DataTable data = new DataTable();
            db.adapter.Fill(data);
            dataGVBorrow.DataSource = data;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = string.Empty;
            BindGrid();
        }
    }
}
