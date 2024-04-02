using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;

namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    public partial class ThongKeDoanhNghiep : Form
    {
        readonly string maDoanhNghiep;
        readonly OracleConnection conn;

        public ThongKeDoanhNghiep(string maDN, OracleConnection conn)
        {
            InitializeComponent();
            this.maDoanhNghiep = maDN;
            this.conn = conn;
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            maDN.Text = maDoanhNghiep;
            DoanhNghiepData.DataSource = DNTiemNang.LoadThongKe(maDoanhNghiep, conn);
        }
    }
}
