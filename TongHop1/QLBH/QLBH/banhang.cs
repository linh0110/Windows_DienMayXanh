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
    public partial class banhang : Form
    {
        public banhang()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-M82S6JDB;Initial Catalog=QuanLyBanHangv2;user ID=123;password=sa2012;Integrated Security=True");
        double s = 0;        
        int ktsolanclick = 0;
        public static string manv;
        public static string soluong;   
        public static int sl;
        public static string hangkm;

        private void frmbh_Load(object sender, EventArgs e)
        {
            connect.Open();
            HienThi4();
            txtMaNVBanHang.Text = manv;
            //load dữ liệu cho cbb
            combxKHACHHD();
            combxtenkhachhd.SelectedIndex = -1;
            txtMaDon.Text = "";
            tgian.Text = Get_tgian();
            timkiemtuongdoi();
           //
            btnluuhd.Enabled= false;
            bntinhoadon.Enabled=false;
        }

        private void frmbh_FormClosing(object sender, FormClosingEventArgs e)
        {
            connect.Close();
           
        }

        public void HienThi4()
        {
            try
            {
                string sql = "SELECT *FROM tb_HangHoa1";
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTonKho.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại");
            }

        }



        private int kiemtratrungGioHang()
        {
            int count = 0;
            int index = dgvTonKho.CurrentCell.RowIndex;
            for (int i = 0; i < dgvHOADON.Rows.Count - 1; i++)
            {
                if (string.Compare(dgvTonKho.Rows[index].Cells[0].Value.ToString(), dgvHOADON.Rows[i].Cells[0].Value.ToString()) == 0)
                    count++;
            }
            return count;
        }

        private void dgvTonKho_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (kiemtratrungGioHang() > 0)
                {
                    MessageBox.Show("Sản phẩm trên đã có trong giỏ hàng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int index = dgvTonKho.CurrentRow.Index;
                    if (int.Parse(dgvTonKho.Rows[index].Cells[4].Value.ToString()) == 0)
                    {
                        MessageBox.Show("Sản phẩm trên đã hết hàng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        nhapsoluong nsl = new nhapsoluong();                        
                        nsl.ShowDialog();
                        this.Show();
                        if (sl > int.Parse(dgvTonKho.Rows[index].Cells[4].Value.ToString()))
                        {
                            MessageBox.Show("Số lượng hàng trong kho không đủ !!!","Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (sl != 0)
                            {
                                int s = 0;
                                dgvHOADON.Rows.Add(new Object[] { dgvTonKho.Rows[index].Cells[0].Value, dgvTonKho.Rows[index].Cells[1].Value, dgvTonKho.Rows[index].Cells[2].Value, dgvTonKho.Rows[index].Cells[3].Value, sl });
                                s = 0;
                                MessageBox.Show("Thêm vào giỏ hàng thành công !!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Dòng chọn đang trống !! Không thể thêm vào giỏ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
  
        }

        private void btnxoahanghd_Click(object sender, EventArgs e)
        {
            if (dgvHOADON.Rows.Count - 1 != 0)
            {
                int index = dgvHOADON.CurrentCell.RowIndex;
                dgvHOADON.Rows.RemoveAt(index);
                tinhtiehoadon();
            }
            else
                MessageBox.Show("Giỏ hàng trống, xóa không thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tinhtiehoadon()
        {
            double kq = 0;
            for (int i = 0; i < dgvHOADON.Rows.Count - 1; i++)
            {
                s = 0;
                s += double.Parse(dgvHOADON.Rows[i].Cells[3].Value.ToString()) * double.Parse(dgvHOADON.Rows[i].Cells[4].Value.ToString());
                kq += s;
            }
            string kqua = String.Format("{0:0,0}", kq);
            string kqua2 = String.Format("{0:0,0}", kq * 0.1);
            string kqua3 = String.Format("{0:0,0}", kq - (kq * 0.1));
            txtTongtien.Text = kqua;
            txtvat.Text = kqua2;
            txtthanhtien.Text = kqua3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvHOADON.CurrentRow.Index;
                dgvHOADON.Rows[index].Cells[4].Value = int.Parse(txtSLTHD.Text);
                MessageBox.Show("Sửa số lượng thành công !!!","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btntinhtien_Click(object sender, EventArgs e)
        {
            tinhtiehoadon();
        }

        private void them_HoaDon()
        {
            try
            {
                if (txtMaDon.Text.Length > 0)
                {
                    string sql = "INSERT INTO tb_HoaDon1(MaHD,MaKH,MaNV,NgayLap,TongSoTien) values('" + txtMaDon.Text + "','" + txmakhachhd.Text + "','" + txtMaNVBanHang.Text + "','" + tgian.Text + "','" + txtTongtien.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Lưu hóa đơn thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lưu hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK);
            }
            }
          
        


        private void them_CTHD()
        {
            try
            {
                for (int i = 0; i < dgvHOADON.Rows.Count - 1; i++)
                {
                    string sql2 = "INSERT INTO tb_CTHD(MaHoaDon,MaHang,DonGia,SoLuong) values('" + txtMaDon.Text + "', '" + dgvHOADON.Rows[i].Cells[0].Value + "', '" + dgvHOADON.Rows[i].Cells[3].Value + "','" + dgvHOADON.Rows[i].Cells[4].Value + "')";

                    SqlCommand cmd2 = new SqlCommand(sql2, connect);
                    //cmd2.Parameters.AddWithValue("mahd", txtMaDon.Text);
                    //cmd2.Parameters.AddWithValue("mahang", dgvHOADON.Rows[i].Cells[0].Value);
                    //cmd2.Parameters.AddWithValue("dongia", dgvHOADON.Rows[i].Cells[3].Value);
                    //cmd2.Parameters.AddWithValue("sl", dgvHOADON.Rows[i].Cells[4].Value);
                    cmd2.ExecuteNonQuery();
                   // them_DoanhThu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu hóa đơn thất bại!!Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void them_DoanhThu()
        {

            try
            {
                string sql = "insert into tb_DoanhSo values('" + txtMaDon.Text + "','" + txtTongtien.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                      
        }

        private string returnSL(string sql)
        {
            string a = "";

            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataReader drd = cmd.ExecuteReader();
            if (drd.Read())
                a = drd[0].ToString();

            drd.Close();
            return a;
        }

        private void soluongconlai()
        {
            try
            {
                for (int i = 0; i < dgvHOADON.Rows.Count - 1; i++)
                {
                    int flag = 0;
                    flag = int.Parse(returnSL("SELECT SoLuong from tb_HangHoa1 where MaHang= '" + dgvHOADON.Rows[i].Cells[0].Value.ToString() + "' ")) - int.Parse(dgvHOADON.Rows[i].Cells[4].Value.ToString());


                    string sql = "update tb_HangHoa1 set SoLuong=" + flag + " where MaHang='" + dgvHOADON.Rows[i].Cells[0].Value.ToString() + "'";

                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnluuhd_Click(object sender, EventArgs e)
        {
            try
            {
                them_HoaDon();
                them_CTHD();
                them_DoanhThu();
                soluongconlai();
                HienThi4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void combxKHACHHD()
        {
            try
            {
                string sql = "select * FROM tb_KhachHang";
                SqlDataAdapter ada = new SqlDataAdapter(sql, connect);
                DataTable tb = new DataTable();
                ada.Fill(tb);

                combxtenkhachhd.DataSource = tb;
                combxtenkhachhd.DisplayMember = "TenKH";
                combxtenkhachhd.ValueMember = "MaKH";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string Get_tgian()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(0, 10);
            return str;
        }

        private void btncapnhatLai_Click(object sender, EventArgs e)
        {

        }

        private void dgvHOADON_Click(object sender, EventArgs e)
        {

        }

        private void combxtenkhachhd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tb_KhachHang WHERE TenKH= N'" + combxtenkhachhd.SelectedItem.ToString() + "'";

            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataReader dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                // get the results of each column
                string sdt = (string)dreader["SDTKH"];
                string dc = (string)dreader["DiaChiKH"];
                string ma = (string)dreader["MaKH"];
                txtsdthd.Text = sdt;
                txtdchd.Text = dc;
                txmakhachhd.Text = ma;
            }
            dreader.Close();

        }

        private void btnSUBtonkho_Click(object sender, EventArgs e)
        {

            try
            {
                string sqlSearchK = "SELECT* FROM tb_HangHoa1 where MaHang='" + txtSEARCHTONKHO.Text + "' or TenHang='" + txtSEARCHTONKHO.Text + "'or ThuongHieu='" + txtSEARCHTONKHO.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlSearchK, connect);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvTonKho.DataSource = dt;

                if (txtSEARCHTONKHO.Text == "")
                    HienThi4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            HienThi4();
        }

        private void timkiemtuongdoi()
        {
            txtSEARCHTONKHO.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSEARCHTONKHO.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            try
            {


                string s = "SELECT *FROM tb_HangHoa1";
                SqlCommand cmd = new SqlCommand(s, connect);
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    coll.Add(drd["TenHang"].ToString());
                    coll.Add(drd["ThuongHieu"].ToString());
                    coll.Add(drd["MaHang"].ToString());
                }
                txtSEARCHTONKHO.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtSEARCHTONKHO.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSEARCHTONKHO.AutoCompleteCustomSource = coll;
                drd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btntinhtienthoi_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtTongtien.Text);
            double b = double.Parse(txttienkhachdua.Text);
            double c = b - a;
            txttiendu.Text = c.ToString();
        }

        private void combxtenkhachhd_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string sql = "select MaKH, DiaChiKH, SDTKH from tb_KhachHang where MaKH='" + combxtenkhachhd.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataReader doc = cmd.ExecuteReader();
            if (doc.Read())
            {
                txmakhachhd.Text = doc.GetString(0);
                txtdchd.Text = doc.GetString(1);
                txtsdthd.Text = doc.GetString(2);
            }
            doc.Close();
            taomahd();
            showhd.mahd = txtMaDon.Text;
        }

        private void taomahd()
        {
            int max = 0;
            try
            {
                string sql = "select tb_HoaDon1.MaHD from tb_HoaDon1 where tb_HoaDon1.MaKH= '" + txmakhachhd .Text+ "'";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataReader doc = cmd.ExecuteReader();
                while (doc.Read())
                {
                    int dem = 0;
                    for (int i = 0; i < doc.GetString(0).ToString().Length - 9; i++)
                    {                        
                        dem++;
                    }
                    string solanmua = doc.GetString(0).ToString().Substring(0, dem);
                    int so = int.Parse(solanmua);
                    if (so > max)
                        max = so;
                }                
                max++;
                string chuoimahd = string.Format(max.ToString() + "HD" + txmakhachhd.Text);
                txtMaDon.Text = chuoimahd;                
                doc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi ở mã hóa đơn");
            }
        }

        private void dgvHOADON_Click_1(object sender, EventArgs e)
        {
            try
            {
                int index = dgvHOADON.CurrentRow.Index;

                txtmadonHD.Text = dgvHOADON.Rows[index].Cells[0].Value.ToString();
                txtSLTHD.Text = dgvHOADON.Rows[index].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                int index = dgvHOADON.CurrentRow.Index;
                dgvHOADON.Rows[index].Cells[4].Value = int.Parse(txtSLTHD.Text);
                MessageBox.Show("Số lượng đã được sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa chọn mặt hàng cần sửa số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btntinhtien_Click_1(object sender, EventArgs e)
        {
            btnluuhd.Enabled = true;
            bntinhoadon.Enabled = true;
            if (dgvHOADON.Rows.Count <= 1)
            {
                MessageBox.Show("Giỏ hàng đang trống !! Không thể tính tiền", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
            ktsolanclick=1;
            tinhtiehoadon();
            }
        }

        private void btnluuhd_Click_1(object sender, EventArgs e)
        {
           
            try{
                if (ktsolanclick == 0 ||dgvHOADON.Rows.Count==1)
                {
                    MessageBox.Show("Thất bại !!Vui lòng nhấn tính tiền hoặc thêm vào giỏ hàng", "Thông báo", MessageBoxButtons.OK);
                    
                    
                }
                else
                {
                    khuyenmai k = new khuyenmai();
                    if (double.Parse(txtTongtien.Text) > 10000000)
                    {
                        k.ShowDialog();
                    }
                    them_HoaDon();
                    them_CTHD();
                    them_DoanhThu();
                    soluongconlai();
                    HienThi4();
                   
                    tgian.Text = Get_tgian();
                    
                }
                
            }
                catch
            {
                MessageBox.Show("Vui lòng bấm tính tiền trước khi lưu hóa đơn", "Thông báo", MessageBoxButtons.OK);
            }
            

        }

     

        private void btntinhtienthoi_Click_1(object sender, EventArgs e)
        {
            if (txttienkhachdua.Text.Length > 0)
            {
                double kq = double.Parse(txttienkhachdua.Text) - double.Parse(txtTongtien.Text);
                string kqua = String.Format("{0:0,0}", kq);
                txttiendu.Text = kqua.ToString();
            }
            else
                MessageBox.Show("Vui lòng nhập số tiền khách đưa để tính toán", "Thông báo", MessageBoxButtons.OK);
        }

        private void txttienkhachdua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) &&!char.IsDigit(e.KeyChar))
                e.Handled=true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbthoigian.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgvHOADON_Click_2(object sender, EventArgs e)
        {
            try
            {

                int index = dgvHOADON.CurrentRow.Index;

                txtmadonHD.Text = dgvHOADON.Rows[index].Cells[0].Value.ToString();
                txtSLTHD.Text = dgvHOADON.Rows[index].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dòng chọn không hợp lệ", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnxoahanghd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvHOADON.Rows.Count - 1 != 0)
                {
                    int index = dgvHOADON.CurrentCell.RowIndex;
                    dgvHOADON.Rows.RemoveAt(index);
                    tinhtiehoadon();
                    ktsolanclick = 0;
                    txtmadonHD.Text = "";
                    txtSLTHD.Text = "";
                }
                else
                    MessageBox.Show("Giỏ hàng trống, xóa không thành công !!", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void txtSLTHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            
            showhd hd = new showhd();
            hd.ma = txtMaDon.Text;
            hd.Show();
        }

        private void btnreload_Click_1(object sender, EventArgs e)
        {
            HienThi4();
        }

        private void bntdonghd_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(hangkm);
        }

        private void txtMaDon_TextChanged(object sender, EventArgs e)
        {

        }


       
    }
}
