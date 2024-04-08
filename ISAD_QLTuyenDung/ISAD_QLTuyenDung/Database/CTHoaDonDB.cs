using ISAD_QLTuyenDung.HoTro;
using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.Database
{
    internal class CTHoaDonDB
    {
        public static string? ThemHoaDon(CTHoaDon hoaDon, OracleConnection conn)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                OracleCommand cmd = new($"{OracleConfig.schema}.USP_CTHOADON_INS", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("IMADN", OracleDbType.Varchar2, 255).Value = hoaDon.maDN;
                cmd.Parameters.Add("IMAPHIEU", OracleDbType.Varchar2, 255).Value = hoaDon.maPhieu;
                cmd.Parameters.Add("ISOTIEN", OracleDbType.Int64, 255).Value = hoaDon.soTien;
                cmd.Parameters.Add("INGAYTRA", OracleDbType.Varchar2, 255).Value = hoaDon.ngayTra;
                cmd.Parameters.Add("IPTTHANHTOAN", OracleDbType.Int64, 255).Value = hoaDon.phuongThucTT;
                cmd.Parameters.Add("IMACT", OracleDbType.Int64, ParameterDirection.Output).Size = 255;

                cmd.ExecuteNonQuery();
                return cmd.Parameters[5].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }

        public static DataTable LayDSHoaDon(OracleConnection conn, CTHoaDon? hoaDon = null)
        {
            string sql = $"SELECT HD.MADN, DN.TENCTY, HD.MAPHIEU, HD.MACT, HD.SOTIEN, HD.NGAYTRA, PT.TENPT " +
                $"FROM {OracleConfig.schema}.CTHOADON HD JOIN {OracleConfig.schema}.DOANHNGHIEP DN ON HD.MADN=DN.MADN " +
                $"JOIN {OracleConfig.schema}.PTTHANHTOAN PT ON PT.MAPT=HD.PTTHANHTOAN";
            if (hoaDon != null) sql += $" WHERE HD.MADN='{hoaDon.maDN}' AND HD.MAPHIEU='{hoaDon.maPhieu}' AND HD.MACT='{hoaDon.maCT}'";
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                DataTable dt = new();
                OracleDataAdapter ap = new(sql, conn);
                ap.Fill(dt);
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
