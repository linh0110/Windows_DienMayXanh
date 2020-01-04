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
    public partial class kho : Form
    {
        public kho()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-M82S6JDB;Initial Catalog=QuanLyBanHangv2;user ID=123;password=sa2012;Integrated Security=True");

        private void kho_Load(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                showhanghoa();
                load_textbox();
                timkiemtuongdoi();
            }
            catch(Exception ex)
            {
                MessageBox.Show("kho trống !!!");
            }
            
        }

        private void timkiemtuongdoi()
        {
            txttim.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txttim.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            try
            {


                string s = "SELECT *FROM tb_HangHoa1";
                SqlCommand cmd = new SqlCommand(s, connect);
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    coll.Add(drd["TenHang"].ToString());
                }
                txttim.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txttim.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txttim.AutoCompleteCustomSource = coll;
                drd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void load_textbox()
        {
            int index = dgrHH.CurrentCell.RowIndex;

            txtMaHangKHO.Text = dgrHH.Rows[index].Cells[0].Value.ToString();
            txtTenHangKho.Text = dgrHH.Rows[index].Cells[1].Value.ToString();
            txtThuongHieuKho.Text = dgrHH.Rows[index].Cells[2].Value.ToString();
            txtSoLuongHangKho.Text = dgrHH.Rows[index].Cells[4].Value.ToString();
            txtDonGiaKho.Text = dgrHH.Rows[index].Cells[3].Value.ToString();

        }

        private void btnSearchHH_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSelect = "SELECT*FROM tb_HangHoa1 WHERE MaHang=@maHH OR TenHang=@tenhang OR ThuongHieu=@thuonghieu";
                SqlCommand cmd = new SqlCommand(sqlSelect, connect);
                cmd.Parameters.AddWithValue("maHH", txttim.Text);
                cmd.Parameters.AddWithValue("tenhang", txttim.Text);
                cmd.Parameters.AddWithValue("thuonghieu", txttim.Text);                
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgrHH.DataSource = dt;
                txttim.Clear();
                load_textbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy kết quả! Bạn phải dùng 'Mã Hàng Hóa' hoặc 'Tên Hàng Hóa' hoặc 'Thương Hiệu' để tìm kiếm", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }       

        public void showhanghoa()
        {
            string sql = "select * from tb_HangHoa1";
            SqlCommand cmd = new SqlCommand(sql, connect);
            //cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgrHH.DataSource = dt;
        }

        private void kho_FormClosing(object sender, FormClosingEventArgs e)
        {
            connect.Close();
        }

        private void taomakhoRandom()
        {
            int Numrd;
            string Numrd_str;
            Random rd = new Random();
            Numrd = rd.Next(1, 999);//biến Numrd sẽ nhận có giá trị ngẫu nhiên trong khoảng 1 đến 100
            Numrd_str = rd.Next(100, 9999).ToString();
            txtMaHangKHO.Text = "HHDT" + Numrd_str;
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            if (btnThemHang.Text == "Thêm")
            {
                txtMaHangKHO.Clear();
                txtTenHangKho.Clear();
                txtThuongHieuKho.Clear();
                txtSoLuongHangKho.Clear();
                txtDonGiaKho.Clear();
                txtMaHangKHO.Focus();
                btnThemHang.Text = "Lưu";
                btnSuaHH.Enabled = false;
                dgrHH.Enabled = false;
                taomakhoRandom();
            }
            else
            {
                btnThemHang.Text = "Thêm";
                btnSuaHH.Enabled = true;
                dgrHH.Enabled = true;
                try
                {
                    if (txtMaHangKHO.Text.Length > 0 && txtTenHangKho.Text.Length > 0 && txtThuongHieuKho.Text.Length > 0 && txtDonGiaKho.Text.Length > 0 && txtSoLuongHangKho.Text.Length > 0)
                    {
                        string sqlInsert = "INSERT INTO tb_HangHoa1(MaHang,TenHang,ThuongHieu,DonGia,SoLuong) VALUES (N'" + txtMaHangKHO.Text + "',N'" + txtTenHangKho.Text + "',N'" + txtThuongHieuKho.Text + "'," + txtDonGiaKho.Text + "," + txtSoLuongHangKho.Text + ")";
                        SqlCommand cmd = new SqlCommand(sqlInsert, connect);
                        cmd.ExecuteNonQuery();

                        showhanghoa();                        
                        load_textbox();
                        MessageBox.Show("Thêm thành công !!!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        showhanghoa();
                        load_textbox();
                        MessageBox.Show("Thêm thất bại, Vui lòng nhập đầy đủ thông tin cần thiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mã hàng đã tồn tại !! Không thể thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSuaHH_Click(object sender, EventArgs e)
        {
            if (btnSuaHH.Text == "Sửa")
            {
                txtTenHangKho.Focus();
                txtMaHangKHO.Enabled = false;
                btnSuaHH.Text = "Lưu";
                dgrHH.Enabled = false;
                btnThemHang.Enabled = false;
            }
            else
            {
                btnSuaHH.Text = "Sửa";
                dgrHH.Enabled = true;
                txtMaHangKHO.Enabled = true;
                btnThemHang.Enabled = true;
                try
                {
                    if (txtTenHangKho.Text.Length > 0 && txtThuongHieuKho.Text.Length > 0 && txtDonGiaKho.Text.Length > 0 && txtSoLuongHangKho.Text.Length > 0)
                    {
                        string sqlUpdate = "UPDATE tb_HangHoa1 SET TenHang = @tenHH, ThuongHieu=@thuonghieu, DonGia=@dongia,SoLuong=@soluong WHERE MaHang= @maHH";
                        SqlCommand cmd = new SqlCommand(sqlUpdate, connect);
                        cmd.Parameters.AddWithValue("@mahh", txtMaHangKHO.Text);
                        cmd.Parameters.AddWithValue("@tenHH", txtTenHangKho.Text);
                        cmd.Parameters.AddWithValue("@thuonghieu", txtThuongHieuKho.Text);
                        cmd.Parameters.AddWithValue("@dongia", txtDonGiaKho.Text);
                        cmd.Parameters.AddWithValue("@soluong", txtSoLuongHangKho.Text);
                        cmd.ExecuteNonQuery();

                        showhanghoa();
                        load_textbox();
                        MessageBox.Show("Sửa thành công!", "Thông Báo");
                    }
                    else
                    {
                        showhanghoa();
                        load_textbox();
                        MessageBox.Show("Sửa không thành công, Vui lòng nhập đầy đủ thông tin cần thiết", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bntdong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            btnThemHang.Text = "Thêm";
            btnSuaHH.Text = "Sửa";
            dgrHH.Enabled = true;
            txtMaHangKHO.Enabled = true;
            btnSuaHH.Enabled = true;
            btnThemHang.Enabled = true;
            showhanghoa();
            load_textbox();
        }

        private void txtMaHangKHO_TextChanged(object sender, EventArgs e)
        {
            if (txtMaHangKHO.Text.Length > 0)
                lb_mahh.Text = "";
            else
                lb_mahh.Text = "Không được bỏ trống mã hàng hóa";
        }

        private void txtTenHangKho_TextChanged(object sender, EventArgs e)
        {
            if (txtTenHangKho.Text.Length > 0)
                lb_tenhh.Text = "";
            else
                lb_tenhh.Text = "Không được bỏ trống tên hàng hóa";
        }       

        private void txtThuongHieuKho_TextChanged(object sender, EventArgs e)
        {
            if (txtThuongHieuKho.Text.Length > 0)
                lb_thuonghieu.Text = "";
            else
                lb_thuonghieu.Text = "Không được bỏ trống thương hiệu";
        }       

        private void txtSoLuongHangKho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDonGiaKho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgrHH_Click(object sender, EventArgs e)
        {
            load_textbox();
        }

        private void txtSoLuongHangKho_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuongHangKho.Text.Length > 0)
            {
                lb_sl.Text = "";
                int sl = int.Parse(txtSoLuongHangKho.Text);
                if (sl == 0)
                    MessageBox.Show("Số lượng nhập kho không hợp lệ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                lb_sl.Text = "Không được bỏ trống số lượng";
        }

        private void txtDonGiaKho_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGiaKho.Text.Length > 0)
            {
                lb_dongia.Text = "";
                double dg = double.Parse(txtDonGiaKho.Text);
                if (dg == 0)
                    MessageBox.Show("Đơn giá nhập kho không hợp lệ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                lb_dongia.Text = "Không được bỏ trống đơn giá";
        }

        //-------------------------------------------
    }
}
