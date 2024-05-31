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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToyHub.DL;

namespace ToyHub.UI
{
    public partial class MarkAttendance : Form
    {
        public int staffID;
        private SqlConnection con = Configuration.getInstance().getConnection();
        public MarkAttendance()
        {
            InitializeComponent();

        }

        public MarkAttendance(int staffId)
        {
            InitializeComponent();
            this.staffID = staffId;


            LoadStaffData(staffId);
            AddMarkArrivalTimeButtonColumn();
            AddMarkLeavingTimeButtonColumn();
        }
        private void AddMarkArrivalTimeButtonColumn()
        {
            // Create a button column
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "MarkArrivalTime";
            editButtonColumn.HeaderText = "MarkArrivalTime";
            editButtonColumn.Text = "MarkArrivalTime";
            editButtonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            dataGrid.Columns.Add(editButtonColumn);
        }

        private void AddMarkLeavingTimeButtonColumn()
        {
            // Create a button column
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "MarkLeavingTime";
            editButtonColumn.HeaderText = "MarkLeavingTime";
            editButtonColumn.Text = "MarkLeavingTime";
            editButtonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            dataGrid.Columns.Add(editButtonColumn);
        }



        public void LoadStaffData(int staffID)
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

                    // Adjust the query to join Person and StaffMember tables and filter by staffID
                    SqlCommand cmd = new SqlCommand("SELECT Person.FirstName, Person.LastName, StaffMember.StaffID  FROM Person INNER JOIN StaffMember ON Person.PersonID = StaffMember.StaffID WHERE StaffMember.StaffID = @StaffID AND StaffMember.StatusOfMember != 4", con);
                    cmd.Parameters.AddWithValue("@StaffID", staffID);

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

    
        public void MarkArrivalTime()
        {
            TimeSpan? nullableTime = null;
            Attendance attendance = new Attendance(staffID, DateTime.Now.TimeOfDay, nullableTime);
            AttendanceDL.AddAttendance(attendance);
            this.Hide();
            MainAttendanceForm mainAttendanceForm = new MainAttendanceForm();
            mainAttendanceForm.Show();
        }
        public void MarkLeavingTime()
        {
            int attendanceID = AttendanceDL.GetAttendanceID(staffID);



            AttendanceDL.MarkLeavingTime(attendanceID);
            /* AttendanceDL.UpdateAttendance(attendance);*/
            this.Hide();
            MainAttendanceForm mainAttendanceForm = new MainAttendanceForm();
            mainAttendanceForm.Show();
        }

      

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGrid.Columns["MarkArrivalTime"].Index && e.RowIndex >= 0)
            {

                MarkArrivalTime();
            }
            if (e.ColumnIndex == dataGrid.Columns["MarkLeavingTime"].Index && e.RowIndex >= 0)
            {
                MarkLeavingTime();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainAttendanceForm managerDashboard = new MainAttendanceForm();
            this.Hide();
            managerDashboard.Show();
        }
    }
}
