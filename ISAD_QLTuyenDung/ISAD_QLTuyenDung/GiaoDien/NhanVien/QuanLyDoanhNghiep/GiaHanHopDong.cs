using ISAD_QLTuyenDung.GiaoDien.NhanVien.QuanLyDoanhNghiep;
using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien
{
    public partial class GiaHanHopDong : Form
    {
        static TimDoanhNghiep? formTimDN;
        readonly OracleConnection conn;

        public GiaHanHopDong(OracleConnection conn)
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
            /*string filter =
                (formTimDN?.maDN != null ? $"MADN='{formTimDN?.maDN}'" : "") +
                (formTimDN?.tenCty != null ? $"TENCTY='{formTimDN?.tenCty}'" : "") +
                (formTimDN?.msThue != null ? $"MASOTHUE='{formTimDN?.msThue}'" : "") +
                (formTimDN?.ngDaiDien != null ? $"NGDAIDIEN='{formTimDN?.ngDaiDien}'" : "") +
                (formTimDN?.diaChi != null ? $"DCHI='{formTimDN?.diaChi}''" : "") +
                (formTimDN?.email != null ? $"EMAIL='{formTimDN?.email}'" : "") +
                (formTimDN?.nvPhuTrach != null ? $"NVPHUTRACH='{formTimDN?.nvPhuTrach}'" : "") +
                (formTimDN?.ngayLap != null ? $"NGAYLAPHD=TO_DATE('{formTimDN?.ngayLap}', 'DD-MM-YYYY')" : "") +
                (formTimDN?.ngayHH != null ? $"NGAYHH=TO_DATE('{formTimDN?.ngayHH}', 'DD-MM-YYYY')" : "");

            ((DataTable)HopDongDNData.DataSource).DefaultView.RowFilter = string.Format(filter);*/
        }

        private void ThemDNButton_Click(object sender, EventArgs e)
        {
            formTimDN = new();
            formTimDN.FormClosedEvent += FormClosedEvent;
            formTimDN.Show();
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
    }
}
