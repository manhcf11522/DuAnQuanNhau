using System;
using System.Windows.Forms;
using System.Threading;

namespace QUANLYQUANNHAU

{
    public partial class frmGiaodienchinh : Form
    {
        public frmGiaodienchinh()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = btnBanHang.Text;
            panel2.Controls.Clear();
            frmOrder f3 = new frmOrder();
            f3.TopLevel = false;
            panel2.Controls.Add(f3);
            f3.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f3.Dock = DockStyle.Fill;
            f3.Show();
        }
        private void ShowForm2()
        {
            frmDoimatkhau f2 = new frmDoimatkhau();
            f2.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowForm2)); 
            thread.Start(); 
            this.Close(); 

        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = btnQLKH.Text;
            panel2.Controls.Clear();
            frmKhachhang f5 = new frmKhachhang();
            f5.TopLevel = false;
            panel2.Controls.Add(f5);
            f5.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f5.Dock = DockStyle.Fill;
            f5.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = btnQLNV.Text;
            panel2.Controls.Clear();
            frmNhanvien f7 = new frmNhanvien();
            f7.TopLevel = false;
            panel2.Controls.Add(f7);
            f7.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f7.Dock = DockStyle.Fill;
            f7.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            label1.Text = btnBan.Text;
            panel2.Controls.Clear();
            frmBan f9 = new frmBan();
            f9.TopLevel = false;
            panel2.Controls.Add(f9);
            f9.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f9.Dock = DockStyle.Fill;
            f9.Show();
        }


        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = btnTKL.Text;
            panel2.Controls.Clear();
            frmThongkeluong f11 = new frmThongkeluong();
            f11.TopLevel = false;
            panel2.Controls.Add(f11);
            f11.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f11.Dock = DockStyle.Fill;
            f11.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            label1.Text = btnBanHang.Text;
            panel2.Controls.Clear();
            frmOrder f3 = new frmOrder();
            f3.TopLevel = false;
            panel2.Controls.Add(f3);
            f3.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f3.Dock = DockStyle.Fill;
            f3.Show();
            if (contains.Quyenhan[0] !="QL")
            {
                
             
                btnQLNV.Hide();
                btnTKL.Hide();
                btnThucdon.Hide();
            }

        }

        

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = btnBanHang.Text;
            panel2.Controls.Clear();
            frmThucdon f13 = new frmThucdon();
            f13.TopLevel = false;
            panel2.Controls.Add(f13);
            f13.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f13.Dock = DockStyle.Fill;
            f13.Show();
        }
    }  
}
