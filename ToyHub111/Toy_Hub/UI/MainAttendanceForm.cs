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
using ToyHub.BL;
using ToyHub.DL;
namespace ToyHub.UI
{
    public partial class MainAttendanceForm : Form
    {
        SqlConnection con = Configuration.getInstance().getConnection();
        public MainAttendanceForm()
        {
            InitializeComponent();
            LoadStaffData();
            AddMarkAttendanceButtonColumn();

        }

        private void AddMarkAttendanceButtonColumn()
        {
            // Create a button column
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "MarkAttendance";
            editButtonColumn.HeaderText = "Mark";
            editButtonColumn.Text = "Mark";
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
        private void MainAttendanceForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGrid.Columns["MarkAttendance"].Index && e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGrid.Rows[e.RowIndex];

                // Call a method to handle editing based on the selected row data
                HandelAttendance(selectedRow);
            }


        }

        private void HandelAttendance(DataGridViewRow selectedRow)
        {
            string staffID = selectedRow.Cells["StaffID"].Value.ToString();
            int memberID = int.Parse(staffID);
            TimeSpan? nullableTime = null;
            Attendance attendance = new Attendance(memberID, DateTime.Now.TimeOfDay, nullableTime);
            MarkAttendance markAttendance = new MarkAttendance(memberID);
            this.Hide();
            markAttendance.Show();
            /* AttendanceDL.AddAttendance(attendance);*/


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerDashboard managerDashboard = new ManagerDashboard();
            managerDashboard.Show();
        }

        private void dataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGrid.Columns["MarkAttendance"].Index && e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGrid.Rows[e.RowIndex];

                // Call a method to handle editing based on the selected row data
                HandelAttendance(selectedRow);
            }

        }
    }
}
