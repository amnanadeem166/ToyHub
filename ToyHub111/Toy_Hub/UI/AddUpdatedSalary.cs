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
    public partial class AddUpdatedSalary : Form
    {
        public int staffId;

        public AddUpdatedSalary()
        {
            InitializeComponent();
        }

        public AddUpdatedSalary(int staffId)
        {
            InitializeComponent();
            this.staffId = staffId;
            this.staffId_txt.Text = staffId.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UpdateSalary updateSalary = new UpdateSalary();
            this.Hide();
            updateSalary.Show();
        }

        private void assign_btn_Click_1(object sender, EventArgs e)
        {
            if (!Validations.ValidateInt(salary_txt.Text, out int newSalary))
            {
                return;
            }
            else
            {
                // Now you have a valid integer value in newSalary
                SalaryDL.UpdateStaffSalary(staffId, newSalary);

            }
        }
    }
}

