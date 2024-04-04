using ISAD_QLTuyenDung.Database;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAD_QLTuyenDung.NghiepVu
{
    internal class UngVien
    {
        public static DataSet LoadMaUngVien(OracleConnection conn)
        {
            return UngVienDB.LayIDUngVien(conn);
        }
    }
}
