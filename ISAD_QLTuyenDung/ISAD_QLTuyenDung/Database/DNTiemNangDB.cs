using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.HoTro;
using ISAD_QLTuyenDung.NghiepVu;
using System.Data;

namespace ISAD_QLTuyenDung.Database
{
    internal class DNTiemNangDB
    {
        static readonly string sql = $"SELECT DG.MADN, DN.TENCTY, DG.LDDANHGIA, NS.HOTEN, DG.TIEMNANG, DG.GHICHU, DG.NGAYCAPNHAT " +
                $"FROM {OracleConfig.schema}.DNTIEMNANG DG JOIN {OracleConfig.schema}.DOANHNGHIEP DN ON DG.MADN=DN.MADN " +
                $"JOIN {OracleConfig.schema}.NHANSU NS ON DG.LDDANHGIA=NS.MANV";
        static readonly string orderSql = "ORDER BY DG.MADN, DG.LDDANHGIA";
        public static DataTable LayDanhGia(OracleConnection conn, DNTiemNang? danhGia = null)
        {
            string seSql = sql;
            if (danhGia != null) seSql += $" WHERE DG.MADN = '{danhGia.maDN}' AND DG.LDDANHGIA = '{danhGia.ldDanhGia}'";
            if (conn.State == ConnectionState.Closed) conn.Open();
            OracleDataAdapter adp = new($"{seSql} {orderSql}", conn);
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

        public static void ThemDanhGia(DNTiemNang danhGia, OracleConnection conn)
        {
            String inSql = $"INSERT INTO {OracleConfig.schema}.DNTIEMNANG " +
                $"VALUES('{danhGia.maDN}', '{danhGia.ldDanhGia}', {danhGia.tiemNang}, " +
                    $"'{danhGia.ghiChu}', TO_DATE('{danhGia.ngayCapNhat:dd/MM/yyyy}', 'DD/MM/YYYY'))";
            OracleCommand cmd = new(inSql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }

        public static DataTable ThongKeDoanhNghiep(string maDN, OracleConnection conn)
        {
            string sql = $"SELECT DISTINCT HS.MAUV, DT.VITRIUT, HS.DOUUTIEN, HS.TINHTRANG, HS.GHICHU " +
                $"FROM {OracleConfig.schema}.HOSOUNGTUYEN HS JOIN {OracleConfig.schema}.PTTDANGTUYEN DT ON HS.MAPHIEU=DT.MAPHIEU " +
                $"WHERE HS.MADN='{maDN}' ORDER BY DT.VITRIUT";

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
