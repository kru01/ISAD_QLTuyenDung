using ISAD_QLTuyenDung.NghiepVu;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.QuanLyDoanhNghiep
{
    public partial class TimDoanhNghiep : Form
    {
        internal DoanhNghiep? doanhNghiep = null;
        public event EventHandler? FormClosedEvent;

        public TimDoanhNghiep()
        {
            InitializeComponent();
        }

        private void TimButton_Click(object sender, EventArgs e)
        {
            doanhNghiep = new(TenCtyBox.Text, MSThueBox.Text, NgDaiDienBox.Text, NVPhuTrachCbo.Text,
                NgayLapDate.Text, NgayHHDate.Text, EmailBox.Text, DiaChiBox.Text, MaDNBox.Text);
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
            doanhNghiep = null;
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
