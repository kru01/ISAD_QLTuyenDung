using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ThongTinDangTuyen
{
    public partial class ThemThanhToan : Form
    {
        private readonly OracleConnection conn;
        private readonly string maDN;
        private readonly string? maPhieu;
        internal ThanhToan? hoaDon;

        public ThemThanhToan(OracleConnection conn, string maDN, string? maPhieu)
        {
            InitializeComponent();
            this.maPhieu = maPhieu;
            this.conn = conn;
            this.maDN = maDN;
        }

        private void DangKyButton_Click(object sender, EventArgs e)
        {
            hoaDon = new(maDN, maPhieu, (int)SoTienUpDown.Value, NgayTraDate.Text, PhuongThucTTCbo.SelectedIndex + 1);
            try
            {
                ThanhToan.ThemHoaDon(ref hoaDon, conn);
                MessageBox.Show("Thêm hóa đơn thành công!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát thanh toán?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
