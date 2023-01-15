namespace Nhom11_QLQuanCafe
{
    partial class Frm_ThongKe
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.data_DSHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mtxt_NgayKT = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_NgayBD = new System.Windows.Forms.MaskedTextBox();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.rdo_HDBan = new System.Windows.Forms.RadioButton();
            this.rdo_HDNhap = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_DSHoaDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1743, 109);
            this.panel2.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(632, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(524, 55);
            this.label9.TabIndex = 1;
            this.label9.Text = "THỐNG KÊ HOÁ ĐƠN";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.data_DSHoaDon);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(168, 394);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1440, 375);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách hoá đơn";
            // 
            // data_DSHoaDon
            // 
            this.data_DSHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.data_DSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_DSHoaDon.Location = new System.Drawing.Point(34, 43);
            this.data_DSHoaDon.Name = "data_DSHoaDon";
            this.data_DSHoaDon.ReadOnly = true;
            this.data_DSHoaDon.RowTemplate.Height = 24;
            this.data_DSHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_DSHoaDon.Size = new System.Drawing.Size(1378, 318);
            this.data_DSHoaDon.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.mtxt_NgayKT);
            this.groupBox3.Controls.Add(this.mtxt_NgayBD);
            this.groupBox3.Controls.Add(this.btn_Loc);
            this.groupBox3.Controls.Add(this.rdo_HDBan);
            this.groupBox3.Controls.Add(this.rdo_HDNhap);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(168, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1440, 212);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Điều kiện lọc";
            // 
            // mtxt_NgayKT
            // 
            this.mtxt_NgayKT.Location = new System.Drawing.Point(920, 34);
            this.mtxt_NgayKT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxt_NgayKT.Mask = "00/00/0000";
            this.mtxt_NgayKT.Name = "mtxt_NgayKT";
            this.mtxt_NgayKT.Size = new System.Drawing.Size(274, 33);
            this.mtxt_NgayKT.TabIndex = 11;
            this.mtxt_NgayKT.ValidatingType = typeof(System.DateTime);
            // 
            // mtxt_NgayBD
            // 
            this.mtxt_NgayBD.Location = new System.Drawing.Point(447, 34);
            this.mtxt_NgayBD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxt_NgayBD.Mask = "00/00/0000";
            this.mtxt_NgayBD.Name = "mtxt_NgayBD";
            this.mtxt_NgayBD.Size = new System.Drawing.Size(274, 33);
            this.mtxt_NgayBD.TabIndex = 10;
            this.mtxt_NgayBD.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Loc
            // 
            this.btn_Loc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Loc.Image = global::Nhom11_QLQuanCafe.Properties.Resources.Search;
            this.btn_Loc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Loc.Location = new System.Drawing.Point(1059, 100);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(136, 80);
            this.btn_Loc.TabIndex = 9;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Loc.UseVisualStyleBackColor = false;
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // rdo_HDBan
            // 
            this.rdo_HDBan.AutoSize = true;
            this.rdo_HDBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_HDBan.Location = new System.Drawing.Point(772, 131);
            this.rdo_HDBan.Name = "rdo_HDBan";
            this.rdo_HDBan.Size = new System.Drawing.Size(175, 33);
            this.rdo_HDBan.TabIndex = 8;
            this.rdo_HDBan.TabStop = true;
            this.rdo_HDBan.Text = "Hoá đơn bán";
            this.rdo_HDBan.UseVisualStyleBackColor = true;
            // 
            // rdo_HDNhap
            // 
            this.rdo_HDNhap.AutoSize = true;
            this.rdo_HDNhap.Checked = true;
            this.rdo_HDNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_HDNhap.Location = new System.Drawing.Point(490, 131);
            this.rdo_HDNhap.Name = "rdo_HDNhap";
            this.rdo_HDNhap.Size = new System.Drawing.Size(188, 33);
            this.rdo_HDNhap.TabIndex = 7;
            this.rdo_HDNhap.TabStop = true;
            this.rdo_HDNhap.Text = "Hoá đơn nhập";
            this.rdo_HDNhap.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(796, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đến ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Từ ngày";
            // 
            // Frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1743, 842);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_ThongKe";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.Frm_ThongKe_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_DSHoaDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView data_DSHoaDon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.RadioButton rdo_HDBan;
        private System.Windows.Forms.RadioButton rdo_HDNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxt_NgayKT;
        private System.Windows.Forms.MaskedTextBox mtxt_NgayBD;
    }
}