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
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=127.0.0.1;user=root;database=conference_data;password=");
            connection.Open();

            string username = usernameTb.Text;
            string password = passwordTb.Text;

            Home home = new Home();
            Admin admin = new Admin();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM register_info " +
                                            "JOIN attendees_info ON register_info.User_ID = attendees_info.AttendeeID " +
                                            "JOIN sessions_info ON register_info.User_ID = sessions_info.SessionID", connection);

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            bool isAdmin = false;

            while (reader.Read())
            {
                if (username.Equals(reader.GetString("username")) && password.Equals(reader.GetString("password")))
                {
                    // Get the User_ID of the logged-in user
                    int userId = reader.GetInt32("User_ID");

                    // Set the User_ID in the IDclasses class
                    IDclasses.UserID = userId;

                    MessageBox.Show("Login Success!");
                    this.Hide(); // Hide the current form
                    this.Close();
                    home.ShowDialog();
                    connection.Close();
                    return;
                }
                else if (username == "admin" && password == "adminpass")
                {
                    isAdmin = true;
                    break; // Exit the loop if admin credentials are found
                }
            }

            connection.Close();

            if (isAdmin == true)
            {
                MessageBox.Show("Welcome Admin!");
                this.Hide(); // Hide the current form
                this.Close();
                admin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }



        void login_Load(object sender, EventArgs e)
        {

        }



        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked == true)
            {
                passwordTb.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTb.UseSystemPasswordChar = true;
            }
        }

        private void passwordTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load_1(object sender, EventArgs e)
        {

        }
    }
}


