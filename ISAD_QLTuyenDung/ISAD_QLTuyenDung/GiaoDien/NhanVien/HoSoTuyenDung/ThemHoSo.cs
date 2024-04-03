using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung
{
    public partial class ThemHoSo : Form
    {
        public event EventHandler? FormClosedEvent;
        private readonly OracleConnection conn;
        private readonly string curUser;
        private readonly string[] thongTinGiayTo;
        private readonly int[] loaiGiayTo;
        internal HoSoUngTuyen? hoso;

        public ThemHoSo(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.conn = conn;
        }

        private void ThemHoSo_Load(object sender, EventArgs e)
        {
            maUV.DisplayMember = "MAUV";
            maUV.ValueMember = "MAUV";
            maUV.DataSource = HoSoUngTuyen.LoadMaUngVien(conn).Tables[0];

            maPhieu.DisplayMember = "MAPHIEU";
            maPhieu.ValueMember = "MAPHIEU";
            maPhieu.DataSource = HoSoUngTuyen.LoadMaPhieu(conn).Tables[0];

            maDN.DisplayMember = "MADN";
            maDN.ValueMember = "MADN";
            maDN.DataSource = HoSoUngTuyen.LoadMaDN(conn).Tables[0];
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            hoso = new(maUV.Text, maDN.Text, maPhieu.Text, (int)doUuTien.Value, ghiChu.Text, tinhTrang.SelectedIndex + 1, curUser, thongTinGiayTo, loaiGiayTo);
            try
            {
                if (!HoSoUngTuyen.ThemHoSo(ref hoso, conn))
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát khỏi thêm hồ sơ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
