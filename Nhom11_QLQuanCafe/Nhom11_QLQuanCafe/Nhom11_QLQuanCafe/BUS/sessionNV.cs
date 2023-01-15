using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11_QLQuanCafe.BUS
{
    class sessionNV
    {
        static string manv;

        public static string Manv
        {
            get { return sessionNV.manv; }
            set { sessionNV.manv = value; }
        }

        public sessionNV(string name)
        {
            Manv = name;
        }


         

        
    }
}
