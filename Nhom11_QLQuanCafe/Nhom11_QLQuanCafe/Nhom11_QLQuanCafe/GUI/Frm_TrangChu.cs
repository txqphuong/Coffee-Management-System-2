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
    public partial class Frm_TrangChu : Form
    {
        private int childFormNumber = 0;
        public string chucVu = "";
        public Frm_TrangChu()
        {
            InitializeComponent();
            //Frm_DangNhap dangNhap = new Frm_DangNhap();
            //dangNhap.ShowDialog();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void TrangChucs_Load(object sender, EventArgs e)
        {
            Frm_SanPhamTrangChu spTrangChu = new Frm_SanPhamTrangChu();
            spTrangChu.MdiParent = this;
            spTrangChu.Show();
            if (chucVu == "TN")
            {
                btn_NhanVien.Visible = false;
                btn_DoanhThu.Visible = false;
            }
        }

     
     

        private void btn_NhanVien_Click_1(object sender, EventArgs e)
        {
            Frm_NhanVien nv = new Frm_NhanVien();
            nv.MdiParent = this;
            nv.Show();
        }

        private void btn_DichVu_Click(object sender, EventArgs e)
        {
            Frm_HoaDon nl = new Frm_HoaDon();
            nl.MdiParent = this;
            nl.Show();
        }

        private void btn_NguyenLieu_Click_1(object sender, EventArgs e)
        {
            Frm_DanhMucNguyenLieu nl = new Frm_DanhMucNguyenLieu();
            nl.MdiParent = this;
            nl.Show();
        }

        private void btn_DoanhThu_Click_1(object sender, EventArgs e)
        {
            Frm_ThongKe tk = new Frm_ThongKe();
            tk.MdiParent = this;
            tk.Show();
        }

        private void btn_KhuyenMai_Click(object sender, EventArgs e)
        {
            Frm_KhuyenMai_SanPham tk = new Frm_KhuyenMai_SanPham();
            tk.MdiParent = this;
            tk.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_HoaDonNhap d = new Frm_HoaDonNhap();
            d.MdiParent = this;
            d.Show();
        }

        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            frm_NhaCC d = new frm_NhaCC();
            d.MdiParent = this;
            d.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mwenu_Click(object sender, EventArgs e)
        {
            frm_SanPham d = new frm_SanPham();
            d.MdiParent = this;
            d.Show();
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                this.Hide();
                Frm_DangNhap dangNhap = new Frm_DangNhap();
                dangNhap.ShowDialog();
            }
        }
    }
}
