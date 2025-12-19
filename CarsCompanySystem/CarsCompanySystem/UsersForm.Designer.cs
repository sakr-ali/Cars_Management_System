using System.Drawing;
using System.Windows.Forms;

namespace CarsCompanySystem
{
    partial class UsersForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerPanel;
        private Label lblTitle;

        private Label label1;
        private Label label2;

        private TextBox txtUUsername;
        private TextBox txtUPassword;

        private Button btnUAdd;
        private Button btnUUpdate;
        private Button btnUDelete;
        private Button btnUSearch;
        private Button btnURefresh;
        private Button btnUClose;

        private DataGridView dataGridUsers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUUsername = new System.Windows.Forms.TextBox();
            this.txtUPassword = new System.Windows.Forms.TextBox();
            this.btnUAdd = new System.Windows.Forms.Button();
            this.btnUUpdate = new System.Windows.Forms.Button();
            this.btnUDelete = new System.Windows.Forms.Button();
            this.btnUSearch = new System.Windows.Forms.Button();
            this.btnURefresh = new System.Windows.Forms.Button();
            this.btnUClose = new System.Windows.Forms.Button();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Location = new System.Drawing.Point(50, 20);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(700, 60);
            this.headerPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(700, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إدارة المستخدمين";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(80, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم المستخدم:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(80, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "كلمة المرور:";
            // 
            // txtUUsername
            // 
            this.txtUUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtUUsername.ForeColor = System.Drawing.Color.White;
            this.txtUUsername.Location = new System.Drawing.Point(220, 120);
            this.txtUUsername.Name = "txtUUsername";
            this.txtUUsername.Size = new System.Drawing.Size(180, 27);
            this.txtUUsername.TabIndex = 3;
            // 
            // txtUPassword
            // 
            this.txtUPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtUPassword.ForeColor = System.Drawing.Color.White;
            this.txtUPassword.Location = new System.Drawing.Point(220, 170);
            this.txtUPassword.Name = "txtUPassword";
            this.txtUPassword.Size = new System.Drawing.Size(180, 27);
            this.txtUPassword.TabIndex = 4;
            this.txtUPassword.UseSystemPasswordChar = true;
            // 
            // btnUAdd
            // 
            this.btnUAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnUAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUAdd.ForeColor = System.Drawing.Color.White;
            this.btnUAdd.Location = new System.Drawing.Point(450, 110);
            this.btnUAdd.Name = "btnUAdd";
            this.btnUAdd.Size = new System.Drawing.Size(150, 40);
            this.btnUAdd.TabIndex = 5;
            this.btnUAdd.Text = "إضافة";
            this.btnUAdd.UseVisualStyleBackColor = false;
            this.btnUAdd.Click += new System.EventHandler(this.btnUAdd_Click);
            // 
            // btnUUpdate
            // 
            this.btnUUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnUUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUUpdate.Location = new System.Drawing.Point(450, 160);
            this.btnUUpdate.Name = "btnUUpdate";
            this.btnUUpdate.Size = new System.Drawing.Size(150, 40);
            this.btnUUpdate.TabIndex = 6;
            this.btnUUpdate.Text = "تعديل";
            this.btnUUpdate.UseVisualStyleBackColor = false;
            this.btnUUpdate.Click += new System.EventHandler(this.btnUUpdate_Click);
            // 
            // btnUDelete
            // 
            this.btnUDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUDelete.ForeColor = System.Drawing.Color.White;
            this.btnUDelete.Location = new System.Drawing.Point(450, 210);
            this.btnUDelete.Name = "btnUDelete";
            this.btnUDelete.Size = new System.Drawing.Size(150, 40);
            this.btnUDelete.TabIndex = 7;
            this.btnUDelete.Text = "حذف";
            this.btnUDelete.UseVisualStyleBackColor = false;
            this.btnUDelete.Click += new System.EventHandler(this.btnUDelete_Click);
            // 
            // btnUSearch
            // 
            this.btnUSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.btnUSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUSearch.ForeColor = System.Drawing.Color.White;
            this.btnUSearch.Location = new System.Drawing.Point(450, 260);
            this.btnUSearch.Name = "btnUSearch";
            this.btnUSearch.Size = new System.Drawing.Size(150, 40);
            this.btnUSearch.TabIndex = 8;
            this.btnUSearch.Text = "بحث";
            this.btnUSearch.UseVisualStyleBackColor = false;
            this.btnUSearch.Click += new System.EventHandler(this.btnUSearch_Click);
            // 
            // btnURefresh
            // 
            this.btnURefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnURefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnURefresh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnURefresh.ForeColor = System.Drawing.Color.White;
            this.btnURefresh.Location = new System.Drawing.Point(270, 310);
            this.btnURefresh.Name = "btnURefresh";
            this.btnURefresh.Size = new System.Drawing.Size(250, 40);
            this.btnURefresh.TabIndex = 9;
            this.btnURefresh.Text = "إرجاع جميع المستخدمين";
            this.btnURefresh.UseVisualStyleBackColor = false;
            this.btnURefresh.Click += new System.EventHandler(this.btnURefresh_Click);
            // 
            // btnUClose
            // 
            this.btnUClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUClose.ForeColor = System.Drawing.Color.White;
            this.btnUClose.Location = new System.Drawing.Point(610, 470);
            this.btnUClose.Name = "btnUClose";
            this.btnUClose.Size = new System.Drawing.Size(150, 40);
            this.btnUClose.TabIndex = 10;
            this.btnUClose.Text = "إغلاق";
            this.btnUClose.UseVisualStyleBackColor = false;
            this.btnUClose.Click += new System.EventHandler(this.btnUClose_Click);
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUsers.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridUsers.Location = new System.Drawing.Point(50, 370);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.RowHeadersWidth = 62;
            this.dataGridUsers.Size = new System.Drawing.Size(700, 90);
            this.dataGridUsers.TabIndex = 11;
            // 
            // UsersForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUUsername);
            this.Controls.Add(this.txtUPassword);
            this.Controls.Add(this.btnUAdd);
            this.Controls.Add(this.btnUUpdate);
            this.Controls.Add(this.btnUDelete);
            this.Controls.Add(this.btnUSearch);
            this.Controls.Add(this.btnURefresh);
            this.Controls.Add(this.btnUClose);
            this.Controls.Add(this.dataGridUsers);
            this.Name = "UsersForm";
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
