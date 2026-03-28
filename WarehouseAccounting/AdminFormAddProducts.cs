using WarehouseAccounting.Models;

namespace WarehouseAccounting
{
    /// <summary>
    /// форма добавлении товара в каталог(для администратор)
    /// </summary>
    public partial class AdminFormAddProducts : Form
    {
        public AdminFormAddProducts()
        {
            InitializeComponent();
        }
        private void otgruzPointButton_Click(object sender, EventArgs e)
        {
            // Проверяем, открыто ли уже окно OtgruzFormAdmin
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

        private void addProductButton_Click(object sender, EventArgs e)
        {
            // 1. Проверяем, что все обязательные поля заполнены
            if (string.IsNullOrWhiteSpace(txtSKU.Text))
            {
                MessageBox.Show("Введите артикул товара", Properties.Resources.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSKU.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите название товара", Properties.Resources.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }


            // 2. Создаем новый товар
            var newProduct = new Product
            {
                Id = Guid.NewGuid(),
                SKU = txtSKU.Text.Trim(),
                Name = txtName.Text.Trim(),
                Category = txtCategory.Text.Trim(),
                Unit = txtUnit.Text.Trim()
            };

            // 3. Преобразуем цену (если введена)
            if (!string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                if (decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    if (price < 0)
                    {
                        MessageBox.Show("Цена не может быть отрицательной!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPrice.Focus();
                        return;
                    }
                    newProduct.Price = price;
                }
                else
                {
                    MessageBox.Show(Properties.Resources.PriceIsDigital, Properties.Resources.Error,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrice.Focus();
                    return;
                }
            }

            // 4. Преобразуем количество (если введено)
            if (!string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                if (int.TryParse(txtQuantity.Text, out int quantity))
                {
                    newProduct.Quantity = quantity;
                }
                else
                {
                    MessageBox.Show(Properties.Resources.PriceIsDigital, Properties.Resources.Error,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQuantity.Focus();
                    return;
                }
            }

            // 5. Сохраняем в базу данных
            try
            {
                using (var db = new ApplicationDBContext())
                {
                    // Проверяем, нет ли товара с таким артикулом
                    if (db.Products.Any(p => p.SKU == newProduct.SKU))
                    {
                        MessageBox.Show(Properties.Resources.ArticulError,
                            Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    db.Products.Add(newProduct);
                    db.SaveChanges();
                }

                MessageBox.Show(Properties.Resources.GoodAdd, Properties.Resources.Good,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 6. Очищаем поля для следующего ввода
                ClearForm();

                // 7. Обновляем таблицу на главной форме
                UpdateMainFormGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Properties.Resources.ErrorProduct}: {ex.Message}", Properties.Resources.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Очистка полей формы
        private void ClearForm()
        {
            txtSKU.Text = string.Empty;
            txtName.Text = string.Empty;
            txtCategory.Text = string.Empty;
            txtUnit.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtSKU.Focus();
        }

        // Обновление таблицы на главной форме

        private void UpdateMainFormGrid()
        {
            // Ищем открытую форму AdminForm или EmployeeForm
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
