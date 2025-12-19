using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarsCompanySystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        // ===== خلفية Gradient =====
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(10, 10, 10),
                Color.FromArgb(40, 40, 40),
                90f
            );

            e.Graphics.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }

        // ===== Panel بزوايا ناعمة =====
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

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, mainPanel.Width, mainPanel.Height);

            using (GraphicsPath path = RoundedRect(rect, 20))
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(30, 33, 40)))
            {
                e.Graphics.FillPath(brush, path);
            }
        }


        // ============= كودك الأصلي (لم يتم تغييره) =============

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtRegUsername.Text.Trim();
            string password = txtRegPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("يرجى إدخال جميع البيانات");
                return;
            }

            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();

                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username=@u";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@u", username);

                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("اسم المستخدم موجود مسبقًا، اختر اسمًا آخر.");
                    return;
                }

                string insertQuery = "INSERT INTO Users (Username, Password) VALUES (@u, @p)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);

                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                cmd.ExecuteNonQuery();

                MessageBox.Show("تم إنشاء الحساب بنجاح!");

                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }

        private void linkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
