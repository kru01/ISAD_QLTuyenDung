using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung
{
    public partial class LapHoSoTuyenDung : Form
    {
        private static ThemHoSo? formHS;
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
            HoSoData.DataSource = NghiepVu.NhanVien.HoSoTuyenDung.LapHoSoTuyenDung.LoadHoSo(conn);
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
            HoSoData.DataSource = NghiepVu.NhanVien.HoSoTuyenDung.LapHoSoTuyenDung.LoadHoSo(conn);
        }

        private void ThemHoSoButton_Click(object sender, EventArgs e)
        {
            formHS = new(curUser, conn);
            formHS.FormClosedEvent += FormClosedEvent;
            formHS.Show();
        }
    }
}
