using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.HoTro;
using System.Data;

namespace ISAD_QLTuyenDung.Database.LanhDao
{
    internal class DeXuatCLUuDai
    {
        private static readonly string sql = $"SELECT CL.TENCL, CL.MOTA, CL.LDDEXUAT, NS.HOTEN " +
            $"FROM {OracleConfig.schema}.CHIENLUOCUUDAI CL JOIN {OracleConfig.schema}.NHANSU NS " +
            $"ON CL.LDDEXUAT = NS.MANV";

        public static DataTable LayChienLuocUuDai(OracleConnection conn)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            OracleDataAdapter adp = new(sql, conn);
            try
            {
                DataTable dt = new();
                adp.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }
    }
}
