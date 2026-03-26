namespace WarehouseAccounting
{
    partial class KatalogFormAdmin
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
            categoryButton7 = new Button();
            categoryButton6 = new Button();
            categoryButton5 = new Button();
            button2 = new Button();
            buttonGener = new Button();
            buttonGenerate = new Button();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            buttonSearch = new Button();
            txtSearch = new TextBox();
            dataGridViewProducts = new DataGridView();
            otgruzPointButton = new Button();
            button3 = new Button();
            panel4 = new Panel();
            labelCategory = new Label();
            panel3 = new Panel();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // categoryButton7
            // 
            categoryButton7.BackColor = Color.Gainsboro;
            categoryButton7.Font = new Font("Segoe UI", 10F);
            categoryButton7.Location = new Point(12, 220);
            categoryButton7.Name = "categoryButton7";
            categoryButton7.Size = new Size(96, 26);
            categoryButton7.TabIndex = 21;
            categoryButton7.Text = "Удалить";
            categoryButton7.UseVisualStyleBackColor = false;
            // 
            // categoryButton6
            // 
            categoryButton6.BackColor = Color.Gainsboro;
            categoryButton6.Font = new Font("Segoe UI", 10F);
            categoryButton6.Location = new Point(12, 188);
            categoryButton6.Name = "categoryButton6";
            categoryButton6.Size = new Size(96, 26);
            categoryButton6.TabIndex = 20;
            categoryButton6.Text = "Изменить";
            categoryButton6.UseVisualStyleBackColor = false;
            // 
            // categoryButton5
            // 
            categoryButton5.BackColor = Color.Gainsboro;
            categoryButton5.Font = new Font("Segoe UI", 10F);
            categoryButton5.Location = new Point(12, 156);
            categoryButton5.Name = "categoryButton5";
            categoryButton5.Size = new Size(96, 26);
            categoryButton5.TabIndex = 19;
            categoryButton5.Text = "Добавить";
            categoryButton5.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(217, 217, 217);
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(21, 195);
            button2.Margin = new Padding(3, 3, 3, 10);
            button2.Name = "button2";
            button2.Size = new Size(117, 42);
            button2.TabIndex = 12;
            button2.Text = "Редактировать";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttonGener
            // 
            buttonGener.BackColor = Color.FromArgb(217, 217, 217);
            buttonGener.Font = new Font("Segoe UI", 10F);
            buttonGener.Location = new Point(21, 140);
            buttonGener.Margin = new Padding(3, 3, 3, 10);
            buttonGener.Name = "buttonGener";
            buttonGener.Size = new Size(117, 42);
            buttonGener.TabIndex = 11;
            buttonGener.Text = "Удалить";
            buttonGener.UseVisualStyleBackColor = false;
            buttonGener.Click += buttonGener_Click;
            // 
            // buttonGenerate
            // 
            buttonGenerate.BackColor = Color.FromArgb(217, 217, 217);
            buttonGenerate.Font = new Font("Segoe UI", 10F);
            buttonGenerate.Location = new Point(21, 85);
            buttonGenerate.Margin = new Padding(3, 3, 3, 10);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(117, 42);
            buttonGenerate.TabIndex = 10;
            buttonGenerate.Text = "Создание";
            buttonGenerate.UseVisualStyleBackColor = false;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtSearch);
            panel1.ImeMode = ImeMode.Off;
            panel1.Location = new Point(18, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 37);
            panel1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(217, 217, 217);
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(3, 0);
            button1.Name = "button1";
            button1.Size = new Size(117, 34);
            button1.TabIndex = 4;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(buttonSearch);
            panel2.Location = new Point(3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 0);
            panel2.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(217, 217, 217);
            buttonSearch.Font = new Font("Segoe UI", 12F);
            buttonSearch.Location = new Point(-3, -1);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(117, 34);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BackColor = Color.FromArgb(170, 170, 170);
            txtSearch.Location = new Point(121, 2);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1670, 32);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(163, 85);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(846, 426);
            dataGridViewProducts.TabIndex = 8;
            // 
            // otgruzPointButton
            // 
            otgruzPointButton.BackColor = Color.FromArgb(217, 217, 217);
            otgruzPointButton.Location = new Point(3, 2);
            otgruzPointButton.Name = "otgruzPointButton";
            otgruzPointButton.Size = new Size(117, 26);
            otgruzPointButton.TabIndex = 14;
            otgruzPointButton.Text = "Каталог";
            otgruzPointButton.UseVisualStyleBackColor = false;
            otgruzPointButton.Click += otgruzPointButton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(217, 217, 217);
            button3.Location = new Point(126, 2);
            button3.Name = "button3";
            button3.Size = new Size(120, 26);
            button3.TabIndex = 15;
            button3.Text = "Отгрузка";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(170, 170, 170);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(otgruzPointButton);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1021, 28);
            panel4.TabIndex = 15;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 13F);
            labelCategory.Location = new Point(12, 0);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(96, 25);
            labelCategory.TabIndex = 0;
            labelCategory.Text = "Категории";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(217, 217, 217);
            panel3.Controls.Add(listBox1);
            panel3.Controls.Add(categoryButton7);
            panel3.Controls.Add(categoryButton6);
            panel3.Controls.Add(categoryButton5);
            panel3.Controls.Add(labelCategory);
            panel3.Location = new Point(18, 253);
            panel3.Name = "panel3";
            panel3.Size = new Size(120, 258);
            panel3.TabIndex = 13;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 28);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(96, 124);
            listBox1.TabIndex = 16;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // KatalogFormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 569);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(button2);
            Controls.Add(buttonGener);
            Controls.Add(buttonGenerate);
            Controls.Add(panel1);
            Controls.Add(dataGridViewProducts);
            Name = "KatalogFormAdmin";
            Text = "KatalogFormAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button buttonGener;
        private Button buttonGenerate;
        private Panel panel1;
        private Panel panel2;
        private Button buttonSearch;
        private TextBox txtSearch;
        private DataGridView dataGridViewProducts;
        private Button button1;
        private Button categoryButton5;
        private Button categoryButton7;
        private Button categoryButton6;
        private Button otgruzPointButton;
        private Button button3;
        private Panel panel4;
        private Label labelCategory;
        private Panel panel3;
        private ListBox listBox1;
    }
}