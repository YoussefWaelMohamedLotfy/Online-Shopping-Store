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
    public partial class Edit : Form
    {
        public products_show ps;
       
        public Edit()
        {
            InitializeComponent();
        }
       

        private void show_data_Click(object sender, EventArgs e)
        {
            FileStream fstream = new FileStream("shoper.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
           
            while (fstream.Position != fstream.Length)
            {
              Shopper shopper = (Shopper)bf.Deserialize(fstream);

                if (linker.email == shopper.email)
                {
                    
                    country_tb.Text = shopper.country;
                    city_tb.Text = shopper.city;
                    address_tb.Text = shopper.address;
                    phone_tb.Text = shopper.phone;
                   // pass_tb.Text = linker.pass;



                }
             
            }
            fstream.Close();
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {

            FileStream fstream = new FileStream("shoper.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<Shopper> shopper_list = new List<Shopper>();
            string name = String.Empty;
            string address = String.Empty;
            string city = String.Empty;
            string country = String.Empty;
            string phone = String.Empty;
            string email = String.Empty;
            string password = String.Empty;
            while (fstream.Position != fstream.Length)
            {
                Shopper shopper = (Shopper)bf.Deserialize(fstream);
                if (linker.email == shopper.email)
                {   
                     country= country_tb.Text;
                     city= city_tb.Text;
                    address=address_tb.Text;
                   phone= phone_tb.Text;
                   password= linker.pass;
                    email = shopper.email ;
                    password = shopper.password;
                    name = shopper.name;
                    Shopper add_item = new Shopper(name,  address,city, country, phone,email, password);
                    shopper_list.Add(add_item);
                }
            }
            fstream.Close();
            FileStream trunc = new FileStream("shoper.txt", FileMode.Truncate);
            trunc.Close();

            FileStream appendfile = new FileStream("shoper.txt", FileMode.Append);
            BinaryFormatter format = new BinaryFormatter();

            for (int i = 0; i <shopper_list.Count; i++)
            {
                bf.Serialize(appendfile, shopper_list[i]);
            }
            appendfile.Close();
            this.Close();
        }
    }
}
