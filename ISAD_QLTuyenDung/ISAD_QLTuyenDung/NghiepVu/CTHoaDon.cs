using ISAD_QLTuyenDung.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.NghiepVu
{
    internal class CTHoaDon (string maDN, string? maPhieu, int soTien, string ngayTra, int phuongThucTT)
    {
        public string? maCT;
        readonly public string? maPhieu = maPhieu;
        readonly public string maDN = maDN, ngayTra = ngayTra;
        readonly public int soTien = soTien, phuongThucTT = phuongThucTT;

        public static DataTable LoadCTHoaDon(OracleConnection conn, CTHoaDon? hoaDon = null)
        {
            return CTHoaDonDB.LayDSHoaDon(conn, hoaDon);
        }

        public static bool ThemHoaDon(ref CTHoaDon hoaDon, OracleConnection conn)
        {
            if (hoaDon.phuongThucTT == 0) return false;
            try
            {
                hoaDon.maCT = CTHoaDonDB.ThemHoaDon(hoaDon, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
