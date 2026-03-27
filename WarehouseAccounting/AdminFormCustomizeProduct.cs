using WarehouseAccounting.Models;

namespace WarehouseAccounting
{
    /// <summary>
    /// форма редактирования товара(для администратора)
    /// </summary>
    public partial class AdminFormCustomizeProduct : Form
    {
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
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Проверяем, открыто ли уже окно KatalogFormAdmin
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

        private Product _product;

        // Конструктор, который принимает выбранный товар
        public AdminFormCustomizeProduct(Product product)
        {
            InitializeComponent();
            _product = product;
            LoadProductData(); // Загружаем данные в поля
        }
        // Загружаем данные товара в поля формы
        private void LoadProductData()
        {
            txtSKU.Text = _product.SKU;
            txtName.Text = _product.Name;
            txtCategory.Text = _product.Category;
            txtUnit.Text = _product.Unit;

            if (_product.Price.HasValue)
                txtPrice.Text = _product.Price.Value.ToString();
            else
                txtPrice.Text = string.Empty;
        }

        private void customizeProductButton_Click(object sender, EventArgs e)
        {
            // 1. Проверяем обязательные поля
            if (string.IsNullOrWhiteSpace(txtSKU.Text))
            {
                MessageBox.Show(Properties.Resources.InputArticul, Properties.Resources.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSKU.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show(Properties.Resources.InputNameProduct, Properties.Resources.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            // 2. Проверяем цену (если введена)
            decimal? price = null;
            if (!string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                if (decimal.TryParse(txtPrice.Text, out decimal priceValue))
                {
                    price = priceValue;
                }
                else
                {
                    MessageBox.Show(Properties.Resources.PriceIsDigital, Properties.Resources.Error,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrice.Focus();
                    return;
                }
            }

            // 3. Сохраняем изменения в базу
            try
            {
                using (var db = new ApplicationDBContext())
                {
                    // Находим товар в базе
                    var product = db.Products.Find(_product.Id);

                    if (product == null)
                    {
                        MessageBox.Show(Properties.Resources.ProductNoBD, Properties.Resources.Error,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Проверяем уникальность артикула (если изменился)
                    if (product.SKU != txtSKU.Text.Trim() &&
                        db.Products.Any(p => p.SKU == txtSKU.Text.Trim()))
                    {
                        MessageBox.Show(Properties.Resources.ArticulError,
                            Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Обновляем поля
                    product.SKU = txtSKU.Text.Trim();
                    product.Name = txtName.Text.Trim();
                    product.Category = txtCategory.Text.Trim();
                    product.Unit = txtUnit.Text.Trim();
                    product.Price = price;

                    db.SaveChanges();
                }

                MessageBox.Show(Properties.Resources.ProductUploading, Properties.Resources.Good,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Обновляем таблицу на главной форме
                UpdateMainFormGrid();

                // Закрываем форму редактирования
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Properties.Resources.ErrorUploading} {ex.Message}", Properties.Resources.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обновление таблицы на главной форме
        private void UpdateMainFormGrid()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is KatalogFormAdmin adminForm)
                {
                    adminForm.RefreshProducts();
                    break;
                }
                else if (form is KatalogFormEmployee employeeForm)
                {
                    employeeForm.RefreshProducts();
                    break;
                }
            }
        }
    }
}
