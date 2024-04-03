using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung
{
    public partial class LapHoSoTuyenDung : Form
    {
        private static ThemHoSo? formHS;
        private static DuyetHoSo? formDHS;
        private readonly OracleConnection conn;
        private readonly string curUser;

        public LapHoSoTuyenDung(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.conn = conn;
        }

        private void LapHoSoTuyenDung_Load(object sender, EventArgs e)
        {
            LamMoiButton.PerformClick();
        }

        private void HoSoData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == HoSoData.RowCount) return;
            DataGridViewRow cRow = HoSoData.Rows[e.RowIndex];

            maUV.Text = cRow.Cells["MAUV"].Value.ToString();
            tenUV.Text = cRow.Cells["HOTEN"].Value.ToString();
            vitriUT.Text = cRow.Cells["VITRIUT"].Value.ToString();
            tinhTrang.Text = cRow.Cells["TINHTRANG"].Value.ToString();
            ghiChu.Text = cRow.Cells["GHICHU"].Value.ToString();
        }

        private void FormClosedEvent(object? sender, EventArgs e)
        {
            HoSoData.DataSource = HoSoUngTuyen.LoadHoSo(conn);
        }

        private void ThemHoSoButton_Click(object sender, EventArgs e)
        {
            formHS = new(curUser, conn);
            formHS.FormClosedEvent += FormClosedEvent;
            formHS.Show();
        }

        private void DuyetHSButton_Click(object sender, EventArgs e)
        {
            formDHS = new(curUser, conn);
            formDHS.FormClosedEvent += FormClosedEvent;
            formDHS.Show();
        }

        private void LapDSHSButton_Click(object sender, EventArgs e)
        {
            try
            {
                HoSoUngTuyen.ExportHoSo(HoSoData);
                MessageBox.Show("Copy vào clipboard thành công! Nếu Excel không tự động mở, vui lòng paste vào nơi cần thiết!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            HoSoData.DataSource = HoSoUngTuyen.LoadHoSo(conn);
        }
    }
}
