using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Nhom11_QLQuanCafe.BUS
{
    public class HoaDonNhap
    {
        public DataTable hienThiDSHoaDonNhap()
        {
            return DAL.Util.FillData("hienThiDSHoaDonNhap");
        }

        public DataTable hienthiNCC()
        {
            return DAL.Util.FillData("MaNCCC");
        }

        public DataTable hienthiMaNV()
        {
            return DAL.Util.FillData("MaNV");
        }

        public DataTable hienthiMaNL()
        {
            return DAL.Util.FillData("MaNL");
        }
    }
}
