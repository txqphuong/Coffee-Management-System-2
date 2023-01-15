namespace Nhom11_QLQuanCafe
{
    partial class Frm_HoaDon
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
            this.dgv_DsHD = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_taoHDMoi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_In = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ThanhTien = new System.Windows.Forms.Label();
            this.txt_GiamGia = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.Label();
            this.lb_idHD = new System.Windows.Forms.Label();
            this.cbo_TenSP = new System.Windows.Forms.ComboBox();
            this.brt_ThanhToan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DsCTHD = new System.Windows.Forms.DataGridView();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsCTHD)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DsHD
            // 
            this.dgv_DsHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DsHD.Location = new System.Drawing.Point(9, 134);
            this.dgv_DsHD.Name = "dgv_DsHD";
            this.dgv_DsHD.ReadOnly = true;
            this.dgv_DsHD.RowTemplate.Height = 24;
            this.dgv_DsHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DsHD.Size = new System.Drawing.Size(482, 494);
            this.dgv_DsHD.TabIndex = 0;
            this.dgv_DsHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DsHD_CellClick);
            this.dgv_DsHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DsHD_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_taoHDMoi);
            this.groupBox1.Controls.Add(this.dgv_DsHD);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(28, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 709);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hoá đơn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(9, 651);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 51);
            this.button1.TabIndex = 20;
            this.button1.Text = "Tải lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_taoHDMoi
            // 
            this.btn_taoHDMoi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_taoHDMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taoHDMoi.ForeColor = System.Drawing.Color.Black;
            this.btn_taoHDMoi.Location = new System.Drawing.Point(9, 49);
            this.btn_taoHDMoi.Name = "btn_taoHDMoi";
            this.btn_taoHDMoi.Size = new System.Drawing.Size(482, 68);
            this.btn_taoHDMoi.TabIndex = 1;
            this.btn_taoHDMoi.Text = "Tạo hoá đơn mới";
            this.btn_taoHDMoi.UseVisualStyleBackColor = false;
            this.btn_taoHDMoi.Click += new System.EventHandler(this.btn_taoHDMoi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btn_In);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_ThanhTien);
            this.groupBox2.Controls.Add(this.txt_GiamGia);
            this.groupBox2.Controls.Add(this.txt_DonGia);
            this.groupBox2.Controls.Add(this.lb_idHD);
            this.groupBox2.Controls.Add(this.cbo_TenSP);
            this.groupBox2.Controls.Add(this.brt_ThanhToan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_SoLuong);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgv_DsCTHD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(536, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1005, 628);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hoá đơn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(344, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(393, 40);
            this.label9.TabIndex = 11;
            this.label9.Text = " Hóa đơn đã thanh toán";
            this.label9.Visible = false;
            // 
            // btn_In
            // 
            this.btn_In.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_In.ForeColor = System.Drawing.Color.Black;
            this.btn_In.Image = global::Nhom11_QLQuanCafe.Properties.Resources.Loading1;
            this.btn_In.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_In.Location = new System.Drawing.Point(20, 557);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(153, 54);
            this.btn_In.TabIndex = 18;
            this.btn_In.Text = "In";
            this.btn_In.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_In.UseVisualStyleBackColor = false;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(729, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mặc định:";
            this.label8.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(851, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = " ";
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.AutoSize = true;
            this.txt_ThanhTien.Location = new System.Drawing.Point(877, 31);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.Size = new System.Drawing.Size(25, 29);
            this.txt_ThanhTien.TabIndex = 8;
            this.txt_ThanhTien.Text = "  ";
            // 
            // txt_GiamGia
            // 
            this.txt_GiamGia.AutoSize = true;
            this.txt_GiamGia.Location = new System.Drawing.Point(892, 80);
            this.txt_GiamGia.Name = "txt_GiamGia";
            this.txt_GiamGia.Size = new System.Drawing.Size(25, 29);
            this.txt_GiamGia.TabIndex = 6;
            this.txt_GiamGia.Text = "  ";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.AutoSize = true;
            this.txt_DonGia.ForeColor = System.Drawing.Color.Black;
            this.txt_DonGia.Location = new System.Drawing.Point(367, 80);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(25, 29);
            this.txt_DonGia.TabIndex = 5;
            this.txt_DonGia.Text = "  ";
            // 
            // lb_idHD
            // 
            this.lb_idHD.AutoSize = true;
            this.lb_idHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idHD.Location = new System.Drawing.Point(904, 254);
            this.lb_idHD.Name = "lb_idHD";
            this.lb_idHD.Size = new System.Drawing.Size(84, 29);
            this.lb_idHD.TabIndex = 4;
            this.lb_idHD.Text = " Trống";
            // 
            // cbo_TenSP
            // 
            this.cbo_TenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TenSP.FormattingEnabled = true;
            this.cbo_TenSP.Location = new System.Drawing.Point(365, 28);
            this.cbo_TenSP.Name = "cbo_TenSP";
            this.cbo_TenSP.Size = new System.Drawing.Size(286, 37);
            this.cbo_TenSP.TabIndex = 3;
            this.cbo_TenSP.SelectedIndexChanged += new System.EventHandler(this.cbo_TenSP_SelectedIndexChanged);
            // 
            // brt_ThanhToan
            // 
            this.brt_ThanhToan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.brt_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brt_ThanhToan.ForeColor = System.Drawing.Color.Black;
            this.brt_ThanhToan.Image = global::Nhom11_QLQuanCafe.Properties.Resources.Loading1;
            this.brt_ThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brt_ThanhToan.Location = new System.Drawing.Point(770, 547);
            this.brt_ThanhToan.Name = "brt_ThanhToan";
            this.brt_ThanhToan.Size = new System.Drawing.Size(218, 75);
            this.brt_ThanhToan.TabIndex = 1;
            this.brt_ThanhToan.Text = "Thanh toán";
            this.brt_ThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.brt_ThanhToan.UseVisualStyleBackColor = false;
            this.brt_ThanhToan.Click += new System.EventHandler(this.brt_ThanhToan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(729, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Thành tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(192, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đơn giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(729, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Sau khi giảm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(192, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(365, 125);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(139, 35);
            this.txt_SoLuong.TabIndex = 1;
            this.txt_SoLuong.TextChanged += new System.EventHandler(this.txt_SoLuong_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(192, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(860, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // dgv_DsCTHD
            // 
            this.dgv_DsCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DsCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DsCTHD.Location = new System.Drawing.Point(20, 315);
            this.dgv_DsCTHD.Name = "dgv_DsCTHD";
            this.dgv_DsCTHD.ReadOnly = true;
            this.dgv_DsCTHD.RowTemplate.Height = 24;
            this.dgv_DsCTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DsCTHD.Size = new System.Drawing.Size(960, 226);
            this.dgv_DsCTHD.TabIndex = 0;
            this.dgv_DsCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DsCTHD_CellClick);
            this.dgv_DsCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DsCTHD_CellContentClick);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Black;
            this.btn_Sua.Image = global::Nhom11_QLQuanCafe.Properties.Resources.Modify;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(183, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(156, 58);
            this.btn_Sua.TabIndex = 15;
            this.btn_Sua.Text = "Sửa   ";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Black;
            this.btn_Them.Image = global::Nhom11_QLQuanCafe.Properties.Resources.Add;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(602, 668);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(170, 62);
            this.btn_Them.TabIndex = 16;
            this.btn_Them.Text = "Thêm ";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_Xoa.Image = global::Nhom11_QLQuanCafe.Properties.Resources.Delete;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(5, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(172, 58);
            this.btn_Xoa.TabIndex = 19;
            this.btn_Xoa.Text = "Xoá  ";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Location = new System.Drawing.Point(903, 667);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 63);
            this.panel1.TabIndex = 20;
            // 
            // Frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1555, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_HoaDon";
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.Frm_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsCTHD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dgv_DsHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_taoHDMoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbo_TenSP;
        private System.Windows.Forms.Button brt_ThanhToan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DsCTHD;
        private System.Windows.Forms.Label lb_idHD;
        private System.Windows.Forms.Label txt_GiamGia;
        private System.Windows.Forms.Label txt_DonGia;
        private System.Windows.Forms.Label txt_ThanhTien;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_In;
        private System.Windows.Forms.Panel panel1;
    }
}