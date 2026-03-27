namespace WarehouseAccounting
{
    /// <summary>
    /// Форма меню админ аккаунта(после авторизации)
    /// </summary>
    public partial class AdminForm : Form
    {
        private User _currentUser;

        public AdminForm(User user)
        {
            InitializeComponent();
            _currentUser = user;

            // Отображаем имя пользователя в заголовке или на форме
            this.Text = $"{Properties.Resources.nameFormAdmin}: {_currentUser.name}";
        }

        private void buttonKatalog_Click(object sender, EventArgs e)
        {
            var formKatalogFormAdmin = new KatalogFormAdmin();
            formKatalogFormAdmin.Show();
            this.Hide();
        }

        private void buttonOtguz_Click(object sender, EventArgs e)
        {
            var formOtgruzFormAdmin = new OtgruzFormAdmin();
            formOtgruzFormAdmin.Show();
            this.Hide();
        }
    }
}