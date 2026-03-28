namespace WarehouseAccounting
{
    partial class OtgruzFormAdmin
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
            button1 = new Button();
            panel2 = new Panel();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            dataGridView1 = new DataGridView();
            buttonHistoryOtgr = new Button();
            panel4 = new Panel();
            button3 = new Button();
            otgruzPointButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBoxSearch);
            panel1.ImeMode = ImeMode.Off;
            panel1.Location = new Point(18, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 37);
            panel1.TabIndex = 16;
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
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(buttonSearch);
            panel2.Location = new Point(3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1711, 0);
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
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.BackColor = Color.FromArgb(170, 170, 170);
            textBoxSearch.Location = new Point(121, 2);
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(2467, 32);
            textBoxSearch.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(988, 426);
            dataGridView1.TabIndex = 15;
            // 
            // buttonHistoryOtgr
            // 
            buttonHistoryOtgr.BackColor = Color.FromArgb(217, 217, 217);
            buttonHistoryOtgr.Font = new Font("Segoe UI", 11F);
            buttonHistoryOtgr.Location = new Point(21, 34);
            buttonHistoryOtgr.Name = "buttonHistoryOtgr";
            buttonHistoryOtgr.Size = new Size(191, 28);
            buttonHistoryOtgr.TabIndex = 22;
            buttonHistoryOtgr.Text = "История отгрузок";
            buttonHistoryOtgr.UseVisualStyleBackColor = false;
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
            panel4.TabIndex = 23;
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
            // OtgruzFormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 569);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(buttonHistoryOtgr);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "OtgruzFormAdmin";
            Text = "Отгрузка";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private DataGridView dataGridView1;
        private Button buttonHistoryOtgr;
        private Panel panel4;
        private Button button3;
        private Button otgruzPointButton;
    }
}