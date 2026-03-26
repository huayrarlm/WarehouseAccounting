namespace WarehouseAccounting
{
    partial class RegisterForm
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
            txtConfirmPassword = new TextBox();
            btnRegister = new Button();
            txtpassword = new TextBox();
            txtemail = new TextBox();
            txtname = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 217, 217);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(txtpassword);
            panel1.Controls.Add(txtemail);
            panel1.Controls.Add(txtname);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(195, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 337);
            panel1.TabIndex = 0;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 11F);
            txtConfirmPassword.ForeColor = SystemColors.GrayText;
            txtConfirmPassword.Location = new Point(71, 213);
            txtConfirmPassword.Margin = new Padding(0, 0, 0, 20);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Повторите ваш пароль";
            txtConfirmPassword.Size = new Size(197, 27);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 10F);
            btnRegister.Location = new Point(91, 263);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(151, 34);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Зарегестрироваться";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 11F);
            txtpassword.ForeColor = SystemColors.GrayText;
            txtpassword.Location = new Point(71, 166);
            txtpassword.Margin = new Padding(0, 0, 0, 20);
            txtpassword.Name = "txtpassword";
            txtpassword.PlaceholderText = "Введите пароль";
            txtpassword.Size = new Size(197, 27);
            txtpassword.TabIndex = 4;
            txtpassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 11F);
            txtemail.ForeColor = SystemColors.GrayText;
            txtemail.Location = new Point(71, 119);
            txtemail.Margin = new Padding(0, 0, 0, 20);
            txtemail.Name = "txtemail";
            txtemail.PlaceholderText = "Введите email";
            txtemail.Size = new Size(197, 27);
            txtemail.TabIndex = 3;
            txtemail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 11F);
            txtname.ForeColor = SystemColors.GrayText;
            txtname.Location = new Point(71, 72);
            txtname.Margin = new Padding(0, 0, 0, 20);
            txtname.Name = "txtname";
            txtname.PlaceholderText = "Введите логин";
            txtname.Size = new Size(197, 27);
            txtname.TabIndex = 2;
            txtname.TextAlign = HorizontalAlignment.Center;
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
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 562);
            Controls.Add(panel1);
            Name = "RegisterForm";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private TextBox txtname;
        private TextBox txtpassword;
        private TextBox txtemail;
        private Button btnRegister;
        private TextBox txtConfirmPassword;
    }
}