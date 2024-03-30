using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAD_QLTuyenDung.NghiepVu.LanhDao
{
    internal class LanhDaoForm
    {
        public static string LanhDaoLoad(string curUser, OracleConnection conn)
        {
            return Database.LanhDao.LanhDaoForm.LanhDaoLoad(curUser, conn);
        }
    }
}
