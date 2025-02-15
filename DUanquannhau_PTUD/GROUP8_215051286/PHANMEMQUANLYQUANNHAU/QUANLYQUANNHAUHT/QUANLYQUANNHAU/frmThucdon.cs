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
    public partial class frmThucdon : Form
    {
        contains ctn = new contains();
        public frmThucdon()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtTenMA.Text = "";
            txtGT.Text = "";
            cbLoaiHang.Text = "";
        }
        private void Form13_Load(object sender, EventArgs e)
        {
            
            lvsThucdon.Columns.Add("Tên Món Ăn", 210);
            lvsThucdon.Columns.Add("Giá Tiền", 160);
            lvsThucdon.Columns.Add("Tên Loại Hàng", 160);
            lvsThucdon.View = View.Details;
            lvsThucdon.FullRowSelect = true;
            lvsThucdon.GridLines = true;
            string lenh1 = "Select* From THUCDON ORDER BY LoaiHang DESC";
            ctn.Hienthi3(lenh1,lvsThucdon);
            cbLoaiHang.Items.Add("Thức Ăn");
            cbLoaiHang.Items.Add("Đồ Uống");

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string lenh1 = "INSERT INTO THUCDON(MonAn,GiaTien,LoaiHang) VALUES(N'"+txtTenMA.Text+"',"+txtGT.Text+", N'"+cbLoaiHang.SelectedItem+"')";
            ctn.Khongtravegt(lenh1);
            string lenh2 = "Select* From THUCDON ORDER BY LoaiHang DESC";
            lvsThucdon.Items.Clear();
            ctn.Hienthi3(lenh2, lvsThucdon);
            txtTenMA.Enabled = true;
            Reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string lenh1 = "Update THUCDON SET GiaTien = "+txtGT.Text+", LoaiHang=N'"+cbLoaiHang.SelectedItem+"' WHERE MonAn = N'"+txtTenMA.Text+"'";
            ctn.Khongtravegt(lenh1);
            string lenh2 = "Select* From THUCDON ORDER BY LoaiHang DESC";
            lvsThucdon.Items.Clear();
            ctn.Hienthi3(lenh2, lvsThucdon);
            txtTenMA.Enabled = true;
            Reset();
        }

        private void lvsThucdon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsThucdon.SelectedItems.Count>0)
            {
                txtTenMA.Enabled = false;
                txtTenMA.Text = lvsThucdon.SelectedItems[0].Text;
                txtGT.Text = lvsThucdon.SelectedItems[0].SubItems[1].Text;
                for (int i = 0; i < cbLoaiHang.Items.Count; i++)
                {
                    if (cbLoaiHang.Items[i].ToString() == lvsThucdon.SelectedItems[0].SubItems[2].Text)
                    {
                        cbLoaiHang.Text = cbLoaiHang.Items[i].ToString();
                    }

                } 
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string lenh1 = "DELETE FROM THUCDON WHERE MonAn =N'"+txtTenMA.Text+"'";
            ctn.Khongtravegt(lenh1);
            string lenh2 = "Select* From THUCDON ORDER BY LoaiHang DESC";
            lvsThucdon.Items.Clear();
            ctn.Hienthi3(lenh2, lvsThucdon);
            txtTenMA.Enabled = true;
            Reset();
        }
    }
}