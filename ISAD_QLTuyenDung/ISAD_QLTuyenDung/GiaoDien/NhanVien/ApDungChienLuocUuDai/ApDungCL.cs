using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ApDungChienLuocUuDai
{
    public partial class ApDungCL : Form
    {
        public event EventHandler? FormClosedEvent;
        private readonly OracleConnection conn;
        internal CLApDung? clApDung;

        public ApDungCL(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void ApDungCL_Load(object sender, EventArgs e)
        {
            MaDNCbo.DisplayMember = "MADN";
            MaDNCbo.ValueMember = "MADN";
            MaDNCbo.DataSource = DoanhNghiep.LoadTenDoanhNghiep(conn).Tables[0];

            MaCLCbo.DisplayMember = "MACL";
            MaCLCbo.ValueMember = "MACL";
            MaCLCbo.DataSource = ChienLuocUuDai.LoadMaCL(conn).Tables[0];
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát áp dụng chiến lược ưu đãi?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void LapButton_Click(object sender, EventArgs e)
        {
            clApDung = new(MaDNCbo.Text, MaCLCbo.Text, NgayBDDate.Text, NgayKTDate.Text);
            try
            {
                CLApDung.ThemCLApDung(ref clApDung, conn);
                MessageBox.Show("Áp dụng chiến lược ưu đãi thành công!");
                FormClosedEvent?.Invoke(this, EventArgs.Empty);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NgayBDDate_ValueChanged(object sender, EventArgs e)
        {
            if (NgayBDDate.Value >= NgayKTDate.Value.AddDays(-1))
                NgayKTDate.Value = NgayBDDate.Value.AddDays(1);
        }

        private void NgayKTDate_ValueChanged(object sender, EventArgs e)
        {
            if (NgayKTDate.Value <= NgayBDDate.Value.AddDays(1))
                NgayBDDate.Value = NgayKTDate.Value.AddDays(-1);
        }
    }
}
