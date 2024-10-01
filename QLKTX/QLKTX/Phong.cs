using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX
{
    class Phong
    {
        Database db;
        public Phong()
        {
            db = new Database();
        }
        public DataTable getAllPhong()
        {
            string sqlStr = "select idPhong, TenPhong, SoCho, case " +
                "when TrangThai = 1 then N'Hoạt động' " +
                "when TrangThai = 0 then N'Không khả dụng' end as TrangThai, LoaiPhong.TenLoaiPhong " +
                "from Phong join LoaiPhong " +
                "on Phong.idLoaiPhong = LoaiPhong.idLoaiPhong";
            DataTable dt = db.LayDL(sqlStr);
            return dt;
        }

        /*public DataTable getPhong()
        {
            string sqlStr = "select * from Phong where TrangThai='True'";
            DataTable dt = db.LayDL(sqlStr);
            return dt;
        }*/

        public DataTable getLoaiPhong()
        {
            string sqlStr = "select * from LoaiPhong";
            DataTable dt = db.LayDL(sqlStr);
            return dt;
        }

        public DataTable getThuePhong(string idPhong)
        {
            string sqlStr = "select SinhVien.Ten, SinhVien.CCCD, SinhVien.QueQuan " +
                "from ThuePhong join SinhVien on ThuePhong.idSinhVien = SinhVien.idSinhVien " +
                "join Phong on ThuePhong.idPhong = Phong.idPhong where Phong.idPhong = '" + idPhong +"'";
            DataTable dt = db.LayDL(sqlStr);
            return dt;
        }

        public void Insert(string idPhong, string TenPhong, string SoCho, int TrangThai, int idLoaiPhong)
        {
            string sqlStr = "insert into Phong(idPhong, TenPhong, SoCho, TrangThai, idLoaiPhong) " +
                "values('" + idPhong + "',N'" + TenPhong + "','" + SoCho + "','" + TrangThai + "','" + idLoaiPhong + "')";
            db.ThucThi(sqlStr);
        }

        public void Update(string idPhong, string TenPhong, string SoCho, int TrangThai, int idLoaiPhong)
        {
            string sqlStr = "update Phong set TenPhong=N'" + TenPhong + "',SoCho='" + SoCho + "',TrangThai='" + TrangThai + "',idLoaiPhong='" + idLoaiPhong + "' where idPhong='" + idPhong + "'";
            db.ThucThi(sqlStr);
        }

        public void Delete(string idPhong)
        {
            string sqlStr = "delete from Phong where idPhong='" + idPhong + "'";
            db.ThucThi(sqlStr);
        }
    }
}
