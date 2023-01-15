using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom11_QLQuanCafe.GUI;

namespace Nhom11_QLQuanCafe
{
    public partial class Frm_HoaDonNhap : Form
    {
        public string maHDNhap = "";
        public Frm_HoaDonNhap()
        {
            InitializeComponent();
        }

        private void Frm_HoaDonNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLQuanCafe.CHITIETHDN' table. You can move, or remove it, as needed.
            this.cHITIETHDNTableAdapter.Fill(this.qLQuanCafe.CHITIETHDN);
            // TODO: This line of code loads data into the 'qLQuanCafe.HOADONNHAP' table. You can move, or remove it, as needed.
            this.hOADONNHAPTableAdapter.Fill(this.qLQuanCafe.HOADONNHAP);
            txt_MaHD.Visible = false;
            label2.Visible = false;

        }

        private void loadDSHoaDonNhap()
        {
            BUS.HoaDonNhap hdn = new BUS.HoaDonNhap();
            dgv_HoaDonNhap.DataSource = hdn.hienThiDSHoaDonNhap();
        }

        private void btn_TaoCTHDNhap_Click(object sender, EventArgs e)
        {
            Frm_ThemCTHDNhap cthdn = new Frm_ThemCTHDNhap(txt_MaHD.Text);
            cthdn.Show();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            

            Frm_TaoHoaDonNhap hdn = new Frm_TaoHoaDonNhap();
            hdn.Show();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.hOADONNHAPTableAdapter.Fill(qLQuanCafe.HOADONNHAP);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.cHITIETHDNTableAdapter.Fill(qLQuanCafe.CHITIETHDN);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
           
        }

        private void dgv_HoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_ChiTietHDNhap.DataSource = this.cHITIETHDNTableAdapter.GetDataBy(txt_MaHD.Text);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn nhập này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (DialogResult.Yes == r)
                {
                    this.hOADONNHAPTableAdapter.procXoaHoaDonNhap(txt_MaHD.Text);
                    MessageBox.Show("Xóa hóa đơn nhập thành công");
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa hóa đơn nhập");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                this.hOADONNHAPTableAdapter.procCapNhatHoaDonNhap(txt_MaNCC.Text, txt_MaNV.Text, double.Parse(txt_TongTienNhap.Text), DateTime.Parse(txt_NgayNhap.Text), txt_GhiChu.Text, txt_MaHD.Text);
                MessageBox.Show("Cập nhật hóa đơn nhập thành công");
            }
            catch
            {
                MessageBox.Show("Không thể chỉnh sửa hóa đơn nhập");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc muốn Thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (DialogResult.Yes == r)
            {
                this.Close();
            }
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            this.hOADONNHAPTableAdapter.Fill(qLQuanCafe.HOADONNHAP);
            this.cHITIETHDNTableAdapter.Fill(qLQuanCafe.CHITIETHDN);
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            int vt = dgv_HoaDonNhap.CurrentCell.RowIndex;
            Frm_InHDNhap hdn = new Frm_InHDNhap();
            hdn.maHDNhap = txt_MaHD.Text;
            hdn.Show();
        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                this.cHITIETHDNBindingSource.EndEdit();
                this.cHITIETHDNTableAdapter.Update(qLQuanCafe.CHITIETHDN);
                MessageBox.Show("Lưu thành công");
            }
        }
    }
}
