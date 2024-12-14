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
            
            LoadRoomType();
            LoadReservationData();
            cmbRoomType.SelectedIndexChanged += cmbRoomType_SelectedIndexChanged;
            cmbRoomDescription.SelectedIndexChanged += cmbRoomDescription_SelectedIndexChanged;
            cmbUpdateRoomType.SelectedIndexChanged += cmbUpdateRoomType_SelectedIndexChanged;
            cmbUpdateRoomDescription.SelectedIndexChanged += cmbUpdateRoomDescription_SelectedIndexChanged;

            // Initialize customer type ComboBox
            InitializeCustomerTypeComboBox();
        }

        private void InitializeCustomerTypeComboBox()
        {
            cmbCustomerType.Items.Clear(); // Clear existing items
            cmbCustomerType.Items.Add("Local");
            cmbCustomerType.Items.Add("Foreign");
            cmbCustomerType.SelectedIndex = 0; // Optionally select the first item
        }

        /* Start of the Add Reservation Tab Page Code */

        private void LoadComboBoxData(ComboBox comboBox, string query, Dictionary<string, object> parameters = null)
        {
            comboBox.Items.Clear(); // Clear existing items
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            foreach (var parameter in parameters)
                            {
                                cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                            }
                        }

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string item = reader[0].ToString(); // Assuming you want the first column
                                item = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item); // Format the string

                                if (!comboBox.Items.Contains(item))
                                {
                                    comboBox.Items.Add(item);
                                }
                            }
                        }
                    }
                }

                // Optionally set the first item as selected if items are available
                if (comboBox.Items.Count > 0)
                {
                    comboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleError(ex, "An error occurred while loading data into the ComboBox.");
            }
        }

        private void LoadRoomType()
        {
            string query = "SELECT DISTINCT TRIM(LOWER(room_type)) AS room_type FROM room WHERE status = 'Available'";
            try
            {
                LoadComboBoxData(cmbRoomType, query);
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleError(ex, "An error occurred while loading room types.");
            }
        }

        private void LoadRoomDescription()
        {
            // Check if a room type is selected; if not, exit the method
            if (cmbRoomType.SelectedItem == null)
            {
                return; // Exit if no room type is selected
            }

            string query = "SELECT room_description FROM room WHERE room_type = @RoomType";
            var parameters = new Dictionary<string, object>
            {
                { "@RoomType", cmbRoomType.SelectedItem.ToString() }
            };

            LoadComboBoxData(cmbRoomDescription, query, parameters);
        }

        private void LoadRoomPrice()
        {
            // Check if a room type or room description is selected; if either is null, exit the method
            if (cmbRoomType.SelectedItem == null || cmbRoomDescription.SelectedItem == null)
            {
                return; // Exit if no room type or description is selected
            }

            try
            {
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
                        txtAddPrice.Text = result?.ToString() ?? "N/A"; // Use null-coalescing operator
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleError(ex, "An error occurred while loading the room price.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validation section to ensure all required fields are filled
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
            {
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
            string customerType = cmbCustomerType.SelectedItem.ToString(); // Customer type might be optional
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            DateTime checkInDate = dtpCheckInDate.Value;
            DateTime checkOutDate = dtpCheckOutDate.Value;

            // Retrieve the room ID based on the selected room type and description
            long roomID = GetRoomID(roomType, roomDescription);
            if (roomID <= 0)
            {
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
                long reservationID = InsertReservation(customerID, roomID, checkInDate, checkOutDate, partialPayment);

                MessageBox.Show("Reservation Added Successfully!", "Added");

                // If the reservation was added successfully, insert the payment
                if (reservationID > 0)
                {
                    InsertPayment(reservationID, partialPayment);
                }

                // Reload the reservation data to update the display
                LoadReservationData();

                // Clear the input fields after successful reservation
                ReservationCLearFields();
            }
        }

        private void InsertPayment(long reservationID, decimal paymentAmount)
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = "INSERT INTO payment (payment_date, payment_amount_paid, payment_method, reservation_id) " +
                                   "VALUES (@PaymentDate, @PaymentAmount, @PaymentMethod, @ReservationID)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@PaymentAmount", paymentAmount);
                        cmd.Parameters.AddWithValue("@PaymentMethod", "Gcash");
                        cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleError(ex, "An error occurred while adding the payment.");
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
                        SELECT COUNT(*) FROM reservation 
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
                                // Customer exists, retrieve their ID and current check-in count
                                customerID = reader.GetInt64("cus_id");
                                int checkInCount = reader.GetInt32("times_checked_In");

                                // Close the DataReader before executing another command
                                reader.Close();

                                // Update customer status and increment check-in count
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

        private long InsertReservation(long customerID, long roomID, DateTime checkInDate, DateTime checkOutDate, decimal partialPayment)
        {
            long reservationID = 0; // Initialize reservation ID

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = "INSERT INTO reservation (cus_id, room_id, check_in_date, check_out_date, reservation_date, partial_payment) " +
                                   "VALUES (@CustomerID, @RoomID, @CheckInDate, @CheckOutDate, @ReservationDate, @PartialPayment); " +
                                   "SELECT LAST_INSERT_ID();"; // Get the last inserted ID

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerID);
                        cmd.Parameters.AddWithValue("@RoomID", roomID);
                        cmd.Parameters.AddWithValue("@CheckInDate", checkInDate);
                        cmd.Parameters.AddWithValue("@CheckOutDate", checkOutDate);
                        cmd.Parameters.AddWithValue("@ReservationDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@PartialPayment", partialPayment);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            reservationID = Convert.ToInt64(result);
                        }
                    }

                    // Update the room status to 'Reserved'
                    string updateStatusQuery = "UPDATE room SET status = 'Reserved' WHERE room_id = @RoomID";
                    using (MySqlCommand updateCmd = new MySqlCommand(updateStatusQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@RoomID", roomID);
                        updateCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleError(ex, "An error occurred while retrieving or inserting customer information.");
            }

            return reservationID;
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
                ErrorHandler.HandleError(ex, "An error occurred while retrieving or inserting customer information.");
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
            cmbCustomerType.SelectedIndex = -1;

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