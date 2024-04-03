using ISAD_QLTuyenDung.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.NghiepVu
{
    internal class DoanhNghiep
    {
        public static DataSet HienDSDoanhNghiep(OracleConnection conn)
        {
            return DoanhNghiepDB.LayDSDoanhNghiep(conn);
        }
    }
}
