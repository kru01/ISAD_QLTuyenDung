using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;
using System.Data;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung
{
    public partial class LapDSHoSo : Form
    {
        readonly OracleConnection conn;
        readonly string curUser;

        public LapDSHoSo(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.conn = conn;
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát khỏi lập danh sách hồ sơ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void LapDSHoSo_Load(object sender, EventArgs e)
        {
            LamMoiButton.PerformClick();

            MaDNCbo.DisplayMember = "MADN";
            MaDNCbo.ValueMember = "MADN";
            MaDNCbo.DataSource = DoanhNghiep.LoadTenDoanhNghiep(conn).Tables[0];

            MaPhieuCbo.DisplayMember = "MAPHIEU";
            MaPhieuCbo.ValueMember = "MAPHIEU";
            MaPhieuCbo.DataSource = PTTDangTuyen.LoadMaPhieu(conn, MaDNCbo.Text).Tables[0];

            MaNVDuyetCbo.DisplayMember = "NVDUYET";
            MaNVDuyetCbo.ValueMember = "NVDUYET";
            MaNVDuyetCbo.DataSource = HoSoUngTuyen.LoadMaNVDuyet(conn).Tables[0];
        }

        private void LapDSButtion_Click(object sender, EventArgs e)
        {
            ((DataTable)DanhSachHoSoData.DataSource).DefaultView.RowFilter =
                string.Format($"MADN='{MaDNCbo.Text}' AND MAPHIEU='{MaPhieuCbo.Text}' AND TINHTRANG={TinhTrangCbo.SelectedIndex + 1} AND NVDUYET='{MaNVDuyetCbo.Text}'");
            try
            {
                HoSoUngTuyen.ExportHoSo(DanhSachHoSoData);
                MessageBox.Show("Copy vào clipboard thành công! Nếu Excel không tự động mở, " +
                    "vui lòng paste vào nơi cần thiết!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            DanhSachHoSoData.DataSource = HoSoUngTuyen.LoadHoSo(conn);
        }
    }
}
