using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYQUANNHAU
{
    public partial class frmKhachhang : Form
    {
        contains cnt = new contains();
        public frmKhachhang()
        {
            InitializeComponent();
        }

        private void lviKhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviKhachhang.SelectedItems.Count > 0)
            {
                txtTim.Text = lviKhachhang.SelectedItems[0].SubItems[0].Text;
                txtMakhachhang.Text = lviKhachhang.SelectedItems[0].SubItems[0].Text;
                txtTenkhachhang.Text = lviKhachhang.SelectedItems[0].SubItems[1].Text;
                txtSdt.Text = lviKhachhang.SelectedItems[0].SubItems[2].Text;
                cbxLoaikhachhang.Text = lviKhachhang.SelectedItems[0].SubItems[3].Text;
                txtDtl.Text = lviKhachhang.SelectedItems[0].SubItems[4].Text; 
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string lenh2 = "Select* From KHACHHANG";
            lviKhachhang.Items.Clear();
            lviKhachhang.Columns.Add("Mã khách hàng", 100);
            lviKhachhang.Columns.Add("Tên khách hàng", 100);
            lviKhachhang.Columns.Add("SĐT", 100);
            lviKhachhang.Columns.Add("Loai khach hang", 100);
            lviKhachhang.Columns.Add("Diem TL", 100);
            lviKhachhang.View = View.Details;
            DataTable dt = cnt.Hienthi4(lenh2);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lviKhachhang.Items.Add(item);
            }

            string lenh4 = "SELECT HOADONBANHANG.MaHDBH, MONANDABAN.MonAn,MONANDABAN.SoLuong,MONANDABAN.GiaTien FROM MONANDABAN JOIN HOADONBANHANG ON MONANDABAN.MaHDBH = HOADONBANHANG.MaHDBH";
            lsvLichSuGiaoDich.Items.Clear();
            lsvLichSuGiaoDich.Columns.Add("Mã hóa đơn", 100);
            lsvLichSuGiaoDich.Columns.Add("Tên món ăn", 200);
            lsvLichSuGiaoDich.Columns.Add("Số Lượng", 100);
            lsvLichSuGiaoDich.Columns.Add("Tiền đã trả", 100);
            lsvLichSuGiaoDich.View = View.Details;
            DataTable dt2 = cnt.Hienthi4(lenh4);
            foreach (DataRow row in dt2.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt2.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lsvLichSuGiaoDich.Items.Add(item);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string lenh1 = "INSERT INTO KHACHHANG(MaKH, TenKH,SDT,LoaiKH,DiemTL) VALUES ('" + txtMakhachhang.Text + "', N'" + txtTenkhachhang.Text + "' ,'" + txtSdt.Text + "' , N'" + cbxLoaikhachhang.Text + "' ,  '" + txtDtl.Text + "')";
            cnt.Khongtravegt(lenh1);
            txtMakhachhang.Text = "";
            txtTenkhachhang.Text = "";
            txtSdt.Text = "";
            cbxLoaikhachhang.Text = "";
            txtDtl.Text = "";
            MessageBox.Show("Bạn đã thêm thành công!");
            string lenh2 = "Select* From KHACHHANG";
            lviKhachhang.Items.Clear();
            DataTable dt = cnt.Hienthi4(lenh2);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lviKhachhang.Items.Add(item);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string lenh1 = "UPDATE KHACHHANG SET TenKH= N'" + txtTenkhachhang.Text + "' , SDT = '" + txtSdt.Text + "' , LoaiKH = N'" + cbxLoaikhachhang.Text + "' , DiemTL = '" + txtDtl.Text + "' WHERE MaKH = '" + txtMakhachhang.Text + "'";
            cnt.Khongtravegt(lenh1);
            txtTim.Text = "";
            txtMakhachhang.Text = "";
            txtTenkhachhang.Text = "";
            txtSdt.Text = "";
            cbxLoaikhachhang.Text = "";
            txtDtl.Text = "";
            MessageBox.Show("Bạn dã cập nhật thành công!");
            string lenh2 = "Select* From KHACHHANG";
            lviKhachhang.Items.Clear();
            DataTable dt = cnt.Hienthi4(lenh2);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lviKhachhang.Items.Add(item);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lviKhachhang.SelectedItems.Count > 0)
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    string lenh2 = "DELETE FROM HOADONBANHANG WHERE MaNV='" + txtMakhachhang + "'";

                    cnt.Khongtravegt(lenh2);

                    string lenh1 = "DELETE FROM KHACHHANG WHERE MaKH = '" + txtMakhachhang.Text + "'";
                    cnt.Khongtravegt(lenh1);
                    MessageBox.Show("Bạn đã xóa thành công!");
                    lviKhachhang.Items.Clear();
                }
                txtTim.Text = "";
                txtMakhachhang.Text = "";
                txtTenkhachhang.Text = "";
                txtSdt.Text = "";
                cbxLoaikhachhang.Text = "";
                txtDtl.Text = "";
                string lenh3 = "SELECT *FROM KHACHHANG";
                DataTable dt = cnt.Hienthi4(lenh3);
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    lviKhachhang.Items.Add(item);
                }
            }
            else
                MessageBox.Show("Cần chọn dòng để xóa!!!");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text != "")
            {
                string lenh1 = "SELECT *FROM KHACHHANG WHERE MaKH= '" + txtTim.Text + "'";
                string lenh2 = "SELECT HOADONBANHANG.MaHDBH, MONANDABAN.MonAn,MONANDABAN.SoLuong,MONANDABAN.GiaTien FROM MONANDABAN JOIN HOADONBANHANG ON MONANDABAN.MaHDBH = HOADONBANHANG.MaHDBH WHERE HOADONBANHANG.MaKH ='" + txtTim.Text + "'";

                lviKhachhang.Items.Clear();
                lsvLichSuGiaoDich.Items.Clear();
                DataTable dt = cnt.Hienthi4(lenh1);
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    lviKhachhang.Items.Add(item);
                }
                DataTable dt2 = cnt.Hienthi4(lenh2);
                foreach (DataRow row in dt2.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dt2.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    lsvLichSuGiaoDich.Items.Add(item);
                }
            }
        }
    }
}
