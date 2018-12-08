using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Online_Shopping_Store
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void createNewAccount_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Go to registration tab
            Login_TabControl.SelectedTab = registrationTab;
        }

        private void cancelRegistration_Button_Click(object sender, EventArgs e)
        {
            // Go to login tab
            Login_TabControl.SelectedTab = loginTab;
        }

        private void createAccount_Button_Click(object sender, EventArgs e)
        {
            FileStream database = new FileStream("Database.txt", FileMode.Append);
            BinaryFormatter formatter = new BinaryFormatter();
            Shopper newShopper = new Shopper();

            // Check if there are any missing fields in registration
            if (IsMissingFields())
            {
                // Set shopper's data and save in database file
                newShopper.name = new_firstName_Textbox.Text + " " + new_lastName_Textbox.Text;
                newShopper.address = new_address_Textbox.Text;
                newShopper.Email = new_email_Textbox.Text;
                newShopper.phoneNumber = new_phoneNumber_Textbox.Text;
                newShopper.password = CheckPasswordIsVerified();

                formatter.Serialize(database, newShopper);

                // Open the home page
                home_page homePage = new home_page();
                homePage.Show();
                this.Close();
            }
            else
            {

            }

            database.Close();
        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            FileStream database = new FileStream("Database.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            // Loop on the whole database file
            while (database.Position != database.Length)
            {
                Shopper shopper = (Shopper)formatter.Deserialize(database);

                // Check if data entered by user exists in the database
                if (shopper.Email == email_Textbox.Text && shopper.password == password_Textbox.Text)
                {
                    // Open the home page and hide the login form
                    //this.Hide();
                    home_page homePage = new home_page();
                    homePage.Show();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Check your credentials! Enter your data again.", "Wrong Email or password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //email_Textbox.Text = password_Textbox.Text = String.Empty; // Clear textboxes
                }

            }



            database.Close();
        }

        /// <summary>
        /// Check if password entered by user is verified
        /// </summary>
        /// <returns> the password string entered by user </returns>
        private string CheckPasswordIsVerified()
        {
            try
            {
                if (new_password_Textbox.Text == new_verifyPassword_Textbox.Text)
                {
                    return new_password_Textbox.Text;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Wrong password verification", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return "";
        }

        /// <summary>
        /// Checks whether there are any missing fields in the registration form
        /// </summary>
        /// <returns> false if any missing field is found, true if none </returns>
        private bool IsMissingFields()
        {
            if (new_firstName_Textbox.TextLength == 0 || new_lastName_Textbox.TextLength == 0 || new_email_Textbox.TextLength == 0 ||
                new_password_Textbox.TextLength == 0 || new_verifyPassword_Textbox.TextLength == 0 || new_phoneNumber_Textbox.TextLength == 0)
            {
                MessageBox.Show("Missing fields found");
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
