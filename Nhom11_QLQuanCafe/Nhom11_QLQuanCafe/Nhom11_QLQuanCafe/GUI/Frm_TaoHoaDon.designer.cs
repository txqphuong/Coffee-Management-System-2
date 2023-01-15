namespace Nhom11_QLQuanCafe
{
    partial class Frm_TaoHoaDon
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
            this.txt_MaKH = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_Ban = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb654 = new System.Windows.Forms.Label();
            this.ln5 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.ln445 = new System.Windows.Forms.Label();
            this.txt_KH = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNgaylap = new System.Windows.Forms.MaskedTextBox();
            this.lb_SNV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_gt = new System.Windows.Forms.ComboBox();
            this.lb_ban = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.AutoSize = true;
            this.txt_MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKH.Location = new System.Drawing.Point(56, 71);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(85, 29);
            this.txt_MaKH.TabIndex = 33;
            this.txt_MaKH.Text = "Mã NV";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.cb_Ban);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(114, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 497);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bàn";
            // 
            // cb_Ban
            // 
            this.cb_Ban.FormattingEnabled = true;
            this.cb_Ban.Items.AddRange(new object[] {
            "Tất cả",
            "Trống",
            "Hoạt động"});
            this.cb_Ban.Location = new System.Drawing.Point(384, 435);
            this.cb_Ban.Name = "cb_Ban";
            this.cb_Ban.Size = new System.Drawing.Size(247, 37);
            this.cb_Ban.TabIndex = 5;
            this.cb_Ban.Text = "Tất cả";
            this.cb_Ban.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
       
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hoạt động";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(172, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 20);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trống";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(32, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 20);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(16, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 385);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(570, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "TẠO HOÁ ĐƠN MỚI";
            // 
            // lb654
            // 
            this.lb654.AutoSize = true;
            this.lb654.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb654.Location = new System.Drawing.Point(56, 243);
            this.lb654.Name = "lb654";
            this.lb654.Size = new System.Drawing.Size(154, 29);
            this.lb654.TabIndex = 29;
            this.lb654.Text = "Số điện thoại";
            // 
            // ln5
            // 
            this.ln5.AutoSize = true;
            this.ln5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln5.Location = new System.Drawing.Point(56, 132);
            this.ln5.Name = "ln5";
            this.ln5.Size = new System.Drawing.Size(184, 29);
            this.ln5.TabIndex = 30;
            this.ln5.Text = "Tên khách hàng";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(258, 240);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(260, 35);
            this.txt_sdt.TabIndex = 26;
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(380, 402);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(153, 63);
            this.btn_OK.TabIndex = 36;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Visible = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // ln445
            // 
            this.ln445.AutoSize = true;
            this.ln445.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln445.Location = new System.Drawing.Point(56, 188);
            this.ln445.Name = "ln445";
            this.ln445.Size = new System.Drawing.Size(108, 29);
            this.ln445.TabIndex = 31;
            this.ln445.Text = "Ngày lập";
            // 
            // txt_KH
            // 
            this.txt_KH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KH.Location = new System.Drawing.Point(256, 123);
            this.txt_KH.Name = "txt_KH";
            this.txt_KH.Size = new System.Drawing.Size(274, 35);
            this.txt_KH.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1526, 105);
            this.panel1.TabIndex = 35;
            // 
            // txtNgaylap
            // 
            this.txtNgaylap.Location = new System.Drawing.Point(260, 185);
            this.txtNgaylap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNgaylap.Mask = "00/00/0000";
            this.txtNgaylap.Name = "txtNgaylap";
            this.txtNgaylap.Size = new System.Drawing.Size(271, 33);
            this.txtNgaylap.TabIndex = 38;
            this.txtNgaylap.ValidatingType = typeof(System.DateTime);
            // 
            // lb_SNV
            // 
            this.lb_SNV.AutoSize = true;
            this.lb_SNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SNV.Location = new System.Drawing.Point(254, 69);
            this.lb_SNV.Name = "lb_SNV";
            this.lb_SNV.Size = new System.Drawing.Size(19, 29);
            this.lb_SNV.TabIndex = 39;
            this.lb_SNV.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 40;
            this.label3.Text = "Giới tính";
            // 
            // txt_gt
            // 
            this.txt_gt.FormattingEnabled = true;
            this.txt_gt.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.txt_gt.Location = new System.Drawing.Point(256, 305);
            this.txt_gt.Name = "txt_gt";
            this.txt_gt.Size = new System.Drawing.Size(121, 37);
            this.txt_gt.TabIndex = 41;
            // 
            // lb_ban
            // 
            this.lb_ban.AutoSize = true;
            this.lb_ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ban.Location = new System.Drawing.Point(436, 69);
            this.lb_ban.Name = "lb_ban";
            this.lb_ban.Size = new System.Drawing.Size(55, 29);
            this.lb_ban.TabIndex = 42;
            this.lb_ban.Text = "Bàn";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.lb_ban);
            this.groupBox1.Controls.Add(this.txt_gt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_SNV);
            this.groupBox1.Controls.Add(this.txtNgaylap);
            this.groupBox1.Controls.Add(this.txt_MaKH);
            this.groupBox1.Controls.Add(this.lb654);
            this.groupBox1.Controls.Add(this.ln5);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.btn_OK);
            this.groupBox1.Controls.Add(this.ln445);
            this.groupBox1.Controls.Add(this.txt_KH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(838, 163);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(566, 495);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // Frm_TaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1526, 742);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_TaoHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo hóa đơn";
            this.Load += new System.EventHandler(this.Frm_TaoHoaDon_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txt_MaKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb654;
        private System.Windows.Forms.Label ln5;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label ln445;
        private System.Windows.Forms.TextBox txt_KH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtNgaylap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_SNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txt_gt;
        private System.Windows.Forms.Label lb_ban;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_Ban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}