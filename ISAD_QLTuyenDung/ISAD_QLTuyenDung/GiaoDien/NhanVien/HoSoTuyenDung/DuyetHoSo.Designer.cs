namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung
{
    partial class DuyetHoSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuyetHoSo));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            doUuTien = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            ghiChu = new TextBox();
            label5 = new Label();
            HuyButton = new Button();
            tinhTrang = new ComboBox();
            LamMoiButton = new Button();
            label3 = new Label();
            ThemButton = new Button();
            HoSoData = new DataGridView();
            maUV = new TextBox();
            maPhieu = new TextBox();
            maDN = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doUuTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HoSoData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(HoSoData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 653);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(353, 10);
            label1.Name = "label1";
            label1.Size = new Size(176, 38);
            label1.TabIndex = 5;
            label1.Text = "Duyệt hồ sơ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(maDN);
            panel2.Controls.Add(maPhieu);
            panel2.Controls.Add(maUV);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(doUuTien);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(ghiChu);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(HuyButton);
            panel2.Controls.Add(tinhTrang);
            panel2.Controls.Add(LamMoiButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(ThemButton);
            panel2.Location = new Point(25, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(832, 250);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightSeaGreen;
            label7.Location = new Point(259, 100);
            label7.Name = "label7";
            label7.Size = new Size(147, 23);
            label7.TabIndex = 33;
            label7.Text = "Mã doanh nghiệp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(435, 100);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 31;
            label6.Text = "Ưu tiên";
            // 
            // doUuTien
            // 
            doUuTien.Location = new Point(435, 126);
            doUuTien.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            doUuTien.Name = "doUuTien";
            doUuTien.Size = new Size(50, 27);
            doUuTien.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(85, 169);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 27;
            label2.Text = "Ghi chú";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(85, 100);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 29;
            label4.Text = "Mã phiếu";
            // 
            // ghiChu
            // 
            ghiChu.Location = new Point(85, 195);
            ghiChu.Name = "ghiChu";
            ghiChu.Size = new Size(400, 27);
            ghiChu.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(259, 29);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 24;
            label5.Text = "Tình trạng";
            // 
            // HuyButton
            // 
            HuyButton.BackColor = Color.LightSeaGreen;
            HuyButton.FlatAppearance.BorderSize = 0;
            HuyButton.FlatStyle = FlatStyle.Flat;
            HuyButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HuyButton.ForeColor = Color.White;
            HuyButton.Location = new Point(570, 183);
            HuyButton.Name = "HuyButton";
            HuyButton.Size = new Size(175, 40);
            HuyButton.TabIndex = 14;
            HuyButton.Text = "Hủy";
            HuyButton.UseVisualStyleBackColor = false;
            HuyButton.Click += HuyButton_Click;
            // 
            // tinhTrang
            // 
            tinhTrang.FormattingEnabled = true;
            tinhTrang.Items.AddRange(new object[] { "Chưa đủ điều kiện", "Đủ điều kiện", "Đã xử lý", "Đã đạt" });
            tinhTrang.Location = new Point(259, 55);
            tinhTrang.Name = "tinhTrang";
            tinhTrang.Size = new Size(226, 28);
            tinhTrang.TabIndex = 23;
            // 
            // LamMoiButton
            // 
            LamMoiButton.BackColor = Color.LightSeaGreen;
            LamMoiButton.FlatAppearance.BorderSize = 0;
            LamMoiButton.FlatStyle = FlatStyle.Flat;
            LamMoiButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LamMoiButton.ForeColor = Color.White;
            LamMoiButton.Location = new Point(570, 113);
            LamMoiButton.Name = "LamMoiButton";
            LamMoiButton.Size = new Size(175, 40);
            LamMoiButton.TabIndex = 13;
            LamMoiButton.Text = "Làm mới";
            LamMoiButton.UseVisualStyleBackColor = false;
            LamMoiButton.Click += LamMoiButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(85, 29);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 21;
            label3.Text = "Mã ứng viên";
            // 
            // ThemButton
            // 
            ThemButton.BackColor = Color.LightSeaGreen;
            ThemButton.FlatAppearance.BorderSize = 0;
            ThemButton.FlatStyle = FlatStyle.Flat;
            ThemButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemButton.ForeColor = Color.White;
            ThemButton.Location = new Point(570, 43);
            ThemButton.Name = "ThemButton";
            ThemButton.Size = new Size(175, 40);
            ThemButton.TabIndex = 12;
            ThemButton.Text = "Duyệt";
            ThemButton.UseVisualStyleBackColor = false;
            ThemButton.Click += ThemButton_Click;
            // 
            // HoSoData
            // 
            HoSoData.AllowUserToAddRows = false;
            HoSoData.AllowUserToDeleteRows = false;
            HoSoData.AllowUserToResizeColumns = false;
            HoSoData.AllowUserToResizeRows = false;
            HoSoData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HoSoData.BorderStyle = BorderStyle.None;
            HoSoData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HoSoData.Dock = DockStyle.Bottom;
            HoSoData.Location = new Point(0, 303);
            HoSoData.Name = "HoSoData";
            HoSoData.ReadOnly = true;
            HoSoData.RowHeadersVisible = false;
            HoSoData.RowHeadersWidth = 51;
            HoSoData.Size = new Size(882, 350);
            HoSoData.TabIndex = 0;
            HoSoData.CellClick += HoSoData_CellClick;
            // 
            // maUV
            // 
            maUV.Location = new Point(85, 55);
            maUV.Name = "maUV";
            maUV.ReadOnly = true;
            maUV.Size = new Size(150, 27);
            maUV.TabIndex = 34;
            // 
            // maPhieu
            // 
            maPhieu.Location = new Point(85, 126);
            maPhieu.Name = "maPhieu";
            maPhieu.ReadOnly = true;
            maPhieu.Size = new Size(150, 27);
            maPhieu.TabIndex = 35;
            // 
            // maDN
            // 
            maDN.Location = new Point(259, 126);
            maDN.Name = "maDN";
            maDN.ReadOnly = true;
            maDN.Size = new Size(150, 27);
            maDN.TabIndex = 36;
            // 
            // DuyetHoSo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 653);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DuyetHoSo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Duyệt hồ sơ";
            Load += DuyetHoSo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doUuTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)HoSoData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView HoSoData;
        private Panel panel2;
        private Label label1;
        private Button HuyButton;
        private Button LamMoiButton;
        private Button ThemButton;
        private Label label5;
        private ComboBox tinhTrang;
        private Label label3;
        private Label label7;
        private Label label6;
        private NumericUpDown doUuTien;
        private Label label2;
        private Label label4;
        private TextBox ghiChu;
        private TextBox maUV;
        private TextBox maPhieu;
        private TextBox maDN;
    }
}