using ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung;
using ISAD_QLTuyenDung.GiaoDien.NhanVien.ThongTinDangTuyen;
using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.HoTro;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien
{
    public partial class NhanVienForm : Form
    {
        private readonly string curUser;
        private readonly OracleConnection conn;

        public NhanVienForm(string curUser, string conn)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.conn = new(conn);
        }

        private void DKDNButton_Click(object sender, EventArgs e)
        {
            Helper.Loadform(new DangKyDoanhNghiep(), mainPanel);
        }

        private void GiaHanHDButton_Click(object sender, EventArgs e)
        {
            Helper.Loadform(new GiaHanHopDong(), mainPanel);
        }

        private void DSHetHDButton_Click(object sender, EventArgs e)
        {
            Helper.Loadform(new LapDSSapHetHopDong(), mainPanel);
        }

        private void TTDangTuyenButton_Click(object sender, EventArgs e)
        {
            Helper.Loadform(new LapPhieuThongTinDangTuyen(), mainPanel);
        }

        private void HSTuyenDungButton_Click(object sender, EventArgs e)
        {
            Helper.Loadform(new LapHoSoTuyenDung(curUser, conn), mainPanel);
        }

        private void DangXuatButton_Click_1(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn đăng xuất?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Hide();
                new Login().ShowDialog();
                this.Close();
            }
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            //empName.Text = $"{curUser} - " + NghiepVu.LanhDao.LanhDaoForm.LanhDaoLoad(curUser, conn);
        }
    }
}
