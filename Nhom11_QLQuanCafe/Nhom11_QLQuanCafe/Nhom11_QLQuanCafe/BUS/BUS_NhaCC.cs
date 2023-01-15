using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Nhom11_QLQuanCafe.DAL;
using System.Text.RegularExpressions;

namespace Nhom11_QLQuanCafe.BUS
{
    public class BUS_NhaCC
    {
        Util conn = new Util();
        DataTable dtNhaCC = new DataTable();
        DataColumn[] key = new DataColumn[1];
        string sql = "";
        
        public DataTable layNhaCC()
        {
            sql = "select * from NHACUNGCAP";
            dtNhaCC = conn.LayDuLieu(sql, "NHACUNGCAP");
            key[0] = dtNhaCC.Columns["MANCC"];
            dtNhaCC.PrimaryKey = key;
            return dtNhaCC;
        }

        public string chuanHoaChuoi(string tenNCC)
        {
            tenNCC = tenNCC.Trim();
            Regex khoangTrang = new Regex(@"\s\s+");
            tenNCC = khoangTrang.Replace(tenNCC, " ");
            return tenNCC;
        }

        public bool ktNCC(string tenNCC)
        {
            sql = string.Format("select COUNT(*) from NHACUNGCAP where MANCC='{0}'", tenNCC);
            return conn.checkForExiststence(sql);
        }

        public bool ktReferences(string maNCC)
        {
            sql = string.Format("select COUNT(*) from HOADONNHAP where MANCC = '{0}'", maNCC);
            return conn.checkForExiststence(sql);
        }

        public bool themNCC(string ten, string sdt, string dc)
        {
            ten = chuanHoaChuoi(ten);
            dc = chuanHoaChuoi(dc);
            if (ktNCC(ten))
                return false;
            else
            {
                sql = string.Format("insert into NHACUNGCAP values('', N'{0}','{1}',N'{2}')", ten, sdt, dc);
                conn.updateToDataBase(sql);
                return true;
            }
        }

        public bool xoaNCC(string ma)
        {
            if (ktReferences(ma) == false)
            {
                sql = string.Format("delete NHACUNGCAP where MANCC='{0}'", ma);
                conn.updateToDataBase(sql);
                return true;
            }
            return false;
        }

        public bool suaNCC(string ma, string ten, string sdt, string dc)
        {
            ten = chuanHoaChuoi(ten);
            dc = chuanHoaChuoi(dc);
            sdt = chuanHoaChuoi(sdt);
            try
            {
                sql = string.Format("update NHACUNGCAP set TENNCC = N'{0}', SDTNCC = '{1}', DIACHINCC= N'{2}' where MANCC = '{3}'", ten, sdt, dc, ma);
                conn.updateToDataBase(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
