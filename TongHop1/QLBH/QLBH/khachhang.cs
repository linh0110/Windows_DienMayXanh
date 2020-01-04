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
    public partial class khachhang : Form
    {
        public khachhang()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-M82S6JDB;Initial Catalog=QuanLyBanHangv2;user ID=123;password=sa2012;Integrated Security=True");

        private void btntimkiemkh_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSelect = "SELECT*FROM tb_KhachHang WHERE MaKH=@maKH OR TenKH=@tenKH OR SDTKH=@sdt OR DiaChiKH=@dc";
                SqlCommand cmd = new SqlCommand(sqlSelect, connect);
                cmd.Parameters.AddWithValue("@maKH", txtKiemkiemkh.Text);
                cmd.Parameters.AddWithValue("@tenKH", txtKiemkiemkh.Text);
                cmd.Parameters.AddWithValue("@sdt", txtKiemkiemkh.Text);
                cmd.Parameters.AddWithValue("@dc", txtKiemkiemkh.Text);
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvKH.DataSource = dt;
                txtKiemkiemkh.Clear();
                bingding3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timkiemtuongdoi()
        {
            txtKiemkiemkh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtKiemkiemkh.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            try
            {


                string s = "SELECT *FROM tb_KhachHang";
                SqlCommand cmd = new SqlCommand(s, connect);
                SqlDataReader drd = cmd.ExecuteReader();
                while (drd.Read())
                {
                    coll.Add(drd["TenKH"].ToString());
                    coll.Add(drd["SDTKH"].ToString());
                    coll.Add(drd["DiaChiKH"].ToString());
                }
                txtKiemkiemkh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtKiemkiemkh.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtKiemkiemkh.AutoCompleteCustomSource = coll;
                drd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bingding3()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("text", dgvKH.DataSource, "MaKH");
            //
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("text", dgvKH.DataSource, "TenKH");
            //
            txtDCKH.DataBindings.Clear();
            txtDCKH.DataBindings.Add("text", dgvKH.DataSource, "DiaChiKH");
            //
            txtSDTKH.DataBindings.Clear();
            txtSDTKH.DataBindings.Add("text", dgvKH.DataSource, "SDTKH");
            //
            cbb_gt.DataBindings.Clear();
            cbb_gt.DataBindings.Add("text", dgvKH.DataSource, "GioiTinhKH");            
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (btnThemKH.Text == "Thêm")
            {
                txtDCKH.Clear();
                txtSDTKH.Clear();
                txtTenKH.Clear();
                txtMaKH.Clear();
                cbb_gt.SelectedIndex = 0;
                btnThemKH.Text = "Lưu";
                txtTenKH.Focus();
                btnXoaKH.Enabled = false;
                btnSuaKH.Enabled = false;                
                dgvKH.Enabled = false;
            }
            else
            {
                btnThemKH.Text = "Thêm";
                btnXoaKH.Enabled = true;
                btnSuaKH.Enabled = true;               
                dgvKH.Enabled = true;
                try
                {                    
                    if (txtTenKH.Text.Length != 0 && txtMaKH.Text.Length != 0 && txtSDTKH.Text.Length != 0 && txtDCKH.Text.Length != 0)
                    {
                        string sqlInsert = "INSERT INTO tb_KhachHang VALUES ('" + txtMaKH.Text + "',N'" + txtTenKH.Text + "','" + txtSDTKH.Text + "',N'" + cbb_gt.SelectedItem.ToString() + "',N'" + txtDCKH.Text + "')";
                        SqlCommand cmd = new SqlCommand(sqlInsert, connect);
                        cmd.ExecuteNonQuery();                        
                        HienThi3();
                        bingding3();
                        MessageBox.Show("Thêm khách hàng thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        HienThi3();
                        bingding3();
                        MessageBox.Show("Thêm không thành công, còn thiếu thông tin chưa điền !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dienmakh()
        {
            try
            {
                if (txtDCKH.Text.Length > 0 && txtSDTKH.Text.Length > 0 && txtTenKH.Text.Length > 0 && cbb_gt.SelectedIndex != -1)
                {
                    string ten = txtTenKH.Text.Substring(0, 2);
                    int index = txtSDTKH.Text.Length;
                    string sdt = txtSDTKH.Text.Substring(index - 3, 3);
                    string ma = string.Format("KH" + sdt + ten);
                    //kiểm tra trùng
                    string sql = "select tb_KhachHang.MaKH from tb_KhachHang where tb_KhachHang.MaKH= '" + ma + "'";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    SqlDataReader doc = cmd.ExecuteReader();
                    if (doc.Read())
                    {
                        ma = string.Format("K1" + sdt + ten);
                    }
                    doc.Close();
                    txtMaKH.Text = ma;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void HienThi3()
        {
            string sql = "select * from tb_KhachHang";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKH.DataSource = dt;
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvKH.CurrentRow.Index;                
                DialogResult r= MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này !","Thông Báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);                
                if (r== DialogResult.OK)
                {
                    string sqlDel = "DELETE FROM tb_KhachHang WHERE MaKH= '"+dgvKH.Rows[index].Cells[0].Value.ToString()+"'";
                    SqlCommand cmd = new SqlCommand(sqlDel, connect);                    
                    cmd.ExecuteNonQuery();
                    HienThi3();
                    bingding3();
                    MessageBox.Show("Xóa khách hàng thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đối tượng này đã có trong Hóa Đơn nên không thể xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSuaKH.Text == "Sửa")
                {
                    btnSuaKH.Text = "Lưu";
                    btnThemKH.Enabled = false;
                    btnXoaKH.Enabled = false;
                    dgvKH.Enabled = false;
                    txtTenKH.Focus();
                }
                else
                {
                    btnSuaKH.Text = "Sửa";
                    btnThemKH.Enabled = true;
                    btnXoaKH.Enabled = true;
                    dgvKH.Enabled = true;
                    if (txtTenKH.Text.Length != 0 && txtMaKH.Text.Length != 0 && txtSDTKH.Text.Length != 0 && txtDCKH.Text.Length != 0)
                    {
                        string sqlUpdate3 = "UPDATE tb_KhachHang SET TenKH= N'" + txtTenKH.Text + "',SDTKH='" + txtSDTKH.Text + "',GioiTinhKH=N'" + cbb_gt.SelectedItem.ToString() + "',DiaChiKH=N'" + txtDCKH.Text + "' WHERE MaKH= '" + txtMaKH.Text + "'";
                        SqlCommand cmd = new SqlCommand(sqlUpdate3, connect);
                        cmd.ExecuteNonQuery();
                        HienThi3();
                        bingding3();
                        MessageBox.Show("Sửa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        HienThi3();
                        bingding3();
                        MessageBox.Show("Sửa không thành công, còn thiếu thông tin chưa điền !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReloadKH_Click(object sender, EventArgs e)
        {
            try
            {
                btnThemKH.Text = "Thêm";
                btnSuaKH.Text = "Sửa";
                btnXoaKH.Enabled = true;
                btnSuaKH.Enabled = true;
                dgvKH.Enabled = true;
                btnThemKH.Enabled = true;
                showkhachhang();
                bingding3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCloseKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void khachhang_Load(object sender, EventArgs e)
        {
            connect.Open();
            cbb_gt.Items.Add("Nam");
            cbb_gt.Items.Add("Nữ");
            cbb_gt.SelectedIndex = 0;
            showkhachhang();
            bingding3();
            timkiemtuongdoi();
        }

        private void khachhang_FormClosing(object sender, FormClosingEventArgs e)
        {
            connect.Close();
        }

        private void txtSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        public void showkhachhang()
        {
            string sql = "select * from tb_KhachHang";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKH.DataSource = dt;
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            if (btnThemKH.Text == "Lưu")
            dienmakh();
            if (txtTenKH.Text.Length > 0)
                lbtenkhach.Text = "";
            else
                lbtenkhach.Text = "Không được bỏ trống tên khách hàng";                
        }

        private void txtDCKH_TextChanged(object sender, EventArgs e)
        {
            if (btnThemKH.Text == "Lưu")
                dienmakh();
            if (txtDCKH.Text.Length == 0)
                lbdiachi.Text = "Không được để trông địa chỉ";
            else
                lbdiachi.Text = "";
        }

        private void txtSDTKH_TextChanged(object sender, EventArgs e)
        {
            if (btnThemKH.Text == "Lưu")
                dienmakh();
            if (txtSDTKH.Text.Length == 0)
                lbsdt.Text = "Không được để trống số điện thoại";
            else
                lbsdt.Text = "";        
        }

        private void cbb_gt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThemKH.Text == "Lưu")
                dienmakh();
        }


        //-------------------------------------------------------
    }
}
