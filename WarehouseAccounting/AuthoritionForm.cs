using System;
using System.Linq;
using System.Windows.Forms;

namespace WarehouseAccounting
{
    /// <summary>
    /// 
    /// </summary>
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
            var email = txtemail.Text.Trim();
            var password = txtpassword.Text;

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
                    //Сначала находим пользователя по email
                    var user = db.Users.FirstOrDefault(u => u.email == email);

                    //Проверяем, существует ли пользователь
                    if (user == null)
                    {
                        MessageBox.Show("Неверный email или пароль", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 3. Проверяем пароль с помощью хеширования
                    bool isPasswordCorrect = PasswordHasher.VerifyPassword(password, user.password);

                    if (!isPasswordCorrect)
                    {
                        MessageBox.Show("Неверный email или пароль", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // ✅ Успешный вход!
                    MessageBox.Show($"Добро пожаловать, {user.name}!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // В зависимости от роли открываем нужную форму
                    if (user.role == "Администратор")
                    {
                        AdminForm adminForm = new AdminForm(user);
                        adminForm.Show();
                    }
                    else
                    {
                        EmployeeForm employeeForm = new EmployeeForm(user);
                        employeeForm.Show();
                    }

                    // Скрываем форму входа
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при входе", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}