using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.Database;

namespace ISAD_QLTuyenDung.NghiepVu
{
    internal class NhanSu
    {
        public static string NhanSuLoad(string curUser, OracleConnection conn)
        {
            return NhanSuDB.LayTenNhanSu(curUser, conn);
        }
    }
}
