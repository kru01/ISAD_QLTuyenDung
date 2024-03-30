using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.HoTro;
using System.Data;
using System.Windows.Forms;

namespace ISAD_QLTuyenDung.Database.LanhDao
{
    internal class ThemDanhGia
    {
        public static DataSet KiemTraThemID(string query, OracleConnection conn)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            DataSet dt = new();
            OracleDataAdapter ap = new(query, conn);
            ap.Fill(dt);
            conn.Close();
            return dt;
        }

        public static bool ThemDG(string maDN, string maLD, int danhGia, string ghiChu, OracleConnection conn)
        {
            String sql = $"INSERT INTO {OracleConfig.schema}.DNTIEMNANG " +
                $"SELECT '{maDN}', '{maLD}', {danhGia}, '{ghiChu}', TO_DATE(CURRENT_DATE, 'DD/MM/YYYY') FROM DUAL";

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
