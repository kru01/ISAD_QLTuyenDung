using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.Database;

namespace ISAD_QLTuyenDung.NghiepVu
{
    internal class ThanhToan (string maDN, string? maPhieu, int soTien, string ngayTra, int PTThanhToan)
    {
        public string? maCT;
        readonly public string? maPhieu = maPhieu;
        readonly public string maDN = maDN, ngayTra = ngayTra;
        readonly public int soTien = soTien, PTThanhToan = PTThanhToan;

        public static void ThemHoaDon(ref ThanhToan hoaDon, OracleConnection conn)
        {
            try
            {
                hoaDon.maCT = CTHoaDonDB.ThemHoaDon(hoaDon, conn);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
