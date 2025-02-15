using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYQUANNHAU
{
    public partial class frmOrder : Form
    {
        contains cnt = new contains();
        public frmOrder()
        {
            InitializeComponent();
        }
        private void ShowForm4()
        {
            frmThanhtoan f4 = new frmThanhtoan();
            f4.ShowDialog();

        }
        private void Form8_Load(object sender, EventArgs e)
        {
            //debug maHD :v
            string lenh4 = "SELECT COUNT(*) FROM HOADONBANHANG";
            string manv = "";
            string hd = "";
            int hd2 = 0;
            hd2 = cnt.HienThi1gtint(lenh4);
            hd = (hd2 + 1).ToString();
            contains.MaHD.Add("TNM" + hd);
            for (int i = contains.MaHD.Count - 1; i < contains.MaHD.Count; i++)
            {
                contains.MaHD[0] = contains.MaHD[i];
            }
            dateTimePicker1.Enabled = false;
            txtSDTKH.Text = "";
            lblMaNV.Text = contains.MaNV[0];
            lblMaHD.Text = contains.MaHD[0];
            dateTimePicker1.Value = DateTime.Now;
            contains.NgayHDBH.Add(dateTimePicker1.Text);
            lvsMenu.Columns.Add("Mon an", 200);
            lvsMenu.Columns.Add("Gia tien", 100);
            lvsMenu.View = View.Details;
            lvsMenu.FullRowSelect = true;
            lvsOrder.Columns.Add("Mon an", 200);
            lvsOrder.Columns.Add("Gia tien", 100);
            lvsOrder.Columns.Add("SL", 100);
            lvsOrder.View = View.Details;
            lvsOrder.FullRowSelect = true;
            cmbBan.Items.Add("Mang Về");
            for (int i = 0; i < 10; i++)
            {
                if(i<9)
                cmbBan.Items.Add("Bàn 0" + (i + 1));
                else
                {
                    cmbBan.Items.Add("Bàn " + (i + 1));
                }

            }
            cmbLH.Items.Add("Thức Ăn");
            cmbLH.Items.Add("Đồ Uống");
            string lenh1 = "Select* From THUCDON ORDER BY LoaiHang DESC";
            cnt.Hienthi2(lenh1, lvsMenu);
            lvsOrder.Items.Clear();
            cnt.HienThict(lvsOrder);
        }

        private void lvsMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvsMenu.SelectedItems.Count > 0)
            {

                txtTenMon.Text = lvsMenu.SelectedItems[0].Text;
                txtGia.Text = lvsMenu.SelectedItems[0].SubItems[1].Text;
                numSL.Value = 1;
            }
        }

        private void btnChonMon_Click(object sender, EventArgs e)
        {

            if (txtTenMon.Text != "")
            {
                lvsOrder.Items.Clear();
                MonAn ma = new MonAn();
                ma.TenMA = txtTenMon.Text;
                ma.Giatien = txtGia.Text;
                ma.SL = (int)numSL.Value;
                contains.DSMonAn.Add(ma);
                for (int i = 0; i < contains.DSMonAn.Count; i++)
                {
                    for (int j = i + 1; j < contains.DSMonAn.Count; j++)
                    {
                        if (contains.DSMonAn[i].TenMA == contains.DSMonAn[j].TenMA)
                        {
                            contains.DSMonAn[i].SL = contains.DSMonAn[j].SL + contains.DSMonAn[i].SL;
                            contains.DSMonAn.Remove(contains.DSMonAn[j]);

                        }

                    }

                }
                for (int i = 0; i < contains.DSMonAn.Count; i++)
                {
                    ListViewItem lvsitem = new ListViewItem();
                    lvsitem.Text = contains.DSMonAn[i].TenMA;

                    lvsitem.SubItems.Add(contains.DSMonAn[i].Giatien);
                    lvsitem.SubItems.Add(contains.DSMonAn[i].SL.ToString());
                    lvsOrder.Items.Add(lvsitem);

                }
                numSL.Value = 0;
                txtTenMon.Text = "";
                txtGia.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (lvsOrder.SelectedItems.Count > 0)
            {

                for (int j = 0; j < contains.DSMonAn.Count; j++)
                {

                    if (contains.DSMonAn[j].TenMA == lvsOrder.SelectedItems[0].Text)
                    {
                        lvsOrder.SelectedItems[0].Remove();
                        contains.DSMonAn.Remove(contains.DSMonAn[j]);

                    }

                }
            }
            else
            {
                MessageBox.Show("Hay chon mon can xoa");
            }
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            if (lvsOrder.Items.Count > 0)
            {
                if (txtSDTKH.Text == "")
                {
                    int n = 0;
                    string tenkh = "";
                    string makh = "";
                    string loaikh = "";
                    string lenh = "SELECT COUNT(*) FROM KHACHHANG WHERE SDT='0000000000'";

                    string lenh2 = "Select TenKH From KHACHHANG WHERE SDT='0000000000'";

                    string lenh3 = "Select MaKH From KHACHHANG WHERE SDT='0000000000'";

                    string lenh4 = "Select LoaiKH From KHACHHANG WHERE SDT='0000000000'";

                    contains ctn = new contains();
                    n = ctn.HienThi1gtint(lenh);
                    if (n > 0)
                    {
                        tenkh = ctn.HienThi1gtstring(lenh2);
                        contains.NameKH.Add(tenkh);
                        makh = ctn.HienThi1gtstring(lenh3);
                        contains.MaKH.Add(makh);
                        loaikh = ctn.HienThi1gtstring(lenh4);
                        contains.LoaiGiamGiaKH.Add(loaikh);

                        if (contains.LoaiGiamGiaKH[0] == "VIP")
                        {
                            contains.GiamGiaKH.Add(0.05);

                        }
                        else
                        {
                            contains.GiamGiaKH.Add(0.0);
                        }
                    }
                }
                if (cmbBan.SelectedIndex < 0)
                {
                    MessageBox.Show("Hãy Chọn Bàn");
                }
                else
                {

                    Thread thread = new Thread(new ThreadStart(ShowForm4));
                    thread.Start();
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Chưa chọn món ăn");
            }
        }

        private void cmbBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (contains.TenBan.Count > 0)
            {
                contains.TenBan.Remove(contains.TenBan[0]);
            }
            contains.TenBan.Add(cmbBan.SelectedItem.ToString());
        }
        private void btnKTKH_Click(object sender, EventArgs e)
        {

            if (txtSDTKH.Text != "")
            {
                int n = 0;
                string tenkh = "";
                string makh = "";
                string loaikh = "";
                string lenh = "SELECT COUNT(*) FROM KHACHHANG WHERE SDT='" + txtSDTKH.Text.Trim() + "'";

                string lenh2 = "SELECT TenKH From KHACHHANG WHERE SDT='" + txtSDTKH.Text.Trim() + "'";

                string lenh3 = "SELECT MaKH From KHACHHANG WHERE SDT='" + txtSDTKH.Text.Trim() + "'";

                string lenh4 = "SELECT LoaiKH From KHACHHANG WHERE SDT='" + txtSDTKH.Text.Trim() + "'";

                contains ctn = new contains();
                n = ctn.HienThi1gtint(lenh);
                if (n > 0)
                {
                    tenkh = ctn.HienThi1gtstring(lenh2);
                    contains.NameKH.Add(tenkh);
                    makh = ctn.HienThi1gtstring(lenh3);
                    contains.MaKH.Add(makh);
                    loaikh = ctn.HienThi1gtstring(lenh4);
                    contains.LoaiGiamGiaKH.Add(loaikh);
                    MessageBox.Show("Mã Khách Hàng: " + makh + "\nTên Khách Hàng: " + tenkh + "\nLoại: " + loaikh);
                    if (contains.LoaiGiamGiaKH[0] == "VIP")
                    {
                        contains.GiamGiaKH.Add(0.05);

                    }
                    else
                    {
                        contains.GiamGiaKH.Add(0.0);
                    }

                }
                if (n != 1)
                {
                    MessageBox.Show("không tồn tại khách hàng");
                }
            }

        }

        private void cmbLH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLH.SelectedIndex > -1)
            {
                string lenh1 = "Select* From THUCDON WHERE LoaiHang = N'" + cmbLH.SelectedItem + "'";
                lvsMenu.Items.Clear();
                cnt.Hienthi2(lenh1, lvsMenu);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (lvsOrder.Items.Count > 0)
            {
                if (txtSDTKH.Text == "" || txtSDTKH.Text.Length < 10 || txtSDTKH.Text.Length > 10)
                {
                    int n = 0;
                    string loaikh = "";
                    string lenh = "SELECT COUNT(*) FROM KHACHHANG WHERE SDT='0000000000'";
                    string lenh4 = "Select LoaiKH From KHACHHANG WHERE SDT='0000000000'";
                    contains ctn = new contains();
                    n = ctn.HienThi1gtint(lenh);
                    if (n > 0)
                    {
                        loaikh = ctn.HienThi1gtstring(lenh4);
                        contains.LoaiGiamGiaKH.Add(loaikh);
                        if (contains.LoaiGiamGiaKH[0] == "VIP")
                        {
                            contains.GiamGiaKH.Add(0.05);
                        }
                        else
                        {
                            contains.GiamGiaKH.Add(0.0);
                        }


                    }
                    if (cmbBan.SelectedIndex < 0)
                    {
                        MessageBox.Show("Hãy Chọn Bàn");
                    }
                }
                for (int i = 0; i < contains.DSMonAn.Count; i++)
                {
                    if (txtSDTKH.Text == "")
                    {
                        txtSDTKH.Text = " 0000000000";
                    }
                    string lenh1 = "INSERT INTO DATHANG(Tenban,SDT,MonAn,SoLuong,Giatien,Thanhtien) VALUES(N'" + cmbBan.Text + "','" + txtSDTKH.Text + "',N'" + contains.DSMonAn[i].TenMA + "', " + contains.DSMonAn[i].SL + "," + contains.DSMonAn[i].Giatien + "," + int.Parse(contains.DSMonAn[i].Giatien) * contains.DSMonAn[i].SL + ")";
                    cnt.Khongtravegt(lenh1);
                }
                string lenh5 = "UPDATE BAN SET Trangthai= N'Có người' WHERE Tenban= N'" + cmbBan.Text + "'";
                cnt.Khongtravegt(lenh5);
                lvsOrder.Items.Clear();
                cmbBan.Text = "";
                txtSDTKH.Text = "";
                for (int j = 0; j < contains.DSMonAn.Count; j++)
                {
                    contains.DSMonAn.Remove(contains.DSMonAn[j]);
                }
                for (int j = 0; j < contains.DSMonAn.Count; j++)
                {
                    contains.DSMonAn.Remove(contains.DSMonAn[j]);
                }
                for (int j = 0; j < contains.DSMonAn.Count; j++)
                {
                    contains.DSMonAn.Remove(contains.DSMonAn[j]);
                }
                for (int j = 0; j < contains.SDTKH.Count; j++)
                {

                    contains.SDTKH.Remove(contains.SDTKH[j]);
                }
                for (int j = 0; j < contains.MaKH.Count; j++)
                {
                    contains.MaKH.Remove(contains.MaKH[j]);
                }
                for (int j = 0; j < contains.NameKH.Count; j++)
                {
                    contains.NameKH.Remove(contains.NameKH[j]);
                }
                for (int j = 0; j < contains.TenBan.Count; j++)
                {
                    contains.TenBan.Remove(contains.TenBan[j]);
                }
                for (int j = 0; j < contains.GiamGiaKH.Count; j++)
                {
                    contains.GiamGiaKH.Remove(contains.GiamGiaKH[j]);
                }
                for (int j = 0; j < contains.LoaiGiamGiaKH.Count; j++)
                {
                    contains.LoaiGiamGiaKH.Remove(contains.LoaiGiamGiaKH[j]);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn món ăn");
            }


        }
    
    }
    
}
