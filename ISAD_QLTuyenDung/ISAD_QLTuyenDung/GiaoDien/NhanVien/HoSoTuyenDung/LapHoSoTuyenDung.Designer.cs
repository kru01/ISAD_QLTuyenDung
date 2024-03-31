namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung
{
    partial class LapHoSoTuyenDung
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
            HoSoData = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            LapDSHSButton = new Button();
            DuyetHSButton = new Button();
            ThemHoSoButton = new Button();
            ((System.ComponentModel.ISupportInitialize)HoSoData).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // HoSoData
            // 
            HoSoData.AllowUserToAddRows = false;
            HoSoData.AllowUserToDeleteRows = false;
            HoSoData.AllowUserToResizeColumns = false;
            HoSoData.AllowUserToResizeRows = false;
            HoSoData.BorderStyle = BorderStyle.None;
            HoSoData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HoSoData.Dock = DockStyle.Bottom;
            HoSoData.Location = new Point(0, 300);
            HoSoData.Name = "HoSoData";
            HoSoData.ReadOnly = true;
            HoSoData.RowHeadersVisible = false;
            HoSoData.RowHeadersWidth = 51;
            HoSoData.Size = new Size(900, 400);
            HoSoData.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(348, 11);
            label2.Name = "label2";
            label2.Size = new Size(205, 31);
            label2.TabIndex = 9;
            label2.Text = "Hồ sơ tuyển dụng";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(ThemHoSoButton);
            panel3.Controls.Add(LapDSHSButton);
            panel3.Controls.Add(DuyetHSButton);
            panel3.Location = new Point(12, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(876, 266);
            panel3.TabIndex = 8;
            // 
            // LapDSHSButton
            // 
            LapDSHSButton.BackColor = Color.LightSeaGreen;
            LapDSHSButton.FlatAppearance.BorderSize = 0;
            LapDSHSButton.FlatStyle = FlatStyle.Flat;
            LapDSHSButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LapDSHSButton.ForeColor = Color.White;
            LapDSHSButton.Location = new Point(621, 170);
            LapDSHSButton.Name = "LapDSHSButton";
            LapDSHSButton.Size = new Size(200, 40);
            LapDSHSButton.TabIndex = 5;
            LapDSHSButton.Text = "Lập danh sách hồ sơ";
            LapDSHSButton.UseVisualStyleBackColor = false;
            // 
            // DuyetHSButton
            // 
            DuyetHSButton.BackColor = Color.LightSeaGreen;
            DuyetHSButton.FlatAppearance.BorderSize = 0;
            DuyetHSButton.FlatStyle = FlatStyle.Flat;
            DuyetHSButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DuyetHSButton.ForeColor = Color.White;
            DuyetHSButton.Location = new Point(621, 124);
            DuyetHSButton.Name = "DuyetHSButton";
            DuyetHSButton.Size = new Size(200, 40);
            DuyetHSButton.TabIndex = 5;
            DuyetHSButton.Text = "Duyệt hồ sơ";
            DuyetHSButton.UseVisualStyleBackColor = false;
            // 
            // ThemHoSoButton
            // 
            ThemHoSoButton.BackColor = Color.LightSeaGreen;
            ThemHoSoButton.FlatAppearance.BorderSize = 0;
            ThemHoSoButton.FlatStyle = FlatStyle.Flat;
            ThemHoSoButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemHoSoButton.ForeColor = Color.White;
            ThemHoSoButton.Location = new Point(621, 78);
            ThemHoSoButton.Name = "ThemHoSoButton";
            ThemHoSoButton.Size = new Size(200, 40);
            ThemHoSoButton.TabIndex = 6;
            ThemHoSoButton.Text = "Thêm hồ sơ";
            ThemHoSoButton.UseVisualStyleBackColor = false;
            // 
            // LapHoSoTuyenDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(HoSoData);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LapHoSoTuyenDung";
            Text = "LapHoSoTuyenDung";
            Load += LapHoSoTuyenDung_Load;
            ((System.ComponentModel.ISupportInitialize)HoSoData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView HoSoData;
        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private Button LapDSHSButton;
        private Button DuyetHSButton;
        private Button ThemHoSoButton;
    }
}