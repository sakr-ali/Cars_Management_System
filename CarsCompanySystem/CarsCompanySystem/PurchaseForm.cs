using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;


namespace CarsCompanySystem
{
    public partial class PurchaseForm : Form
    {
        int SelectedCarID;

        public PurchaseForm(int carId)
        {
            InitializeComponent();
            SelectedCarID = carId;
        }

        private void LoadCarDetails()
        {
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();

                string query = "SELECT CarName, Brand, Model, Price FROM Cars WHERE CarID=@id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", SelectedCarID);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtCarName.Text = dr["CarName"].ToString();
                    txtBrand.Text = dr["Brand"].ToString();
                    txtModel.Text = dr["Model"].ToString();
                    txtPrice.Text = dr["Price"].ToString();
                }
            }
        }


        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            LoadCarDetails();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string custName = txtCustomerName.Text.Trim();
            string custPhone = txtCustomerPhone.Text.Trim();
            string custAddress = txtCustomerAddress.Text.Trim();

            if (custName == "" || custPhone == "" || custAddress == "")
            {
                MessageBox.Show("يرجى إدخال بيانات المشتري كاملة.");
                return;
            }

            MessageBox.Show("تم تأكيد عملية الشراء بنجاح!\nسيتم التواصل معك قريبًا.",
                "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void PurchaseForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
