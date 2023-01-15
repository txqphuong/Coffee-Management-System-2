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
    public partial class Frm_KhuyenMai_SanPham : Form
    {
        public Frm_KhuyenMai_SanPham()
        {
            InitializeComponent();
        }

        private void Frm_KhuyenMai_SanPham_Load(object sender, EventArgs e)
        {
            loadThongTinKM(); loadThongTinSPKM(); loadSP_CBB(); loadThongTinIDKM();
            WindowState = FormWindowState.Maximized;
            
        }

        void loadSP_CBB()
        {
            BUS.KhuyenMai k = new BUS.KhuyenMai();
            DataTable table = new DataTable();
            table = k.loadThongTinSP();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string a = table.Rows[i]["TENSP"].ToString();
                txt_TenSP.Items.Add(a);

            }
        }

        void loadThongTinIDKM()
        {
            BUS.KhuyenMai k = new BUS.KhuyenMai();
            DataTable table = new DataTable();
            table = k.loadThongTinMKM();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string a = table.Rows[i]["MAKM"].ToString();
                txt_MaKM.Items.Add(a);

            }
        }

        void loadThongTinKM()
        {
            BUS.KhuyenMai k = new BUS.KhuyenMai();
            dtgvKhuyenMai.DataSource = k.loadThongTinKM1();
        }

        void loadThongTinSPKM()
        {
            BUS.KhuyenMai k = new BUS.KhuyenMai();
            dtgvDuocKM.DataSource = k.loadThongTinSPKM();
        }

        private void btn_TaoKM_Click(object sender, EventArgs e)
        {
            Frm_KhuyenMai f = new Frm_KhuyenMai();
            f.Show();

        }

       
        private void dtgvDuocKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Sua.Visible = true;
            btn_Xoa.Visible = true;
            btn_Clear.Visible = true;
            btn_Them.Visible = false;
            DataGridViewRow row = new DataGridViewRow();
            row = dtgvDuocKM.Rows[e.RowIndex];
            lb_ID.Text = Convert.ToString(row.Cells["ID"].Value);
            txt_NgayKT.Text=Convert.ToString(row.Cells["NGAYKT"].Value);
            txt_NgayBD.Text=Convert.ToString(row.Cells["NGAYBD"].Value);
            txt_TenSP.Text = Convert.ToString(row.Cells["TENSP"].Value);
            txt_MaKM.Text = Convert.ToString(row.Cells["MAKM"].Value);

        }

       
       
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            btn_Sua.Visible = false;
            btn_Xoa.Visible = false;
            btn_Clear.Visible = false;
            btn_Them.Visible = true;

            txt_MaKM.Text = "";
            txt_NgayBD.Text = "";
            txt_NgayKT.Text = "";
            txt_TenSP.Text = "";
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                BUS.KhuyenMai x = new BUS.KhuyenMai();
                x.delSPKhuyenMai(lb_ID.Text);
                MessageBox.Show("Xóa sản phẩm thành công");
                loadThongTinSPKM();
            }
            catch
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            try
            {
                BUS.KhuyenMai x = new BUS.KhuyenMai();
                x.suaSPKhuyenMai(lb_ID.Text, txt_MaKM.Text, txt_TenSP.Text, txt_NgayBD.Text, txt_NgayKT.Text);
                MessageBox.Show("Sửa sản phẩm thành công");
                loadThongTinSPKM();
            }
            catch
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            try
            {
                BUS.KhuyenMai x = new BUS.KhuyenMai();
                x.themSPKhuyenMai(txt_MaKM.Text, txt_TenSP.Text, txt_NgayBD.Text, txt_NgayKT.Text);
                MessageBox.Show("Thêm khuyến mãi thành công");
                loadThongTinSPKM();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void dtgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgvKhuyenMai.Rows[e.RowIndex];
            string idKm = Convert.ToString(row.Cells["MAKM"].Value);
            BUS.KhuyenMai aa = new BUS.KhuyenMai();
            dtgvDuocKM.DataSource = aa.loadKMMM(idKm);


        }

        private void dtgvDuocKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

      
    }
}
