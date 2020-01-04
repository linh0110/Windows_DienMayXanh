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
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-M82S6JDB;Initial Catalog=QuanLyBanHangv2;user ID=123;password=sa2012;Integrated Security=True");
                
        private void dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {            
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát chương trình !!!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.Cancel)
            {
                e.Cancel = true;                
            }
        }

        private void bntlogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "select * from tb_QLTaiKhoan where taikhoan='" + txtusername.Text + "' and matkhau='" + txtpassword.Text + "'"; // truy vấn
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    dta.Close();                    
                    dienmayxanh ql = new dienmayxanh();                    
                    dienmayxanh.quyen = ktraQUYEN("SELECT quyen FROM tb_QLTaiKhoan where taikhoan='" + txtusername.Text + "' and matkhau='" + txtpassword.Text + "'");
                    // lấy mã nhân viên
                    thongtinnhanvien.manv = laymanv("select MaNV from tb_QLTaiKhoan where taikhoan='" + txtusername.Text + "' and matkhau='" + txtpassword.Text + "'");
                    dienmayxanh.manv = laymanv("select MaNV from tb_QLTaiKhoan where taikhoan='" + txtusername.Text + "' and matkhau='" + txtpassword.Text + "'");
                    banhang.manv = laymanv("select MaNV from tb_QLTaiKhoan where taikhoan='" + txtusername.Text + "' and matkhau='" + txtpassword.Text + "'");
                    doanhsocanhan.manv = laymanv("select MaNV from tb_QLTaiKhoan where taikhoan='" + txtusername.Text + "' and matkhau='" + txtpassword.Text + "'");

                    this.Hide();
                    ql.ShowDialog();
                    this.Show();
                }

                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtusername.Clear();
                    txtpassword.Clear();
                    txtusername.Focus();
                }
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntexit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát chương trình !!!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (r == DialogResult.OK)
                Application.ExitThread();
        }


        private void chkshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowpassword.Checked == true)
                txtpassword.UseSystemPasswordChar = false;
            else
                txtpassword.UseSystemPasswordChar = true;
        }

        public string ktraQUYEN(string sql)
        {
            string a = "";
            SqlCommand cmd = new SqlCommand(sql, conn);
            //SqlDataReader dreader = cmd.ExecuteReader();
            //if (dreader.Read())
            //{
            //    a = dreader.GetString(0);
            //}
            a = cmd.ExecuteScalar().ToString();
            return a;
        }

        public string laymanv(string s)
        {
            string b = "";
            SqlCommand cmd = new SqlCommand(s, conn);
            b = cmd.ExecuteScalar().ToString();
            return b;
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {
            
        }

        //-----------------------------------------------------------
    }
}
