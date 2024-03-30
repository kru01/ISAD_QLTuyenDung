using Excel = Microsoft.Office.Interop.Excel;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace ISAD_QLTuyenDung.NghiepVu.LanhDao
{
    internal class DanhGiaTiemNang
    {
        public static DataTable LoadDanhGia(OracleConnection conn)
        {
            return Database.LanhDao.DanhGiaTiemNang.LayDanhGia(conn);
        }

        public static void ExportDanhGia(DataGridView d)
        {
            try
            {
                if (d.Rows.Count > 0)
                {
                    Excel.ApplicationClass MExcel = new();
                    MExcel.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < d.Columns.Count + 1; i++)
                    {
                        MExcel.Cells[1, i] = d.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < d.Rows.Count; i++)
                    {
                        for (int j = 0; j < d.Columns.Count; j++)
                        {
                            MExcel.Cells[i + 2, j + 1] = d.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    MExcel.Columns.AutoFit();
                    MExcel.Rows.AutoFit();
                    MExcel.Columns.Font.Size = 12;
                    MExcel.Visible = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
