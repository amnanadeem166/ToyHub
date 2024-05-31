using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyHub.BL;
using ToyHub.DL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ToyHub.UI
{
    public partial class StaffManagement : Form
    {
        private string connectionString = @"Data Source=(local);Initial Catalog=ToyHub;Integrated Security=True";


        public StaffManagement()
        {
            InitializeComponent();
            LoadStaffData();
            PopulateGenderComboBox(gen_cbx);
            PopulateStaffTypeComboBox(type_cbx);
            staff_dgv.SelectionChanged += dgvStaff_SelectionChanged;
            AddEditButtonColumn();
            AddDeleteButtonColumn();

        }

        private void PopulateStaffTypeComboBox(System.Windows.Forms.ComboBox type_cbx)
        {
            type_cbx.Items.Clear();
            type_cbx.Items.Add("Cashier");
            type_cbx.Items.Add("Salesperson");
        }

        private void PopulateGenderComboBox(System.Windows.Forms.ComboBox gen_cbx)
        {
            gen_cbx.Items.Clear();
            gen_cbx.Items.Add("Male");
            gen_cbx.Items.Add("Female");
        }

        private void AddDeleteButtonColumn()
        {
            // Create a button column for delete
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButton";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;

            // Add a handler for the DataGridView's CellContentClick event
            staff_dgv.CellContentClick += Staff_dgv_CellContentClick;

            // Add the button column to the DataGridView
            staff_dgv.Columns.Add(deleteButtonColumn);
        }
        private void Staff_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == staff_dgv.Columns["DeleteButton"].Index && e.RowIndex >= 0 && !staff_dgv.Rows[e.RowIndex].IsNewRow)
            {
                // Perform deletion logic here
                DataGridViewRow selectedRow = staff_dgv.Rows[e.RowIndex];
                DeleteMember(selectedRow);
                int rowIndex = e.RowIndex;
                staff_dgv.Rows.RemoveAt(rowIndex);
            }
        }

        public static StaffMember GetDataOfSelectedRow(DataGridViewRow selectedRow)
        {
            string staffID = selectedRow.Cells["StaffID"].Value.ToString();
            string firstName = selectedRow.Cells["FirstName"].Value.ToString();
            string lastName = selectedRow.Cells["LastName"].Value.ToString();
            string email = selectedRow.Cells["Email"].Value.ToString();
            string address = selectedRow.Cells["Address"].Value.ToString();
            string contact = selectedRow.Cells["ContactNumber"].Value.ToString();
            string status = selectedRow.Cells["StatusOfMember"].Value.ToString();
            string qualification = selectedRow.Cells["Qualification"].Value.ToString();
            string gender = selectedRow.Cells["GenderID"].Value.ToString();
            string staffType = selectedRow.Cells["TypeOfMember"].Value.ToString();
            DateTime dob = Convert.ToDateTime(selectedRow.Cells["DOB"].Value);
            DateTime joiningDate = Convert.ToDateTime(selectedRow.Cells["JoiningDate"].Value);

            int genderID = int.Parse(gender);
            int staffTypeID = int.Parse(staffType);
            int staffStatus = StaffMember.GetStaffStatusID("Expelled");
            int memberID = int.Parse(staffID);
            string password = selectedRow.Cells["Password"].Value.ToString();
          /*  MessageBox.Show(
                $"First Name: {firstName}\n" +
                $"Last Name: {lastName}\n" +
                $"Email: {email}\n" +
                $"Address: {address}\n" +
                $"Contact Number: {contact}\n" +
                $"Status: {staffStatus}\n" +
                $"Qualification: {qualification}\n" +
                $"Gender: {genderID}\n" +
                $"Staff Type: {staffTypeID}\n" +
                $"Date of Birth: {dob.ToShortDateString()}\n" +
                $"Joining Date: {joiningDate.ToShortDateString()}",
                "Selected Row Details"
            );*/
            StaffMember staffMember = new StaffMember(memberID, firstName, lastName, password,email, address, contact, genderID, dob, qualification, joiningDate, staffTypeID, staffStatus);

            return staffMember;
        }
        private static void DeleteMember(DataGridViewRow selectedRow)
        {

            StaffMemberDL.UpdateStaffMember(GetDataOfSelectedRow(selectedRow));

        }
        private void AddEditButtonColumn()
        {
            // Create a button column
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "EditButton";
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            staff_dgv.Columns.Add(editButtonColumn);
        }
        private void HandleEdit(DataGridViewRow selectedRow)
        {
            string staffID = selectedRow.Cells["StaffID"].Value.ToString();
            string firstName = selectedRow.Cells["FirstName"].Value.ToString();
            string lastName = selectedRow.Cells["LastName"].Value.ToString();
            string email = selectedRow.Cells["Email"].Value.ToString();
            string address = selectedRow.Cells["Address"].Value.ToString();
            string contact = selectedRow.Cells["ContactNumber"].Value.ToString();
            string status = selectedRow.Cells["StatusOfMember"].Value.ToString();
            string qualification = selectedRow.Cells["Qualification"].Value.ToString();
            string gender = selectedRow.Cells["GenderID"].Value.ToString();
            string staffType = selectedRow.Cells["TypeOfMember"].Value.ToString();
            DateTime dob = Convert.ToDateTime(selectedRow.Cells["DOB"].Value);
            DateTime joiningDate = Convert.ToDateTime(selectedRow.Cells["JoiningDate"].Value);
            string password = selectedRow.Cells["Password"].Value.ToString();
            int genderID = int.Parse(gender);
            int staffTypeID = int.Parse(staffType);
            int staffStatus = int.Parse(status);
            int memberID = int.Parse(staffID);
           


            StaffMember satffMember = new StaffMember(memberID, firstName, lastName, password,email, address, contact, genderID, dob, qualification, joiningDate, staffTypeID, staffStatus);


            UpdateStaff editForm = new UpdateStaff(satffMember);
            this.Hide();
            editForm.Show(); // Show as a modal dialog



        }
        private void dgvStaff_SelectionChanged(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (staff_dgv.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = staff_dgv.SelectedRows[0];

                // Call the function to populate text boxes with selected row data
                PopulateTextBoxesWithSelectedRow(selectedRow);
            }
            else
            {
                // If no row is selected, clear the text boxes
                ClearFields();
            }
        }



        public void LoadStaffData()
        {
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Close();
                        con.Open();
                    }

                    // Adjust the query to join Person and StaffMember tables
                    SqlCommand cmd = new SqlCommand("SELECT Person.*, StaffMember.* FROM Person INNER JOIN StaffMember ON Person.PersonID = StaffMember.StaffID WHERE StaffMember.StatusOfMember != 4", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    staff_dgv.DataSource = dt;
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

        private void Search_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ClearFields()
        {
            Fname_txt.Text = "";
            Lname_tx.Text = "";
            email_txt.Text = "";
            address_txt.Text = "";
            contact_txt.Text = "";
            qualification.Text = "";
            salary_txt.Text = "";
            gen_cbx.SelectedIndex = -1; // Clear selected gender
            type_cbx.SelectedIndex = -1; // Clear selected staff type
            dob_dtp.Value = DateTime.Today; // Reset date of birth to today's date
            joini_dtp.Value = DateTime.Today; // Reset joining date to today's date
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            StaffMemberDL.AddStaffMember(GetDataToAddFromUI());
            int staffID = StaffMemberDL.GetLastInsertedStaffID();
            SalaryDL.AddSalary(staffID);
            LoadStaffData();
            ClearFields();
        }

        public StaffMember GetDataToAddFromUI()
        {
            string firstName = Fname_txt.Text;
            string lastName = Lname_tx.Text;
            string email = email_txt.Text;
            string address = address_txt.Text;
            string contactNumber = contact_txt.Text;

            DateTime dob = dob_dtp.Value.Date;
            string qualificationofMember = qualification.Text;
            DateTime joiningDate = joini_dtp.Value.Date;

            int genderID = Person.GetGenderId(gen_cbx.Text);

            int typeOfMember = StaffMember.GetStaffTypeID(type_cbx.Text);

            int statusID = StaffMember.GetStaffStatusID("Active");
            string inputSalary = salary_txt.Text;
            int salary = int.Parse(inputSalary);

            string password = password_txt.Text;
            string message = "First Name: " + firstName + "\n" +
                 "Last Name: " + lastName + "\n" +
                 "Email: " + email + "\n" +
                 "Address: " + address + "\n" +
                 "Contact Number: " + contactNumber + "\n" +
                 "Date of Birth: " + dob.ToShortDateString() + "\n" +
                 "Qualification: " + qualificationofMember + "\n" +
                 "Joining Date: " + joiningDate.ToShortDateString() + "\n" +
                 "Gender ID: " + genderID + "\n" +
                 "Type of Member: " + typeOfMember + "\n" +
                 "Status ID: " + statusID + "\n" +
                 "Salary: " + salary;

            MessageBox.Show(message, "Staff Member Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

            StaffMember satffMember = new StaffMember(firstName, lastName, password,email, address, contactNumber, genderID, dob, qualificationofMember, joiningDate, typeOfMember, statusID, salary);
            return satffMember;
        }
        private void gen_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void staff_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == staff_dgv.Columns["EditButton"].Index && e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = staff_dgv.Rows[e.RowIndex];

                // Call a method to handle editing based on the selected row data
                HandleEdit(selectedRow);
            }
            if (staff_dgv.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = staff_dgv.SelectedRows[0];

                // Call the function to populate text boxes with selected row data
                PopulateTextBoxesWithSelectedRow(selectedRow);
            }
            else
            {
                // If no row is selected, clear the text boxes
                ClearFields();
            }
        }
        private void PopulateTextBoxesWithSelectedRow(DataGridViewRow selectedRow)
        {
            if (selectedRow != null)
            {
                // Assuming the order of columns in the grid matches the order of text boxes
                Fname_txt.Text = selectedRow.Cells["FirstName"].Value.ToString();
                Lname_tx.Text = selectedRow.Cells["LastName"].Value.ToString();
                email_txt.Text = selectedRow.Cells["Email"].Value.ToString();
                address_txt.Text = selectedRow.Cells["Address"].Value.ToString();
                contact_txt.Text = selectedRow.Cells["ContactNumber"].Value.ToString();
                salary_txt.Text = selectedRow.Cells["StatusOfMember"].Value.ToString();
                qualification.Text = selectedRow.Cells["Qualification"].Value.ToString();
                password_txt.Text= selectedRow.Cells["Password"].Value.ToString();
                // Set selected gender in combo box
                // Retrieve the value from the "GenderID" cell of the selected row
                object genderValue = selectedRow.Cells["GenderID"].Value;

                // Define a dictionary to map numeric gender IDs to string representations
                Dictionary<int, string> genderMap = new Dictionary<int, string>
                {
                    { 1, "Male" },
                    { 2, "Female" }
                    // Add more mappings as needed
                };

                // Check if the gender value is not null and not empty
                if (genderValue != null && !string.IsNullOrEmpty(genderValue.ToString()))
                {
                    // Convert the gender value to an integer
                    if (int.TryParse(genderValue.ToString(), out int genderID))
                    {
                        // Check if the genderID exists in the dictionary
                        if (genderMap.ContainsKey(genderID))
                        {
                            // Get the corresponding string representation from the dictionary
                            string gender = genderMap[genderID];

                            // Set the selected index of the combo box based on the gender string
                            gen_cbx.SelectedIndex = gen_cbx.Items.IndexOf(gender);
                        }
                        else
                        {
                            // If the genderID doesn't match any mapping, clear the selection
                            gen_cbx.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        // If conversion to int fails, clear the selection
                        gen_cbx.SelectedIndex = -1;
                    }
                }
                else
                {
                    // If the gender value is null or empty, clear the selection
                    gen_cbx.SelectedIndex = -1;
                }


                // Retrieve the value from the "TypeOfMember" cell of the selected row
                object typeOfMemberValue = selectedRow.Cells["TypeOfMember"].Value;

                // Define a dictionary to map numeric type of member IDs to string representations
                Dictionary<int, string> typeOfMemberMap = new Dictionary<int, string>
                {
                    { 6, "Cashier" },
                    { 7, "Salesperson" }
                    // Add more mappings as needed
                };

                // Check if the type of member value is not null and not empty
                if (typeOfMemberValue != null && !string.IsNullOrEmpty(typeOfMemberValue.ToString()))
                {
                    // Convert the type of member value to an integer
                    if (int.TryParse(typeOfMemberValue.ToString(), out int typeOfMemberID))
                    {
                        // Check if the typeOfMemberID exists in the dictionary
                        if (typeOfMemberMap.ContainsKey(typeOfMemberID))
                        {
                            // Get the corresponding string representation from the dictionary
                            string typeOfMember = typeOfMemberMap[typeOfMemberID];

                            // Set the selected index of the combo box based on the type of member string
                            type_cbx.SelectedIndex = type_cbx.Items.IndexOf(typeOfMember);
                        }
                        else
                        {
                            // If the typeOfMemberID doesn't match any mapping, clear the selection
                            type_cbx.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        // If conversion to int fails, clear the selection
                        type_cbx.SelectedIndex = -1;
                    }
                }
                else
                {
                    // If the type of member value is null or empty, clear the selection
                    type_cbx.SelectedIndex = -1;
                }


                // Set date of birth and joining date
                dob_dtp.Value = Convert.ToDateTime(selectedRow.Cells["DOB"].Value);
                joini_dtp.Value = Convert.ToDateTime(selectedRow.Cells["JoiningDate"].Value);
            }
        }

        private void backarrow_btn_Click(object sender, EventArgs e)
        {
            ManagerDashboard managerDashboard= new ManagerDashboard();
            this.Hide();
            managerDashboard.Show();
        }

       
    }
}
