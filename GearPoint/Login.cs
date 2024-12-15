using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GearPoint
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void SignInCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(SignInCheckBox.Checked == true)
            {
                SignInPassTextBox.UseSystemPasswordChar = false;
                SignInConfPassTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                SignInPassTextBox.UseSystemPasswordChar = true;
                SignInConfPassTextBox.UseSystemPasswordChar = true;
            }
        }

        private void LoginCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(LoginCheckBox.Checked == true)
            {
                LoginPassTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                LoginPassTextBox.UseSystemPasswordChar= true; 
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            StartingPoint start = new StartingPoint();
            start.Show();
            this.Close();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (SignInPassTextBox.Text.Equals(SignInConfPassTextBox.Text))
            {
                string username = SignInUserTextBox.Text; // Assuming SignInUserTextBox is the username textbox
                string password = SignInPassTextBox.Text;

                DatabaseHandler dbHandler = new DatabaseHandler();
                bool userAdded = dbHandler.AddUser(username, password);

                if (userAdded)
                {
                    SignInUserTextBox.Clear();
                    SignInPassTextBox.Clear();
                    SignInConfPassTextBox.Clear();

                    MessageBox.Show("Account created successfully!\nYou can now proceed to login");
                }
                else
                {
                    MessageBox.Show("Failed to create account.");
                }
            }
            else
            {
                MessageBox.Show("Password does not match.");
            }
        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = LoginUserTextBox.Text; // Assuming LoginUserTextBox is the username textbox
            string password = LoginPassTextBox.Text;

            DatabaseHandler dbHandler = new DatabaseHandler();
            bool isValidUser = dbHandler.ValidateUser(username, password);

            if (isValidUser)
            {
                MessageBox.Show("Login successful!");
                Admin admin = new Admin(); // Proceed to admin interface after successful login
                admin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

    }
}
