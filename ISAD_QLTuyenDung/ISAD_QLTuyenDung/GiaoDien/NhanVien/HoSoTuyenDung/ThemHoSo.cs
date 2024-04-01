using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung
{
    public partial class ThemHoSo : Form
    {
        public event EventHandler? FormClosedEvent;
        private readonly OracleConnection conn;
        private readonly string curUser;

        public ThemHoSo(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.conn = conn;
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát khỏi thêm hồ sơ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void ThemHoSo_Load(object sender, EventArgs e)
        {
            maUV.DisplayMember = "MAUV";
            maUV.ValueMember = "MAUV";
            maUV.DataSource = NghiepVu.NhanVien.HoSoTuyenDung.ThemHoSo.ThemIDUngVien(conn).Tables[0];

            maPhieu.DisplayMember = "MAPHIEU";
            maPhieu.ValueMember = "MAPHIEU";
            maPhieu.DataSource = NghiepVu.NhanVien.HoSoTuyenDung.ThemHoSo.ThemMaPhieu(conn).Tables[0];

            maDN.DisplayMember = "MADN";
            maDN.ValueMember = "MADN";
            maDN.DataSource = NghiepVu.NhanVien.HoSoTuyenDung.ThemHoSo.ThemMaDoanhNghiep(conn).Tables[0];
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            if (!NghiepVu.NhanVien.HoSoTuyenDung.ThemHoSo.KiemTraThemHoSo(maUV.Text, maDN.Text, maPhieu.Text, tinhTrang.SelectedIndex, ghiChu.Text, (int)doUuTien.Value, curUser, conn))
            {
                MessageBox.Show("Thêm hồ sơ thất bại!");
            }
            else
            {
                MessageBox.Show("Thêm hồ sơ thành công!");
                FormClosedEvent?.Invoke(this, EventArgs.Empty);
                Close();
            }
        }
    }
}
