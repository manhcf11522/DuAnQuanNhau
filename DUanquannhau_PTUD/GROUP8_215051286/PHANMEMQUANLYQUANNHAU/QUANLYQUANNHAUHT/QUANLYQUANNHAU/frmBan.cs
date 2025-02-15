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
    public partial class frmBan : Form
    {
        contains cnt = new contains();
        public frmBan()
        {
            InitializeComponent();
        }
        private void ShowForm4()
        {
            frmThanhtoan f4 = new frmThanhtoan();
            f4.ShowDialog();

        }
        private void Form9_Load(object sender, EventArgs e)
        {
            string lenh4 = "SELECT COUNT(*) FROM HOADONBANHANG";
            string hd = "";
            int hd2 = 0;
            hd2 = cnt.HienThi1gtint(lenh4);
            hd = (hd2 + 1).ToString();
            contains.MaHD.Add("TNM" + hd);
            for (int i = contains.MaHD.Count - 1; i < contains.MaHD.Count; i++)
            {
                contains.MaHD[0] = contains.MaHD[i];
            }
            contains.NgayHDBH.Add(DateTime.Now.ToString("yyyy-MM-dd"));
            for(int i= contains.NgayHDBH.Count; i< contains.NgayHDBH.Count;i++)
            {
                contains.NgayHDBH[0] = contains.NgayHDBH[i];
            }
            cbTrangthai.Items.Add("Có người");
            cbTrangthai.Items.Add("TRỐNG");
            string lenh1 = "SELECT* FROM BAN ORDER BY Tenban ASC";
            lvsBan.Items.Clear();
            lvsBan.Columns.Add("Tên bàn", 250);
            lvsBan.Columns.Add("Trạng thái", 150);
            lvsBan.View = View.Details;
            lvsBan.Items.Clear();
            cnt.Hienthi2(lenh1, lvsBan);
            lvsThongtin.Items.Clear();
            lvsThongtin.Columns.Add("Món ăn", 300);
            lvsThongtin.Columns.Add("Số lượng", 100);
            lvsThongtin.Columns.Add("Giá tiền", 100);
            lvsThongtin.Columns.Add("Thành tiền", 300);
            lvsThongtin.View = View.Details;
        }

        private void lvsBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void cbTrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lenh1 = "SELECT* FROM BAN WHERE Trangthai= N'" + cbTrangthai.SelectedItem + "'";
            lvsBan.Items.Clear();
            lvsBan.View = View.Details;
            cnt.Hienthi2(lenh1, lvsBan);
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lvsThongtin.Items.Count; i++)
            {
                MonAn ma = new MonAn();
                ma.TenMA = lvsThongtin.Items[i].Text;
                ma.SL = int.Parse(lvsThongtin.Items[i].SubItems[1].Text);
                ma.Giatien = lvsThongtin.Items[i].SubItems[2].Text;
                contains.DSMonAn.Add(ma);
            }
            if (contains.TenBan.Count >= 1)
            {
                contains.TenBan[0] = lvsBan.SelectedItems[0].Text;
            }
            else
            {
                contains.TenBan.Add(lvsBan.SelectedItems[0].Text);
            }
            string sdt = "";
            string lenh4 = "SELECT SDT FROM DATHANG WHERE TenBan = '" + lvsBan.SelectedItems[0].Text + "'";
            sdt = cnt.HienThi1gtstring(lenh4);
            string tenKH = "";
            string lenh1 = "SELECT TenKH FROM KHACHHANG WHERE SDT LIKE '" + sdt.Trim() + "'";
            tenKH = cnt.HienThi1gtstring(lenh1);
            contains.NameKH.Add(tenKH);
            string maKH = "";
            string lenh2 = "SELECT MAKH FROM KHACHHANG WHERE SDT LIKE '" + sdt.Trim() + "'";
            maKH = cnt.HienThi1gtstring(lenh2);
            contains.MaKH.Add(maKH);
            string loaikh = "";
            string lenh3 = "Select LoaiKH From KHACHHANG WHERE SDT LIKE '" + sdt.Trim() + "'";
            loaikh = cnt.HienThi1gtstring(lenh3);
            contains.LoaiGiamGiaKH.Add(loaikh);
            if (contains.LoaiGiamGiaKH[0] == "VIP")
            {
                contains.GiamGiaKH.Add(0.05);

            }
            else
            {
                contains.GiamGiaKH.Add(0.0);
            }
            Thread thread = new Thread(new ThreadStart(ShowForm4));
            thread.Start();
            this.Close();
        }

        private void lvsBan_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var _item = e.Item;
            txtMaban.Text = _item.Text;
            string lenh1 = "select MonAn,SoLuong,Giatien,ThanhTien FROM DATHANG WHERE Tenban=N'" + txtMaban.Text + "'";
            lvsThongtin.Items.Clear();
            DataTable dt = cnt.Hienthi4(lenh1);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lvsThongtin.Items.Add(item);
            }
            string sdt = "";
            string lenh2 = "SELECT SDT FROM DATHANG WHERE Tenban=N'" + txtMaban.Text + "'";
            sdt = cnt.HienThi1gtstring(lenh2);
            if (contains.SDTKH.Count >= 1)
            {
                contains.SDTKH[0] = sdt;
            }
            else
            {
                contains.SDTKH.Add(sdt);
            }
        }
    }
    
}
