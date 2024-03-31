using ISAD_QLTuyenDung.HoTro;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.Database.LanhDao
{
    internal class ThongKe
    {
        public static DataTable LayThongKe(string maDN, OracleConnection conn)
        {
            string sql = $"SELECT DISTINCT HS.MAUV, DT.VITRIUT, HS.DOUUTIEN, HS.TINHTRANG, HS.GHICHU " +
                $"FROM {OracleConfig.schema}.HOSOUNGTUYEN HS JOIN {OracleConfig.schema}.PTTDANGTUYEN DT ON HS.MAPHIEU=DT.MAPHIEU " +
                $"WHERE HS.MADN='{maDN}' ORDER BY DT.VITRIUT";

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
