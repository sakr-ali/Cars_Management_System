using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsCompanySystem
{
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            CarsForm cars = new CarsForm();
            this.Hide();
            cars.ShowDialog();
            this.Show();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersForm users = new UsersForm();
            this.Hide();
            users.ShowDialog();
            this.Show();
        }
    }
}
