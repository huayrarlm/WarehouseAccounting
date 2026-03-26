using Microsoft.EntityFrameworkCore;

namespace WarehouseAccounting
{
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
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void LoadOrders()
        {
            try
            {
                using (var db = new ApplicationDBContext())
                {
                    // Проверяем подключение
                    if (!db.Database.CanConnect())
                    {
                        MessageBox.Show("Не могу подключиться к БД!");
                        return;
                    }

                    var orders = db.Orders.ToList();

                    dataGridViewOrders.AutoGenerateColumns = false;
                    dataGridViewOrders.Columns.Clear();

                    // Колонка "IDзаказа"
                    dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "Id",
                        HeaderText = "ID заказа",
                        DataPropertyName = "Id",
                        Width = 250
                    });

                    // Колонка "Артикул"
                    dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "SKU",
                        HeaderText = "Артикул",
                        DataPropertyName = "SKU",
                        Width = 100
                    });

                    // Колонка "Название"
                    dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "Name",
                        HeaderText = "Название",
                        DataPropertyName = "Name",
                        Width = 150
                    });

                    // Колонка "Количество"
                    dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "Quantity",
                        HeaderText = "Количество",
                        DataPropertyName = "Quantity",
                        Width = 80
                    });

                    dataGridViewOrders.DataSource = orders;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void LoadShipments()
        {
            try
            {
                using (var db = new ApplicationDBContext())
                {
                    if (!db.Database.CanConnect())
                    {
                        MessageBox.Show("Не могу подключиться к БД!");
                        return;
                    }

                    var shipments = db.Shipments.ToList();

                    dataGridViewShipments.AutoGenerateColumns = false;
                    dataGridViewShipments.Columns.Clear();

                    // Колонка "ID отгрузки"
                    dataGridViewShipments.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "Id",
                        HeaderText = "ID отгрузки",
                        DataPropertyName = "Id",
                        Width = 250
                    });

                    // Колонка "Артикул"
                    dataGridViewShipments.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "SKU",
                        HeaderText = "Артикул",
                        DataPropertyName = "SKU",
                        Width = 100
                    });

                    // Колонка "Название"
                    dataGridViewShipments.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "Name",
                        HeaderText = "Название",
                        DataPropertyName = "Name",
                        Width = 150
                    });

                    // Колонка "Количество"
                    dataGridViewShipments.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "Quantity",
                        HeaderText = "Количество",
                        DataPropertyName = "Quantity",
                        Width = 80
                    });

                    dataGridViewShipments.DataSource = shipments;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
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
