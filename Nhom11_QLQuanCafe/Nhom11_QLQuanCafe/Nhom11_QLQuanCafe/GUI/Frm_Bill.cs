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
    public partial class Frm_Bill : Form
    {
        string idHD;

        public string IdHD
        {
            get { return idHD; }
            set { idHD = value; }
        }

       

        public Frm_Bill(string id)
        {
            InitializeComponent();
            this.idHD = id;
        }



        private void Frm_Bill_Load(object sender, EventArgs e)
        {
            loadHD();
        }

       void loadHD()
        {
            BUS.HoaDon d = new BUS.HoaDon();
            DataTable table = new DataTable();
            table = d.loadBill(idHD);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                lb_Ban.Text= table.Rows[i]["TENBAN"].ToString();
                lb_SDT.Text = table.Rows[i]["SDTKH"].ToString();
                lb_Ten.Text = table.Rows[i]["TENKH"].ToString();
                lb_Tong.Text = table.Rows[i]["TONGTIEN"].ToString();

            }
        }

       private void button1_Click(object sender, EventArgs e)
       {
           BUS.HoaDon d = new BUS.HoaDon();
           d.doiTinhTrangTrong(lb_Ban.Text);
           d.DoiTTHD(idHD);
           MessageBox.Show("Cảm ơn quý khách!!");
           this.Close();
       }
    }
}
