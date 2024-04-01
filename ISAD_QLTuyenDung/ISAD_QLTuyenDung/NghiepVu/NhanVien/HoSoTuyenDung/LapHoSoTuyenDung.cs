using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.NghiepVu.NhanVien.HoSoTuyenDung
{
    internal class LapHoSoTuyenDung
    {
        public static DataTable LoadHoSo(OracleConnection conn)
        {
            return Database.NhanVien.HoSoTuyenDung.LapHoSoTuyenDung.LayHoSo(conn);
        }
    }
}
