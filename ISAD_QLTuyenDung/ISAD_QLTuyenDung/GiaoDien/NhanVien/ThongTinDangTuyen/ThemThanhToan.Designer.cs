namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ThongTinDangTuyen
{
    partial class ThemThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemThanhToan));
            panel1 = new Panel();
            HuyButton = new Button();
            DangKyButton = new Button();
            label4 = new Label();
            SoTienUpDown = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            PhuongThucTTCbo = new ComboBox();
            NgayTraDate = new DateTimePicker();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SoTienUpDown).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(HuyButton);
            panel1.Controls.Add(DangKyButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(SoTienUpDown);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(PhuongThucTTCbo);
            panel1.Controls.Add(NgayTraDate);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 403);
            panel1.TabIndex = 0;
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
            HuyButton.TabIndex = 61;
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
            DangKyButton.TabIndex = 60;
            DangKyButton.Text = "Lập";
            DangKyButton.UseVisualStyleBackColor = false;
            DangKyButton.Click += DangKyButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(66, 84);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 59;
            label4.Text = "Số tiền";
            // 
            // SoTienUpDown
            // 
            SoTienUpDown.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SoTienUpDown.Location = new Point(66, 110);
            SoTienUpDown.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            SoTienUpDown.Name = "SoTienUpDown";
            SoTienUpDown.Size = new Size(250, 30);
            SoTienUpDown.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(66, 224);
            label3.Name = "label3";
            label3.Size = new Size(201, 23);
            label3.TabIndex = 57;
            label3.Text = "Phương thức thanh toán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(66, 154);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 56;
            label2.Text = "Ngày trả";
            // 
            // PhuongThucTTCbo
            // 
            PhuongThucTTCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhuongThucTTCbo.FormattingEnabled = true;
            PhuongThucTTCbo.Items.AddRange(new object[] { "Trực tiếp", "Thông qua thẻ thanh toán" });
            PhuongThucTTCbo.Location = new Point(66, 250);
            PhuongThucTTCbo.Name = "PhuongThucTTCbo";
            PhuongThucTTCbo.Size = new Size(250, 31);
            PhuongThucTTCbo.TabIndex = 55;
            // 
            // NgayTraDate
            // 
            NgayTraDate.CustomFormat = "dd/MM/yyyy";
            NgayTraDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgayTraDate.Format = DateTimePickerFormat.Custom;
            NgayTraDate.Location = new Point(66, 180);
            NgayTraDate.Name = "NgayTraDate";
            NgayTraDate.Size = new Size(250, 30);
            NgayTraDate.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(108, 20);
            label1.Name = "label1";
            label1.Size = new Size(167, 38);
            label1.TabIndex = 7;
            label1.Text = "Thanh toán";
            // 
            // ThemThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 403);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ThemThanhToan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thanh Toán";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SoTienUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DateTimePicker NgayTraDate;
        private ComboBox PhuongThucTTCbo;
        private Label label3;
        private Label label2;
        private NumericUpDown SoTienUpDown;
        private Label label4;
        private Button HuyButton;
        private Button DangKyButton;
    }
}