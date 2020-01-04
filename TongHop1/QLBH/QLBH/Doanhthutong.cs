using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLBH
{
    public partial class Doanhthutong : Form
    {
        public Doanhthutong()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-M82S6JDB;Initial Catalog=QuanLyBanHangv2;user ID=123;password=sa2012;Integrated Security=True");

        private void Doanhthutong_Load(object sender, EventArgs e)
        {
            connect.Open();
            hienthidoanhthuadmin();
            thongkeTong();
            hienthibxh();
            hienthihanghoabanchay();
            hienthihoadon();
           
        }


   

        private void soluongdonhang()
        {
            try
            {
                string sql = "select count(MaHD) from tb_HoaDon1  ";
                SqlCommand cmd = new SqlCommand(sql, connect);
                int a = Convert.ToInt32(cmd.ExecuteScalar());
                txtsldonhang.Text = a.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void thongkeTong()
        {
            try
            {
                string sql = "select SUM(DoanhThu) from tb_DoanhSo";
                SqlCommand cmd = new SqlCommand(sql, connect);
                double a = double.Parse(cmd.ExecuteScalar().ToString());
                string kqua = String.Format("{0:0,0}", a);
                txtdoanhthu.Text = kqua.ToString();
                soluongdonhang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa có doanh thu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void hienthihoadon()
        {
            try
            {
                string sql = "select * from tb_CTHD";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvhoadon.DataSource = dt;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa có doanh thu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void hienthidoanhthuadmin()
        {
            try
            {
                string sql = "select * from tb_HoaDon1";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvdoanhthuadmin.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hienthibxh()
        {
            try
            {
                string sql = "select tb_HoaDon1.MaNV,tb_NhanVien.TenNV ,sum(TongSoTien)  as DoanhSo from tb_HoaDon1,tb_NhanVien where tb_NhanVien.MaNV = tb_HoaDon1.MaNV group by tb_HoaDon1.MaNV ,tb_NhanVien.TenNV order by sum(TongSoTien) desc";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBXH.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hienthihanghoabanchay()
        {
            try
            {
                string sql = "select tb_CTHD.MaHang, tb_HangHoa1.TenHang, SUM(tb_CTHD.SoLuong)as SoLuong from tb_CTHD, tb_HangHoa1 where tb_CTHD.MaHang = tb_HangHoa1.MaHang group by tb_CTHD.MaHang, tb_HangHoa1.TenHang order by SUM(tb_CTHD.SoLuong) desc";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvhhbanchay.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Doanhthutong_FormClosing(object sender, FormClosingEventArgs e)
        {
            connect.Close();
        }           
        //-----------------------------------------------------
    }
}
