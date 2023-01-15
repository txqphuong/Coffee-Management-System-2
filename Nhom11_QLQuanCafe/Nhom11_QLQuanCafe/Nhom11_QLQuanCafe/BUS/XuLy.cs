using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using Nhom11_QLQuanCafe.DAL;

namespace Nhom11_QLQuanCafe.BUS
{
    class XuLy
    {
        Util con = new Util();
        DataTable dtHDBan, dtHDNhap;
        DataColumn[] keyHDBan = new DataColumn[1];
        DataColumn[] keyHDNhap = new DataColumn[1];

        #region Tải dữ liệu
        //Hóa đơn bán
        public DataTable taiDuLieuHDBan(string nbd, string nkt)
        {
            string sql = string.Format("set dateformat dmy select * from HOADON where NGAYBAN >='{0}' and NGAYBAN <= '{1}' ", nbd, nkt);
            dtHDBan = con.LayDuLieu(sql, "HOADON");
            keyHDBan[0] = dtHDBan.Columns["MAHD"];
            dtHDBan.PrimaryKey = keyHDBan;
            return dtHDBan;
        }
        //Hóa đơn nhập
        public DataTable taiDuLieuHDNhap(string nbd, string nkt)
        {
            string sql = string.Format("set dateformat dmy select * from HOADONNHAP where NGAYNHAP >='{0}' and NGAYNHAP <= '{1}'",nbd,nkt);
            dtHDNhap = con.LayDuLieu(sql, "HOADONNHAP");
            keyHDNhap[0] = dtHDNhap.Columns["MAHDNHAP"];
            dtHDNhap.PrimaryKey = keyHDNhap;
            return dtHDNhap;
        }
        #endregion

        public int kiemTraXacNhan(string ten, string matKhau)
        {
            con.openConnection();
            string sql = string.Format("select *  from TAIKHOAN where TENNGUOIDUNG = '{0}' and MATKHAU = '{1}'", ten, matKhau);
            SqlDataReader rd = con.getDataReader(sql);
            if (rd.Read())
            {
                //nếu đúng
                return 1;
            }
            rd.Close();
            con.closeConnection();
            //nếu sai
            return 0;
        }

        public string layChucVu(string maNV)
        {
            con.closeConnection();
            string cv = "";
            string sql = string.Format("select * from NHANVIEN where MANV= '{0}'", maNV);
            SqlDataReader rd = con.getDataReader(sql);
            if(rd.Read())
            {
                cv = rd["MACV"].ToString();
            }
            rd.Close();
            con.closeConnection();
            return cv;
        }

    }
}
