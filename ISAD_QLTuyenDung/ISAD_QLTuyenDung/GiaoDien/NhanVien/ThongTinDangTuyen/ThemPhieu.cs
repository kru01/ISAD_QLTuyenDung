using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ThongTinDangTuyen
{
    public partial class ThemPhieu : Form
    {
        public event EventHandler? FormClosedEvent;
        private readonly OracleConnection conn;
        private readonly string curUser;
        internal PTTDangTuyen? phieu;
        internal CTHoaDon? hoaDon;
        internal PDKQuangCao? qc;

        public ThemPhieu(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.conn = conn;
            NgayKetThuc.Value = NgayBatDau.Value.AddDays(1);
            NgayKTQCDate.Value = NgayBDQCDate.Value.AddDays(1);
        }

        private void ThemPhieu_Load(object sender, EventArgs e)
        {

            MaDNCbo.DisplayMember = "MADN";
            MaDNCbo.ValueMember = "MADN";
            MaDNCbo.DataSource = PTTDangTuyen.LoadMaDN(conn).Tables[0];

            ViTriCbo.DisplayMember = "VITRIUT";
            ViTriCbo.ValueMember = "VITRIUT";
            ViTriCbo.DataSource = PTTDangTuyen.LoadViTriUT(conn).Tables[0];
        }

        private void LapButton_Click(object sender, EventArgs e)
        {
            phieu = new(MaDNCbo.Text, ViTriCbo.Text, (int)SoLuongUpDown.Value, NgayBatDau.Text,
                NgayKetThuc.Text, YeuCauBox.Text, (int)TongTienUpDown.Value, HinhThucTTCbo.SelectedIndex + 1, curUser);
            try
            {
                if (!PTTDangTuyen.ThemPhieu(ref phieu, conn))
                {
                    MessageBox.Show("Cần nhập yêu cầu ứng tuyển!");
                    return;
                }

                int hinhThuc = BaoGiayCheckBox.Checked ? 1 :
                               BannerCheckBox.Checked ? 2 :
                               MangCheckBox.Checked ? 3 : 0;
                qc = new(MaDNCbo.Text, phieu.maPhieu, hinhThuc, NgayBDQCDate.Text, NgayKTQCDate.Text);
                if (!PDKQuangCao.ThemQuangCao(ref qc, conn))
                {
                    MessageBox.Show("Vui lòng chọn hình thức đăng tuyển!");
                    return;
                }

                hoaDon = new(MaDNCbo.Text, phieu.maPhieu, (int)SoTienUpDown.Value, NgayTraDate.Text, 
                    PhuongThucTTCbo.SelectedIndex + 1);
                if (!CTHoaDon.ThemHoaDon(ref hoaDon, conn))
                {
                    MessageBox.Show("Vui lòng chọn phương thức thanh toán!");
                    return;
                }

                MessageBox.Show("Lập phiếu đăng tuyển thành công!");
                FormClosedEvent?.Invoke(this, EventArgs.Empty);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát lập phiếu?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BaoGiayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BaoGiayCheckBox.Checked == true)
            {
                BannerCheckBox.Checked = false;
                MangCheckBox.Checked = false;
                NgayBDQCDate.Enabled = true;
                NgayKTQCDate.Enabled = true;
            }
            else if (MangCheckBox.Checked == false && BannerCheckBox.Checked == false)
            {
                NgayBDQCDate.Enabled = false;
                NgayKTQCDate.Enabled = false;
            }
        }

        private void BannerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BannerCheckBox.Checked == true)
            {
                BaoGiayCheckBox.Checked = false;
                MangCheckBox.Checked = false;
                NgayBDQCDate.Enabled = true;
                NgayKTQCDate.Enabled = true;
            }
            else if (MangCheckBox.Checked == false && BaoGiayCheckBox.Checked == false)
            {
                NgayBDQCDate.Enabled = false;
                NgayKTQCDate.Enabled = false;
            }
        }

        private void MangCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MangCheckBox.Checked == true)
            {
                BaoGiayCheckBox.Checked = false;
                BannerCheckBox.Checked = false;
                NgayBDQCDate.Enabled = true;
                NgayKTQCDate.Enabled = true;
            }
            else if (BaoGiayCheckBox.Checked == false && BannerCheckBox.Checked == false)
            {
                NgayBDQCDate.Enabled = false;
                NgayKTQCDate.Enabled = false;
            }
        }

        private void NgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            if (NgayBatDau.Value >= NgayKetThuc.Value.AddDays(-1))
            {
                NgayKetThuc.Value = NgayBatDau.Value.AddDays(1);
            }
            NgayBDQCDate.Value = NgayBatDau.Value;
            CapNhatHinhThucTT();
        }

        private void NgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            if (NgayKetThuc.Value <= NgayBatDau.Value.AddDays(1))
            {
                NgayBatDau.Value = NgayKetThuc.Value.AddDays(-1);
            }
            CapNhatHinhThucTT();
        }

        private void NgayBDQCDate_ValueChanged(object sender, EventArgs e)
        {
            if (NgayBDQCDate.Value < NgayBatDau.Value)
                NgayBDQCDate.Value = NgayBatDau.Value;

            if (NgayBDQCDate.Value >= NgayKTQCDate.Value.AddDays(-1))
            {
                NgayKTQCDate.Value = NgayBDQCDate.Value.AddDays(1);
            }
        }

        private void NgayKTQCDate_ValueChanged(object sender, EventArgs e)
        {
            if (NgayKTQCDate.Value <= NgayBDQCDate.Value.AddDays(1))
            {
                NgayBDQCDate.Value = NgayKTQCDate.Value.AddDays(-1);
            }
        }

        private void CapNhatHinhThucTT()
        {
            TimeSpan difference = NgayKetThuc.Value - NgayBatDau.Value;
            int differenceInDays = difference.Days;

            if (differenceInDays < 30)
            {
                HinhThucTTCbo.SelectedIndex = 0;
                HinhThucTTCbo.Enabled = false;
                CapNhatSoTien(HinhThucTTCbo.SelectedIndex);
            }
            else HinhThucTTCbo.Enabled = true;
        }

        private void CapNhatSoTien(int luaChon)
        {
            if (luaChon == 0)
            {
                SoTienUpDown.Enabled = false;
                SoTienUpDown.Value = TongTienUpDown.Value;
            }
            else
            {
                SoTienUpDown.Enabled = true;
                SoTienUpDown.Value = TongTienUpDown.Value * 0.3m;
            }
        }

        private void HinhThucTTCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatSoTien(HinhThucTTCbo.SelectedIndex);
        }

        private void TongTienUpDown_ValueChanged(object sender, EventArgs e)
        {
            CapNhatSoTien(HinhThucTTCbo.SelectedIndex);
        }

        private void SoTienUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (HinhThucTTCbo.SelectedIndex == 1)
            {
                if (SoTienUpDown.Value < TongTienUpDown.Value * 0.3m)
                    SoTienUpDown.Value = TongTienUpDown.Value * 0.3m;
                else if (SoTienUpDown.Value > TongTienUpDown.Value)
                    SoTienUpDown.Value = TongTienUpDown.Value;
            }
        }

        private void MaDNCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViTriCbo.DataSource = PTTDangTuyen.LoadViTriUT(conn, MaDNCbo.Text).Tables[0];
        }
    }
}
