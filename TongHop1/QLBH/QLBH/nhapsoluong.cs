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
    public partial class nhapsoluong : Form
    {
        public nhapsoluong()
        {
            InitializeComponent();
        }        

        private void bnthuy_Click(object sender, EventArgs e)
        {
            banhang.sl = 0;
            this.Close();
        }

        private void bntok_Click(object sender, EventArgs e)
        {
            if (int.Parse(numsl.Value.ToString()) == 0)
                MessageBox.Show("Có ai mua 0 sản phẩm đâu !!!", "Thông báo");
            else
            {
                banhang.sl = int.Parse(numsl.Value.ToString());
                this.Close();
            }
        }

        //---------------------
    }
}
