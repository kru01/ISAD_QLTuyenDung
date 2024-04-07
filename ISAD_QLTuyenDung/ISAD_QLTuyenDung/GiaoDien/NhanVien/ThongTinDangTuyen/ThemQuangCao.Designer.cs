namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ThongTinDangTuyen
{
    partial class ThemQuangCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemQuangCao));
            label1 = new Label();
            panel1 = new Panel();
            HuyButton = new Button();
            DangKyButton = new Button();
            label3 = new Label();
            NgayKTDate = new DateTimePicker();
            label2 = new Label();
            NgayBDDate = new DateTimePicker();
            label10 = new Label();
            HinhThucDTCbo = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(56, 20);
            label1.Name = "label1";
            label1.Size = new Size(270, 38);
            label1.TabIndex = 6;
            label1.Text = "Đăng ký quảng cáo";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(HuyButton);
            panel1.Controls.Add(DangKyButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(NgayKTDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(NgayBDDate);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(HinhThucDTCbo);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 403);
            panel1.TabIndex = 7;
            // 
            // HuyButton
            // 
            HuyButton.BackColor = Color.LightSeaGreen;
            HuyButton.FlatAppearance.BorderSize = 0;
            HuyButton.FlatStyle = FlatStyle.Flat;
            HuyButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HuyButton.ForeColor = Color.White;
            HuyButton.Location = new Point(201, 300);
            HuyButton.Name = "HuyButton";
            HuyButton.Size = new Size(115, 40);
            HuyButton.TabIndex = 57;
            HuyButton.Text = "Hủy";
            HuyButton.UseVisualStyleBackColor = false;
            HuyButton.Click += HuyButton_Click;
            // 
            // DangKyButton
            // 
            DangKyButton.BackColor = Color.LightSeaGreen;
            DangKyButton.FlatAppearance.BorderSize = 0;
            DangKyButton.FlatStyle = FlatStyle.Flat;
            DangKyButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DangKyButton.ForeColor = Color.White;
            DangKyButton.Location = new Point(66, 300);
            DangKyButton.Name = "DangKyButton";
            DangKyButton.Size = new Size(115, 40);
            DangKyButton.TabIndex = 8;
            DangKyButton.Text = "Đăng ký";
            DangKyButton.UseVisualStyleBackColor = false;
            DangKyButton.Click += DangKyButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(66, 224);
            label3.Name = "label3";
            label3.Size = new Size(119, 23);
            label3.TabIndex = 56;
            label3.Text = "Ngày kết thúc";
            // 
            // NgayKTDate
            // 
            NgayKTDate.CustomFormat = "dd/MM/yyyy";
            NgayKTDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgayKTDate.Format = DateTimePickerFormat.Custom;
            NgayKTDate.Location = new Point(66, 250);
            NgayKTDate.Name = "NgayKTDate";
            NgayKTDate.Size = new Size(250, 30);
            NgayKTDate.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(66, 154);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 54;
            label2.Text = "Ngày bắt đầu";
            // 
            // NgayBDDate
            // 
            NgayBDDate.CustomFormat = "dd/MM/yyyy";
            NgayBDDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgayBDDate.Format = DateTimePickerFormat.Custom;
            NgayBDDate.Location = new Point(66, 180);
            NgayBDDate.Name = "NgayBDDate";
            NgayBDDate.Size = new Size(250, 30);
            NgayBDDate.TabIndex = 53;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.LightSeaGreen;
            label10.Location = new Point(66, 84);
            label10.Name = "label10";
            label10.Size = new Size(180, 23);
            label10.TabIndex = 52;
            label10.Text = "Hình thức đăng tuyển";
            // 
            // HinhThucDTCbo
            // 
            HinhThucDTCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HinhThucDTCbo.FormattingEnabled = true;
            HinhThucDTCbo.Items.AddRange(new object[] { "Đăng tuyển trên báo giấy", "Đăng banner quảng cáo", "Đăng trên các trang mạng" });
            HinhThucDTCbo.Location = new Point(66, 110);
            HinhThucDTCbo.Name = "HinhThucDTCbo";
            HinhThucDTCbo.Size = new Size(250, 31);
            HinhThucDTCbo.TabIndex = 51;
            // 
            // ThemQuangCao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 403);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ThemQuangCao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm quảng cáo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ComboBox HinhThucDTCbo;
        private Label label10;
        private Label label3;
        private DateTimePicker NgayKTDate;
        private Label label2;
        private DateTimePicker NgayBDDate;
        private Button HuyButton;
        private Button DangKyButton;
    }
}