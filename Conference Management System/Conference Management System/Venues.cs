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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Conference_Management_System
{

    public partial class Venues : UserControl
    {
        public event EventHandler NextButtonClicked;
        public event EventHandler BackButtonClicked;

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=conference_data");

        public Venues()
        {
            InitializeComponent();
            InitializeCapacity();
        }

        private void InitializeCapacity()
        {
            for (int i = 1; i <= 500; i++)
            {
                domainUpDownCapacity.Items.Add(i).ToString();
            }
        }

        private void Venues_Load(object sender, EventArgs e)
        {

        }

        private void nextpic_Click(object sender, EventArgs e)
        {
            string venueName = venueNameTb.Text;
            string location = locationTb.Text;
            string capacity = domainUpDownCapacity.SelectedItem?.ToString();

            // Check if any of the required fields is empty or capacity is not selected
            if (string.IsNullOrEmpty(venueName) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(capacity))
            {
                MessageBox.Show("Please fill in all required fields, including capacity.");
                return;
            }

            SessionShare.venueName = venueName;

            string venueQuery = "INSERT INTO `venue_info`(`venueName`, `location`, `capacity`) VALUES (@venueName, @location, @capacity)";

            connection.Open();
            MySqlCommand command = new MySqlCommand(venueQuery, connection);
            command.Parameters.AddWithValue("@venueName", venueName);
            command.Parameters.AddWithValue("@location", location);
            command.Parameters.AddWithValue("@capacity", capacity);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Please Proceed to the next Section");
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



        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void backpic_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
