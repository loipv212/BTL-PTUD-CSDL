using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX
{
    class Database
    {
        public string connectionstring = "Data Source=ADMIN;Initial Catalog=QLKyTucXa;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        public Database()
        {
            conn = new SqlConnection(connectionstring);
        }
        //Ham lay du lieu
        public DataTable LayDL(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, conn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        //Ham thuc thi cau lenh them sua xoa
        public void ThucThi(string sqlStr)
        {
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        
        
        
        
        
        
        
        
        //Ham hien thi ket qua tim kiem
        public DataTable ParticularRows(string sqlStr)
        {
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
            conn.Close();
        }
    }
}
