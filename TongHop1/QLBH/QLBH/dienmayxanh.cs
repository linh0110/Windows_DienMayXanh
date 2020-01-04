using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class dienmayxanh : Form
    {
        public dienmayxanh()
        {
            InitializeComponent();
        }

        public static string quyen,manv;

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtinnhanvien nv = new thongtinnhanvien();
            this.Hide();
            nv.ShowDialog();
            this.Show();

        }


        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khachhang kh = new khachhang();
            this.Hide();
            kh.ShowDialog();
            this.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banhang bh = new banhang();
            this.Hide();
            bh.ShowDialog();
            this.Show();
        }


        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kho k = new kho();
            this.Hide();
            k.ShowDialog();
            this.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanly ql = new quanly();
            this.Hide();
            ql.ShowDialog();
            this.Show();
        }

        private void dienmayxanh_Load(object sender, EventArgs e)
        {
            lbmanvtrangchu.Text = manv;
            lbchucvutrangchu.Text = quyen;

            if (quyen == "user")
            {
                khoToolStripMenuItem.Visible = false;
                quảnLýToolStripMenuItem.Visible = false;
                dOanhThuToolStripMenuItem.Visible = false;
                
            }
        }
 

        private void dienmayxanh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát chương trình !!!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (r == DialogResult.OK)
                Application.ExitThread();
            else
                e.Cancel = true;
        }

        private void bánHàng2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banhang ql = new banhang();
            this.Hide();
            ql.ShowDialog();
            this.Show();
        }

        private void dOanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Doanhthutong  ql= new Doanhthutong();
            this.Hide();
            ql.ShowDialog();
            this.Show();
        }

        private void doanhThuCủaBạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doanhsocanhan cn = new doanhsocanhan();
            this.Hide();
            cn.ShowDialog();
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbrun.Left += 50;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r= MessageBox.Show("Bạn có chắc chắn muốn đăng xuất ?","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (r == DialogResult.OK)
            {
                dangnhap lg = new dangnhap();
                this.Hide();                
                lg.ShowDialog();
                this.Show();
            }
        }
        //------------------------------------
    }
}
