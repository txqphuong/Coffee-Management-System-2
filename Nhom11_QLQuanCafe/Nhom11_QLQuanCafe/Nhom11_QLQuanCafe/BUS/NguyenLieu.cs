using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Nhom11_QLQuanCafe.BUS
{
    public class NguyenLieu
    {
        public DataTable hienThiDSNguyenLieu()
        {
            return DAL.Util.FillData("hienThiDSNguyenLieu");
        }
    }
}
