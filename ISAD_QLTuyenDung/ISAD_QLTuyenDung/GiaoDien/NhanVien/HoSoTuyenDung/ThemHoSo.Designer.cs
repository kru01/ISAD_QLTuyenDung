namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung
{
    partial class ThemHoSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemHoSo));
            panel1 = new Panel();
            HuyButton = new Button();
            ThemButton = new Button();
            label6 = new Label();
            doUuTien = new NumericUpDown();
            label5 = new Label();
            tinhTrang = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            maPhieu = new ComboBox();
            maUV = new ComboBox();
            label3 = new Label();
            ghiChu = new TextBox();
            label1 = new Label();
            maDN = new ComboBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doUuTien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(maDN);
            panel1.Controls.Add(HuyButton);
            panel1.Controls.Add(ThemButton);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(doUuTien);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tinhTrang);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(maPhieu);
            panel1.Controls.Add(maUV);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ghiChu);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 453);
            panel1.TabIndex = 0;
            // 
            // HuyButton
            // 
            HuyButton.BackColor = Color.LightSeaGreen;
            HuyButton.FlatAppearance.BorderSize = 0;
            HuyButton.FlatStyle = FlatStyle.Flat;
            HuyButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HuyButton.ForeColor = Color.White;
            HuyButton.Location = new Point(266, 360);
            HuyButton.Name = "HuyButton";
            HuyButton.Size = new Size(175, 40);
            HuyButton.TabIndex = 23;
            HuyButton.Text = "Hủy";
            HuyButton.UseVisualStyleBackColor = false;
            HuyButton.Click += HuyButton_Click;
            // 
            // ThemButton
            // 
            ThemButton.BackColor = Color.LightSeaGreen;
            ThemButton.FlatAppearance.BorderSize = 0;
            ThemButton.FlatStyle = FlatStyle.Flat;
            ThemButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemButton.ForeColor = Color.White;
            ThemButton.Location = new Point(41, 360);
            ThemButton.Name = "ThemButton";
            ThemButton.Size = new Size(175, 40);
            ThemButton.TabIndex = 11;
            ThemButton.Text = "Thêm";
            ThemButton.UseVisualStyleBackColor = false;
            ThemButton.Click += ThemButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(391, 175);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 22;
            label6.Text = "Ưu tiên";
            // 
            // doUuTien
            // 
            doUuTien.Location = new Point(391, 201);
            doUuTien.Name = "doUuTien";
            doUuTien.Size = new Size(50, 27);
            doUuTien.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(215, 79);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 20;
            label5.Text = "Tình trạng";
            // 
            // tinhTrang
            // 
            tinhTrang.FormattingEnabled = true;
            tinhTrang.Items.AddRange(new object[] { "Chưa đủ điều kiện", "Đủ điều kiện", "Đã xử lý", "Đã đạt" });
            tinhTrang.Location = new Point(215, 105);
            tinhTrang.Name = "tinhTrang";
            tinhTrang.Size = new Size(226, 28);
            tinhTrang.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(41, 264);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 14;
            label2.Text = "Ghi chú";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(41, 175);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 18;
            label4.Text = "Mã phiếu";
            // 
            // maPhieu
            // 
            maPhieu.FormattingEnabled = true;
            maPhieu.Location = new Point(41, 200);
            maPhieu.Name = "maPhieu";
            maPhieu.Size = new Size(150, 28);
            maPhieu.TabIndex = 17;
            // 
            // maUV
            // 
            maUV.FormattingEnabled = true;
            maUV.Location = new Point(41, 105);
            maUV.Name = "maUV";
            maUV.Size = new Size(150, 28);
            maUV.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(41, 79);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 15;
            label3.Text = "Mã ứng viên";
            // 
            // ghiChu
            // 
            ghiChu.Location = new Point(41, 290);
            ghiChu.Name = "ghiChu";
            ghiChu.Size = new Size(400, 27);
            ghiChu.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(156, 20);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 4;
            label1.Text = "Thêm hồ sơ";
            // 
            // maDN
            // 
            maDN.FormattingEnabled = true;
            maDN.Location = new Point(215, 200);
            maDN.Name = "maDN";
            maDN.Size = new Size(150, 28);
            maDN.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightSeaGreen;
            label7.Location = new Point(215, 175);
            label7.Name = "label7";
            label7.Size = new Size(147, 23);
            label7.TabIndex = 25;
            label7.Text = "Mã doanh nghiệp";
            // 
            // ThemHoSo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ThemHoSo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm hồ sơ";
            Load += ThemHoSo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doUuTien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox ghiChu;
        private NumericUpDown doUuTien;
        private Label label5;
        private ComboBox tinhTrang;
        private Label label4;
        private ComboBox maPhieu;
        private ComboBox maUV;
        private Label label6;
        private Button HuyButton;
        private Button ThemButton;
        private ComboBox maDN;
        private Label label7;
    }
}