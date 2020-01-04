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
    public partial class khuyenmai : Form
    {
        public khuyenmai()
        {
            InitializeComponent();
        }


        private string check()
        {
            if (rd1.Checked)
                return rd1.Text;
            if (rd2.Checked)
                return rd2.Text;
            if (rd3.Checked) 
                return rd3.Text;
            else
                return "không có";
        }
        private void khuyenmai_Load(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            showhd.hangkm=check();
            banhang.hangkm = check();
            this.Close();
        }
    }
}
