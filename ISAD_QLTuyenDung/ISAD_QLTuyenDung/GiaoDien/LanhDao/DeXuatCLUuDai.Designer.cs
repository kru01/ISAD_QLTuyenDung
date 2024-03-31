namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    partial class DeXuatCLUuDai
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
            label4 = new Label();
            label3 = new Label();
            tenLD = new TextBox();
            LamMoiButton = new Button();
            ThemChienLuocButton = new Button();
            tenCL = new TextBox();
            label5 = new Label();
            moTa = new TextBox();
            ChienLuocData = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChienLuocData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(ChienLuocData);
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
            label2.Location = new Point(323, 11);
            label2.Name = "label2";
            label2.Size = new Size(254, 31);
            label2.TabIndex = 7;
            label2.Text = "Xem chiến lược ưu đãi";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(tenLD);
            panel3.Controls.Add(LamMoiButton);
            panel3.Controls.Add(ThemChienLuocButton);
            panel3.Controls.Add(tenCL);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(moTa);
            panel3.Location = new Point(12, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(876, 266);
            panel3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(546, 44);
            label4.Name = "label4";
            label4.Size = new Size(171, 23);
            label4.TabIndex = 20;
            label4.Text = "Tên lãnh đạo đề xuất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(54, 44);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 19;
            label3.Text = "Tên chiến lược";
            // 
            // tenLD
            // 
            tenLD.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tenLD.Location = new Point(546, 70);
            tenLD.Name = "tenLD";
            tenLD.ReadOnly = true;
            tenLD.Size = new Size(275, 30);
            tenLD.TabIndex = 17;
            // 
            // LamMoiButton
            // 
            LamMoiButton.BackColor = Color.LightSeaGreen;
            LamMoiButton.FlatAppearance.BorderSize = 0;
            LamMoiButton.FlatStyle = FlatStyle.Flat;
            LamMoiButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LamMoiButton.ForeColor = Color.White;
            LamMoiButton.Location = new Point(621, 170);
            LamMoiButton.Name = "LamMoiButton";
            LamMoiButton.Size = new Size(200, 40);
            LamMoiButton.TabIndex = 5;
            LamMoiButton.Text = "Làm mới";
            LamMoiButton.UseVisualStyleBackColor = false;
            LamMoiButton.Click += LamMoiButton_Click;
            // 
            // ThemChienLuocButton
            // 
            ThemChienLuocButton.BackColor = Color.LightSeaGreen;
            ThemChienLuocButton.FlatAppearance.BorderSize = 0;
            ThemChienLuocButton.FlatStyle = FlatStyle.Flat;
            ThemChienLuocButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemChienLuocButton.ForeColor = Color.White;
            ThemChienLuocButton.Location = new Point(621, 124);
            ThemChienLuocButton.Name = "ThemChienLuocButton";
            ThemChienLuocButton.Size = new Size(200, 40);
            ThemChienLuocButton.TabIndex = 5;
            ThemChienLuocButton.Text = "Thêm chiến lược";
            ThemChienLuocButton.UseVisualStyleBackColor = false;
            ThemChienLuocButton.Click += ThemChienLuocButton_Click;
            // 
            // tenCL
            // 
            tenCL.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tenCL.Location = new Point(54, 70);
            tenCL.Name = "tenCL";
            tenCL.ReadOnly = true;
            tenCL.Size = new Size(450, 30);
            tenCL.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(54, 150);
            label5.Name = "label5";
            label5.Size = new Size(56, 23);
            label5.TabIndex = 14;
            label5.Text = "Mô tả";
            // 
            // moTa
            // 
            moTa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moTa.Location = new Point(54, 180);
            moTa.Name = "moTa";
            moTa.ReadOnly = true;
            moTa.Size = new Size(500, 30);
            moTa.TabIndex = 13;
            // 
            // ChienLuocData
            // 
            ChienLuocData.AllowUserToAddRows = false;
            ChienLuocData.AllowUserToDeleteRows = false;
            ChienLuocData.AllowUserToResizeColumns = false;
            ChienLuocData.AllowUserToResizeRows = false;
            ChienLuocData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ChienLuocData.BorderStyle = BorderStyle.None;
            ChienLuocData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ChienLuocData.Dock = DockStyle.Bottom;
            ChienLuocData.Location = new Point(0, 300);
            ChienLuocData.Name = "ChienLuocData";
            ChienLuocData.ReadOnly = true;
            ChienLuocData.RowHeadersVisible = false;
            ChienLuocData.RowHeadersWidth = 51;
            ChienLuocData.Size = new Size(900, 400);
            ChienLuocData.TabIndex = 0;
            ChienLuocData.CellClick += ChienLuocData_CellClick;
            // 
            // DeXuatCLUuDai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeXuatCLUuDai";
            Text = "QuanLyUuDai";
            Load += DeXuatCLUuDai_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ChienLuocData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ThemChienLuocButton;
        private DataGridView ChienLuocData;
        private Panel panel3;
        private Button LamMoiButton;
        private Label label2;
        private Label label5;
        private TextBox moTa;
        private TextBox tenCL;
        private TextBox tenLD;
        private Label label4;
        private Label label3;
    }
}