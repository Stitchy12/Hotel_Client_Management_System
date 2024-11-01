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
    public partial class UserControlCheckInAndOut : UserControl
    {
        public UserControlCheckInAndOut()
        {
            InitializeComponent();

            LoadRoomType();
            cmbCheckInRoomType.SelectedIndexChanged += cmbCheckInRoomType_SelectedIndexChanged;
            cmbCheckInRoomDescription.SelectedIndexChanged += cmbCheckInRoomDescription_SelectedIndexChanged;

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

        private long GetOrInsertCustomer(string firstName, string lastName, string customerType, string phoneNumber, string address)
        {
            long customerID = 0;
            string status = "Checked-In";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // check if the customer already exists
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

                        // Update status checked-In
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
                        string insertQuery = "INSERT INTO customer (cus_firstname, cus_lastname, cus_type, cus_phone, cus_address, status)" +
                                                "VALUES (@FirstName, @LastName, @CustomerType, @PhoneNumber, @Address, @Status); SELECT LAST_INSERT_ID();";

                        using (MySqlCommand insertcmd = new MySqlCommand(insertQuery, conn))
                        {
                            insertcmd.Parameters.AddWithValue("@FirstName", firstName);
                            insertcmd.Parameters.AddWithValue("@LastName", lastName);
                            insertcmd.Parameters.AddWithValue("@CustomerType", customerType);
                            insertcmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                            insertcmd.Parameters.AddWithValue("@Address", address);
                            insertcmd.Parameters.AddWithValue("@Status", status);

                            customerID = Convert.ToInt64(insertcmd.ExecuteScalar());
                        }
                    }
                }
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

        public void ClearFields()
        {
            txtCheckInFirstName.Clear();
            txtCheckInLastName.Clear();
            txtCheckInPhoneNumber.Clear();
            txtCheckInAddress.Clear();
            cmbCheckInRoomType.SelectedIndex = -1;
            cmbCheckInRoomDescription.SelectedIndex = -1;
            txtCheckInPrice.Clear();
            txtCustomerType.Clear();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            // validation
            if (string.IsNullOrWhiteSpace(txtCheckInFirstName.Text) || string.IsNullOrWhiteSpace(txtCheckInLastName.Text) ||
                string.IsNullOrWhiteSpace(txtCheckInPhoneNumber.Text) || string.IsNullOrWhiteSpace(txtCheckInAddress.Text))
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
            string customerType = txtCustomerType.Text;

            DateTime checkInDate = DateTime.Now;

            long customerID = GetOrInsertCustomer(firstname, lastname, customerType, phone, address);
            long roomID = GetRoomID(roomType, roomDescription);

            if(customerID > 0 && roomID > 0)
            {
                InsertCheckIn(customerID, roomID, checkInDate);
                ClearFields();
            }
        }

        private void cmbCheckInRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCheckInRoomDescription();
        }

        private void cmbCheckInRoomDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoomPrice();
        }
    }
}
