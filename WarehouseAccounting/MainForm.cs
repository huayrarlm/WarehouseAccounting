namespace WarehouseAccounting
{
    /// <summary>
    /// Основная форма(Добро пожаловать!)
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new RegisterForm();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new AuthoritionForm();
            form.Show();
            this.Hide();
        }
    }
}
