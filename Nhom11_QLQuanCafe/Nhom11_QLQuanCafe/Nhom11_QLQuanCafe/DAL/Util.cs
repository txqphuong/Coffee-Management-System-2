using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Nhom11_QLQuanCafe.DAL
{
    public class Util
    {
        private SqlConnection connect;
        private string strConnect, strServerName, strDatabaseName, DSet;

        public string StrDatabaseName
        {
            get { return strDatabaseName; }
            set { strDatabaseName = value; }
        }

        public string StrServerName
        {
            get { return strServerName; }
            set { strServerName = value; }
        }

        public string StrConnect
        {
            get { return strConnect; }
            set { strConnect = value; }
        }
       

        public Util()
        {
            StrServerName = @"MSI\SQLEXPRESS";
            StrDatabaseName = "QL_QUANCAFE";
            StrConnect = @"Data Source=" + StrServerName + ";Initial Catalog=" + StrDatabaseName + ";Integrated Security=True";
            //StrConnect = @"Data Source=A102PC35;Initial Catalog=QLSinhVien;Integrated Security=True";

            connect = new SqlConnection(StrConnect);
            
        }

        static string Dn;
        static string Pass;

        public static string Dn1
        {
            get { return Dn; }
            set { Dn = value; }
        }
        public static string Pass1
        {
            get { return Pass; }
            set { Pass = value; }
        }

        public Util(string d, string pass)
        {
            Dn = d; Pass = pass;
        }


        public static void ExecuteNonQuery(string store, string[] paramater, string[] values)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=QL_QUANCAFE;Integrated Security=True");
            conn.Open();


            var SqlCom = new SqlCommand();
            SqlCom.CommandText = store;
            SqlCom.Connection = conn;
            SqlCom.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < paramater.Length; i++)
            {
                SqlCom.Parameters.AddWithValue(paramater[i], values[i]);
            }
            SqlCom.ExecuteNonQuery();
            conn.Close();
        }
        public static bool ExecuteReader(string store, string[] paramater, string[] values)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=QL_QUANCAFE;Integrated Security=True");
            conn.Open();
            var SqlCom = new SqlCommand();
            SqlCom.CommandText = store;
            SqlCom.Connection = conn;
            SqlCom.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < paramater.Length; i++)
            {
                SqlCom.Parameters.AddWithValue(paramater[i], values[i]);
            }
            SqlDataReader dr = SqlCom.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }
        public static DataTable FillData(string store, string[] paramater, string[] values)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=QL_QUANCAFE;Integrated Security=True");
            conn.Open();
            var SqlCom = new SqlCommand();
            var tb = new DataTable();
            SqlCom.CommandText = store;
            SqlCom.Connection = conn;
            SqlCom.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < paramater.Length; i++)
            {
                SqlCom.Parameters.AddWithValue(paramater[i], values[i]);
            }
            SqlDataAdapter dap = new SqlDataAdapter(SqlCom);
            dap.Fill(tb);
            conn.Close();
            return tb;
        }


        public static DataTable FillData(string store)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=QL_QUANCAFE;Integrated Security=True");
            conn.Open();
            var SqlCom = new SqlCommand();
            var tb = new DataTable();
            SqlCom.CommandText = store;
            SqlCom.Connection = conn;
            SqlCom.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dap = new SqlDataAdapter(SqlCom);
            dap.Fill(tb);
            conn.Close();
            return tb;
        }


        public string chuoiKN(string serverName, string databaseName)
        {
            string con = @"Data Source=" + strServerName + ";Initial Catalog=" + strDatabaseName + ";Integrated Security=True";
            return con;

        }
        public void openConnection()
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
        }

        public void closeConnection()
        {
            if (connect.State == ConnectionState.Open)
                connect.Close();
        }
        public void disposeConnection()
        {
            if (connect.State == ConnectionState.Open)
                connect.Close();
            connect.Dispose();
        }

        public void updateToDataBase(string strSQL)
        {//update database: thêm, xóa, sửa
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandText = strSQL;
            // SqlCommand cmd = new SqlCommand(strSQL, Connect);

            cmd.ExecuteNonQuery();
            closeConnection();
        }

        public int getCount(string strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(strSQL, connect);

            int dem = (int)cmd.ExecuteScalar();
            closeConnection();
            return dem;
        }

        public SqlDataReader getDataReader(string strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(strSQL, connect);
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }

   

        public bool checkForExiststence(string strSQL)
        {
            return getCount(strSQL) > 0 ? true : false;
        }

        public DataTable LayDuLieu(string sql, string tablename)
        {
            openConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeConnection();
            return dt;
        }

        public void updateToDatabase(string sql, DataTable tablename)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            SqlCommandBuilder cbm = new SqlCommandBuilder(da);
            da.Update(tablename);

        }
    }
}
