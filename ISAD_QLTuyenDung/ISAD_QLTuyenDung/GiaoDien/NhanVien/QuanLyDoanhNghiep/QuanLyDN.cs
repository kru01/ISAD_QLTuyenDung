using ISAD_QLTuyenDung.GiaoDien.NhanVien.QuanLyDoanhNghiep;
using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien
{
    public partial class QuanLyDN : Form
    {
        static TimDoanhNghiep? formTimDN;
        static ThemDoanhNghiep? formDN;
        internal DoanhNghiep? doanhNghiep = null;
        readonly OracleConnection conn;

        public QuanLyDN(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void GiaHanHopDong_Load(object sender, EventArgs e)
        {
            LamMoiButton.PerformClick();
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            HopDongDNData.DataSource = DoanhNghiep.LoadDSDoanhNghiep(conn);
        }

        private void FormClosedEvent(object? sender, EventArgs e)
        {
            doanhNghiep = formTimDN?.doanhNghiep ?? formDN?.doanhNghiep;
            HopDongDNData.DataSource = DoanhNghiep.LoadDSDoanhNghiep(conn, doanhNghiep);
            doanhNghiep = null;
        }

        private void TimDNButton_Click(object sender, EventArgs e)
        {
            formTimDN = new();
            formTimDN.FormClosedEvent += FormClosedEvent;
            formTimDN.Show();
        }

        private void ThemDNButton_Click(object sender, EventArgs e)
        {
            formDN = new(conn);
            formDN.FormClosedEvent += FormClosedEvent;
            formDN.Show();
        }

        private void CapNhatButton_Click(object sender, EventArgs e)
        {
            try
            {
                DoanhNghiep.CapNhatHanHopDong(conn, NgayHHDate.Text, MaDNBox.Text);
                MessageBox.Show("Gia hạn hợp đồng thành công!");
                LamMoiButton.PerformClick();
                ((DataTable)HopDongDNData.DataSource).DefaultView.RowFilter = string.Format($"MADN='{MaDNBox.Text}'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HopDongDNData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == HopDongDNData.RowCount) return;
            DataGridViewRow cRow = HopDongDNData.Rows[e.RowIndex];

            MaDNBox.Text = cRow.Cells["MADN"].Value.ToString();
            TenCtyBox.Text = cRow.Cells["TENCTY"].Value.ToString();
            NVPhuTrachBox.Text = cRow.Cells["NVPHUTRACH"].Value.ToString();
            MSThueBox.Text = cRow.Cells["MASOTHUE"].Value.ToString();
            EmailBox.Text = cRow.Cells["EMAIL"].Value.ToString();
            NgDaiDienBox.Text = cRow.Cells["NGDAIDIEN"].Value.ToString();
            DiaChiBox.Text = cRow.Cells["DCHI"].Value.ToString();
            NgayLapDate.Text = cRow.Cells["NGAYLAPHD"].Value.ToString();
            NgayHHDate.Text = cRow.Cells["NGAYHHHD"].Value.ToString();
        }

        private void ThongKeHDButton_Click(object sender, EventArgs e)
        {
            DateTime ngayHH = DateTime.Today.AddDays(-3);
            ((DataTable)HopDongDNData.DataSource).DefaultView.RowFilter =
                string.Format("CONVERT(NGAYHHHD, 'System.DateTime') < #{0}#", ngayHH.ToString("yyyy-MM-dd"));
            try
            {
                LapDSHDHetHan.ExportHoSoHetHan(HopDongDNData);
                MessageBox.Show("Copy vào clipboard thành công! Nếu Excel không tự động mở, " +
                    "vui lòng paste vào nơi cần thiết!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
