using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYQUANNHAU
{
    internal class contains
    {
        SqlConnection sqlConnection = null;
        SqlDataReader sqlDataReader = null;
        private static List<string> taikhoan = new List<string>();
        public static List<string> Taikhoan { get => taikhoan; set => taikhoan = value; }
        private static List<string> matkhau = new List<string>();
        public static List<string> Matkhau { get => matkhau; set => matkhau = value; }
        private static List<string> quyenhan = new List<string>();
        public static List<string> Quyenhan { get => quyenhan; set => quyenhan = value; }
        private static List<string> maNV = new List<string>();
        public static List<string> MaNV { get => maNV; set => maNV = value; }
        private static List<string> maKH = new List<string>();
        public static List<string> MaKH { get => maKH; set => maKH = value; }
        private static List<string> sDTKH = new List<string>();
        public static List<string> SDTKH { get => sDTKH; set => sDTKH = value; }
        private static List<string> nameKH = new List<string>();
        public static List<string> NameKH { get => nameKH; set => nameKH = value; }
        private static List<MonAn> dSMonAn = new List<MonAn>();
        public static List<MonAn> DSMonAn { get => dSMonAn; set => dSMonAn = value; }
        private static List<string> maHD = new List<string>();
        public static List<string> MaHD { get => maHD; set => maHD = value; }
        private static List<string> tenBan = new List<string>();
        public static List<string> TenBan { get => tenBan; set => tenBan = value; }
        private static List<string> ngayHDBH = new List<string>();
        public static List<string> NgayHDBH { get => ngayHDBH; set => ngayHDBH = value; }
        private static List<int> vAT = new List<int>();
        public static List<int> VAT { get => vAT; set => vAT = value; }
        private static List<int> tongTien = new List<int>();
        public static List<int> TongTien { get => tongTien; set => tongTien = value; }
        private static List<double> giamGiaKH = new List<double>();
        public static List<double> GiamGiaKH { get => giamGiaKH; set => giamGiaKH = value; }
        private static List<string> loaiGiamGiaKH = new List<string>();
        public static List<string> LoaiGiamGiaKH { get => loaiGiamGiaKH; set => loaiGiamGiaKH = value; }
        private static List<int> tTTungMon = new List<int>();
        public static List<int> TTTungMon { get => tTTungMon; set => tTTungMon = value; }
        public void Hienthi2(string lenh, ListView lvs)
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(CnSQL.linksql);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand cmd = new SqlCommand(lenh, sqlConnection);
            sqlDataReader = cmd.ExecuteReader();
            int i = 0;
            while (sqlDataReader.Read())
            {
                lvs.Items.Add(sqlDataReader[0].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[1].ToString());
                i++;
            }
            sqlConnection.Close();
        }
        public void Hienthi3(string lenh, ListView lvs)
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(CnSQL.linksql);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand cmd = new SqlCommand(lenh, sqlConnection);
            sqlDataReader = cmd.ExecuteReader();
            int i = 0;
            while (sqlDataReader.Read())
            {
                lvs.Items.Add(sqlDataReader[0].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[1].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[2].ToString());
                i++;
            }
            sqlConnection.Close();
        }
        public DataTable Hienthi4(string lenh)
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(CnSQL.linksql);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand cmd = new SqlCommand(lenh, sqlConnection);
            sqlDataReader = cmd.ExecuteReader();
            int i = 0;
            DataTable dt = new DataTable();
            SqlDataReader reader = sqlDataReader;
            dt.Load(reader);
            sqlConnection.Close();
            return dt;
        }
        public void Hienthi5(string lenh, ListView lvs)
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(CnSQL.linksql);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand cmd = new SqlCommand(lenh, sqlConnection);
            sqlDataReader = cmd.ExecuteReader();
            int i = 0;
            while (sqlDataReader.Read())
            {
                lvs.Items.Add(sqlDataReader[0].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[1].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[2].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[3].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[4].ToString());
                i++;
            }
            sqlConnection.Close();
        }
        public void Hienthi6(string lenh, ListView lvs)
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(CnSQL.linksql);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand cmd = new SqlCommand(lenh, sqlConnection);
            sqlDataReader = cmd.ExecuteReader();
            int i = 0;
            while (sqlDataReader.Read())
            {
                lvs.Items.Add(sqlDataReader[0].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[1].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[2].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[3].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[4].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[5].ToString());
                i++;
            }
            sqlConnection.Close();
        }
        public void Hienthi8(string lenh, ListView lvs)
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(CnSQL.linksql);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand cmd = new SqlCommand(lenh, sqlConnection);
            sqlDataReader = cmd.ExecuteReader();
            int i = 0;
            while (sqlDataReader.Read())
            {
                lvs.Items.Add(sqlDataReader[0].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[1].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[2].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[3].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[4].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[5].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[6].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[7].ToString());
                i++;
            }
            sqlConnection.Close();
        }
        public void Hienthi7(string lenh, ListView lvs)
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(CnSQL.linksql);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand cmd = new SqlCommand(lenh, sqlConnection);
            sqlDataReader = cmd.ExecuteReader();
            int i = 0;
            while (sqlDataReader.Read())
            {
                lvs.Items.Add(sqlDataReader[0].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[1].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[2].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[3].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[4].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[5].ToString());
                lvs.Items[i].SubItems.Add(sqlDataReader[6].ToString());
                i++;
            }
            sqlConnection.Close();
        }
        public int HienThi1gtint(string lenh)
        {
            int n = 0;
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(CnSQL.linksql);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = lenh;
            cmd.Connection = sqlConnection;
            n = (int)cmd.ExecuteScalar();
            return n;
            sqlConnection.Close();
        }
        public string HienThi1gtstring(string lenh)
        {
            string n;
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(CnSQL.linksql);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = lenh;
            cmd.Connection = sqlConnection;
            n = (string)cmd.ExecuteScalar();
            return n;
            sqlConnection.Close();
        }
        public void Khongtravegt(string lenh)
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(CnSQL.linksql);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = lenh;
            cmd.Connection = sqlConnection;
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void HienThict(ListView lvs)
        {
            for (int i = 0; i < contains.DSMonAn.Count; i++)
            {
                ListViewItem lvsitem = new ListViewItem();
                lvsitem.Text = contains.DSMonAn[i].TenMA;

                lvsitem.SubItems.Add(contains.DSMonAn[i].Giatien);
                lvsitem.SubItems.Add(contains.DSMonAn[i].SL.ToString());

                lvs.Items.Add(lvsitem);
            }
        }

    }
}
