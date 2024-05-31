using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ToyHub.UI
{
    public partial class StockManagement : Form
    {
        private string connectionString = @"Data Source=(local);Initial Catalog=ToyHub;Integrated Security=True";

        public StockManagement()
        {
            InitializeComponent();
            LoadProductData();
            //   LoadActiveSalespersons();
            //   PopulateSenderComboBox();
            //  LoadSenderReceiverProductData();
            LoadAggregatedProductQuantities();
            LoadData();
            PopulateDataGridView();

        }




        private void LoadProductData()
        {
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Close();
                    con.Open();

                    string query = "SELECT Name FROM Product WHERE IsDeleted = 0";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    Product_cbx.Items.Clear();

                    while (reader.Read())
                    {
                        string productName = reader["Name"].ToString();
                        Product_cbx.Items.Add(productName);
                    }

                    reader.Close();
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Check if the clicked cell is in the "Update" column
                    if (dataGridView1.Columns[e.ColumnIndex].Name == "Update")
                    {
                        // Call a method to handle editing based on the selected row data
                        DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                        // Call a method to handle editing based on the selected row data
                        HandleEdit(selectedRow);
                    }
                    // Check if the clicked cell is in the "Delete" column

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void HandleEdit(DataGridViewRow selectedRow)
        {
            if (selectedRow != null)
            {
                try
                {
                    string stockId = selectedRow.Cells["StockID"].Value.ToString();
                    string productName = selectedRow.Cells["ProductName"].Value.ToString();
                    int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                    DateTime stockDate = Convert.ToDateTime(selectedRow.Cells["StockDate"].Value);

                    // Pass the data to the UpdateStock form
                    UpdateStocks updateForm = new UpdateStocks(int.Parse(stockId), productName, quantity, stockDate);
                    this.Hide();
                    updateForm.ShowDialog();

                    // After updating the data in the UpdateStock form, reload the DataGridView
                    LoadData();
                    LoadAggregatedProductQuantities();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
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
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Create a SqlCommand to retrieve data from the StockView view
                    string query = "SELECT StockID, ProductName, Quantity, StockDate FROM StockView";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Create a DataTable to hold the results
                    DataTable dataTable = new DataTable();

                    // Load data from the SqlDataReader into the DataTable
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }






        private void Product_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected in the ComboBox
            if (Product_cbx.SelectedItem != null)
            {
                string selectedProductName = Product_cbx.SelectedItem.ToString();
                // Now you can use the selectedProductName variable as needed
            }
            else
            {
                MessageBox.Show("Please select a product.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


    
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void quantity_txt_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnAddStock_Click(object sender, EventArgs e)
        {

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedProduct = Product_cbx.SelectedItem?.ToString();
                int quantity;

                // Check if quantity is a valid integer and not negative
                if (!int.TryParse(quantity_txt.Text, out quantity) || quantity < 0)
                {
                    MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get ProductID from Product table
                int productId;
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT ProductID FROM Product WHERE Name = @ProductName", con))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", selectedProduct);
                        productId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                // Insert into the Stock table if quantity is positive
                if (quantity > 0)
                {
                    using (var con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO Stock (ProductID, Quantity, StockDate) VALUES (@ProductID, @Quantity, @StockDate)", con))
                        {
                            cmd.Parameters.AddWithValue("@ProductID", productId);
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.Parameters.AddWithValue("@StockDate", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Stock added successfully.");
                    LoadData();
                    LoadAggregatedProductQuantities();
                }
                else
                {
                    MessageBox.Show("Please enter a positive quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void product_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void LoadAggregatedProductQuantities()
        {
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT Name AS ProductName, 
                            CASE 
                                WHEN SUM(Quantity) < 0 THEN 0 
                                ELSE SUM(Quantity) 
                            END AS TotalQuantity
                    FROM Stock
                    JOIN Product ON Stock.ProductID = Product.ProductID
                    GROUP BY Name
                    HAVING SUM(Quantity) > 0"; // Filter out products with zero quantity

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Create a BindingSource
                    BindingSource bindingSource = new BindingSource();
                    // Set the DataSource of the BindingSource
                    bindingSource.DataSource = dataTable;
                    // Assign the BindingSource to the DataGridView
                    product_dgv.DataSource = bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading aggregated product quantities: " + ex.Message);
            }
        }








        private void button1_Click(object sender, EventArgs e)
        {
            ManagerDashboard managerform = new ManagerDashboard();

            // Show the StockManagement form
            managerform.Show();

            // Close the current UpdateStocks form
            this.Close();
        }

        private void Stock_lbl_Click(object sender, EventArgs e)
        {

        }

        private void StockManagement_Load(object sender, EventArgs e)
        {

        }

    }

}