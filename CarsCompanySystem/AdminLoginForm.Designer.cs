namespace CarsCompanySystem
{
    partial class AdminLoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkBack;
        private System.Windows.Forms.TextBox txtAdminUser;
        private System.Windows.Forms.TextBox txtAdminPass;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdminUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.linkBack = new System.Windows.Forms.LinkLabel();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.txtAdminUser);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.txtAdminPass);
            this.mainPanel.Controls.Add(this.linkBack);
            this.mainPanel.Controls.Add(this.btnAdminLogin);
            this.mainPanel.Controls.Add(this.btnExit);
            this.mainPanel.Location = new System.Drawing.Point(200, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(420, 330);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "username";
            // 
            // txtAdminUser
            // 
            this.txtAdminUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.txtAdminUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdminUser.ForeColor = System.Drawing.Color.White;
            this.txtAdminUser.Location = new System.Drawing.Point(40, 65);
            this.txtAdminUser.Name = "txtAdminUser";
            this.txtAdminUser.Size = new System.Drawing.Size(330, 27);
            this.txtAdminUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(40, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "password";
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.txtAdminPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdminPass.ForeColor = System.Drawing.Color.White;
            this.txtAdminPass.Location = new System.Drawing.Point(40, 150);
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.PasswordChar = '●';
            this.txtAdminPass.Size = new System.Drawing.Size(330, 27);
            this.txtAdminPass.TabIndex = 3;
            // 
            // linkBack
            // 
            this.linkBack.AutoSize = true;
            this.linkBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.linkBack.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkBack.Location = new System.Drawing.Point(250, 195);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(112, 28);
            this.linkBack.TabIndex = 4;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "رجوع للخلف";
            this.linkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnAdminLogin.FlatAppearance.BorderSize = 0;
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogin.ForeColor = System.Drawing.Color.White;
            this.btnAdminLogin.Location = new System.Drawing.Point(110, 235);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(200, 40);
            this.btnAdminLogin.TabIndex = 5;
            this.btnAdminLogin.Text = "تسجيل الدخول";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(155, 285);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "رجوع";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AdminLoginForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
