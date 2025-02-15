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
    public partial class frmThanhtoan : Form
    {
        contains ctn = new contains();
        public frmThanhtoan()
        {
            InitializeComponent();
        }
        private void ShowForm6()
        {
            frmHoadonbanhang f6 = new frmHoadonbanhang();
            f6.ShowDialog();
        }
        private void Form4_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            int tt = 0;
            lblTenBan.Text = contains.TenBan[0];
            lblMaNV.Text = contains.MaNV[0];
            lblMaHD.Text = contains.MaHD[0];
            lblTenKH.Text = contains.NameKH[0];
            lvsThanhToan.Columns.Add("Mon an", 300);
            lvsThanhToan.Columns.Add("So luong", 100);
            lvsThanhToan.Columns.Add("Gia tien", 150);
            lvsThanhToan.Columns.Add("Thanh Tien", 200);
            lvsThanhToan.View = View.Details;
            lvsThanhToan.GridLines = true;
            for (int i = 0; i < contains.DSMonAn.Count; i++)
            {
                ListViewItem lvsitem = new ListViewItem();
                lvsitem.Text = contains.DSMonAn[i].TenMA;
                lvsitem.SubItems.Add(contains.DSMonAn[i].SL.ToString());
                lvsitem.SubItems.Add(contains.DSMonAn[i].Giatien);
                int n = contains.DSMonAn[i].SL;
                string gt = contains.DSMonAn[i].Giatien;
                int gt2 = int.Parse(gt);
                lvsitem.SubItems.Add((gt2 * n).ToString());
                contains.VAT.Add((gt2 * n) * 10 / 100);
                lvsThanhToan.Items.Add(lvsitem);
                tt = tt + (gt2 * n);
                contains.TTTungMon.Add(gt2 * n);
            }
            lblTT.Text = tt.ToString();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            int tt = 0;
            for (int i = 0; i < contains.TTTungMon.Count; i++)
            {
                tt = tt + contains.TTTungMon[i];
            }
            contains.TongTien.Add(tt);
            string lenh1 = "INSERT INTO HOADONBANHANG (MaHDBH,MaNV,Tenban,MaKH,NgayHDBH,Thanhtien,VAT,DiemTL,Giamgia,Tongtien) VALUES ('" + lblMaHD.Text + "','" + lblMaNV.Text + "',N'" + lblTenBan.Text + "',N'" + contains.MaKH[0] + "','" + contains.NgayHDBH[0] + "'," + lblTT.Text + ",'" + contains.VAT[0] + "'," + (contains.TongTien[0] - (contains.GiamGiaKH[0] * contains.TongTien[0]) + contains.VAT[0]) / 1000 + "," + contains.GiamGiaKH[0] * contains.TongTien[0] + "," + (contains.TongTien[0] - (contains.GiamGiaKH[0] * contains.TongTien[0]) + contains.VAT[0]) + ")";
            ctn.Khongtravegt(lenh1);
            for (int i = 0; i < contains.DSMonAn.Count; i++)
            {
                string lenh2 = "INSERT INTO MONANDABAN(MaHDBH,MonAn,SoLuong,GiaTien) VALUES('" + lblMaHD.Text + "',N'" + contains.DSMonAn[i].TenMA + "', " + contains.DSMonAn[i].SL + ", " + contains.DSMonAn[i].Giatien + ")";
                ctn.Khongtravegt(lenh2);
            }
            string lenh3 = "UPDATE BAN SET Trangthai= N'TRỐNG' WHERE Tenban = N'" + lblTenBan.Text + "'";
            ctn.Khongtravegt(lenh3);
            string lenh4 = "DELETE FROM DATHANG WHERE Tenban=N'" + lblTenBan.Text + "'";
            ctn.Khongtravegt(lenh4);
            Thread thread = new Thread(new ThreadStart(ShowForm6));
            thread.Start();
            this.Close();
        }

        private void btnSuaOrder_Click(object sender, EventArgs e)
        {
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
            Close();
        }

        private void btnHuyTT_Click(object sender, EventArgs e)
        {
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
            for (int j = 0; j < contains.TongTien.Count; j++)
            {
                contains.TongTien.Remove(contains.TongTien[j]);
            }
            for (int j = 0; j < contains.SDTKH.Count; j++)
            {
                contains.SDTKH.Remove(contains.SDTKH[j]);
            }
            for (int j = 0; j < contains.GiamGiaKH.Count; j++)
            {
                contains.GiamGiaKH.Remove(contains.GiamGiaKH[j]);
            }
            for (int j = 0; j < contains.LoaiGiamGiaKH.Count; j++)
            {
                contains.LoaiGiamGiaKH.Remove(contains.LoaiGiamGiaKH[j]);
            }
            for (int j = 0; j < contains.MaKH.Count; j++)
            {
                contains.MaKH.Remove(contains.MaKH[j]);
            }
            for (int j = 0; j < contains.NameKH.Count; j++)
            {
                contains.NameKH.Remove(contains.NameKH[j]);
            }
            for (int j = 0; j < contains.NgayHDBH.Count; j++)
            {
                contains.NgayHDBH.Remove(contains.NgayHDBH[j]);
            }
            for (int j = 0; j < contains.SDTKH.Count; j++)
            {
                if (contains.SDTKH.Count > 0)
                    contains.SDTKH.Remove(contains.SDTKH[j]);
            }
            for (int j = 0; j < contains.TenBan.Count; j++)
            {
                contains.TenBan.Remove(contains.TenBan[j]);
            }
            for (int j = 0; j < contains.TTTungMon.Count; j++)
            {
                contains.TTTungMon.Remove(contains.TTTungMon[j]);
            }
            for (int j = 0; j < contains.VAT.Count; j++)
            {
                contains.VAT.Remove(contains.VAT[j]);
            }
            this.Close();
        }
    }
}
