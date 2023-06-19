namespace HoLaDrinkManager
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lbPassword = new Label();
            lbUsername = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lbPassword);
            panel1.Controls.Add(lbUsername);
            panel1.Location = new Point(24, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 136);
            panel1.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(172, 90);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(221, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(172, 32);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(221, 23);
            txtUsername.TabIndex = 2;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbPassword.ForeColor = Color.Blue;
            lbPassword.Location = new Point(50, 83);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(115, 30);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Mật Khẩu:";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbUsername.ForeColor = Color.Blue;
            lbUsername.Location = new Point(50, 25);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(116, 30);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Tài Khoản:";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Blue;
            btnLogin.Location = new Point(133, 153);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(115, 37);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Blue;
            btnExit.Location = new Point(294, 155);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 35);
            btnExit.TabIndex = 2;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 205);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(panel1);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lbPassword;
        private Label lbUsername;
        private Button btnLogin;
        private Button btnExit;
    }
}