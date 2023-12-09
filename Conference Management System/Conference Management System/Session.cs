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
using static Conference_Management_System.IDclasses;

namespace Conference_Management_System
{

    public partial class Session : UserControl
    {

        public event EventHandler NextButtonClicked;
        public event EventHandler BackButtonClicked;
        public string SessionTitle { get; private set; }
        public Session()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=conference_data");
        private void Session_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string title = titleTb.Text;
            string description = descriptionRTB.Text;
            DateTime datetime = dateAndTime.Value;


            // Check if any of the required fields are empty
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || !dateAndTime.Checked)
            {
                MessageBox.Show("Please fill in all required fields, including a valid date and time.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=conference_data"))
            {
                connection.Open();

                string sessionQuery = "INSERT INTO `sessions_info` (`SessionID`, `title`, `description`, `dateAndtime`) " +
                                      "VALUES (NULL, @title, @description, @datetime)";

                MySqlCommand command = new MySqlCommand(sessionQuery, connection);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@datetime", datetime.ToString("yyyy-MM-dd HH:mm:ss"));
                SessionShare.sessiontitle = title;

                if (command.ExecuteNonQuery() == 1)
                {
                    // Retrieve the last inserted session ID
                    string getLastInsertIdQuery = "SELECT LAST_INSERT_ID()";
                    MySqlCommand getLastInsertIdCommand = new MySqlCommand(getLastInsertIdQuery, connection);

                    // ExecuteScalar returns the value of the first column of the first row
                    object result = getLastInsertIdCommand.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int lastInsertId))
                    {
                        // Update the SessionID in the IDclasses class
                        IDclasses.SessionID = lastInsertId;



                        MessageBox.Show("Proceed to the next Question");
                        // Fire the event when the "Next" button is clicked
                        NextButtonClicked?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Can't retrieve the last inserted ID");
                    }
                }
                else
                {
                    MessageBox.Show("Can't proceed...");
                }
            }
        }

        private void descriptionRTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}



