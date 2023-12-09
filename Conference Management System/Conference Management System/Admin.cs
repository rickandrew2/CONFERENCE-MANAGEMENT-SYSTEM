using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace Conference_Management_System
{
    public partial class Admin : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=conference_data");
        DataTable dataTable = new DataTable();


        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public Admin()
        {
            InitializeComponent();
            DisplayConfSched();
        }

        private void DisplayConfSched()
        {
            try
            {
                // Create a DataTable to store the trade history data
                DataTable confScheduleTable = new DataTable();

                // Open the database connection
                connection.Open();

                // Fetch the trade history data from the database
                string confSchedQuery = @"SELECT * FROM schedules_info 
                                          ORDER BY scheduleID ASC";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(confSchedQuery, connection))
                {
                    // Fill the DataTable with the trade history data
                    adapter.Fill(confScheduleTable);
                }

                // Bind the DataTable to the DataGridView
                dataGridViewMyAllData.DataSource = confScheduleTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching trade history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                connection.Close();
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Welcome welcome = new Welcome();
                this.Hide();
                this.Close();
                welcome.ShowDialog();
            }

        }

        private void dataGridViewMyAllData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewMyAllData.SelectedRows.Count > 0)
            {
                string selectedScheduleID = dataGridViewMyAllData.SelectedRows[0].Cells["scheduleID"].Value.ToString();

                using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=conference_data"))
                {
                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM schedules_info WHERE scheduleID = @scheduleID", connection))
                    {
                        cmd.Parameters.AddWithValue("@scheduleID", selectedScheduleID);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Record Successfully Deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayConfSched(); // Assuming you have a method to refresh or load data
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a row to delete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clears the Data  
        private void ClearData()
        {
            txtScheduleID.Text = "";
            txtUserID.Text = "";
            txtSessionID.Text = "";
            txtSessionName.Text = "";
            txtVenueName.Text = "";
            txtConferenceStatus.Text = "";
        }


        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewMyAllData.SelectedRows.Count > 0)
            {
                string selectedScheduleID = dataGridViewMyAllData.SelectedRows[0].Cells["scheduleID"].Value.ToString();

                using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=conference_data"))
                {
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE schedules_info SET User_ID=@userId, SessionID=@sessionId, session_name=@sessionName, venueName=@venueName, conferenceStatus=@conferenceStatus WHERE scheduleID=@scheduleId", connection))
                    {

                        cmd.Parameters.AddWithValue("@scheduleId", txtScheduleID.Text);
                        cmd.Parameters.AddWithValue("@userId", txtUserID.Text);
                        cmd.Parameters.AddWithValue("@sessionId", txtSessionID.Text);
                        cmd.Parameters.AddWithValue("@sessionName", txtSessionName.Text);
                        cmd.Parameters.AddWithValue("@venueName", txtVenueName.Text);
                        cmd.Parameters.AddWithValue("@conferenceStatus", txtConferenceStatus.Text);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Record Successfully Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayConfSched();
                        ClearData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a row to UPDATE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void dataGridViewMyAllData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtScheduleID.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUserID.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSessionID.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSessionName.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtVenueName.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtConferenceStatus.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (txtSessionName.Text != "" && txtVenueName.Text != "" && txtConferenceStatus.Text != "")
            {
                using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=conference_data"))
                {
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO schedules_info (User_ID, SessionID, session_name, venueName, conferenceStatus) VALUES (NULL, NULL, @sessionName, @venueName, @conferenceStatus)", connection))
                    {
                        // Use the correct parameter name here
                        cmd.Parameters.AddWithValue("@UserID", txtUserID.Text);
                        cmd.Parameters.AddWithValue("@sessionId", txtSessionID.Text);
                        cmd.Parameters.AddWithValue("@sessionName", txtSessionName.Text);
                        cmd.Parameters.AddWithValue("@venueName", txtVenueName.Text);
                        cmd.Parameters.AddWithValue("@conferenceStatus", txtConferenceStatus.Text);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Record Successfully Inserted", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayConfSched();
                        ClearData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill up all the required fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}



