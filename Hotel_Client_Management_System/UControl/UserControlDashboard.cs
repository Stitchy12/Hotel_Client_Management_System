using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Client_Management_System.UControl
{
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (this.Visible)
            {
                LoadDashboardData(); // refresh all metrics
            }
        }

        // Load all dashboard data
        private void LoadDashboardData()
        {
            LoadTotalCustomers();
            LoadTotalRoomsAvailable();
            LoadTotalReservations();
            LoadTotalCheckIns();
        }

        // Fetch the total number of customers
        private long CountTotalCustomers()
        {
            long totalCustomers = 0;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(DISTINCT cus_id) FROM customer";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        totalCustomers = Convert.ToInt64(result);
                    }
                }
            }

            return totalCustomers;
        }

        private void LoadTotalCustomers()
        {
            long totalCustomers = CountTotalCustomers();
            labelTotalCustomer.Text = $"{totalCustomers:N0}"; // Format with commas
        }

        // Fetch the number of available rooms
        private long CountAvailableRooms()
        {
            long availableRooms = 0;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM room WHERE status = 'Available'";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        availableRooms = Convert.ToInt64(result);
                    }
                }
            }

            return availableRooms;
        }

        private void LoadTotalRoomsAvailable()
        {
            long availableRooms = CountAvailableRooms();
            labelTotalRoomsAvailable.Text = $"{availableRooms:N0}";
        }

        // Fetch the total number of reservations
        private long CountTotalReservations()
        {
            long totalReservations = 0;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM reservation";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        totalReservations = Convert.ToInt64(result);
                    }
                }
            }

            return totalReservations;
        }

        private void LoadTotalReservations()
        {
            long totalReservations = CountTotalReservations();
            labelTotalReservation.Text = $"{totalReservations:N0}";
        }

        // Fetch the total number of check-ins
        private long CountTotalCheckIns()
        {
            long totalCheckIns = 0;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM `check-in`";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        totalCheckIns = Convert.ToInt64(result);
                    }
                }
            }

            return totalCheckIns;
        }

        private void LoadTotalCheckIns()
        {
            long totalCheckIns = CountTotalCheckIns();
            labelTotalCheckIn.Text = $"{totalCheckIns:N0}";
        }
    }
}
