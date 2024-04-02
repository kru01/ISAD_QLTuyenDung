using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISAD_QLTuyenDung.Database;

namespace ISAD_QLTuyenDung.NghiepVu
{
    internal class NhanSu
    {
        public static string LanhDaoLoad(string curUser, OracleConnection conn)
        {
            return NhanSuDB.LayTenLanhDao(curUser, conn);
        }
    }
}
