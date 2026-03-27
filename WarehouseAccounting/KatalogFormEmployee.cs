using System.Data;

namespace WarehouseAccounting
{
    /// <summary>
    /// Форма каталог товаров для кладовщика
    /// </summary>
    public partial class KatalogFormEmployee : Form
    {
        private User currentUser;
        public KatalogFormEmployee()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void button1_Click(object sender, EventArgs e)
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
                this.Hide();
            }
        }
        protected virtual void LoadProducts()
        {
            try
            {
                using (var db = new ApplicationDBContext())
                {
                    var products = db.Products
                        .OrderBy(p => p.SKU)
                        .ToList();

                    dataGridViewProducts.DataSource = products;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Properties.Resources.ErrorProduct}: {ex.Message}", Properties.Resources.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///Публметичный метод для прогрузки таблиц
        /// </summary>
        public void RefreshProducts()
        {
            LoadProducts();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text.Trim();

            try
            {
                using (var db = new ApplicationDBContext())
                {
                    var query = db.Products.AsQueryable();

                    if (!string.IsNullOrWhiteSpace(searchText))
                    {
                        string searchLower = searchText.ToLower();

                        query = query.Where(p =>
                            p.SKU.ToLower().Contains(searchLower) ||
                            p.Name.ToLower().Contains(searchLower) ||
                            (p.Category != null && p.Category.ToLower().Contains(searchLower)) ||
                            (p.Unit != null && p.Unit.ToLower().Contains(searchLower)) ||
                            (p.Price != null && p.Price.ToString().Contains(searchText))
                        );
                    }

                    var products = query.OrderBy(p => p.SKU).ToList();

                    dataGridViewProducts.DataSource = products;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Properties.Resources.ErrorSearch}: {ex.Message}", Properties.Resources.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
