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
using System.Runtime.Serialization;

namespace Online_Shopping_Store
{
    public partial class incs : Form
    {
        public incs()
        {
            InitializeComponent();
        }

        private void Buttsignup_Click(object sender, EventArgs e)
        {
            //save data in file through sign up form 
            string NAME = Textbox1_fname.Text + Textbox2_lname.Text;
            string EMAIL = Textbox3_email.Text;
            string PASSWORD = Textbox4_pass.Text;
            string COUNTRY = Textbox5_country.Text;
            string CITY = Textbox6_city.Text;
            string ADDRESS = Textbox7_address.Text;
            string PHONE = Textbox8_phone.Text;
            Shoper S = new Shoper(NAME, ADDRESS, CITY, COUNTRY, PHONE, EMAIL, PASSWORD);
            FileStream shoper_file = new FileStream("shoper.txt", FileMode.Append);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(shoper_file, S);
            shoper_file.Close();
            MessageBox.Show("Successfully Added!!");
            Textbox1_fname.Text = null;
            Textbox2_lname.Text = null;
            Textbox3_email.Text = null;
            Textbox4_pass.Text = null;
            Textbox5_country.Text = null;
            Textbox6_city.Text = null;
            Textbox7_address.Text = null;
            Textbox8_phone.Text = null;

        }

       

        private void Buttonsignin_Click_1(object sender, EventArgs e)
        {
            bool check = false;
            FileStream shoper_file_open = new FileStream("shoper.txt", FileMode.Open);
            BinaryFormatter Formatter = new BinaryFormatter();

            while (shoper_file_open.Position != shoper_file_open.Length)
            {
                Shoper S = (Shoper)Formatter.Deserialize(shoper_file_open);
                if (S.email == TextBox1_emailin.Text)
                {
                    if (S.password == TextBox2_passin.Text)
                    {
                        home_page fr = new home_page();
                        fr.Show();
                        //this.Hide();
                        check = true;
                    }


                }
            }
            shoper_file_open.Close();
            if (check == false)
            {
                MessageBox.Show("NOT found in System Y_Y");
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void butSign_up_tab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
    }
}
   
