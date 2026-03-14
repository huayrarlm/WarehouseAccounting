using System;
using System.Windows.Forms;

namespace WarehouseAccounting
{
    public partial class AdminForm : Form
    {
        private User _currentUser;

        public AdminForm(User user)
        {
            InitializeComponent();
            _currentUser = user;

            // Отображаем имя пользователя в заголовке или на форме
            this.Text = $"Администратор: {_currentUser.name}";
        }
    }
}