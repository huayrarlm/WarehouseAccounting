using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WarehouseAccounting
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            // Получаем данные из текстовых полей
            var name = txtname.Text.Trim();
            var email = txtemail.Text.Trim();
            var password = txtpassword.Text;
            var confirmPassword = txtConfirmPassword.Text;

            // Проверка: все поля заполнены?
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка: пароли совпадают?
            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка: минимальная длина пароля
            if (password.Length < 4)
            {
                MessageBox.Show("Пароль должен содержать не менее 4 символов", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Создаем контекст базы данных
                using (var db = new ApplicationDBContext())
                {
                    // Проверяем, не занят ли email
                    var existingUser = db.Users.FirstOrDefault(u => u.email == email);
                    if (existingUser != null)
                    {
                        MessageBox.Show("Пользователь с таким email уже существует", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Создаем нового пользователя
                    // По умолчанию роль = "Сотрудник" (обычный кладовщик)
                    // Админов можно создавать только через ба  зу данных
                    var newUser = new User
                    {
                        name = name,
                        email = email,
                        password = password, // В реальном проекте нужно хешировать!
                        role = "Сотрудник"   // По умолчанию обычный пользователь
                    };

                    // Добавляем в базу данных
                    db.Users.Add(newUser);
                    db.SaveChanges();

                    MessageBox.Show("Регистрация прошла успешно!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Закрываем форму регистрации и возвращаемся к входу
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при регистрации: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
