namespace WarehouseAccounting
{
    /// <summary>
    /// Форма отгрузки для администратора
    /// </summary>
    public partial class OtgruzFormAdmin : Form
    {
        public OtgruzFormAdmin()
        {
            InitializeComponent();
        }

        private void otgruzPointButton_Click(object sender, EventArgs e)
        {
            // Проверяем, открыто ли уже окно KatalogFormAdmin
            if (Application.OpenForms["KatalogFormAdmin"] is KatalogFormAdmin adminForm)
            {
                // Если окно уже открыто — активируем его
                adminForm.WindowState = FormWindowState.Normal;
                adminForm.Activate();
            }
            else
            {
                // Если не открыто — создаем новое
                var newForm = new KatalogFormAdmin();
                newForm.Show();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Проверяем, открыто ли уже окно OtgruzFormAdmin
            if (Application.OpenForms["OtgruzFormAdmin"] is OtgruzFormAdmin adminForm)
            {
                // Если окно уже открыто — активируем его
                adminForm.WindowState = FormWindowState.Normal;
                adminForm.Activate();
            }
            else
            {
                // Если не открыто — создаем новое
                var newForm = new OtgruzFormAdmin();
                newForm.Show();
                this.Close();
            }
        }
    }
}
