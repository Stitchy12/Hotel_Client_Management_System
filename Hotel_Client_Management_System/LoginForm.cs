using MySql.Data.MySqlClient;

namespace Hotel_Client_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();  
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // this will exit the application
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // retrieve the inputs username and password
            string username = txtUser.Text.Trim();
            string password = txtPassword.Text;

            // establish a connection in the database
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                // Prepare and SQL command to select the user from the admin table
                // where both the username and password match the input values
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM admin WHERE admn_user = @username AND admn_password = @password", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    conn.Open();

                    // this will execute the sql query and retrieve the results
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // check if any rows were returned, indicating a successful login
                    if (reader.HasRows)
                    {
                        // it will hide the login form
                        this.Hide();
                        Dashboard dashboard = new Dashboard();
                        dashboard.Username = txtUser.Text; // pass the username to the dashboard
                        txtUser.Clear();
                        txtPassword.Clear();
                        dashboard.Show(); // this will show the dashboard form
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username and Password, Please Try Again!", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            // toggle the visibility of the password characters
            if (chkShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
