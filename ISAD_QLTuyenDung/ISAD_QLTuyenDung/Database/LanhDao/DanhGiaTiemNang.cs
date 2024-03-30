using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.HoTro;
using System.Data;

namespace ISAD_QLTuyenDung.Database.LanhDao
{
    internal class DanhGiaTiemNang
    {
        private static readonly String sql = $"SELECT DG.MADN, DN.TENCTY, DG.LDDANHGIA, NS.HOTEN, DG.TIEMNANG, DG.GHICHU, DG.NGAYCAPNHAT " +
                                    $"FROM {OracleConfig.schema}.DNTIEMNANG DG JOIN {OracleConfig.schema}.DOANHNGHIEP DN ON DG.MADN=DN.MADN " +
                                    $"JOIN {OracleConfig.schema}.NHANSU NS ON DG.LDDANHGIA=NS.MANV";

        public static DataTable LayDanhGia(OracleConnection conn)
        {
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
    }
}
