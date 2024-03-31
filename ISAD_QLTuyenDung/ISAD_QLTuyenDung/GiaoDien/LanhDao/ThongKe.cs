using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    public partial class ThongKe : Form
    {
        private readonly string maDoanhNghiep;
        private OracleConnection conn;

        public ThongKe(string maDN, OracleConnection conn)
        {
            InitializeComponent();
            this.maDoanhNghiep = maDN;
            this.conn = conn;
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            maDN.Text = maDoanhNghiep;
            DoanhNghiepData.DataSource = NghiepVu.LanhDao.ThongKe.LoadThongKe(maDoanhNghiep, conn);
        }
    }
}
