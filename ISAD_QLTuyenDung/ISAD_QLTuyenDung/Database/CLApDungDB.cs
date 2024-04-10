using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;
using ISAD_QLTuyenDung.HoTro;
using System.Data;

namespace ISAD_QLTuyenDung.Database
{
    internal class CLApDungDB
    {
        public static DataTable LayChienLuocApDung(OracleConnection conn, CLApDung? clApDung = null)
        {
            string sql = $"SELECT CL.MADN, DN.TENCTY, CL.MACL, UD.TENCL, CL.NGAYBD, CL.NGAYKT " +
                $"FROM {OracleConfig.schema}.CLAPDUNG CL JOIN {OracleConfig.schema}.DOANHNGHIEP DN ON CL.MADN=DN.MADN " +
                $"JOIN {OracleConfig.schema}.CHIENLUOCUUDAI UD ON CL.MACL=UD.MACL";

            if (clApDung != null) sql += $" WHERE CL.MADN='{clApDung.maDN}' AND CL.MACL='{clApDung.maCL}'";
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

        public static void ApDungCL(CLApDung clApDung, OracleConnection conn)
        {
            string insSql = $"INSERT INTO {OracleConfig.schema}.CLAPDUNG " +
                $"VALUES('{clApDung.maDN}', '{clApDung.maCL}', TO_DATE('{clApDung.ngayBD}', 'DD/MM/YYYY'), " +
                $"TO_DATE('{clApDung.ngayKT}', 'DD/MM/YYYY'))";

            OracleCommand cmd = new(insSql, conn);
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
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
