namespace HoLaDrinkManager
{
    partial class FrmAccountInfo
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
            txtUsername = new TextBox();
            lbUsername = new Label();
            panel2 = new Panel();
            txtDisplayName = new TextBox();
            lbDisplayName = new Label();
            panel3 = new Panel();
            txtPassword = new TextBox();
            lbPassword = new Label();
            panel4 = new Panel();
            txtNewPassword = new TextBox();
            lbNewPassword = new Label();
            btnExit = new Button();
            btnUpdate = new Button();
            panel5 = new Panel();
            txtReEnter = new TextBox();
            lbReEnter = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lbUsername);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 64);
            panel1.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(216, 21);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(247, 23);
            txtUsername.TabIndex = 1;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbUsername.ForeColor = Color.Blue;
            lbUsername.Location = new Point(24, 16);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(103, 25);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Tài Khoản:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtDisplayName);
            panel2.Controls.Add(lbDisplayName);
            panel2.Location = new Point(12, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 64);
            panel2.TabIndex = 1;
            // 
            // txtDisplayName
            // 
            txtDisplayName.Location = new Point(216, 24);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.Size = new Size(247, 23);
            txtDisplayName.TabIndex = 1;
            // 
            // lbDisplayName
            // 
            lbDisplayName.AutoSize = true;
            lbDisplayName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbDisplayName.ForeColor = Color.Blue;
            lbDisplayName.Location = new Point(25, 19);
            lbDisplayName.Name = "lbDisplayName";
            lbDisplayName.Size = new Size(48, 25);
            lbDisplayName.TabIndex = 0;
            lbDisplayName.Text = "Tên:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(lbPassword);
            panel3.Location = new Point(12, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(522, 64);
            panel3.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(216, 20);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(247, 23);
            txtPassword.TabIndex = 1;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbPassword.ForeColor = Color.Blue;
            lbPassword.Location = new Point(24, 18);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(102, 25);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Mật Khẩu:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtNewPassword);
            panel4.Controls.Add(lbNewPassword);
            panel4.Location = new Point(12, 222);
            panel4.Name = "panel4";
            panel4.Size = new Size(522, 64);
            panel4.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(216, 23);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(247, 23);
            txtNewPassword.TabIndex = 1;
            // 
            // lbNewPassword
            // 
            lbNewPassword.AutoSize = true;
            lbNewPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbNewPassword.ForeColor = Color.Blue;
            lbNewPassword.Location = new Point(24, 23);
            lbNewPassword.Name = "lbNewPassword";
            lbNewPassword.Size = new Size(142, 25);
            lbNewPassword.TabIndex = 0;
            lbNewPassword.Text = "Mật Khẩu Mới:";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Blue;
            btnExit.Location = new Point(340, 375);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(119, 33);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.Blue;
            btnUpdate.Location = new Point(103, 375);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(119, 36);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtReEnter);
            panel5.Controls.Add(lbReEnter);
            panel5.Location = new Point(12, 292);
            panel5.Name = "panel5";
            panel5.Size = new Size(522, 64);
            panel5.TabIndex = 6;
            // 
            // txtReEnter
            // 
            txtReEnter.Location = new Point(216, 20);
            txtReEnter.Name = "txtReEnter";
            txtReEnter.Size = new Size(247, 23);
            txtReEnter.TabIndex = 1;
            // 
            // lbReEnter
            // 
            lbReEnter.AutoSize = true;
            lbReEnter.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbReEnter.ForeColor = Color.Blue;
            lbReEnter.Location = new Point(25, 20);
            lbReEnter.Name = "lbReEnter";
            lbReEnter.Size = new Size(185, 25);
            lbReEnter.TabIndex = 0;
            lbReEnter.Text = "Nhập Lại Mật Khẩu:";
            // 
            // FrmAccountInfo
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(552, 450);
            Controls.Add(panel5);
            Controls.Add(btnUpdate);
            Controls.Add(btnExit);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FrmAccountInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtUsername;
        private Label lbUsername;
        private TextBox txtDisplayName;
        private Label lbDisplayName;
        private TextBox txtPassword;
        private Label lbPassword;
        private Panel panel4;
        private TextBox txtNewPassword;
        private Label lbNewPassword;
        private Button btnExit;
        private Button btnUpdate;
        private Panel panel5;
        private TextBox txtReEnter;
        private Label lbReEnter;
    }
}