namespace WarehouseAccounting
{
    public partial class OtgruzFormEmployee : Form
    {
        public OtgruzFormEmployee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

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
                var newForm = new OtgruzFormEmployee();
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
