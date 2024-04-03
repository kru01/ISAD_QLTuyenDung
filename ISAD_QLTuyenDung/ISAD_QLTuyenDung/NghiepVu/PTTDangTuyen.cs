using ISAD_QLTuyenDung.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.NghiepVu
{
    internal class PTTDangTuyen (string maDN, string viTriUT, int soLuong, string ngayBD, string ngayKT, string yeuCau, int tongTien, int hinhThuc, string curUser)
    {
        public string? maPhieu;
        readonly public string maDN = maDN, viTriUT = viTriUT, yeuCau = yeuCau, curUser = curUser, ngayBD = ngayBD, ngayKT = ngayKT;
        readonly public int soLuong = soLuong, tongTien = tongTien, hinhThuc = hinhThuc;

        public static DataTable LoadPhieuTTDT(OracleConnection conn, PTTDangTuyen? phieu = null)
        {
            return PTTDangTuyenDB.LayPhieuTTDT(conn, phieu);
        }

        public static DataSet LoadMaDN(OracleConnection conn)
        {
            return PTTDangTuyenDB.LayMaDN(conn);
        }

        public static DataSet LoadViTriUT(OracleConnection conn)
        {
            return PTTDangTuyenDB.LayViTriUT(conn);
        }

        public static bool ThemPhieu(ref PTTDangTuyen phieu, OracleConnection conn)
        {
            if (string.IsNullOrEmpty(phieu.yeuCau)) return false;
            try
            {
                phieu.maPhieu = PTTDangTuyenDB.ThemPhieu(phieu, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
