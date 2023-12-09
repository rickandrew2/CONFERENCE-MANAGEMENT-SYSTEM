using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Conference_Management_System
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();

            // Hide all user controls initially
            speakers1.Hide();
            attendees1.Hide();
            session1.Hide();
            venues1.Hide();
            sponsor1.Hide();

            // SPEAKERS NEXT AND BACK
            speakers1.NextButtonClicked += Speakers_NextButtonClicked;
            speakers1.BackButtonClicked += Speakers_BackButtonClicked;
            // ATTENDEES NEXT AND BACK
            attendees1.NextButtonClicked += Attendees_NextButtonClicked;
            attendees1.BackButtonClicked += Attendees_BackButtonClicked;
            // SESSION NEXT AND BACK
            session1.NextButtonClicked += Session_NextButtonClicked;
            session1.BackButtonClicked += Session_BackButtonClicked;
            // VENUE NEXT AND BACK
            venues1.NextButtonClicked += Venues_NextButtonClicked;
            venues1.BackButtonClicked += Venues_BackButtonClicked;
            // SPONSOR BACK 
            sponsor1.BackButtonClicked += Sponsor_BackButtonClicked;


        }
        private void Speakers_NextButtonClicked(object sender, EventArgs e)
        {

            // Hide all user controls
            HideAllUserControls();

            // Show the Attendees user control
            attendees1.BringToFront();
            attendees1.Show();
        }

        private void Speakers_BackButtonClicked(object sender, EventArgs e)
        {
            // Hide all user controls
            HideAllUserControls();
        }

        private void Attendees_NextButtonClicked(object sender, EventArgs e)
        {
            // Hide all user controls
            HideAllUserControls();

            // Show the Session user control
            session1.BringToFront();
            session1.Show();
        }

        private void Attendees_BackButtonClicked(object sender, EventArgs e)
        {
            // Hide all user controls
            HideAllUserControls();

            speakers1.BringToFront();
            speakers1.Show();
        }

        private void Session_NextButtonClicked(object sender, EventArgs e)
        {
            // Hide all user controls
            HideAllUserControls();

            // Show the Session user control
            venues1.BringToFront();
            venues1.Show();
        }

        private void Session_BackButtonClicked(object sender, EventArgs e)
        {
            // Hide all user controls
            HideAllUserControls();

            attendees1.BringToFront();
            attendees1.Show();

        }

        private void Venues_NextButtonClicked(object sender, EventArgs e)
        {
            // Hide all user controls
            HideAllUserControls();

            // Show the Session user control
            sponsor1.BringToFront();
            sponsor1.Show();
        }

        private void Venues_BackButtonClicked(object sender, EventArgs e)
        {
            // Hide all user controls
            HideAllUserControls();

            session1.BringToFront();
            session1.Show();
        }


        private void Sponsor_BackButtonClicked(object sender, EventArgs e)
        {
            // Hide all user controls
            HideAllUserControls();

            // Show the Session user control
            venues1.BringToFront();
            venues1.Show();
        }







        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void speakerBtn_Click(object sender, EventArgs e)
        {
            // Hide all user controls
            HideAllUserControls();

            // Show the Speakers user control
            speakers1.BringToFront();
            speakers1.Show();
        }

        private void attendeesBtn_Click(object sender, EventArgs e)
        {
            // Hide all user controls
            HideAllUserControls();

            // Show the Attendees user control

            attendees1.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void sessionBtn_Click(object sender, EventArgs e)
        {
            // Hide all user controls
            HideAllUserControls();

            // Show the Session user control

            session1.BringToFront();
            session1.Show();
        }

        private void venueBtn_Click(object sender, EventArgs e)
        {
            // Hide all user controls
            HideAllUserControls();

            // Show the Venues user control
            venues1.BringToFront();
            venues1.Show();
        }

        private void sponsorsBtn_Click(object sender, EventArgs e)
        {
            // Hide all user controls
            HideAllUserControls();

            // Show the Sponsors user control
            sponsor1.BringToFront();
            sponsor1.Show();
        }

        // Helper method to hide all user controls
        private void HideAllUserControls()
        {
            speakers1.Hide();
            attendees1.Hide();
            session1.Hide();
            venues1.Hide();
            sponsor1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            speakers1.Hide();
            attendees1.Hide();
            session1.Hide();
            venues1.Hide();
            sponsor1.Hide();
        }

        private void exitPic_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
                this.Hide();
            }
        }

        private void attendees1_Load(object sender, EventArgs e)
        {

        }
    }
}
