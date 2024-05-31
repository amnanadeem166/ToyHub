using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyHub.DL;

namespace ToyHub.UI
{
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = email_txt.Text;
            string password = Password_txt.Text;
            int staffID = LoginDL.isValidLogin(email, password);
            int managerID=LoginDL.ManagerLogin(email, password);
          
            if (staffID != -1)
            {
                // Login is successful for a staff member
                // Open the staff member form and pass the staffID
                PunchOrder staffForm = new PunchOrder(staffID);
                staffForm.Show();
            }
            // Check if the login is for a manager
            else if (managerID != -1)
            {
                // Login is successful for a manager
                // Open the manager form and pass the managerID
                ManagerDashboard managerForm = new ManagerDashboard();
                managerForm.Show();
                this.Hide();
               
            }
            else
            {
                // Invalid login, display error message
                MessageBox.Show("Invalid email or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
