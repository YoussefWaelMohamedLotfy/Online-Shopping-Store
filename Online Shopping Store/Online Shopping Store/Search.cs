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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Online_Shopping_Store
{
    public partial class Search : Form
    {
        
        public Search()
        {
            InitializeComponent();
        }

        private void Load_Cat_Click(object sender, EventArgs e)
        {
            search_flowLayoutPanel.Controls.Clear();
            string name;
            string price;
            string id;
            string description;
            string brand;
            Image pic;
            bool found = false;
            if (choose_CB.SelectedItem.ToString() == "Smart Phones")
            {
                FileStream smartPhonesFile = new FileStream("Smart Phones.txt", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                while (smartPhonesFile.Position != smartPhonesFile.Length)
                {
                    ItemsDetails its = (ItemsDetails)formatter.Deserialize(smartPhonesFile);
                    Items_Details.Add(its);
                    name = its.Product_Name;
                    price = its.Price;
                    id = its.Product_ID;
                    pic = its.productImages;
                    description = its.Product_Description;
                    brand = its.Product_brand;
                    details details = new details(name, id, price, pic, description, brand);
                    if (textBox1.Text == name)
                    {
                        found = true;
                     
                        search_flowLayoutPanel.Controls.Add(details);
                    }
                   
                }
                if (!found)
                {
                    MessageBox.Show("Not Found");
                    search_flowLayoutPanel.Controls.Clear();
                }

                //dataGridView3.DataSource = Items_Details;
                smartPhonesFile.Close();
            }
            else if (choose_CB.SelectedItem.ToString() == "Fashion")
            {
                FileStream FashionFile = new FileStream("Fashion.txt", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();

                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                while (FashionFile.Position != FashionFile.Length)
                {
                    ItemsDetails its = (ItemsDetails)formatter.Deserialize(FashionFile);
                    Items_Details.Add(its);
                    name = its.Product_Name;
                    price = its.Price;
                    id = its.Product_ID;
                    pic = its.productImages;
                    description = its.Product_Description;
                    brand = its.Product_brand;
                    details details = new details(name, id, price, pic, description, brand);
                    if (textBox1.Text == name)
                    {
                        found = true;
                        search_flowLayoutPanel.Controls.Add(details);
                    }
                }
                if (!found)
                {
                    search_flowLayoutPanel.Controls.Clear();
                    MessageBox.Show("Not Found");
                }
                //  dataGridView3.DataSource = Items_Details;
                FashionFile.Close();
            }
            else if (choose_CB.SelectedItem.ToString() == "Electronics")
            {
                FileStream electronicsFile = new FileStream("Electronics.txt", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();

                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                while (electronicsFile.Position != electronicsFile.Length)
                {
                    ItemsDetails its = (ItemsDetails)formatter.Deserialize(electronicsFile);
                    Items_Details.Add(its);
                    name = its.Product_Name;
                    price = its.Price;
                    id = its.Product_ID;
                    pic = its.productImages;
                    description = its.Product_Description;
                    brand = its.Product_brand;
                    details details = new details(name, id, price, pic, description, brand);
                    if (textBox1.Text == name)
                    {
                        found = true;
                        search_flowLayoutPanel.Controls.Add(details);
                    }
                    if (!found)
                    {
                        search_flowLayoutPanel.Controls.Clear();
                        MessageBox.Show("Not Found");
                    }
                }
                //  dataGridView3.DataSource = Items_Details;
                electronicsFile.Close();
            }
            else if (choose_CB.SelectedItem.ToString() == "Beauty Products")
            {
                FileStream beautyproductsFile = new FileStream("Beauty Products.txt", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();

                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                while (beautyproductsFile.Position != beautyproductsFile.Length)
                {
                    ItemsDetails its = (ItemsDetails)formatter.Deserialize(beautyproductsFile);
                    Items_Details.Add(its);
                    name = its.Product_Name;
                    price = its.Price;
                    id = its.Product_ID;
                    pic = its.productImages;
                    description = its.Product_Description;
                    brand = its.Product_brand;
                    details details = new details(name, id, price, pic, description, brand);
                    if (textBox1.Text == name)
                    {
                        found = true;
                   
                        search_flowLayoutPanel.Controls.Add(details);
                    }

                }
                if (!found)
                {
                    MessageBox.Show("Not Found");
                    search_flowLayoutPanel.Controls.Clear();
                }
                // dataGridView3.DataSource = Items_Details;
                beautyproductsFile.Close();
            }
            else if (choose_CB.SelectedItem.ToString() == "Appliances")
            {
                FileStream appliancesFile = new FileStream("Appliances.txt", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();

                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                while (appliancesFile.Position != appliancesFile.Length)
                {
                    ItemsDetails its = (ItemsDetails)formatter.Deserialize(appliancesFile);
                    Items_Details.Add(its);
                    name = its.Product_Name;
                    price = its.Price;
                    id = its.Product_ID;
                    pic = its.productImages;
                    description = its.Product_Description;
                    brand = its.Product_brand;
                    details details = new details(name, id, price, pic, description, brand);
                    if (textBox1.Text == name)
                    {
                        found = true;
                        search_flowLayoutPanel.Controls.Add(details);
                    }
                }
                if (!found)
                {
                    MessageBox.Show("Not Found");
                    search_flowLayoutPanel.Controls.Clear();
                }
                // dataGridView3.DataSource = Items_Details;
                appliancesFile.Close();
            }
            else if (choose_CB.SelectedItem.ToString() == "Furniture")
            {
                FileStream FurnitureFile = new FileStream("Furniture.txt", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();

                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                while (FurnitureFile.Position != FurnitureFile.Length)
                {
                    ItemsDetails its = (ItemsDetails)formatter.Deserialize(FurnitureFile);
                    Items_Details.Add(its);
                    name = its.Product_Name;
                    price = its.Price;
                    id = its.Product_ID;
                    pic = its.productImages;
                    description = its.Product_Description;
                    brand = its.Product_brand;
                    details details = new details(name, id, price, pic, description, brand);
                    if (textBox1.Text == name)
                    {
                        found = true;
                        search_flowLayoutPanel.Controls.Add(details);
                    }
                }
                if (!found)
                {
                    MessageBox.Show("Not Found");
                    search_flowLayoutPanel.Controls.Clear();
                }
                //  dataGridView3.DataSource = Items_Details;
                FurnitureFile.Close();
            }
        }
    }
}
