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
using System.Data.SqlClient;
using ToyHub.BL;
namespace ToyHub.UI
{
    public partial class ShipmentManagement : Form
    {
        public ShipmentManagement()
        {
            InitializeComponent();
            PopulateGenderComboBox(gender_cbx);
            LoadSenderData();
            AddEditButtonColumn();
            AddDeleteButtonColumn();

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
            dataGrid.CellContentClick += Staff_dgv_CellContentClick;

            // Add the button column to the DataGridView
            dataGrid.Columns.Add(deleteButtonColumn);
        }
        private void Staff_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGrid.Columns["DeleteButton"].Index && e.RowIndex >= 0 && !dataGrid.Rows[e.RowIndex].IsNewRow)
            {
                // Perform deletion logic here
                DataGridViewRow selectedRow = dataGrid.Rows[e.RowIndex];
                DeleteSender(selectedRow);
                int rowIndex = e.RowIndex;
                dataGrid.Rows.RemoveAt(rowIndex);
            }
        }

        public static Sender GetDataOfSelectedRow(DataGridViewRow selectedRow)
        {
            string senderId = selectedRow.Cells["SenderID"].Value.ToString();
            string firstName = selectedRow.Cells["FirstName"].Value.ToString();
            string lastName = selectedRow.Cells["LastName"].Value.ToString();
            string email = selectedRow.Cells["Email"].Value.ToString();
            string address = selectedRow.Cells["Address"].Value.ToString();
            string contact = selectedRow.Cells["ContactNumber"].Value.ToString();
            string gender = selectedRow.Cells["GenderID"].Value.ToString();
            DateTime dob = Convert.ToDateTime(selectedRow.Cells["DOB"].Value);
            DateTime joiningDate = Convert.ToDateTime(selectedRow.Cells["JoiningDate"].Value);

            int genderID = int.Parse(gender);
            int memberID = int.Parse(senderId);
            string companyName = selectedRow.Cells["CompanyName"].Value.ToString();

            string companyAddress = selectedRow.Cells["CompanyAddress"].Value.ToString();
            string companyContact = selectedRow.Cells["CompanyContact"].Value.ToString();
            /* int status = int.Parse(selectedRow.Cells["Status"].Value.ToString());*/
            int status = 4;
            string password = selectedRow.Cells["Password"].Value.ToString(); ;
            Sender sender = new Sender(memberID, firstName, lastName, password, email, address, contact, genderID, dob, joiningDate, companyName, companyAddress, companyContact, status);
            return sender;
        }
        public static void DeleteSender(DataGridViewRow selectedRow)
        {
            SenderDL.UpdateSenderWithPerson(GetDataOfSelectedRow(selectedRow));
        }
        private void AddEditButtonColumn()
        {
            // Create a button column
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "UpdateButton";
            editButtonColumn.HeaderText = "Update";
            editButtonColumn.Text = "Update";
            editButtonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            dataGrid.Columns.Add(editButtonColumn);
        }
        public void LoadSenderData()
        {
            try
            {
                SqlConnection con = Configuration.getInstance().getConnection();
                using (con)
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    // Adjust the query to join Person and StaffMember tables
                    SqlCommand cmd = new SqlCommand("SELECT Person.*, Sender.* FROM Person INNER JOIN Sender ON Person.PersonID = Sender.SenderID", con);
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

        private void PopulateGenderComboBox(System.Windows.Forms.ComboBox gen_cbx)
        {
            gen_cbx.Items.Clear();
            gen_cbx.Items.Add("Male");
            gen_cbx.Items.Add("Female");
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string firstName = fname_txt.Text;
            string lastName = Lname_txt.Text;
            string email = email_txt.Text;
            string address = address_txt.Text;
            string contactNumber = contact_txt.Text;
            string gender = gender_cbx.Text;
            string companyName = Cpname_txt.Text;
            string companyAddress = cpadd_txt.Text;
            string companyContact = cpcontact_txt.Text;
            DateTime dob = dob_dtp.Value.Date;
            DateTime joinDate = joiningDate.Value.Date;

            int genderID = 0;
            /* MessageBox.Show(gender);*/
            if (gender == "Male" || gender == "Female")
            {
                /* genderID = Person.GetGenderId(gender);*/
                if (gender == "Male")
                {
                    genderID = 1;
                }
                else if (gender == "Female")
                {
                    genderID = 2;
                }
                /* MessageBox.Show(genderID.ToString());*/
            }
            int status = StaffMember.GetStaffStatusID("Active");
            string password = password_txt.Text;
            SenderDL.AddSender(firstName, lastName, email, address, contactNumber,
                           genderID, dob, joinDate, companyName, companyAddress, companyContact, status, password);
            LoadSenderData();





        }

        private void Search_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void HandleEdit(DataGridViewRow selectedRow)
        {
            int senderID = int.Parse(selectedRow.Cells["SenderID"].Value.ToString());
            string firstName = selectedRow.Cells["FirstName"].Value.ToString();
            string lastName = selectedRow.Cells["LastName"].Value.ToString();
            string email = selectedRow.Cells["Email"].Value.ToString();
            string address = selectedRow.Cells["Address"].Value.ToString();
            string contactNumber = selectedRow.Cells["ContactNumber"].Value.ToString();

            string gender = selectedRow.Cells["GenderID"].Value.ToString();

            DateTime dob = Convert.ToDateTime(selectedRow.Cells["DOB"].Value);
            DateTime joiningDate = Convert.ToDateTime(selectedRow.Cells["JoiningDate"].Value);

            int genderID = int.Parse(gender);
            string companyName = selectedRow.Cells["CompanyName"].Value.ToString();
            string companyAddress = selectedRow.Cells["CompanyAddress"].Value.ToString();
            string companyContact = selectedRow.Cells["CompanyContact"].Value.ToString();
            int status = StaffMember.GetStaffStatusID("Active");
            string password = selectedRow.Cells["Password"].Value.ToString();
            MessageBox.Show($"Sender ID: {senderID}\n" +
                $"First Name: {firstName}\n" +
                $"Last Name: {lastName}\n" +
                $"Email: {email}\n" +
                $"Address: {address}\n" +
                $"Contact Number: {contactNumber}\n" +
                $"Gender ID: {genderID}\n" +
                $"Date of Birth: {dob.ToString("yyyy-MM-dd")}\n" +
                $"Joining Date: {joiningDate.ToString("yyyy-MM-dd")}\n" +
                $"Company Name: {companyName}\n" +
                $"Company Address: {companyAddress}\n" +
                 $"Password: {password}\n"+
                $"Company Contact: {companyContact}\n",
                "Sender Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Sender sender = new Sender(senderID, firstName, lastName, password, email, address, contactNumber, genderID, dob, joiningDate, companyName, companyAddress, companyContact, status);

            UpdateSender updateSender = new UpdateSender(sender);
            this.Hide();
            updateSender.Show();





        }
       
        private void ShipmentManagement_Load(object sender, EventArgs e)
        {

        }

        private void backarrow_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerDashboard managerDashboard = new ManagerDashboard();
            managerDashboard.Show();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGrid.Columns["UpdateButton"].Index && e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGrid.Rows[e.RowIndex];

                // Call a method to handle editing based on the selected row data
                HandleEdit(selectedRow);
            }
            if (dataGrid.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGrid.SelectedRows[0];

                // Call the function to populate text boxes with selected row data
                /*  PopulateTextBoxesWithSelectedRow(selectedRow);*/
            }
            else
            {
                // If no row is selected, clear the text boxes
                /* ClearFields();*/
            }
        }

    }
}
