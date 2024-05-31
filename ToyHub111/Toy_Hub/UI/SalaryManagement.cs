using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyHub.BL;
using ToyHub.DL;

namespace ToyHub.UI
{
    public partial class SalaryManagement : Form
    {
        public int staffId;
        public SalaryManagement()
        {
            InitializeComponent();

        }
        public SalaryManagement(int staffID)
        {
            InitializeComponent();
            this.staffId = staffID;
            PopulatePaymentMethodComboBox(payment_cbx);
        }

        private void PopulatePaymentMethodComboBox(System.Windows.Forms.ComboBox payment_cbx)
        {
            payment_cbx.Items.Clear();
            payment_cbx.Items.Add("In Cash");
            payment_cbx.Items.Add("Bank Transfer");
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            int paymentMethod = Salary.GetPaymentMethod(payment_cbx.Text);
            /* SalaryDL.UpdateSalaryStatusAndPaymentMethod(staffId, paymentMethod);*/

            if (SalaryDL.UpdateSalaryAmountWithBonus(staffId))
            {
                SalaryDL.UpdateSalaryStatusAndPaymentMethod(staffId, paymentMethod);
            }
            else
            {
                MessageBox.Show("Failed to transact!");

            }
            this.Hide();
            SalarySystem sm = new SalarySystem();
            sm.Show();

        }

        private void backarrow_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalarySystem salarySystem = new SalarySystem();
            salarySystem.Show();
        }

    }
}
