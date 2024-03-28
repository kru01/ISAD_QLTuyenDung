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
            label1 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            ThemDGButton = new Button();
            ThongKeButton = new Button();
            DanhGiaData = new DataGridView();
            lapDSTNButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DanhGiaData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(DanhGiaData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(564, 205);
            label1.Name = "label1";
            label1.Size = new Size(265, 31);
            label1.TabIndex = 2;
            label1.Text = "Đánh giá doanh nghiệp";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lapDSTNButton);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(ThemDGButton);
            panel2.Controls.Add(ThongKeButton);
            panel2.Location = new Point(525, 221);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 275);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // ThemDGButton
            // 
            ThemDGButton.BackColor = Color.LightSeaGreen;
            ThemDGButton.FlatAppearance.BorderSize = 0;
            ThemDGButton.FlatStyle = FlatStyle.Flat;
            ThemDGButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemDGButton.ForeColor = Color.White;
            ThemDGButton.Location = new Point(49, 120);
            ThemDGButton.Name = "ThemDGButton";
            ThemDGButton.Size = new Size(250, 40);
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
            ThongKeButton.Location = new Point(49, 50);
            ThongKeButton.Name = "ThongKeButton";
            ThongKeButton.Size = new Size(100, 40);
            ThongKeButton.TabIndex = 3;
            ThongKeButton.Text = "Thống kê";
            ThongKeButton.UseVisualStyleBackColor = false;
            // 
            // DanhGiaData
            // 
            DanhGiaData.AllowUserToAddRows = false;
            DanhGiaData.AllowUserToDeleteRows = false;
            DanhGiaData.AllowUserToResizeColumns = false;
            DanhGiaData.AllowUserToResizeRows = false;
            DanhGiaData.BorderStyle = BorderStyle.None;
            DanhGiaData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DanhGiaData.Dock = DockStyle.Left;
            DanhGiaData.Location = new Point(0, 0);
            DanhGiaData.Name = "DanhGiaData";
            DanhGiaData.ReadOnly = true;
            DanhGiaData.RowHeadersVisible = false;
            DanhGiaData.RowHeadersWidth = 51;
            DanhGiaData.Size = new Size(500, 700);
            DanhGiaData.TabIndex = 0;
            // 
            // lapDSTNButton
            // 
            lapDSTNButton.BackColor = Color.LightSeaGreen;
            lapDSTNButton.FlatAppearance.BorderSize = 0;
            lapDSTNButton.FlatStyle = FlatStyle.Flat;
            lapDSTNButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lapDSTNButton.ForeColor = Color.White;
            lapDSTNButton.Location = new Point(49, 190);
            lapDSTNButton.Name = "lapDSTNButton";
            lapDSTNButton.Size = new Size(250, 40);
            lapDSTNButton.TabIndex = 6;
            lapDSTNButton.Text = "Lập danh sách tiềm năng";
            lapDSTNButton.UseVisualStyleBackColor = false;
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DanhGiaData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView DanhGiaData;
        private Panel panel2;
        private Label label1;
        private Button ThemDGButton;
        private TextBox textBox1;
        private Button ThongKeButton;
        private Button lapDSTNButton;
    }
}