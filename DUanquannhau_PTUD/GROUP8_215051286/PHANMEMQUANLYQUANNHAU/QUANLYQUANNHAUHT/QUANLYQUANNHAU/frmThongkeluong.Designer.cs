namespace QUANLYQUANNHAU
{
    partial class frmThongkeluong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaNVCA = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemCa = new System.Windows.Forms.Button();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvsCalam = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaluong = new System.Windows.Forms.Button();
            this.btnSualuong = new System.Windows.Forms.Button();
            this.btnThemluong = new System.Windows.Forms.Button();
            this.cbxkyluong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNVLuong = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lvsTongluong = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.txtMaNVCA);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThemCa);
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lvsCalam);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(578, 608);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý ca làm";
            // 
            // txtMaNVCA
            // 
            this.txtMaNVCA.Location = new System.Drawing.Point(230, 32);
            this.txtMaNVCA.Name = "txtMaNVCA";
            this.txtMaNVCA.Size = new System.Drawing.Size(263, 23);
            this.txtMaNVCA.TabIndex = 14;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(400, 511);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(230, 511);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemCa
            // 
            this.btnThemCa.Location = new System.Drawing.Point(70, 511);
            this.btnThemCa.Name = "btnThemCa";
            this.btnThemCa.Size = new System.Drawing.Size(75, 23);
            this.btnThemCa.TabIndex = 9;
            this.btnThemCa.Text = "THÊM";
            this.btnThemCa.UseVisualStyleBackColor = true;
            this.btnThemCa.Click += new System.EventHandler(this.btnThemCa_Click);
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "yyyy-MM-dd";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(230, 69);
            this.dtpNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(263, 23);
            this.dtpNgay.TabIndex = 6;
            this.dtpNgay.Value = new System.DateTime(2023, 10, 14, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã nhân viên:";
            // 
            // lvsCalam
            // 
            this.lvsCalam.HideSelection = false;
            this.lvsCalam.Location = new System.Drawing.Point(0, 106);
            this.lvsCalam.Margin = new System.Windows.Forms.Padding(4);
            this.lvsCalam.Name = "lvsCalam";
            this.lvsCalam.Size = new System.Drawing.Size(578, 380);
            this.lvsCalam.TabIndex = 1;
            this.lvsCalam.UseCompatibleStateImageBehavior = false;
            this.lvsCalam.SelectedIndexChanged += new System.EventHandler(this.lvsCalam_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.btnXoaluong);
            this.groupBox2.Controls.Add(this.btnSualuong);
            this.groupBox2.Controls.Add(this.btnThemluong);
            this.groupBox2.Controls.Add(this.cbxkyluong);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaNVLuong);
            this.groupBox2.Controls.Add(this.txtLuong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lvsTongluong);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(602, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(560, 608);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý lương";
            // 
            // btnXoaluong
            // 
            this.btnXoaluong.Location = new System.Drawing.Point(414, 511);
            this.btnXoaluong.Name = "btnXoaluong";
            this.btnXoaluong.Size = new System.Drawing.Size(75, 23);
            this.btnXoaluong.TabIndex = 21;
            this.btnXoaluong.Text = "XÓA";
            this.btnXoaluong.UseVisualStyleBackColor = true;
            this.btnXoaluong.Click += new System.EventHandler(this.btnXoaluong_Click);
            // 
            // btnSualuong
            // 
            this.btnSualuong.Location = new System.Drawing.Point(265, 511);
            this.btnSualuong.Name = "btnSualuong";
            this.btnSualuong.Size = new System.Drawing.Size(75, 23);
            this.btnSualuong.TabIndex = 20;
            this.btnSualuong.Text = "SỬA";
            this.btnSualuong.UseVisualStyleBackColor = true;
            this.btnSualuong.Click += new System.EventHandler(this.btnSualuong_Click);
            // 
            // btnThemluong
            // 
            this.btnThemluong.Location = new System.Drawing.Point(108, 511);
            this.btnThemluong.Name = "btnThemluong";
            this.btnThemluong.Size = new System.Drawing.Size(75, 23);
            this.btnThemluong.TabIndex = 19;
            this.btnThemluong.Text = "THÊM";
            this.btnThemluong.UseVisualStyleBackColor = true;
            this.btnThemluong.Click += new System.EventHandler(this.btnThemluong_Click);
            // 
            // cbxkyluong
            // 
            this.cbxkyluong.FormattingEnabled = true;
            this.cbxkyluong.Items.AddRange(new object[] {
            "Tháng 10/2023",
            "Tháng 11/2023",
            "Tháng 12/2023",
            "Tháng 1/2024",
            "Tháng 2/2024",
            "Tháng 3/2024"});
            this.cbxkyluong.Location = new System.Drawing.Point(172, 95);
            this.cbxkyluong.Name = "cbxkyluong";
            this.cbxkyluong.Size = new System.Drawing.Size(263, 25);
            this.cbxkyluong.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kỳ lương:";
            // 
            // txtMaNVLuong
            // 
            this.txtMaNVLuong.Location = new System.Drawing.Point(172, 29);
            this.txtMaNVLuong.Name = "txtMaNVLuong";
            this.txtMaNVLuong.Size = new System.Drawing.Size(263, 23);
            this.txtMaNVLuong.TabIndex = 15;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(172, 63);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(263, 23);
            this.txtLuong.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tổng lương:";
            // 
            // lvsTongluong
            // 
            this.lvsTongluong.HideSelection = false;
            this.lvsTongluong.Location = new System.Drawing.Point(0, 127);
            this.lvsTongluong.Margin = new System.Windows.Forms.Padding(4);
            this.lvsTongluong.Name = "lvsTongluong";
            this.lvsTongluong.Size = new System.Drawing.Size(568, 359);
            this.lvsTongluong.TabIndex = 1;
            this.lvsTongluong.UseCompatibleStateImageBehavior = false;
            this.lvsTongluong.SelectedIndexChanged += new System.EventHandler(this.lvsTongluong_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã nhân viên:";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1161, 559);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form11";
            this.Text = "THỐNG KÊ LƯƠNG ";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvsCalam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvsTongluong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemCa;
        private System.Windows.Forms.TextBox txtMaNVLuong;
        private System.Windows.Forms.TextBox txtMaNVCA;
        private System.Windows.Forms.ComboBox cbxkyluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoaluong;
        private System.Windows.Forms.Button btnSualuong;
        private System.Windows.Forms.Button btnThemluong;
    }
}