using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien
{
    public partial class LapDSSapHetHopDong : Form
    {
        readonly OracleConnection conn;

        public LapDSSapHetHopDong(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void LapDSSapHetHopDong_Load(object sender, EventArgs e)
        {
            LamMoiButton.PerformClick();
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            HopDongData.DataSource = DoanhNghiep.LoadDSDoanhNghiep(conn);
        }

        private void HopDongData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == HopDongData.RowCount) return;
            DataGridViewRow cRow = HopDongData.Rows[e.RowIndex];

            MaDNBox.Text = cRow.Cells["MADN"].Value.ToString();
            TenCtyBox.Text = cRow.Cells["TENCTY"].Value.ToString();
            MaSoThueBox.Text = cRow.Cells["MASOTHUE"].Value.ToString();
            NguoiDaiDienBox.Text = cRow.Cells["NGDAIDIEN"].Value.ToString();
            NVPhuTrachBox.Text = cRow.Cells["NVPHUTRACH"].Value.ToString();
            DiaChiBox.Text = cRow.Cells["DCHI"].Value.ToString();
        }

        private void ThongKeHDButton_Click(object sender, EventArgs e)
        {
            DateTime ngayHH = DateTime.Today.AddDays(-3);
            ((DataTable)HopDongData.DataSource).DefaultView.RowFilter = 
                string.Format("CONVERT(NGAYHHHD, 'System.DateTime') < #{0}#", ngayHH.ToString("yyyy-MM-dd"));
            try
            {
                LapDSHDHetHan.ExportHoSoHetHan(HopDongData);
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
