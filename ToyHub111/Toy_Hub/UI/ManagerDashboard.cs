using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyHub.UI
{
    public partial class ManagerDashboard : Form
    {
        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void addSender_Click(object sender, EventArgs e)
        {
            ShipmentManagement s = new ShipmentManagement();
            this.Hide();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalarySystem s = new SalarySystem();
            this.Hide();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StaffManagement s = new StaffManagement();
            this.Hide();
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainAttendanceForm markAttendance = new MainAttendanceForm();
            this.Hide();
            markAttendance.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            this.Hide();
            productManagement.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateSalary updateSalary = new UpdateSalary();
            this.Hide();
            updateSalary.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StockManagement stockManagement = new StockManagement();
            this.Hide();
            stockManagement.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateReports generateReports = new GenerateReports();
            this.Hide();
            generateReports.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReportsPage reportsPage = new ReportsPage();
            this.Hide();
            reportsPage.Show();
        }
    }
}
