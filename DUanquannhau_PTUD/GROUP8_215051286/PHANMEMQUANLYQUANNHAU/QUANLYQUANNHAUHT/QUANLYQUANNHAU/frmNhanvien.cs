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
using System.Security.Claims;

namespace QUANLYQUANNHAU
{

    public partial class frmNhanvien : Form
    {
        contains ctn = new contains();
        public frmNhanvien()
        {
            InitializeComponent();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            txtTimkiem.Text = "";
            lvsNhanvien.Items.Clear();
            lvsNhanvien.Columns.Add("Mã Nhân Viên ", 90);
            lvsNhanvien.Columns.Add("Tên Nhân Viên", 150);
            lvsNhanvien.Columns.Add("Giới tính", 90);
            lvsNhanvien.Columns.Add("SDT", 90);
            lvsNhanvien.Columns.Add("Chức Vụ", 80);
            lvsNhanvien.Columns.Add("Ngày sinh ", 80);
            lvsNhanvien.View = View.Details;
            lvsNhanvien.FullRowSelect = true;
            lvsNhanvien.GridLines = true;
            string lenh1 = "Select* From NHANVIEN";
            DataTable dt = ctn.Hienthi4(lenh1);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lvsNhanvien.Items.Add(item);
            }
        }
        private void lvsNhanvien_SelectedIndexChanged(object sender, EventArgs e)// Chọn hàng
        {
            if (lvsNhanvien.SelectedItems.Count>0)
            {
                txtMaNV.Text = lvsNhanvien.SelectedItems[0].Text;
                txtTenNV.Text = lvsNhanvien.SelectedItems[0].SubItems[1].Text;
                string gioitinh = "";
                gioitinh = lvsNhanvien.SelectedItems[0].SubItems[2].Text;
                string gioitinh2 = gioitinh.Trim();
                if (gioitinh2 == radNam.Text)
                {
                    radNam.Checked = true;
                }
                if (gioitinh2 == radNu.Text)
                {
                    radNu.Checked = true;
                }
                txtSDT.Text = lvsNhanvien.SelectedItems[0].SubItems[3].Text;
                txtChucvu.Text = lvsNhanvien.SelectedItems[0].SubItems[4].Text;
                dtpNgaysinh.Text = lvsNhanvien.SelectedItems[0].SubItems[5].Text;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)//Thêm
        {
            RadioButton ra = new RadioButton();
            foreach (var item in this.Controls)
            {

                if (item is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)item;

                    foreach (var item2 in groupBox.Controls)
                    {
                        if (item2 is RadioButton)
                        {
                            RadioButton radioButton = (RadioButton)item2;
                            if (radioButton.Checked)
                            {
                                ra.Text = radioButton.Text;

                            }
                        }
                    }
                }
            }
            
            string lenh1 = "INSERT INTO NHANVIEN(MaNV, TenNV, Gioitinh, SDT, Chucvu, Ngaysinh) VALUES(N'" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + ra.Text + "','" + txtSDT.Text + "',N'" + txtChucvu.Text + "','" + dtpNgaysinh.Text +  "')";
            ctn.Khongtravegt(lenh1);
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            ra.Text = "";
            txtSDT.Text = "";
            txtChucvu.Text = "";
            dtpNgaysinh.Text = "";
            ListViewItem listView = new System.Windows.Forms.ListViewItem(new String[] { txtMaNV.Text, txtTenNV.Text, ra.Text, txtSDT.Text, txtChucvu.Text, dtpNgaysinh.Text});
            string lenh2 = "Select* From NHANVIEN";
            lvsNhanvien.Items.Clear();
            ctn.Hienthi6(lenh2, lvsNhanvien);
        }
        private void btnCapnhat_Click(object sender, EventArgs e)// Cập nhật
        {
            RadioButton ra = new RadioButton();
            foreach (var item in this.Controls)
            {

                if (item is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)item;

                    foreach (var item2 in groupBox.Controls)
                    {
                        if (item2 is RadioButton)
                        {
                            RadioButton radioButton = (RadioButton)item2;
                            if (radioButton.Checked)
                            {
                                ra.Text = radioButton.Text;
                            }
                        }
                    }
                }
            }
            string lenh1 = "UPDATE NHANVIEN  SET MaNV= N'" + txtMaNV.Text + "', TenNV = N'" + txtTenNV.Text + "', Gioitinh = N'" + ra.Text + "' , SDT= '" + txtSDT.Text + "' , Chucvu= N'" + txtChucvu.Text + "', Ngaysinh= '" + dtpNgaysinh.Text + "'WHERE MaNV = N'" + txtMaNV.Text +"'";
            ctn.Khongtravegt(lenh1);
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtChucvu.Text = "";
            dtpNgaysinh.Text = "";
            string lenh2 = "Select* From NHANVIEN";
            lvsNhanvien.Items.Clear();
            ctn.Hienthi6(lenh2, lvsNhanvien);
        }
        private void btnXoa_Click(object sender, EventArgs e)// Xóa
        {
            RadioButton ra = new RadioButton();
            foreach (var item in this.Controls)
            {

                if (item is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)item;

                    foreach (var item2 in groupBox.Controls)
                    {
                        if (item2 is RadioButton)
                        {
                            RadioButton radioButton = (RadioButton)item2;
                            if (radioButton.Checked)
                            {
                                ra.Text = radioButton.Text;

                            }
                        }
                    }
                }
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa không ? ", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                string lenh1 = "delete from LUONGNHANVIEN where MaNV= '" + txtMaNV.Text + "'";
                ctn.Khongtravegt(lenh1);
                string lenh2 = "delete from TAIKHOAN where MaNV ='" + txtMaNV.Text + "'";
                ctn.Khongtravegt(lenh2);
                string lenh3 = "delete from HOADONBANHANG where MaNV ='" + txtMaNV.Text + "'";
                ctn.Khongtravegt(lenh3);
                string lenh5 = "delete from CALAMVIEC where MaNV ='" + txtMaNV.Text + "'";
                ctn.Khongtravegt(lenh5);
                string lenh6 = "delete from NHANVIEN where MaNV= '" + txtMaNV.Text + "'";
                ctn.Khongtravegt(lenh6);
                lvsNhanvien.Items.Clear();
            }
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtChucvu.Text = "";
            dtpNgaysinh.Text = "";
            string lenh = "Select* From NHANVIEN";
            ctn.Hienthi6(lenh, lvsNhanvien);
        }      
        private void btnTim_Click(object sender, EventArgs e)// Tìm kiếm
        {
            if (txtTimkiem.Text != "")
            {
                string lenh1 = "SELECT * FROM NHANVIEN WHERE MaNV= '" + txtTimkiem.Text + "'";
                lvsNhanvien.Items.Clear();
                ctn.Hienthi6(lenh1, lvsNhanvien);
            }
            else
            {
                string lenh2 = "SELECT * FROM NHANVIEN";
                lvsNhanvien.Items.Clear();
                ctn.Hienthi6(lenh2, lvsNhanvien);
            }
        }
    }
}
