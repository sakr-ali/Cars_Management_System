namespace CarsCompanySystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridUserCars = new System.Windows.Forms.DataGridView();
            this.btnBuy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnUSearch = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserCars)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Transparent;
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Location = new System.Drawing.Point(20, 12);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(760, 70);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.headerPanel_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(219, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(356, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "نظام البحث عن السيارات";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // dataGridUserCars
            // 
            this.dataGridUserCars.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.dataGridUserCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUserCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnBuy});
            this.dataGridUserCars.Location = new System.Drawing.Point(20, 180);
            this.dataGridUserCars.Name = "dataGridUserCars";
            this.dataGridUserCars.RowHeadersWidth = 62;
            this.dataGridUserCars.Size = new System.Drawing.Size(760, 180);
            this.dataGridUserCars.TabIndex = 5;
            this.dataGridUserCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUserCars_CellContentClick);
            // 
            // btnBuy
            // 
            this.btnBuy.HeaderText = "شراء";
            this.btnBuy.MinimumWidth = 8;
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Width = 150;
            // 
            // btnUSearch
            // 
            this.btnUSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.btnUSearch.FlatAppearance.BorderSize = 0;
            this.btnUSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSearch.ForeColor = System.Drawing.Color.White;
            this.btnUSearch.Location = new System.Drawing.Point(650, 130);
            this.btnUSearch.Name = "btnUSearch";
            this.btnUSearch.Size = new System.Drawing.Size(70, 30);
            this.btnUSearch.TabIndex = 3;
            this.btnUSearch.Text = "بحث";
            this.btnUSearch.UseVisualStyleBackColor = false;
            this.btnUSearch.Click += new System.EventHandler(this.btnUSearch_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(20, 380);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 35);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "تسجيل الخروج";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtCarName
            // 
            this.txtCarName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.txtCarName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarName.ForeColor = System.Drawing.Color.White;
            this.txtCarName.Location = new System.Drawing.Point(460, 130);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(180, 27);
            this.txtCarName.TabIndex = 2;
            this.txtCarName.Text = "x";
            this.txtCarName.TextChanged += new System.EventHandler(this.txtUSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(598, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "بحث عن سيارة";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.btnUSearch);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dataGridUserCars);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridUserCars;
        private System.Windows.Forms.DataGridViewButtonColumn btnBuy;
        private System.Windows.Forms.Button btnUSearch;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Label label1;
    }
}
