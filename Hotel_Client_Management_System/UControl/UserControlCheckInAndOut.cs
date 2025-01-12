using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Client_Management_System.UControl
{
    public partial class UserControlCheckInAndOut : UserControl
    {
        public UserControlCheckInAndOut()
        {
            InitializeComponent();

            LoadRoomType();
            InitializeCustomerTypeComboBox();

            cmbCheckInRoomType.SelectedIndexChanged += cmbCheckInRoomType_SelectedIndexChanged;
            cmbCheckInRoomDescription.SelectedIndexChanged += cmbCheckInRoomDescription_SelectedIndexChanged;
            LoadCheckInData();
        }

        private void InitializeCustomerTypeComboBox()
        {
            cmbcustomerType.Items.Clear();
            cmbcustomerType.Items.Add("Local");
            cmbcustomerType.Items.Add("Foreign");
            cmbcustomerType.SelectedIndex = 0; // Default to "Local"
        }

        private void LoadRoomType()
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT DISTINCT room_type FROM room";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbCheckInRoomType.Items.Add(reader["room_type"].ToString());
                    }
                }

                if (cmbCheckInRoomType.Items.Count > 0)
                {
                    cmbCheckInRoomType.SelectedIndex = 0;
                }
            }
        }

        private void LoadCheckInRoomDescription()
        {
            cmbCheckInRoomDescription.Items.Clear();

            if (cmbCheckInRoomType.SelectedItem == null)
            {
                return;
            }

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT room_description FROM room WHERE room_type = @RoomType";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomType", cmbCheckInRoomType.SelectedItem.ToString());
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbCheckInRoomDescription.Items.Add(reader["room_description"].ToString());
                    }
                }
            }
        }

        private void LoadRoomPrice()
        {
            if (cmbCheckInRoomType.SelectedItem == null || cmbCheckInRoomDescription.SelectedItem == null)
            {
                MessageBox.Show("Please select both a room type and description.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                string priceQuery = "SELECT room_price FROM room WHERE room_type = @RoomType AND room_description = @RoomDescription";

                using (MySqlCommand command = new MySqlCommand(priceQuery, connection))
                {
                    command.Parameters.AddWithValue("@RoomType", cmbCheckInRoomType.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@RoomDescription", cmbCheckInRoomDescription.SelectedItem.ToString());

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        txtCheckInPrice.Text = result.ToString();
                    }
                    else
                    {
                        txtCheckInPrice.Text = "N/A";
                    }
                }
            }
        }

        private void InsertCheckIn(long customerID, long roomID, DateTime CheckInDate)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = "INSERT INTO `check-in` (room_id, cus_id, check_in_date) " +
                               "VALUES (@RoomID, @CustomerID, @CheckInDate)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomID", roomID);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@CheckInDate", CheckInDate);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Check-In Added Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Check-In. Please try again.");
                    }
                }
            }
        }

        private long GetRoomID(string roomType, string roomDescription)
        {
            long roomID = 0;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT room_id FROM room WHERE room_type = @RoomType AND room_description = @RoomDescription";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomType", roomType);
                    cmd.Parameters.AddWithValue("@RoomDescription", roomDescription);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        roomID = Convert.ToInt64(result);
                    }
                    else
                    {
                        MessageBox.Show("Room not found! Please check the room details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return roomID;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (cmbcustomerType.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer type.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string customerType = cmbcustomerType.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(txtCheckInFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtCheckInLastName.Text) ||
                string.IsNullOrWhiteSpace(txtCheckInPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtCheckInAddress.Text))
            {
                MessageBox.Show("Please fill in all the customer details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cmbCheckInRoomType.SelectedItem == null || cmbCheckInRoomDescription.SelectedItem == null)
            {
                MessageBox.Show("Please select a room type and description!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string roomType = cmbCheckInRoomType.SelectedItem.ToString();
            string roomDescription = cmbCheckInRoomDescription.SelectedItem.ToString();
            string firstname = txtCheckInFirstName.Text;
            string lastname = txtCheckInLastName.Text;
            string phone = txtCheckInPhoneNumber.Text;
            string address = txtCheckInAddress.Text;

            DateTime checkInDate = DateTime.Now;

            long customerID = GetOrInsertCustomer(firstname, lastname, customerType, phone, address);
            long roomID = GetRoomID(roomType, roomDescription);

            if (customerID > 0 && roomID > 0)
            {
                InsertCheckIn(customerID, roomID, checkInDate);
                LoadCheckInData();
                ClearFields();
            }
        }

        private long GetOrInsertCustomer(string firstName, string lastName, string customerType, string phoneNumber, string address)
        {
            long customerID = 0;
            string status = "Checked-In";

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Check if the customer already exists
                    string query = "SELECT cus_id, times_checked_In FROM customer WHERE cus_firstname = @FirstName AND cus_lastname = @LastName AND cus_phone = @PhoneNumber";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Customer exists, retrieve their ID and check-in count
                                customerID = reader.GetInt64("cus_id");
                                int checkInCount = reader.GetInt32("times_checked_In");

                                // Close the DataReader before executing another command
                                reader.Close();

                                // Update status and increment check-in count
                                string updateStatusQuery = "UPDATE customer SET status = @Status, times_checked_In = @CheckInCount WHERE cus_id = @CustomerID";
                                using (MySqlCommand update = new MySqlCommand(updateStatusQuery, conn))
                                {
                                    update.Parameters.AddWithValue("@Status", status);
                                    update.Parameters.AddWithValue("@CheckInCount", checkInCount + 1); // Increment count
                                    update.Parameters.AddWithValue("@CustomerID", customerID);
                                    update.ExecuteNonQuery();
                                }

                                MessageBox.Show($"Welcome back, {firstName} {lastName}! You have checked in {checkInCount + 1} times.");
                            }
                            else
                            {
                                // Close the DataReader before executing another command
                                reader.Close();

                                // Insert new customer
                                string insertQuery = "INSERT INTO customer (cus_firstname, cus_lastname, cus_type, cus_phone, cus_address, status, times_checked_In) " +
                                                     "VALUES (@FirstName, @LastName, @CustomerType, @PhoneNumber, @Address, @Status, 1); SELECT LAST_INSERT_ID();";

                                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                                {
                                    insertCmd.Parameters.AddWithValue("@FirstName", firstName);
                                    insertCmd.Parameters.AddWithValue("@LastName", lastName);
                                    insertCmd.Parameters.AddWithValue("@CustomerType", customerType);
                                    insertCmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                                    insertCmd.Parameters.AddWithValue("@Address", address);
                                    insertCmd.Parameters.AddWithValue("@Status", status);

                                    customerID = Convert.ToInt64(insertCmd.ExecuteScalar());
                                }

                                MessageBox.Show($"Welcome, {firstName} {lastName}! This is your first time checking in.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleError(ex, "An error occurred while retrieving or inserting customer information.");
            }

            return customerID;
        }

        private void cmbCheckInRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCheckInRoomDescription();
        }

        private void cmbCheckInRoomDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoomPrice();
        }

        private void LoadCheckInData()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Query to fetch check-in data
                    string query = @"
                SELECT 
                    ci.check_in_id,
                    c.cus_id,
                    r.room_type,
                    r.room_description,
                    r.room_price,
                    ci.check_in_date
                    FROM `check-in` ci
                    INNER JOIN customer c ON ci.cus_id = c.cus_id
                    INNER JOIN room r ON ci.room_id = r.room_id
                    ORDER BY ci.check_in_date DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGVCheckIn.AutoGenerateColumns = true;
                    dataGVCheckIn.DataSource = table; // Bind data to DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading check-in data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearFields()
        {
            txtCheckInFirstName.Clear();
            txtCheckInLastName.Clear();
            txtCheckInPhoneNumber.Clear();
            txtCheckInAddress.Clear();
            cmbCheckInRoomType.SelectedIndex = -1;
            cmbCheckInRoomDescription.SelectedIndex = -1;
            txtCheckInPrice.Clear();
            cmbcustomerType.SelectedIndex = -1;
        }

        private void dataGVCheckIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dataGVCheckIn.Rows[e.RowIndex];

                // Extract data from the selected row
                string UpdatedRoomDescription = row.Cells["room_description"].Value.ToString();
                string UpdatedRoomType = row.Cells["room_type"].Value.ToString();
                string UpdatedPrice = row.Cells["room_price"].Value.ToString();
                DateTime UpdateCheckInDate = Convert.ToDateTime(row.Cells["check_in_date"].Value);

                // Set the ComboBox selections
                cmbCheckOutRoomType.SelectedItem = UpdatedRoomType;

                // Set the other text fields
                txtCheckInPrice.Text = UpdatedPrice;
                dtpUpdateCheckIn.Text = UpdateCheckInDate.ToString("yyyy-MM-dd");

                LoadRoomDescriptionForUpdate(UpdatedRoomType);

                SetReservationData(UpdatedRoomDescription, UpdatedRoomType, UpdatedPrice, UpdateCheckInDate);

                tabControlCheckInAndOut.SelectedTab = tabPageCheckOut;


            }
        }

        public void SetReservationData(string updatedRoomDescription, string updatedRoomType, string updatedPrice, DateTime updatedCheckInDate)
        {
            //Load room types for the update form
            if (cmbCheckOutRoomType.Items.Count == 0)
            {
                LoadRoomTypeForUpdate();
            }

            //Set the selected room type
            if (cmbCheckOutRoomType.Items.Contains(updatedRoomType))
            {
                cmbCheckOutRoomType.SelectedItem = updatedRoomType;
            }

            if (cmbCheckOutRoomDescription.Items.Count == 0)
            {
                LoadRoomDescriptionForUpdate(updatedRoomType);
            }
            //Load the room description based on the selected room type
            if (cmbCheckOutRoomDescription.Items.Contains(updatedRoomDescription))
            {
                cmbCheckOutRoomDescription.SelectedItem = updatedRoomDescription;
            }

            //set the price and check-in / check-out for update
            txtCheckInPrice.Text = updatedPrice;
            dtpUpdateCheckIn.Value = updatedCheckInDate;
        }

        private void LoadRoomTypeForUpdate()
        {
            cmbCheckOutRoomType.Items.Clear(); //Clear the existing items

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT DISTINCT room_type FROM room";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string roomType = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(reader["room_type"].ToString());

                        if (!cmbCheckOutRoomType.Items.Contains(roomType))
                        {
                            cmbCheckOutRoomType.Items.Add(roomType);
                        }
                    }
                }

                // Optionally select the first item if needed
                if (cmbCheckOutRoomType.Items.Count > 0)
                {
                    cmbCheckOutRoomType.SelectedIndex = 0;
                }
            }
        }

        private void LoadRoomDescriptionForUpdate(string updateRoomType)
        {
            cmbCheckOutRoomDescription.Items.Clear();

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT room_description FROM room WHERE room_type = @RoomType";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomType", updateRoomType);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbCheckOutRoomDescription.Items.Add(reader["room_description"].ToString());
                    }
                }
            }
        }
    }
}
