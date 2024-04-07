namespace ISAD_QLTuyenDung.GiaoDien.NhanVien
{
    partial class GiaHanHopDong
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
            NVPhuTrachBox = new TextBox();
            CapNhatButton = new Button();
            ThemDNButton = new Button();
            label10 = new Label();
            LamMoiButton = new Button();
            label9 = new Label();
            TenCtyBox = new TextBox();
            DiaChiBox = new TextBox();
            MaDNBox = new TextBox();
            label8 = new Label();
            MSThueBox = new TextBox();
            NgDaiDienBox = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label1 = new Label();
            NgayHHDate = new DateTimePicker();
            EmailBox = new TextBox();
            label6 = new Label();
            label3 = new Label();
            NgayLapDate = new DateTimePicker();
            label4 = new Label();
            HopDongDNData = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HopDongDNData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(HopDongDNData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(347, 11);
            label2.Name = "label2";
            label2.Size = new Size(206, 31);
            label2.TabIndex = 9;
            label2.Text = "Gia hạn hợp đồng";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(NVPhuTrachBox);
            panel3.Controls.Add(CapNhatButton);
            panel3.Controls.Add(ThemDNButton);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(LamMoiButton);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(TenCtyBox);
            panel3.Controls.Add(DiaChiBox);
            panel3.Controls.Add(MaDNBox);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(MSThueBox);
            panel3.Controls.Add(NgDaiDienBox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(NgayHHDate);
            panel3.Controls.Add(EmailBox);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(NgayLapDate);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(12, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(876, 316);
            panel3.TabIndex = 8;
            // 
            // NVPhuTrachBox
            // 
            NVPhuTrachBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NVPhuTrachBox.Location = new Point(670, 51);
            NVPhuTrachBox.Name = "NVPhuTrachBox";
            NVPhuTrachBox.PlaceholderText = "Nhân viên";
            NVPhuTrachBox.ReadOnly = true;
            NVPhuTrachBox.Size = new Size(125, 30);
            NVPhuTrachBox.TabIndex = 71;
            // 
            // CapNhatButton
            // 
            CapNhatButton.BackColor = Color.LightSeaGreen;
            CapNhatButton.FlatAppearance.BorderSize = 0;
            CapNhatButton.FlatStyle = FlatStyle.Flat;
            CapNhatButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CapNhatButton.ForeColor = Color.White;
            CapNhatButton.Location = new Point(595, 250);
            CapNhatButton.Name = "CapNhatButton";
            CapNhatButton.Size = new Size(200, 40);
            CapNhatButton.TabIndex = 70;
            CapNhatButton.Text = "Cập nhật";
            CapNhatButton.UseVisualStyleBackColor = false;
            CapNhatButton.Click += CapNhatButton_Click;
            // 
            // ThemDNButton
            // 
            ThemDNButton.BackColor = Color.LightSeaGreen;
            ThemDNButton.FlatAppearance.BorderSize = 0;
            ThemDNButton.FlatStyle = FlatStyle.Flat;
            ThemDNButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemDNButton.ForeColor = Color.White;
            ThemDNButton.Location = new Point(79, 250);
            ThemDNButton.Name = "ThemDNButton";
            ThemDNButton.Size = new Size(200, 40);
            ThemDNButton.TabIndex = 6;
            ThemDNButton.Text = "Tìm doanh nghiệp";
            ThemDNButton.UseVisualStyleBackColor = false;
            ThemDNButton.Click += ThemDNButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.LightSeaGreen;
            label10.Location = new Point(670, 25);
            label10.Name = "label10";
            label10.Size = new Size(113, 23);
            label10.TabIndex = 69;
            label10.Text = "NV phụ trách";
            // 
            // LamMoiButton
            // 
            LamMoiButton.BackColor = Color.LightSeaGreen;
            LamMoiButton.FlatAppearance.BorderSize = 0;
            LamMoiButton.FlatStyle = FlatStyle.Flat;
            LamMoiButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LamMoiButton.ForeColor = Color.White;
            LamMoiButton.Location = new Point(337, 250);
            LamMoiButton.Name = "LamMoiButton";
            LamMoiButton.Size = new Size(200, 40);
            LamMoiButton.TabIndex = 23;
            LamMoiButton.Text = "Làm mới";
            LamMoiButton.UseVisualStyleBackColor = false;
            LamMoiButton.Click += LamMoiButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LightSeaGreen;
            label9.Location = new Point(395, 165);
            label9.Name = "label9";
            label9.Size = new Size(62, 23);
            label9.TabIndex = 67;
            label9.Text = "Địa chỉ";
            // 
            // TenCtyBox
            // 
            TenCtyBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TenCtyBox.Location = new Point(194, 51);
            TenCtyBox.Name = "TenCtyBox";
            TenCtyBox.PlaceholderText = "Tên công ty";
            TenCtyBox.ReadOnly = true;
            TenCtyBox.Size = new Size(450, 30);
            TenCtyBox.TabIndex = 52;
            // 
            // DiaChiBox
            // 
            DiaChiBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiaChiBox.Location = new Point(395, 191);
            DiaChiBox.Name = "DiaChiBox";
            DiaChiBox.PlaceholderText = "Địa chỉ";
            DiaChiBox.ReadOnly = true;
            DiaChiBox.Size = new Size(400, 30);
            DiaChiBox.TabIndex = 66;
            // 
            // MaDNBox
            // 
            MaDNBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaDNBox.Location = new Point(79, 51);
            MaDNBox.Name = "MaDNBox";
            MaDNBox.PlaceholderText = "Mã DN";
            MaDNBox.ReadOnly = true;
            MaDNBox.Size = new Size(100, 30);
            MaDNBox.TabIndex = 53;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LightSeaGreen;
            label8.Location = new Point(545, 95);
            label8.Name = "label8";
            label8.Size = new Size(124, 23);
            label8.TabIndex = 65;
            label8.Text = "Người đại diện";
            // 
            // MSThueBox
            // 
            MSThueBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MSThueBox.Location = new Point(79, 121);
            MSThueBox.Name = "MSThueBox";
            MSThueBox.PlaceholderText = "Mã số thuế";
            MSThueBox.ReadOnly = true;
            MSThueBox.Size = new Size(150, 30);
            MSThueBox.TabIndex = 54;
            // 
            // NgDaiDienBox
            // 
            NgDaiDienBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgDaiDienBox.Location = new Point(545, 121);
            NgDaiDienBox.Name = "NgDaiDienBox";
            NgDaiDienBox.PlaceholderText = "Người đại diện";
            NgDaiDienBox.ReadOnly = true;
            NgDaiDienBox.Size = new Size(250, 30);
            NgDaiDienBox.TabIndex = 64;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(194, 25);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 55;
            label5.Text = "Tên công ty";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightSeaGreen;
            label7.Location = new Point(227, 165);
            label7.Name = "label7";
            label7.Size = new Size(115, 23);
            label7.TabIndex = 63;
            label7.Text = "Ngày hết hạn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(79, 25);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 56;
            label1.Text = "Mã DN";
            // 
            // NgayHHDate
            // 
            NgayHHDate.CustomFormat = "dd/MM/yyyy";
            NgayHHDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgayHHDate.Format = DateTimePickerFormat.Custom;
            NgayHHDate.Location = new Point(228, 191);
            NgayHHDate.Name = "NgayHHDate";
            NgayHHDate.Size = new Size(125, 30);
            NgayHHDate.TabIndex = 62;
            // 
            // EmailBox
            // 
            EmailBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailBox.Location = new Point(252, 121);
            EmailBox.Name = "EmailBox";
            EmailBox.PlaceholderText = "Email";
            EmailBox.ReadOnly = true;
            EmailBox.Size = new Size(250, 30);
            EmailBox.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(79, 165);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 61;
            label6.Text = "Ngày lập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(79, 95);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 58;
            label3.Text = "Mã số thuế";
            // 
            // NgayLapDate
            // 
            NgayLapDate.CustomFormat = "dd/MM/yyyy";
            NgayLapDate.Enabled = false;
            NgayLapDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgayLapDate.Format = DateTimePickerFormat.Custom;
            NgayLapDate.Location = new Point(79, 191);
            NgayLapDate.Name = "NgayLapDate";
            NgayLapDate.Size = new Size(125, 30);
            NgayLapDate.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(252, 95);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 59;
            label4.Text = "Email";
            // 
            // HopDongDNData
            // 
            HopDongDNData.AllowUserToAddRows = false;
            HopDongDNData.AllowUserToDeleteRows = false;
            HopDongDNData.AllowUserToResizeColumns = false;
            HopDongDNData.AllowUserToResizeRows = false;
            HopDongDNData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            HopDongDNData.BorderStyle = BorderStyle.None;
            HopDongDNData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HopDongDNData.Dock = DockStyle.Bottom;
            HopDongDNData.Location = new Point(0, 350);
            HopDongDNData.Name = "HopDongDNData";
            HopDongDNData.ReadOnly = true;
            HopDongDNData.RowHeadersVisible = false;
            HopDongDNData.RowHeadersWidth = 51;
            HopDongDNData.Size = new Size(900, 350);
            HopDongDNData.TabIndex = 10;
            HopDongDNData.CellClick += HopDongDNData_CellClick;
            // 
            // GiaHanHopDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GiaHanHopDong";
            Text = "GiaHanHopDong";
            Load += GiaHanHopDong_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HopDongDNData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView HopDongDNData;
        private Label label2;
        private Panel panel3;
        private Button LamMoiButton;
        private Button ThemDNButton;
        private Label label10;
        private Label label9;
        private TextBox TenCtyBox;
        private TextBox DiaChiBox;
        private TextBox MaDNBox;
        private Label label8;
        private TextBox MSThueBox;
        private TextBox NgDaiDienBox;
        private Label label5;
        private Label label7;
        private Label label1;
        private DateTimePicker NgayHHDate;
        private TextBox EmailBox;
        private Label label6;
        private Label label3;
        private DateTimePicker NgayLapDate;
        private Label label4;
        private TextBox NVPhuTrachBox;
        private Button CapNhatButton;
    }
}