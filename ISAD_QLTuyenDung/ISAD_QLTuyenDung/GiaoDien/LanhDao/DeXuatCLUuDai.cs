using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    public partial class DeXuatCLUuDai : Form
    {
        private static ThemChienLuoc? f;
        private readonly OracleConnection conn;
        private readonly string curUser;

        public DeXuatCLUuDai(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.curUser = curUser;
        }

        private void DeXuatCLUuDai_Load(object sender, EventArgs e)
        {
            ChienLuocData.DataSource = NghiepVu.LanhDao.DeXuatCLUuDai.LoadChienLuoc(conn);
        }

        private void ThemChienLuocButton_Click(object sender, EventArgs e)
        {
            f = new(curUser, conn);
            f.FormClosedEvent += FormClosedEvent;
            f.Show();
        }

        private void FormClosedEvent(object? sender, EventArgs e)
        {
            ChienLuocData.DataSource = NghiepVu.LanhDao.DeXuatCLUuDai.LoadChienLuoc(conn);
        }

        private void ChienLuocData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == ChienLuocData.RowCount) return;
            DataGridViewRow cRow = ChienLuocData.Rows[e.RowIndex];

            moTa.Text = cRow.Cells["MOTA"].Value.ToString();
            tenLD.Text = cRow.Cells["HOTEN"].Value.ToString();
            tenCL.Text = cRow.Cells["TENCL"].Value.ToString();
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            ChienLuocData.DataSource = NghiepVu.LanhDao.DeXuatCLUuDai.LoadChienLuoc(conn);
        }
    }
}
