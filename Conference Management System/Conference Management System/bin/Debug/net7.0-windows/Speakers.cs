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

namespace Conference_Management_System
{

    // Modify the Speakers user control to implement IDataSender
    public partial class Speakers : UserControl
    {

        public event EventHandler NextButtonClicked;
        public event EventHandler BackButtonClicked;

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=conference_data");
        public Speakers()
        {
            InitializeComponent();
        }

        private void lastNameTb_TextChanged(object sender, EventArgs e)
        {


        }

        private void nextpic_Click(object sender, EventArgs e)
        {

            string lastname = lastNameTb.Text;
            string firstname = firstNameTb.Text;
            string contact = contactTb.Text;
            string email = emailTb.Text;

            // Check if any of the required fields are empty
            if (string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(contact) ||
                string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            string speakerQuery = $"INSERT INTO `speakers_info`(`SpeakerID`, `LNspeaker`, `FNspeaker`, `Contactspeaker`, `Emailspeaker`) VALUES('NULL', '{lastname}', '{firstname}', '{contact}', '{email}')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(speakerQuery, connection);

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Please Proceed to the next Section");
                this.Hide();
                // Fire the event when the "Next" button is clicked
                NextButtonClicked?.Invoke(this, EventArgs.Empty);
                return;
            }
            else
            {
                MessageBox.Show("Can't proceed...");
            }

            connection.Close();
        }

        private void backpic_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

