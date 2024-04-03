using ISAD_QLTuyenDung.HoTro;
using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.Database
{
    internal class HoSoUngTuyenDB
    {
        public static DataTable LayHoSo(OracleConnection conn)
        {
            string sql = $"SELECT DISTINCT HS.MAUV, UV.HOTEN, HS.MAPHIEU, HS.MADN, DT.VITRIUT, HS.DOUUTIEN, HS.GHICHU, HS.TINHTRANG " +
                $"FROM {OracleConfig.schema}.HOSOUNGTUYEN HS JOIN {OracleConfig.schema}.UNGVIEN UV ON HS.MAUV=UV.MAUV " +
                $"JOIN {OracleConfig.schema}.PTTDANGTUYEN DT ON HS.MAPHIEU=DT.MAPHIEU";

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

                for (int i = 0; i < hoso.loaiGiayTo.Length; i++)
                {
                    OracleCommand cmdGiayTo = new($"{OracleConfig.schema}.USP_GIAYTOUT_INS", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmdGiayTo.Parameters.Add("IMAUV", OracleDbType.Varchar2, 255).Value = hoso.maUV;
                    cmdGiayTo.Parameters.Add("IMADN", OracleDbType.Varchar2, 255).Value = hoso.maDN;
                    cmdGiayTo.Parameters.Add("IMAPHIEU", OracleDbType.Varchar2, 255).Value = hoso.maPhieu;
                    cmdGiayTo.Parameters.Add("ITHONGTIN", OracleDbType.Varchar2, 255).Value = hoso.thongTin[i];
                    cmdGiayTo.Parameters.Add("ILOAIGIAYTO", OracleDbType.Int64, 255).Value = hoso.loaiGiayTo[i];
                    cmdGiayTo.Parameters.Add("IMAGIAY", OracleDbType.Varchar2, ParameterDirection.Output).Size = 255;
                    cmdGiayTo.ExecuteNonQuery();
                }
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
    }
}
