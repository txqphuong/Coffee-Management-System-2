using Nhom11_QLQuanCafe.GUI;
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
    public partial class Frm_HoaDon : Form
    {
        public string maHD = "";
        public Frm_HoaDon()
        {
            InitializeComponent();
        }

        private void btn_taoHDMoi_Click(object sender, EventArgs e)
        {
            Frm_TaoHoaDon d = new Frm_TaoHoaDon();
            d.Show();
            loadThonTinCTHD();
            loadThongTinHD();
        }

        private void Frm_HoaDon_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            loadTenSP();
            loadThongTinHD();
            

        }

        void loadThongTinHD()
        {
            BUS.HoaDon k = new BUS.HoaDon();
            dgv_DsHD.DataSource = k.loadThongTinHD();
            dgv_DsHD.Columns[0].HeaderText = "Bàn";
            dgv_DsHD.Columns[1].HeaderText = "Tổng bill";
            dgv_DsHD.Columns[2].HeaderText = "Tình trạng";
            dgv_DsHD.Columns[3].HeaderText = "ID";
            dgv_DsHD.Columns[4].HeaderText = "Khách hàng";
            dgv_DsHD.Columns[5].HeaderText = "Ngày bán";
            
        }

        void loadTenSP()
        {
             BUS.KhuyenMai k = new BUS.KhuyenMai();
            DataTable table = new DataTable();
            table = k.loadThongTinSP();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string a = table.Rows[i]["TENSP"].ToString();
                cbo_TenSP.Items.Add(a);

            }
        }

        string ii = "";
        private void dgv_DsHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                label8.Visible = false;
                label8.Visible = false;
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_DsHD.Rows[e.RowIndex];
                string idHD = Convert.ToString(row.Cells["MAHD"].Value);
                string tt = Convert.ToString(row.Cells["TINHTRANG"].Value);
                if (tt == "Cũ")
                {
                    txt_SoLuong.Visible = false;
                    label3.Visible = false;
                    label2.Visible = false;
                    cbo_TenSP.Visible = false;
                    label4.Visible = false;
                    txt_DonGia.Visible = false;


                    label6.Visible = false;
                    label5.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    txt_ThanhTien.Visible = false;
                    txt_GiamGia.Visible = false;
                    brt_ThanhToan.Visible = false;
                    btn_Sua.Visible = false;
                    btn_Xoa.Visible = false;
                    btn_Them.Visible = false;
                    label9.Visible = true;


                }
                else
                {
                    txt_SoLuong.Visible = true;
                    label3.Visible = true;
                    label2.Visible = true;
                    cbo_TenSP.Visible = true;
                    label4.Visible = true;
                    txt_DonGia.Visible = true;

                    label6.Visible = true;
                    label5.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    txt_ThanhTien.Visible = true;
                    txt_GiamGia.Visible = true;
                    brt_ThanhToan.Visible = true;
                    btn_Sua.Visible = true;
                    btn_Xoa.Visible = true;
                    btn_Them.Visible = true;
                    label9.Visible = false;
                }
                BUS.HoaDon k = new BUS.HoaDon();
                lb_idHD.Text = Convert.ToString(row.Cells["MAHD"].Value);
                ii = idHD;
                loadThonTinCTHD();
            }
            catch
            {
                MessageBox.Show("Thao tác thất bại");
            }

          
        }

        void loadThonTinCTHD()
        {
            BUS.HoaDon k = new BUS.HoaDon();
            dgv_DsCTHD.DataSource = k.loadThongTinCTHD(ii);
            dgv_DsCTHD.Columns[0].HeaderText = "Sản phẩm";
            dgv_DsCTHD.Columns[1].HeaderText = "Đơn giá";
            dgv_DsCTHD.Columns[2].HeaderText = "Số lượng";
            dgv_DsCTHD.Columns[3].HeaderText = "Tổng tiền";
            dgv_DsCTHD.Columns[4].HeaderText = "Sale còn";
            
        }





        private void dgv_DsCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               

                label8.Visible = true;
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_DsCTHD.Rows[e.RowIndex];
                label6.Text = Convert.ToString(row.Cells["SL"].Value);
                txt_GiamGia.Text = Convert.ToString(row.Cells["GIAMGIA"].Value);
                txt_DonGia.Text = Convert.ToString(row.Cells["GIABAN"].Value);
                txt_ThanhTien.Text = Convert.ToString(row.Cells["TONGTIEN"].Value);
                cbo_TenSP.Text = Convert.ToString(row.Cells["TENSP"].Value);
            }
            catch
            {
                MessageBox.Show("Thao tác thất bại");
            }
            

           
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            BUS.HoaDon k = new BUS.HoaDon();
            k.delCTHD(lb_idHD.Text, cbo_TenSP.Text);
            MessageBox.Show("Xóa sản phẩm thành công");
            loadThonTinCTHD();
            loadThongTinHD();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                BUS.HoaDon k = new BUS.HoaDon();
                string a = txt_ThanhTien.Text;
                k.themCTHD(lb_idHD.Text, cbo_TenSP.Text, txt_SoLuong.Text, txt_GiamGia.Text, a);
                MessageBox.Show("Thêm sản phẩm thành công");
                loadThonTinCTHD();
                loadThongTinHD();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
           
           
           
            
        }

        private void cbo_TenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            BUS.HoaDon k = new BUS.HoaDon();
            DataTable table = new DataTable();
            table = k.loadGiaSP(cbo_TenSP.Text);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string a = table.Rows[i]["GIABAN"].ToString();
                txt_DonGia.Text = a+" VNĐ";

            }
    


        }


        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string[] strS = txt_DonGia.Text.Split(' ');
                string a = strS[0];
                txt_ThanhTien.Text = (int.Parse(a) * int.Parse(txt_SoLuong.Text)).ToString();

                BUS.HoaDon k = new BUS.HoaDon();
                DataTable table = new DataTable();
                table = k.loadThongTinGG(cbo_TenSP.Text, txt_ThanhTien.Text);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    string ab = table.Rows[i]["Sale"].ToString();

                    txt_GiamGia.Text = ab;

                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn số lượng");
            }

          
           
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                BUS.HoaDon k = new BUS.HoaDon();
                string a = txt_ThanhTien.Text;
                k.suaCTHD(lb_idHD.Text, cbo_TenSP.Text, txt_SoLuong.Text, txt_GiamGia.Text, a);
                MessageBox.Show("Sửa sản phẩm thành công");
                loadThonTinCTHD();
                loadThongTinHD();
            }
            catch
            {
                MessageBox.Show("Chọn bàn hoặc kiểm tra thông tin!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadThonTinCTHD();
            loadThongTinHD();
        }

        private void dgv_DsCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_DsHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void brt_ThanhToan_Click(object sender, EventArgs e)
        {
            GUI.Frm_Bill d = new GUI.Frm_Bill(lb_idHD.Text);
            d.Show();
            loadThonTinCTHD();
            loadThongTinHD();

        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            int vt = dgv_DsHD.CurrentCell.RowIndex;
            Frm_InHoaDon hd = new Frm_InHoaDon();
            hd.maHD = dgv_DsHD.Rows[vt].Cells["MAHD"].Value.ToString();
            hd.Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult rd = MessageBox.Show("Bạn muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (rd == DialogResult.Yes)
                this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            


        }

       




    }
}
