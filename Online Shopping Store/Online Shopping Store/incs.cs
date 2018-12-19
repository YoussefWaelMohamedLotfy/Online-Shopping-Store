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
            bool check = false;
            //save data in file through sign up form 
            string NAME = Textbox1_fname.Text + " " + Textbox2_lname.Text;
            string EMAIL = Textbox3_email.Text;
            string PASSWORD = Textbox4_pass.Text;
            string COUNTRY = Textbox5_country.Text;
            string CITY = Textbox6_city.Text;
            string ADDRESS = Textbox7_address.Text;
            string PHONE = Textbox8_phone.Text;
            if (string.IsNullOrWhiteSpace(Textbox1_fname.Text) || string.IsNullOrWhiteSpace(Textbox2_lname.Text) || string.IsNullOrWhiteSpace(Textbox3_email.Text) || string.IsNullOrWhiteSpace(Textbox4_pass.Text) || string.IsNullOrWhiteSpace(Textbox5_country.Text) || string.IsNullOrWhiteSpace(Textbox6_city.Text) || string.IsNullOrWhiteSpace(Textbox7_address.Text) || string.IsNullOrWhiteSpace(Textbox8_phone.Text))
            {
                MessageBox.Show("Missing");
            }
            else
            {
                FileStream shoper_file_open = new FileStream("shoper.txt", FileMode.Open);
                BinaryFormatter Formatter = new BinaryFormatter();
                ///
                                                        //attention//
                                 // dont remove this   it will work if you put data in the file //
                //while (shoper_file_open.Position != shoper_file_open.Length)
                //{
                //    Shopper S1 = (Shopper)Formatter.Deserialize(shoper_file_open);
                //    Dictionary<string, string> Check_repet = new Dictionary<string, string>();
                //    Check_repet.Add(S1.email, S1.password);
                //    if(Check_repet.ContainsKey(Textbox3_email.Text))
                //    {

                //        MessageBox.Show("Hi " + S1.name);
                //        tabPage1.Hide();

                //        tabPage2.Show();

                //        TextBox1_emailin.Text = S1.email;
                //        check=true;
                        
                //    }
                //}
                //shoper_file_open.Close();

                if (check == false)
                {
                    Shopper S = new Shopper(NAME, ADDRESS, CITY, COUNTRY, PHONE, EMAIL, PASSWORD);
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
                    shoper_file_open.Close();
                }
            }
        }

       

        private void Buttonsignin_Click_1(object sender, EventArgs e)
        {
            bool check = false;
            if(TextBox1_emailin.Text=="admin" && TextBox2_passin.Text=="admin")
            {
                OwnerAccount owner = new OwnerAccount();
                owner.Show();
                this.Hide();
                check = true;
            }
            FileStream shoper_file_open = new FileStream("shoper.txt", FileMode.Open);
            BinaryFormatter Formatter = new BinaryFormatter();

            while (shoper_file_open.Position != shoper_file_open.Length)
            {
                Shopper S = (Shopper)Formatter.Deserialize(shoper_file_open);
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
   
