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
    public partial class Frm_KhuyenMai : Form
    {
        public Frm_KhuyenMai()
        {
            InitializeComponent();
        }

        private void Frm_KhuyenMai_Load(object sender, EventArgs e)
        {
            loadKhuyenMai();
            panel1.Visible = true;
        }

        void loadKhuyenMai()
        {
            BUS.KhuyenMai k = new BUS.KhuyenMai();
            dtgvKhuyenMai.DataSource = k.loadThongTinKM();

        }

        private void dtgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgvKhuyenMai.Rows[e.RowIndex];
            lbMaKM.Text = Convert.ToString(row.Cells["MAKM"].Value);
            txt_PhanTram.Text = Convert.ToString(row.Cells["TILEKM"].Value);
            txt_SuKien.Text = Convert.ToString(row.Cells["TENSUKIEN"].Value);
            txt_ND.Text = Convert.ToString(row.Cells["NOIDUNG"].Value);
            //panel1.Visible = true;
           // btn_Them.Visible = false;

        }

     
      
        private void btn_Them_Click(object sender, EventArgs e)
        {
            BUS.KhuyenMai x = new BUS.KhuyenMai();
            x.themKhuyenMai(txt_SuKien.Text, txt_ND.Text, txt_PhanTram.Text);
            MessageBox.Show("Thêm khuyến mãi thành công");
            loadKhuyenMai();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
           // panel1.Visible = false;
           // btn_Them.Visible = true;
            txt_ND.Text = " ";
            txt_PhanTram.Text = " ";
            txt_SuKien.Text = " ";
            loadKhuyenMai();
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            BUS.KhuyenMai x = new BUS.KhuyenMai();
            x.delKhuyenMai(lbMaKM.Text);
            MessageBox.Show("Xóa khuyến mãi thành công");
            loadKhuyenMai();
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            BUS.KhuyenMai x = new BUS.KhuyenMai();
            x.suaKhuyenMai(lbMaKM.Text, txt_SuKien.Text, txt_ND.Text, txt_PhanTram.Text);
            MessageBox.Show("Sửa khuyến mãi thành công");
            loadKhuyenMai();
        }

        private void btn_Thoát_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc muốn Thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (DialogResult.Yes == r)
            {
                this.Close();
            }
        }

      
    }
}
