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
                txtPrice.Text = "";
        }

        private void customizeProductButton_Click(object sender, EventArgs e)
        {
            // 1. Проверяем обязательные поля
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
                    MessageBox.Show("Цена должна быть числом", "Ошибка",
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
                        MessageBox.Show("Товар не найден в базе данных", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Проверяем уникальность артикула (если изменился)
                    if (product.SKU != txtSKU.Text.Trim() &&
                        db.Products.Any(p => p.SKU == txtSKU.Text.Trim()))
                    {
                        MessageBox.Show("Товар с таким артикулом уже существует!",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                MessageBox.Show("Товар успешно обновлен!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Обновляем таблицу на главной форме
                UpdateMainFormGrid();

                // Закрываем форму редактирования
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении: {ex.Message}", "Ошибка",
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
