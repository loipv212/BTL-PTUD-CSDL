using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX
{
    class SinhVien
    {
        Database db;
        public SinhVien()
        {
            db = new Database();
        }

        public DataTable getAllSV()
        {
            string sqlStr = "select idSinhVien, Ten, GioiTinh, NgaySinh, CCCD, DienThoai, QueQuan, Truong from SinhVien";
            DataTable dt = db.LayDL(sqlStr);
            return dt;
        }

        public void Insert(string idSinhVien, string Ten, string GioiTinh, string NgaySinh, string CCCD, string DienThoai, string QueQuan, string Truong)
        {
            string sqlStr = "insert into SinhVien(idSinhVien, Ten, GioiTinh, NgaySinh, CCCD, DienThoai, QueQuan, Truong) " +
                "values('" + idSinhVien + "',N'" + Ten + "',N'" + GioiTinh + "','" + NgaySinh + "','" + CCCD + "','" + DienThoai + "',N'" + QueQuan + "',N'" + Truong + "')";
            db.ThucThi(sqlStr);
        }

        public void Update(string idSinhVien, string Ten, string GioiTinh, string NgaySinh, string CCCD, string DienThoai, string QueQuan, string Truong)
        {
            string sqlStr = "update SinhVien set Ten=N'" + Ten + "',GioiTinh=N'" + GioiTinh + "',NgaySinh='" + NgaySinh + "',CCCD='" + CCCD + "',DienThoai='" + DienThoai + "', QueQuan=N'" + QueQuan + "',Truong=N'" + Truong + "' where idSinhVien='" + idSinhVien + "'";
            db.ThucThi(sqlStr);
        }

        public void Delete(string idSinhVien)
        {
            string sqlStr = "delete from SinhVien where idSinhVien='" + idSinhVien + "'";
            db.ThucThi(sqlStr);
        }
    }
}
