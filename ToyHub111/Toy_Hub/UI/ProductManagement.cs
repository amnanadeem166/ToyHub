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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ToyHub.UI
{
    public partial class ProductManagement : Form
    {
        private string connectionString = @"Data Source=(local);Initial Catalog=ToyHub;Integrated Security=True";


        public ProductManagement()
        {
            InitializeComponent();
            LoadProductData(); // Load existing product data into the DataGridView
            PopulateDataGridView();
            LoadProductNames();

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;


        }

        private void addprod_btn_Click(object sender, EventArgs e)
        {
            string productName = ProdName_txt.Text;
            string priceStr = Price_txt.Text;
            string description = Description_txt.Text;

            // Validate that all textboxes are filled
            if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(priceStr) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("All fields must be filled to add a new product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate product name (allow only text)
            if (!IsTextOnly(productName))
            {
                MessageBox.Show("Product name can only contain letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal price;

            // Validate the price (integer only)
            if (!decimal.TryParse(priceStr, out price) || price % 1 != 0)
            {
                MessageBox.Show("Price must be a whole number without decimal points.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Call the AddProduct method from ProductDL class
                ProductDL.AddProduct(productName, price, description);

                MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView and combo box
                LoadProductData();
                LoadProductNames();

                // Clear textboxes
                ProdName_txt.Text = "";
                Price_txt.Text = "";
                Description_txt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to check if a string contains only text (letters)
        private bool IsTextOnly(string input)
        {
            return input.All(char.IsLetter);
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index && e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Call a method to handle editing based on the selected row data
                HandleEdit(selectedRow);
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Update the IsDeleted value to 1 in the database
                int productId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value);
                UpdateIsDeletedValue(productId);

                // Remove the row from the DataGridView
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void UpdateIsDeletedValue(int productId)
        {
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    // Prepare the SQL UPDATE command
                    string query = "UPDATE Product SET IsDeleted = 1 WHERE ProductID = @ProductId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ProductId", productId);

                    // Execute the command
                    cmd.ExecuteNonQuery();
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


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Call the function to populate text boxes with selected row data
                PopulateTextBoxesWithSelectedRow(selectedRow);
            }
            else
            {
                // If no row is selected, clear the text boxes
                ClearFields();
            }
        }


        private void PopulateDataGridView()
        {
            try
            {
                // Add Update button column
                DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
                updateButtonColumn.HeaderText = "Update";
                updateButtonColumn.Text = "Update";
                updateButtonColumn.Name = "Update"; // Ensure this name matches
                updateButtonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(updateButtonColumn);

                // Add Delete button column
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.HeaderText = "Delete";
                deleteButtonColumn.Text = "Delete";
                deleteButtonColumn.Name = "Delete"; // Add this line
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(deleteButtonColumn);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void LoadProductData()
        {
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    // Adjust the query to select non-deleted products
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE IsDeleted = 0", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
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


        private void LoadProductNames()
        {
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    // Adjust the query to select only the Product Name column
                    SqlCommand cmd = new SqlCommand("SELECT Name FROM Product", con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Clear existing items in the dropdown
                    Search_cbx.Items.Clear();

                    // Populate the dropdown with product names
                    while (reader.Read())
                    {
                        Search_cbx.Items.Add(reader["Name"].ToString());
                    }

                    // Close the reader
                    reader.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    // Adjust the query to select product names where IsDeleted = 0
                    SqlCommand cmd = new SqlCommand("SELECT Name FROM Product WHERE IsDeleted = 0", con);

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Clear the existing items in the combo box
                    Search_cbx.Items.Clear();

                    while (reader.Read())
                    {
                        string productName = reader["Name"].ToString();
                        // Add only non-deleted product names to the combo box
                        Search_cbx.Items.Add(productName);
                    }

                    reader.Close();
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

        private void HandleEdit(DataGridViewRow selectedRow)
        {
            if (selectedRow != null)
            {
                string productId = selectedRow.Cells["ProductID"].Value.ToString();
                string productName = selectedRow.Cells["Name"].Value.ToString();

                // Parsing Price
                decimal price;
                if (!decimal.TryParse(selectedRow.Cells["Price"].Value.ToString(), out price))
                {
                    MessageBox.Show("Invalid price format. Please enter a valid decimal number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string description = selectedRow.Cells["Description"].Value.ToString();


                MessageBox.Show(
                    $"Product ID: {productId}\n" +
                    $"Product Name: {productName}\n" +
                    $"Price: {price}\n" +
                    $"Description: {description}\n" +
                    "Selected Product Details"
                );

                // Open a new form or dialog for editing with the extracted data
                UpdateProduct editForm = new UpdateProduct(int.Parse(productId), productName, price, description);
                this.Hide();
                editForm.Show(); // Show as a modal dialog
            }
        }



        private void PopulateTextBoxesWithSelectedRow(DataGridViewRow selectedRow)
        {
            if (selectedRow != null)
            {
                // Check if the column exists before accessing its value
                if (selectedRow.Cells["Name"] != null && selectedRow.Cells["Name"].Value != null)
                {
                    ProdName_txt.Text = selectedRow.Cells["Name"].Value.ToString();
                }
                if (selectedRow.Cells["Price"] != null && selectedRow.Cells["Price"].Value != null)
                {
                    Price_txt.Text = selectedRow.Cells["Price"].Value.ToString();
                }
                if (selectedRow.Cells["Description"] != null && selectedRow.Cells["Description"].Value != null)
                {
                    Description_txt.Text = selectedRow.Cells["Description"].Value.ToString();
                }
            }
        }



        private void ClearFields()
        {
            ProdName_txt.Text = "";
            Price_txt.Text = "";
            Description_txt.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerDashboard md = new ManagerDashboard();
            md.Show();
        }

       
    }
}