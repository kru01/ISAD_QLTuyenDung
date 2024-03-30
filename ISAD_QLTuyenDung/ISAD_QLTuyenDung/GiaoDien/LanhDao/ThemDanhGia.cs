using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.HoTro;

namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    public partial class ThemDanhGia : Form
    {
        private readonly OracleConnection conn;
        public event EventHandler? FormClosedEvent;
        private readonly string curUser;

        public ThemDanhGia(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.curUser = curUser;
        }

        private void ThemDanhGia_Load(object sender, EventArgs e)
        {
            String sql = $"SELECT MADN, TENCTY FROM {OracleConfig.schema}.DOANHNGHIEP ORDER BY MADN";

            idCbo.DisplayMember = "TENCTY";
            idCbo.ValueMember = "MADN";
            idCbo.DataSource = NghiepVu.LanhDao.ThemDanhGia.ThemIDDoanhNghiep(sql, conn).Tables[0];
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát khỏi thêm đánh giá?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string? id = idCbo?.SelectedValue?.ToString();

            if (!NghiepVu.LanhDao.ThemDanhGia.KiemTraThemDanhGia(id, curUser, (int)ratingBox.Value, NoteBox.Text, conn))
            {
                MessageBox.Show("Tiềm năng phải nằm trong khoảng từ 1 đến 10!");
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
