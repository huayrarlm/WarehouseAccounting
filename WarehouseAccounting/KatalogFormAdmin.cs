using System.Data;
using WarehouseAccounting.Models;

namespace WarehouseAccounting
{
    /// <summary>
    /// Форма каталог товаров для администратора
    /// </summary>
    public partial class KatalogFormAdmin : Form
    {
        protected BindingSource productsBindingSource = new BindingSource();
        protected User CurrentUser { get; set; }

        public KatalogFormAdmin()
        {
            InitializeComponent();
            LoadProducts();
        }

        public KatalogFormAdmin(User user)
        {
            CurrentUser = user;
            InitializeComponent();
        }

        // Загрузка данных из БД в DataGridView
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
        /// Публметичный метод для прогрузки таблиц
        /// </summary>
        public void RefreshProducts()
        {
            LoadProducts();
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
                this.Hide();
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            var formAdd = new AdminFormAddProducts();
            formAdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли товар
            if (dataGridViewProducts.CurrentRow == null)
            {
                MessageBox.Show(Properties.Resources.ClickProductCustomize, Properties.Resources.Warring,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем выбранный товар
            var selectedProduct = (Product)dataGridViewProducts.CurrentRow.DataBoundItem;

            if (selectedProduct == null)
            {
                MessageBox.Show($"{Properties.Resources.Error}: {Properties.Resources.ProductNoBD}", Properties.Resources.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Открываем форму редактирования
            using (var customizeForm = new AdminFormCustomizeProduct(selectedProduct))
            {
                customizeForm.ShowDialog();
            }

            // Обновляем таблицу после редактирования
            RefreshProducts();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void buttonGener_Click(object sender, EventArgs e)
        {
            // 1. Проверяем, выбран ли товар
            if (dataGridViewProducts.CurrentRow == null)
            {
                MessageBox.Show("Выберите товар для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Получаем выбранный товар
            var selectedProduct = (Product)dataGridViewProducts.CurrentRow.DataBoundItem;

            if (selectedProduct == null)
            {
                MessageBox.Show($"{Properties.Resources.Error}: {Properties.Resources.ProductNoBD}", Properties.Resources.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Запрашиваем подтверждение удаления
            DialogResult result = MessageBox.Show(
                $"Вы уверены, что хотите удалить товар '{selectedProduct.Name}'?\n\n" +
                $"Артикул: {selectedProduct.SKU}\n" +
                $"Остаток: {selectedProduct.Quantity} шт.",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            // 4. Удаляем товар из базы данных
            try
            {
                using (var db = new ApplicationDBContext())
                {
                    // Находим товар в базе
                    var product = db.Products.Find(selectedProduct.Id);

                    if (product == null)
                    {
                        MessageBox.Show(Properties.Resources.ProductNoBD, Properties.Resources.Error,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Удаляем товар
                    db.Products.Remove(product);
                    db.SaveChanges();
                }

                MessageBox.Show($"Товар '{selectedProduct.Name}' успешно удален!", Properties.Resources.Good,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5. Обновляем таблицу
                RefreshProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Properties.Resources.ErrorProduct}: {ex.Message}", Properties.Resources.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
