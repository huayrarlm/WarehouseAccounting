namespace WarehouseAccounting
{
    partial class AdminFormCustomizeProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            customizeProductButton = new Button();
            txtPrice = new TextBox();
            label4 = new Label();
            txtUnit = new TextBox();
            label3 = new Label();
            txtCategory = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            txtSKU = new TextBox();
            addProductLabel1 = new Label();
            addProducts = new Label();
            panel4 = new Panel();
            button3 = new Button();
            otgruzPointButton = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 217, 217);
            panel1.Controls.Add(customizeProductButton);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtUnit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCategory);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSKU);
            panel1.Controls.Add(addProductLabel1);
            panel1.Controls.Add(addProducts);
            panel1.Location = new Point(127, 107);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 377);
            panel1.TabIndex = 1;
            // 
            // customizeProductButton
            // 
            customizeProductButton.Font = new Font("Segoe UI", 11F);
            customizeProductButton.Location = new Point(157, 295);
            customizeProductButton.Margin = new Padding(4, 3, 4, 3);
            customizeProductButton.Name = "customizeProductButton";
            customizeProductButton.Size = new Size(118, 38);
            customizeProductButton.TabIndex = 13;
            customizeProductButton.Text = "Изменить";
            customizeProductButton.UseVisualStyleBackColor = true;
            customizeProductButton.Click += customizeProductButton_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(172, 242);
            txtPrice.Margin = new Padding(4, 3, 4, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(210, 23);
            txtPrice.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(43, 240);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 9;
            label4.Text = "Цена закупки";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(186, 208);
            txtUnit.Margin = new Padding(4, 3, 4, 3);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(196, 23);
            txtUnit.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(43, 207);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 25);
            label3.TabIndex = 7;
            label3.Text = "Ед. измерения";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(144, 173);
            txtCategory.Margin = new Padding(4, 3, 4, 3);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(237, 23);
            txtCategory.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(43, 171);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 5;
            label2.Text = "Категория";
            // 
            // txtName
            // 
            txtName.Location = new Point(144, 138);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(237, 23);
            txtName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(43, 136);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 3;
            label1.Text = "Название";
            // 
            // txtSKU
            // 
            txtSKU.Location = new Point(131, 102);
            txtSKU.Margin = new Padding(4, 3, 4, 3);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(250, 23);
            txtSKU.TabIndex = 2;
            // 
            // addProductLabel1
            // 
            addProductLabel1.AutoSize = true;
            addProductLabel1.Font = new Font("Segoe UI", 14F);
            addProductLabel1.Location = new Point(43, 99);
            addProductLabel1.Margin = new Padding(4, 0, 4, 0);
            addProductLabel1.Name = "addProductLabel1";
            addProductLabel1.Size = new Size(82, 25);
            addProductLabel1.TabIndex = 1;
            addProductLabel1.Text = "Артикул";
            // 
            // addProducts
            // 
            addProducts.AutoSize = true;
            addProducts.Font = new Font("Segoe UI", 18F);
            addProducts.Location = new Point(172, 38);
            addProducts.Margin = new Padding(4, 0, 4, 0);
            addProducts.Name = "addProducts";
            addProducts.Size = new Size(80, 32);
            addProducts.TabIndex = 0;
            addProducts.Text = "Товар";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(170, 170, 170);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(otgruzPointButton);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(686, 28);
            panel4.TabIndex = 16;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(217, 217, 217);
            button3.Location = new Point(126, 2);
            button3.Name = "button3";
            button3.Size = new Size(117, 23);
            button3.TabIndex = 15;
            button3.Text = "Отгрузка";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // otgruzPointButton
            // 
            otgruzPointButton.BackColor = Color.FromArgb(217, 217, 217);
            otgruzPointButton.Location = new Point(3, 2);
            otgruzPointButton.Name = "otgruzPointButton";
            otgruzPointButton.Size = new Size(117, 23);
            otgruzPointButton.TabIndex = 14;
            otgruzPointButton.Text = "Каталог";
            otgruzPointButton.UseVisualStyleBackColor = false;
            otgruzPointButton.Click += otgruzPointButton_Click;
            // 
            // AdminFormCustomizeProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 609);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "AdminFormCustomizeProduct";
            Text = "AdminFormCustomizeProduct";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button customizeProductButton;
        private TextBox txtPrice;
        private Label label4;
        private TextBox txtUnit;
        private Label label3;
        private TextBox txtCategory;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private TextBox txtSKU;
        private Label addProductLabel1;
        private Label addProducts;
        private Panel panel4;
        private Button button3;
        private Button otgruzPointButton;
    }
}