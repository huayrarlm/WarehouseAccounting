namespace WarehouseAccounting
{
    public partial class СlientForm : Form
    {
        public СlientForm()
        {
            InitializeComponent();
        }

        private void otgruzPointButton_Click(object sender, EventArgs e)
        {
            // Проверяем, открыто ли уже окно KatalogFormAdmin
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
            // Проверяем, открыто ли уже окно KatalogFormAdmin
            if (Application.OpenForms["OtgruzFormEmployee"] is OtgruzFormEmployee adminForm)
            {
                // Если окно уже открыто — активируем его
                adminForm.WindowState = FormWindowState.Normal;
                adminForm.Activate();
            }
            else
            {
                // Если не открыто — создаем новое
                var newForm = new OtgruzFormEmployee();
                newForm.Show();
                this.Close();
            }
        }
    }
}
