namespace WarehouseAccounting
{
    partial class AdminForm
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
            buttonOtguz = new Button();
            buttonKatalog = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 217, 217);
            panel1.Controls.Add(buttonOtguz);
            panel1.Controls.Add(buttonKatalog);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(251, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 206);
            panel1.TabIndex = 1;
            // 
            // buttonOtguz
            // 
            buttonOtguz.Location = new Point(70, 135);
            buttonOtguz.Name = "buttonOtguz";
            buttonOtguz.Size = new Size(159, 41);
            buttonOtguz.TabIndex = 3;
            buttonOtguz.Text = "Отгрузка";
            buttonOtguz.UseVisualStyleBackColor = true;
            buttonOtguz.Click += buttonOtguz_Click;
            // 
            // buttonKatalog
            // 
            buttonKatalog.Location = new Point(70, 75);
            buttonKatalog.Name = "buttonKatalog";
            buttonKatalog.Size = new Size(159, 41);
            buttonKatalog.TabIndex = 1;
            buttonKatalog.Text = "Каталог";
            buttonKatalog.UseVisualStyleBackColor = true;
            buttonKatalog.Click += buttonKatalog_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(114, 29);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "Меню";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "AdminForm";
            Text = "Администратор";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonOtguz;
        private Button buttonKatalog;
        private Label label1;
    }
}