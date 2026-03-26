namespace WarehouseAccounting
{
    partial class AuthoritionForm
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
            EnterButton = new Button();
            txtpassword = new TextBox();
            txtemail = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 217, 217);
            panel1.Controls.Add(EnterButton);
            panel1.Controls.Add(txtpassword);
            panel1.Controls.Add(txtemail);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(195, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 280);
            panel1.TabIndex = 2;
            // 
            // EnterButton
            // 
            EnterButton.Font = new Font("Segoe UI", 12F);
            EnterButton.Location = new Point(113, 213);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(107, 37);
            EnterButton.TabIndex = 6;
            EnterButton.Text = "Войти";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += EnterButton_Click;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 11F);
            txtpassword.ForeColor = SystemColors.GrayText;
            txtpassword.Location = new Point(68, 153);
            txtpassword.Margin = new Padding(0, 0, 0, 30);
            txtpassword.Name = "txtpassword";
            txtpassword.PlaceholderText = "Пароль";
            txtpassword.Size = new Size(197, 27);
            txtpassword.TabIndex = 5;
            txtpassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 11F);
            txtemail.ForeColor = SystemColors.GrayText;
            txtemail.Location = new Point(68, 96);
            txtemail.Margin = new Padding(0, 0, 0, 30);
            txtemail.Name = "txtemail";
            txtemail.PlaceholderText = "Введите email";
            txtemail.Size = new Size(197, 27);
            txtemail.TabIndex = 2;
            txtemail.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(332, 85);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(332, 85);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AuthoritionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 562);
            Controls.Add(panel1);
            Name = "AuthoritionForm";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox txtemail;
        private Panel panel3;
        private Label label1;
        private TextBox txtpassword;
        private Button EnterButton;
    }
}