namespace ISAD_QLTuyenDung.GiaoDien.NhanVien
{
    partial class NhanVienForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVienForm));
            mainPanel = new Panel();
            navigator = new Panel();
            DangXuatButton = new Button();
            HSTuyenDungButton = new Button();
            TTDangTuyenButton = new Button();
            DSHetHDButton = new Button();
            GiaHanHDButton = new Button();
            DKDNButton = new Button();
            empName = new Label();
            pictureBox1 = new PictureBox();
            navigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(300, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(900, 700);
            mainPanel.TabIndex = 6;
            // 
            // navigator
            // 
            navigator.BackColor = Color.FromArgb(51, 51, 76);
            navigator.Controls.Add(DangXuatButton);
            navigator.Controls.Add(HSTuyenDungButton);
            navigator.Controls.Add(TTDangTuyenButton);
            navigator.Controls.Add(DSHetHDButton);
            navigator.Controls.Add(GiaHanHDButton);
            navigator.Controls.Add(DKDNButton);
            navigator.Controls.Add(empName);
            navigator.Controls.Add(pictureBox1);
            navigator.Dock = DockStyle.Left;
            navigator.Location = new Point(0, 0);
            navigator.Name = "navigator";
            navigator.Size = new Size(300, 700);
            navigator.TabIndex = 5;
            // 
            // DangXuatButton
            // 
            DangXuatButton.BackColor = Color.Transparent;
            DangXuatButton.Dock = DockStyle.Top;
            DangXuatButton.FlatAppearance.BorderSize = 0;
            DangXuatButton.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            DangXuatButton.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            DangXuatButton.FlatStyle = FlatStyle.Flat;
            DangXuatButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DangXuatButton.ForeColor = Color.White;
            DangXuatButton.Location = new Point(0, 570);
            DangXuatButton.Name = "DangXuatButton";
            DangXuatButton.Size = new Size(300, 80);
            DangXuatButton.TabIndex = 3;
            DangXuatButton.Text = "Đăng xuất";
            DangXuatButton.UseVisualStyleBackColor = false;
            DangXuatButton.Click += DangXuatButton_Click_1;
            // 
            // HSTuyenDungButton
            // 
            HSTuyenDungButton.BackColor = Color.Transparent;
            HSTuyenDungButton.Dock = DockStyle.Top;
            HSTuyenDungButton.FlatAppearance.BorderSize = 0;
            HSTuyenDungButton.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            HSTuyenDungButton.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            HSTuyenDungButton.FlatStyle = FlatStyle.Flat;
            HSTuyenDungButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HSTuyenDungButton.ForeColor = Color.White;
            HSTuyenDungButton.Location = new Point(0, 490);
            HSTuyenDungButton.Name = "HSTuyenDungButton";
            HSTuyenDungButton.Size = new Size(300, 80);
            HSTuyenDungButton.TabIndex = 9;
            HSTuyenDungButton.Text = "Hồ sơ tuyển dụng";
            HSTuyenDungButton.UseVisualStyleBackColor = false;
            HSTuyenDungButton.Click += HSTuyenDungButton_Click;
            // 
            // TTDangTuyenButton
            // 
            TTDangTuyenButton.BackColor = Color.Transparent;
            TTDangTuyenButton.Dock = DockStyle.Top;
            TTDangTuyenButton.FlatAppearance.BorderSize = 0;
            TTDangTuyenButton.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            TTDangTuyenButton.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            TTDangTuyenButton.FlatStyle = FlatStyle.Flat;
            TTDangTuyenButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TTDangTuyenButton.ForeColor = Color.White;
            TTDangTuyenButton.Location = new Point(0, 410);
            TTDangTuyenButton.Name = "TTDangTuyenButton";
            TTDangTuyenButton.Size = new Size(300, 80);
            TTDangTuyenButton.TabIndex = 8;
            TTDangTuyenButton.Text = "Thông tin đăng tuyển";
            TTDangTuyenButton.UseVisualStyleBackColor = false;
            TTDangTuyenButton.Click += TTDangTuyenButton_Click;
            // 
            // DSHetHDButton
            // 
            DSHetHDButton.BackColor = Color.Transparent;
            DSHetHDButton.Dock = DockStyle.Top;
            DSHetHDButton.FlatAppearance.BorderSize = 0;
            DSHetHDButton.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            DSHetHDButton.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            DSHetHDButton.FlatStyle = FlatStyle.Flat;
            DSHetHDButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DSHetHDButton.ForeColor = Color.White;
            DSHetHDButton.Location = new Point(0, 330);
            DSHetHDButton.Name = "DSHetHDButton";
            DSHetHDButton.Size = new Size(300, 80);
            DSHetHDButton.TabIndex = 7;
            DSHetHDButton.Text = "Danh sách sắp hết hợp đồng";
            DSHetHDButton.UseVisualStyleBackColor = false;
            DSHetHDButton.Click += DSHetHDButton_Click;
            // 
            // GiaHanHDButton
            // 
            GiaHanHDButton.BackColor = Color.Transparent;
            GiaHanHDButton.Dock = DockStyle.Top;
            GiaHanHDButton.FlatAppearance.BorderSize = 0;
            GiaHanHDButton.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            GiaHanHDButton.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            GiaHanHDButton.FlatStyle = FlatStyle.Flat;
            GiaHanHDButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GiaHanHDButton.ForeColor = Color.White;
            GiaHanHDButton.Location = new Point(0, 250);
            GiaHanHDButton.Name = "GiaHanHDButton";
            GiaHanHDButton.Size = new Size(300, 80);
            GiaHanHDButton.TabIndex = 2;
            GiaHanHDButton.Text = "Gia hạn hợp đồng";
            GiaHanHDButton.UseVisualStyleBackColor = false;
            GiaHanHDButton.Click += GiaHanHDButton_Click;
            // 
            // DKDNButton
            // 
            DKDNButton.BackColor = Color.Transparent;
            DKDNButton.Dock = DockStyle.Top;
            DKDNButton.FlatAppearance.BorderSize = 0;
            DKDNButton.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            DKDNButton.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            DKDNButton.FlatStyle = FlatStyle.Flat;
            DKDNButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DKDNButton.ForeColor = Color.White;
            DKDNButton.Location = new Point(0, 170);
            DKDNButton.Name = "DKDNButton";
            DKDNButton.Size = new Size(300, 80);
            DKDNButton.TabIndex = 1;
            DKDNButton.Text = "Đăng ký doanh nghiệp";
            DKDNButton.UseVisualStyleBackColor = false;
            DKDNButton.Click += DKDNButton_Click;
            // 
            // empName
            // 
            empName.Dock = DockStyle.Top;
            empName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            empName.ForeColor = Color.White;
            empName.Location = new Point(0, 120);
            empName.Name = "empName";
            empName.Size = new Size(300, 50);
            empName.TabIndex = 5;
            empName.Text = "<Name>";
            empName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // NhanVienForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(mainPanel);
            Controls.Add(navigator);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "NhanVienForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân viên";
            navigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel navigator;
        private Button DangXuatButton;
        private Button GiaHanHDButton;
        private Button DKDNButton;
        private Label empName;
        private PictureBox pictureBox1;
        private Button HSTuyenDungButton;
        private Button TTDangTuyenButton;
        private Button DSHetHDButton;
    }
}