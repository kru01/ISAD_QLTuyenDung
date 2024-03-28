using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.HoTro;
using ISAD_QLTuyenDung.NghiepVu.LanhDao;

namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    public partial class LanhDaoForm : Form
    {
        private readonly string curUser;
        private readonly string conn;

        public LanhDaoForm(string curUser, string conn)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.conn = conn;
        }

        private void LanhDaoForm_Load(object sender, EventArgs e)
        {
        }

        private void DanhGiaDNButton_Click(object sender, EventArgs e)
        {
            Helper.Loadform(new DanhGiaTiemNang(), mainPanel);
        }

        private void QuanLyUDButton_Click(object sender, EventArgs e)
        {
            Helper.Loadform(new DeXuatCLUuDai(), mainPanel);
        }

        private void DangXuatButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn đăng xuất?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Hide();
                new Login().ShowDialog();
                this.Close();
            }
        }
    }
}
