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
using ToyHub.DL;
using ToyHub.BL;
using System.Data.SqlClient;

namespace ToyHub.UI
{
    public partial class UpdateStocks : Form
    {
        public int StockID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }

        // public string SenderName { get; set; }
        public DateTime StockDate { get; set; }

        private string connectionString = @"Data Source=(local);Initial Catalog=ToyHub;Integrated Security=True";


        private int productId; // Add a field to store the product ID


        public UpdateStocks(int stockId, string productName, int quantity, DateTime stockDate)
        {
            InitializeComponent();

            // Assign the values to the properties of the class
            StockID = stockId;
            ProductName = productName;
            Quantity = quantity;
            StockDate = stockDate;

            // Update UI with stock data
            LoadProductData();
            UpdateUIWithStockData();
            //  PreProduct_txt.TextChanged += PreProduct_txt_TextChanged;

        }

        private void UpdateUIWithStockData()
        {
            // Update UI controls with the stock data
            Stockid_txt.Text = StockID.ToString();
            Stockid_txt.BackColor = Color.LightGray; // Change the background color to indicate it's read-only
            ProName_cbx.SelectedItem = ProductName;
            Quantity_txt.Text = Quantity.ToString();
            stock_dtp.Value = StockDate;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UpdatStock_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(Stockid_txt.Text) ||
                    string.IsNullOrWhiteSpace(ProName_cbx.Text) ||
                    string.IsNullOrWhiteSpace(Quantity_txt.Text))
                {
                    MessageBox.Show("Please provide valid values for all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Parse the stock ID
                if (!int.TryParse(Stockid_txt.Text, out int stockID))
                {
                    MessageBox.Show("Invalid stock ID. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the user tries to update the stock ID
                if (stockID != StockID)
                {
                    MessageBox.Show("Stock ID cannot be updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Parse the quantity
                if (!int.TryParse(Quantity_txt.Text, out int quantity) || quantity < 0)
                {
                    MessageBox.Show("Invalid quantity format. Please enter a valid positive integer number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the selected product name from the combo box
                string productName = ProName_cbx.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(productName))
                {
                    MessageBox.Show("Please select a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Call a method to retrieve the product ID based on the selected product name
                productId = GetProductIdByName(productName);

                DateTime stockDate = stock_dtp.Value;

                // Call the UpdateStock method with the retrieved product ID
                string result = StockDL.UpdateStock(stockID, productId, quantity, stockDate);

                if (result == "Stock updated successfully.")
                {
                    MessageBox.Show(result, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Hide the current form
                    this.Hide();

                    // Show the StockManagement form
                    StockManagement stockManagementForm = new StockManagement();
                    stockManagementForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private int GetProductIdByName(string productName)
        {
            // Implement the method to retrieve the product ID by its name from the database
            // You can use a SQL query or any other method to achieve this
            // For demonstration purposes, let's assume you have a method in your data access layer to retrieve the product ID
            return ProductDL.GetProductIdByName(productName);
        }



        private void ProName_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Check if an item is selected in the ComboBox
            if (ProName_cbx.SelectedItem != null)
            {
                string selectedProductName = ProName_cbx.SelectedItem.ToString();
                // Now you can use the selectedProductName variable as needed
            }
            else
            {
                MessageBox.Show("Please select a product.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                    string query = "SELECT Name FROM Product WHERE IsDeleted = 0";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    ProName_cbx.Items.Clear();

                    while (reader.Read())
                    {
                        string productName = reader["Name"].ToString();
                        ProName_cbx.Items.Add(productName);
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




        private void Quantity_txt_TextChanged(object sender, EventArgs e)
        {

        }

       
        
        

        private void stock_dtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockManagement stockManagementForm = new StockManagement();
            stockManagementForm.Show();
         

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
    

