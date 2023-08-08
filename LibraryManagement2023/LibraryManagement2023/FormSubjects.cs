using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LibraryManagement2023
{
    public partial class FormSubjects : Form
    {
        int positionId = 0;    //حالت ویرایش یا درچ
        Database db = new Database();
        public FormSubjects()
        {
            InitializeComponent();
        }

        private void BindGrid()
        {
            dataGVContacts.DataSource = db.selectAll("Subjects", "SubjectID");
        }

        private void FormSubjects_Load(object sender, EventArgs e)
        {
            dataGVContacts.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            BindGrid();
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            if (textBoxSubject.Text == string.Empty)
            {
                Message.errorMessage("لطفا نام موضوع را وارد کنید!");
                return;
            }

            if (positionId == 0)
            {
                db.dbConnection("insert into Subjects (Name) values (@Name)", out SqlConnection connection, out SqlCommand command);
                command.Parameters.AddWithValue("@Name", textBoxSubject.Text);
                command.ExecuteNonQuery();
                connection.Close();
                Message.addMessage();
            }

            else
            {
                db.dbConnection("update Subjects set Name=@Name where SubjectID=@ID", out SqlConnection connection, out SqlCommand command);
                command.Parameters.AddWithValue("@Name", textBoxSubject.Text);
                command.Parameters.AddWithValue("@ID", positionId);
                command.ExecuteNonQuery();
                connection.Close();
                buttonAddSubject.Text = "افزودن";
                positionId = 0;
                Message.editMessage();
            }

            BindGrid();
            textBoxSubject.Clear();
        }

        private void dataGVContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGVContacts.Columns[e.ColumnIndex].Name == "buttonEditSubject" && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGVContacts.Rows[e.RowIndex].Cells["subject_id"].Value);
                var dataSubjects = db.selectRow("Subjects", "SubjectID", id.ToString());
                textBoxSubject.Text = dataSubjects["Name"].ToString();

                positionId = Convert.ToInt32(dataSubjects["SubjectID"]);    //پیدا کردن حالت
                buttonAddSubject.Text = "ویرایش";
            }

            if (dataGVContacts.Columns[e.ColumnIndex].Name == "buttonDeleteSubject" && e.RowIndex >= 0)
            {
                if (Message.delQuestion() == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGVContacts.Rows[e.RowIndex].Cells["subject_id"].Value);

                    if (db.countRow("Books", "SubjectID", id.ToString()) == 0)
                    {
                        db.deleteRow("Subjects", "SubjectID", id.ToString());
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

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
