namespace HoLaDrinkManager
{
    partial class FrmAdmin
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
            tabControl = new TabControl();
            tpBill = new TabPage();
            panel2 = new Panel();
            dtpEndDate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            btnCount = new Button();
            btnSearchBill = new Button();
            lbEnd = new Label();
            lbFrom = new Label();
            panel1 = new Panel();
            btnExport = new Button();
            dgvBill = new DataGridView();
            tpDrink = new TabPage();
            panel6 = new Panel();
            cbDrinkCategory = new ComboBox();
            txtPrice = new TextBox();
            txtDrinkName = new TextBox();
            txtDrinkID = new TextBox();
            lbPrice = new Label();
            lbDrinkCatefory = new Label();
            lbDrinkName = new Label();
            lbDrinkID = new Label();
            panel5 = new Panel();
            dgvDrink = new DataGridView();
            panel4 = new Panel();
            txtSearchDrinkName = new TextBox();
            btnSearchDrink = new Button();
            panel3 = new Panel();
            btnViewDrink = new Button();
            btnDeleteDrink = new Button();
            btnEditDrink = new Button();
            btnAddDrink = new Button();
            tpCategory = new TabPage();
            lbCategoryName = new Panel();
            txtCategoryName = new TextBox();
            txtCategoryID = new TextBox();
            label2 = new Label();
            lbCategoryID = new Label();
            panel8 = new Panel();
            dgvCategory = new DataGridView();
            panel7 = new Panel();
            btnViewCategory = new Button();
            btnDeleteCategory = new Button();
            btnEditCategory = new Button();
            btnAddCategory = new Button();
            tpTable = new TabPage();
            panel11 = new Panel();
            txtStatustable = new TextBox();
            txtTableName = new TextBox();
            txtTableID = new TextBox();
            label4 = new Label();
            lbTableName = new Label();
            lbTabelID = new Label();
            panel10 = new Panel();
            dgvTable = new DataGridView();
            panel9 = new Panel();
            btnViewTable = new Button();
            btnDeleteTable = new Button();
            btnEditTable = new Button();
            btnAddTable = new Button();
            tpAccount = new TabPage();
            panel14 = new Panel();
            label3 = new Label();
            label1 = new Label();
            btnResetPassword = new Button();
            nbAccountType = new NumericUpDown();
            txtAccountDisplayName = new TextBox();
            txtAccountUsername = new TextBox();
            lbAccountType = new Label();
            lbAccountName = new Label();
            lbAccountID = new Label();
            panel13 = new Panel();
            dgvAccount = new DataGridView();
            panel12 = new Panel();
            btnViewAccount = new Button();
            btnDeleteAccount = new Button();
            btnEditAccount = new Button();
            btnAddAcount = new Button();
            tabControl.SuspendLayout();
            tpBill.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            tpDrink.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrink).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tpCategory.SuspendLayout();
            lbCategoryName.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            panel7.SuspendLayout();
            tpTable.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
            panel9.SuspendLayout();
            tpAccount.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbAccountType).BeginInit();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            panel12.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tpBill);
            tabControl.Controls.Add(tpDrink);
            tabControl.Controls.Add(tpCategory);
            tabControl.Controls.Add(tpTable);
            tabControl.Controls.Add(tpAccount);
            tabControl.Location = new Point(19, 9);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(828, 557);
            tabControl.TabIndex = 0;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tpBill.ForeColor = Color.Blue;
            tpBill.Location = new Point(4, 24);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(820, 529);
            tpBill.TabIndex = 0;
            tpBill.Text = "Doanh thu";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtpEndDate);
            panel2.Controls.Add(dtpFromDate);
            panel2.Controls.Add(btnCount);
            panel2.Controls.Add(btnSearchBill);
            panel2.Controls.Add(lbEnd);
            panel2.Controls.Add(lbFrom);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(814, 75);
            panel2.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(418, 26);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 5;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(125, 26);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(200, 23);
            dtpFromDate.TabIndex = 4;
            // 
            // btnCount
            // 
            btnCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCount.Location = new Point(725, 20);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(75, 35);
            btnCount.TabIndex = 3;
            btnCount.Text = "Đếm";
            btnCount.UseVisualStyleBackColor = true;
            // 
            // btnSearchBill
            // 
            btnSearchBill.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchBill.Location = new Point(644, 20);
            btnSearchBill.Name = "btnSearchBill";
            btnSearchBill.Size = new Size(75, 35);
            btnSearchBill.TabIndex = 2;
            btnSearchBill.Text = "Tìm";
            btnSearchBill.UseVisualStyleBackColor = true;
            // 
            // lbEnd
            // 
            lbEnd.AutoSize = true;
            lbEnd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbEnd.Location = new Point(351, 26);
            lbEnd.Name = "lbEnd";
            lbEnd.Size = new Size(41, 21);
            lbEnd.TabIndex = 1;
            lbEnd.Text = "Đến";
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbFrom.Location = new Point(56, 26);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new Size(30, 21);
            lbFrom.TabIndex = 0;
            lbFrom.Text = "Từ";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(dgvBill);
            panel1.Location = new Point(3, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 442);
            panel1.TabIndex = 0;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExport.ForeColor = Color.Red;
            btnExport.Location = new Point(679, 411);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(99, 28);
            btnExport.TabIndex = 1;
            btnExport.Text = "Xuất File";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // dgvBill
            // 
            dgvBill.BackgroundColor = SystemColors.ActiveCaption;
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBill.Location = new Point(0, 0);
            dgvBill.Name = "dgvBill";
            dgvBill.RowTemplate.Height = 25;
            dgvBill.Size = new Size(814, 405);
            dgvBill.TabIndex = 0;
            // 
            // tpDrink
            // 
            tpDrink.Controls.Add(panel6);
            tpDrink.Controls.Add(panel5);
            tpDrink.Controls.Add(panel4);
            tpDrink.Controls.Add(panel3);
            tpDrink.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tpDrink.ForeColor = Color.Blue;
            tpDrink.Location = new Point(4, 24);
            tpDrink.Name = "tpDrink";
            tpDrink.Padding = new Padding(3);
            tpDrink.Size = new Size(820, 529);
            tpDrink.TabIndex = 1;
            tpDrink.Text = "Đồ uống";
            tpDrink.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(cbDrinkCategory);
            panel6.Controls.Add(txtPrice);
            panel6.Controls.Add(txtDrinkName);
            panel6.Controls.Add(txtDrinkID);
            panel6.Controls.Add(lbPrice);
            panel6.Controls.Add(lbDrinkCatefory);
            panel6.Controls.Add(lbDrinkName);
            panel6.Controls.Add(lbDrinkID);
            panel6.Location = new Point(431, 94);
            panel6.Name = "panel6";
            panel6.Size = new Size(386, 432);
            panel6.TabIndex = 3;
            // 
            // cbDrinkCategory
            // 
            cbDrinkCategory.FormattingEnabled = true;
            cbDrinkCategory.Location = new Point(134, 180);
            cbDrinkCategory.Name = "cbDrinkCategory";
            cbDrinkCategory.Size = new Size(220, 23);
            cbDrinkCategory.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(134, 247);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(220, 23);
            txtPrice.TabIndex = 6;
            // 
            // txtDrinkName
            // 
            txtDrinkName.Location = new Point(134, 114);
            txtDrinkName.Name = "txtDrinkName";
            txtDrinkName.Size = new Size(220, 23);
            txtDrinkName.TabIndex = 5;
            // 
            // txtDrinkID
            // 
            txtDrinkID.Location = new Point(134, 48);
            txtDrinkID.Name = "txtDrinkID";
            txtDrinkID.Size = new Size(220, 23);
            txtDrinkID.TabIndex = 4;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(35, 250);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(25, 15);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Giá";
            // 
            // lbDrinkCatefory
            // 
            lbDrinkCatefory.AutoSize = true;
            lbDrinkCatefory.Location = new Point(35, 183);
            lbDrinkCatefory.Name = "lbDrinkCatefory";
            lbDrinkCatefory.Size = new Size(63, 15);
            lbDrinkCatefory.TabIndex = 2;
            lbDrinkCatefory.Text = "Danh mục";
            // 
            // lbDrinkName
            // 
            lbDrinkName.AutoSize = true;
            lbDrinkName.Location = new Point(35, 117);
            lbDrinkName.Name = "lbDrinkName";
            lbDrinkName.Size = new Size(76, 15);
            lbDrinkName.TabIndex = 1;
            lbDrinkName.Text = "Tên đồ uống";
            // 
            // lbDrinkID
            // 
            lbDrinkID.AutoSize = true;
            lbDrinkID.Location = new Point(35, 56);
            lbDrinkID.Name = "lbDrinkID";
            lbDrinkID.Size = new Size(73, 15);
            lbDrinkID.TabIndex = 0;
            lbDrinkID.Text = "Mã đồ uống";
            // 
            // panel5
            // 
            panel5.Controls.Add(dgvDrink);
            panel5.Location = new Point(3, 94);
            panel5.Name = "panel5";
            panel5.Size = new Size(422, 432);
            panel5.TabIndex = 2;
            // 
            // dgvDrink
            // 
            dgvDrink.BackgroundColor = SystemColors.ActiveCaption;
            dgvDrink.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrink.Location = new Point(0, 0);
            dgvDrink.Name = "dgvDrink";
            dgvDrink.RowTemplate.Height = 25;
            dgvDrink.Size = new Size(422, 432);
            dgvDrink.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtSearchDrinkName);
            panel4.Controls.Add(btnSearchDrink);
            panel4.Location = new Point(431, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(386, 85);
            panel4.TabIndex = 1;
            // 
            // txtSearchDrinkName
            // 
            txtSearchDrinkName.Location = new Point(134, 32);
            txtSearchDrinkName.Name = "txtSearchDrinkName";
            txtSearchDrinkName.Size = new Size(203, 23);
            txtSearchDrinkName.TabIndex = 1;
            // 
            // btnSearchDrink
            // 
            btnSearchDrink.Location = new Point(25, 33);
            btnSearchDrink.Name = "btnSearchDrink";
            btnSearchDrink.Size = new Size(75, 23);
            btnSearchDrink.TabIndex = 0;
            btnSearchDrink.Text = "Tìm";
            btnSearchDrink.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnViewDrink);
            panel3.Controls.Add(btnDeleteDrink);
            panel3.Controls.Add(btnEditDrink);
            panel3.Controls.Add(btnAddDrink);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(422, 85);
            panel3.TabIndex = 0;
            // 
            // btnViewDrink
            // 
            btnViewDrink.Location = new Point(311, 31);
            btnViewDrink.Name = "btnViewDrink";
            btnViewDrink.Size = new Size(75, 23);
            btnViewDrink.TabIndex = 3;
            btnViewDrink.Text = "Xem";
            btnViewDrink.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDrink
            // 
            btnDeleteDrink.Location = new Point(214, 31);
            btnDeleteDrink.Name = "btnDeleteDrink";
            btnDeleteDrink.Size = new Size(75, 23);
            btnDeleteDrink.TabIndex = 2;
            btnDeleteDrink.Text = "Xóa";
            btnDeleteDrink.UseVisualStyleBackColor = true;
            // 
            // btnEditDrink
            // 
            btnEditDrink.Location = new Point(119, 31);
            btnEditDrink.Name = "btnEditDrink";
            btnEditDrink.Size = new Size(75, 23);
            btnEditDrink.TabIndex = 1;
            btnEditDrink.Text = "Sửa";
            btnEditDrink.UseVisualStyleBackColor = true;
            // 
            // btnAddDrink
            // 
            btnAddDrink.Location = new Point(26, 31);
            btnAddDrink.Name = "btnAddDrink";
            btnAddDrink.Size = new Size(75, 23);
            btnAddDrink.TabIndex = 0;
            btnAddDrink.Text = "Thêm";
            btnAddDrink.UseVisualStyleBackColor = true;
            // 
            // tpCategory
            // 
            tpCategory.Controls.Add(lbCategoryName);
            tpCategory.Controls.Add(panel8);
            tpCategory.Controls.Add(panel7);
            tpCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tpCategory.ForeColor = Color.Blue;
            tpCategory.Location = new Point(4, 24);
            tpCategory.Name = "tpCategory";
            tpCategory.Size = new Size(820, 529);
            tpCategory.TabIndex = 2;
            tpCategory.Text = "Danh mục";
            tpCategory.UseVisualStyleBackColor = true;
            // 
            // lbCategoryName
            // 
            lbCategoryName.Controls.Add(txtCategoryName);
            lbCategoryName.Controls.Add(txtCategoryID);
            lbCategoryName.Controls.Add(label2);
            lbCategoryName.Controls.Add(lbCategoryID);
            lbCategoryName.Location = new Point(426, 109);
            lbCategoryName.Name = "lbCategoryName";
            lbCategoryName.Size = new Size(391, 417);
            lbCategoryName.TabIndex = 2;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(130, 186);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(196, 23);
            txtCategoryName.TabIndex = 3;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(130, 126);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(196, 23);
            txtCategoryID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 189);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên danh mục";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(45, 129);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(81, 15);
            lbCategoryID.TabIndex = 0;
            lbCategoryID.Text = "Mã danh mục";
            // 
            // panel8
            // 
            panel8.Controls.Add(dgvCategory);
            panel8.Location = new Point(3, 109);
            panel8.Name = "panel8";
            panel8.Size = new Size(417, 417);
            panel8.TabIndex = 1;
            // 
            // dgvCategory
            // 
            dgvCategory.BackgroundColor = SystemColors.ActiveCaption;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(3, 3);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowTemplate.Height = 25;
            dgvCategory.Size = new Size(411, 411);
            dgvCategory.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnViewCategory);
            panel7.Controls.Add(btnDeleteCategory);
            panel7.Controls.Add(btnEditCategory);
            panel7.Controls.Add(btnAddCategory);
            panel7.Location = new Point(232, 24);
            panel7.Name = "panel7";
            panel7.Size = new Size(375, 79);
            panel7.TabIndex = 0;
            // 
            // btnViewCategory
            // 
            btnViewCategory.Location = new Point(279, 27);
            btnViewCategory.Name = "btnViewCategory";
            btnViewCategory.Size = new Size(75, 23);
            btnViewCategory.TabIndex = 3;
            btnViewCategory.Text = "Xem";
            btnViewCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(194, 27);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(75, 23);
            btnDeleteCategory.TabIndex = 2;
            btnDeleteCategory.Text = "Xóa";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(110, 27);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(75, 23);
            btnEditCategory.TabIndex = 1;
            btnEditCategory.Text = "Sửa";
            btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(29, 27);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(75, 23);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel11);
            tpTable.Controls.Add(panel10);
            tpTable.Controls.Add(panel9);
            tpTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tpTable.ForeColor = Color.Blue;
            tpTable.Location = new Point(4, 24);
            tpTable.Name = "tpTable";
            tpTable.Size = new Size(820, 529);
            tpTable.TabIndex = 3;
            tpTable.Text = "Bàn";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Controls.Add(txtStatustable);
            panel11.Controls.Add(txtTableName);
            panel11.Controls.Add(txtTableID);
            panel11.Controls.Add(label4);
            panel11.Controls.Add(lbTableName);
            panel11.Controls.Add(lbTabelID);
            panel11.Location = new Point(410, 109);
            panel11.Name = "panel11";
            panel11.Size = new Size(407, 417);
            panel11.TabIndex = 3;
            // 
            // txtStatustable
            // 
            txtStatustable.Location = new Point(136, 217);
            txtStatustable.Name = "txtStatustable";
            txtStatustable.Size = new Size(213, 23);
            txtStatustable.TabIndex = 5;
            // 
            // txtTableName
            // 
            txtTableName.Location = new Point(136, 177);
            txtTableName.Name = "txtTableName";
            txtTableName.Size = new Size(213, 23);
            txtTableName.TabIndex = 4;
            // 
            // txtTableID
            // 
            txtTableID.Location = new Point(136, 129);
            txtTableID.Name = "txtTableID";
            txtTableID.Size = new Size(213, 23);
            txtTableID.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 225);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 2;
            label4.Text = "Status";
            // 
            // lbTableName
            // 
            lbTableName.AutoSize = true;
            lbTableName.Location = new Point(48, 177);
            lbTableName.Name = "lbTableName";
            lbTableName.Size = new Size(51, 15);
            lbTableName.TabIndex = 1;
            lbTableName.Text = "Tên Bàn";
            // 
            // lbTabelID
            // 
            lbTabelID.AutoSize = true;
            lbTabelID.Location = new Point(48, 130);
            lbTabelID.Name = "lbTabelID";
            lbTabelID.Size = new Size(47, 15);
            lbTabelID.TabIndex = 0;
            lbTabelID.Text = "Mã bàn";
            // 
            // panel10
            // 
            panel10.Controls.Add(dgvTable);
            panel10.Location = new Point(3, 109);
            panel10.Name = "panel10";
            panel10.Size = new Size(401, 417);
            panel10.TabIndex = 2;
            // 
            // dgvTable
            // 
            dgvTable.BackgroundColor = SystemColors.ActiveCaption;
            dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTable.Location = new Point(0, 3);
            dgvTable.Name = "dgvTable";
            dgvTable.RowTemplate.Height = 25;
            dgvTable.Size = new Size(398, 411);
            dgvTable.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnViewTable);
            panel9.Controls.Add(btnDeleteTable);
            panel9.Controls.Add(btnEditTable);
            panel9.Controls.Add(btnAddTable);
            panel9.Location = new Point(210, 22);
            panel9.Name = "panel9";
            panel9.Size = new Size(375, 79);
            panel9.TabIndex = 1;
            // 
            // btnViewTable
            // 
            btnViewTable.Location = new Point(279, 27);
            btnViewTable.Name = "btnViewTable";
            btnViewTable.Size = new Size(75, 23);
            btnViewTable.TabIndex = 3;
            btnViewTable.Text = "Xem";
            btnViewTable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(194, 27);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(75, 23);
            btnDeleteTable.TabIndex = 2;
            btnDeleteTable.Text = "Xóa";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnEditTable
            // 
            btnEditTable.Location = new Point(110, 27);
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(75, 23);
            btnEditTable.TabIndex = 1;
            btnEditTable.Text = "Sửa";
            btnEditTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(29, 27);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(75, 23);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "Thêm";
            btnAddTable.UseVisualStyleBackColor = true;
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(panel14);
            tpAccount.Controls.Add(panel13);
            tpAccount.Controls.Add(panel12);
            tpAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tpAccount.ForeColor = Color.Blue;
            tpAccount.Location = new Point(4, 24);
            tpAccount.Name = "tpAccount";
            tpAccount.Size = new Size(820, 529);
            tpAccount.TabIndex = 4;
            tpAccount.Text = "Tài khoản";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            panel14.Controls.Add(label3);
            panel14.Controls.Add(label1);
            panel14.Controls.Add(btnResetPassword);
            panel14.Controls.Add(nbAccountType);
            panel14.Controls.Add(txtAccountDisplayName);
            panel14.Controls.Add(txtAccountUsername);
            panel14.Controls.Add(lbAccountType);
            panel14.Controls.Add(lbAccountName);
            panel14.Controls.Add(lbAccountID);
            panel14.Location = new Point(431, 97);
            panel14.Name = "panel14";
            panel14.Size = new Size(386, 429);
            panel14.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 256);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 8;
            label3.Text = "1 là Admin)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 241);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 7;
            label1.Text = "(0 là Nhân viên";
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(243, 277);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(111, 51);
            btnResetPassword.TabIndex = 6;
            btnResetPassword.Text = "Đặt lại mật khẩu";
            btnResetPassword.UseVisualStyleBackColor = true;
            // 
            // nbAccountType
            // 
            nbAccountType.Location = new Point(142, 214);
            nbAccountType.Name = "nbAccountType";
            nbAccountType.Size = new Size(153, 23);
            nbAccountType.TabIndex = 5;
            // 
            // txtAccountDisplayName
            // 
            txtAccountDisplayName.Location = new Point(142, 153);
            txtAccountDisplayName.Name = "txtAccountDisplayName";
            txtAccountDisplayName.Size = new Size(212, 23);
            txtAccountDisplayName.TabIndex = 4;
            // 
            // txtAccountUsername
            // 
            txtAccountUsername.Location = new Point(142, 104);
            txtAccountUsername.Name = "txtAccountUsername";
            txtAccountUsername.Size = new Size(212, 23);
            txtAccountUsername.TabIndex = 3;
            // 
            // lbAccountType
            // 
            lbAccountType.AutoSize = true;
            lbAccountType.Location = new Point(37, 216);
            lbAccountType.Name = "lbAccountType";
            lbAccountType.Size = new Size(83, 15);
            lbAccountType.TabIndex = 2;
            lbAccountType.Text = "Loại tài khoản";
            // 
            // lbAccountName
            // 
            lbAccountName.AutoSize = true;
            lbAccountName.Location = new Point(37, 161);
            lbAccountName.Name = "lbAccountName";
            lbAccountName.Size = new Size(72, 15);
            lbAccountName.TabIndex = 1;
            lbAccountName.Text = "Tên hiển thị";
            // 
            // lbAccountID
            // 
            lbAccountID.AutoSize = true;
            lbAccountID.Location = new Point(37, 112);
            lbAccountID.Name = "lbAccountID";
            lbAccountID.Size = new Size(81, 15);
            lbAccountID.TabIndex = 0;
            lbAccountID.Text = "Tên tài khoản";
            // 
            // panel13
            // 
            panel13.Controls.Add(dgvAccount);
            panel13.Location = new Point(3, 97);
            panel13.Name = "panel13";
            panel13.Size = new Size(422, 429);
            panel13.TabIndex = 3;
            // 
            // dgvAccount
            // 
            dgvAccount.BackgroundColor = SystemColors.ActiveCaption;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Location = new Point(3, 3);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.RowTemplate.Height = 25;
            dgvAccount.Size = new Size(416, 423);
            dgvAccount.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.Controls.Add(btnViewAccount);
            panel12.Controls.Add(btnDeleteAccount);
            panel12.Controls.Add(btnEditAccount);
            panel12.Controls.Add(btnAddAcount);
            panel12.Location = new Point(217, 12);
            panel12.Name = "panel12";
            panel12.Size = new Size(375, 79);
            panel12.TabIndex = 2;
            // 
            // btnViewAccount
            // 
            btnViewAccount.Location = new Point(279, 27);
            btnViewAccount.Name = "btnViewAccount";
            btnViewAccount.Size = new Size(75, 23);
            btnViewAccount.TabIndex = 3;
            btnViewAccount.Text = "Xem";
            btnViewAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(194, 27);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(75, 23);
            btnDeleteAccount.TabIndex = 2;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(110, 27);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(75, 23);
            btnEditAccount.TabIndex = 1;
            btnEditAccount.Text = "Sửa";
            btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAcount
            // 
            btnAddAcount.Location = new Point(29, 27);
            btnAddAcount.Name = "btnAddAcount";
            btnAddAcount.Size = new Size(75, 23);
            btnAddAcount.TabIndex = 0;
            btnAddAcount.Text = "Thêm";
            btnAddAcount.UseVisualStyleBackColor = true;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 578);
            Controls.Add(tabControl);
            Name = "FrmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAdmin";
            tabControl.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            tpDrink.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDrink).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            tpCategory.ResumeLayout(false);
            lbCategoryName.ResumeLayout(false);
            lbCategoryName.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            panel7.ResumeLayout(false);
            tpTable.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
            panel9.ResumeLayout(false);
            tpAccount.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbAccountType).EndInit();
            panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            panel12.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tpBill;
        private TabPage tpDrink;
        private Panel panel2;
        private DateTimePicker dtpFromDate;
        private Button btnCount;
        private Button btnSearchBill;
        private Label lbEnd;
        private Label lbFrom;
        private Panel panel1;
        private Button btnExport;
        private DataGridView dgvBill;
        private DateTimePicker dtpEndDate;
        private Panel panel6;
        private Panel panel5;
        private DataGridView dgvDrink;
        private Panel panel4;
        private Button btnSearchDrink;
        private Panel panel3;
        private Button btnViewDrink;
        private Button btnDeleteDrink;
        private Button btnEditDrink;
        private Button btnAddDrink;
        private TabPage tpCategory;
        private TabPage tpTable;
        private TabPage tpAccount;
        private ComboBox cbDrinkCategory;
        private TextBox txtPrice;
        private TextBox txtDrinkName;
        private TextBox txtDrinkID;
        private Label lbPrice;
        private Label lbDrinkCatefory;
        private Label lbDrinkName;
        private Label lbDrinkID;
        private TextBox txtSearchDrinkName;
        private Panel lbCategoryName;
        private Panel panel8;
        private DataGridView dgvCategory;
        private Panel panel7;
        private TextBox txtCategoryID;
        private Label label2;
        private Label lbCategoryID;
        private Button btnViewCategory;
        private Button btnDeleteCategory;
        private Button btnEditCategory;
        private Button btnAddCategory;
        private TextBox txtCategoryName;
        private Panel panel9;
        private Button btnViewTable;
        private Button btnDeleteTable;
        private Button btnEditTable;
        private Button btnAddTable;
        private Panel panel11;
        private Panel panel10;
        private TextBox txtStatustable;
        private TextBox txtTableName;
        private TextBox txtTableID;
        private Label label4;
        private Label lbTableName;
        private Label lbTabelID;
        private DataGridView dgvTable;
        private Panel panel12;
        private Button btnViewAccount;
        private Button btnDeleteAccount;
        private Button btnEditAccount;
        private Button btnAddAcount;
        private Panel panel14;
        private Button btnResetPassword;
        private NumericUpDown nbAccountType;
        private TextBox txtAccountDisplayName;
        private TextBox txtAccountUsername;
        private Label lbAccountType;
        private Label lbAccountName;
        private Label lbAccountID;
        private Panel panel13;
        private DataGridView dgvAccount;
        private Label label3;
        private Label label1;
    }
}