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


namespace CarsCompanySystem
{
    public partial class UsersForm : Form
    {

        public UsersForm()
        {
            InitializeComponent();
        }
        private void LoadUsers()
        {
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();

                string query = "SELECT * FROM Users";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridUsers.DataSource = dt;
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadUsers();

        }

        private void btnUAdd_Click(object sender, EventArgs e)
        {
            string username = txtUUsername.Text.Trim();
            string password = txtUPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("يرجى تعبئة جميع البيانات.");
                return;
            }

            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();

                // فحص إذا كان اسم المستخدم موجودًا مسبقًا
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username=@u";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@u", username);

                int exists = (int)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("اسم المستخدم موجود مسبقًا.");
                    return;
                }

                // إضافة المستخدم الجديد
                string query = "INSERT INTO Users (Username, Password) VALUES (@u, @p)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("تمت إضافة المستخدم بنجاح!");

            LoadUsers(); // تحديث القائمة
            txtUUsername.Clear();
            txtUPassword.Clear();
        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridUsers.Rows[e.RowIndex];

                txtUUsername.Text = row.Cells["Username"].Value.ToString();
                txtUPassword.Text = row.Cells["Password"].Value.ToString();
            }
        }

        private void btnUUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridUsers.CurrentRow == null)
            {
                MessageBox.Show("يرجى اختيار مستخدم أولاً.");
                return;
            }

            int id = Convert.ToInt32(dataGridUsers.CurrentRow.Cells["UserID"].Value);

            string username = txtUUsername.Text.Trim();
            string password = txtUPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("يرجى تعبئة جميع الحقول.");
                return;
            }

            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();

                string query = "UPDATE Users SET Username=@u, Password=@p WHERE UserID=@id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("تم تعديل المستخدم بنجاح!");

            LoadUsers();   // تحديث الجدول
        }

        private void btnUDelete_Click(object sender, EventArgs e)
        {
            if (dataGridUsers.CurrentRow == null)
            {
                MessageBox.Show("يرجى اختيار مستخدم لحذفه.");
                return;
            }

            // الحصول على رقم المستخدم
            int id = Convert.ToInt32(dataGridUsers.CurrentRow.Cells["UserID"].Value);

            // رسالة تأكيد
            DialogResult confirm = MessageBox.Show(
                "هل أنت متأكد من حذف هذا المستخدم؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No)
                return;

            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();

                string query = "DELETE FROM Users WHERE UserID=@id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("تم حذف المستخدم بنجاح!");

            LoadUsers(); // تحديث الجدول

            // تنظيف الحقول
            txtUUsername.Clear();
            txtUPassword.Clear();
        

    }

        private void btnUSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtUUsername.Text.Trim();

            if (searchText == "")
            {
                MessageBox.Show("يرجى كتابة اسم المستخدم أو جزء منه للبحث.");
                return;
            }

            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();

                string query = "SELECT * FROM Users WHERE Username LIKE @search";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + searchText + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridUsers.DataSource = dt;
            }
        }

        private void btnURefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();

        }

        private void btnUClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
