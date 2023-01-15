using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Nhom11_QLQuanCafe.BUS
{
    class NhanVien
    {
        public DataTable loadThongTinNV()
        {
            return DAL.Util.FillData("ThonTinNV");
        }

       

        public DataTable loadThongTinCV()
        {
            return DAL.Util.FillData("ThonTinCV");
        }


        public DataTable ThongTinCV()
        {
            return DAL.Util.FillData("CongViec");
        }


        public DataTable loadTenCV(string idCV)
        {
            string[] par = new string[1] { "@macv" };
            string[] value = new string[1] { idCV };

            return DAL.Util.FillData("ThongTinTenCV", par, value);
        }


        public DataTable loadCNV(string idCV)
        {
            string[] par = new string[1] { "@idcv" };
            string[] value = new string[1] { idCV };

            return DAL.Util.FillData("loadCNV", par, value);
        }

        public DataTable ssNV(string tentk)
        {
            string[] par = new string[1] { "@ten" };
            string[] value = new string[1] { tentk };

            return DAL.Util.FillData("sesssion", par, value);
        }

        public DataTable loadTenCV1(string tenCV)
        {
            string[] par = new string[1] { "@tencv" };
            string[] value = new string[1] { tenCV };

            return DAL.Util.FillData("ThongTinTenCV1", par, value);
        }


        public void delNhanVien(string idNV)
        {
            string[] par = new string[1] { "@manv" };
            string[] value = new string[1] { idNV };

            DAL.Util.ExecuteNonQuery("XoaNV", par, value);
        }


        public void suaNhanVien(string manv, string macv, string tennv, string gioitinh, string sdt, string ngaysinh)
        {
            string[] par = new string[6] { "@manv" , "@macv" ,"@tennv" , "@gioitinh" , "@ngaysinh" , "@sdt" };
            string[] value = new string[6] { manv, macv, tennv, gioitinh, ngaysinh, sdt };

            DAL.Util.ExecuteNonQuery("SuaNV", par, value);
        }

        public void themNhanVien(string macv, string tennv, string gioitinh, string ngaysinh,string sdt )
        {
            string a = ngaysinh;
            string[] par = new string[5] { "@macv", "@tennv", "@gioitinh", "@ngaysinh", "@sdt" };
            string[] value = new string[5] {macv, tennv, gioitinh, ngaysinh, sdt };

            DAL.Util.ExecuteNonQuery("themNV", par, value);
        }
    }
}
