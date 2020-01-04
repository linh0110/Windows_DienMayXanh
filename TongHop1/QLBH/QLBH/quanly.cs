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
    public partial class quanly : Form
    {
        public quanly()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-M82S6JDB;Initial Catalog=QuanLyBanHangv2;user ID=123;password=sa2012;Integrated Security=True");

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txttendangnhap.Clear();
            txtmatkhau.Clear();
            txtmanv.Clear();
            txtxacnhan.Clear();
            txttendangnhap.Focus();
        }

        private void timkiemtuongdoi()
        {
            txtTIMKIEM.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTIMKIEM.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            try
            {


                string s = "SELECT *FROM tb_NhanVien";
                SqlCommand cmd = new SqlCommand(s, connect);
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    coll.Add(drd["TenNV"].ToString());
                }
                txtTIMKIEM.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtTIMKIEM.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtTIMKIEM.AutoCompleteCustomSource = coll;
                drd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            if (txttendangnhap.Text.Length > 0 && txtmatkhau.Text.Length > 0 && txtxacnhan.Text.Length > 0 && txtmanv.Text.Length > 0)
            {
                if (txtmatkhau.Text == txtxacnhan.Text)
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        string kt = "select * from tb_QLTaiKhoan where taikhoan = '" + txttendangnhap.Text + "'";
                        SqlCommand commandkt = new SqlCommand(kt, connect);
                        SqlDataAdapter da = new SqlDataAdapter(commandkt);
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng nhập tên đăng nhập khác !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txttendangnhap.Clear();
                            txtmatkhau.Clear();
                            txtxacnhan.Clear();
                            txtmanv.Clear();
                            txttendangnhap.Focus();
                        }
                        else
                        {
                            string quyen = "";
                            if (rbtadmin.Checked == true)
                                quyen = rbtadmin.Text;
                            else
                                quyen = rbtuser.Text;
                            //thêm mã nhân viên
                            string themma = "INSERT INTO tb_NhanVien(MaNV) VALUES ('"+txtmanv.Text+"')";
                            SqlCommand command = new SqlCommand(themma, connect);
                            command.ExecuteNonQuery();
                            //thêm tài khoản
                            string them = "INSERT INTO tb_QLTaiKhoan VALUES ('" + txttendangnhap.Text + "','" + txtmatkhau.Text + "','" + quyen + "','" + txtmanv.Text + "')";
                            SqlCommand commandthem = new SqlCommand(them, connect);
                            commandthem.ExecuteNonQuery();
                            MessageBox.Show("Đăng ký thành công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txttendangnhap.Clear();
                            txtmatkhau.Clear();
                            txtxacnhan.Clear();
                            txtmanv.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Xác nhận mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttendangnhap.Clear();
                    txtmatkhau.Clear();
                    txtxacnhan.Clear();
                    txtmanv.Clear();
                    txttendangnhap.Focus();
                }
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại, vui lòng điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quanly_Load(object sender, EventArgs e)
        {
            connect.Open();
            string sqlSelect = "SELECT * FROM tb_NhanVien";
            SqlCommand cmd = new SqlCommand(sqlSelect, connect);

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvNV.DataSource = dt;
            txtTIMKIEM.Focus();
            timkiemtuongdoi();
        }

        private void quanly_FormClosing(object sender, FormClosingEventArgs e)
        {
            connect.Close();
        }

        private void txttendangnhap_Leave(object sender, EventArgs e)
        {
            if (txttendangnhap.Text.Length > 0)
                lbdangnhap.Text = "";
            else
                lbdangnhap.Text = "Không được bỏ trống tên đăng nhập";
            dienma();
        }

        private void txtmatkhau_Leave(object sender, EventArgs e)
        {
            if (txtmatkhau.Text.Length > 0)
                lbmatkhau.Text = "";
            else
                lbmatkhau.Text = "Không được bỏ trống tên mật khẩu";
            dienma();
        }

        private void txtxacnhan_Leave(object sender, EventArgs e)
        {
            if (txtxacnhan.Text.Length > 0)
                lbxacnhan.Text = "";
            else
                lbxacnhan.Text = "Không được bỏ trống tên xác nhận mật khẩu";
            dienma();
        }

        private void dienma()
        {
            if (txttendangnhap.Text.Length > 0 && txtmatkhau.Text.Length > 0 && txtxacnhan.Text.Length > 0)
            {
                string demma = @"select count(tb_NhanVien.MaNV) from tb_NhanVien";
                SqlCommand cmddemma = new SqlCommand(demma, connect);
                string dem = cmddemma.ExecuteScalar().ToString();
                int d = Convert.ToInt32(dem);
                d++;
                string s;
                if (d < 10)
                    s = string.Format("NV00{0}", d);
                else if (d < 100)
                    s = string.Format("NV0{0}", d);
                else
                    s = string.Format("NV{0}", d);
                txtmanv.Text = s;
            }
        }

        private void btnTimkiemNV_Click(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT*FROM tb_NhanVien WHERE MaNV='" + txtTIMKIEM.Text + "' or TenNV='" + txtTIMKIEM.Text + "' or GioiTinh='" + txtTIMKIEM.Text + "' or DiaChi='" + txtTIMKIEM.Text + "' or SDT='" + txtTIMKIEM.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, connect);            

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvNV.DataSource = dt;
            txtTIMKIEM.Clear();      
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT * FROM tb_NhanVien";
            SqlCommand cmd = new SqlCommand(sqlSelect, connect);

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvNV.DataSource = dt;
        }
       

        //-----------------------------------
    }
}
