namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung
{
    partial class LapDSHoSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LapDSHoSo));
            DanhSachHoSoData = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            LamMoiButton = new Button();
            label5 = new Label();
            MaNVDuyetCbo = new ComboBox();
            label3 = new Label();
            TinhTrangCbo = new ComboBox();
            label4 = new Label();
            GhiChuBox = new TextBox();
            label6 = new Label();
            DoUuTienUpDown = new NumericUpDown();
            label2 = new Label();
            MaPhieuCbo = new ComboBox();
            label7 = new Label();
            MaDNCbo = new ComboBox();
            HuyButton = new Button();
            LapDSButtion = new Button();
            ((System.ComponentModel.ISupportInitialize)DanhSachHoSoData).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DoUuTienUpDown).BeginInit();
            SuspendLayout();
            // 
            // DanhSachHoSoData
            // 
            DanhSachHoSoData.AllowUserToAddRows = false;
            DanhSachHoSoData.AllowUserToDeleteRows = false;
            DanhSachHoSoData.AllowUserToResizeColumns = false;
            DanhSachHoSoData.AllowUserToResizeRows = false;
            DanhSachHoSoData.BorderStyle = BorderStyle.None;
            DanhSachHoSoData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DanhSachHoSoData.Dock = DockStyle.Bottom;
            DanhSachHoSoData.Location = new Point(0, 253);
            DanhSachHoSoData.Name = "DanhSachHoSoData";
            DanhSachHoSoData.ReadOnly = true;
            DanhSachHoSoData.RowHeadersVisible = false;
            DanhSachHoSoData.RowHeadersWidth = 51;
            DanhSachHoSoData.Size = new Size(682, 400);
            DanhSachHoSoData.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(227, 10);
            label1.Name = "label1";
            label1.Size = new Size(229, 31);
            label1.TabIndex = 5;
            label1.Text = "Lập danh sách hồ sơ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(LamMoiButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(MaNVDuyetCbo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TinhTrangCbo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(GhiChuBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(DoUuTienUpDown);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(MaPhieuCbo);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(MaDNCbo);
            panel1.Controls.Add(DanhSachHoSoData);
            panel1.Controls.Add(HuyButton);
            panel1.Controls.Add(LapDSButtion);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 653);
            panel1.TabIndex = 6;
            // 
            // LamMoiButton
            // 
            LamMoiButton.BackColor = Color.LightSeaGreen;
            LamMoiButton.FlatAppearance.BorderSize = 0;
            LamMoiButton.FlatStyle = FlatStyle.Flat;
            LamMoiButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LamMoiButton.ForeColor = Color.White;
            LamMoiButton.Location = new Point(533, 126);
            LamMoiButton.Name = "LamMoiButton";
            LamMoiButton.Size = new Size(100, 40);
            LamMoiButton.TabIndex = 37;
            LamMoiButton.Text = "Làm mới";
            LamMoiButton.UseVisualStyleBackColor = false;
            LamMoiButton.Click += LamMoiButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(324, 106);
            label5.Name = "label5";
            label5.Size = new Size(165, 23);
            label5.TabIndex = 36;
            label5.Text = "Mã nhân viên duyệt";
            // 
            // MaNVDuyetCbo
            // 
            MaNVDuyetCbo.FormattingEnabled = true;
            MaNVDuyetCbo.Location = new Point(324, 132);
            MaNVDuyetCbo.Name = "MaNVDuyetCbo";
            MaNVDuyetCbo.Size = new Size(150, 28);
            MaNVDuyetCbo.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(49, 106);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 34;
            label3.Text = "Tình trạng";
            // 
            // TinhTrangCbo
            // 
            TinhTrangCbo.FormattingEnabled = true;
            TinhTrangCbo.Items.AddRange(new object[] { "Chưa đủ điều kiện ứng tuyển", "Đủ điều kiện ứng tuyển", "Đã xử lý", "Đã đạt" });
            TinhTrangCbo.Location = new Point(49, 132);
            TinhTrangCbo.Name = "TinhTrangCbo";
            TinhTrangCbo.Size = new Size(250, 28);
            TinhTrangCbo.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(49, 166);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 32;
            label4.Text = "Ghi chú";
            // 
            // GhiChuBox
            // 
            GhiChuBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GhiChuBox.Location = new Point(49, 192);
            GhiChuBox.Name = "GhiChuBox";
            GhiChuBox.PlaceholderText = "Ghi chú";
            GhiChuBox.Size = new Size(425, 30);
            GhiChuBox.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(232, 46);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 30;
            label6.Text = "Ưu tiên";
            // 
            // DoUuTienUpDown
            // 
            DoUuTienUpDown.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DoUuTienUpDown.Location = new Point(249, 72);
            DoUuTienUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            DoUuTienUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            DoUuTienUpDown.Name = "DoUuTienUpDown";
            DoUuTienUpDown.Size = new Size(50, 30);
            DoUuTienUpDown.TabIndex = 29;
            DoUuTienUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(324, 46);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 28;
            label2.Text = "Mã phiếu";
            // 
            // MaPhieuCbo
            // 
            MaPhieuCbo.FormattingEnabled = true;
            MaPhieuCbo.Location = new Point(324, 72);
            MaPhieuCbo.Name = "MaPhieuCbo";
            MaPhieuCbo.Size = new Size(150, 28);
            MaPhieuCbo.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightSeaGreen;
            label7.Location = new Point(49, 46);
            label7.Name = "label7";
            label7.Size = new Size(65, 23);
            label7.TabIndex = 26;
            label7.Text = "Mã DN";
            // 
            // MaDNCbo
            // 
            MaDNCbo.FormattingEnabled = true;
            MaDNCbo.Location = new Point(49, 72);
            MaDNCbo.Name = "MaDNCbo";
            MaDNCbo.Size = new Size(175, 28);
            MaDNCbo.TabIndex = 9;
            // 
            // HuyButton
            // 
            HuyButton.BackColor = Color.LightSeaGreen;
            HuyButton.FlatAppearance.BorderSize = 0;
            HuyButton.FlatStyle = FlatStyle.Flat;
            HuyButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HuyButton.ForeColor = Color.White;
            HuyButton.Location = new Point(533, 182);
            HuyButton.Name = "HuyButton";
            HuyButton.Size = new Size(100, 40);
            HuyButton.TabIndex = 8;
            HuyButton.Text = "Hủy";
            HuyButton.UseVisualStyleBackColor = false;
            HuyButton.Click += HuyButton_Click;
            // 
            // LapDSButtion
            // 
            LapDSButtion.BackColor = Color.LightSeaGreen;
            LapDSButtion.FlatAppearance.BorderSize = 0;
            LapDSButtion.FlatStyle = FlatStyle.Flat;
            LapDSButtion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LapDSButtion.ForeColor = Color.White;
            LapDSButtion.Location = new Point(533, 72);
            LapDSButtion.Name = "LapDSButtion";
            LapDSButtion.Size = new Size(100, 40);
            LapDSButtion.TabIndex = 7;
            LapDSButtion.Text = "Lập";
            LapDSButtion.UseVisualStyleBackColor = false;
            LapDSButtion.Click += LapDSButtion_Click;
            // 
            // LapDSHoSo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 653);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LapDSHoSo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách hồ sơ";
            Load += LapDSHoSo_Load;
            ((System.ComponentModel.ISupportInitialize)DanhSachHoSoData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DoUuTienUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DanhSachHoSoData;
        private Label label1;
        private Panel panel1;
        private Button LapDSButtion;
        private Button HuyButton;
        private ComboBox MaDNCbo;
        private Label label7;
        private Label label2;
        private ComboBox MaPhieuCbo;
        private Label label6;
        private NumericUpDown DoUuTienUpDown;
        private Label label4;
        private TextBox GhiChuBox;
        private ComboBox TinhTrangCbo;
        private Label label3;
        private Label label5;
        private ComboBox MaNVDuyetCbo;
        private Button LamMoiButton;
    }
}