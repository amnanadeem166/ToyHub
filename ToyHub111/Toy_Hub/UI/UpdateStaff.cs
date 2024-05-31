using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using ToyHub.BL;
using ToyHub.DL;
namespace ToyHub.UI
{
    public partial class UpdateStaff : Form
    {



        StaffMember staffMember;
        public UpdateStaff()
        {
            InitializeComponent();

        }
        public UpdateStaff(StaffMember staffMember)
        {
            InitializeComponent();
            PopulateGenderComboBox(genderCmb);
            PopulateStaffTypeComboBox(typeCmb);
            PopulateStaffStatuseComboBox(statusCmb);

            this.staffMember = staffMember;

            UpdateUIWithStaffMemberData();
        }


        private void UpdateUIWithStaffMemberData()
        {
            // Update UI controls with the property values
            idTxt.Text = (staffMember.StaffID).ToString();
            txtFirstName.Text = staffMember.FirstName;
            txtLastName.Text = staffMember.LastName;
            txtEmail.Text = staffMember.Email;
            txtAddress.Text = staffMember.Address;
            txtContactNumber.Text = staffMember.ContactNumber;
            int statusID = staffMember.StatusOfMember;
            Password_txt.Text=staffMember.Password;
            if (statusID == 3)
            {
                statusCmb.Text = "Active";
            }
            else if (statusID == 4)
            {
                statusCmb.Text = "Expelled";
            }
            else if (statusID == 5)
            {
                statusCmb.Text = "On Leave";
            }
            int genderID = staffMember.GenderID;
            if (genderID == 1)
            {
                genderCmb.Text = "Male";
            }
            else if (genderID == 2)
            {
                genderCmb.Text = "Female";
            }
            int typeId = staffMember.TypeOfMember;
            if (typeId == 6)
            {
                typeCmb.Text = "Cashier";
            }
            else if (typeId == 7)
            {
                typeCmb.Text = "Salesperson";
            }

            dobDateTimePicker.Value = staffMember.DOB;
            joiningDateTimePicker.Value = staffMember.JoiningDate;
            txtQualification.Text = staffMember.Qualification;
        }
        public void PopulateGenderComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("Male");
            comboBox.Items.Add("Female");
        }
        public void PopulateStaffTypeComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("Cashier");
            comboBox.Items.Add("Salesperson");
        }
        public void PopulateStaffStatuseComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("Active");
            comboBox.Items.Add("Expelled");
            comboBox.Items.Add("On Leave");
        }
        private static void populateGenderComboBox(int genderID)
        {

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public StaffMember GetUpdatedDataFromUI()
        {
            int staffID = int.Parse(idTxt.Text);
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string contactNumber = txtContactNumber.Text;

            DateTime dob = dobDateTimePicker.Value;
            DateTime joiningDate = joiningDateTimePicker.Value;
            string qualification = txtQualification.Text;

            int genderID = Person.GetGenderId(genderCmb.Text);

            int typeOfMember = StaffMember.GetStaffTypeID(typeCmb.Text);

            int statusID = StaffMember.GetStaffStatusID(statusCmb.Text);
            string password = Password_txt.Text;
            StaffMember satffMember = new StaffMember(staffID, firstName, lastName,password, email, address, contactNumber, genderID, dob, qualification, joiningDate, typeOfMember, statusID);
            return satffMember;
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {

            StaffMember updatedMember = GetUpdatedDataFromUI();

            StaffMemberDL.UpdateStaffMember(updatedMember);
            this.Hide();
            StaffManagement staffManagement = new StaffManagement();
            staffManagement.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           StaffManagement staffManagement=new StaffManagement();
            staffManagement.Show();
            this.Close();
        }


    }
}
