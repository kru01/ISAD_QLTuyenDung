using ISAD_QLTuyenDung.HoTro;
using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.Database
{
    internal class CTHoaDonDB
    {
        public static string? ThemHoaDon(ThanhToan hoaDon, OracleConnection conn)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new($"{OracleConfig.schema}.USP_CTHOADON_INS", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("IMADN", OracleDbType.Varchar2, 255).Value = hoaDon.maDN;
                cmd.Parameters.Add("IMAPHIEU", OracleDbType.Varchar2, 255).Value = hoaDon.maPhieu;
                cmd.Parameters.Add("ISOTIEN", OracleDbType.Int64, 255).Value = hoaDon.soTien;
                cmd.Parameters.Add("INGAYTRA", OracleDbType.Varchar2, 255).Value = hoaDon.ngayTra;
                cmd.Parameters.Add("IPTTHANHTOAN", OracleDbType.Int64, 255).Value = hoaDon.PTThanhToan;
                cmd.Parameters.Add("IMACT", OracleDbType.Varchar2, ParameterDirection.Output).Size = 255;

                cmd.ExecuteNonQuery();
                return cmd.Parameters[5].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }
    }
}
