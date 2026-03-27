using WarehouseAccounting.EnumsRole;

namespace WarehouseAccounting
{
    /// <summary>
    /// Форма регистрации
    /// </summary>
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
                MessageBox.Show(Properties.Resources.InputTextBox, Properties.Resources.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка: пароли совпадают?
            if (password != confirmPassword)
            {
                MessageBox.Show(Properties.Resources.ErrorPassword, Properties.Resources.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка: минимальная длина пароля
            if (password.Length < 4)
            {
                MessageBox.Show(Properties.Resources.ErrorCountSymbolPassword, Properties.Resources.Error,
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
                        MessageBox.Show(Properties.Resources.ErrorEmail, Properties.Resources.Error,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Создаем нового пользователя
                    // По умолчанию роль = "Сотрудник" (обычный кладовщик)
                    // Админов можно создавать только через ба  зу данных

                    string hashedPassword = PasswordHasher.HashPassword(password); //ХЕШИРОВАНИЕ ПАРОЛЯ

                    var newUser = new User
                    {
                        name = name,
                        email = email,
                        password = hashedPassword, // В реальном проекте нужно хешировать!
                        role = Role.Сотрудник   // По умолчанию обычный пользователь
                    };

                    // Добавляем в базу данных
                    db.Users.Add(newUser);
                    db.SaveChanges();

                    MessageBox.Show(Properties.Resources.RegisterGood, Properties.Resources.Good,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Закрываем форму регистрации и возвращаемся к входу
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Properties.Resources.ErrorRegister}: {ex.Message}", Properties.Resources.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
