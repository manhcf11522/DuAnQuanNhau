using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QUANLYQUANNHAU
{
    public partial class frmThongkeluong : Form
    {
        contains ctn = new contains();
        public frmThongkeluong()
        {
            InitializeComponent();
        }
        private void Form11_Load(object sender, EventArgs e)
        {
            // bảng listview Quản lý ca làm
            lvsCalam.Columns.Add("Mã Nhân viên", 110);
            lvsCalam.Columns.Add("Ngày", 90);
            lvsCalam.View = View.Details;
            lvsCalam.GridLines = true;
            lvsCalam.FullRowSelect = true;
            string lenh1 = "Select* From CALAMVIEC";
            ctn.Hienthi2(lenh1, lvsCalam);
            // bảng listview Quản lý lương
            lvsTongluong.Columns.Add("Mã nhân viên", 90);
            lvsTongluong.Columns.Add("Tổng lương", 110);
            lvsTongluong.Columns.Add("Kỳ lương", 110);
            lvsTongluong.View = View.Details;
            lvsTongluong.GridLines = true;
            lvsTongluong.FullRowSelect = true;
            string lenh2 = "Select* From LUONGNHANVIEN";
            ctn.Hienthi3(lenh2, lvsTongluong);
        }
        private void ResetCa()
        {
            txtMaNVCA.Text = "";
        }
        private void ResetLuong()
        {
            txtMaNVLuong.Text = "";
            txtLuong.Text = "";
            cbxkyluong.Text = "";
        }
        private void lvsCalam_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaNVCA.Text = lvsCalam.SelectedItems[0].Text;
            dtpNgay.Text = lvsCalam.SelectedItems[0].SubItems[1].Text;
            string lenh = "SELECT * FROM CALAMVIEC";
            lvsCalam.Items.Clear();
            ctn.Hienthi2(lenh, lvsCalam);
        }
        private void lvsTongluong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaNVLuong.Text = lvsTongluong.SelectedItems[0].Text;
            txtLuong.Text = lvsTongluong.SelectedItems[0].SubItems[1].Text;
            cbxkyluong.Text = lvsTongluong.SelectedItems[0].SubItems[2].Text;
            string lenh = "SELECT * FROM LUONGNHANVIEN";
            lvsTongluong.Items.Clear();
            ctn.Hienthi3(lenh, lvsTongluong);
        }
        private void btnThemCa_Click(object sender, EventArgs e)
        {
            string lenh1 = "INSERT INTO CALAMVIEC(MaNV,Ngay) VALUES('" + txtMaNVCA.Text +  "','" + dtpNgay.Text + "')";
            ctn.Khongtravegt(lenh1);
            txtMaNVCA.Text = "";
            dtpNgay.Text = "";
            ListViewItem listView = new System.Windows.Forms.ListViewItem(new String[] { txtMaNVCA.Text, dtpNgay.Text});
            string lenh2 = "Select* From CALAMVIEC";
            lvsCalam.Items.Clear();
            ctn.Hienthi2(lenh2, lvsCalam);
            ResetCa();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa không ? ", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                string lenh = "DELETE FROM LUONGNHANVIEN WHERE MaNV = '" + txtMaNVCA.Text + "'";
                ctn.Khongtravegt(lenh);
                string lenh1 = "DELETE FROM CALAMVIEC WHERE MaNV = '" + txtMaNVCA.Text + "'";
                ctn.Khongtravegt(lenh1);
                lvsCalam.Items.Clear();
            }
            string lenh2 = "SELECT * FROM CALAMVIEC";
            ctn.Hienthi2(lenh2, lvsCalam);
            ResetCa();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string lenh = "UPDATE CALAMVIEC SET MaNV= N'" + txtMaNVCA.Text + "',Ngay = '" + dtpNgay.Text + "' WHERE MaNV = '" + txtMaNVCA.Text + "'";
            ctn.Khongtravegt(lenh);
            txtMaNVCA.Text = "";
            dtpNgay.Text = "";
            string lenh1 = "SELECT * FROM CALAMVIEC";
            lvsCalam.Items.Clear();
            ctn.Hienthi2(lenh1, lvsCalam);
            ResetCa();
        }
        private void btnThemluong_Click(object sender, EventArgs e)
        {
            string lenh1 = "INSERT INTO LUONGNHANVIEN(MaNV,Tongluong,Kyluong) VALUES('" + txtMaNVLuong.Text + "'," + txtLuong.Text + ",N'" + cbxkyluong.Text + "')";
            ctn.Khongtravegt(lenh1);
            txtMaNVLuong.Text = "";
            txtLuong.Text = "";
            cbxkyluong.Text = "";
            ListViewItem listView = new System.Windows.Forms.ListViewItem(new String[] { txtMaNVLuong.Text,txtLuong.Text,cbxkyluong.Text });
            string lenh2 = "Select* From LUONGNHANVIEN";
            lvsTongluong.Items.Clear();
            ctn.Hienthi3(lenh2, lvsTongluong);
            ResetLuong();
        }
        private void btnSualuong_Click(object sender, EventArgs e)
        {
            string lenh = "UPDATE LUONGNHANVIEN SET MaNV= N'" + txtMaNVLuong.Text + "', Tongluong = '" + txtLuong.Text + "', Kyluong = N'" + cbxkyluong.Text + "'";
            ctn.Khongtravegt(lenh);
            txtMaNVLuong.Text = "";
            txtLuong.Text = "";
            cbxkyluong.Text = "";
            string lenh2 = "Select* From LUONGNHANVIEN";
            lvsTongluong.Items.Clear();
            ctn.Hienthi3(lenh2, lvsTongluong);
            ResetLuong();
        }
        private void btnXoaluong_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa không ? ", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                string lenh1 = "DELETE  FROM LUONGNHANVIEN WHERE Kyluong ='" + cbxkyluong.Text + "'";
                ctn.Khongtravegt(lenh1);
                MessageBox.Show("Bạn đã xóa thành công!");
                lvsTongluong.Items.Clear();
            }
            string lenh2= "SELECT * FROM LUONGNHANVIEN";
            ctn.Hienthi3(lenh2, lvsTongluong);
            ResetLuong();
        }
    }
}
