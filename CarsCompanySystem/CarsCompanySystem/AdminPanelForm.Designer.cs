using System.Drawing;
using System.Windows.Forms;

namespace CarsCompanySystem
{
    partial class AdminPanelForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerPanel;
        private Label lblTitle;

        private Button btnCars;
        private Button btnUsers;
        private Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCars = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Location = new System.Drawing.Point(50, 20);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(700, 70);
            this.headerPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(700, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "لوحة تحكم المدير";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCars
            // 
            this.btnCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCars.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCars.ForeColor = System.Drawing.Color.White;
            this.btnCars.Location = new System.Drawing.Point(150, 150);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(200, 60);
            this.btnCars.TabIndex = 1;
            this.btnCars.Text = "إدارة السيارات";
            this.btnCars.UseVisualStyleBackColor = false;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(450, 150);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(200, 60);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "إدارة العملاء";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(300, 260);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 60);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "تسجيل الخروج";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminPanelForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.btnCars);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnLogout);
            this.Name = "AdminPanelForm";
            this.Text = "Admin Panel";
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
