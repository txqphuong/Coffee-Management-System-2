using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using Nhom11_QLQuanCafe.BUS;


namespace Nhom11_QLQuanCafe
{
    public partial class frm_SanPham : Form
    {
        BUS_SanPham busSanPham = new BUS_SanPham();
        public frm_SanPham()
        {
            InitializeComponent();
        }

        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        public void loadDuLieu()
        {
            dgv_DsSanPham.DataSource = busSanPham.laySanPham();
            cbo_LoaiSP.DataSource = busSanPham.layLoai();
            cbo_LoaiSP.DisplayMember = "TENLOAI";
            cbo_LoaiSP.ValueMember = "MALOAI";
        }


        private void dgv_DsSanPham_SelectionChanged(object sender, EventArgs e)
        {
            int vt = dgv_DsSanPham.CurrentCell.RowIndex;
            txt_TenSP.Text = dgv_DsSanPham.Rows[vt].Cells["TENSP"].Value.ToString();
            txt_Anh.Text = dgv_DsSanPham.Rows[vt].Cells["HINHANH"].Value.ToString();
            txt_DonGia.Text = dgv_DsSanPham.Rows[vt].Cells["GIABAN"].Value.ToString();
            txt_DVT.Text = dgv_DsSanPham.Rows[vt].Cells["DONVITINH"].Value.ToString();
            txt_SL.Text = dgv_DsSanPham.Rows[vt].Cells["SOLUONGCONLAI"].Value.ToString();
            cbo_LoaiSP.SelectedValue = dgv_DsSanPham.Rows[vt].Cells["MALOAI"].Value;

            //load hình sản phẩm
            if (txt_Anh.Text == "")
            {
                ptb_AnhSP.Image = null;
            }
            else if (txt_Anh.Text != "")
            {
                ptb_AnhSP.Image = Image.FromFile("..//..//Images//" + txt_Anh.Text);
                
                ptb_AnhSP.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
              DialogResult rd = MessageBox.Show("Xác nhận thêm", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
              if (rd == DialogResult.Yes)
              {
                  if (cbo_LoaiSP.Text == "" || txt_TenSP.Text == "" || txt_SL.Text == "" || txt_DVT.Text == "" || txt_DonGia.Text == "")
                  {
                      MessageBox.Show("Hãy nhập đầy đủ thông tin trước khi thêm");
                      return;
                  }

                  try
                  {
                      if (busSanPham.themSanPham(txt_TenSP.Text, cbo_LoaiSP.SelectedValue.ToString(), txt_SL.Text, txt_DVT.Text, txt_DonGia.Text, txt_Anh.Text.Trim()))
                      {
                          MessageBox.Show("Thêm thành công");
                          loadDuLieu();
                      }
                      else
                          MessageBox.Show("Sản phẩm này đã tồn tại");
                  }
                  catch
                  {
                      MessageBox.Show("thêm thất bại");
                  }
              }          
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            string duongDan = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string a = @"\";
                duongDan = dialog.FileName.ToString();
                ptb_AnhSP.ImageLocation = duongDan;
                string[] tenHinh = duongDan.Split(Convert.ToChar(a));
                txt_Anh.Text = tenHinh[tenHinh.Length - 1];
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
             DialogResult rd = MessageBox.Show("Xác nhận xoá", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
             if (rd == DialogResult.Yes)
             {
                 if (txt_TenSP.Text.Trim() != "")
                 {
                     int vt = dgv_DsSanPham.CurrentCell.RowIndex;
                     try
                     {
                         bool kt = busSanPham.xoaSanPham(dgv_DsSanPham.Rows[vt].Cells[0].Value.ToString());
                         if (kt)
                         {
                             MessageBox.Show("Xoá thành công");
                             loadDuLieu();
                         }
                         else
                             MessageBox.Show("Sản phẩm này không thể xoá");
                     }
                    catch
                     {
                         MessageBox.Show("Xoá thất bại");
                     }
                 }
                 else
                 {
                     MessageBox.Show("Hãy chọn sản phẩm cần xoá");
                     return;
                 }  
             }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
             DialogResult rd = MessageBox.Show("Xác nhận sửa thông tin", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
             if (rd == DialogResult.Yes)
             {
                   }
            if (txt_TenSP.Text.Trim() != "")
            {
                int vt = dgv_DsSanPham.CurrentCell.RowIndex;
                try
                {
                    bool kt = busSanPham.suaSanPham(dgv_DsSanPham.Rows[vt].Cells[0].Value.ToString(), txt_TenSP.Text, cbo_LoaiSP.SelectedValue.ToString(), txt_SL.Text, txt_DVT.Text, txt_DonGia.Text, txt_Anh.Text);
                    if (kt)
                    {
                        MessageBox.Show("sửa thành công");
                        loadDuLieu();
                    }
                    else
                        MessageBox.Show("Sản phẩm này không tồn tại");
                }
                catch
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn sản phẩm cần sửa thông tin");
                return;
            }  
        }

        private void btn_Loai_Click(object sender, EventArgs e)
        {
            frm_Loai n = new frm_Loai();
            n.ShowDialog();
            loadDuLieu();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult rd = MessageBox.Show("Bạn muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (rd == DialogResult.Yes)
                this.Close();
        }

        private void txt_SL_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                this.errorProvider1.SetError(ctr, "chi được nhập số");
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_Anh.Clear();
            txt_DonGia.Clear();
            txt_DVT.Clear();
            txt_SL.Clear();
            txt_TenSP.Clear();
            cbo_LoaiSP.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
