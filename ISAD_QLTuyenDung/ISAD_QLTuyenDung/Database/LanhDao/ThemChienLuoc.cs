using ISAD_QLTuyenDung.HoTro;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.Database.LanhDao
{
    internal class ThemChienLuoc
    {
        public static bool ThemCL(string curUser, string tenCL, string moTa, OracleConnection conn)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                OracleCommand cmd = new("USP_CHIENLUOCUUDAI_INS", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("ITENCL", OracleDbType.Varchar2).Value = tenCL;
                cmd.Parameters.Add("IMOTA", OracleDbType.Varchar2).Value = moTa;
                cmd.Parameters.Add("ILDDEXUAT", OracleDbType.Varchar2).Value = curUser;
                cmd.Parameters.Add("IMACL", OracleDbType.Varchar2, ParameterDirection.Output);

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }
    }
}
