using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace CarsCompanySystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        // ================= خلفية Gradient ============================
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(15, 18, 24),
                Color.FromArgb(45, 48, 55),
                90f
            );

            e.Graphics.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }

        // ================= Panel بزوايا ناعمة ========================
        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);

            path.CloseFigure();
            return path;
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, headerPanel.Width, headerPanel.Height);

            using (GraphicsPath path = RoundedRect(rect, 8))
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(30, 33, 40)))
            {
                e.Graphics.FillPath(brush, path);
            }
        }




        // ================= تحميل السيارات ============================
        private void LoadCars()
        {
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Cars";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridUserCars.DataSource = dt;
            }
        }

        // ================= عند فتح الفورم ============================
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCars();

            // تحسين شكل الـ DataGridView
            dataGridUserCars.EnableHeadersVisualStyles = false;
            dataGridUserCars.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 43, 50);
            dataGridUserCars.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridUserCars.BackgroundColor = Color.FromArgb(35, 38, 45);
            dataGridUserCars.DefaultCellStyle.BackColor = Color.FromArgb(40, 43, 50);
            dataGridUserCars.DefaultCellStyle.ForeColor = Color.White;
            dataGridUserCars.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 255);
            dataGridUserCars.GridColor = Color.Black;
        }

        // ================= شراء سيارة ============================
        private void dataGridUserCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridUserCars.Columns["btnBuy"].Index && e.RowIndex >= 0)
            {
                int carId = Convert.ToInt32(dataGridUserCars.Rows[e.RowIndex].Cells["CarID"].Value);

                PurchaseForm p = new PurchaseForm(carId);
                p.Show();
                this.Hide();
            }
        }







        // ================= تسجيل الخروج ============================
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtUSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnUSearch_Click(object sender, EventArgs e)
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

                dataGridUserCars.DataSource = dt;
            }
        }
    }
}
