using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX
{
    class XepPhongChild
    {
        Database db;
        public XepPhongChild()
        {
            db = new Database();
        }

        public void Insert(string idSinhVien, string idPhong, string TienCoc, string NgayThue)
        {
            string sqlStr = "insert into ThuePhong(idSinhVien, idPhong, TienCoc, NgayThue) " +
                "values('" + idSinhVien + "','" + idPhong + "','" + TienCoc + "','" + NgayThue + "')";
            db.ThucThi(sqlStr);
        }

        public DataTable getAllSV()
        {
            string sqlStr = "select * from SinhVien where Chon='False'";
            DataTable dt = db.LayDL(sqlStr);
            return dt;
        }

        public DataTable getAllPhong()
        {
            string sqlStr = "select * from Phong where TrangThai='True' and SoCho < 4";
            DataTable dt = db.LayDL(sqlStr);
            return dt;
        }

        public void setTrue(string idSinhVien)
        {
            string sqlStr = "update SinhVien set Chon = 'True' where idSinhVien = '" + idSinhVien + "'";
            db.ThucThi(sqlStr);
        }
    }
}
