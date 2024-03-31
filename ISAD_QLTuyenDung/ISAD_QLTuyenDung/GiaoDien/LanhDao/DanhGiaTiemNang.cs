using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    public partial class DanhGiaTiemNang : Form
    {
        private static ThemDanhGia? formDG;
        private static ThongKe? formTK;
        private readonly OracleConnection conn;
        private readonly string curUser;

        public DanhGiaTiemNang(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.curUser = curUser;
        }

        private void DanhGiaTiemNang_Load(object sender, EventArgs e)
        {
            DanhGiaData.DataSource = NghiepVu.LanhDao.DanhGiaTiemNang.LoadDanhGia(conn);
        }

        private void ThemDGButton_Click(object sender, EventArgs e)
        {
            formDG = new(curUser, conn);
            formDG.FormClosedEvent += FormClosedEvent;
            formDG.Show();
        }

        private void FormClosedEvent(object? sender, EventArgs e)
        {
            DanhGiaData.DataSource = NghiepVu.LanhDao.DanhGiaTiemNang.LoadDanhGia(conn);
        }

        private void DanhGiaData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == DanhGiaData.RowCount) return;
            DataGridViewRow cRow = DanhGiaData.Rows[e.RowIndex];

            tenDN.Text = cRow.Cells["TENCTY"].Value.ToString();
            tenLD.Text = cRow.Cells["HOTEN"].Value.ToString();
            tiemNang.Text = cRow.Cells["TIEMNANG"].Value.ToString();
            ghiChu.Text = cRow.Cells["GHICHU"].Value.ToString();
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            DanhGiaData.DataSource = NghiepVu.LanhDao.DanhGiaTiemNang.LoadDanhGia(conn);
        }

        private void LapDSTNButton_Click(object sender, EventArgs e)
        {
            NghiepVu.LanhDao.DanhGiaTiemNang.ExportDanhGia(DanhGiaData);
        }

        private void ThongKeButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(DNThongKe.Text))
            {
                MessageBox.Show("Cần nhập mã doanh nghiệp để thống kê!");
            }
            else
            {
                formTK = new(DNThongKe.Text, conn);
                formTK.Show();
            }
        }
    }
}
