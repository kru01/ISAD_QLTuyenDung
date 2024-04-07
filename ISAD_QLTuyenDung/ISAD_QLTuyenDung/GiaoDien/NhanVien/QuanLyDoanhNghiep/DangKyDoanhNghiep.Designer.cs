namespace ISAD_QLTuyenDung.GiaoDien.NhanVien
{
    partial class DangKyDoanhNghiep
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
            label6 = new Label();
            NVPhuTrachBox = new TextBox();
            label7 = new Label();
            MaSoThueBox = new TextBox();
            LamMoiButton = new Button();
            label4 = new Label();
            DiaChiBox = new TextBox();
            NguoiDaiDienBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            MaDNBox = new TextBox();
            label5 = new Label();
            TenCtyBox = new TextBox();
            ThemDNButton = new Button();
            DoanhNghiepData = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DoanhNghiepData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(DoanhNghiepData);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
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
            label2.Location = new Point(322, 11);
            label2.Name = "label2";
            label2.Size = new Size(257, 31);
            label2.TabIndex = 9;
            label2.Text = "Đăng ký doanh nghiệp";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(NVPhuTrachBox);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(MaSoThueBox);
            panel3.Controls.Add(LamMoiButton);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(DiaChiBox);
            panel3.Controls.Add(NguoiDaiDienBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(MaDNBox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(TenCtyBox);
            panel3.Controls.Add(ThemDNButton);
            panel3.Location = new Point(12, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(876, 266);
            panel3.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(454, 100);
            label6.Name = "label6";
            label6.Size = new Size(113, 23);
            label6.TabIndex = 27;
            label6.Text = "NV phụ trách";
            // 
            // NVPhuTrachBox
            // 
            NVPhuTrachBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NVPhuTrachBox.Location = new Point(454, 125);
            NVPhuTrachBox.Name = "NVPhuTrachBox";
            NVPhuTrachBox.PlaceholderText = "NV phụ trách";
            NVPhuTrachBox.ReadOnly = true;
            NVPhuTrachBox.Size = new Size(125, 30);
            NVPhuTrachBox.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightSeaGreen;
            label7.Location = new Point(56, 100);
            label7.Name = "label7";
            label7.Size = new Size(97, 23);
            label7.TabIndex = 25;
            label7.Text = "Mã số thuế";
            // 
            // MaSoThueBox
            // 
            MaSoThueBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaSoThueBox.Location = new Point(56, 125);
            MaSoThueBox.Name = "MaSoThueBox";
            MaSoThueBox.PlaceholderText = "Mã số thuế";
            MaSoThueBox.ReadOnly = true;
            MaSoThueBox.Size = new Size(150, 30);
            MaSoThueBox.TabIndex = 24;
            // 
            // LamMoiButton
            // 
            LamMoiButton.BackColor = Color.LightSeaGreen;
            LamMoiButton.FlatAppearance.BorderSize = 0;
            LamMoiButton.FlatStyle = FlatStyle.Flat;
            LamMoiButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LamMoiButton.ForeColor = Color.White;
            LamMoiButton.Location = new Point(619, 175);
            LamMoiButton.Name = "LamMoiButton";
            LamMoiButton.Size = new Size(200, 40);
            LamMoiButton.TabIndex = 23;
            LamMoiButton.Text = "Làm mới";
            LamMoiButton.UseVisualStyleBackColor = false;
            LamMoiButton.Click += LamMoiButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(56, 158);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 20;
            label4.Text = "Địa chỉ";
            // 
            // DiaChiBox
            // 
            DiaChiBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiaChiBox.Location = new Point(56, 185);
            DiaChiBox.Name = "DiaChiBox";
            DiaChiBox.PlaceholderText = "Địa chỉ";
            DiaChiBox.ReadOnly = true;
            DiaChiBox.Size = new Size(523, 30);
            DiaChiBox.TabIndex = 19;
            // 
            // NguoiDaiDienBox
            // 
            NguoiDaiDienBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NguoiDaiDienBox.Location = new Point(225, 125);
            NguoiDaiDienBox.Name = "NguoiDaiDienBox";
            NguoiDaiDienBox.PlaceholderText = "Người đại diện";
            NguoiDaiDienBox.ReadOnly = true;
            NguoiDaiDienBox.Size = new Size(200, 30);
            NguoiDaiDienBox.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(225, 100);
            label3.Name = "label3";
            label3.Size = new Size(124, 23);
            label3.TabIndex = 17;
            label3.Text = "Người đại diện";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(56, 39);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 16;
            label1.Text = "Mã DN";
            // 
            // MaDNBox
            // 
            MaDNBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaDNBox.Location = new Point(56, 65);
            MaDNBox.Name = "MaDNBox";
            MaDNBox.PlaceholderText = "Mã DN";
            MaDNBox.ReadOnly = true;
            MaDNBox.Size = new Size(100, 30);
            MaDNBox.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(179, 39);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 14;
            label5.Text = "Tên công ty";
            // 
            // TenCtyBox
            // 
            TenCtyBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TenCtyBox.Location = new Point(179, 65);
            TenCtyBox.Name = "TenCtyBox";
            TenCtyBox.PlaceholderText = "Tên công ty";
            TenCtyBox.ReadOnly = true;
            TenCtyBox.Size = new Size(400, 30);
            TenCtyBox.TabIndex = 13;
            // 
            // ThemDNButton
            // 
            ThemDNButton.BackColor = Color.LightSeaGreen;
            ThemDNButton.FlatAppearance.BorderSize = 0;
            ThemDNButton.FlatStyle = FlatStyle.Flat;
            ThemDNButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemDNButton.ForeColor = Color.White;
            ThemDNButton.Location = new Point(619, 125);
            ThemDNButton.Name = "ThemDNButton";
            ThemDNButton.Size = new Size(200, 40);
            ThemDNButton.TabIndex = 6;
            ThemDNButton.Text = "Thêm doanh nghiệp";
            ThemDNButton.UseVisualStyleBackColor = false;
            ThemDNButton.Click += ThemDNButton_Click;
            // 
            // DoanhNghiepData
            // 
            DoanhNghiepData.AllowUserToAddRows = false;
            DoanhNghiepData.AllowUserToDeleteRows = false;
            DoanhNghiepData.AllowUserToResizeColumns = false;
            DoanhNghiepData.AllowUserToResizeRows = false;
            DoanhNghiepData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DoanhNghiepData.BorderStyle = BorderStyle.None;
            DoanhNghiepData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DoanhNghiepData.Dock = DockStyle.Bottom;
            DoanhNghiepData.Location = new Point(0, 300);
            DoanhNghiepData.Name = "DoanhNghiepData";
            DoanhNghiepData.ReadOnly = true;
            DoanhNghiepData.RowHeadersVisible = false;
            DoanhNghiepData.RowHeadersWidth = 51;
            DoanhNghiepData.Size = new Size(900, 400);
            DoanhNghiepData.TabIndex = 10;
            DoanhNghiepData.CellClick += DoanhNghiepData_CellClick;
            // 
            // DangKyDoanhNghiep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DangKyDoanhNghiep";
            Text = "DangKyDoanhNghiep";
            Load += DangKyDoanhNghiep_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DoanhNghiepData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private Label label7;
        private TextBox MaSoThueBox;
        private Button LamMoiButton;
        private Label label4;
        private TextBox DiaChiBox;
        private TextBox NguoiDaiDienBox;
        private Label label3;
        private Label label1;
        private TextBox MaDNBox;
        private Label label5;
        private TextBox TenCtyBox;
        private Button ThemDNButton;
        private Label label6;
        private TextBox NVPhuTrachBox;
        private DataGridView DoanhNghiepData;
    }
}