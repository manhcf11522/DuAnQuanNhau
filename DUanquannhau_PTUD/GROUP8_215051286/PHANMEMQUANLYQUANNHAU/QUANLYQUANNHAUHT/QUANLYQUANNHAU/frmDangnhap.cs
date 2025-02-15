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
    public partial class frmDangnhap : Form
    {
        contains ctn = new contains();
        public frmDangnhap()
        {
            
        
            InitializeComponent();
        }
        private void ShowForm3()
        {
            frmGiaodienchinh f3 = new frmGiaodienchinh();
            f3.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            string qh = "";
            string cat = "";
            string manv = "";
            string hd = "";
            int hd2 = 0;
            string lenh = "SELECT COUNT(*) FROM TAIKHOAN WHERE Tendangnhap='" + textBox1.Text + "' AND Matkhau='" + txtMKDN.Text + "'";
            string lenh2 = "SELECT QuyenHan FROM TAIKHOAN WHERE Tendangnhap = '" + textBox1.Text + "' AND Matkhau = '" + txtMKDN.Text + "'";
            string lenh3 = "SELECT MaNV FROM TAIKHOAN WHERE Tendangnhap = '" + textBox1.Text + "' AND Matkhau = '" + txtMKDN.Text + "'";
            string lenh4 = "SELECT COUNT(*) FROM HOADONBANHANG";
            n = ctn.HienThi1gtint(lenh);
            if (n == 1)
            {
                cat = ctn.HienThi1gtstring(lenh2);
                qh = cat.Trim();
                contains.Taikhoan.Add(textBox1.Text);
                contains.Matkhau.Add(txtMKDN.Text);
                contains.Quyenhan.Add(qh);
                cat = ctn.HienThi1gtstring(lenh3);
                manv = cat.Trim();
                contains.MaNV.Add(manv);
                hd2 = ctn.HienThi1gtint(lenh4);
                hd = (hd2 + 1).ToString();
                contains.MaHD.Add("TNM" + hd);
                Thread thread = new Thread(new ThreadStart(ShowForm3));
                thread.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tai khoan hoac mat khau");
            }
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

            foreach (var item in this.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox itemcheck = (CheckBox)item;
                    if (itemcheck.Checked == false)
                    {
                        txtMKDN.UseSystemPasswordChar = true;
                    }
                    else
                    {
                        txtMKDN.UseSystemPasswordChar = false;
                    }
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            txtMKDN.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
