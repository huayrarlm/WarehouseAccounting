namespace WarehouseAccounting
{
    partial class BasketForm
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
            label9 = new Label();
            label8 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            button3 = new Button();
            otgruzPointButton = new Button();
            dataGridView3 = new DataGridView();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(217, 217, 217);
            label9.Font = new Font("Segoe UI", 13F);
            label9.Location = new Point(12, 41);
            label9.Name = "label9";
            label9.Padding = new Padding(37, 0, 37, 0);
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(247, 25);
            label9.TabIndex = 43;
            label9.Text = "Добавление товара";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(217, 217, 217);
            label8.Font = new Font("Segoe UI", 13F);
            label8.Location = new Point(165, 357);
            label8.Name = "label8";
            label8.Padding = new Padding(30, 0, 30, 0);
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(141, 25);
            label8.TabIndex = 42;
            label8.Text = "Корзина";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(217, 217, 217);
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(12, 140);
            button2.Name = "button2";
            button2.Size = new Size(134, 57);
            button2.TabIndex = 41;
            button2.Text = "Выбрать";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(170, 170, 170);
            textBox1.Location = new Point(145, 79);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(801, 34);
            textBox1.TabIndex = 39;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(217, 217, 217);
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(12, 79);
            button1.Name = "button1";
            button1.Size = new Size(134, 34);
            button1.TabIndex = 38;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(165, 140);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(781, 199);
            dataGridView2.TabIndex = 35;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(273, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(683, 212);
            dataGridView1.TabIndex = 34;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(170, 170, 170);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(otgruzPointButton);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1010, 28);
            panel4.TabIndex = 44;
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
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(165, 401);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(781, 199);
            dataGridView3.TabIndex = 45;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(217, 217, 217);
            button4.Font = new Font("Segoe UI", 13F);
            button4.Location = new Point(165, 606);
            button4.Name = "button4";
            button4.Size = new Size(203, 34);
            button4.TabIndex = 46;
            button4.Text = "Отправить в отгрузку";
            button4.UseVisualStyleBackColor = false;
            // 
            // BasketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 644);
            Controls.Add(button4);
            Controls.Add(dataGridView3);
            Controls.Add(panel4);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "BasketForm";
            Text = "BasketForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Label label8;
        private Button button2;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Button button3;
        private Button otgruzPointButton;
        private DataGridView dataGridView3;
        private Button button4;
    }
}