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
    public partial class Frm_DangNhap : Form
    {
        BUS.XuLy xl = new BUS.XuLy();
        public string chucVu = "";
        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        #region Nút đóng
        private void btn_Dong_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát phần mềm?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                Application.Exit();
        }
        #endregion

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (txt_DangNhap.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                txt_DangNhap.Focus();
                return;
            }
            if (txt_MatKhau.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                txt_MatKhau.Focus();
                return;
            }
            if (xl.kiemTraXacNhan(txt_DangNhap.Text.Trim(), txt_MatKhau.Text.Trim()) == 1)
            {


                BUS.NhanVien d1 = new BUS.NhanVien();
                DataTable table = new DataTable();
                table = d1.ssNV(txt_DangNhap.Text);
                string a = table.Rows[0]["MANV"].ToString();
                chucVu = xl.layChucVu(a);
                BUS.sessionNV eee = new BUS.sessionNV(a);

                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                Frm_TrangChu d = new Frm_TrangChu();
                d.chucVu = chucVu;
                d.Show();


            }
            else
            {
                lbl_ThongBao.Text = "Bạn nhập sai tên đăng nhập hoặc mật khẩu";
                txt_DangNhap.Clear();
                txt_MatKhau.Clear();
            }
        }
    }
}
