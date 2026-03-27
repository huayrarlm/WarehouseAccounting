namespace WarehouseAccounting
{
    partial class KatalogFormEmployee
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
            dataGridViewProducts = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            buttonSearch = new Button();
            txtSearch = new TextBox();
            panel3 = new Panel();
            categoryButton2 = new Button();
            categoryButton3 = new Button();
            categoryButton1 = new Button();
            labelCategory = new Label();
            panel4 = new Panel();
            button3 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(160, 79);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(846, 426);
            dataGridViewProducts.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtSearch);
            panel1.ImeMode = ImeMode.Off;
            panel1.Location = new Point(15, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 40);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(buttonSearch);
            panel2.Location = new Point(3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(117, 33);
            panel2.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(217, 217, 217);
            buttonSearch.Font = new Font("Segoe UI", 12F);
            buttonSearch.Location = new Point(0, 0);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(117, 34);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BackColor = Color.FromArgb(170, 170, 170);
            txtSearch.Location = new Point(121, 2);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(873, 32);
            txtSearch.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(217, 217, 217);
            panel3.Controls.Add(categoryButton2);
            panel3.Controls.Add(categoryButton3);
            panel3.Controls.Add(categoryButton1);
            panel3.Controls.Add(labelCategory);
            panel3.Location = new Point(15, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(120, 148);
            panel3.TabIndex = 6;
            // 
            // categoryButton2
            // 
            categoryButton2.Font = new Font("Segoe UI", 10F);
            categoryButton2.Location = new Point(12, 74);
            categoryButton2.Name = "categoryButton2";
            categoryButton2.Size = new Size(96, 27);
            categoryButton2.TabIndex = 3;
            categoryButton2.Text = "Сухая";
            categoryButton2.UseVisualStyleBackColor = true;
            // 
            // categoryButton3
            // 
            categoryButton3.Font = new Font("Segoe UI", 10F);
            categoryButton3.Location = new Point(12, 107);
            categoryButton3.Name = "categoryButton3";
            categoryButton3.Size = new Size(96, 27);
            categoryButton3.TabIndex = 2;
            categoryButton3.Text = "Готовая";
            categoryButton3.UseVisualStyleBackColor = true;
            // 
            // categoryButton1
            // 
            categoryButton1.Font = new Font("Segoe UI", 10F);
            categoryButton1.Location = new Point(12, 41);
            categoryButton1.Name = "categoryButton1";
            categoryButton1.Size = new Size(96, 27);
            categoryButton1.TabIndex = 1;
            categoryButton1.Text = "Все товары";
            categoryButton1.UseVisualStyleBackColor = true;
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
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(170, 170, 170);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1021, 28);
            panel4.TabIndex = 16;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(217, 217, 217);
            button3.Location = new Point(126, 2);
            button3.Name = "button3";
            button3.Size = new Size(121, 26);
            button3.TabIndex = 15;
            button3.Text = "Отгрузка";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(217, 217, 217);
            button1.Location = new Point(3, 2);
            button1.Name = "button1";
            button1.Size = new Size(120, 26);
            button1.TabIndex = 14;
            button1.Text = "Каталог";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // KatalogFormEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 569);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dataGridViewProducts);
            Name = "KatalogFormEmployee";
            Text = "KatalogFormEmployee";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private Panel panel1;
        private TextBox txtSearch;
        private Panel panel2;
        private Button buttonSearch;
        private Panel panel3;
        private Label labelCategory;
        private Button categoryButton2;
        private Button categoryButton3;
        private Button categoryButton1;
        private Panel panel4;
        private Button button3;
        private Button button1;
    }
}