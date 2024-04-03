using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ThongTinDangTuyen
{
    public partial class LapPhieuThongTinDangTuyen : Form
    {
        private static ThemPhieu? formThemPhieu;
        private readonly OracleConnection conn;
        private readonly string curUser;

        public LapPhieuThongTinDangTuyen(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.conn = conn;
        }

        private void LapPhieuThongTinDangTuyen_Load(object sender, EventArgs e)
        {
            LamMoiButton.PerformClick();
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            PhieuTTDTData.DataSource = PTTDangTuyen.LoadPhieuTTDT(conn);
        }

        private void FormClosedEvent(object? sender, EventArgs e)
        {
            PhieuTTDTData.DataSource = PTTDangTuyen.LoadPhieuTTDT(conn, formThemPhieu?.phieu);
        }

        private void PhieuTTDTData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == PhieuTTDTData.RowCount) return;
            DataGridViewRow cRow = PhieuTTDTData.Rows[e.RowIndex];

            maDN.Text = cRow.Cells["MADN"].Value.ToString();
            maPhieu.Text = cRow.Cells["MAPHIEU"].Value.ToString();
            vitriUT.Text = cRow.Cells["VITRIUT"].Value.ToString();
            hinhThucTT.Text = cRow.Cells["HTTHANHTOAN"].Value.ToString();
            ngayBatDau.Text = cRow.Cells["NGAYBD"].Value.ToString();
            ngayKetThuc.Text = cRow.Cells["NGAYKT"].Value.ToString();
            tongTien.Text = cRow.Cells["TONGTIEN"].Value.ToString();
            tienDaTra.Text = cRow.Cells["TIENDATRA"].Value.ToString();
            yeuCau.Text = cRow.Cells["YEUCAUUV"].Value.ToString();
        }

        private void ThemPhieuButton_Click(object sender, EventArgs e)
        {
            formThemPhieu = new(curUser, conn);
            formThemPhieu.FormClosedEvent += FormClosedEvent;
            formThemPhieu.Show();
        }
    }
}
