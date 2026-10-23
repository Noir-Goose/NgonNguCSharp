namespace BaiTapTuan01
{
    partial class Form3
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
            label1 = new Label();
            lblFullName = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            lblUsername = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtUsername = new TextBox();
            btnRegister = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(290, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ TÀI KHOẢN";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(50, 60);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(95, 20);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Họ và Tên (*)";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(50, 180);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(116, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Địa chỉ email (*)";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(50, 240);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Mật khẩu (*)";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(50, 300);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(154, 20);
            lblConfirmPassword.TabIndex = 5;
            lblConfirmPassword.Text = "Xác nhận mật khẩu (*)";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(50, 120);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(127, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Tên đăng nhập (*)";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(200, 60);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(300, 27);
            txtFullName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(200, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 27);
            txtEmail.TabIndex = 8;
            txtEmail.Leave += TxtEmail_Leave;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(200, 240);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(300, 27);
            txtPassword.TabIndex = 9;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(200, 300);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(300, 27);
            txtConfirmPassword.TabIndex = 10;
            txtConfirmPassword.KeyDown += TxtConfirmPassword_KeyDown;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(200, 120);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 27);
            txtUsername.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(200, 370);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 35);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += BtnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(330, 370);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 35);
            btnClear.TabIndex = 12;
            btnClear.Text = "Xóa";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // BaiTap02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 455);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(txtFullName);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(lblFullName);
            Controls.Add(label1);
            Name = "BaiTap02";
            Text = "Đăng ký tài khoản";
            FormClosing += Form3_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblFullName;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Label lblUsername;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtUsername;
        private Button btnRegister;
        private Button btnClear;
    }
}