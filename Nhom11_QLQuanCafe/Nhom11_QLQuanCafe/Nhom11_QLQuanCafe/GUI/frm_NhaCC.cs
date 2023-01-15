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
    public partial class frm_NhaCC : Form
    {
        BUS_NhaCC busNCC = new BUS_NhaCC();
        public frm_NhaCC()
        {
            InitializeComponent();
        }
        private void frm_NhaCC_Load(object sender, EventArgs e)
        {
            loadDuLieu();
            
            
        }
        public void loadDuLieu()
        {
            dgv_NhaCC.DataSource = busNCC.layNhaCC();
        }

        private void dgv_NhaCC_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int vt = dgv_NhaCC.CurrentCell.RowIndex;
                txt_TenNhaCC.Text = dgv_NhaCC.Rows[vt].Cells["TENNCC"].Value.ToString();
                txt_DiaChi.Text = dgv_NhaCC.Rows[vt].Cells["DIACHINCC"].Value.ToString();
                txt_SDT.Text = dgv_NhaCC.Rows[vt].Cells["SDTNCC"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Thao tác thất bại");
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
              DialogResult rd = MessageBox.Show("Xác nhận thêm", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
              if (rd == DialogResult.Yes)
              {
                  if (txt_TenNhaCC.Text == "" || txt_SDT.Text == "" || txt_DiaChi.Text == "")
                  {
                      MessageBox.Show("Hãy nhập đầy đủ thông tin");
                      return;
                  }
                  try
                  {
                      bool kt = busNCC.themNCC(txt_TenNhaCC.Text, txt_SDT.Text, txt_DiaChi.Text);
                      if (kt)
                      {
                          MessageBox.Show("Thêm Thành công");
                          loadDuLieu();
                      }
                      else
                          MessageBox.Show("Nhà cung cấp này đã tồn tại");
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
                if (txt_TenNhaCC.Text.Trim() != "")
                {
                    int vt = dgv_NhaCC.CurrentCell.RowIndex;
                    try
                    {
                        bool kt = busNCC.xoaNCC(dgv_NhaCC.Rows[vt].Cells[0].Value.ToString());
                        if (kt)
                        {
                            MessageBox.Show("Xoá thành công");
                            loadDuLieu();
                        }
                        else
                            MessageBox.Show("Nhà cung cấp này không thể xoá");
                    }
                    catch
                    {
                        MessageBox.Show("Xoá thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn nhà cung cấp để xoá");
                    return;
                }  
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult rd = MessageBox.Show("Xác nhận sửa thông tin", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rd == DialogResult.Yes)
            {
                if (txt_TenNhaCC.Text.Trim() != "")
                {
                    int vt = dgv_NhaCC.CurrentCell.RowIndex;
                    try
                    {
                        bool kt = busNCC.suaNCC(dgv_NhaCC.Rows[vt].Cells[0].Value.ToString(), txt_TenNhaCC.Text, txt_SDT.Text, txt_DiaChi.Text);
                        if (kt)
                        {
                            MessageBox.Show("sửa thành công");
                            loadDuLieu();
                        }
                        else
                            MessageBox.Show("Nhà cung cấp này không tồn tại");
                    }
                    catch
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn Nhà cung cấp cần sửa thông tin");
                    return;
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_DiaChi.Clear();
            txt_SDT.Clear();
            txt_TenNhaCC.Clear();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult rd = MessageBox.Show("Bạn muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (rd == DialogResult.Yes)
                this.Close();
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                this.errorProvider1.SetError(ctr, "chi được nhập số");
            }
            else this.errorProvider1.Clear();
        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
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
