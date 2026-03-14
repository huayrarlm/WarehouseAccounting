using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WarehouseAccounting
{
    public partial class EmployeeForm : Form
    {
        private User _currentUser;
        public EmployeeForm(User user)
        {
            InitializeComponent();
            _currentUser = user;

            this.Text = $"Сотрудник: {_currentUser.name}";
        }
    }
}
