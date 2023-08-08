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
    public partial class FormBooks : Form
    {
        int positionId = 0;    //حالت ویرایش یا درچ
        Database db = new Database();
        public FormBooks()
        {
            InitializeComponent();
        }

        private void FormBooks_Load(object sender, EventArgs e)
        {
            dataGVBooks.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            comboBoxSubjectID.DataSource = db.selectAll("Subjects", "SubjectID");
            comboBoxSubjectID.DisplayMember = "Name";
            comboBoxSubjectID.ValueMember = "SubjectID";
            comboBoxSubjectID.SelectedIndex = -1;
            BindGrid();
        }

        private void BindGrid()
        {
            dataGVBooks.AutoGenerateColumns = false;
            dataGVBooks.DataSource = db.selectAll("BookInfo_view", "BookID");
            dataGVBooks.Columns["book_id"].DisplayIndex = 0;
            dataGVBooks.Columns["book_name"].DisplayIndex = 1;
            dataGVBooks.Columns["book_author"].DisplayIndex = 2;
            dataGVBooks.Columns["book_subject"].DisplayIndex = 3;
            dataGVBooks.Columns["book_publishYear"].DisplayIndex = 4;
            dataGVBooks.Columns["book_price"].DisplayIndex = 5;
            dataGVBooks.Columns["buttonEditBook"].DisplayIndex = 6;
            dataGVBooks.Columns["buttonDeleteBook"].DisplayIndex = 7;
        }

        private void dataGVBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGVBooks.Columns[e.ColumnIndex].Name == "book_price" && e.Value != null)
            {
                e.Value = e.Value + " تومان ";
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            if (textBoxBook.Text == string.Empty)
            {
                Message.errorMessage("لطفا نام کتاب را وارد کنید!");
                return;
            }

            if (textBoxAuthor.Text == string.Empty)
            {
                Message.errorMessage("لطفا نام نویسنده را وارد کنید!");
                return;
            }

            if (comboBoxSubjectID.SelectedIndex == -1)
            {
                Message.errorMessage("لطفا موضوع را انتخاب کنید!");
                return;
            }

            if (positionId == 0)
            {
                db.dbConnection("insert into Books (Name,Author,SubjectID,Publish_year,Price) values (@Name,@Author,@SubjectID,@Publish_year,@Price)",
                    out SqlConnection connection, out SqlCommand command);
                command.Parameters.AddWithValue("@Name", textBoxBook.Text);
                command.Parameters.AddWithValue("@Author", textBoxAuthor.Text);
                command.Parameters.AddWithValue("@SubjectId", comboBoxSubjectID.SelectedValue);
                command.Parameters.AddWithValue("@Publish_year", textBoxPublish_year.Text);
                command.Parameters.AddWithValue("@Price", textBoxPrice.Text);
                command.ExecuteNonQuery();
                connection.Close();
                Message.addMessage();
            }

            else
            {
                db.dbConnection("update Books set Name=@Name,Author=@Author,SubjectID=@SubjectID,Publish_year=@Publish_year,Price=@Price where BookID=@ID",
                    out SqlConnection connection, out SqlCommand command);
                command.Parameters.AddWithValue("@Name", textBoxBook.Text);
                command.Parameters.AddWithValue("@Author", textBoxAuthor.Text);
                command.Parameters.AddWithValue("@SubjectId", comboBoxSubjectID.SelectedValue);
                command.Parameters.AddWithValue("@Publish_year", textBoxPublish_year.Text);
                command.Parameters.AddWithValue("@Price", textBoxPrice.Text);
                command.Parameters.AddWithValue("@ID", positionId);
                command.ExecuteNonQuery();
                connection.Close();
                buttonAddBook.Text = "افزودن";
                positionId = 0;
                Message.editMessage();
            }

            BindGrid();
            textBoxBook.Clear();
            textBoxAuthor.Clear();
            comboBoxSubjectID.SelectedIndex = -1;
            textBoxPublish_year.Clear();
            textBoxPrice.Clear();
        }

        private void textBoxPublish_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGVBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGVBooks.Columns[e.ColumnIndex].Name == "buttonEditBook" && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGVBooks.Rows[e.RowIndex].Cells["book_id"].Value);
                var dataBooks = db.selectRow("Books", "BookID", id.ToString());
                textBoxBook.Text = dataBooks["Name"].ToString();
                textBoxAuthor.Text = dataBooks["Author"].ToString();
                comboBoxSubjectID.SelectedValue = dataBooks["SubjectID"].ToString();
                textBoxPublish_year.Text = dataBooks["Publish_year"].ToString();
                textBoxPrice.Text = dataBooks["Price"].ToString();

                positionId = Convert.ToInt32(dataBooks["BookID"]);    //پیدا کردن حالت
                buttonAddBook.Text = "ویرایش";
            }

            if (dataGVBooks.Columns[e.ColumnIndex].Name == "buttonDeleteBook" && e.RowIndex >= 0)
            {
                if (Message.delQuestion() == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGVBooks.Rows[e.RowIndex].Cells["book_id"].Value);

                    if (db.countRow("BorrowBooks", "BookID", id.ToString()) == 0)
                    {
                        db.deleteRow("Books", "BookID", id.ToString());
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
            db.dbConnection("select * from BookInfo_view where BookID like @parameter or Name like @parameter or Author like @parameter" +
                " or Subject like @parameter or Publish_year like @parameter or Price like @parameter",
                out SqlConnection connection, out SqlCommand command);
            command.Parameters.AddWithValue("@parameter", "%" + textBoxSearch.Text + "%");
            db.adapter.SelectCommand = command;
            DataTable data = new DataTable();
            db.adapter.Fill(data);
            dataGVBooks.DataSource = data;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = string.Empty;
            BindGrid();
        }
    }
}
