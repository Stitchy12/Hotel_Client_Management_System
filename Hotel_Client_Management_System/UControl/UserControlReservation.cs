using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class UserControlReservation : UserControl
    {
        public UserControlReservation()
        {
            
            InitializeComponent();
            // Load the available room types from the database into the room type combo box
            LoadRoomType();
            // Load existing reservation data to display on the user control
            LoadReservationData();
            // This event will trigger when the user selects a different room type
            cmbRoomType.SelectedIndexChanged += cmbRoomType_SelectedIndexChanged;
            // This event will trigger when the user selects a different room description
            cmbRoomDescription.SelectedIndexChanged += cmbRoomDescription_SelectedIndexChanged;


            // This event will trigger when the user selects a different room type in the update section
            cmbUpdateRoomType.SelectedIndexChanged += cmbUpdateRoomType_SelectedIndexChanged;
            // This event will trigger when the user selects a different room description in the update section
            cmbUpdateRoomDescription.SelectedIndexChanged += cmbUpdateRoomDescription_SelectedIndexChanged;
        }

        /* Start of the Add Reservation Tab Page Code */
        private void LoadRoomType()
        {
            // Clear any existing items in the room type combo box to prepare for fresh data loading
            cmbRoomType.Items.Clear();

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT DISTINCT TRIM(LOWER(room_type)) AS room_type FROM room";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            // Convert the room type to title case for better readability
                            string roomType = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(reader["room_type"].ToString());

                            // Check if the combo box already contains the room type to avoid duplicates
                            if (!cmbRoomType.Items.Contains(roomType))
                            {
                                // Add the room type to the combo box if it does not exist
                                cmbRoomType.Items.Add(roomType);
                            }
                        }
                    }
                }

                // If any room types were loaded, set the selected index to the first item
                if (cmbRoomType.Items.Count > 0)
                {
                    cmbRoomType.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the loading process and show an error message
                MessageBox.Show("An error occurred while loading room types: " + ex.Message);
            }
        }

        private void LoadRoomDescription()
        {
            // Clear any existing items in the room description combo box to prepare for fresh data loading
            cmbRoomDescription.Items.Clear();

            // Check if a room type is selected; if not, exit the method to avoid querying without a valid selection
            if (cmbRoomType.SelectedItem == null)
            {
                return; // Exit if no room type is selected
            }

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // SQL query to select room descriptions from the room table for the selected room type
                    string query = "SELECT room_description FROM room WHERE room_type = @RoomType";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@RoomType", cmbRoomType.SelectedItem.ToString());

                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            // Add each room description to the room description combo box
                            cmbRoomDescription.Items.Add(reader["room_description"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading room descriptions: " + ex.Message);
            }
        }

        private void LoadRoomPrice()
        {
            // Check if a room type or room description is selected; if either is null, exit the method to avoid querying without valid selections
            if (cmbRoomType.SelectedItem == null || cmbRoomDescription.SelectedItem == null)
            {
                return; // Exit if no room type or description is selected
            }

            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                // SQL query to select the room price based on the selected room type and description
                string priceQuery = "SELECT room_price FROM room WHERE room_type = @RoomType AND room_description = @RoomDescription";

                using (MySqlCommand command = new MySqlCommand(priceQuery, connection))
                {
                    command.Parameters.AddWithValue("@RoomType", cmbRoomType.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@RoomDescription", cmbRoomDescription.SelectedItem.ToString());

                    object result = command.ExecuteScalar();

                    // Check if the result is not null, indicating that a price was found
                    if (result != null)
                    {
                        // Set the text box to display the retrieved room price
                        txtAddPrice.Text = result.ToString();
                    }
                    else
                    {
                        // If no price was found, display "N/A" in the text box
                        txtAddPrice.Text = "N/A";
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validation section to ensure all required fields are filled
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                // Show an error message if any customer details are missing
                MessageBox.Show("Please fill in all the customer details.");
                return; // Exit the method to prevent further processing
            }

            // Check if a room type and description are selected; if not, show an error message
            if (cmbRoomType.SelectedItem == null || cmbRoomDescription.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid room type and description!");
                return; // Exit the method
            }

            // Validate the partial payment amount; it should not be empty and must be a valid decimal
            if (string.IsNullOrWhiteSpace(txtPartialPayment.Text) || !decimal.TryParse(txtPartialPayment.Text, out decimal partialPayment))
            {
                MessageBox.Show("Please enter a valid partial payment amount.");
                return;
            }

            // Retrieve the selected room type and description
            string roomType = cmbRoomType.SelectedItem.ToString();
            string roomDescription = cmbRoomDescription.SelectedItem.ToString();

            // Get customer information from the input fields
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string customerType = txtCustomerType.Text; // Customer type might be optional
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            DateTime checkInDate = dtpCheckInDate.Value;
            DateTime checkOutDate = dtpCheckOutDate.Value;

            // Retrieve the room ID based on the selected room type and description
            long roomID = GetRoomID(roomType, roomDescription);
            if (roomID <= 0)
            {
                // Show an error message if the room ID is not valid
                MessageBox.Show("Room not found! Please check the room details.");
                return;
            }

            // Check if the selected room is available for the specified dates
            if (!IsRoomAvailable(roomID, checkInDate, checkOutDate))
            {
                MessageBox.Show("The selected room is not available for the chosen dates. Please select different dates or a different room.");
                return;
            }

            // Get or insert the customer information into the database
            long customerID = GetorInsertCustomer(firstName, lastName, customerType, phoneNumber, address);

            // If the customer ID is valid, proceed to insert the reservation
            if (customerID > 0)
            {
                // Insert the reservation details into the database
                InsertReservation(customerID, roomID, checkInDate, checkOutDate, partialPayment);

                // Reload the reservation data to update the display
                LoadReservationData();

                // Clear the input fields after successful reservation
                ReservationCLearFields();
            }
        }

        private bool IsRoomAvailable(long roomID, DateTime checkInDate, DateTime checkOutDate)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Query to count reservations that conflict with the provided check-in and check-out dates
                    string query = @"
                        SELECT COUNT(*) 
                        FROM reservation 
                        WHERE room_id = @RoomID 
                        AND NOT (@CheckOutDate <= check_in_date OR @CheckInDate >= check_out_date)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection and specify check-in/check-out date range
                        cmd.Parameters.AddWithValue("@RoomID", roomID);
                        cmd.Parameters.AddWithValue("@CheckInDate", checkInDate);
                        cmd.Parameters.AddWithValue("@CheckOutDate", checkOutDate);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count == 0; // Return true if no conflicting reservations
                    }
                }
                catch (MySqlException ex)
                {
                    // Handle any potential MySQL exceptions (e.g., connection issues)
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return false; // or throw; to re-throw the exception for higher-level handling
                }
            }
        }

        private long GetorInsertCustomer(string firstName, string lastName, string customerType, string phoneNumber, string address)
        {
            long customerID = 0;
            string status = "Reserved";

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT cus_id FROM customer WHERE cus_firstname = @FirstName AND cus_lastname = @LastName AND cus_phone = @PhoneNumber";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            customerID = Convert.ToInt64(result);

                            string updateStatusQuery = "UPDATE customer SET status = @Status WHERE cus_id = @CustomerID";
                            using (MySqlCommand update = new MySqlCommand(updateStatusQuery, conn))
                            {
                                update.Parameters.AddWithValue("@Status", status);
                                update.Parameters.AddWithValue("@CustomerID", customerID);
                                update.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string insertQuery = "INSERT INTO customer (cus_firstname, cus_lastname, cus_type, cus_phone, cus_address, status) " +
                                                 "VALUES (@FirstName, @LastName, @CustomerType, @PhoneNumber, @Address, @Status); SELECT LAST_INSERT_ID();";

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
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving or inserting customer information: " + ex.Message);
            }

            return customerID;
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
                        MessageBox.Show("Room not found! Please check the room details.");
                    }
                }
            }
            return roomID;
        }

        /* private void UpdateCheckInCount(long customerID)
         {
             using (MySqlConnection conn = DatabaseHelper.GetConnection())
             {
                 conn.Open();
                 string query = "UPDATE customer SET check_in_count = check_in_count + 1 WHERE cus_id = @CustomerID";

                 using (MySqlCommand cmd = new MySqlCommand(query, conn))
                 {
                     cmd.Parameters.AddWithValue("@CustomerID", customerID);
                     cmd.ExecuteNonQuery();
                 }
             }
         }
        */
        private void InsertReservation(long customerID, long roomID, DateTime CheckInDate, DateTime CheckOutDate, decimal partialPayment)
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = "INSERT INTO reservation (cus_id, room_id, check_in_date, check_out_date, reservation_date, partial_payment) " +
                                   "VALUES (@CustomerID, @RoomID, @CheckInDate, @CheckOutDate, @ReservationDate, @PartialPayment)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerID);
                        cmd.Parameters.AddWithValue("@RoomID", roomID);
                        cmd.Parameters.AddWithValue("@CheckInDate", CheckInDate);
                        cmd.Parameters.AddWithValue("@CheckOutDate", CheckOutDate);
                        cmd.Parameters.AddWithValue("@ReservationDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@PartialPayment", partialPayment);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Reservation added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add reservation. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the reservation: " + ex.Message);
            }
        }

        // Load reservation Data
        public void LoadReservationData()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT r.reservation_id, ro.room_description, ro.room_type, ro.room_price, r.check_in_date, r.check_out_date, r.partial_payment
                                     FROM reservation r
                                     INNER JOIN room ro ON r.room_id = ro.room_id";

                    MySqlCommand cmd = new(query, conn);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGVReservation.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        public void ReservationCLearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtAddPrice.Clear();
            txtPartialPayment.Clear();
            txtCustomerType.Clear();

            dtpCheckInDate.Value = DateTime.Now;
            dtpCheckOutDate.Value = DateTime.Now;

            cmbRoomDescription.SelectedIndex = -1;
            cmbRoomType.SelectedIndex = -1;


            // clear fields of update and cancel reservation when switching tabs
            cmbUpdateRoomDescription.SelectedIndex = -1;
            cmbUpdateRoomType.SelectedIndex = -1;
            txtUpdatePrice.Clear();

            dtpUpdateCheckIn.Value = DateTime.Now;
            dtpUpdateCheckOut.Value = DateTime.Now;
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoomDescription();
        }

        private void cmbRoomDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoomPrice();
        }
        /* End of the Add Reservation Tab Page Code */


        /* Start of the Update and Cancel Reservation Code */
        private void btnReservationUpdate_Click(object sender, EventArgs e)
        {

        }

        public void SetReservationData(string updatedRoomDescription, string updatedRoomType, string updatedPrice, DateTime updatedCheckInDate, DateTime updatedCheckOutDate)
        {
            //Load room types for the update form
            if (cmbUpdateRoomType.Items.Count == 0)
            {
                LoadRoomTypeForUpdate();
            }

            //Set the selected room type
            if (cmbUpdateRoomType.Items.Contains(updatedRoomType))
            {
                cmbUpdateRoomType.SelectedItem = updatedRoomType;
            }

            if (cmbUpdateRoomDescription.Items.Count == 0)
            {
                LoadRoomDescriptionForUpdate(updatedRoomType);
            }
            //Load the room description based on the selected room type
            if (cmbUpdateRoomDescription.Items.Contains(updatedRoomDescription))
            {
                cmbUpdateRoomDescription.SelectedItem = updatedRoomDescription;
            }

            //set the price and check-in / check-out for update
            txtUpdatePrice.Text = updatedPrice;
            dtpUpdateCheckIn.Value = updatedCheckInDate;
            dtpUpdateCheckOut.Value = updatedCheckOutDate;
        }

        public void RefreshData()
        {
            LoadRoomType();
            LoadRoomDescription();
        }

        public void dataGVReservation_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGVReservation.Rows[e.RowIndex];


                string UpdatedRoomDescription = row.Cells["room_description"].Value.ToString();
                string UpdatedRoomType = row.Cells["room_type"].Value.ToString();
                string UpdatedPrice = row.Cells["room_price"].Value.ToString();
                string PartialPayment = row.Cells["partial_payment"].Value.ToString();
                DateTime UpdateCheckInDate = Convert.ToDateTime(row.Cells["check_in_date"].Value);
                DateTime UpdatedCheckOutDate = Convert.ToDateTime(row.Cells["check_out_date"].Value);

                LoadRoomDescriptionForUpdate(UpdatedRoomType);

                SetReservationData(UpdatedRoomDescription, UpdatedRoomType, UpdatedPrice, UpdateCheckInDate, UpdatedCheckOutDate);

                tabControlReservation.SelectedTab = tabPageUpdateAndCancelReservation;


            }
        }

        private void LoadRoomTypeForUpdate()
        {
            cmbUpdateRoomType.Items.Clear(); //Clear the existing items

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

                        if (!cmbUpdateRoomType.Items.Contains(roomType))
                        {
                            cmbUpdateRoomType.Items.Add(roomType);
                        }
                    }
                }

                // Optionally select the first item if needed
                if (cmbUpdateRoomType.Items.Count > 0)
                {
                    cmbUpdateRoomType.SelectedIndex = 0;
                }
            }
        }

        private void LoadRoomPriceForUpdate()
        {
            txtUpdatePrice.Clear();

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT room_price FROM room WHERE room_type = @RoomType AND room_description = @RoomDescription";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomType", cmbUpdateRoomType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@RoomDescription", cmbUpdateRoomDescription.SelectedItem.ToString());

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        txtUpdatePrice.Text = result.ToString();
                    }
                    else
                    {
                        txtUpdatePrice.Text = "N/A";
                    }
                }
            }
        }

        private void LoadRoomDescriptionForUpdate(string updateRoomType)
        {
            cmbUpdateRoomDescription.Items.Clear();

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
                        cmbUpdateRoomDescription.Items.Add(reader["room_description"].ToString());
                    }
                }
            }
        }

        private void cmbUpdateRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUpdateRoomType.SelectedItem != null)
            {
                LoadRoomDescriptionForUpdate(cmbUpdateRoomType.SelectedItem.ToString());

                txtUpdatePrice.Text = "";
            }
        }

        private void cmbUpdateRoomDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUpdateRoomType.SelectedItem != null && cmbUpdateRoomDescription.SelectedItem != null)
            {
                LoadRoomPriceForUpdate();
            }
        }
    }
}
