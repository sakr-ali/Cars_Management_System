using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CarsCompanySystem
{
    public partial class CarsForm : Form
    {
        public CarsForm()
        {
            InitializeComponent();
        }

        private void LoadCars()
        {
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cars", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewCars.DataSource = dt;
            }
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void dataGridViewCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCars.Rows[e.RowIndex];

                txtCarName.Text = row.Cells["CarName"].Value.ToString();
                txtModel.Text = row.Cells["Model"].Value.ToString();
                txtBrand.Text = row.Cells["Brand"].Value.ToString();
                txtColor.Text = row.Cells["Color"].Value.ToString();
                txtYear.Text = row.Cells["Year"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Cars (CarName, Model, Brand, Color, Year, Price) VALUES (@n,@m,@b,@c,@y,@p)",
                    con);

                cmd.Parameters.AddWithValue("@n", txtCarName.Text);
                cmd.Parameters.AddWithValue("@m", txtModel.Text);
                cmd.Parameters.AddWithValue("@b", txtBrand.Text);
                cmd.Parameters.AddWithValue("@c", txtColor.Text);
                cmd.Parameters.AddWithValue("@y", Convert.ToInt32(txtYear.Text));
                cmd.Parameters.AddWithValue("@p", Convert.ToDecimal(txtPrice.Text));

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("تمت الإضافة!");
            LoadCars();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewCars.CurrentRow == null)
            {
                MessageBox.Show("اختر سيارة أولاً");
                return;
            }

            int id = Convert.ToInt32(dataGridViewCars.CurrentRow.Cells["CarID"].Value);

            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Cars SET CarName=@n, Model=@m, Brand=@b, Color=@c, Year=@y, Price=@p WHERE CarID=@id",
                    con);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@n", txtCarName.Text);
                cmd.Parameters.AddWithValue("@m", txtModel.Text);
                cmd.Parameters.AddWithValue("@b", txtBrand.Text);
                cmd.Parameters.AddWithValue("@c", txtColor.Text);
                cmd.Parameters.AddWithValue("@y", Convert.ToInt32(txtYear.Text));
                cmd.Parameters.AddWithValue("@p", Convert.ToDecimal(txtPrice.Text));

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("تم التعديل!");
            LoadCars();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCars.CurrentRow == null)
            {
                MessageBox.Show("اختر سيارة أولاً");
                return;
            }

            int id = Convert.ToInt32(dataGridViewCars.CurrentRow.Cells["CarID"].Value);

            DialogResult result = MessageBox.Show("هل تريد الحذف؟", "تأكيد", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Cars WHERE CarID=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("تم الحذف!");
            LoadCars();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string text = txtCarName.Text.Trim();

            if (text == "")
            {
                MessageBox.Show("اكتب كلمة للبحث");
                return;
            }

            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Cars WHERE CarName LIKE @t OR Model LIKE @t OR Brand LIKE @t", con);
                da.SelectCommand.Parameters.AddWithValue("@t", "%" + text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewCars.DataSource = dt;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
