namespace HoLaDrinkManager
{
    partial class FrmManager
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
            menuStrip1 = new MenuStrip();
            itAdmin = new ToolStripMenuItem();
            itAccInfo = new ToolStripMenuItem();
            thanhToánToolStripMenuItem = new ToolStripMenuItem();
            thêmMónCtrlDToolStripMenuItem = new ToolStripMenuItem();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            thanhToánCtrlFToolStripMenuItem = new ToolStripMenuItem();
            thêmMónCtrlDToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { itAdmin, itAccInfo, chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // itAdmin
            // 
            itAdmin.Name = "itAdmin";
            itAdmin.Size = new Size(55, 20);
            itAdmin.Text = "Admin";
            // 
            // itAccInfo
            // 
            itAccInfo.DropDownItems.AddRange(new ToolStripItem[] { thanhToánToolStripMenuItem, thêmMónCtrlDToolStripMenuItem });
            itAccInfo.Name = "itAccInfo";
            itAccInfo.Size = new Size(122, 20);
            itAccInfo.Text = "Thông tin tài khoản";
            // 
            // thanhToánToolStripMenuItem
            // 
            thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            thanhToánToolStripMenuItem.Size = new Size(180, 22);
            thanhToánToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // thêmMónCtrlDToolStripMenuItem
            // 
            thêmMónCtrlDToolStripMenuItem.Name = "thêmMónCtrlDToolStripMenuItem";
            thêmMónCtrlDToolStripMenuItem.Size = new Size(180, 22);
            thêmMónCtrlDToolStripMenuItem.Text = "Đăng xuất";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thanhToánCtrlFToolStripMenuItem, thêmMónCtrlDToolStripMenuItem1 });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(77, 20);
            chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thanhToánCtrlFToolStripMenuItem
            // 
            thanhToánCtrlFToolStripMenuItem.Name = "thanhToánCtrlFToolStripMenuItem";
            thanhToánCtrlFToolStripMenuItem.Size = new Size(180, 22);
            thanhToánCtrlFToolStripMenuItem.Text = "Thanh toán Ctrl+F";
            // 
            // thêmMónCtrlDToolStripMenuItem1
            // 
            thêmMónCtrlDToolStripMenuItem1.Name = "thêmMónCtrlDToolStripMenuItem1";
            thêmMónCtrlDToolStripMenuItem1.Size = new Size(180, 22);
            thêmMónCtrlDToolStripMenuItem1.Text = "Thêm món Ctrl+D";
            // 
            // FrmManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmManager";
            Text = "Quản lý HolaDrink";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem itAdmin;
        private ToolStripMenuItem itAccInfo;
        private ToolStripMenuItem thanhToánToolStripMenuItem;
        private ToolStripMenuItem thêmMónCtrlDToolStripMenuItem;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem thanhToánCtrlFToolStripMenuItem;
        private ToolStripMenuItem thêmMónCtrlDToolStripMenuItem1;
    }
}