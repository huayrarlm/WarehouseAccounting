using WarehouseAccounting.EnumsRole;

namespace WarehouseAccounting
{
    /// <summary>
    /// Форма авторизации
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
            var registerForm = new RegisterForm();
            registerForm.ShowDialog(); // ShowDialog блокирует основную форму до закрытия
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            var email = txtemail.Text.Trim();
            var password = txtpassword.Text;

            // Проверка: поля заполнены?
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(Properties.Resources.InputEmailAndPassword, Properties.Resources.Error,
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
                        MessageBox.Show(Properties.Resources.ErrorEmailAndPassword, Properties.Resources.Error,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 3. Проверяем пароль с помощью хеширования
                    bool isPasswordCorrect = PasswordHasher.VerifyPassword(password, user.password);

                    if (!isPasswordCorrect)
                    {
                        MessageBox.Show(Properties.Resources.ErrorEmailAndPassword, Properties.Resources.Error,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // ✅ Успешный вход!
                    MessageBox.Show($"{Properties.Resources.Hello}, {user.name}!", Properties.Resources.Good,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // В зависимости от роли открываем нужную форму
                    if (user.role == Role.Администратор)
                    {
                        var adminForm = new AdminForm(user);
                        adminForm.Show();
                    }
                    else
                    {
                        var employeeForm = new EmployeeForm(user);
                        employeeForm.Show();
                    }

                    // Скрываем форму входа
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Properties.Resources.ErrorToGo}", Properties.Resources.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}