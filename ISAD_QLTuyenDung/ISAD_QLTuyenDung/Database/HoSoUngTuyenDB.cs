using ISAD_QLTuyenDung.HoTro;
using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.Database
{
    internal class HoSoUngTuyenDB
    {
        public static DataTable LayHoSo(OracleConnection conn, HoSoUngTuyen? hoso = null)
        {
            string orderSql = "ORDER BY HS.MAUV, HS.MADN, HS.MAPHIEU";
            string sql = $"SELECT HS.MAUV, UV.HOTEN, HS.MADN, HS.MAPHIEU, DT.VITRIUT, HS.DOUUTIEN, HS.GHICHU, HS.TINHTRANG, HS.NVDUYET " +
                $"FROM {OracleConfig.schema}.HOSOUNGTUYEN HS JOIN {OracleConfig.schema}.UNGVIEN UV ON HS.MAUV=UV.MAUV " +
                $"JOIN {OracleConfig.schema}.PTTDANGTUYEN DT ON HS.MADN=DT.MADN AND HS.MAPHIEU=DT.MAPHIEU";

            if (hoso != null) sql += $" WHERE HS.MAUV='{hoso.maUV}' AND HS.MADN='{hoso.maDN}' AND HS.MAPHIEU='{hoso.maPhieu}'";
            sql += $" {orderSql}";

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

        public static void ThemHoSo(HoSoUngTuyen hoso, OracleConnection conn)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string hoSoSql = $"INSERT INTO {OracleConfig.schema}.HOSOUNGTUYEN " +
                    $"VALUES('{hoso.maUV}', '{hoso.maDN}', '{hoso.maPhieu}', '{hoso.doUuTien}', " +
                    $"'{hoso.ghiChu}', {hoso.tinhTrang}, '{hoso.nvDuyet}')";
                OracleCommand cmdHoSo = new(hoSoSql, conn);
                cmdHoSo.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }

        public static void DuyetHoSo(HoSoUngTuyen hoso, OracleConnection conn)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string hoSoSql = $"UPDATE {OracleConfig.schema}.HOSOUNGTUYEN " +
                    $"SET DOUUTIEN={hoso.doUuTien}, GHICHU='{hoso.ghiChu}', TINHTRANG={hoso.tinhTrang} " +
                    $"WHERE MAUV='{hoso.maUV}' AND MADN='{hoso.maDN}' AND MAPHIEU='{hoso.maPhieu}'";

                OracleCommand cmd = new(hoSoSql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }

        public static DataSet LayMaNVDuyet(OracleConnection conn)
        {
            string sql = $"SELECT DISTINCT NVDUYET FROM {OracleConfig.schema}.HOSOUNGTUYEN ORDER BY NVDUYET";
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                DataSet dt = new();
                OracleDataAdapter ap = new(sql, conn);
                ap.Fill(dt);
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
