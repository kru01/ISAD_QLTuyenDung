using ISAD_QLTuyenDung.HoTro;
using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.Database
{
    internal class NhanSuDB
    {
        public static string LayTenLanhDao(string curUser, OracleConnection conn)
        {
            string sql = $"SELECT HOTEN FROM {OracleConfig.schema}.NHANSU WHERE MANV='{curUser}'";
            string name = " ";
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
