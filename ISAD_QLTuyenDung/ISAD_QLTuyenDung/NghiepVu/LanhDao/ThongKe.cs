using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.NghiepVu.LanhDao
{
    internal class ThongKe
    {
        public static DataTable LoadThongKe(string maDN, OracleConnection conn)
        {
            return Database.LanhDao.ThongKe.LayThongKe(maDN, conn);
        }
    }
}
