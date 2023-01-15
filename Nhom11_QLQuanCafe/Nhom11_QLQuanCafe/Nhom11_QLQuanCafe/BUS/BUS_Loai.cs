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
     public class BUS_Loai
    {
         Util conn = new Util();
         public DataTable dtLoai = new DataTable();
         DataColumn[] key = new DataColumn[1];
         string sql = "";

         public DataTable layLoai()
         {
             sql = "select * from LOAI";
             dtLoai= conn.LayDuLieu(sql, "LOAI");
             key[0] = dtLoai.Columns["MALOAI"];
             dtLoai.PrimaryKey = key;
             return dtLoai;
         }

         public string chuanHoaChuoi(string tenLoai)
         {
            tenLoai = tenLoai.Trim();
            Regex khoangTrang = new Regex(@"\s\s+");
            tenLoai = khoangTrang.Replace(tenLoai, " ");
            return tenLoai;
         }

         public bool ktLoai( string tenLoai)
         {
             sql = string.Format("select COUNT(*) from LOAI where TENLOAI= '{0}'",tenLoai);
             return conn.checkForExiststence(sql);
         }

         public bool ktReferences(string ma)
         {
             sql = string.Format("select COUNT(*) from SANPHAM where MALOAI='{0}'", ma);
             return conn.checkForExiststence(sql);
         }

         public bool themLoai(string tenLoai)
         {
             tenLoai = chuanHoaChuoi(tenLoai);
             if( ktLoai(tenLoai))
                 return false;
             else
             {
                 sql = string.Format("insert into LOAI values(' ',N'{0}')",tenLoai);
                 conn.updateToDataBase(sql);
                 return true;
             }
         }

         public bool xoaLoai(string maLoai)
         {
            if(ktReferences(maLoai) == false)
            {
                sql = string.Format("delete LOAI where MALOAI='{0}'", maLoai);
                conn.updateToDataBase(sql);
                return true;
            }
            return false;
         }

         public bool suaLoai(string maLoai, string tenLoai)
         {
             tenLoai = chuanHoaChuoi(tenLoai);
             try
             {
                 sql = string.Format("update LOAI set TENLOAI ='{0}' where MALOAI='{1}'",tenLoai, maLoai);
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
