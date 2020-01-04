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
    public partial class showhd : Form
    {
        public showhd()
        {
            InitializeComponent();
        }

        public static string hangkm;
        public static string mahd;

        public string ma
        {
            get { return mahd; }
            set { mahd = value; }
        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {
            Hoadon hd = new Hoadon();
            crystalReportViewer1.ReportSource = hd;
            hd.SetDatabaseLogon("sa", "sa2012", "LAPTOP-M82S6JDB","QuanLyBanHangv2");
            crystalReportViewer1.Refresh();
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = false;

            hd.SetParameterValue("Lọc HD", mahd);
           
          
        }

       
    }
}
