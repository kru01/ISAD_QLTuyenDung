using ISAD_QLTuyenDung.HoTro;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.Database
{
    internal class UngVienDB
    {
        public static DataSet LayIDUngVien(OracleConnection conn)
        {
            String sql = $"SELECT MAUV FROM {OracleConfig.schema}.UNGVIEN";

            if (conn.State == ConnectionState.Closed) conn.Open();
            DataSet dt = new();
            OracleDataAdapter ap = new(sql, conn);
            ap.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
