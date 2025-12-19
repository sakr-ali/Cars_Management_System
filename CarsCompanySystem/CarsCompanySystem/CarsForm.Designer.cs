using System.Drawing;
using System.Windows.Forms;

namespace CarsCompanySystem
{
    partial class CarsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerPanel;
        private Label lblTitle;

        private Label lblCar;
        private Label lblModel;
        private Label lblBrand;
        private Label lblColor;
        private Label lblYear;
        private Label lblPrice;

        private TextBox txtCarName;
        private TextBox txtModel;
        private TextBox txtBrand;
        private TextBox txtColor;
        private TextBox txtYear;
        private TextBox txtPrice;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnRefresh;
        private Button btnClose;

        private DataGridView dataGridViewCars;

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
            this.headerPanel = new Panel();
            this.lblTitle = new Label();

            this.lblCar = new Label();
            this.lblModel = new Label();
            this.lblBrand = new Label();
            this.lblColor = new Label();
            this.lblYear = new Label();
            this.lblPrice = new Label();

            this.txtCarName = new TextBox();
            this.txtModel = new TextBox();
            this.txtBrand = new TextBox();
            this.txtColor = new TextBox();
            this.txtYear = new TextBox();
            this.txtPrice = new TextBox();

            this.btnAdd = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnSearch = new Button();
            this.btnRefresh = new Button();
            this.btnClose = new Button();

            this.dataGridViewCars = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            this.SuspendLayout();

            // ================= FORM =================
            this.BackColor = Color.FromArgb(25, 25, 25);
            this.ClientSize = new Size(900, 650);
            this.Text = "CarsForm";
            this.Load += new System.EventHandler(this.CarsForm_Load);

            // ================= HEADER =================
            this.headerPanel.BackColor = Color.FromArgb(40, 40, 40);
            this.headerPanel.Size = new Size(800, 70);
            this.headerPanel.Location = new Point(50, 20);

            this.lblTitle.Text = "Cars Management";
            this.lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.AutoSize = false;
            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            this.headerPanel.Controls.Add(this.lblTitle);

            // ================= LABELS =================
            this.lblCar.Text = "Car Name";
            this.lblCar.ForeColor = Color.White;
            this.lblCar.Font = new Font("Segoe UI", 14F);
            this.lblCar.Location = new Point(120, 120);

            this.lblModel.Text = "Model";
            this.lblModel.ForeColor = Color.White;
            this.lblModel.Font = new Font("Segoe UI", 14F);
            this.lblModel.Location = new Point(120, 165);

            this.lblBrand.Text = "Brand";
            this.lblBrand.ForeColor = Color.White;
            this.lblBrand.Font = new Font("Segoe UI", 14F);
            this.lblBrand.Location = new Point(120, 210);

            this.lblColor.Text = "Color";
            this.lblColor.ForeColor = Color.White;
            this.lblColor.Font = new Font("Segoe UI", 14F);
            this.lblColor.Location = new Point(120, 255);

            this.lblYear.Text = "Year";
            this.lblYear.ForeColor = Color.White;
            this.lblYear.Font = new Font("Segoe UI", 14F);
            this.lblYear.Location = new Point(120, 300);

            this.lblPrice.Text = "Price";
            this.lblPrice.ForeColor = Color.White;
            this.lblPrice.Font = new Font("Segoe UI", 14F);
            this.lblPrice.Location = new Point(120, 345);

            // ================= TEXTBOXES =================
            int textX = 250;
            int width = 250;

            this.txtCarName.Location = new Point(textX, 120);
            this.txtCarName.Size = new Size(width, 30);
            this.txtCarName.BackColor = Color.FromArgb(50, 50, 50);
            this.txtCarName.ForeColor = Color.White;
            this.txtCarName.Font = new Font("Segoe UI", 12F);

