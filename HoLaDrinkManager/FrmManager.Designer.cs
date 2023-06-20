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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            itAdmin = new ToolStripMenuItem();
            itAccInfo = new ToolStripMenuItem();
            itPersonalInfo = new ToolStripMenuItem();
            itLogout = new ToolStripMenuItem();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            thanhToánToolStripMenuItem = new ToolStripMenuItem();
            thêmMóntoolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            label1 = new Label();
            txtTotalPrice = new TextBox();
            nmDiscount = new NumericUpDown();
            btnDiscount = new Button();
            btnPay = new Button();
            panel3 = new Panel();
            cbDrink = new ComboBox();
            cbCategory = new ComboBox();
            nbDrinkCount = new NumericUpDown();
            btnAdd = new Button();
            flbTable = new FlowLayoutPanel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            lstvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbDrinkCount).BeginInit();
            panel1.SuspendLayout();
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
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thanhToánToolStripMenuItem, thêmMóntoolStripMenuItem });
            chứcNăngToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chứcNăngToolStripMenuItem.ForeColor = Color.Blue;
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(77, 20);
            chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thanhToánToolStripMenuItem
            // 
            thanhToánToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            thanhToánToolStripMenuItem.ForeColor = Color.Blue;
            thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            thanhToánToolStripMenuItem.Size = new Size(174, 22);
            thanhToánToolStripMenuItem.Text = "Thanh Toán Ctrl+F";
            thanhToánToolStripMenuItem.Click += thanhToánToolStripMenuItem_Click;
            // 
            // thêmMóntoolStripMenuItem
            // 
            thêmMóntoolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            thêmMóntoolStripMenuItem.ForeColor = Color.Blue;
            thêmMóntoolStripMenuItem.Name = "thêmMóntoolStripMenuItem";
            thêmMóntoolStripMenuItem.Size = new Size(174, 22);
            thêmMóntoolStripMenuItem.Text = "Thêm Món Ctrl+D";
            thêmMóntoolStripMenuItem.Click += thêmMóntoolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtTotalPrice);
            panel2.Controls.Add(nmDiscount);
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
            // nmDiscount
            // 
            nmDiscount.ForeColor = Color.Blue;
            nmDiscount.Location = new Point(3, 46);
            nmDiscount.Name = "nmDiscount";
            nmDiscount.Size = new Size(114, 23);
            nmDiscount.TabIndex = 2;
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
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
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
            btnAdd.Click += btnAdd_Click;
            // 
            // flbTable
            // 
            flbTable.Location = new Point(577, 27);
            flbTable.Name = "flbTable";
            flbTable.Size = new Size(385, 429);
            flbTable.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel1
            // 
            panel1.Controls.Add(lstvBill);
            panel1.Location = new Point(0, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(571, 420);
            panel1.TabIndex = 6;
            // 
            // lstvBill
            // 
            lstvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lstvBill.Location = new Point(0, 0);
            lstvBill.Name = "lstvBill";
            lstvBill.Size = new Size(568, 417);
            lstvBill.TabIndex = 0;
            lstvBill.UseCompatibleStateImageBehavior = false;
            lstvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên đồ uống";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 100;
            // 
            // FrmManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 554);
            Controls.Add(panel1);
            Controls.Add(flbTable);
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
            ((System.ComponentModel.ISupportInitialize)nmDiscount).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nbDrinkCount).EndInit();
            panel1.ResumeLayout(false);
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
        private NumericUpDown nmDiscount;
        private Button btnDiscount;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem thanhToánToolStripMenuItem;
        private ToolStripMenuItem thêmMóntoolStripMenuItem;
        private FlowLayoutPanel flbTable;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private ListView lstvBill;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}