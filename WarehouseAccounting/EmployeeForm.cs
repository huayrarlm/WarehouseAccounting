using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WarehouseAccounting
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EmployeeForm : Form
    {
        private User _currentUser;
        public EmployeeForm(User user)
        {
            InitializeComponent();
            _currentUser = user;

            this.Text = $"{Properties.Resources.nameFormEmployee}: {_currentUser.name}";
        }

        private void buttonOtguz_Click(object sender, EventArgs e)
        {
            var formOtgruzFormEmployee = new OtgruzFormEmployee();
            formOtgruzFormEmployee.Show();
            this.Hide();
        }

        private void buttonKatalog_Click(object sender, EventArgs e)
        {
            var formKatalogFormEmployee = new KatalogFormEmployee();
            formKatalogFormEmployee.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonKatalog_Click_1(object sender, EventArgs e)
        {
            var formKatalogEmployee = new KatalogFormEmployee();
            formKatalogEmployee.Show();
            this.Hide();
        }

        private void buttonOtguz_Click_1(object sender, EventArgs e)
        {
            var formOtgruzEmployee = new OtgruzFormEmployee();
            formOtgruzEmployee.Show();
            this.Hide();
        }
    }
}
