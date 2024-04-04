﻿using ISAD_QLTuyenDung.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.NghiepVu
{
    internal class PTTDangTuyen (string maDN, string viTriUT, int soLuongTD, string ngayBD, string ngayKT,
        string yeuCauUV, int tongTien, int htThanhToan, string nvLap)
    {
        public string? maPhieu;
        readonly public string maDN = maDN, viTriUT = viTriUT, yeuCauUV = yeuCauUV, nvLap = nvLap,
            ngayBD = ngayBD, ngayKT = ngayKT;
        readonly public int soLuongTD = soLuongTD, tongTien = tongTien, htThanhToan = htThanhToan;

        public static DataTable LoadPhieuTTDT(OracleConnection conn, PTTDangTuyen? phieu = null)
        {
            return PTTDangTuyenDB.LayPhieuTTDT(conn, phieu);
        }

        public static DataSet LoadMaDN(OracleConnection conn)
        {
            return PTTDangTuyenDB.LayMaDN(conn);
        }

        public static DataSet LoadMaPhieu(OracleConnection conn, string maDN)
        {
            return PTTDangTuyenDB.LayMaPhieu(conn, maDN);
        }

        public static DataSet LoadViTriUT(OracleConnection conn)
        {
            return PTTDangTuyenDB.LayViTriUT(conn);
        }

        public static bool ThemPhieu(ref PTTDangTuyen phieu, OracleConnection conn)
        {
            if (string.IsNullOrEmpty(phieu.yeuCauUV)) return false;
            try
            {
                phieu.maPhieu = PTTDangTuyenDB.ThemPhieu(phieu, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
