using ISAD_QLTuyenDung.HoTro;
using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.Database
{
    internal class DoanhNghiepDB
    {
        public static DataSet LayTenDoanhNghiep(OracleConnection conn)
        {
            string sql = $"SELECT MADN, TENCTY FROM {OracleConfig.schema}.DOANHNGHIEP ORDER BY MADN";

            conn.Open();
            DataSet dt = new();
            OracleDataAdapter ap = new(sql, conn);
            ap.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable LayDSDoanhNghiep(OracleConnection conn, DoanhNghiep? doanhNghiep = null)
        {
            string sql = $"SELECT * FROM {OracleConfig.schema}.DOANHNGHIEP";
            if (doanhNghiep != null) sql += $" WHERE MADN='{doanhNghiep.maDN}'";

            conn.Open();
            DataTable dt = new();
            OracleDataAdapter ap = new(sql, conn);
            ap.Fill(dt);
            conn.Close();
            return dt;
        }

        public static string? ThemDoanhNghiep(DoanhNghiep doanhNghiep, OracleConnection conn)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new($"{OracleConfig.schema}.USP_DOANHNGHIEP_INS", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("ITENCTY", OracleDbType.Varchar2, 255).Value = doanhNghiep.tenCty;
                cmd.Parameters.Add("IMASOTHUE", OracleDbType.Varchar2, 255).Value = doanhNghiep.msThue;
                cmd.Parameters.Add("INGDAIDIEN", OracleDbType.Varchar2, 255).Value = doanhNghiep.ngDaiDien;
                cmd.Parameters.Add("IDCHI", OracleDbType.Varchar2, 255).Value = doanhNghiep.diaChi;
                cmd.Parameters.Add("IEMAIL", OracleDbType.Varchar2, 255).Value = doanhNghiep.email;
                cmd.Parameters.Add("INGAYLAPHD", OracleDbType.Varchar2, 255).Value = doanhNghiep.ngayLap;
                cmd.Parameters.Add("INGAYHHHD", OracleDbType.Varchar2, 255).Value = doanhNghiep.ngayHD;
                cmd.Parameters.Add("INVPHUTRACH", OracleDbType.Varchar2, 255).Value = doanhNghiep.nvPhutrach;
                cmd.Parameters.Add("IMADN", OracleDbType.Varchar2, ParameterDirection.Output).Size = 255;

                cmd.ExecuteNonQuery();
                return cmd.Parameters[8].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close();  }
        }

        public static void CapNhatHopDong(OracleConnection conn, string ngayHH, string maDN)
        {
            try
            {
                string sql = $"UPDATE {OracleConfig.schema}.DOANHNGHIEP " +
                    $"SET NGAYHHHD=TO_DATE('{ngayHH}', 'DD-MM-YYYY') WHERE MADN='{maDN}'";

                if (conn.State == ConnectionState.Closed) conn.Open();
                OracleCommand cmd = new(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }
    }
}
