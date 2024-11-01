using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Client_Management_System.UControl
{

    public partial class UserControlCustomer : UserControl
    {

        private string selectedFirstName, selectedLastName, selectedCustomerType, selectedPhone, selectedAddress, selectedStatus;

        public UserControlCustomer()
        {
            InitializeComponent();
            txtSearch.TextChanged += txtSearch_TextChanged;
            dataGVCustomer.AutoGenerateColumns = true;
            LoadCustomerData();
        }

        public void LoadCustomerData()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT cus_id, CONCAT(cus_firstname, ' ', cus_lastname) AS FullName, cus_type, cus_phone, cus_address, status FROM customer";

                    MySqlCommand cmd = new(query, conn);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // set the data grid views data source to the  datatable
                    dataGVCustomer.DataSource = table;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        //Clear fields
        public void clearCustomerData()
        {
            txtCustomerFirstName.Clear();
            txtCustomerLastName.Clear();
            txtCustomerType.Clear();
            txtCustomerPhoneNumber.Clear();
            txtCustomerAddress.Clear();
            txtCustomerStatus.Clear();
            txtTimeCheckedIn.Clear();
            txtHistoryCustomerComment.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the text from the search box
            string searchValue = txtSearch.Text.Trim();

            // Check if the search box is not empty
            if (!string.IsNullOrEmpty(searchValue))
            {
                // Filter the DataGridView based on the phone number
                (dataGVCustomer.DataSource as DataTable).DefaultView.RowFilter = string.Format("cus_phone LIKE '%{0}%'", searchValue.Replace("'", "''"));
            }
            else
            {
                // If the search box is empty, remove the filter
                (dataGVCustomer.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {

            // Switch tab to the customer history
            tControlCustomer.SelectedTab = tabPageCustomerHistory;

            LoadCustomerData();
        }

        private void dataGVCustomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGVCustomer.Rows[e.RowIndex];

                string[] fullName = row.Cells["FullName"].Value.ToString().Split(' ');
                txtCustomerFirstName.Text = fullName[0];
                txtCustomerLastName.Text = fullName.Length > 1 ? fullName[1] : "";

                // Handle null or empty values to prevent errors
                txtCustomerType.Text = row.Cells["cus_type"].Value?.ToString() ?? string.Empty;
                txtCustomerPhoneNumber.Text = row.Cells["cus_phone"].Value?.ToString() ?? string.Empty;
                txtCustomerAddress.Text = row.Cells["cus_address"].Value?.ToString() ?? string.Empty;
                txtCustomerStatus.Text = row.Cells["status"].Value?.ToString() ?? string.Empty;
            }
        }
    }
}
