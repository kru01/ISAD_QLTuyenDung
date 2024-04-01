using ISAD_QLTuyenDung.HoTro;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.Database.NhanVien.HoSoTuyenDung
{
    internal class LapHoSoTuyenDung
    {
        private static readonly string sql = $"SELECT DISTINCT HS.MAUV, UV.HOTEN, DT.VITRIUT, HS.DOUUTIEN, HS.GHICHU, HS.TINHTRANG " +
                $"FROM {OracleConfig.schema}.HOSOUNGTUYEN HS JOIN {OracleConfig.schema}.UNGVIEN UV ON HS.MAUV=UV.MAUV " +
                $"JOIN {OracleConfig.schema}.PTTDANGTUYEN DT ON HS.MAPHIEU=DT.MAPHIEU";

        public static DataTable LayHoSo(OracleConnection conn)
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
