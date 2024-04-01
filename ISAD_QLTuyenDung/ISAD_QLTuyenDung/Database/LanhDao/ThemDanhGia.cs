using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.HoTro;
using System.Data;

namespace ISAD_QLTuyenDung.Database.LanhDao
{
    internal class ThemDanhGia
    {
        public static DataSet LayIDDoanhNghiep(OracleConnection conn)
        {
            String sql = $"SELECT MADN, TENCTY FROM {OracleConfig.schema}.DOANHNGHIEP ORDER BY MADN";

            if (conn.State == ConnectionState.Closed) conn.Open();
            DataSet dt = new();
            OracleDataAdapter ap = new(sql, conn);
            ap.Fill(dt);
            conn.Close();
            return dt;
        }

        public static bool ThemDG(string maDN, string maLD, int danhGia, string ghiChu, OracleConnection conn)
        {
            String sql = $"INSERT INTO {OracleConfig.schema}.DNTIEMNANG " +
                $"VALUES('{maDN}', '{maLD}', {danhGia}, '{ghiChu}', TRUNC(CURRENT_DATE))";

            OracleCommand cmd = new(sql, conn);

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }
    }
}
