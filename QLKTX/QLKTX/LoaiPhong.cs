using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX
{
    class LoaiPhong
    {
        Database db;
        public LoaiPhong()
        {
            db = new Database();
        }
        public DataTable getAllLoaiPhong()
        {
            string sqlStr = "select idLoaiPhong, GiaPhong, TenLoaiPhong from LoaiPhong";
            DataTable dt = db.LayDL(sqlStr);
            return dt;
        }

        /*public DataTable getTenLoaiPhong() 
        {
            string sqlStr = "select TenLoaiPhong from LoaiPhong";
            DataTable dt = db.LayDL(sqlStr);
            return dt;
        }*/

        public void Insert(string idLoaiPhong, string GiaPhong, string TenLoaiPhong)
        {
            string sqlStr = "insert into LoaiPhong(idLoaiPhong, GiaPhong, TenLoaiPhong) " +
                "values('" + idLoaiPhong + "','" + GiaPhong + "',N'" + TenLoaiPhong + "')";
            db.ThucThi(sqlStr);
        }

        public void Update(string idLoaiPhong, string GiaPhong, string TenLoaiPhong)
        {
            string sqlStr = "update LoaiPhong set TenLoaiPhong=N'" + TenLoaiPhong + "',GiaPhong='" + GiaPhong + "' where idLoaiPhong='" + idLoaiPhong + "'";
            db.ThucThi(sqlStr);
        }

        public void Delete(string idLoaiPhong)
        {
            string sqlStr = "delete from LoaiPhong where idLoaiPhong='" + idLoaiPhong + "'";
            db.ThucThi(sqlStr);
        }
    }
}
