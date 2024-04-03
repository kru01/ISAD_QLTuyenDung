using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;
using ISAD_QLTuyenDung.HoTro;
using System.Data;

namespace ISAD_QLTuyenDung.Database
{
    internal class GiayToUTDB
    {
        public static void ThemGiayTo(HoSoUngTuyen hoso, OracleConnection conn)
        {
            try
            {
                for (int i = 0; i < hoso?.loaiGiayTo?.Length; i++)
                {
                    OracleCommand cmdGiayTo = new($"{OracleConfig.schema}.USP_GIAYTOUT_INS", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmdGiayTo.Parameters.Add("IMAUV", OracleDbType.Varchar2, 255).Value = hoso.maUV;
                    cmdGiayTo.Parameters.Add("IMADN", OracleDbType.Varchar2, 255).Value = hoso.maDN;
                    cmdGiayTo.Parameters.Add("IMAPHIEU", OracleDbType.Varchar2, 255).Value = hoso.maPhieu;
                    cmdGiayTo.Parameters.Add("ITHONGTIN", OracleDbType.Varchar2, 255).Value = hoso?.thongTin?[i];
                    cmdGiayTo.Parameters.Add("ILOAIGIAY", OracleDbType.Int64, 255).Value = hoso?.loaiGiayTo[i];
                    cmdGiayTo.Parameters.Add("IMAGIAY", OracleDbType.Varchar2, ParameterDirection.Output).Size = 255;
                    cmdGiayTo.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { if (conn.State == ConnectionState.Open) conn.Close(); }
        }
    }
}
