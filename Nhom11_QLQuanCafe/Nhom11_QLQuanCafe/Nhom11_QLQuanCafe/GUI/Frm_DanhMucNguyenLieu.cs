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
    public partial class Frm_DanhMucNguyenLieu : Form
    {
        public Frm_DanhMucNguyenLieu()
        {
            InitializeComponent();
        }

        private void Frm_DanhMucNguyenLieu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLQuanCafe.NGUYENLIEU' table. You can move, or remove it, as needed.
            this.nGUYENLIEUTableAdapter.Fill(this.qLQuanCafe.NGUYENLIEU);

        }

        private void loadDSNguyenLieu()
        {
            BUS.NguyenLieu nl = new BUS.NguyenLieu();
            dgv_NguyenLieu.DataSource = nl.hienThiDSNguyenLieu();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
                Frm_ThemNguyenLieu nl = new Frm_ThemNguyenLieu();
                nl.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa nguyên liệu này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (DialogResult.Yes == r)
                {
                    this.nGUYENLIEUTableAdapter.procXoaNguyenLieu(txt_MaNL.Text);
                    MessageBox.Show("Xóa nguyên liệu thành công");
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa nguyên liệu");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn chỉnh sửa nguyên liệu này?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (DialogResult.Yes == r)
                {
                    this.nGUYENLIEUTableAdapter.procCapNhatNguyenLieu(txt_TenNL.Text, int.Parse(txt_SL.Text), DateTime.Parse(txt_HSD.Text), double.Parse(txt_DonGia.Text), txt_MaNL.Text);
                    MessageBox.Show("Chỉnh sửa nguyên liệu thành công");
                }
            }
            catch
            {
                MessageBox.Show("Không thể chỉnh sửa nguyên liệu");
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

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.nGUYENLIEUTableAdapter.Fill(qLQuanCafe.NGUYENLIEU);
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            this.nGUYENLIEUTableAdapter.Fill(qLQuanCafe.NGUYENLIEU);
        }
    }
}
