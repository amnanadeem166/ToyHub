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
namespace ToyHub.UI
{
    public partial class SalarySystem : Form
    {
        SqlConnection con = Configuration.getInstance().getConnection();
        public SalarySystem()
        {
            InitializeComponent();
            LoadStaffData();
            AddPayrollButtonColumn();
        }
        private void AddPayrollButtonColumn()
        {
            // Create a button column
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Payroll";
            editButtonColumn.HeaderText = "Payroll";
            editButtonColumn.Text = "Payroll";
            editButtonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            dataGrid.Columns.Add(editButtonColumn);
        }
        public void LoadStaffData()
        {
            try
            {
                using (con)
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Close();
                        con.Open();
                    }

                    // Adjust the query to join Person and StaffMember tables
                    SqlCommand cmd = new SqlCommand("SELECT Person.FirstName, StaffMember.staffID FROM Person INNER JOIN StaffMember ON Person.PersonID = StaffMember.StaffID WHERE StaffMember.StatusOfMember != 4", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGrid.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL Server exceptions
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void SalarySystem_Load(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGrid.Columns["Payroll"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGrid.Rows[e.RowIndex];
                UpdateStaffSalary(selectedRow);


            }
        }
        private void UpdateStaffSalary(DataGridViewRow selectedRow)
        {
            string staffID = selectedRow.Cells["StaffID"].Value.ToString();
            int memberID = int.Parse(staffID);
            SalaryManagement salaryManagement = new SalaryManagement(memberID);
            this.Hide();
            salaryManagement.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerDashboard managerDashboard = new ManagerDashboard();
            managerDashboard.Show();
        }

        private void dataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGrid.Columns["Payroll"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGrid.Rows[e.RowIndex];
                UpdateStaffSalary(selectedRow);


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ManagerDashboard md = new ManagerDashboard();
            md.Show();
        }
    }
}
