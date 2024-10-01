using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX
{
    class XepPhong
    {
        Database db;
        public XepPhong()
        {
            db = new Database();
        }
        public DataTable getAllSV()
        {
            string sqlStr = "select idSinhVien, Ten, GioiTinh, NgaySinh, CCCD, DienThoai," +
                " QueQuan, Truong from SinhVien where Chon='False'";
            DataTable dt = db.LayDL(sqlStr);
            return dt;
        }

        public DataTable getXepPhong() 
        {
            string sqlStr = "select ThuePhong.id, SinhVien.idSinhVien, SinhVien.Ten, SinhVien.GioiTinh, Phong.TenPhong, ThuePhong.TienCoc " +
                "from ThuePhong join SinhVien on ThuePhong.idSinhVien = SinhVien.idSinhVien " +
                "join Phong on ThuePhong.idPhong = Phong.idPhong";
            DataTable dt = db.LayDL(sqlStr);
            return dt;
        }

        public void Xuly(string phong)
        {
            string sqlStr = "insert into ThuePhong (idSinhVien, idPhong) " +
                "select idSinhVien, idPhong from SinhVien, Phong " +
                "where SinhVien.Chon = 'True' and Phong.idPhong = '" + phong + "'";
            db.ThucThi(sqlStr);
        }

        public void Delete(string idThue, string idSV)
        {
            string sqlStr1 = "update SinhVien set Chon = 'False' where idSinhVien = '" + idSV + "'";
            string sqlStr2 = "delete from ThuePhong where id='" + idThue + "'";

            db.ThucThi(sqlStr1);
            db.ThucThi(sqlStr2);
        }

        
    }
}
