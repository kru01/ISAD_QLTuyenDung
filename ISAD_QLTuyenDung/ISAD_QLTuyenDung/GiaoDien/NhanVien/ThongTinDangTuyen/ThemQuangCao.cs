using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ThongTinDangTuyen
{
    public partial class ThemQuangCao : Form
    {
        private readonly OracleConnection conn;
        private readonly string maDN;
        private readonly string? maPhieu;
        static ThemThanhToan? formTT;
        internal PDKQuangCao? qc;

        public ThemQuangCao(OracleConnection conn, string maDN, string? maPhieu)
        {
            InitializeComponent();
            this.maPhieu = maPhieu;
            this.conn = conn;
            this.maDN = maDN;
        }

        private void DangKyButton_Click(object sender, EventArgs e)
        {
            qc = new(maDN, maPhieu, HinhThucDTCbo.SelectedIndex + 1, NgayBDDate.Text, NgayKTDate.Text);
            try
            {
                PDKQuangCao.ThemQuangCao(ref qc, conn);
                MessageBox.Show("Đăng ký quảng cáo thành công!");
                formTT = new(conn, maDN, maPhieu);
                formTT.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát đăng ký quảng cáo?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
