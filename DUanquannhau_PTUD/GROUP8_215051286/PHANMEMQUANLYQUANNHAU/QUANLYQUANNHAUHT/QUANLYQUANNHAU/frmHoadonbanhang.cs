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
    public partial class frmHoadonbanhang : Form
    {
        public frmHoadonbanhang()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            txtMaBan.Text = contains.TenBan[0];
            txtMaBan.Enabled = false;
            txtMaNV.Text = contains.MaNV[0];
            txtMaNV.Enabled = false;
            txtMaHD.Text = contains.MaHD[0];
            txtMaHD.Enabled = false;
            txtKH.Text = contains.NameKH[0];
            txtKH.Enabled = false;
            lblDiemTL.Text = ((contains.TongTien[0] - (contains.GiamGiaKH[0] * contains.TongTien[0]) + contains.VAT[0]) / 1000).ToString();
            lblGG.Text = (contains.TongTien[0] * contains.GiamGiaKH[0]).ToString();
            lblVAT.Text = (contains.TongTien[0] * 10 / 100).ToString();
            lblTong.Text = (contains.TongTien[0] - (contains.GiamGiaKH[0] * contains.TongTien[0]) + contains.VAT[0]).ToString();
            dateTimePicker1.Enabled = false;
            int tt = 0;
            lvsHD.Columns.Add("Mon an", 100);
            lvsHD.Columns.Add("So luong", 100);
            lvsHD.Columns.Add("Gia tien", 100);
            lvsHD.Columns.Add("Thanh Tien", 150);
            lvsHD.View = View.Details;
            lvsHD.GridLines = true;
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
                lvsHD.Items.Add(lvsitem);
                tt = tt + (gt2 * n);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
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
            for (int j = 0; j < contains.MaHD.Count; j++)
            {
                contains.MaHD.Remove(contains.MaHD[j]);
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
