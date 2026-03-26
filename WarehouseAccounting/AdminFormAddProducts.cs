using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using WarehouseAccounting.Models;

namespace WarehouseAccounting
{
    public partial class AdminFormAddProducts : Form
    {
        public AdminFormAddProducts()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("Введите артикул товара", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSKU.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите название товара", "Ошибка",
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
                    newProduct.Price = price;
                }
                else
                {
                    MessageBox.Show("Цена должна быть числом", "Ошибка",
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
                    MessageBox.Show("Количество должно быть целым числом", "Ошибка",
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
                        MessageBox.Show("Товар с таким артикулом уже существует!",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    db.Products.Add(newProduct);
                    db.SaveChanges();
                }

                MessageBox.Show("Товар успешно добавлен!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 6. Очищаем поля для следующего ввода
                ClearForm();

                // 7. Обновляем таблицу на главной форме
                UpdateMainFormGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении товара: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Очистка полей формы
        private void ClearForm()
        {
            txtSKU.Text = "";
            txtName.Text = "";
            txtCategory.Text = "";
            txtUnit.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
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
