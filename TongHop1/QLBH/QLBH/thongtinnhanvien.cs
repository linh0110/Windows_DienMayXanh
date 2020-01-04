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
    public partial class thongtinnhanvien : Form
    {
        public thongtinnhanvien()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-M82S6JDB;Initial Catalog=QuanLyBanHangv2;user ID=123;password=sa2012;Integrated Security=True");
        public static string manv;

        private void bntsuatt_Click(object sender, EventArgs e)
        {
            try
            {
                if (bntsuatt.Text == "Sửa Thông Tin")
                {
                    txtTenNV.Enabled = true;
                    txtDiaChiNV.Enabled = true;
                    txtDienThoaiNV.Enabled = true;
                    dtp1.Enabled = true;
                    cbbgioitinh.Enabled = true;
                    bntsuatt.Text = "Lưu";
                    if (cbbgioitinh.SelectedIndex < 0)
                        cbbgioitinh.SelectedIndex = 0;
                }
                else
                {
                    txtTenNV.Enabled = false;
                    txtDiaChiNV.Enabled = false;
                    txtDienThoaiNV.Enabled = false;
                    dtp1.Enabled = false;
                    cbbgioitinh.Enabled = false;
                    bntsuatt.Text = "Sửa Thông Tin";
                    //
                    if (txtTenNV.Text.Length != 0 && txtDienThoaiNV.Text.Length != 0 && txtDiaChiNV.Text.Length != 0)
                    {
                        string sqlUpdate = "UPDATE tb_NhanVien SET TenNV = N'" + txtTenNV.Text + "', NgaySinh='" + dtp1.Value + "', GioiTinh=N'" + cbbgioitinh.SelectedItem.ToString() + "',DiaChi=N'" + txtDiaChiNV.Text + "',SDT='" + txtDienThoaiNV.Text + "', NgayCapNhat='" + lbtime.Text + "' WHERE MaNV= '" + txtMaNV.Text + "'";
                        SqlCommand cmd = new SqlCommand(sqlUpdate, connect);
                        cmd.ExecuteNonQuery();
                        dodulieu();
                        MessageBox.Show("Sửa thông tin thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công, còn thông tin trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dodulieu();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void thongtinnhanvien_Load(object sender, EventArgs e)
        {
            connect.Open();
            cbbgioitinh.Items.Add("Nam");
            cbbgioitinh.Items.Add("Nữ");
            txtMaNV.Text = manv.ToString();
            //lấy dữ liệu đổ vào textbox
           
            dodulieu();
            lbtime.Text = Get_tgian();
        }

        public string Get_tgian()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(0, 10);
            return str;
        }

        private void dodulieu()
        {
            try
            {
                string sql = "Select TenNV,NgaySinh,GioiTinh,DiaChi,SDT from tb_NhanVien where MaNV='" + txtMaNV.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataReader drd = cmd.ExecuteReader();
                    if(drd.Read())
                    {
                        string kt = "";
                        kt = drd["TenNV"].ToString();
                        if (kt != "")
                        {
                            string s = drd["TenNV"].ToString();
                            string s2 = (string)drd["GioiTinh"];
                            string s3 = (string)drd["DiaChi"];
                            string s4 = (string)drd["SDT"];

                            dtp1.Text = drd["NgaySinh"].ToString();
                            txtTenNV.Text = s;
                            cbbgioitinh.Text = s2;
                            txtDiaChiNV.Text = s3;
                            txtDienThoaiNV.Text = s4;
                            drd.Close();
                        }
                        else
                            drd.Close();
                    }                    
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void txtdoitk_Leave(object sender, EventArgs e)
        {
            if (txtdoitk.Text.Length == 0)
                lbtaikhoan.Text = "Không được bỏ trống tài khoản !";
            else
                lbtaikhoan.Text = "";
        }

        private void txtdoimkcu_Leave(object sender, EventArgs e)
        {
            if (txtdoimkcu.Text.Length == 0)
                lbmatkhaucu.Text = "Không được bỏ trống mật khẩu cũ !";
            else
                lbmatkhaucu.Text = "";
        }

        private void txtdoimkmoi_Leave(object sender, EventArgs e)
        {
            if (txtdoimkmoi.Text.Length == 0)
                lbmatkhaumoi.Text = "Không được bỏ trống mật khẩu mới !";
            else
                lbmatkhaumoi.Text = "";
        }

        private void txtdoixacnhan_Leave(object sender, EventArgs e)
        {
            if (txtdoixacnhan.Text.Length == 0)
                lbxacnhanmk.Text = "Không được bỏ trống xác nhận mật khẩu mới !";
            else
                lbxacnhanmk.Text = "";
        }

        private void bntluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdoitk.Text.Length > 0)
                {
                    if (txtdoimkcu.Text.Length > 0)
                    {
                        if (txtdoimkmoi.Text.Length > 0)
                        {
                            if (txtdoixacnhan.Text.Length > 0)
                            {
                                if (txtdoimkmoi.Text == txtdoixacnhan.Text)
                                {  
                                    string sql = "select * from tb_QLTaiKhoan where taikhoan='" + txtdoitk.Text + "' and matkhau='" + txtdoimkcu.Text + "'"; // truy vấn
                                    SqlCommand cmd = new SqlCommand(sql, connect);// thực thi cậu lệnh trong sql
                                    SqlDataReader dta = cmd.ExecuteReader();                               
                                    if (dta.Read() == true)
                                    {                                                                                                              
                                        dta.Close(); // đóng SQLDatareader
                                        string doimk = "update tb_QLTaiKhoan set matkhau = '" + txtdoixacnhan.Text + "' where taikhoan='" + txtdoitk.Text + "'";
                                        SqlCommand upmk = new SqlCommand(doimk, connect);
                                        upmk.ExecuteNonQuery();
                                      
                                        MessageBox.Show("Đổi mật khẩu thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtdoitk.Clear();
                                        txtdoimkcu.Clear();
                                        txtdoimkmoi.Clear();
                                        txtdoixacnhan.Clear();                                    
                                    }
                                    else
                                    {
                                        dta.Close(); // đóng SQLDatareader
                                        MessageBox.Show("Tài Khoản hoặc Mật Khẩu không chính xác !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtdoitk.Clear();
                                        txtdoimkcu.Clear();
                                        txtdoimkmoi.Clear();
                                        txtdoixacnhan.Clear();
                                        txtdoitk.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Xác nhận mật khẩu không khớp với mật khẩu !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtdoitk.Clear();
                                    txtdoimkcu.Clear();
                                    txtdoimkmoi.Clear();
                                    txtdoixacnhan.Clear();
                                    txtdoitk.Focus();
                                }
                            }

                            else
                            {
                                MessageBox.Show("Bạn không được bỏ trống xác nhận mật khẩu !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtdoixacnhan.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bạn không được bỏ trống mật khẩu mới !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtdoimkmoi.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn không được bỏ trống mật khẩu cũ !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtdoimkcu.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn không được bỏ trống tài khoản !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdoitk.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void thongtinnhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            connect.Close();
        }

        private void txtDiaChiNV_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChiNV.Text.Length > 0)
                lb_diachi.Text = "";
            else
                lb_diachi.Text = "Không được để trống Địa Chỉ";
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            if (txtTenNV.Text.Length > 0)
                lb_tennv.Text = "";
            else
                lb_tennv.Text = "Không được bỏ trống tên nhân viên";
        }

        private void txtDienThoaiNV_TextChanged(object sender, EventArgs e)
        {
            if (txtDienThoaiNV.Text.Length > 0)
                lb_SDT.Text = "";
            else
                lb_SDT.Text = "Không được bỏ trống số điện thoại";
        }

        private void txtDienThoaiNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

    }
}
