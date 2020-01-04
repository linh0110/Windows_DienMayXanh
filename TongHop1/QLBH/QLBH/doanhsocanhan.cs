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
    public partial class doanhsocanhan : Form
    {
        public doanhsocanhan()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-M82S6JDB;Initial Catalog=QuanLyBanHangv2;user ID=123;password=sa2012;Integrated Security=True");
        public static string manv;

        private void doanhsocanhan_Load(object sender, EventArgs e)
        {
            connect.Open();
            hienthi();
            thongkedoanhsocanhan();
        }

        private void hienthi()
        {
            string sql = "select * from tb_HoaDon1 where tb_HoaDon1.MaNV='"+manv+"'";
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvdoanhthucanhan.DataSource = dt;
        }

        private void thongkedoanhsocanhan()
        {
            try
            {
                string sql = "select SUM(TongSoTien) from tb_HoaDon1 where MaNV='"+manv+"'";
                SqlCommand cmd = new SqlCommand(sql, connect);
                double a = double.Parse(cmd.ExecuteScalar().ToString());
                string kqua = String.Format("{0:0,0}", a);
                txtdoanhsocanhan.Text = kqua.ToString();
                soluongdonhang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa có doanh thu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdoanhsocanhan.Clear();
                txtsodoncanhan.Clear();
            }
        }

        private void soluongdonhang()
        {
            try
            {
                string sql = "select count(MaHD) from tb_HoaDon1  where MaNV='"+manv+"'";
                SqlCommand cmd = new SqlCommand(sql, connect);
                int a = Convert.ToInt32(cmd.ExecuteScalar());
                txtsodoncanhan.Text = a.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void doanhsocanhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            connect.Close();
        }

        private void btnxoahoadon_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có chắc chắn xóa hóa đơn này không ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                conglaisoluong();
                xoadoanhthu();
                xoacthd();
                xoahoadon();
                //-----------------------
                hienthi();                
                txtmadoncanxoa.Clear();
                MessageBox.Show("Xóa hóa đơn thành công !  đã cập nhật lại số lượng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                thongkedoanhsocanhan();
                //-----------------------                 
            }
        }

        private void xoadoanhthu()
        {
            try
            {
                int index = dgvdoanhthucanhan.CurrentCell.RowIndex;
                string sql = "delete from tb_DoanhSo where MaHD='" + dgvdoanhthucanhan.Rows[index].Cells[0].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void xoacthd()
        {
            try
            {
                int index = dgvdoanhthucanhan.CurrentCell.RowIndex;
                string sql = "delete from tb_CTHD where MaHoaDon='" + dgvdoanhthucanhan.Rows[index].Cells[0].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void xoahoadon()
        {
            try
            {
                int index = dgvdoanhthucanhan.CurrentCell.RowIndex;
                string sql = "delete from tb_HoaDon1 where MaHD='" + dgvdoanhthucanhan.Rows[index].Cells[0].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void conglaisoluong()
        {
            try
            {
                // list mã hàng
                List<string> ma = new List<string>();

                int index = dgvdoanhthucanhan.CurrentCell.RowIndex;
                string layma = "select tb_CTHD.MaHang, tb_CTHD.SoLuong from tb_CTHD where tb_CTHD.MaHoaDon='" + dgvdoanhthucanhan.Rows[index].Cells[0].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(layma, connect);
                SqlDataReader doc = cmd.ExecuteReader();
                while (doc.Read())
                {
                    string a = doc.GetString(0);// lấy mã
                    ma.Add(a);
                }
                doc.Close();

                //list số lượng trong CTHD
                List<int> slcthd = new List<int>();

                string layslban = "select tb_CTHD.MaHang, tb_CTHD.SoLuong from tb_CTHD where tb_CTHD.MaHoaDon='" + dgvdoanhthucanhan.Rows[index].Cells[0].Value.ToString() + "'";
                SqlCommand cmd1 = new SqlCommand(layslban, connect);
                SqlDataReader doc1 = cmd1.ExecuteReader();
                while (doc1.Read())
                {
                    int slban = doc1.GetInt32(1);// lấy số lượng bán  
                    slcthd.Add(slban);
                }
                doc1.Close();

                //List số lượng trong kho
                List<int> slkho = new List<int>();
                foreach (string i in ma)
                {
                    string sltrongkho = "select tb_HangHoa1.SoLuong from tb_HangHoa1 where tb_HangHoa1.MaHang='" + i + "'";
                    SqlCommand cmdsl = new SqlCommand(sltrongkho, connect);
                    int b = int.Parse(cmdsl.ExecuteScalar().ToString());
                    slkho.Add(b);
                }

                // update
                int vt = 0;
                foreach (string m in ma)
                {
                    int slmoi = 0;
                    slmoi = slcthd[vt] + slkho[vt];
                    string sql = "update tb_HangHoa1 set SoLuong=" + slmoi + " where MaHang='" + m.ToString() + "'";
                    SqlCommand upd = new SqlCommand(sql, connect);
                    upd.ExecuteNonQuery();
                    vt++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvdoanhthucanhan_Click(object sender, EventArgs e)
        {
            int index = dgvdoanhthucanhan.CurrentCell.RowIndex;
            txtmadoncanxoa.Text = dgvdoanhthucanhan.Rows[index].Cells[0].Value.ToString();
        }
        //----------------------------------------------------------
    }
}
