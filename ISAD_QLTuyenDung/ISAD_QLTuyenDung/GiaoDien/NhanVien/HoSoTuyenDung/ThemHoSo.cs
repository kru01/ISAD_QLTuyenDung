using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung
{
    public partial class ThemHoSo : Form
    {
        public event EventHandler? FormClosedEvent;
        private readonly OracleConnection conn;
        private readonly string curUser;
        readonly List<string> thongTinGiayTo = [];
        readonly List<int> loaiGiayTo = [];
        internal HoSoUngTuyen? hoso;

        private int YNextCbo = 104;
        private int YNextTextBox = 104;
        private int soGiayTo = 1;
        private readonly string[] loaiGT = ["-- Chọn loại giấy tờ --", "Sơ yếu lý lịch", "Đơn xin việc", "CV xin việc", "Sổ hộ khẩu (Bản sao công chứng)", "Căn cước công dân (Bản sao công chứng)", "Giấy khai sinh (Bản sao công chứng)", "Giấy khám sức khỏe (Dưới 6 tháng)", "Ảnh thẻ hồ sơ (3x4 hoặc 4x6)", "Chứng chỉ liên quan"];

        private void ThemSoGiayTo()
        {
            if (soGiayTo <= 9)
            {
                ComboBox comboBox = new()
                {
                    Location = new Point(511, YNextCbo),
                    Size = new Size(300, 28)
                };
                comboBox.Items.AddRange(loaiGT);
                comboBox.SelectedIndex = 0;
                comboBox.Name = $"GiayTo{soGiayTo}";
                Controls.Add(comboBox);
                YNextCbo += 34;

                TextBox textBox = new()
                {
                    Location = new Point(817, YNextTextBox),
                    Size = new Size(300, 27)
                };
                Controls.Add(textBox);
                textBox.Name = $"ThongTin{soGiayTo}";
                textBox.PlaceholderText = "Thông tin giấy tờ";
                YNextTextBox += 34;

                soGiayTo++;
                panel1.SendToBack();
            }
            else MessageBox.Show("Số giấy tờ đã đạt tối đa!");
        }

        public ThemHoSo(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.conn = conn;
        }

        private void ThemHoSo_Load(object sender, EventArgs e)
        {
            maUV.DisplayMember = "MAUV";
            maUV.ValueMember = "MAUV";
            maUV.DataSource = HoSoUngTuyen.LoadMaUngVien(conn).Tables[0];

            maPhieu.DisplayMember = "MAPHIEU";
            maPhieu.ValueMember = "MAPHIEU";
            maPhieu.DataSource = HoSoUngTuyen.LoadMaPhieu(conn).Tables[0];

            maDN.DisplayMember = "MADN";
            maDN.ValueMember = "MADN";
            maDN.DataSource = HoSoUngTuyen.LoadMaDN(conn).Tables[0];

            tinhTrang.SelectedIndex = 0;
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= soGiayTo; i++)
            {
                if (Controls.Find($"ThongTin{i}", true).FirstOrDefault() is TextBox textBox && Controls.Find($"GiayTo{i}", true).FirstOrDefault() is ComboBox comboBox)
                {
                    thongTinGiayTo.Add(textBox.Text);
                    loaiGiayTo.Add(comboBox.SelectedIndex);
                }
            }

            string[] thongTinGT = [.. thongTinGiayTo];
            int[] loaiGT = [.. loaiGiayTo];

            hoso = new(maUV.Text, maDN.Text, maPhieu.Text, (int)doUuTien.Value, ghiChu.Text, tinhTrang.SelectedIndex, curUser, thongTinGT, loaiGT);
            try
            {
                if (!HoSoUngTuyen.ThemHoSo(ref hoso, conn))
                {
                    MessageBox.Show("Vui lòng chọn tình trạng hồ sơ!");
                }
                else
                {
                    MessageBox.Show("Thêm hồ sơ thành công!");
                    FormClosedEvent?.Invoke(this, EventArgs.Empty);
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
            var res = MessageBox.Show("Bạn có chắc là muốn thoát khỏi thêm hồ sơ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void ThemGiayToButton_Click(object sender, EventArgs e)
        {
            ThemSoGiayTo();
        }
    }
}
