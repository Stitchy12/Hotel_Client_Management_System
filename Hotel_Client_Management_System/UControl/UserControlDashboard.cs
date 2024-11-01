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
            LoadTotalCustomers();
        }

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

        public void LoadTotalCustomers()
        {
            long totalCustomers = CountTotalCustomers();
            labelTotalCustomer.Text = $"{totalCustomers}"; // Update the label with the total */
        }
    }
}
