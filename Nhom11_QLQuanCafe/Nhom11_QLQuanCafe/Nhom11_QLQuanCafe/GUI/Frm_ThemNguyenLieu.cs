using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11_QLQuanCafe.GUI
{
    public partial class Frm_ThemNguyenLieu : Form
    {
        public Frm_ThemNguyenLieu()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                //if (string.Compare(txt_HanSD.Text, DateTime.Now.ToString()) < 0)
                //{
                //    MessageBox.Show("Hạn sử dụng của nguyên liệu phải lớn hơn ngày hiện tại");
                //}
                //else
                //{
                    this.nguyenlieuTableAdapter1.Insert(txt_MaNguyenLieu.Text, txt_TenNguyenLieu.Text, int.Parse(txt_SLConLai.Text), DateTime.Parse(txt_HanSD.Text), double.Parse(txt_DonGia.Text));
                    MessageBox.Show("Thêm nguyên liệu thành công");
                //}
            }
            catch
            {
                MessageBox.Show("Không thể thêm nguyên liệu");
            }
            finally
            {
                this.Close();
            }
        }
    }
}
