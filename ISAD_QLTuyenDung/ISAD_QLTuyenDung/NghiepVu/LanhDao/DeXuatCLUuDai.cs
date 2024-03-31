using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.NghiepVu.LanhDao
{
    internal class DeXuatCLUuDai
    {
        public static DataTable LoadChienLuoc(OracleConnection conn)
        {
            return Database.LanhDao.DeXuatCLUuDai.LayChienLuocUuDai(conn);
        }
    }
}
