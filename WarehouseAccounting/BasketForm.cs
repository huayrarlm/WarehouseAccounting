using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WarehouseAccounting
{
    public partial class BasketForm : Form
    {
        public BasketForm()
        {
            InitializeComponent();
        }

        private void otgruzPointButton_Click(object sender, EventArgs e)
        {
            // Проверяем, открыто ли уже окно KatalogFormEmployee
            if (Application.OpenForms["KatalogFormEmployee"] is KatalogFormEmployee adminForm)
            {
                // Если окно уже открыто — активируем его
                adminForm.WindowState = FormWindowState.Normal;
                adminForm.Activate();
            }
            else
            {
                // Если не открыто — создаем новое
                var newForm = new KatalogFormEmployee();
                newForm.Show();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Проверяем, открыто ли уже окно OtgruzFormEmployee
            if (Application.OpenForms["OtgruzFormEmployee"] is OtgruzFormEmployee adminForm)
            {
                // Если окно уже открыто — активируем его
                adminForm.WindowState = FormWindowState.Normal;
                adminForm.Activate();
            }
            else
            {
                // Если не открыто — создаем новое
                var newForm = new OtgruzFormEmployee();
                newForm.Show();
                this.Close();
            }
        }
    }
}
