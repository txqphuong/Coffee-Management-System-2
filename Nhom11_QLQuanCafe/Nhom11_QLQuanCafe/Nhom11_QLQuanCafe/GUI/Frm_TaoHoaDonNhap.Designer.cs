namespace Nhom11_QLQuanCafe
{
    partial class Frm_TaoHoaDonNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.txt_NgayNhap = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hoadonnhapTableAdapter1 = new Nhom11_QLQuanCafe.DAL.QLQuanCafeTableAdapters.HOADONNHAPTableAdapter();
            this.cbo_MaNCC = new System.Windows.Forms.ComboBox();
            this.qLQuanCafe = new Nhom11_QLQuanCafe.DAL.QLQuanCafe();
            this.hOADONNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbo_MaNV = new System.Windows.Forms.ComboBox();
            this.txt_MaHDN = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLQuanCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONNHAPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1464, 109);
            this.panel1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(468, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "TẠO HOÁ ĐƠN NHẬP MỚI";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.txt_MaHDN);
            this.groupBox1.Controls.Add(this.cbo_MaNV);
            this.groupBox1.Controls.Add(this.cbo_MaNCC);
            this.groupBox1.Controls.Add(this.btn_OK);
            this.groupBox1.Controls.Add(this.txt_GhiChu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_TongTien);
            this.groupBox1.Controls.Add(this.txt_NgayNhap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(76, 160);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1326, 414);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn nhập";
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_OK.Location = new System.Drawing.Point(1125, 323);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(170, 74);
            this.btn_OK.TabIndex = 50;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(951, 218);
            this.txt_GhiChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_GhiChu.Multiline = true;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(342, 41);
            this.txt_GhiChu.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(814, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 29);
            this.label7.TabIndex = 48;
            this.label7.Text = "Ghi chú";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(288, 214);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TongTien.Multiline = true;
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(342, 41);
            this.txt_TongTien.TabIndex = 47;
            // 
            // txt_NgayNhap
            // 
            this.txt_NgayNhap.Location = new System.Drawing.Point(951, 138);
            this.txt_NgayNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_NgayNhap.Mask = "00/00/0000";
            this.txt_NgayNhap.Name = "txt_NgayNhap";
            this.txt_NgayNhap.Size = new System.Drawing.Size(342, 33);
            this.txt_NgayNhap.TabIndex = 46;
            this.txt_NgayNhap.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(783, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 29);
            this.label6.TabIndex = 45;
            this.label6.Text = "Ngày nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 29);
            this.label5.TabIndex = 42;
            this.label5.Text = "Tổng tiền nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(762, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 29);
            this.label4.TabIndex = 41;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "Mã nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã hóa đơn nhập";
            // 
            // hoadonnhapTableAdapter1
            // 
            this.hoadonnhapTableAdapter1.ClearBeforeFill = true;
            // 
            // cbo_MaNCC
            // 
            this.cbo_MaNCC.FormattingEnabled = true;
            this.cbo_MaNCC.Location = new System.Drawing.Point(288, 138);
            this.cbo_MaNCC.Name = "cbo_MaNCC";
            this.cbo_MaNCC.Size = new System.Drawing.Size(342, 37);
            this.cbo_MaNCC.TabIndex = 51;
            // 
            // qLQuanCafe
            // 
            this.qLQuanCafe.DataSetName = "QLQuanCafe";
            this.qLQuanCafe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOADONNHAPBindingSource
            // 
            this.hOADONNHAPBindingSource.DataMember = "HOADONNHAP";
            this.hOADONNHAPBindingSource.DataSource = this.qLQuanCafe;
            // 
            // cbo_MaNV
            // 
            this.cbo_MaNV.FormattingEnabled = true;
            this.cbo_MaNV.Location = new System.Drawing.Point(951, 54);
            this.cbo_MaNV.Name = "cbo_MaNV";
            this.cbo_MaNV.Size = new System.Drawing.Size(342, 37);
            this.cbo_MaNV.TabIndex = 52;
            // 
            // txt_MaHDN
            // 
            this.txt_MaHDN.Location = new System.Drawing.Point(288, 62);
            this.txt_MaHDN.Name = "txt_MaHDN";
            this.txt_MaHDN.Size = new System.Drawing.Size(342, 33);
            this.txt_MaHDN.TabIndex = 53;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Frm_TaoHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1464, 623);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_TaoHoaDonNhap";
            this.Text = "Tạo hóa đơn nhập";
            this.Load += new System.EventHandler(this.Frm_TaoHoaDonNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLQuanCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONNHAPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.MaskedTextBox txt_NgayNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_OK;
        private DAL.QLQuanCafeTableAdapters.HOADONNHAPTableAdapter hoadonnhapTableAdapter1;
        private System.Windows.Forms.ComboBox cbo_MaNCC;
        private System.Windows.Forms.BindingSource hOADONNHAPBindingSource;
        private DAL.QLQuanCafe qLQuanCafe;
        private System.Windows.Forms.ComboBox cbo_MaNV;
        private System.Windows.Forms.TextBox txt_MaHDN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}