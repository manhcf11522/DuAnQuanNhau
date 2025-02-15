using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYQUANNHAU
{
    public partial class frmDoimatkhau : Form
    {
        contains ctn = new contains();
        public frmDoimatkhau()
        {
            InitializeComponent();
        }
        private void ShowForm1()
        {
            frmDangnhap f1 = new frmDangnhap();
            f1.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (contains.Quyenhan[0] != "QL")
            {
                if (textBox1.Text != contains.Taikhoan[0] || txtMKCu.Text != contains.Matkhau[0])
                {
                    MessageBox.Show("Mat khau cu hoac tai khoan cu khong dung");
                }

                if (textBox1.Text == contains.Taikhoan[0] && txtMKCu.Text == contains.Matkhau[0])
                {
                    if (txtMKMoi.Text == txtXNMK.Text)
                    {
                        string tk = "";
                        int n = 0;
                        string lenh = "SELECT COUNT(*) FROM TAIKHOAN WHERE Tendangnhap='" + textBox1.Text + "' AND Matkhau='" + txtMKCu.Text + "'";
                        string lenh2 = "UPDATE TAIKHOAN SET Tendangnhap = '" + textBox1.Text + "' , Matkhau = '" + txtXNMK.Text + "'  WHERE  Tendangnhap = '" + textBox1.Text + "' AND Matkhau = '" + txtMKCu.Text + "'";
                        n = ctn.HienThi1gtint(lenh);
                        if (n == 1)
                        {
                            ctn.Khongtravegt(lenh2);
                            MessageBox.Show("Da doi mat khau thanh cong\n Vui long dang nhap lai");
                            Thread thread = new Thread(new ThreadStart(ShowForm1));
                            thread.Start();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Mat khau cu hoac tai khoan cu khong dung");
                            textBox1.Text = "";
                            txtMKCu.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xac Nhan Mat Khau Moi khong dung\n Vui long nhap lai");
                    }
                }
            }
            else
            {
                if (txtMKMoi.Text == txtXNMK.Text)
                {
                    string tk = "";
                    int n = 0;
                    string lenh = "SELECT COUNT(*) FROM TAIKHOAN WHERE Tendangnhap='" + textBox1.Text + "' AND Matkhau='" + txtMKCu.Text + "'";
                    string lenh2 = "UPDATE TAIKHOAN SET Tendangnhap = '" + textBox1.Text + "' , Matkhau = '" + txtXNMK.Text + "'  WHERE  Tendangnhap = '" + textBox1.Text + "' AND Matkhau = '" + txtMKCu.Text + "'";
                    n = ctn.HienThi1gtint(lenh);
                    if (n == 1)
                    {
                        ctn.Khongtravegt(lenh2);
                        MessageBox.Show("Da doi mat khau thanh cong\n Vui long dang nhap lai");
                        Thread thread = new Thread(new ThreadStart(ShowForm1));
                        thread.Start();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mat khau cu hoac tai khoan cu khong dung");
                        textBox1.Text = "";
                        txtMKCu.Text = "";
                        txtMKMoi.Text = "";
                        txtXNMK.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Xac Nhan Mat Khau Moi khong dung\n Vui long nhap lai");
                }
            }

        }
        private void Form2_Load(object sender, EventArgs e)
        {

            txtMKCu.UseSystemPasswordChar = true;
            txtMKMoi.UseSystemPasswordChar = true;
            txtXNMK.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox itemcheck = (CheckBox)item;
                    if (itemcheck.Checked == false)
                    {
                        txtMKCu.UseSystemPasswordChar = true;
                        txtMKMoi.UseSystemPasswordChar = true;
                        txtXNMK.UseSystemPasswordChar = true;
                    }
                    else
                    {
                        txtMKCu.UseSystemPasswordChar = false;
                        txtMKMoi.UseSystemPasswordChar = false;
                        txtXNMK.UseSystemPasswordChar = false;
                    }
                }
            }
        }
    }
}
