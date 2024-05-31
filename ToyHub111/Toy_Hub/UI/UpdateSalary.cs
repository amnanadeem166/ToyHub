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
    public partial class UpdateSalary : Form
    {
        SqlConnection con = Configuration.getInstance().getConnection();
        public UpdateSalary()
        {
            InitializeComponent();
            LoadStaffData();
            AddDecideSalaryButtonColumn();

        }

        private void AddDecideSalaryButtonColumn()
        {
            // Create a button column
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "DecideSalary";
            editButtonColumn.HeaderText = "DecideSalary";
            editButtonColumn.Text = "DecideSalary";
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGrid.Columns["DecideSalary"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGrid.Rows[e.RowIndex];
                UpdateStaffSalary(selectedRow);


            }
        }
        private void UpdateStaffSalary(DataGridViewRow selectedRow)
        {
            string staffID = selectedRow.Cells["StaffID"].Value.ToString();
            int memberID = int.Parse(staffID);
            AddUpdatedSalary addUpdateSalary = new AddUpdatedSalary(memberID);

            this.Hide();
            addUpdateSalary.Show();
        }

        private void UpdateSalary_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerDashboard mn = new ManagerDashboard();   
            mn.Show();
        }
    }
}
