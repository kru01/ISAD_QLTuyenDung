namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ThongTinDangTuyen
{
    partial class ThemPhieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemPhieu));
            panel1 = new Panel();
            label5 = new Label();
            soLuong = new NumericUpDown();
            HuyButton = new Button();
            viTri = new ComboBox();
            tongTien = new NumericUpDown();
            label10 = new Label();
            hinhThucTT = new ComboBox();
            maDN = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            ngayKetThuc = new DateTimePicker();
            label7 = new Label();
            ngayBatDau = new DateTimePicker();
            label4 = new Label();
            yeuCau = new TextBox();
            label3 = new Label();
            label2 = new Label();
            LapButton = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)soLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tongTien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(soLuong);
            panel1.Controls.Add(HuyButton);
            panel1.Controls.Add(viTri);
            panel1.Controls.Add(tongTien);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(hinhThucTT);
            panel1.Controls.Add(maDN);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(ngayKetThuc);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(ngayBatDau);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(yeuCau);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(LapButton);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 453);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(342, 94);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 56;
            label5.Text = "Số lượng";
            // 
            // soLuong
            // 
            soLuong.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            soLuong.Location = new Point(342, 120);
            soLuong.Name = "soLuong";
            soLuong.Size = new Size(75, 30);
            soLuong.TabIndex = 55;
            // 
            // HuyButton
            // 
            HuyButton.BackColor = Color.LightSeaGreen;
            HuyButton.FlatAppearance.BorderSize = 0;
            HuyButton.FlatStyle = FlatStyle.Flat;
            HuyButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HuyButton.ForeColor = Color.White;
            HuyButton.Location = new Point(342, 365);
            HuyButton.Name = "HuyButton";
            HuyButton.Size = new Size(200, 50);
            HuyButton.TabIndex = 54;
            HuyButton.Text = "Hủy";
            HuyButton.UseVisualStyleBackColor = false;
            HuyButton.Click += HuyButton_Click;
            // 
            // viTri
            // 
            viTri.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viTri.FormattingEnabled = true;
            viTri.Location = new Point(192, 120);
            viTri.Name = "viTri";
            viTri.Size = new Size(125, 31);
            viTri.TabIndex = 53;
            // 
            // tongTien
            // 
            tongTien.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tongTien.Location = new Point(442, 121);
            tongTien.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            tongTien.Name = "tongTien";
            tongTien.Size = new Size(100, 30);
            tongTien.TabIndex = 52;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.LightSeaGreen;
            label10.Location = new Point(342, 184);
            label10.Name = "label10";
            label10.Size = new Size(177, 23);
            label10.TabIndex = 51;
            label10.Text = "Hình thức thanh toán";
            // 
            // hinhThucTT
            // 
            hinhThucTT.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hinhThucTT.FormattingEnabled = true;
            hinhThucTT.Items.AddRange(new object[] { "Thanh toán toàn bộ", "Thanh toán theo đợt" });
            hinhThucTT.Location = new Point(342, 209);
            hinhThucTT.Name = "hinhThucTT";
            hinhThucTT.Size = new Size(200, 31);
            hinhThucTT.TabIndex = 50;
            // 
            // maDN
            // 
            maDN.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maDN.FormattingEnabled = true;
            maDN.Location = new Point(41, 120);
            maDN.Name = "maDN";
            maDN.Size = new Size(125, 31);
            maDN.TabIndex = 48;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LightSeaGreen;
            label9.Location = new Point(442, 94);
            label9.Name = "label9";
            label9.Size = new Size(83, 23);
            label9.TabIndex = 47;
            label9.Text = "Tổng tiền";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LightSeaGreen;
            label8.Location = new Point(192, 184);
            label8.Name = "label8";
            label8.Size = new Size(119, 23);
            label8.TabIndex = 44;
            label8.Text = "Ngày kết thúc";
            // 
            // ngayKetThuc
            // 
            ngayKetThuc.CustomFormat = "dd/MM/yyyy";
            ngayKetThuc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngayKetThuc.Format = DateTimePickerFormat.Custom;
            ngayKetThuc.Location = new Point(192, 210);
            ngayKetThuc.Name = "ngayKetThuc";
            ngayKetThuc.Size = new Size(125, 30);
            ngayKetThuc.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightSeaGreen;
            label7.Location = new Point(42, 184);
            label7.Name = "label7";
            label7.Size = new Size(115, 23);
            label7.TabIndex = 42;
            label7.Text = "Ngày bắt đầu";
            // 
            // ngayBatDau
            // 
            ngayBatDau.CustomFormat = "dd/MM/yyyy";
            ngayBatDau.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngayBatDau.Format = DateTimePickerFormat.Custom;
            ngayBatDau.Location = new Point(42, 210);
            ngayBatDau.Name = "ngayBatDau";
            ngayBatDau.Size = new Size(125, 30);
            ngayBatDau.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(42, 274);
            label4.Name = "label4";
            label4.Size = new Size(142, 23);
            label4.TabIndex = 38;
            label4.Text = "Yêu cầu ứng viên";
            // 
            // yeuCau
            // 
            yeuCau.CharacterCasing = CharacterCasing.Upper;
            yeuCau.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yeuCau.Location = new Point(42, 300);
            yeuCau.Name = "yeuCau";
            yeuCau.Size = new Size(500, 30);
            yeuCau.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(192, 94);
            label3.Name = "label3";
            label3.Size = new Size(131, 23);
            label3.TabIndex = 35;
            label3.Text = "Vị trí ứng tuyển";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(42, 94);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 34;
            label2.Text = "Mã DN";
            // 
            // LapButton
            // 
            LapButton.BackColor = Color.LightSeaGreen;
            LapButton.FlatAppearance.BorderSize = 0;
            LapButton.FlatStyle = FlatStyle.Flat;
            LapButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LapButton.ForeColor = Color.White;
            LapButton.Location = new Point(41, 365);
            LapButton.Name = "LapButton";
            LapButton.Size = new Size(200, 50);
            LapButton.TabIndex = 7;
            LapButton.Text = "Lập";
            LapButton.UseVisualStyleBackColor = false;
            LapButton.Click += LapButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(126, 25);
            label1.Name = "label1";
            label1.Size = new Size(331, 38);
            label1.TabIndex = 5;
            label1.Text = "Thêm phiếu đăng tuyển";
            // 
            // ThemPhieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 453);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ThemPhieu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm phiếu thông tin đăng tuyển";
            Load += ThemPhieu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)soLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)tongTien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button LapButton;
        private Label label9;
        private Label label8;
        private DateTimePicker ngayKetThuc;
        private Label label7;
        private DateTimePicker ngayBatDau;
        private Label label4;
        private TextBox yeuCau;
        private Label label3;
        private Label label2;
        private ComboBox hinhThucTT;
        private ComboBox maDN;
        private Button HuyButton;
        private ComboBox viTri;
        private NumericUpDown tongTien;
        private Label label10;
        private Label label5;
        private NumericUpDown soLuong;
    }
}