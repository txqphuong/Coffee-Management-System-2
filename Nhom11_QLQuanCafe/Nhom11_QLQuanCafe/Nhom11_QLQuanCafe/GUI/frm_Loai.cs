using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Nhom11_QLQuanCafe.BUS;

namespace Nhom11_QLQuanCafe
{
    public partial class frm_Loai : Form
    {
        BUS_Loai busLoai = new BUS_Loai();
        DataTable dtLoai = new DataTable();
        public frm_Loai()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        public void loadDuLieu()
        {
            dgv_DsLoai.DataSource = busLoai.layLoai();
        }

        private void dgv_DsLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = new DataGridViewRow();
            //row = dgv_DsLoai.Rows[e.RowIndex];
            //txt_MaLoai.Text = row.Cells[0].Value.ToString();
            //txt_TenLoai.Text = row.Cells[1].Value.ToString();
        }

        private void dgv_DsLoai_SelectionChanged(object sender, EventArgs e)
        {
            int vt = dgv_DsLoai.CurrentCell.RowIndex;
            txt_TenLoai.Text = dgv_DsLoai.Rows[vt].Cells[1].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
             DialogResult rd = MessageBox.Show("Xác nhận thêm", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
             if (rd == DialogResult.Yes)
             {
                 try
                 {
                     if(txt_TenLoai.Text.Trim() =="")
                     {
                         MessageBox.Show("Hãy nhập đủ thông tin");
                         return;
                     }
                     bool kt = busLoai.themLoai(txt_TenLoai.Text);
                     if (kt)
                     {
                         MessageBox.Show("Thêm Thành công");
                         loadDuLieu();
                     }
                     else
                         MessageBox.Show("Loại này đã tồn tại");
                 }
                 catch
                 {
                     MessageBox.Show("Thêm thất bại");
                 }
             }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
             DialogResult rd = MessageBox.Show("Xác nhận xoá", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
             if (rd == DialogResult.Yes)
             {
                 if (txt_TenLoai.Text.Trim() != "")
                 {
                     int vt = dgv_DsLoai.CurrentCell.RowIndex;
                     try
                     {
                         bool kt = busLoai.xoaLoai(dgv_DsLoai.Rows[vt].Cells[0].Value.ToString());
                         if (kt)
                         {
                             MessageBox.Show("Xoá thành công");
                             loadDuLieu();
                         }
                         else
                             MessageBox.Show("Loại này không thể xoá");
                     }
                     catch
                     {
                         MessageBox.Show("Xoá thất bại");
                     }
                 }
                 else
                 {
                     MessageBox.Show("Hãy chọn loại trước khi xoá");
                     return;
                 }
             }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
             DialogResult rd = MessageBox.Show("Xác nhận sửa thông tin", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
             if (rd == DialogResult.Yes)
             {
                 if (txt_TenLoai.Text.Trim() != "")
                 {
                     int vt = dgv_DsLoai.CurrentCell.RowIndex;
                     try
                     {
                         bool kt = busLoai.suaLoai(dgv_DsLoai.Rows[vt].Cells[0].Value.ToString(), txt_TenLoai.Text);
                         if (kt)
                         {
                             MessageBox.Show("Sửa thành công");
                             loadDuLieu();
                         }
                         else
                             MessageBox.Show("Loại này không tồn tại");
                     }
                     catch
                     {
                         MessageBox.Show("Sửa thất bại");
                     }
                 }
                 else
                 {
                     MessageBox.Show("Tên Loại không được để trống");
                     return;
                 }
             }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_TenLoai.Clear();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult rd = MessageBox.Show("Bạn muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (rd == DialogResult.Yes)
                this.Close();
        }
    }
}
