using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.NghiepVu.LanhDao
{
    internal class ThemDanhGia
    {
        public static DataSet ThemIDDoanhNghiep(string query, OracleConnection conn)
        {
            return Database.LanhDao.ThemDanhGia.KiemTraThemID(query, conn);
        }

        public static bool KiemTraThemDanhGia(string maDN, string maLD, int danhGia, string ghiChu, OracleConnection conn)
        {
            if (danhGia < 1 || danhGia > 10)
            {
                return false;
            }
            else
            {
                try
                {
                    if(!Database.LanhDao.ThemDanhGia.ThemDG(maDN, maLD, danhGia, ghiChu, conn))
                    {
                        return false;
                    }
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
