namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    partial class DanhGiaTiemNang
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
            tiemNang = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tenDN = new TextBox();
            tenLD = new TextBox();
            label3 = new Label();
            ghiChu = new TextBox();
            label1 = new Label();
            DanhGiaData = new DataGridView();
            panel2 = new Panel();
            LamMoiButton = new Button();
            lapDSTNButton = new Button();
            DNThongKe = new TextBox();
            ThemDGButton = new Button();
            ThongKeButton = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DanhGiaData).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(DanhGiaData);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(547, 13);
            label2.Name = "label2";
            label2.Size = new Size(162, 31);
            label2.TabIndex = 8;
            label2.Text = "Xem đánh giá";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(tiemNang);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(tenDN);
            panel3.Controls.Add(tenLD);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(ghiChu);
            panel3.Location = new Point(368, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(520, 250);
            panel3.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(375, 94);
            label6.Name = "label6";
            label6.Size = new Size(91, 23);
            label6.TabIndex = 14;
            label6.Text = "Tiềm năng";
            // 
            // tiemNang
            // 
            tiemNang.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tiemNang.Location = new Point(384, 120);
            tiemNang.Name = "tiemNang";
            tiemNang.ReadOnly = true;
            tiemNang.Size = new Size(75, 30);
            tiemNang.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(59, 24);
            label5.Name = "label5";
            label5.Size = new Size(148, 23);
            label5.TabIndex = 12;
            label5.Text = "Tên doanh nghiệp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(59, 94);
            label4.Name = "label4";
            label4.Size = new Size(180, 23);
            label4.TabIndex = 11;
            label4.Text = "Tên lãnh đạo đánh giá";
            // 
            // tenDN
            // 
            tenDN.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tenDN.Location = new Point(59, 50);
            tenDN.Name = "tenDN";
            tenDN.ReadOnly = true;
            tenDN.Size = new Size(400, 30);
            tenDN.TabIndex = 11;
            // 
            // tenLD
            // 
            tenLD.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tenLD.Location = new Point(59, 120);
            tenLD.Name = "tenLD";
            tenLD.ReadOnly = true;
            tenLD.Size = new Size(300, 30);
            tenLD.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(59, 164);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 9;
            label3.Text = "Ghi chú";
            // 
            // ghiChu
            // 
            ghiChu.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ghiChu.Location = new Point(59, 190);
            ghiChu.Name = "ghiChu";
            ghiChu.ReadOnly = true;
            ghiChu.Size = new Size(400, 30);
            ghiChu.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(55, 15);
            label1.Name = "label1";
            label1.Size = new Size(265, 31);
            label1.TabIndex = 2;
            label1.Text = "Đánh giá doanh nghiệp";
            // 
            // DanhGiaData
            // 
            DanhGiaData.AllowUserToAddRows = false;
            DanhGiaData.AllowUserToDeleteRows = false;
            DanhGiaData.AllowUserToResizeColumns = false;
            DanhGiaData.AllowUserToResizeRows = false;
            DanhGiaData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DanhGiaData.BorderStyle = BorderStyle.None;
            DanhGiaData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DanhGiaData.Dock = DockStyle.Bottom;
            DanhGiaData.Location = new Point(0, 300);
            DanhGiaData.Name = "DanhGiaData";
            DanhGiaData.ReadOnly = true;
            DanhGiaData.RowHeadersVisible = false;
            DanhGiaData.RowHeadersWidth = 51;
            DanhGiaData.Size = new Size(900, 400);
            DanhGiaData.TabIndex = 0;
            DanhGiaData.CellClick += DanhGiaData_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(LamMoiButton);
            panel2.Controls.Add(lapDSTNButton);
            panel2.Controls.Add(DNThongKe);
            panel2.Controls.Add(ThemDGButton);
            panel2.Controls.Add(ThongKeButton);
            panel2.Location = new Point(12, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 250);
            panel2.TabIndex = 1;
            // 
            // LamMoiButton
            // 
            LamMoiButton.BackColor = Color.LightSeaGreen;
            LamMoiButton.FlatAppearance.BorderSize = 0;
            LamMoiButton.FlatStyle = FlatStyle.Flat;
            LamMoiButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LamMoiButton.ForeColor = Color.White;
            LamMoiButton.Location = new Point(212, 105);
            LamMoiButton.Name = "LamMoiButton";
            LamMoiButton.Size = new Size(100, 40);
            LamMoiButton.TabIndex = 7;
            LamMoiButton.Text = "Làm mới";
            LamMoiButton.UseVisualStyleBackColor = false;
            LamMoiButton.Click += LamMoiButton_Click;
            // 
            // lapDSTNButton
            // 
            lapDSTNButton.BackColor = Color.LightSeaGreen;
            lapDSTNButton.FlatAppearance.BorderSize = 0;
            lapDSTNButton.FlatStyle = FlatStyle.Flat;
            lapDSTNButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lapDSTNButton.ForeColor = Color.White;
            lapDSTNButton.Location = new Point(37, 175);
            lapDSTNButton.Name = "lapDSTNButton";
            lapDSTNButton.Size = new Size(275, 40);
            lapDSTNButton.TabIndex = 6;
            lapDSTNButton.Text = "Lập danh sách tiềm năng";
            lapDSTNButton.UseVisualStyleBackColor = false;
            lapDSTNButton.Click += LapDSTNButton_Click;
            // 
            // DNThongKe
            // 
            DNThongKe.CharacterCasing = CharacterCasing.Upper;
            DNThongKe.Location = new Point(187, 48);
            DNThongKe.Name = "DNThongKe";
            DNThongKe.Size = new Size(125, 27);
            DNThongKe.TabIndex = 4;
            // 
            // ThemDGButton
            // 
            ThemDGButton.BackColor = Color.LightSeaGreen;
            ThemDGButton.FlatAppearance.BorderSize = 0;
            ThemDGButton.FlatStyle = FlatStyle.Flat;
            ThemDGButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemDGButton.ForeColor = Color.White;
            ThemDGButton.Location = new Point(37, 105);
            ThemDGButton.Name = "ThemDGButton";
            ThemDGButton.Size = new Size(150, 40);
            ThemDGButton.TabIndex = 5;
            ThemDGButton.Text = "Thêm đánh giá";
            ThemDGButton.UseVisualStyleBackColor = false;
            ThemDGButton.Click += ThemDGButton_Click;
            // 
            // ThongKeButton
            // 
            ThongKeButton.BackColor = Color.LightSeaGreen;
            ThongKeButton.FlatAppearance.BorderSize = 0;
            ThongKeButton.FlatStyle = FlatStyle.Flat;
            ThongKeButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThongKeButton.ForeColor = Color.White;
            ThongKeButton.Location = new Point(37, 35);
            ThongKeButton.Name = "ThongKeButton";
            ThongKeButton.Size = new Size(125, 40);
            ThongKeButton.TabIndex = 3;
            ThongKeButton.Text = "Thống kê";
            ThongKeButton.UseVisualStyleBackColor = false;
            ThongKeButton.Click += ThongKeButton_Click;
            // 
            // DanhGiaTiemNang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DanhGiaTiemNang";
            Text = "DanhGiaDoanhNghiep";
            Load += DanhGiaTiemNang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DanhGiaData).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView DanhGiaData;
        private Panel panel2;
        private Label label1;
        private Button ThemDGButton;
        private TextBox DNThongKe;
        private Button ThongKeButton;
        private Button lapDSTNButton;
        private Label label2;
        private Panel panel3;
        private TextBox ghiChu;
        private Label label3;
        private Label label4;
        private TextBox tenDN;
        private TextBox tenLD;
        private Label label5;
        private Label label6;
        private TextBox tiemNang;
        private Button LamMoiButton;
    }
}