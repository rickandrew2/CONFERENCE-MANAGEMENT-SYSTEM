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
using MySql.Data.MySqlClient;

namespace Conference_Management_System
{
    public partial class Register : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=conference_data");
        public Register()
        {
            InitializeComponent();


        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string lname = lastNameTb.Text;
            string fname = firstNameTb.Text;
            string address = addressTb.Text;
            string emailadd = emailAddTb.Text;
            string contactnum = contactNumberTb.Text;
            string username = usernameTb.Text;
            string password = passwordTb.Text;

            // Check if any of the required fields are empty
            if (string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(emailadd) || string.IsNullOrEmpty(contactnum) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            Welcome welcome = new Welcome();

            // Check if the username already exists
            string checkUsernameQuery = $"SELECT r.* FROM register_info r " +
                            $"LEFT JOIN register_info u ON r.User_ID = u.User_ID " +
                            $"WHERE u.username = '{username}'";

            MySqlCommand checkUsernameCommand = new MySqlCommand(checkUsernameQuery, connection);

            connection.Open();
            MySqlDataReader usernameReader = checkUsernameCommand.ExecuteReader();

            if (usernameReader.HasRows)
            {
                // Username already exists, display a message to the user
                MessageBox.Show("Username already exists. Please choose a different username.");
                connection.Close();
                return;
            }

            connection.Close();

            // If the username is unique, proceed with the registration
            string registerQuery = $"INSERT INTO `register_info`(`User_ID`, `Lname`, `Fname`, `address`, `emailadd`, `contactnum`, `username`, `password`) " +
                $"VALUES ('NULL', '{lname}', '{fname}', '{address}', '{emailadd}', '{contactnum}', '{username}', '{password}')";

            connection.Open();
            MySqlCommand command = new MySqlCommand(registerQuery, connection);

            if (command.ExecuteNonQuery() == 1)
            {
                IDclasses.UserID++;
                MessageBox.Show("Registered Successfully!");
                this.Hide();
                welcome.ShowDialog();
                return;
            }
            else
            {
                MessageBox.Show("Can't Register at the moment...");
            }

            connection.Close();
        }

        private void Register_Load(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void contactNumberTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
