namespace WarehouseAccounting
{
    /// <summary>
    /// Форма меню кладовщика (после авторизации)
    /// </summary>
    public partial class EmployeeForm : Form
    {
        private User currentUser;
        public EmployeeForm(User user)
        {
            InitializeComponent();
            currentUser = user;

            this.Text = $"{Properties.Resources.nameFormEmployee}: {currentUser.name}";
        }

        private void buttonOtguz_Click(object sender, EventArgs e)
        {
            var formOtgruzFormEmployee = new OtgruzFormEmployee(currentUser);
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
            var formOtgruzEmployee = new OtgruzFormEmployee(currentUser);
            formOtgruzEmployee.Show();
            this.Hide();
        }
    }
}
