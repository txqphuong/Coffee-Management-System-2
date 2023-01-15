namespace Nhom11_QLQuanCafe
{
    partial class Frm_DanhMucNguyenLieu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DanhMucNguyenLieu));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_HSD = new System.Windows.Forms.TextBox();
            this.nGUYENLIEUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLQuanCafe = new Nhom11_QLQuanCafe.DAL.QLQuanCafe();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_SL = new System.Windows.Forms.TextBox();
            this.txt_TenNL = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaNL = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuCo_bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.dgv_NguyenLieu = new System.Windows.Forms.DataGridView();
            this.mANLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENNLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGCONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hANSDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nGUYENLIEUTableAdapter = new Nhom11_QLQuanCafe.DAL.QLQuanCafeTableAdapters.NGUYENLIEUTableAdapter();
            this.btn_TaiLai = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nGUYENLIEUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQuanCafe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuCo_bindingNavigator)).BeginInit();
            this.SuCo_bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguyenLieu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(87, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hạn sử dụng";
            this.label7.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(680, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Đơn giá";
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(58, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng còn lại";
            this.label5.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(609, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên nguyên liệu";
            this.label2.UseWaitCursor = true;
            // 
            // txt_HSD
            // 
            this.txt_HSD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nGUYENLIEUBindingSource, "HANSD", true));
            this.txt_HSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HSD.Location = new System.Drawing.Point(252, 191);
            this.txt_HSD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_HSD.Name = "txt_HSD";
            this.txt_HSD.Size = new System.Drawing.Size(324, 35);
            this.txt_HSD.TabIndex = 5;
            this.txt_HSD.UseWaitCursor = true;
            // 
            // nGUYENLIEUBindingSource
            // 
            this.nGUYENLIEUBindingSource.DataMember = "NGUYENLIEU";
            this.nGUYENLIEUBindingSource.DataSource = this.qLQuanCafe;
            // 
            // qLQuanCafe
            // 
            this.qLQuanCafe.DataSetName = "QLQuanCafe";
            this.qLQuanCafe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nGUYENLIEUBindingSource, "DONGIA", true));
            this.txt_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonGia.Location = new System.Drawing.Point(792, 126);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(324, 35);
            this.txt_DonGia.TabIndex = 5;
            this.txt_DonGia.UseWaitCursor = true;
            // 
            // txt_SL
            // 
            this.txt_SL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nGUYENLIEUBindingSource, "SOLUONGCON", true));
            this.txt_SL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SL.Location = new System.Drawing.Point(252, 126);
            this.txt_SL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(324, 35);
            this.txt_SL.TabIndex = 5;
            this.txt_SL.UseWaitCursor = true;
            // 
            // txt_TenNL
            // 
            this.txt_TenNL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nGUYENLIEUBindingSource, "TENNL", true));
            this.txt_TenNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNL.Location = new System.Drawing.Point(792, 62);
            this.txt_TenNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenNL.Name = "txt_TenNL";
            this.txt_TenNL.Size = new System.Drawing.Size(324, 35);
            this.txt_TenNL.TabIndex = 5;
            this.txt_TenNL.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_HSD);
            this.groupBox1.Controls.Add(this.txt_DonGia);
            this.groupBox1.Controls.Add(this.txt_SL);
            this.groupBox1.Controls.Add(this.txt_TenNL);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_MaNL);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(279, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1197, 248);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nguyên liệu";
            this.groupBox1.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(69, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã nguyên liệu";
            this.label4.UseWaitCursor = true;
            // 
            // txt_MaNL
            // 
            this.txt_MaNL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nGUYENLIEUBindingSource, "MANL", true));
            this.txt_MaNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNL.Location = new System.Drawing.Point(252, 62);
            this.txt_MaNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaNL.Name = "txt_MaNL";
            this.txt_MaNL.Size = new System.Drawing.Size(324, 35);
            this.txt_MaNL.TabIndex = 5;
            this.txt_MaNL.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1642, 109);
            this.panel2.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(620, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(644, 55);
            this.label9.TabIndex = 1;
            this.label9.Text = "DANH MỤC NGUYÊN LIỆU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(636, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH MỤC SẢM PHẨM";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.SuCo_bindingNavigator);
            this.groupBox2.Controls.Add(this.dgv_NguyenLieu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(279, 400);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1197, 414);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nguyên liệu";
            // 
            // SuCo_bindingNavigator
            // 
            this.SuCo_bindingNavigator.AddNewItem = null;
            this.SuCo_bindingNavigator.AutoSize = false;
            this.SuCo_bindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.SuCo_bindingNavigator.BindingSource = this.nGUYENLIEUBindingSource;
            this.SuCo_bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.SuCo_bindingNavigator.DeleteItem = null;
            this.SuCo_bindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.SuCo_bindingNavigator.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SuCo_bindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.SuCo_bindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SuCo_bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.saveToolStripButton,
            this.toolStripSeparator});
            this.SuCo_bindingNavigator.Location = new System.Drawing.Point(386, 29);
            this.SuCo_bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.SuCo_bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.SuCo_bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.SuCo_bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.SuCo_bindingNavigator.Name = "SuCo_bindingNavigator";
            this.SuCo_bindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.SuCo_bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.SuCo_bindingNavigator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SuCo_bindingNavigator.Size = new System.Drawing.Size(429, 52);
            this.SuCo_bindingNavigator.TabIndex = 98;
            this.SuCo_bindingNavigator.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(61, 49);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 49);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 49);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(56, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 49);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 49);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = global::Nhom11_QLQuanCafe.Properties.Resources.sync;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(24, 49);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 52);
            // 
            // dgv_NguyenLieu
            // 
            this.dgv_NguyenLieu.AutoGenerateColumns = false;
            this.dgv_NguyenLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANLDataGridViewTextBoxColumn,
            this.tENNLDataGridViewTextBoxColumn,
            this.sOLUONGCONDataGridViewTextBoxColumn,
            this.hANSDDataGridViewTextBoxColumn,
            this.dONGIADataGridViewTextBoxColumn});
            this.dgv_NguyenLieu.DataSource = this.nGUYENLIEUBindingSource;
            this.dgv_NguyenLieu.Location = new System.Drawing.Point(14, 48);
            this.dgv_NguyenLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_NguyenLieu.Name = "dgv_NguyenLieu";
            this.dgv_NguyenLieu.ReadOnly = true;
            this.dgv_NguyenLieu.RowTemplate.Height = 24;
            this.dgv_NguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NguyenLieu.Size = new System.Drawing.Size(1168, 323);
            this.dgv_NguyenLieu.TabIndex = 0;
            // 
            // mANLDataGridViewTextBoxColumn
            // 
            this.mANLDataGridViewTextBoxColumn.DataPropertyName = "MANL";
            this.mANLDataGridViewTextBoxColumn.HeaderText = "Mã nguyên liệu";
            this.mANLDataGridViewTextBoxColumn.Name = "mANLDataGridViewTextBoxColumn";
            // 
            // tENNLDataGridViewTextBoxColumn
            // 
            this.tENNLDataGridViewTextBoxColumn.DataPropertyName = "TENNL";
            this.tENNLDataGridViewTextBoxColumn.HeaderText = "Tên nguyên liệu";
            this.tENNLDataGridViewTextBoxColumn.Name = "tENNLDataGridViewTextBoxColumn";
            // 
            // sOLUONGCONDataGridViewTextBoxColumn
            // 
            this.sOLUONGCONDataGridViewTextBoxColumn.DataPropertyName = "SOLUONGCON";
            this.sOLUONGCONDataGridViewTextBoxColumn.HeaderText = "Số lượng còn";
            this.sOLUONGCONDataGridViewTextBoxColumn.Name = "sOLUONGCONDataGridViewTextBoxColumn";
            // 
            // hANSDDataGridViewTextBoxColumn
            // 
            this.hANSDDataGridViewTextBoxColumn.DataPropertyName = "HANSD";
            this.hANSDDataGridViewTextBoxColumn.HeaderText = "Hạn sử dụng";
            this.hANSDDataGridViewTextBoxColumn.Name = "hANSDDataGridViewTextBoxColumn";
            // 
            // dONGIADataGridViewTextBoxColumn
            // 
            this.dONGIADataGridViewTextBoxColumn.DataPropertyName = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.dONGIADataGridViewTextBoxColumn.Name = "dONGIADataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1642, 109);
            this.panel1.TabIndex = 26;
            // 
            // nGUYENLIEUTableAdapter
            // 
            this.nGUYENLIEUTableAdapter.ClearBeforeFill = true;
            // 
            // btn_TaiLai
            // 
            this.btn_TaiLai.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_TaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaiLai.ForeColor = System.Drawing.Color.Black;
            this.btn_TaiLai.Image = global::Nhom11_QLQuanCafe.Properties.Resources.Next;
            this.btn_TaiLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaiLai.Location = new System.Drawing.Point(1167, 820);
            this.btn_TaiLai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_TaiLai.Name = "btn_TaiLai";
            this.btn_TaiLai.Size = new System.Drawing.Size(152, 91);
            this.btn_TaiLai.TabIndex = 32;
            this.btn_TaiLai.Text = "Tải lại";
            this.btn_TaiLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TaiLai.UseVisualStyleBackColor = false;
            this.btn_TaiLai.Click += new System.EventHandler(this.btn_TaiLai_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Black;
            this.btn_Sua.Image = global::Nhom11_QLQuanCafe.Properties.Resources.Modify;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(933, 820);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(152, 91);
            this.btn_Sua.TabIndex = 31;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_Xoa.Image = global::Nhom11_QLQuanCafe.Properties.Resources.Delete;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(699, 818);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(152, 91);
            this.btn_Xoa.TabIndex = 30;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Black;
            this.btn_Them.Image = global::Nhom11_QLQuanCafe.Properties.Resources.Add;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(468, 818);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(152, 91);
            this.btn_Them.TabIndex = 29;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // Frm_DanhMucNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1642, 917);
            this.ControlBox = false;
            this.Controls.Add(this.btn_TaiLai);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_DanhMucNguyenLieu";
            this.Text = "Danh mục nguyên liệu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_DanhMucNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nGUYENLIEUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQuanCafe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SuCo_bindingNavigator)).EndInit();
            this.SuCo_bindingNavigator.ResumeLayout(false);
            this.SuCo_bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguyenLieu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_HSD;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_SL;
        private System.Windows.Forms.TextBox txt_TenNL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MaNL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_NguyenLieu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private DAL.QLQuanCafe qLQuanCafe;
        private System.Windows.Forms.BindingSource nGUYENLIEUBindingSource;
        private DAL.QLQuanCafeTableAdapters.NGUYENLIEUTableAdapter nGUYENLIEUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENNLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGCONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hANSDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator SuCo_bindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.Button btn_TaiLai;
    }
}