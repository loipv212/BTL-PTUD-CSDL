using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX
{
    class Nuoc
    {
        Database db;
        public Nuoc()
        {
            db = new Database();
        }

        public DataTable getNuoc()
        {
            string sqlStr = "select id, TenPhong, ChiSoCu, ChiSoMoi, TuNgay, DenNgay, ThanhTien," +
                "case when Nuoc.TrangThai = 0 then N'Chưa thanh toán' " +
                "when Nuoc.TrangThai = 1 then N'Đã thanh toán' end as TrangThai " +
                "from Nuoc join Phong on Nuoc.idPhong = Phong.idPhong";
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
            string sqlStr = "insert into Nuoc(idPhong, ChiSoCu, ChiSoMoi, TuNgay, DenNgay, TrangThai) " +
                "values('" + idPhong + "','" + ChiSoCu + "','" + ChiSoMoi + "','" + TuNgay + "','" + DenNgay + "','" + TrangThai + "')";
            db.ThucThi(sqlStr);
        }

        public void Update(string id, string idPhong, string ChiSoCu, string ChiSoMoi, string TuNgay, string DenNgay, int TrangThai)
        {
            string sqlStr = "update Nuoc set idPhong='" + idPhong + "',ChiSoCu='" + ChiSoCu + "',ChiSoMoi='" + ChiSoMoi + "',TuNgay='" + TuNgay + "',DenNgay='" + DenNgay + "',TrangThai='" + TrangThai + "' where id='" + id + "'";
            db.ThucThi(sqlStr);
        }

        public void Delete(string id)
        {
            string sqlStr = "delete from Nuoc where id='" + id + "'";
            db.ThucThi(sqlStr);
        }
//asfqwfqwfqfqwfqwfqwasdawd
    }
}
