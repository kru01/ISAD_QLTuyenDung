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
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            DanhGiaData = new DataGridView();
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
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(48, 34);
            button1.Name = "button1";
            button1.Size = new Size(250, 40);
            button1.TabIndex = 5;
            button1.Text = "Thêm chiến lược";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(574, 290);
            label1.Name = "label1";
            label1.Size = new Size(250, 38);
            label1.TabIndex = 2;
            label1.Text = "Chiến lược ưu đãi";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Location = new Point(525, 311);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 100);
            panel2.TabIndex = 1;
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
            // DeXuatCLUuDai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeXuatCLUuDai";
            Text = "QuanLyUuDai";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DanhGiaData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private DataGridView DanhGiaData;
    }
}