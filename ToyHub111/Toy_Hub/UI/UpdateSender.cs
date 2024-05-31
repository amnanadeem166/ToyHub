using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToyHub.BL;
using ToyHub.DL;
using System.Reflection;

namespace ToyHub.UI
{
    public partial class UpdateSender : Form
    {
        private Sender sender;
        public UpdateSender()
        {
            InitializeComponent();
        }

        public UpdateSender(Sender sender)
        {
            InitializeComponent();
            PopulateGenderComboBox(gender_cbx);
            this.sender = sender;
            PopulateSenderDetails(sender);
        }
        public void PopulateGenderComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("Male");
            comboBox.Items.Add("Female");
        }
        public Sender GetUpdatedDataFromUI()
        {
            int senderID = this.sender.SenderID;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string email = emailTextBox.Text;
            string address = addressTextBox.Text;
            string contact = contactNumberTextBox.Text;

            string gender = gender_cbx.Text;

            int genderID = -1;
            if (gender == "Male" || gender == "Female")
            {

                /*genderID = Person.GetGenderId(gender);*/
                if (gender == "Male")
                {
                    genderID = 1;
                }
                else if (gender == "Female")
                {
                    genderID = 2;
                }
            }
            DateTime dob = dobDateTimePicker.Value;
            DateTime joiningDate = joiningDateDateTimePicker.Value;
            string companyName = companyNameTextBox.Text;
            string companyAddress = companyAddressTextBox.Text;
            string companyContact = companyContactTextBox.Text;
            int status = StaffMember.GetStaffStatusID("Active");
            string password = Password_txt.Text;
            //text box here
            Sender sender = new Sender(senderID, firstName, lastName, password, email, address, contact, genderID, dob, joiningDate, companyName, companyAddress, companyContact, status);
            return sender;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Sender updatedSender = GetUpdatedDataFromUI();
            SenderDL.UpdateSenderWithPerson(updatedSender);

        }
        private void PopulateSenderDetails(Sender sender)
        {
            // Populate UI controls with Sender data
            Id_txt.Text = (sender.SenderID).ToString();
            firstNameTextBox.Text = sender.FirstName;
            lastNameTextBox.Text = sender.LastName;
            emailTextBox.Text = sender.Email;
            addressTextBox.Text = sender.Address;
            contactNumberTextBox.Text = sender.ContactNumber;
            int genderId = sender.GenderID;
            if (genderId == 1)
            {
                gender_cbx.Text = "Male";
            }
            else if (genderId == 2)
            {
                gender_cbx.Text = "Female";
            }
            dobDateTimePicker.Value = sender.DOB;
            joiningDateDateTimePicker.Value = sender.JoiningDate;
            companyNameTextBox.Text = sender.CompanyName;
            companyAddressTextBox.Text = sender.CompanyAddress;
            companyContactTextBox.Text = sender.CompanyContact;
            /*  statusCmb.Text=(sender.statusID).ToString();*/
            Password_txt.Text=sender.Password;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShipmentManagement shipmentManagement = new ShipmentManagement();
            this.Hide();
            shipmentManagement.Show();
        }

        
    }
}
