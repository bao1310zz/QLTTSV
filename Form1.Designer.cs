namespace QLTTSV
{
    partial class Form1
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
            this.grbTTSV = new System.Windows.Forms.GroupBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblDTB = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTT = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTS = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTongNam = new System.Windows.Forms.Label();
            this.lblTongNu = new System.Windows.Forms.Label();
            this.grbTTSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTT)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTTSV
            // 
            this.grbTTSV.Controls.Add(this.txtDTB);
            this.grbTTSV.Controls.Add(this.rdbNu);
            this.grbTTSV.Controls.Add(this.rdbNam);
            this.grbTTSV.Controls.Add(this.cmbKhoa);
            this.grbTTSV.Controls.Add(this.txtHoTen);
            this.grbTTSV.Controls.Add(this.txtMSSV);
            this.grbTTSV.Controls.Add(this.lblKhoa);
            this.grbTTSV.Controls.Add(this.lblDTB);
            this.grbTTSV.Controls.Add(this.lblGT);
            this.grbTTSV.Controls.Add(this.lblHoTen);
            this.grbTTSV.Controls.Add(this.lblMSSV);
            this.grbTTSV.Location = new System.Drawing.Point(32, 149);
            this.grbTTSV.Name = "grbTTSV";
            this.grbTTSV.Size = new System.Drawing.Size(284, 169);
            this.grbTTSV.TabIndex = 0;
            this.grbTTSV.TabStop = false;
            this.grbTTSV.Text = "Thông tin sinh viên";
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(107, 99);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(100, 22);
            this.txtDTB.TabIndex = 0;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(168, 76);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(45, 20);
            this.rdbNu.TabIndex = 9;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            this.rdbNu.CheckedChanged += new System.EventHandler(this.rdbNu_CheckedChanged);
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(77, 76);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(57, 20);
            this.rdbNam.TabIndex = 8;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cmbKhoa.Location = new System.Drawing.Point(107, 126);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(121, 24);
            this.cmbKhoa.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(107, 50);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 22);
            this.txtHoTen.TabIndex = 6;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(107, 22);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(100, 22);
            this.txtMSSV.TabIndex = 5;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(6, 130);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(95, 16);
            this.lblKhoa.TabIndex = 4;
            this.lblKhoa.Text = "Chuyên Ngành";
            // 
            // lblDTB
            // 
            this.lblDTB.AutoSize = true;
            this.lblDTB.Location = new System.Drawing.Point(6, 105);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(59, 16);
            this.lblDTB.TabIndex = 3;
            this.lblDTB.Text = "Điểm TB";
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Location = new System.Drawing.Point(6, 80);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(60, 16);
            this.lblGT.TabIndex = 2;
            this.lblGT.Text = "Giới Tính";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(6, 55);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(52, 16);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(6, 28);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(85, 16);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "Mã Sinh Viên";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            // 
            // dgvTT
            // 
            this.dgvTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTT.Location = new System.Drawing.Point(360, 149);
            this.dgvTT.Name = "dgvTT";
            this.dgvTT.RowHeadersWidth = 51;
            this.dgvTT.RowTemplate.Height = 24;
            this.dgvTT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTT.Size = new System.Drawing.Size(428, 229);
            this.dgvTT.TabIndex = 2;
            this.dgvTT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTT_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MSSV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Điểm Trung Bình";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Chuyên Ngành";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // btnTS
            // 
            this.btnTS.Location = new System.Drawing.Point(58, 355);
            this.btnTS.Name = "btnTS";
            this.btnTS.Size = new System.Drawing.Size(94, 23);
            this.btnTS.TabIndex = 3;
            this.btnTS.Text = "Thêm/Sửa";
            this.btnTS.UseVisualStyleBackColor = true;
            this.btnTS.Click += new System.EventHandler(this.btnTS_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(178, 354);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(489, 402);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(625, 403);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            // 
            // lblTongNam
            // 
            this.lblTongNam.AutoSize = true;
            this.lblTongNam.Location = new System.Drawing.Point(395, 407);
            this.lblTongNam.Name = "lblTongNam";
            this.lblTongNam.Size = new System.Drawing.Size(92, 16);
            this.lblTongNam.TabIndex = 10;
            this.lblTongNam.Text = "Tổng SV Nam";
            // 
            // lblTongNu
            // 
            this.lblTongNu.AutoSize = true;
            this.lblTongNu.Location = new System.Drawing.Point(595, 408);
            this.lblTongNu.Name = "lblTongNu";
            this.lblTongNu.Size = new System.Drawing.Size(24, 16);
            this.lblTongNu.TabIndex = 11;
            this.lblTongNu.Text = "Nữ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTongNu);
            this.Controls.Add(this.lblTongNam);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTS);
            this.Controls.Add(this.dgvTT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbTTSV);
            this.Name = "Form1";
            this.Text = "Quản lý thông tin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbTTSV.ResumeLayout(false);
            this.grbTTSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTT;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblDTB;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Button btnTS;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblTongNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblTongNu;
    }
}

