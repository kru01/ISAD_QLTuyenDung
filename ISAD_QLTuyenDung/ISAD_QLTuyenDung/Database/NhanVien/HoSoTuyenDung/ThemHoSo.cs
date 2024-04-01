using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.HoTro;
using System.Data;
using System.Windows.Forms;

namespace ISAD_QLTuyenDung.Database.NhanVien.HoSoTuyenDung
{
    internal class ThemHoSo
    {
        public static DataSet LayIDUngVien(OracleConnection conn)
        {
            String sql = $"SELECT MAUV FROM {OracleConfig.schema}.UNGVIEN";

            if (conn.State == ConnectionState.Closed) conn.Open();
            DataSet dt = new();
            OracleDataAdapter ap = new(sql, conn);
            ap.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataSet LayMaPhieu(OracleConnection conn)
        {
            String sql = $"SELECT DISTINCT MAPHIEU FROM {OracleConfig.schema}.PTTDANGTUYEN";

            if (conn.State == ConnectionState.Closed) conn.Open();
            DataSet dt = new();
            OracleDataAdapter ap = new(sql, conn);
            ap.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataSet LayMaDN(OracleConnection conn)
        {
            String sql = $"SELECT DISTINCT MADN FROM {OracleConfig.schema}.PTTDANGTUYEN";

            if (conn.State == ConnectionState.Closed) conn.Open();
            DataSet dt = new();
            OracleDataAdapter ap = new(sql, conn);
            ap.Fill(dt);
            conn.Close();
            return dt;
        }

        public static bool ThemHS(string maUV, string maDN, string maPhieu, int tinhTrang, string ghiChu, int uuTien, string curUser, OracleConnection conn)
        {
            try
            {
                String sql = $"INSERT INTO {OracleConfig.schema}.HOSOUNGTUYEN " +
                    $"VALUES('{maUV}', '{maDN}', '{maPhieu}', '{uuTien}', '{ghiChu}', {tinhTrang}, '{curUser}')";

                if (conn.State == ConnectionState.Closed) conn.Open();
                OracleCommand cmd = new(sql, conn);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    return true;
                }
                else return false;
            }
            catch(Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }
    }
}
