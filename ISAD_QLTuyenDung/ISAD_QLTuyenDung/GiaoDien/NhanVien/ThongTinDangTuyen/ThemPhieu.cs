using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ThongTinDangTuyen
{
    public partial class ThemPhieu : Form
    {
        public event EventHandler? FormClosedEvent;
        private readonly OracleConnection conn;
        private readonly string curUser;
        internal PTTDangTuyen? phieu;
        static ThemQuangCao? formQC;

        public ThemPhieu(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.conn = conn;
        }

        private void ThemPhieu_Load(object sender, EventArgs e)
        {
            maDN.DisplayMember = "MADN";
            maDN.ValueMember = "MADN";
            maDN.DataSource = PTTDangTuyen.LoadMaDN(conn).Tables[0];

            viTri.DisplayMember = "VITRIUT";
            viTri.ValueMember = "VITRIUT";
            viTri.DataSource = PTTDangTuyen.LoadViTriUT(conn).Tables[0];
        }

        private void LapButton_Click(object sender, EventArgs e)
        {
            phieu = new(maDN.Text, viTri.Text, (int)soLuong.Value, ngayBatDau.Text, ngayKetThuc.Text, yeuCau.Text, (int)tongTien.Value, hinhThucTT.SelectedIndex + 1, curUser);
            try
            {
                if (!PTTDangTuyen.ThemPhieu(ref phieu, conn))
                {
                    MessageBox.Show("Cần nhập yêu cầu ứng tuyển!");
                }
                else
                {
                    MessageBox.Show("Thêm phiếu đăng tuyển thành công!");
                    FormClosedEvent?.Invoke(this, EventArgs.Empty);
                    formQC = new(conn, maDN.Text, phieu.maPhieu);
                    formQC.Show();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát lập phiếu?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
