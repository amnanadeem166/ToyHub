using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ToyHub.BL;
using ToyHub.DL;
using Chunk = iTextSharp.text.Chunk;
using Document = iTextSharp.text.Document;
namespace ToyHub.UI
{
    public partial class GenerateReports : Form
    {
        public GenerateReports()
        {
            InitializeComponent();
        }
        private void GenerateStaffAttendanceReport()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "StaffAttendanceReport.pdf";
            bool errorMessage = false;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (Exception ex)
                    {
                        errorMessage = true;
                        MessageBox.Show("Unable to write data to disk: " + ex.Message);
                    }
                }

                if (!errorMessage)
                {
                    // Create new PDF document
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(sfd.FileName, FileMode.Create));
                    document.Open();

                    // Add title page
                    document = AddTitlePage(ref document, "Staff Attendance Report");

                    // Get staff members with attendance greater than 80%
                    List<StaffMember> staffMembers = GetStaffWithHighAttendance();

                    // Add staff members to the report
                    document = AddStaffMembersToReport(ref document, staffMembers);

                    // Close PDF document and writer
                    document.Close();
                    writer.Close();
                }
            }
        }

        private List<StaffMember> GetStaffWithHighAttendance()
        {
            // Query the database or any other data source to retrieve staff members with attendance greater than 80%
            // This is a placeholder method, you should implement your logic here
            List<StaffMember> staffMembers = new List<StaffMember>();

            // Example query: SELECT * FROM StaffMember WHERE Attendance > 80;
            // Execute the query and populate the staffMembers list accordingly

            return staffMembers;
        }

        private Document AddTitlePage(ref Document document, string title)
        {
            // Add title page with the specified title
            // This is a placeholder method, you can customize it as needed
            document.Add(new Paragraph(title));
            document.Add(Chunk.NEWLINE);

            return document;
        }
        public static void GenerateAttendanceReportOfStaffMember()
        {
            List<int> staffIDs = AttendanceDL.GetStaffIDsWithFullAttendance();

            // Call the GetStaffDetails function to retrieve staff member details
            List<StaffMember> staffMembers = AttendanceDL.GetStaffDetails(staffIDs);

            GenerateStaffReport(staffMembers);


        }
        private static string PromptUserForFilePath(string title, string defaultFileName)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = title;
            saveFileDialog.FileName = defaultFileName;
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }
            else
            {
                return null;
            }
        }

        private static void GenerateProductReport(List<Product> product)
        {
            // Prompt the user to specify the path for saving the PDF file
            string filePath = PromptUserForFilePath("Save Product Report As", "ProductReport.pdf");

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("File path not provided.");
                return;
            }

            try
            {
                // Create a new PDF document
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                // Open the document
                document.Open();

                // Add the title page for the staff report
                ProductReportTitlePage(ref document);

                // Add staff member details to the document
                foreach (Product p in product)
                {
                    document.Add(new Paragraph("Product ID: " + p.ProductID));
                    document.Add(new Paragraph("Product Name: " + p.Name));
                    document.Add(new Paragraph("Product Description: " + p.Description));
                    document.Add(new Paragraph("Product Price: " + p.Price));

                    // Add a separator between each staff member
                    document.Add(new Paragraph(new Chunk(new LineSeparator())));
                    document.Add(new Paragraph(new Chunk("\n")));
                }

                // Close the document
                document.Close();
                writer.Close();

                MessageBox.Show("Report generated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message);
            }
        }

        private static void GenerateStaffReport(List<StaffMember> staffMembers)
        {
            // Prompt the user to specify the path for saving the PDF file
            string filePath = PromptUserForFilePath("Save Staff Report As", "StaffReport.pdf");
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("File path not provided.");
                return;
            }

            try
            {
                // Create a new PDF document
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                // Open the document
                document.Open();

                // Add the title page for the staff report
                StaffReportTitlePage(ref document);

                // Add staff member details to the document
                foreach (StaffMember staffMember in staffMembers)
                {
                    // Append the details of the current staff member to the StringBuilder
                    document.Add(new Paragraph("First Name: " + staffMember.FirstName));
                    document.Add(new Paragraph("Last Name: " + staffMember.LastName));
                    document.Add(new Paragraph("Email: " + staffMember.Email));
                    document.Add(new Paragraph("Address: " + staffMember.Address));
                    document.Add(new Paragraph("Contact Number: " + staffMember.ContactNumber));
                    document.Add(new Paragraph("Gender ID: " + staffMember.GenderID));
                    document.Add(new Paragraph("Date of Birth: " + staffMember.DOB.ToString()));
                    document.Add(new Paragraph("Qualification: " + staffMember.Qualification));
                    document.Add(new Paragraph("Joining Date: " + staffMember.JoiningDate.ToString()));
                    document.Add(new Paragraph("Type of Member: " + staffMember.TypeOfMember));
                    document.Add(new Paragraph("Status of Member: " + staffMember.StatusOfMember));
                    document.Add(new Paragraph("Password of Member: " + staffMember.Password));
                    // Add a separator between each staff member
                    document.Add(new Paragraph(new Chunk(new LineSeparator())));
                    document.Add(new Paragraph(new Chunk("\n")));
                }

                // Close the document
                document.Close();
                writer.Close();

                MessageBox.Show("Staff report generated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating staff report: " + ex.Message);
            }
        }
        private static Document ProductReportTitlePage(ref Document document)
        {
            // Set page size, margins, author, date, title, header
            document.SetPageSize(PageSize.A4);
            document.SetMargins(30, 30, 30, 30);
            document.AddAuthor("Gul-e-Zahra");
            document.AddCreationDate();
            document.AddTitle("Product Report");
            document.AddHeader("Title", "Product Report");

            // Adding title page
            document.NewPage();
            Paragraph title = new Paragraph("Product Report");
            title.SpacingBefore = 50f;
            title.SpacingAfter = 50f;
            title.Font.Size = 28;
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            // Add any additional elements you want on the title page
            // For example:
            Paragraph subTitle = new Paragraph("Product Details");
            subTitle.SpacingBefore = 20f;
            subTitle.SpacingAfter = 20f;
            subTitle.Font.Size = 18;
            subTitle.Alignment = Element.ALIGN_CENTER;
            document.Add(subTitle);

            // Add a separator line
            LineSeparator line = new LineSeparator();
            document.Add(line);

            return document;
        }

        private static Document StaffReportTitlePage(ref Document document)
        {
            // Set page size, margins, author, date, title, header
            document.SetPageSize(PageSize.A4);
            document.SetMargins(30, 30, 30, 30);
            document.AddAuthor("Your Name");
            document.AddCreationDate();
            document.AddTitle("Staff Report");
            document.AddHeader("Title", "Staff Report");

            // Adding title page
            document.NewPage();
            Paragraph title = new Paragraph("Staff Report");
            title.SpacingBefore = 50f;
            title.SpacingAfter = 50f;
            title.Font.Size = 28;
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            // Add any additional elements you want on the title page
            // For example:
            Paragraph subTitle = new Paragraph("Attendance Greater Than 80%");
            subTitle.SpacingBefore = 20f;
            subTitle.SpacingAfter = 20f;
            subTitle.Font.Size = 18;
            subTitle.Alignment = Element.ALIGN_CENTER;
            document.Add(subTitle);

            // Add a separator line
            LineSeparator line = new LineSeparator();
            document.Add(line);

            return document;
        }

        public static void WriteStaffDetailsToPDF(List<StaffMember> staffMembers)
        {
            try
            {
                // Prompt the user to select a folder using FolderBrowserDialog
                FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
                folderBrowser.Description = "Select folder to save PDF file";

                // Show the FolderBrowserDialog
                DialogResult result = folderBrowser.ShowDialog();

                // Check if the user selected a folder
                if (result == DialogResult.OK)
                {
                    // Get the selected folder path
                    string folderPath = folderBrowser.SelectedPath;

                    // Combine the folder path and default file name to get the full file path
                    string fileName = "StaffDetails.pdf";
                    string filePath = Path.Combine(folderPath, fileName);

                    // Create a new PDF document
                    using (Document document = new Document())
                    {
                        // Create a PdfWriter instance to write the document to a file
                        PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                        // Open the document
                        document.Open();

                        // Create a PdfPTable with 2 columns
                        PdfPTable table = new PdfPTable(2);

                        // Add headers
                        table.AddCell("Field");
                        table.AddCell("Value");

                        // Loop through each staff member
                        foreach (StaffMember staffMember in staffMembers)
                        {
                            // Add details of the current staff member to the table
                            table.AddCell("First Name:");
                            table.AddCell(staffMember.FirstName);

                            table.AddCell("Last Name:");
                            table.AddCell(staffMember.LastName);

                            table.AddCell("Email:");
                            table.AddCell(staffMember.Email);

                            table.AddCell("Address:");
                            table.AddCell(staffMember.Address);

                            table.AddCell("Contact Number:");
                            table.AddCell(staffMember.ContactNumber);

                            table.AddCell("Gender ID:");
                            table.AddCell(staffMember.GenderID.ToString());

                            table.AddCell("Date of Birth:");
                            table.AddCell(staffMember.DOB.ToString());

                            table.AddCell("Qualification:");
                            table.AddCell(staffMember.Qualification);

                            table.AddCell("Joining Date:");
                            table.AddCell(staffMember.JoiningDate.ToString());

                            table.AddCell("Type of Member:");
                            table.AddCell(staffMember.TypeOfMember.ToString());

                            table.AddCell("Status of Member:");
                            table.AddCell(staffMember.StatusOfMember.ToString());

                            table.AddCell("Password of Member:");
                            table.AddCell(staffMember.Password.ToString());

                            // Add an empty row as a separator
                            table.AddCell("");
                            table.AddCell("");
                        }

                        // Add the table to the document
                        document.Add(table);
                    }

                    // Display success message
                    MessageBox.Show("PDF file saved successfully to: " + filePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Document AddStaffMembersToReport(ref Document document, List<StaffMember> staffMembers)
        {
            // Add staff members to the report
            // This is a placeholder method, you can customize it to format the data as needed
            foreach (StaffMember staffMember in staffMembers)
            {
                /*  // Add staff member details to the document
                  document.Add(new Paragraph("Name: " + staffMember.Name));
                  document.Add(new Paragraph("Attendance: " + staffMember.Attendance));*/

                document.Add(Chunk.NEWLINE);
            }

            return document;
        }
        public static void GenerateReportOfAllProduct()
        {

            // Call the GetStaffDetails function to retrieve staff member details
            List<Product> product = ProductDL.GetAllProducts();

            GenerateProductReport(product);


        }
        public static void GenerateReportOfAllSenders()
        {

            List<Sender> senders = SenderDL.GetAllSenders();
            GenerateSenderReport(senders);


        }
        private static void GenerateSenderReport(List<Sender> sender)
        {
            // Prompt the user to specify the path for saving the PDF file
            string filePath = PromptUserForFilePath("Save Sender Report As", "SenderReport.pdf");

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("File path not provided.");
                return;
            }

            try
            {
                // Create a new PDF document
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                // Open the document
                document.Open();

                // Add the title page for the staff report
                ProductReportTitlePage(ref document);

                // Add staff member details to the document
                foreach (Sender s in sender)
                {
                    document.Add(new Paragraph("Sender ID: " + s.SenderID));
                    document.Add(new Paragraph("First Name: " + s.FirstName));
                    document.Add(new Paragraph("Last Name: " + s.LastName));
                    document.Add(new Paragraph("Email: " + s.Email));
                    document.Add(new Paragraph("Address: " + s.Address));
                    document.Add(new Paragraph("Contact Number: " + s.ContactNumber));
                    document.Add(new Paragraph("Gender ID: " + s.GenderID));
                    document.Add(new Paragraph("Date of Birth: " + s.DOB));
                    document.Add(new Paragraph("Joining Date: " + s.JoiningDate));
                    document.Add(new Paragraph("Company Name: " + s.CompanyName));
                    document.Add(new Paragraph("Company Address: " + s.CompanyAddress));
                    document.Add(new Paragraph("Company Contact: " + s.CompanyContact));
                    document.Add(new Paragraph("Status: " + s.statusID));

                    // Add a separator between each sender
                    document.Add(new Paragraph(new Chunk(new LineSeparator())));
                    document.Add(new Paragraph(new Chunk("\n")));
                }


                // Close the document
                document.Close();
                writer.Close();

                MessageBox.Show("Report generated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateAttendanceReportOfStaffMember();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateReportOfAllProduct();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerDashboard managerDashboard = new ManagerDashboard();
            managerDashboard.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GenerateReportOfAllSenders();
        }

    }
}
