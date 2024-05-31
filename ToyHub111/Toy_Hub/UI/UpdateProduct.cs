using System;
using System.Windows.Forms;
using ToyHub.DL;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;

namespace ToyHub.UI
{
    public partial class UpdateProduct : Form
    {

        private string connectionString = @"Data Source=(local);Initial Catalog=ToyHub;Integrated Security=True";

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }


        public UpdateProduct()
        {
            InitializeComponent();

        }

        public UpdateProduct(int productId, string productName, decimal price, string description)
        {
            InitializeComponent();

            ProductID = productId;
            ProductName = productName;
            Price = price;
            Description = description;

            // Update UI with product data
            UpdateUIWithProductData();
        }

        private void UpdateUIWithProductData()
        {
            // Update UI controls with the product data
            Id_txt.Text = ProductID.ToString();
            textBox9.Text = ProductName;
            textBox2.Text = Price.ToString();
            description_txt.Text = Description;
        }

        private void Id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void description_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Stockquant_txt_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(Id_txt.Text) ||
                string.IsNullOrWhiteSpace(textBox9.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(description_txt.Text))
            {
                MessageBox.Show("Please provide valid values for all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse the product ID
            if (!int.TryParse(Id_txt.Text, out int productId))
            {
                MessageBox.Show("Invalid product ID. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse the price
            if (!decimal.TryParse(textBox2.Text, out decimal price))
            {
                MessageBox.Show("Invalid price format. Please enter a valid decimal number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get product name and description
            string productName = textBox9.Text;
            string description = description_txt.Text;

            // Call the method from the Data Access Layer
            string connectionString = @"Data Source=(local);Initial Catalog=ToyHub;Integrated Security=True";
            string result = ProductDL.UpdateProduct(connectionString, productId, productName, price, description);

            // Display appropriate message based on the result
            if (result == "Product updated successfully.")
            {
                MessageBox.Show(result, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                ProductManagement productManagement = new ProductManagement();
                productManagement.Show();
            }
            else
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductManagement PM = new ProductManagement();
            PM.Show();
        }

        
    }


}

