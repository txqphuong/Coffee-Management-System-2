using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Nhom11_QLQuanCafe.BUS
{
    class KhuyenMai
    {
        public DataTable loadThongTinKM()
        {
            return DAL.Util.FillData("ThongTinKhuyenMai");
        }

        public DataTable loadThongTinKM1()
        {
            return DAL.Util.FillData("ThongTinKhuyenMai1");
        }

        public DataTable loadThongTinSP()
        {
            return DAL.Util.FillData("allSP_DKM");
        }

        public DataTable loadThongTinMKM()
        {
            return DAL.Util.FillData("allMKM");
        }

         public DataTable loadThongTinSPKM()
        {
            return DAL.Util.FillData("DuocKM");
        }
        public void delKhuyenMai(string idKM)
        {
            string[] par = new string[1] { "@makm" };
            string[] value = new string[1] { idKM };
            DAL.Util.ExecuteNonQuery("XoaKM", par, value);
        }

       

        public void delSPKhuyenMai(string idKM)
        {
            string[] par = new string[1] { "@idKM" };
            string[] value = new string[1] { idKM };
            DAL.Util.ExecuteNonQuery("xoaSPKhuyenMai", par, value);
        }


        public void suaKhuyenMai(string idKM, string ten, string nd, string tile)
        {
            string[] par = new string[4] { "@makm", "@tensk", "@noidung", "@tile" };
            string[] value = new string[4] { idKM, ten, nd, tile };
            DAL.Util.ExecuteNonQuery("suaKM", par, value);
        }


        public void suaSPKhuyenMai(string id, string idkm, string tensp, string ngaybd, string ngaykt)
        {
            string[] par = new string[5] { "@idd", "@makm", "@tenspkm", "@ngaybd", "@ngaykt" };
            string[] value = new string[5] { id, idkm, tensp, ngaybd, ngaykt };
            DAL.Util.ExecuteNonQuery("suaSPKM", par, value);
        }



        public void themKhuyenMai(string ten, string nd, string tile)
        {
            string[] par = new string[3] { "@tensk", "@noidung", "@tile" };
            string[] value = new string[3] { ten, nd, tile };
            DAL.Util.ExecuteNonQuery("themKM", par, value);
        }

        public void themSPKhuyenMai(string idkm, string tensp, string ngaybd, string ngaykt)
        {
            string[] par = new string[4] {  "@makm", "@tenspkm", "@ngaybd", "@ngaykt" };
            string[] value = new string[4] {  idkm, tensp, ngaybd, ngaykt };
            DAL.Util.ExecuteNonQuery("themSPKM", par, value);
        }


        public DataTable loadKMMM(string idKM)
        {
            string[] par = new string[1] { "@idKM" };
            string[] value = new string[1] { idKM };

            return DAL.Util.FillData("loadSPKMMM", par, value);
        }
    }
}
