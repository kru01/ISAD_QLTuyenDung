using ISAD_QLTuyenDung.HoTro;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAD_QLTuyenDung.Database
{
    internal class DoanhNghiepDB
    {
        public static DataSet LayDSDoanhNghiep(OracleConnection conn)
        {
            String sql = $"SELECT MADN, TENCTY FROM {OracleConfig.schema}.DOANHNGHIEP ORDER BY MADN";

            if (conn.State == ConnectionState.Closed) conn.Open();
            DataSet dt = new();
            OracleDataAdapter ap = new(sql, conn);
            ap.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
