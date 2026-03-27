namespace WarehouseAccounting
{
    /// <summary>
    /// Форма отгрузки для кладовщика
    /// </summary>
    public partial class OtgruzFormEmployee : Form
    {
        private User currentUser;

        public OtgruzFormEmployee(User currentUser)
        {
            InitializeComponent();
            // Простейший тест
            try
            {
                using (var db = new ApplicationDBContext())
                {
                    var count = db.Orders.Count();
                    MessageBox.Show($"В таблице Order {count} записей");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Properties.Resources.Error}: {ex.Message}");
            }
        }
        private void otgruzPointButton_Click(object sender, EventArgs e)
        {
            // Проверяем, открыто ли уже окно KatalogFormEmployee
            if (Application.OpenForms["KatalogFormEmployee"] is KatalogFormEmployee adminForm)
            {
                // Если окно уже открыто — активируем его
                adminForm.WindowState = FormWindowState.Normal;
                adminForm.Activate();
            }
            else
            {
                // Если не открыто — создаем новое
                var newForm = new KatalogFormEmployee();
                newForm.Show();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Проверяем, открыто ли уже окно OtgruzFormEmployee
            if (Application.OpenForms["OtgruzFormEmployee"] is OtgruzFormEmployee adminForm)
            {
                // Если окно уже открыто — активируем его
                adminForm.WindowState = FormWindowState.Normal;
                adminForm.Activate();
            }
            else
            {
                // Если не открыто — создаем новое
                var newForm = new OtgruzFormEmployee(currentUser);
                newForm.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formClient = new СlientForm();
            formClient.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var formAddBasket = new BasketForm();
            formAddBasket.Show();
        }
    }
}
