namespace QUANLYQUANNHAU
{
    partial class frmOrder
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbBan = new System.Windows.Forms.ComboBox();
            this.btnKTKH = new System.Windows.Forms.Button();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTT = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSL = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.btnChonMon = new System.Windows.Forms.Button();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lvsOrder = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbLH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvsMenu = new System.Windows.Forms.ListView();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.cmbBan);
            this.panel2.Controls.Add(this.btnKTKH);
            this.panel2.Controls.Add(this.txtSDTKH);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnTT);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1162, 613);
            this.panel2.TabIndex = 5;
            // 
            // cmbBan
            // 
            this.cmbBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbBan.FormattingEnabled = true;
            this.cmbBan.Location = new System.Drawing.Point(980, 23);
            this.cmbBan.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBan.Name = "cmbBan";
            this.cmbBan.Size = new System.Drawing.Size(160, 25);
            this.cmbBan.TabIndex = 18;
            this.cmbBan.Text = "Chọn Bàn";
            this.cmbBan.SelectedIndexChanged += new System.EventHandler(this.cmbBan_SelectedIndexChanged);
            // 
            // btnKTKH
            // 
            this.btnKTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKTKH.Location = new System.Drawing.Point(1038, 182);
            this.btnKTKH.Name = "btnKTKH";
            this.btnKTKH.Size = new System.Drawing.Size(107, 35);
            this.btnKTKH.TabIndex = 17;
            this.btnKTKH.Text = "Kiểm tra";
            this.btnKTKH.UseVisualStyleBackColor = true;
            this.btnKTKH.Click += new System.EventHandler(this.btnKTKH_Click);
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(980, 141);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(160, 22);
            this.txtSDTKH.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(914, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Số Điện hoại hách hàng";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(915, 417);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 74);
            this.button2.TabIndex = 12;
            this.button2.Text = "ORDER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(913, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bàn:";
            // 
            // btnTT
            // 
            this.btnTT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTT.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTT.Location = new System.Drawing.Point(912, 510);
            this.btnTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(241, 79);
            this.btnTT.TabIndex = 5;
            this.btnTT.Text = "THANH TOÁN";
            this.btnTT.UseVisualStyleBackColor = false;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSL);
            this.groupBox4.Controls.Add(this.txtTenMon);
            this.groupBox4.Controls.Add(this.txtGia);
            this.groupBox4.Controls.Add(this.numSL);
            this.groupBox4.Controls.Add(this.btnChonMon);
            this.groupBox4.Controls.Add(this.lblGia);
            this.groupBox4.Controls.Add(this.lblTenMon);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.lvsOrder);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(423, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(484, 602);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ORDER";
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(387, 41);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(77, 17);
            this.lblSL.TabIndex = 13;
            this.lblSL.Text = "Số Lượng";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(13, 85);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(163, 23);
            this.txtTenMon.TabIndex = 12;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(219, 85);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(146, 23);
            this.txtGia.TabIndex = 11;
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(390, 85);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(53, 23);
            this.numSL.TabIndex = 10;
            // 
            // btnChonMon
            // 
            this.btnChonMon.Location = new System.Drawing.Point(219, 130);
            this.btnChonMon.Name = "btnChonMon";
            this.btnChonMon.Size = new System.Drawing.Size(106, 33);
            this.btnChonMon.TabIndex = 9;
            this.btnChonMon.Text = "Chọn Món";
            this.btnChonMon.UseVisualStyleBackColor = true;
            this.btnChonMon.Click += new System.EventHandler(this.btnChonMon_Click);
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(216, 41);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(33, 17);
            this.lblGia.TabIndex = 8;
            this.lblGia.Text = "Giá";
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Location = new System.Drawing.Point(10, 41);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(71, 17);
            this.lblTenMon.TabIndex = 7;
            this.lblTenMon.Text = "Tên Món";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(349, 130);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "XÓA MÓN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvsOrder
            // 
            this.lvsOrder.HideSelection = false;
            this.lvsOrder.Location = new System.Drawing.Point(13, 180);
            this.lvsOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvsOrder.Name = "lvsOrder";
            this.lvsOrder.Size = new System.Drawing.Size(464, 405);
            this.lvsOrder.TabIndex = 0;
            this.lvsOrder.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMaHD);
            this.groupBox2.Controls.Add(this.lblMaNV);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(399, 110);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HÓA ĐƠN";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(285, 69);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(23, 17);
            this.lblMaHD.TabIndex = 5;
            this.lblMaHD.Text = "...";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(118, 69);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(23, 17);
            this.lblMaNV.TabIndex = 4;
            this.lblMaNV.Text = "...";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(68, 32);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 23);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2023, 9, 29, 15, 27, 3, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(192, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã hóa đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(15, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(15, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbLH);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lvsMenu);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(3, 119);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(399, 485);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "THỰC ĐƠN";
            // 
            // cmbLH
            // 
            this.cmbLH.FormattingEnabled = true;
            this.cmbLH.Location = new System.Drawing.Point(195, 22);
            this.cmbLH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLH.Name = "cmbLH";
            this.cmbLH.Size = new System.Drawing.Size(140, 25);
            this.cmbLH.TabIndex = 3;
            this.cmbLH.SelectedIndexChanged += new System.EventHandler(this.cmbLH_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(107, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại hàng:";
            // 
            // lvsMenu
            // 
            this.lvsMenu.HideSelection = false;
            this.lvsMenu.Location = new System.Drawing.Point(5, 63);
            this.lvsMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvsMenu.Name = "lvsMenu";
            this.lvsMenu.Size = new System.Drawing.Size(384, 405);
            this.lvsMenu.TabIndex = 0;
            this.lvsMenu.UseCompatibleStateImageBehavior = false;
            this.lvsMenu.View = System.Windows.Forms.View.Details;
            this.lvsMenu.SelectedIndexChanged += new System.EventHandler(this.lvsMenu_SelectedIndexChanged);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 616);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOrder";
            this.Text = "ORDER";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvsOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvsMenu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Button btnChonMon;
        private System.Windows.Forms.Button btnKTKH;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.ComboBox cmbLH;
        private System.Windows.Forms.ComboBox cmbBan;
    }
}