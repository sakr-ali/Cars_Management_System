namespace CarsCompanySystem
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel linkBackToLogin;

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
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.linkBackToLogin = new System.Windows.Forms.LinkLabel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.txtRegUsername);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.txtRegPassword);
            this.mainPanel.Controls.Add(this.linkBackToLogin);
            this.mainPanel.Controls.Add(this.btnRegister);
            this.mainPanel.Location = new System.Drawing.Point(216, 64);
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
            this.label1.Size = new System.Drawing.Size(192, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "username";
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.txtRegUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegUsername.ForeColor = System.Drawing.Color.White;
            this.txtRegUsername.Location = new System.Drawing.Point(28, 85);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(330, 27);
            this.txtRegUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(40, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "password";
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.txtRegPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegPassword.ForeColor = System.Drawing.Color.White;
            this.txtRegPassword.Location = new System.Drawing.Point(40, 150);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.PasswordChar = '●';
            this.txtRegPassword.Size = new System.Drawing.Size(330, 27);
            this.txtRegPassword.TabIndex = 3;
            // 
            // linkBackToLogin
            // 
            this.linkBackToLogin.AutoSize = true;
            this.linkBackToLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.linkBackToLogin.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkBackToLogin.Location = new System.Drawing.Point(230, 195);
            this.linkBackToLogin.Name = "linkBackToLogin";
            this.linkBackToLogin.Size = new System.Drawing.Size(196, 28);
            this.linkBackToLogin.TabIndex = 4;
            this.linkBackToLogin.TabStop = true;
            this.linkBackToLogin.Text = "العودة لتسجيل الدخول";
            this.linkBackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBackToLogin_LinkClicked);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(110, 235);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(200, 40);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "إنشاء حساب";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // RegisterForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1073, 656);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load_1);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
