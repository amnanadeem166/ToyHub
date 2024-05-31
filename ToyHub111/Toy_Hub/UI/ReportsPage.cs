using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toy_Hub.UI;

namespace ToyHub.UI
{
    public partial class ReportsPage : Form
    {
        public ReportsPage()
        {
            InitializeComponent();
        }

        private void Profit_btn_Click(object sender, EventArgs e)
        {
            ViewReport vR = new ViewReport();
            vR.LoadReport("CrystalReport1.rpt");
            vR.Show();
        }

        private void purchase_btn_Click(object sender, EventArgs e)
        {
            ViewReport vR = new ViewReport();
            vR.LoadReport("CrystalReport2.rpt");
            vR.Show();
        }

        private void staff_btn_Click(object sender, EventArgs e)
        {
            ViewReport vR = new ViewReport();
            vR.LoadReport("CrystalReport3.rpt");
            vR.Show();
        }

        private void backarrow_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerDashboard md = new ManagerDashboard();
            md.Show();
        }
    }
}
