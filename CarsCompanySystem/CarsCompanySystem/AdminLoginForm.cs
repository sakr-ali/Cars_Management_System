using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CarsCompanySystem
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        // خلفية متدرجة Gradient
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

        // رسم Panel بزوايا ناعمة
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

        // دالة تسجيل دخول المدير
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string user = txtAdminUser.Text.Trim();
            string pass = txtAdminPass.Text.Trim();

            if (user == "admin" && pass == "12345")
            {
                MessageBox.Show("مرحبًا أيها المدير!");

                AdminPanelForm admin = new AdminPanelForm();
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("خطأ: بيانات المدير غير صحيحة.");
            }
        }

        // دالة الرجوع
        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        // زر الرجوع (نفس وظيفة الرابط)
        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
