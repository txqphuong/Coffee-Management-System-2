using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11_QLQuanCafe
{
    public partial class Frm_TaoHoaDonNhap : Form
    {
        public Frm_TaoHoaDonNhap()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                //if (string.Compare(txt_NgayNhap.Text, DateTime.Now.ToString()) < 0)
                //{
                //    MessageBox.Show("Ngày nhập của hóa đơn nhập phải lớn hơn ngày hiện tại");
                //}
                //else
                //{
                    this.hoadonnhapTableAdapter1.Insert(txt_MaHDN.Text, cbo_MaNCC.Text, cbo_MaNV.Text, double.Parse(txt_TongTien.Text), DateTime.Parse(txt_NgayNhap.Text), txt_GhiChu.Text);
                    MessageBox.Show("Thêm hóa đơn nhập thành công");
                //}
            }
            catch
            {
                MessageBox.Show("Không thể thêm hóa đơn nhập");
            }
            finally
            {
                this.Close();
            }
        }

        private void Frm_TaoHoaDonNhap_Load(object sender, EventArgs e)
        {
            BUS.HoaDonNhap d = new BUS.HoaDonNhap();
            DataTable table = new DataTable();
            table = d.hienthiNCC();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cbo_MaNCC.Items.Add(table.Rows[i]["MANCC"].ToString());
            }
            table = d.hienthiMaNV();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cbo_MaNV.Items.Add(table.Rows[i]["MANV"].ToString());
            }
        }


    }
}
