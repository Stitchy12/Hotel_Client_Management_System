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
    public partial class UserControlRoom : UserControl
    {
        public UserControlRoom()
        {
            InitializeComponent();
            loadRoomData();
        }

        public void loadRoomData()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT room_id, room_type, room_description, room_price, status FROM room";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGVRooms.DataSource = table;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e.Message);
            }
        }

        public void UpdateRoomStatus(long roomID, string status)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE room SET status = @Status WHERE room_id = @RoomID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@RoomID", roomID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void dataGVRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGVRooms.Rows[e.RowIndex];

                string roomID = row.Cells["room_id"].Value.ToString();
                string roomDescription = row.Cells["room_description"].Value.ToString();
                string roomType = row.Cells["room_type"].Value.ToString();
                string roomPrice = row.Cells["room_price"].Value.ToString();
                string roomStatus = row.Cells["status"].Value.ToString();
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string roomType = cmbAddRoomType.SelectedItem.ToString();
            string roomDescription = txtRoomDescription.Text.ToString();
            string roomPrice = txtAddRoomPrice.Text.ToString();

            if (string.IsNullOrEmpty(roomType) || string.IsNullOrEmpty(roomDescription) || string.IsNullOrEmpty(roomPrice))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = "INSERT INTO room (room_type, room_description, room_price, status) VALUES (@roomType, @roomDescription, @roomPrice, 'Available')";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        //Assign the parameters to the query
                        cmd.Parameters.AddWithValue("@roomType", roomType);
                        cmd.Parameters.AddWithValue("@roomDescription", roomDescription);
                        cmd.Parameters.AddWithValue("@roomPrice", roomPrice);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Room Added Successfully.");
                            refreshRoomData();
                            loadRoomData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the room!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void refreshRoomData()
        {
            cmbAddRoomType.SelectedIndex = -1;
            txtRoomDescription.Clear();
            txtAddRoomPrice.Clear();
        }
    }
}
