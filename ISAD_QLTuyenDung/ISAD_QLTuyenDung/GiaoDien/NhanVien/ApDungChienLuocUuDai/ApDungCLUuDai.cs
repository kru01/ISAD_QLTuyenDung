using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ApDungChienLuocUuDai
{
    public partial class ApDungCLUuDai : Form
    {
        private readonly OracleConnection conn;

        public ApDungCLUuDai(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void ApDungCLUuDai_Load(object sender, EventArgs e)
        {

        }
    }
}
