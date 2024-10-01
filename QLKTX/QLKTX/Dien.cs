using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX
{
    class Dien
    {
        Database db;
        public Dien()
        {
            db = new Database();
        }

        public DataTable getDien()
        {
            string sqlStr = "select id as 'ID', TenPhong as 'Phòng', ChiSoCu as 'Chỉ số cũ', ChiSoMoi as 'Chỉ số mới', TuNgay as 'Từ ngày', DenNgay as 'Đến ngày', ThanhTien as 'Thành Tiền'," +
                "case when Dien.TrangThai = 0 then N'Chưa thanh toán' " +
                "when Dien.TrangThai = 1 then N'Đã thanh toán' end as 'Thanh toán' " +
                "from Dien join Phong on Dien.idPhong = Phong.idPhong " + 
                "order by 'Thanh toán' asc";
            DataTable dt = db.LayDL(sqlStr);
            return dt;
        }

        public DataTable getPhong()
        {
            string sqlStr = "select * from Phong where TrangThai='True' and SoCho != 0";
            DataTable dt = db.LayDL(sqlStr);
            return dt;
        }

        public void Insert(string idPhong, string ChiSoCu, string ChiSoMoi, string TuNgay, string DenNgay, int TrangThai)
        {
            string sqlStr = "insert into Dien(idPhong, ChiSoCu, ChiSoMoi, TuNgay, DenNgay, TrangThai) " +
                "values('" + idPhong + "','" + ChiSoCu + "','" + ChiSoMoi + "','" + TuNgay + "','" + DenNgay + "','" + TrangThai + "')";
            db.ThucThi(sqlStr);
        }

        public void Update(string id, string idPhong, string ChiSoCu, string ChiSoMoi, string TuNgay, string DenNgay, int TrangThai)
        {
            string sqlStr = "update Dien set idPhong='" + idPhong + "',ChiSoCu='" + ChiSoCu + "',ChiSoMoi='" + ChiSoMoi + "',TuNgay='" + TuNgay + "',DenNgay='" + DenNgay + "',TrangThai='" + TrangThai + "' where id='" + id + "'";
            db.ThucThi(sqlStr);
        }

        public void Delete(string id)
        {
            string sqlStr = "delete from Dien where id='" + id + "'";
            db.ThucThi(sqlStr);
        }
    }
}
