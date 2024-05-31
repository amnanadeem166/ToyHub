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
namespace ToyHub.UI
{
    public partial class PunchOrder : Form
    {
        public int staffID;
        public PunchOrder(int staffID)
        {
            InitializeComponent();
            PopulatePaymentMethodComboBox(paymentMethod_cbx);
            PopulatePaymentStatusComboBox(paymentStatus_cbx);
            LoadProductData();
            AddPunchOrderButtonColumn();
            this.staffID = staffID;
        }
        private string connectionString = @"Data Source=(local);Initial Catalog=ToyHub;Integrated Security=True";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGrid.Columns["PunchOrder"].Index && e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGrid.Rows[e.RowIndex];

                // Call a method to handle editing based on the selected row data
                HandleEdit(selectedRow);
            }
        }
        private void HandleEdit(DataGridViewRow selectedRow)
        {
            /* string productName = selectedRow.Cells["Name"].Value.ToString();
             string producID= selectedRow.Cells["ProductID"].Value.ToString();
             int id = int.Parse(producID);
             int quantity = int.Parse(quantity_txt.Text);
             decimal totalAmount = ProductDL.GetTotalAmount(id, quantity);
             int paymentStatus = Salary.GetSalaryStatus(paymentStatus_cbx.Text);
             int paymentMethod = Salary.GetPaymentMethod(paymentMethod_cbx.Text);
             int orderID = OrderDL.GetNewOrderID(staffID, totalAmount, paymentStatus, paymentMethod);
             MessageBox.Show(orderID.ToString());
             OrderDL.AddPunchOrder( orderID, id,  quantity);*/
            string productName = selectedRow.Cells["Name"].Value?.ToString();
            string productIDStr = selectedRow.Cells["ProductID"].Value?.ToString();
            int quantity;
            decimal totalAmount;

            // Validate if product name and ID are not null or empty
            if (!string.IsNullOrEmpty(productName) && !string.IsNullOrEmpty(productIDStr))
            {
                int productID;
                if (int.TryParse(productIDStr, out productID))
                {
                    if (int.TryParse(quantity_txt.Text, out quantity) && quantity > 0)
                    {
                        // Get total amount only if quantity is a valid positive integer
                        totalAmount = ProductDL.GetTotalAmount(productID, quantity);

                        // Check if total amount is non-negative
                        if (totalAmount >= 0)
                        {
                            int paymentStatus = Salary.GetSalaryStatus(paymentStatus_cbx.Text);
                            int paymentMethod = Salary.GetPaymentMethod(paymentMethod_cbx.Text);
                            if (staffID > 0)
                            {
                                // Get new order ID only if staff ID is valid
                                int orderID = OrderDL.GetNewOrderID(staffID, totalAmount, paymentStatus, paymentMethod);
                                if (orderID > 0)
                                {
                                    // Add punch order only if order ID is valid
                                    OrderDL.AddPunchOrder(orderID, productID, quantity);
                                    /* MessageBox.Show("Punch order added successfully.");*/
                                }
                                else
                                {
                                    /* MessageBox.Show("Failed to get a valid order ID.");*/
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid staff ID.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Total amount cannot be negative.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid quantity. Please enter a valid positive integer.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid product ID.");
                }
            }
            else
            {
                MessageBox.Show("Product name or ID is missing.");
            }

        }
        private void PopulatePaymentMethodComboBox(System.Windows.Forms.ComboBox paymentMethod_cbx)
        {
            paymentMethod_cbx.Items.Clear();
            paymentMethod_cbx.Items.Add("In Cash");
            paymentMethod_cbx.Items.Add("Bank Transfer");
        }
        private void PopulatePaymentStatusComboBox(System.Windows.Forms.ComboBox paymentStatus_cbx)
        {
            paymentStatus_cbx.Items.Clear();
            paymentStatus_cbx.Items.Add("Payed");
            paymentStatus_cbx.Items.Add("Pending");
        }
        private void LoadSearchedData(string searchCriteria)
        {
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT Name FROM Product WHERE IsDeleted = 0";
                    if (!string.IsNullOrEmpty(searchCriteria))
                    {
                        query += " AND Name LIKE @SearchCriteria";
                    }

                    SqlCommand cmd = new SqlCommand(query, con);
                    if (!string.IsNullOrEmpty(searchCriteria))
                    {
                        cmd.Parameters.AddWithValue("@SearchCriteria", "%" + searchCriteria + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGrid.DataSource = dataTable;
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

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchCriteria = SearchTextBox.Text;
            LoadSearchedData(searchCriteria);
        }
        private void AddPunchOrderButtonColumn()
        {
            // Create a button column
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "PunchOrder";
            editButtonColumn.HeaderText = "PunchOrder";
            editButtonColumn.Text = "PunchOrder";
            editButtonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            dataGrid.Columns.Add(editButtonColumn);
        }
        private void LoadProductData()
        {
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT ProductID,Name FROM Product WHERE IsDeleted = 0";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGrid.DataSource = dataTable;
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

        private void SearchTextBox_TextChanged_1(object sender, EventArgs e)
        {
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            LoadSearchedData(SearchTextBox.Text);
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGrid.Columns["PunchOrder"].Index && e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGrid.Rows[e.RowIndex];

                // Call a method to handle editing based on the selected row data
                HandleEdit(selectedRow);
            }
        }
    }
}
