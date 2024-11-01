using Hotel_Client_Management_System.UControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Client_Management_System
{

    public partial class Dashboard : Form
    {
        public string Username;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MMM-dd-yyyy hh:mm:ss tt");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblUsername.Text = Username;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(btnDashboard);
            userControlCustomer1.Hide();
            userControlRoom1.Hide();
            userControlReservation2.Hide();
            userControlCheckInAndOut2.Hide();
            userControlReport1.Hide();
            userControlDashboard1.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            MovePanel(btnCustomer);
            userControlDashboard1.Hide();
            userControlReservation2.Hide();
            userControlRoom1.Hide();
            userControlReport1.Hide();
            userControlCheckInAndOut2.Hide();
            userControlCustomer1.Show();

            userControlCustomer1.LoadCustomerData();

            //clear the fields when switching to other tabs
            userControlCustomer1.clearCustomerData();

        }

        private void btnRoomAvailable_Click(object sender, EventArgs e)
        {
            MovePanel(btnRoomAvailable);
            userControlDashboard1.Hide();
            userControlCustomer1.Hide();
            userControlCheckInAndOut2.Hide();
            userControlReservation2.Hide();
            userControlReport1.Hide();

            userControlRoom1.refreshRoomData();

            userControlRoom1.Show();
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            MovePanel(btnReport);
            userControlDashboard1.Hide();
            userControlReservation2.Hide();
            userControlRoom1.Hide();
            userControlCustomer1.Hide();
            userControlCheckInAndOut2.Hide();
            userControlReport1.Show();
        }


        private void btnReservation_Click(object sender, EventArgs e)
        {
            MovePanel(btnReservation);
            userControlDashboard1.Hide();
            userControlCustomer1.Hide();
            userControlRoom1.Hide();
            userControlCheckInAndOut2.Hide();
            userControlReport1.Hide();
            userControlReservation2.Show();

            userControlReservation2.RefreshData();

            //clear the fields when switching to other tabs
            userControlReservation2.ReservationCLearFields();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            MovePanel(btnCheckIn);
            userControlDashboard1.Hide();
            userControlCustomer1.Hide();
            userControlRoom1.Hide();
            userControlReport1.Hide();
            userControlCheckInAndOut2.Show();

            //clear the fields when switching to other tabs
            userControlCheckInAndOut2.ClearFields();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
