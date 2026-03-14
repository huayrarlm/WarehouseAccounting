using System;
using System.Linq;
using System.Windows.Forms;

namespace WarehouseAccounting
{
    public partial class AuthoritionForm : Form
    {
        public AuthoritionForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Открываем форму регистрации
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog(); // ShowDialog блокирует основную форму до закрытия
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text.Trim();
            string password = txtpassword.Text;

            // Проверка: поля заполнены?
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите email и пароль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new ApplicationDBContext())
                {
                    // Ищем пользователя с таким email и паролем
                    var user = db.Users.FirstOrDefault(u => u.email == email && u.password == password);

                    if (user != null)
                    {
                        // Пользователь найден - вход выполнен
                        MessageBox.Show($"Добро пожаловать, {user.name}!", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // В зависимости от роли открываем нужную форму
                        if (user.role == "Администратор")
                        {
                            // Открываем форму для администратора
                            AdminForm adminForm = new AdminForm(user);
                            adminForm.Show();
                        }
                        else
                        {
                            // Открываем форму для обычного сотрудника
                            EmployeeForm employeeForm = new EmployeeForm(user);
                            employeeForm.Show();
                        }

                        // Скрываем форму входа (не закрываем, чтобы можно было вернуться)
                        this.Hide();
                    }
                    else
                    {
                        // Пользователь не найден
                        MessageBox.Show("Неверный email или пароль", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при входе: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}