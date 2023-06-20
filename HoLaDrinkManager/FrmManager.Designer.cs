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
            itPersonalInfo = new ToolStripMenuItem();
            itLogout = new ToolStripMenuItem();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            thêmMónCtrlDToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            panel2 = new Panel();
            label1 = new Label();
            txtTotalPrice = new TextBox();
            mmDiscount = new NumericUpDown();
            btnDiscount = new Button();
            btnPay = new Button();
            panel3 = new Panel();
            cbDrink = new ComboBox();
            cbCategory = new ComboBox();
            nbDrinkCount = new NumericUpDown();
            btnAdd = new Button();
            lstvBill = new ListView();
            flbTable = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mmDiscount).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbDrinkCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { itAdmin, itAccInfo, chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(974, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // itAdmin
            // 
            itAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            itAdmin.ForeColor = Color.Blue;
            itAdmin.Name = "itAdmin";
            itAdmin.Size = new Size(55, 20);
            itAdmin.Text = "Admin";
            itAdmin.Click += itAdmin_Click;
            // 
            // itAccInfo
            // 
            itAccInfo.DropDownItems.AddRange(new ToolStripItem[] { itPersonalInfo, itLogout });
            itAccInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            itAccInfo.ForeColor = Color.Blue;
            itAccInfo.Name = "itAccInfo";
            itAccInfo.Size = new Size(126, 20);
            itAccInfo.Text = "Thông tin tài khoản";
            // 
            // itPersonalInfo
            // 
            itPersonalInfo.ForeColor = Color.Blue;
            itPersonalInfo.Name = "itPersonalInfo";
            itPersonalInfo.Size = new Size(172, 22);
            itPersonalInfo.Text = "Thông tin cá nhân";
            itPersonalInfo.Click += itPersonalInfo_Click;
            // 
            // itLogout
            // 
            itLogout.ForeColor = Color.Blue;
            itLogout.Name = "itLogout";
            itLogout.Size = new Size(172, 22);
            itLogout.Text = "Đăng xuất";
            itLogout.Click += itLogout_Click;
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmMónCtrlDToolStripMenuItem, toolStripMenuItem1 });
            chứcNăngToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chứcNăngToolStripMenuItem.ForeColor = Color.Blue;
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(77, 20);
            chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thêmMónCtrlDToolStripMenuItem
            // 
            thêmMónCtrlDToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            thêmMónCtrlDToolStripMenuItem.ForeColor = Color.Blue;
            thêmMónCtrlDToolStripMenuItem.Name = "thêmMónCtrlDToolStripMenuItem";
            thêmMónCtrlDToolStripMenuItem.Size = new Size(174, 22);
            thêmMónCtrlDToolStripMenuItem.Text = "Thanh Toán Ctrl+F";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripMenuItem1.ForeColor = Color.Blue;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(174, 22);
            toolStripMenuItem1.Text = "Thêm Món Ctrl+D";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtTotalPrice);
            panel2.Controls.Add(mmDiscount);
            panel2.Controls.Add(btnDiscount);
            panel2.Controls.Add(btnPay);
            panel2.Location = new Point(577, 462);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 91);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(156, 11);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 4;
            label1.Text = "Tổng tiền";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalPrice.ForeColor = Color.Blue;
            txtTotalPrice.Location = new Point(139, 35);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(117, 33);
            txtTotalPrice.TabIndex = 3;
            txtTotalPrice.Text = "0";
            txtTotalPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // mmDiscount
            // 
            mmDiscount.ForeColor = Color.Blue;
            mmDiscount.Location = new Point(3, 46);
            mmDiscount.Name = "mmDiscount";
            mmDiscount.Size = new Size(114, 23);
            mmDiscount.TabIndex = 2;
            // 
            // btnDiscount
            // 
            btnDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiscount.ForeColor = Color.Blue;
            btnDiscount.Location = new Point(3, 11);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(114, 29);
            btnDiscount.TabIndex = 1;
            btnDiscount.Text = "Khuyến mãi";
            btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            btnPay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPay.ForeColor = Color.Blue;
            btnPay.Location = new Point(262, 17);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(120, 52);
            btnPay.TabIndex = 0;
            btnPay.Text = "Thanh toán";
            btnPay.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbDrink);
            panel3.Controls.Add(cbCategory);
            panel3.Controls.Add(nbDrinkCount);
            panel3.Controls.Add(btnAdd);
            panel3.Location = new Point(0, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(571, 100);
            panel3.TabIndex = 3;
            // 
            // cbDrink
            // 
            cbDrink.ForeColor = Color.Blue;
            cbDrink.FormattingEnabled = true;
            cbDrink.Location = new Point(347, 60);
            cbDrink.Name = "cbDrink";
            cbDrink.Size = new Size(161, 23);
            cbDrink.TabIndex = 3;
            // 
            // cbCategory
            // 
            cbCategory.ForeColor = Color.Blue;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(347, 15);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(161, 23);
            cbCategory.TabIndex = 2;
            // 
            // nbDrinkCount
            // 
            nbDrinkCount.ForeColor = Color.Blue;
            nbDrinkCount.Location = new Point(165, 36);
            nbDrinkCount.Name = "nbDrinkCount";
            nbDrinkCount.Size = new Size(120, 23);
            nbDrinkCount.TabIndex = 1;
            nbDrinkCount.TextAlign = HorizontalAlignment.Center;
            nbDrinkCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Blue;
            btnAdd.Location = new Point(26, 34);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // lstvBill
            // 
            lstvBill.Location = new Point(0, 133);
            lstvBill.Name = "lstvBill";
            lstvBill.Size = new Size(571, 420);
            lstvBill.TabIndex = 4;
            lstvBill.UseCompatibleStateImageBehavior = false;
            // 
            // flbTable
            // 
            flbTable.Location = new Point(577, 27);
            flbTable.Name = "flbTable";
            flbTable.Size = new Size(385, 429);
            flbTable.TabIndex = 5;
            // 
            // FrmManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 554);
            Controls.Add(flbTable);
            Controls.Add(lstvBill);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý HolaDrink";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mmDiscount).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nbDrinkCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem itAdmin;
        private ToolStripMenuItem itAccInfo;
        private ToolStripMenuItem itPersonalInfo;
        private ToolStripMenuItem itLogout;
        private Panel panel2;
        private Panel panel3;
        private Button btnPay;
        private ComboBox cbDrink;
        private ComboBox cbCategory;
        private NumericUpDown nbDrinkCount;
        private Button btnAdd;
        private Label label1;
        private TextBox txtTotalPrice;
        private NumericUpDown mmDiscount;
        private Button btnDiscount;
        private ListView lstvBill;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem thêmMónCtrlDToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private FlowLayoutPanel flbTable;
    }
}