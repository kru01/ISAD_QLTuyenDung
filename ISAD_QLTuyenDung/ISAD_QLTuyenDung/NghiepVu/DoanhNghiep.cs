using ISAD_QLTuyenDung.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.NghiepVu
{
    internal class DoanhNghiep(string tenCty, string msThue, string ngDaiDien, string nvPhuTrach, 
        string ngayLap, string ngayHD, string email, string diaChi)
    {
        public string? maDN;
        readonly public string tenCty = tenCty, msThue = msThue, ngDaiDien = ngDaiDien, nvPhutrach = nvPhuTrach, 
            ngayLap = ngayLap, ngayHD = ngayHD, email = email, diaChi = diaChi;

        public static DataSet LoadTenDoanhNghiep(OracleConnection conn)
        {
            return DoanhNghiepDB.LayTenDoanhNghiep(conn);
        }

        public static DataTable LoadDSDoanhNghiep(OracleConnection conn, DoanhNghiep? doanhNghiep = null)
        {
            return DoanhNghiepDB.LayDSDoanhNghiep(conn, doanhNghiep);
        }

        public static bool ThemDoanhNghiep(ref DoanhNghiep doanhNghiep, OracleConnection conn)
        {
            if (string.IsNullOrEmpty(doanhNghiep.tenCty) || string.IsNullOrEmpty(doanhNghiep.msThue) ||
                string.IsNullOrEmpty(doanhNghiep.ngDaiDien) || string.IsNullOrEmpty(doanhNghiep.email) ||
                string.IsNullOrEmpty(doanhNghiep.diaChi)) return false;
            try
            {
                doanhNghiep.maDN = DoanhNghiepDB.ThemDoanhNghiep(doanhNghiep, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void CapNhatHanHopDong(OracleConnection conn, string ngayHH, string maDN)
        {
            try
            {
                DoanhNghiepDB.CapNhatHopDong(conn, ngayHH, maDN);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
