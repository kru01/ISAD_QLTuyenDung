using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.NghiepVu.LanhDao
{
    internal class ThemChienLuoc
    {
        public static bool KiemTraThemChienLuoc(string curUser, string tenCL, string moTa, OracleConnection conn)
        {
            if (String.IsNullOrEmpty(tenCL))
            {
                return false;
            }
            else
            {
                try
                {
                    if (!Database.LanhDao.ThemChienLuoc.ThemCL(curUser, tenCL, moTa, conn))
                    {
                        return false;
                    }
                    else return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
