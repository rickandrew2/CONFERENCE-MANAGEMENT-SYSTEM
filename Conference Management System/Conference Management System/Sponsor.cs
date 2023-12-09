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

namespace Conference_Management_System
{
    public partial class Sponsor : UserControl
    {
        public event EventHandler BackButtonClicked;

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=conference_data");

        public Sponsor()
        {
            InitializeComponent();
        }

        private void backPic_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=conference_data"))
                {
                    connection.Open();

                    string lastname = lastNameTb.Text;
                    string firstname = firstNameTb.Text;
                    string emailadd = emailTb.Text;
                    string contact = contactTb.Text;

                    // Check if any of the required fields are empty
                    if (string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(emailadd) ||
                        string.IsNullOrEmpty(contact))
                    {
                        MessageBox.Show("Please fill in all required fields.");
                        return;
                    }

                    // Insert into sponsor_info using parameterized query
                    string sponsorQuery = "INSERT INTO `sponsor_info`(`sponsorID`, `LastName`, `FirstName`, `emailAddress`, `contactnum`) " +
                        "VALUES (NULL, @LastName, @FirstName, @EmailAddress, @ContactNum)";

                    using (MySqlCommand sponsorCommand = new MySqlCommand(sponsorQuery, connection))
                    {
                        sponsorCommand.Parameters.AddWithValue("@LastName", lastname);
                        sponsorCommand.Parameters.AddWithValue("@FirstName", firstname);
                        sponsorCommand.Parameters.AddWithValue("@EmailAddress", emailadd);
                        sponsorCommand.Parameters.AddWithValue("@ContactNum", contact);

                        // Insert into schedules_info using parameterized query
                        string setConQuery = "INSERT INTO schedules_info(`scheduleID`, `User_ID`, `SessionID`, `session_name`, `venueName`, `conferenceStatus`) " +
                            "VALUES (NULL, @UserID, @SessionID, @SessionTitle, @VenueName, 'Pending')";

                               

                        using (MySqlCommand setConCommand = new MySqlCommand(setConQuery, connection))
                        {
                            setConCommand.Parameters.AddWithValue("@UserID", IDclasses.UserID);
                            setConCommand.Parameters.AddWithValue("@SessionID", IDclasses.SessionID);
                            setConCommand.Parameters.AddWithValue("@SessionTitle", SessionShare.sessiontitle);
                            setConCommand.Parameters.AddWithValue("@VenueName", SessionShare.venueName);

                            using (MySqlTransaction transaction = connection.BeginTransaction())
                            {
                                try
                                {
                                    // Execute both commands
                                    sponsorCommand.ExecuteNonQuery();
                                    setConCommand.ExecuteNonQuery();

                                    // Successfully executed both queries
                                    transaction.Commit();
                                    DialogResult result = MessageBox.Show("Conference was set Successfully!", "Congrats", MessageBoxButtons.OK);
                                    if (result == DialogResult.OK)
                                    {
                                        this.Hide();
                                    }
                                    return;
                                }
                                catch (Exception ex)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show($"Error: {ex.Message}");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}