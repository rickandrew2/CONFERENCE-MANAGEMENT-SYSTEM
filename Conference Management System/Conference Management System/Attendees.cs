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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Conference_Management_System
{

    public partial class Attendees : UserControl
    {

        public event EventHandler NextButtonClicked;
        public event EventHandler BackButtonClicked;

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=conference_data");
        public Sponsor sponsor { get; set; }

        public Attendees()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string typeAttendee = typeAttendeesTb.Text;
            string orgName = orgNameTb.Text;
            string affiliation = affiliationTb.Text;
            string contactnum = contactNumTb.Text;

            // Check if any of the required fields are empty
            if (string.IsNullOrEmpty(typeAttendee) || string.IsNullOrEmpty(orgName) || string.IsNullOrEmpty(affiliation) ||
                string.IsNullOrEmpty(contactnum))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            string attendeeQuery = "INSERT INTO `attendees_info`(`typeAttendees`, `orgName`, `affiliation`, `contactnum`) " +
                "VALUES (@typeAttendee, @orgName, @affiliation, @contactnum)";

            connection.Open();
            MySqlCommand command = new MySqlCommand(attendeeQuery, connection);
            command.Parameters.AddWithValue("@typeAttendee", typeAttendee);
            command.Parameters.AddWithValue("@orgName", orgName);
            command.Parameters.AddWithValue("@affiliation", affiliation);
            command.Parameters.AddWithValue("@contactnum", contactnum);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Proceed to the next Question");
                    this.Hide();
                    // Fire the event when the "Next" button is clicked
                    NextButtonClicked?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Can't proceed...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Attendees_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
