using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarsCompanySystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        // خلفية داكنة متدرجة (Gradient)
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

        // رسم البانل بزوايا ناعمة
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




        // ===================== كودك الأصلي كما هو =========================

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.Show();
            this.Hide();
        }

        private void linkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLoginForm admin = new AdminLoginForm();
            admin.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("يرجى إدخال اسم المستخدم وكلمة المرور");
                return;
            }

            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Username=@u AND Password=@p";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("تم تسجيل الدخول بنجاح!");

                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("خطأ: اسم المستخدم أو كلمة المرور غير صحيحين.");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("هل تريد الخروج من البرنامج؟",
                "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
