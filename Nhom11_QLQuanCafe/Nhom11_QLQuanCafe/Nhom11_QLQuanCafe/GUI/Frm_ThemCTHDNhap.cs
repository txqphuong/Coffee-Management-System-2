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
    public partial class Frm_ThemCTHDNhap : Form
    {

        string idHDN;

        public string IdHDN
        {
            get { return idHDN; }
            set { idHDN = value; }
        }
        public Frm_ThemCTHDNhap(string id)
        {
            InitializeComponent();
            idHDN = id;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                this.chitiethdnTableAdapter1.Insert(cbo_MaNL.Text, label6.Text, int.Parse(txt_SL.Text), double.Parse(txt_ThanhTien.Text));
                MessageBox.Show("Thêm chi tiết hóa đơn thành công");
            }
            catch
            {
                MessageBox.Show("Không thể thêm chi tiết hóa đơn");
            }
            finally
            {
                this.Close();
            }
        }

        private void Frm_ThemCTHDNhap_Load(object sender, EventArgs e)
        {
            label6.Text = idHDN;
            BUS.HoaDonNhap d = new BUS.HoaDonNhap();
            DataTable table = new DataTable();
            table = d.hienthiMaNL();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cbo_MaNL.Items.Add(table.Rows[i]["MANL"].ToString());
            }
        }
    }
}
