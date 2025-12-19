using System.Drawing;
using System.Windows.Forms;

namespace CarsCompanySystem
{
    partial class PurchaseForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerPanel;
        private Label lblTitle;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;

        private TextBox txtCarName;
        private TextBox txtBrand;
        private TextBox txtModel;
        private TextBox txtPrice;
        private TextBox txtCustomerName;
        private TextBox txtCustomerPhone;
        private TextBox txtCustomerAddress;

        private Button btnConfirm;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
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
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(700, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إتمام عملية الشراء";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(70, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم السيارة:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(70, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "الطراز:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(70, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "الموديل:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(70, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "السعر:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(430, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "اسم العميل:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(430, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "رقم الهاتف:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(430, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "العنوان:";
            // 
            // txtCarName
            // 
            this.txtCarName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtCarName.ForeColor = System.Drawing.Color.White;
            this.txtCarName.Location = new System.Drawing.Point(180, 110);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.ReadOnly = true;
            this.txtCarName.Size = new System.Drawing.Size(150, 27);
            this.txtCarName.TabIndex = 8;
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtBrand.ForeColor = System.Drawing.Color.White;
            this.txtBrand.Location = new System.Drawing.Point(180, 150);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.ReadOnly = true;
            this.txtBrand.Size = new System.Drawing.Size(150, 27);
            this.txtBrand.TabIndex = 9;
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtModel.ForeColor = System.Drawing.Color.White;
            this.txtModel.Location = new System.Drawing.Point(180, 190);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(150, 27);
            this.txtModel.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(180, 230);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(150, 27);
            this.txtPrice.TabIndex = 11;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtCustomerName.ForeColor = System.Drawing.Color.White;
            this.txtCustomerName.Location = new System.Drawing.Point(550, 110);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(150, 27);
            this.txtCustomerName.TabIndex = 12;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtCustomerPhone.ForeColor = System.Drawing.Color.White;
            this.txtCustomerPhone.Location = new System.Drawing.Point(550, 150);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(150, 27);
            this.txtCustomerPhone.TabIndex = 13;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtCustomerAddress.ForeColor = System.Drawing.Color.White;
            this.txtCustomerAddress.Location = new System.Drawing.Point(550, 190);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(150, 27);
            this.txtCustomerAddress.TabIndex = 14;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(250, 350);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(180, 45);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "تأكيد الشراء";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(450, 350);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(180, 45);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "رجوع";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PurchaseForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Name = "PurchaseForm";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.PurchaseForm_Load_1);
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
