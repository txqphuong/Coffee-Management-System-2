using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom11_QLQuanCafe.BUS;

namespace Nhom11_QLQuanCafe
{
    public partial class Frm_ThongKe : Form
    {
        public Frm_ThongKe()
        {
            InitializeComponent();
        }

        #region Tải dữ liệu
        public void taiHDBan()
        {
            BUS.XuLy xl = new BUS.XuLy();
            data_DSHoaDon.DataSource = xl.taiDuLieuHDBan(mtxt_NgayBD.Text.Trim(),mtxt_NgayKT.Text.Trim());

            data_DSHoaDon.Columns["MaHD"].HeaderText = "Mã hóa đơn";
            data_DSHoaDon.Columns["MaBan"].HeaderText = "Mã bàn";
            data_DSHoaDon.Columns["MaKH"].HeaderText = "Mã khách hàng";
            data_DSHoaDon.Columns["MaNV"].HeaderText = "Mã nhân viên";
            data_DSHoaDon.Columns["NgayBan"].HeaderText = "Ngày bán";
            data_DSHoaDon.Columns["TongTien"].HeaderText = "Tổng tiền";

            data_DSHoaDon.Columns["MaHD"].Width = 130;
            data_DSHoaDon.Columns["MaNV"].Width = 130;
            data_DSHoaDon.Columns["MaKH"].Width = 150;

            data_DSHoaDon.ReadOnly = true;
            data_DSHoaDon.AllowUserToAddRows = false;
        }
        public void taiHDNhap()
        {
            BUS.XuLy xl = new BUS.XuLy();
            data_DSHoaDon.DataSource = xl.taiDuLieuHDNhap(mtxt_NgayBD.Text.Trim(),mtxt_NgayKT.Text.Trim());
            data_DSHoaDon.Columns["MAHDNHAP"].HeaderText = "Mã hóa đơn nhập";
            data_DSHoaDon.Columns["MANCC"].HeaderText = "Mã nhà cung cấp";
            data_DSHoaDon.Columns["MaNV"].HeaderText = "Mã nhân viên";
            data_DSHoaDon.Columns["TONGTIENNHAP"].HeaderText = "Tổng tiền nhập";
            data_DSHoaDon.Columns["NGAYNHAP"].HeaderText = "Ngày nhập";
            data_DSHoaDon.Columns["GHICHU"].HeaderText = "Ghi chú";

            data_DSHoaDon.Columns["MAHDNHAP"].Width = 150;
            data_DSHoaDon.Columns["MANCC"].Width = 150;
            data_DSHoaDon.Columns["MaNV"].Width = 150;
            data_DSHoaDon.Columns["TONGTIENNHAP"].Width =140;
            data_DSHoaDon.Columns["NGAYNHAP"].Width = 130;
            data_DSHoaDon.Columns["GHICHU"].Width = 150;

            data_DSHoaDon.ReadOnly = true;
            data_DSHoaDon.AllowUserToAddRows = false;
        }
        #endregion

        public void Frm_ThongKe_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            if (mtxt_NgayBD.Text.Trim().Length < 10)
            {
                MessageBox.Show("Ngày sai, vui lòng nhập lại ngày bắt đầu");
                return;
            }
            if (mtxt_NgayKT.Text.Trim().Length < 10)
            {
                MessageBox.Show("Ngày sai, vui lòng nhập lại ngày bắt đầu");
                return;
            }

            if (rdo_HDBan.Checked)
            {
                taiHDBan();
            }
            else
            {
                taiHDNhap();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
