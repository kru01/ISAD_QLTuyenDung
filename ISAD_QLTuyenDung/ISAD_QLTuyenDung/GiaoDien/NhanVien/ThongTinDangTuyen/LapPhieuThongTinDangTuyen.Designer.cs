namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ThongTinDangTuyen
{
    partial class LapPhieuThongTinDangTuyen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            label9 = new Label();
            tongTien = new TextBox();
            tienDaTra = new TextBox();
            label8 = new Label();
            ngayKetThuc = new DateTimePicker();
            label7 = new Label();
            LamMoiButton = new Button();
            ngayBatDau = new DateTimePicker();
            ThemPhieuButton = new Button();
            label6 = new Label();
            hinhThucTT = new TextBox();
            label4 = new Label();
            yeuCau = new TextBox();
            vitriUT = new TextBox();
            label3 = new Label();
            label1 = new Label();
            maDN = new TextBox();
            label5 = new Label();
            maPhieu = new TextBox();
            PhieuTTDTData = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PhieuTTDTData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(PhieuTTDTData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(295, 11);
            label2.Name = "label2";
            label2.Size = new Size(310, 31);
            label2.TabIndex = 9;
            label2.Text = "Phiếu thông tin đăng tuyển";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(tongTien);
            panel3.Controls.Add(tienDaTra);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(ngayKetThuc);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(LamMoiButton);
            panel3.Controls.Add(ngayBatDau);
            panel3.Controls.Add(ThemPhieuButton);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(hinhThucTT);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(yeuCau);
            panel3.Controls.Add(vitriUT);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(maDN);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(maPhieu);
            panel3.Location = new Point(12, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(876, 266);
            panel3.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.LightSeaGreen;
            label10.Location = new Point(663, 101);
            label10.Name = "label10";
            label10.Size = new Size(92, 23);
            label10.TabIndex = 30;
            label10.Text = "Tiền đã trả";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LightSeaGreen;
            label9.Location = new Point(461, 102);
            label9.Name = "label9";
            label9.Size = new Size(83, 23);
            label9.TabIndex = 29;
            label9.Text = "Tổng tiền";
            // 
            // tongTien
            // 
            tongTien.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tongTien.Location = new Point(461, 128);
            tongTien.Name = "tongTien";
            tongTien.PlaceholderText = "Tổng tiền";
            tongTien.ReadOnly = true;
            tongTien.Size = new Size(150, 30);
            tongTien.TabIndex = 28;
            // 
            // tienDaTra
            // 
            tienDaTra.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tienDaTra.Location = new Point(663, 128);
            tienDaTra.Name = "tienDaTra";
            tienDaTra.PlaceholderText = "Tiền đã trả";
            tienDaTra.ReadOnly = true;
            tienDaTra.Size = new Size(150, 30);
            tienDaTra.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LightSeaGreen;
            label8.Location = new Point(266, 102);
            label8.Name = "label8";
            label8.Size = new Size(119, 23);
            label8.TabIndex = 26;
            label8.Text = "Ngày kết thúc";
            // 
            // ngayKetThuc
            // 
            ngayKetThuc.CustomFormat = "dd/MM/yyyy";
            ngayKetThuc.Enabled = false;
            ngayKetThuc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngayKetThuc.Format = DateTimePickerFormat.Custom;
            ngayKetThuc.Location = new Point(266, 128);
            ngayKetThuc.Name = "ngayKetThuc";
            ngayKetThuc.Size = new Size(150, 30);
            ngayKetThuc.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightSeaGreen;
            label7.Location = new Point(62, 102);
            label7.Name = "label7";
            label7.Size = new Size(115, 23);
            label7.TabIndex = 24;
            label7.Text = "Ngày bắt đầu";
            // 
            // LamMoiButton
            // 
            LamMoiButton.BackColor = Color.LightSeaGreen;
            LamMoiButton.FlatAppearance.BorderSize = 0;
            LamMoiButton.FlatStyle = FlatStyle.Flat;
            LamMoiButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LamMoiButton.ForeColor = Color.White;
            LamMoiButton.Location = new Point(713, 178);
            LamMoiButton.Name = "LamMoiButton";
            LamMoiButton.Size = new Size(100, 40);
            LamMoiButton.TabIndex = 23;
            LamMoiButton.Text = "Làm mới";
            LamMoiButton.UseVisualStyleBackColor = false;
            LamMoiButton.Click += LamMoiButton_Click;
            // 
            // ngayBatDau
            // 
            ngayBatDau.CustomFormat = "dd/MM/yyyy";
            ngayBatDau.Enabled = false;
            ngayBatDau.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngayBatDau.Format = DateTimePickerFormat.Custom;
            ngayBatDau.Location = new Point(62, 128);
            ngayBatDau.Name = "ngayBatDau";
            ngayBatDau.Size = new Size(150, 30);
            ngayBatDau.TabIndex = 23;
            // 
            // ThemPhieuButton
            // 
            ThemPhieuButton.BackColor = Color.LightSeaGreen;
            ThemPhieuButton.FlatAppearance.BorderSize = 0;
            ThemPhieuButton.FlatStyle = FlatStyle.Flat;
            ThemPhieuButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemPhieuButton.ForeColor = Color.White;
            ThemPhieuButton.Location = new Point(577, 178);
            ThemPhieuButton.Name = "ThemPhieuButton";
            ThemPhieuButton.Size = new Size(130, 40);
            ThemPhieuButton.TabIndex = 6;
            ThemPhieuButton.Text = "Thêm phiếu";
            ThemPhieuButton.UseVisualStyleBackColor = false;
            ThemPhieuButton.Click += ThemPhieuButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(636, 42);
            label6.Name = "label6";
            label6.Size = new Size(177, 23);
            label6.TabIndex = 22;
            label6.Text = "Hình thức thanh toán";
            // 
            // hinhThucTT
            // 
            hinhThucTT.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hinhThucTT.Location = new Point(663, 68);
            hinhThucTT.Name = "hinhThucTT";
            hinhThucTT.PlaceholderText = "Hình thức thanh toán";
            hinhThucTT.ReadOnly = true;
            hinhThucTT.Size = new Size(150, 30);
            hinhThucTT.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(62, 162);
            label4.Name = "label4";
            label4.Size = new Size(142, 23);
            label4.TabIndex = 20;
            label4.Text = "Yêu cầu ứng viên";
            // 
            // yeuCau
            // 
            yeuCau.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yeuCau.Location = new Point(62, 188);
            yeuCau.Name = "yeuCau";
            yeuCau.PlaceholderText = "Yêu cầu ứng viên";
            yeuCau.ReadOnly = true;
            yeuCau.Size = new Size(475, 30);
            yeuCau.TabIndex = 19;
            // 
            // vitriUT
            // 
            vitriUT.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vitriUT.Location = new Point(361, 68);
            vitriUT.Name = "vitriUT";
            vitriUT.PlaceholderText = "Vị trí ứng tuyển";
            vitriUT.ReadOnly = true;
            vitriUT.Size = new Size(250, 30);
            vitriUT.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(361, 42);
            label3.Name = "label3";
            label3.Size = new Size(131, 23);
            label3.TabIndex = 17;
            label3.Text = "Vị trí ứng tuyển";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(62, 42);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 16;
            label1.Text = "Mã DN";
            // 
            // maDN
            // 
            maDN.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maDN.Location = new Point(62, 68);
            maDN.Name = "maDN";
            maDN.PlaceholderText = "Mã DN";
            maDN.ReadOnly = true;
            maDN.Size = new Size(100, 30);
            maDN.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(211, 42);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 14;
            label5.Text = "Mã phiếu";
            // 
            // maPhieu
            // 
            maPhieu.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maPhieu.Location = new Point(211, 68);
            maPhieu.Name = "maPhieu";
            maPhieu.PlaceholderText = "Mã Phiếu";
            maPhieu.ReadOnly = true;
            maPhieu.Size = new Size(100, 30);
            maPhieu.TabIndex = 13;
            // 
            // PhieuTTDTData
            // 
            PhieuTTDTData.AllowUserToAddRows = false;
            PhieuTTDTData.AllowUserToDeleteRows = false;
            PhieuTTDTData.AllowUserToResizeColumns = false;
            PhieuTTDTData.AllowUserToResizeRows = false;
            PhieuTTDTData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            PhieuTTDTData.BorderStyle = BorderStyle.None;
            PhieuTTDTData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PhieuTTDTData.Dock = DockStyle.Bottom;
            PhieuTTDTData.Location = new Point(0, 300);
            PhieuTTDTData.Name = "PhieuTTDTData";
            PhieuTTDTData.ReadOnly = true;
            PhieuTTDTData.RowHeadersVisible = false;
            PhieuTTDTData.RowHeadersWidth = 51;
            PhieuTTDTData.Size = new Size(900, 400);
            PhieuTTDTData.TabIndex = 10;
            PhieuTTDTData.CellClick += PhieuTTDTData_CellClick;
            // 
            // LapPhieuThongTinDangTuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LapPhieuThongTinDangTuyen";
            Text = "LapPhieuThongTinDangTuyen";
            Load += LapPhieuThongTinDangTuyen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PhieuTTDTData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private Button LamMoiButton;
        private Label label6;
        private TextBox hinhThucTT;
        private Label label4;
        private TextBox yeuCau;
        private TextBox vitriUT;
        private Label label3;
        private Label label1;
        private TextBox maDN;
        private Label label5;
        private TextBox maPhieu;
        private Button ThemPhieuButton;
        private DataGridView PhieuTTDTData;
        private DateTimePicker ngayBatDau;
        private Label label8;
        private DateTimePicker ngayKetThuc;
        private Label label7;
        private Label label10;
        private Label label9;
        private TextBox tongTien;
        private TextBox tienDaTra;
    }
}