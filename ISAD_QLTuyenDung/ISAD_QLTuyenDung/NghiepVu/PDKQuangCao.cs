using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.Database;

namespace ISAD_QLTuyenDung.NghiepVu
{
    internal class PDKQuangCao (string maDN, string? maPhieu, int hinhThucDT, string ngayBD, string ngayKT)
    {
        readonly public string? maPhieu = maPhieu;
        readonly public string maDN = maDN, ngayBD = ngayBD, ngayKT = ngayKT;
        readonly public int hinhThucDT = hinhThucDT;

        public static void ThemQuangCao(ref PDKQuangCao qc, OracleConnection conn)
        {
            try
            {
                PDKQuangCaoDB.ThemQuangCao(qc, conn);
            }
            catch (Exception) 
            {
                throw;
            }
        }
    }
}
