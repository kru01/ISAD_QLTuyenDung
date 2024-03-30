using ISAD_QLTuyenDung.HoTro;
using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.Database.LanhDao
{
    internal class LanhDaoForm
    {
        public static string LanhDaoLoad(string curUser, OracleConnection conn)
        {
            String sql = $"SELECT HOTEN FROM {OracleConfig.schema}.NHANSU WHERE MANV='{curUser}'";
            String name = " ";
            OracleConnection connection = conn;
            OracleCommand cmd = new(sql, conn);
            try
            {
                connection.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    name = reader.GetString(0);
                }
                return name;
            }
            catch (Exception)
            {
                throw;
            }
            finally { connection.Close(); }
        }
    }
}
