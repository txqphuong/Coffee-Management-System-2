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
    public class BUS_SanPham
    {
        Util conn = new Util();
        DataTable dtSanPham = new DataTable();
        DataTable dtLoai = new DataTable();
        DataColumn[] key = new DataColumn[1];
        DataColumn[] keyLoai = new DataColumn[1];

        string sql = "";

        public DataTable laySanPham()
        {
            sql = "select * from SANPHAM";
            dtSanPham = conn.LayDuLieu(sql, "SANPHAM");
            key[0] = dtSanPham.Columns["MASP"];
            dtSanPham.PrimaryKey = key;
            return dtSanPham;
        }

        public DataTable layLoai()
        {
            sql = "select * from LOAI";
            dtLoai = conn.LayDuLieu(sql, "LOAI");
            keyLoai[0] = dtLoai.Columns["MALOAI"];
            dtLoai.PrimaryKey = keyLoai;
            return dtLoai;
        }

        public string chuanHoaChuoi(string tenLoai)
        {
            tenLoai = tenLoai.Trim();
            Regex khoangTrang = new Regex(@"\s\s+");
            tenLoai = khoangTrang.Replace(tenLoai, " ");
            return tenLoai;
        }

        public bool ktTen(string ten)
        {
            sql = string.Format("select COUNT(*) from SANPHAM where TENSP=N'{0}'", ten);
            return conn.checkForExiststence(sql);
        }

        public bool ktReferences(string ma)
        {
            sql = string.Format("select COUNT(*) from CHITIETHD where MASP='{0}'", ma);
            bool ktHD = conn.checkForExiststence(sql);
            sql = string.Format("select COUNT(*) from DUOCKHUYENMAI where MASP='{0}'", ma);
            bool ktKM = conn.checkForExiststence(sql);
            if (ktHD || ktKM)
                return true;
            return false;
        }

        public bool themSanPham(string ten, string loai, string sl, string dvt, string dg, string anh)
        {
            ten = chuanHoaChuoi(ten);
            if(ktTen(ten))
                return false;
            else
            {
                if (anh.Length == 0)
                    sql = string.Format("insert into SANPHAM values('','{0}',N'{1}', {2}, N'{3}',{4}, null)", loai, ten, sl, dvt, dg);
                else
                    sql = string.Format("insert into SANPHAM values('','{0}',N'{1}', {2}, N'{3}',{4},'{5}')", loai, ten, sl, dvt, dg, anh);

                conn.updateToDataBase(sql);
                conn.closeConnection();
                return true;
            }
        }

        public bool xoaSanPham(string maSP)
        {
            if(ktReferences(maSP) == false)
            {
                sql = string.Format("delete SANPHAM where MASP='{0}'", maSP);
                conn.updateToDataBase(sql);
                return true;
            }
            return false;
        }

        public bool suaSanPham(string maSP,string ten, string loai, string sl, string dvt, string dg, string anh )
        {
            ten = chuanHoaChuoi(ten);
           try
           {
               sql = string.Format(" update SANPHAM set TENSP = N'{0}', MALOAI = '{1}', SOLUONGCONLAI= {2}, DONVITINH = N'{3}', GIABAN ={4}, HINHANH='{5}' where MASP = '{6}'", ten, loai, sl, dvt, dg, anh, maSP);
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
