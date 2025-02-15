namespace QUANLYQUANNHAU
{
    partial class frmBan
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
            this.cbTrangthai = new System.Windows.Forms.ComboBox();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.lvsBan = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaban = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvsThongtin = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTrangthai);
            this.groupBox1.Controls.Add(this.btnThanhtoan);
            this.groupBox1.Controls.Add(this.lvsBan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaban);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(29, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1091, 304);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bàn";
            // 
            // cbTrangthai
            // 
            this.cbTrangthai.FormattingEnabled = true;
            this.cbTrangthai.Location = new System.Drawing.Point(111, 137);
            this.cbTrangthai.Margin = new System.Windows.Forms.Padding(4);
            this.cbTrangthai.Name = "cbTrangthai";
            this.cbTrangthai.Size = new System.Drawing.Size(135, 25);
            this.cbTrangthai.TabIndex = 3;
            this.cbTrangthai.SelectedIndexChanged += new System.EventHandler(this.cbTrangthai_SelectedIndexChanged);
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhtoan.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThanhtoan.Location = new System.Drawing.Point(42, 206);
            this.btnThanhtoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(179, 43);
            this.btnThanhtoan.TabIndex = 6;
            this.btnThanhtoan.Text = "THANH TOÁN";
            this.btnThanhtoan.UseVisualStyleBackColor = false;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // lvsBan
            // 
            this.lvsBan.FullRowSelect = true;
            this.lvsBan.HideSelection = false;
            this.lvsBan.Location = new System.Drawing.Point(272, 23);
            this.lvsBan.Margin = new System.Windows.Forms.Padding(4);
            this.lvsBan.Name = "lvsBan";
            this.lvsBan.Size = new System.Drawing.Size(782, 246);
            this.lvsBan.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvsBan.TabIndex = 3;
            this.lvsBan.UseCompatibleStateImageBehavior = false;
            this.lvsBan.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvsBan_ItemSelectionChanged);
            this.lvsBan.SelectedIndexChanged += new System.EventHandler(this.lvsBan_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(8, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Trạng thái:";
            // 
            // txtMaban
            // 
            this.txtMaban.Location = new System.Drawing.Point(111, 58);
            this.txtMaban.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaban.Name = "txtMaban";
            this.txtMaban.Size = new System.Drawing.Size(132, 23);
            this.txtMaban.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã bàn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvsThongtin);
            this.groupBox2.Location = new System.Drawing.Point(29, 326);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1091, 297);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // lvsThongtin
            // 
            this.lvsThongtin.HideSelection = false;
            this.lvsThongtin.Location = new System.Drawing.Point(11, 23);
            this.lvsThongtin.Margin = new System.Windows.Forms.Padding(4);
            this.lvsThongtin.Name = "lvsThongtin";
            this.lvsThongtin.Size = new System.Drawing.Size(1043, 254);
            this.lvsThongtin.TabIndex = 0;
            this.lvsThongtin.UseCompatibleStateImageBehavior = false;
            // 
            // frmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1157, 626);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBan";
            this.Text = "QUẢN LÝ BÀN";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvsBan;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvsThongtin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTrangthai;
        private System.Windows.Forms.TextBox txtMaban;
    }
}