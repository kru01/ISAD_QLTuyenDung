using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien
{
    public partial class DangKyDoanhNghiep : Form
    {
        static ThemDoanhNghiep? formDN;
        readonly OracleConnection conn;
        readonly string curUser;

        public DangKyDoanhNghiep(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.conn = conn;
        }

        private void DangKyDoanhNghiep_Load(object sender, EventArgs e)
        {
            LamMoiButton.PerformClick();
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            DoanhNghiepData.DataSource = DoanhNghiep.LoadDSDoanhNghiep(conn, formDN?.doanhNghiep);
        }

        private void DoanhNghiepData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == DoanhNghiepData.RowCount) return;
            DataGridViewRow cRow = DoanhNghiepData.Rows[e.RowIndex];

            MaDNBox.Text = cRow.Cells["MADN"].Value.ToString();
            TenCtyBox.Text = cRow.Cells["TENCTY"].Value.ToString();
            MaSoThueBox.Text = cRow.Cells["MASOTHUE"].Value.ToString();
            NguoiDaiDienBox.Text = cRow.Cells["NGDAIDIEN"].Value.ToString();
            NVPhuTrachBox.Text = cRow.Cells["NVPHUTRACH"].Value.ToString();
            DiaChiBox.Text = cRow.Cells["DCHI"].Value.ToString();
        }

        private void FormClosedEvent(object? sender, EventArgs e)
        {
            DoanhNghiepData.DataSource = DoanhNghiep.LoadDSDoanhNghiep(conn, formDN?.doanhNghiep);
        }

        private void ThemDNButton_Click(object sender, EventArgs e)
        {
            formDN = new(conn);
            formDN.FormClosedEvent += FormClosedEvent;
            formDN.Show();
        }
    }
}
