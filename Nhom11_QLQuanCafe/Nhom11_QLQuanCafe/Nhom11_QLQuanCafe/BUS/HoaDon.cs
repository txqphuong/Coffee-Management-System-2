using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Nhom11_QLQuanCafe.BUS
{
    class HoaDon
    {
        public DataTable loadThongTinHD()
        {
            return DAL.Util.FillData("ThongTinHD");
        }


        public DataTable loadThongTinBan()
        {
            return DAL.Util.FillData("loadB");
        }

        public DataTable loadThongTin1Ban(string tenban)
        {
            string[] par = new string[1] { "@tenb" };
            string[] value = new string[1] { tenban };

            return DAL.Util.FillData("loadBan", par, value);
        }

        public DataTable doiTinhTrang(string tenban)
        {
            string[] par = new string[1] { "@tenb" };
            string[] value = new string[1] { tenban };

            return DAL.Util.FillData("tinhtrangban", par, value);
        }

        public DataTable doiTinhTrangTrong(string tenban)
        {
            string[] par = new string[1] { "@tenb" };
            string[] value = new string[1] { tenban };

            return DAL.Util.FillData("tinhtrangbanTrong", par, value);
        }

        public DataTable loadGiaSP( string tensp)
        {
            string[] par = new string[1] { "@tensp" };
            string[] value = new string[1] { tensp };

            return DAL.Util.FillData("DonGiaSP", par, value);
        }

        public DataTable loadThongTinCTHD(string idHD)
        {
            string[] par = new string[1] { "@maHD" };
            string[] value = new string[1] { idHD };

            return DAL.Util.FillData("ThongTinCTHD", par, value);
        }



        public DataTable loadBill(string idHD)
        {
            string[] par = new string[1] { "@maHD" };
            string[] value = new string[1] { idHD };

            return DAL.Util.FillData("TongTienHD", par, value);
        }

        public DataTable loadThongTinGG(string Tensp, string tong)
        {
            string[] par = new string[2] { "@TenSP", "@TongTien" };
            string[] value = new string[2] { Tensp, tong };

            return DAL.Util.FillData("aCTHD", par, value);
        }

        public void delCTHD(string idHD, string tenSP)
        {
            string[] par = new string[2] { "@maHD", "@tensp" };
            string[] value = new string[2] { idHD, tenSP };
            DAL.Util.ExecuteNonQuery("XoaCTHD", par, value);
        }

        public void themCTHD(string idHD, string tenSP, string sl,string giamg,string sum)
        {
            string[] par = new string[5] { "@maHD", "@tensp", "@sl", "@giam", "@tong" };
            string[] value = new string[5] { idHD, tenSP, sl, giamg, sum };
            DAL.Util.ExecuteNonQuery("ThemCTHD", par, value);
        }


        public void DoiTTHD(string idHD)
        {
            string[] par = new string[1] { "@idhd" };
            string[] value = new string[1] { idHD };
            DAL.Util.ExecuteNonQuery("tinhtrangHD", par, value);
        }

        public void themKH(string tenkh, string gt, string sdt)
        {
            string[] par = new string[3] { "@tenkh", "@phai", "@sdt" };
            string[] value = new string[3] { tenkh, gt, sdt };
            DAL.Util.ExecuteNonQuery("themKH", par, value);
        }

        public void suaCTHD(string idHD, string tenSP, string sl, string giamg, string sum)
        {
            string[] par = new string[5] { "@maHD", "@tensp", "@sl", "@giam", "@tong" };
            string[] value = new string[5] { idHD, tenSP, sl, giamg, sum };
            DAL.Util.ExecuteNonQuery("SuaCTHD", par, value);
        }


        public void themHD(string mab,string tenkh, string phai, string sdt, string manv, string ngay)
        {
            string[] par = new string[6] { "@mab", "@tenkh", "@phai", "@sdt", "@manv", "@ngay" };
            string[] value = new string[6] { mab, tenkh, phai, sdt, manv, ngay };
            DAL.Util.ExecuteNonQuery("themHD", par, value);
        }


    }
}
