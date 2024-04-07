using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.QuanLyDoanhNghiep
{
    public partial class TimDoanhNghiep : Form
    {
        public string? maDN, tenCty, msThue, email, nvPhuTrach, ngDaiDien, diaChi, ngayLap, ngayHH;
        public event EventHandler? FormClosedEvent;

        public TimDoanhNghiep()
        {
            InitializeComponent();
        }

        private void TimButton_Click(object sender, EventArgs e)
        {
            maDN = MaDNBox.Text;
            tenCty = TenCtyBox.Text;
            msThue = MSThueBox.Text;
            email = EmailBox.Text;
            nvPhuTrach = NVPhuTrachCbo.Text;
            ngDaiDien = NgDaiDienBox.Text;
            diaChi = DiaChiBox.Text;
            ngayLap = NgayLapDate.Text;
            ngayHH = NgayHHDate.Text;
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát khỏi tìm kiếm doanh nghiệp?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
