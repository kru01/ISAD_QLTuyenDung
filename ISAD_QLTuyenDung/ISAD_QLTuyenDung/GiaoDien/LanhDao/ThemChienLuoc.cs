using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    public partial class ThemChienLuoc : Form
    {
        private readonly OracleConnection conn;
        public event EventHandler? FormClosedEvent;
        private readonly string curUser;

        public ThemChienLuoc(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.curUser = curUser;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát khỏi thêm chiến lược?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!NghiepVu.LanhDao.ThemChienLuoc.KiemTraThemChienLuoc(curUser, TenChienLuoc.Text, MoTa.Text, conn))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                MessageBox.Show("Thêm đánh giá thành công!");
                FormClosedEvent?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }
    }
}
