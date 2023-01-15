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
    public partial class Frm_NhanVien : Form
    {
        public Frm_NhanVien()
        {
            InitializeComponent();
        }

        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            loadThongTinNV(); loadThongTinCV();
            loadCV();
            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnThem.Visible = true;
            btnClear.Visible = true;
        }

        void loadCV()
        {
            BUS.NhanVien n = new BUS.NhanVien();
            DataTable table = new DataTable();
            table = n.ThongTinCV();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string a = table.Rows[i]["TENCV"].ToString();
                txtTenCV.Items.Add(a);
               
            }

        }


        void loadThongTinNV()
        {
            BUS.NhanVien n = new BUS.NhanVien();
            dtgvNhanVien.DataSource = n.loadThongTinNV();
        }


        void loadThongTinCV()
        {
            BUS.NhanVien n = new BUS.NhanVien();
            dtgvChucVu.DataSource = n.loadThongTinCV();
        }

        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                panel1.Visible = true;
                btnThem.Visible = false;
                DataGridViewRow row = new DataGridViewRow();
                row = dtgvNhanVien.Rows[e.RowIndex];
                txtIDChucVu.Text = Convert.ToString(row.Cells["MACV"].Value);
                txtTenNV.Text = Convert.ToString(row.Cells["TENNV"].Value);
                txtGioiTinh.Text = Convert.ToString(row.Cells["GIOITINH"].Value);
                txtNgaySinh.Text = Convert.ToString(row.Cells["NGAYSINH"].Value);
                txtIDNhanVien.Text = Convert.ToString(row.Cells["MANV"].Value);
                txtSDT.Text = Convert.ToString(row.Cells["SDT"].Value);
                string tencv = loadTenCV(txtIDChucVu.Text);
                txtTenCV.Text = tencv;
                dtgvNhanVien.Columns["TENNV"].Width = 150;
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn lại");
            }
        }


        string loadTenCV (string idCV)
        {
            string a = "";
            BUS.NhanVien n = new BUS.NhanVien();
            DataTable table = new DataTable();
            table = n.loadTenCV(idCV);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                a = table.Rows[i]["TENCV"].ToString();
            }
            return a;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //btnSua.Visible = false;
           // btnXoa.Visible = false;
            //btnThem.Visible = true;
            //btnClear.Visible = false;

            txtGioiTinh.Text = "";
            txtNgaySinh.Text = "";
            txtIDNhanVien.Text = "";
            txtSDT.Text = "";
            txtTenNV.Text = "";

            panel1.Visible = false;
            btnThem.Visible = true;
            loadThongTinNV(); loadThongTinCV();
            loadCV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                BUS.NhanVien x = new BUS.NhanVien();
                x.delNhanVien(txtIDNhanVien.Text);
                MessageBox.Show("Xóa nhân viên thành công");
                loadThongTinNV();
            }
            catch
            {
                MessageBox.Show("Xóa nhân viên không thành công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                BUS.NhanVien x = new BUS.NhanVien();
                x.suaNhanVien(txtIDNhanVien.Text,txtIDChucVu.Text,txtTenNV.Text,txtGioiTinh.Text,txtSDT.Text,txtNgaySinh.Text);
                MessageBox.Show("Sửa nhân viên thành công");
                loadThongTinNV();
            }
            catch
            {
                MessageBox.Show("Sửa nhân viên không thành công");
            }
        }

        private void txtTenCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            BUS.NhanVien s = new BUS.NhanVien();
            DataTable table = new DataTable();
            table = s.loadTenCV1(txtTenCV.Text);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                txtIDChucVu.Text = table.Rows[i]["MACV"].ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
                BUS.NhanVien x = new BUS.NhanVien();
                x.themNhanVien(txtIDChucVu.Text, txtTenNV.Text, txtGioiTinh.Text,txtNgaySinh.Text,txtSDT.Text);
                MessageBox.Show("Thêm nhân viên thành công");
                loadThongTinNV();
           
        }

        private void dtgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgvChucVu.Rows[e.RowIndex];
            string aaa = Convert.ToString(row.Cells["MACV"].Value);
            BUS.NhanVien d = new BUS.NhanVien();
            dtgvNhanVien.DataSource = d.loadCNV(aaa);
        }

       
    }
}
