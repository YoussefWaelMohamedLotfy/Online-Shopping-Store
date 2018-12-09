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




        }
    }
}
