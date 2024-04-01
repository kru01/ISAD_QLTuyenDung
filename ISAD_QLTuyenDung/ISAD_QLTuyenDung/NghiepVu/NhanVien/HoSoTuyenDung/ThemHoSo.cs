using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.NghiepVu.NhanVien.HoSoTuyenDung
{
    internal class ThemHoSo
    {
        public static DataSet ThemIDUngVien(OracleConnection conn)
        {
            return Database.NhanVien.HoSoTuyenDung.ThemHoSo.LayIDUngVien(conn);
        }

        public static DataSet ThemMaPhieu(OracleConnection conn)
        {
            return Database.NhanVien.HoSoTuyenDung.ThemHoSo.LayMaPhieu(conn);
        }

        public static DataSet ThemMaDoanhNghiep(OracleConnection conn)
        {
            return Database.NhanVien.HoSoTuyenDung.ThemHoSo.LayMaDN(conn);
        }

        public static bool KiemTraThemHoSo(string maUV, string maDN, string maPhieu, int tinhTrang, string ghiChu, int uuTien, string curUser, OracleConnection conn)
        {
            try
            {
                if (!Database.NhanVien.HoSoTuyenDung.ThemHoSo.ThemHS(maUV, maDN, maPhieu, tinhTrang, ghiChu, uuTien, curUser, conn))
                {
                    return false;
                }
                else return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
