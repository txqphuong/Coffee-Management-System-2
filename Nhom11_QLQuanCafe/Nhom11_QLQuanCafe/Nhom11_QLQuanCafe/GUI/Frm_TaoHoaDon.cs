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
    public partial class Frm_TaoHoaDon : Form
    {
        public Frm_TaoHoaDon()
        {
            InitializeComponent();
        }


        void loadBan()
        {
            BUS.HoaDon b = new BUS.HoaDon();
            panel2.Controls.Clear();
            DataTable table = new DataTable();
            table = b.loadThongTinBan();
            int vttrai = 10;
            int vttren = 10;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Button buttonMoi = new Button(); 

                buttonMoi.Left = vttrai; 
                buttonMoi.Top = vttren;
                string tenn = table.Rows[i]["TENBAN"].ToString();
                buttonMoi.Name =  tenn;
               
                string ss = buttonMoi.Name;

                buttonMoi.Size = new System.Drawing.Size(100, 40);
                string trangthai = table.Rows[i]["TINHTRANG"].ToString();
                if (trangthai == "Trống")
                {
                    buttonMoi.BackColor = System.Drawing.Color.Yellow;
                }
                else
                {
                    buttonMoi.BackColor = System.Drawing.Color.Green;
                }
                buttonMoi.Text = tenn;
                if ((i + 1) % 4 != 0)
                {
                    vttrai = vttrai + 100; 
                    
                }
                else if ((i + 1) % 4 == 0)
                {
                    vttrai = 10;
                    vttren += 60;
                }

                panel2.Controls.Add(buttonMoi);
                buttonMoi.Click += new EventHandler(buttonMoi_Click);
            }
        }


        private void buttonMoi_Click(object sender, EventArgs e)
        {
            lb_ban.Text = ((Button)sender).Text;
            BUS.HoaDon n = new BUS.HoaDon();
            DataTable table = new DataTable();
            table = n.loadThongTin1Ban(lb_ban.Text);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string tinhtrang = table.Rows[i]["TINHTRANG"].ToString();
                if(tinhtrang=="Hoạt động")
                {
                    btn_OK.Visible = false;
                    MessageBox.Show("Bàn này đang hoạt động!!");
                }
                else
                {
                    btn_OK.Visible = true;
                }

            }
            
        }

        private void Frm_TaoHoaDon_Load(object sender, EventArgs e)
        {
           
            loadBan();
            lb_SNV.Text = BUS.sessionNV.Manv;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                BUS.HoaDon n = new BUS.HoaDon();
                n.doiTinhTrang(lb_ban.Text);

                //lấy id
                DataTable table = new DataTable();
                table = n.loadThongTin1Ban(lb_ban.Text);
                string idban = table.Rows[0]["MABAN"].ToString();
                //
                n.themHD(idban, txt_KH.Text, txt_gt.Text, txt_sdt.Text, lb_SNV.Text, txtNgaylap.Text);
                MessageBox.Show("Tạo thành công");
                loadBan();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại thông tin nhé!!");
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_Ban.Text =="Tất cả")
            {
                loadBan();
            }
            else if(cb_Ban.Text=="Trống")
            {
                BUS.HoaDon b = new BUS.HoaDon();
                panel2.Controls.Clear();
                DataTable table = new DataTable();
                table = b.loadThongTinBan();
                int vttrai = 10;
                int vttren = 10;
                int flag = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    string ttr = table.Rows[i]["TINHTRANG"].ToString();
                    if (ttr == "Trống")
                    {
                        Button buttonMoi = new Button();

                        buttonMoi.Left = vttrai;
                        buttonMoi.Top = vttren;
                        string tenn = table.Rows[i]["TENBAN"].ToString();
                        buttonMoi.Name = tenn;

                        string ss = buttonMoi.Name;

                        buttonMoi.Size = new System.Drawing.Size(100, 40);
                        string trangthai = table.Rows[i]["TINHTRANG"].ToString();
                        if (trangthai == "Trống")
                        {
                            buttonMoi.BackColor = System.Drawing.Color.Yellow;
                        }
                        else
                        {
                            buttonMoi.BackColor = System.Drawing.Color.Green;
                        }
                        buttonMoi.Text = tenn;
                        if ((flag + 1) % 4 != 0)
                        {
                            vttrai = vttrai + 100;

                        }
                        else if ((flag + 1) % 4 == 0)
                        {
                            vttrai = 10;
                            vttren += 60;
                        }
                        panel2.Controls.Add(buttonMoi);


                        buttonMoi.Click += new EventHandler(buttonMoi_Click);
                        flag++;
                    }
                }
            }
            else if (cb_Ban.Text == "Hoạt động")
            {
                BUS.HoaDon b = new BUS.HoaDon();
                panel2.Controls.Clear();
                DataTable table = new DataTable();
                table = b.loadThongTinBan();
                int vttrai = 10;
                int vttren = 10;
                int flag = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    string ttr = table.Rows[i]["TINHTRANG"].ToString();
                    if (ttr == "Hoạt động")
                    {
                        Button buttonMoi = new Button();

                        buttonMoi.Left = vttrai;
                        buttonMoi.Top = vttren;
                        string tenn = table.Rows[i]["TENBAN"].ToString();
                        buttonMoi.Name = tenn;

                        string ss = buttonMoi.Name;

                        buttonMoi.Size = new System.Drawing.Size(100, 40);
                        string trangthai = table.Rows[i]["TINHTRANG"].ToString();
                        if (trangthai == "Trống")
                        {
                            buttonMoi.BackColor = System.Drawing.Color.Yellow;
                        }
                        else
                        {
                            buttonMoi.BackColor = System.Drawing.Color.Green;
                        }
                        buttonMoi.Text = tenn;
                        if ((flag + 1) % 4 != 0)
                        {
                            vttrai = vttrai + 100;

                        }
                        else if ((flag + 1) % 4 == 0)
                        {
                            vttrai = 10;
                            vttren += 60;
                        }
                        panel2.Controls.Add(buttonMoi);


                        buttonMoi.Click += new EventHandler(buttonMoi_Click);
                        flag++;
                    }
                }
            }
        }


    }
}
