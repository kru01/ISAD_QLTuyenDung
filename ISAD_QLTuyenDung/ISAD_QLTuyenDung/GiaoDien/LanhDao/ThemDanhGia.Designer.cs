namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    partial class ThemDanhGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemDanhGia));
            panel1 = new Panel();
            ratingBox = new NumericUpDown();
            CancelButton = new Button();
            AddButton = new Button();
            label4 = new Label();
            label3 = new Label();
            idCbo = new ComboBox();
            label2 = new Label();
            NoteBox = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ratingBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(ratingBox);
            panel1.Controls.Add(CancelButton);
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(idCbo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(NoteBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 353);
            panel1.TabIndex = 0;
            // 
            // ratingBox
            // 
            ratingBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ratingBox.Location = new Point(404, 112);
            ratingBox.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            ratingBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ratingBox.Name = "ratingBox";
            ratingBox.Size = new Size(75, 30);
            ratingBox.TabIndex = 12;
            ratingBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.LightSeaGreen;
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(304, 260);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(175, 40);
            CancelButton.TabIndex = 11;
            CancelButton.Text = "Hủy";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.LightSeaGreen;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(54, 260);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(175, 40);
            AddButton.TabIndex = 10;
            AddButton.Text = "Thêm";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(404, 86);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 9;
            label4.Text = "Tiềm năng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(54, 86);
            label3.Name = "label3";
            label3.Size = new Size(138, 23);
            label3.TabIndex = 7;
            label3.Text = "Tên doanh ngiệp";
            // 
            // idCbo
            // 
            idCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idCbo.FormattingEnabled = true;
            idCbo.Location = new Point(54, 112);
            idCbo.Name = "idCbo";
            idCbo.Size = new Size(325, 31);
            idCbo.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(54, 170);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 5;
            label2.Text = "Ghi chú";
            // 
            // NoteBox
            // 
            NoteBox.Location = new Point(54, 196);
            NoteBox.Name = "NoteBox";
            NoteBox.Size = new Size(425, 27);
            NoteBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(104, 20);
            label1.Name = "label1";
            label1.Size = new Size(325, 38);
            label1.TabIndex = 3;
            label1.Text = "Đánh giá doanh nghiệp";
            // 
            // ThemDanhGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 353);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ThemDanhGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm đánh giá doanh nghiệp";
            Load += ThemDanhGia_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ratingBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox NoteBox;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private ComboBox idCbo;
        private Button AddButton;
        private new Button CancelButton;
        private NumericUpDown ratingBox;
    }
}