            this.txtModel.Location = new Point(textX, 165);
            this.txtModel.Size = new Size(width, 30);
            this.txtModel.BackColor = Color.FromArgb(50, 50, 50);
            this.txtModel.ForeColor = Color.White;
            this.txtModel.Font = new Font("Segoe UI", 12F);

            this.txtBrand.Location = new Point(textX, 210);
            this.txtBrand.Size = new Size(width, 30);
            this.txtBrand.BackColor = Color.FromArgb(50, 50, 50);
            this.txtBrand.ForeColor = Color.White;
            this.txtBrand.Font = new Font("Segoe UI", 12F);

            this.txtColor.Location = new Point(textX, 255);
            this.txtColor.Size = new Size(width, 30);
            this.txtColor.BackColor = Color.FromArgb(50, 50, 50);
            this.txtColor.ForeColor = Color.White;
            this.txtColor.Font = new Font("Segoe UI", 12F);

            this.txtYear.Location = new Point(textX, 300);
            this.txtYear.Size = new Size(width, 30);
            this.txtYear.BackColor = Color.FromArgb(50, 50, 50);
            this.txtYear.ForeColor = Color.White;
            this.txtYear.Font = new Font("Segoe UI", 12F);

            this.txtPrice.Location = new Point(textX, 345);
            this.txtPrice.Size = new Size(width, 30);
            this.txtPrice.BackColor = Color.FromArgb(50, 50, 50);
            this.txtPrice.ForeColor = Color.White;
            this.txtPrice.Font = new Font("Segoe UI", 12F);

            // ================= BUTTONS =================
            this.btnAdd.Text = "Add";
            this.btnAdd.BackColor = Color.FromArgb(0, 120, 255);
            this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.ForeColor = Color.White;
            this.btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnAdd.Location = new Point(550, 120);
            this.btnAdd.Size = new Size(150, 35);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.BackColor = Color.FromArgb(255, 140, 0);
            this.btnUpdate.FlatStyle = FlatStyle.Flat;
            this.btnUpdate.ForeColor = Color.White;
            this.btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnUpdate.Location = new Point(550, 165);
            this.btnUpdate.Size = new Size(150, 35);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.BackColor = Color.FromArgb(220, 50, 50);
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.ForeColor = Color.White;
            this.btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnDelete.Location = new Point(550, 210);
            this.btnDelete.Size = new Size(150, 35);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnSearch.Text = "Search";
            this.btnSearch.BackColor = Color.FromArgb(150, 70, 200);
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.ForeColor = Color.White;
            this.btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnSearch.Location = new Point(550, 255);
            this.btnSearch.Size = new Size(150, 35);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.BackColor = Color.FromArgb(80, 100, 140);
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnRefresh.Location = new Point(550, 300);
            this.btnRefresh.Size = new Size(150, 35);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnClose.Text = "Close";
            this.btnClose.BackColor = Color.FromArgb(60, 60, 60);
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.ForeColor = Color.White;
            this.btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnClose.Location = new Point(550, 345);
            this.btnClose.Size = new Size(150, 35);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // ================= DATAGRIDVIEW =================
            this.dataGridViewCars.Location = new Point(120, 400);
            this.dataGridViewCars.Size = new Size(650, 200);

            this.dataGridViewCars.BackgroundColor = Color.FromArgb(35, 35, 35);
            this.dataGridViewCars.GridColor = Color.Gray;
            this.dataGridViewCars.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            this.dataGridViewCars.DefaultCellStyle.ForeColor = Color.White;
            this.dataGridViewCars.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
            this.dataGridViewCars.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dataGridViewCars.EnableHeadersVisualStyles = false;

            this.dataGridViewCars.RowTemplate.Height = 28;
            this.dataGridViewCars.CellContentClick += new DataGridViewCellEventHandler(this.dataGridViewCars_CellContentClick);

            // ================= ADD CONTROLS =================
            this.Controls.Add(this.headerPanel);

            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblPrice);

            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtPrice);

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);

            this.Controls.Add(this.dataGridViewCars);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
