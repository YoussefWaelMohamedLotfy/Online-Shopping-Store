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
    public partial class products_show : Form
    {
        Random rand = new Random();
        //details Cart = new details();
        int orderTotal;

        public products_show()
        {
            InitializeComponent();

            orderTotal = 0;
            shippingFees_label.Text = rand.Next(15, 60).ToString();
            receiptNumber.Text = "Receipt #" + rand.Next(321561453, 575443321).ToString();
        }

        private void products_show_Load(object sender, EventArgs e)
        {
            // Hide tabs
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            string name;
            string price;
            string id;
            string description;
            string brand;
            Image pic;
            LinkedList<ItemsDetails> PR = new LinkedList<ItemsDetails>();

            // Save smart phones product
            FileStream smartPhoneFile = new FileStream("Smart Phones.txt", FileMode.Open);
            BinaryFormatter Formatter = new BinaryFormatter();
           
            while (smartPhoneFile.Position != smartPhoneFile.Length)
            {
                ItemsDetails PP = (ItemsDetails)Formatter.Deserialize(smartPhoneFile);
                PR.AddFirst(PP);// not important i put it for fun 
               
                name =PP.Product_Name;
                price = PP.Price;
                id = PP.Product_ID;
                pic = PP.productImages;
                description = PP.Product_Description;
                brand = PP.Product_brand;

                details UC = new details(name, id, price,pic,description, brand, this);//user control to send data on it 
                    flowLayoutPanel1.Controls.Add(UC); 
            }
            smartPhoneFile.Close();
           
           // Save fashion product
            FileStream fashionFile = new FileStream("Fashion.txt", FileMode.Open);
            BinaryFormatter Formatter1 = new BinaryFormatter();
            PR = new LinkedList<ItemsDetails>();
            while (fashionFile.Position != fashionFile.Length)
            {
                ItemsDetails PP = (ItemsDetails)Formatter.Deserialize(fashionFile);
                PR.AddFirst(PP);// not important i put it for fun 

                name = PP.Product_Name;
                price = PP.Price;
                id = PP.Product_ID;
                pic = PP.productImages;
                description = PP.Product_Description;
                brand = PP.Product_brand;

                details UC = new details(name, id, price, pic, description, brand, this);//user control to send data on it 
                flowLayoutPanel2.Controls.Add(UC);
            }
            fashionFile.Close();

            // Save electronic product
            FileStream electronicsFile = new FileStream("Electronics.txt", FileMode.Open);
            BinaryFormatter Formatter2 = new BinaryFormatter();
            PR = new LinkedList<ItemsDetails>();
            while (electronicsFile.Position != electronicsFile.Length)
            {
                ItemsDetails PP = (ItemsDetails)Formatter.Deserialize(electronicsFile);
                PR.AddFirst(PP);// not important i put it for fun 

                name = PP.Product_Name;
                price = PP.Price;
                id = PP.Product_ID;
                pic = PP.productImages;
                description = PP.Product_Description;
                brand = PP.Product_brand;

                details UC = new details(name, id, price, pic, description, brand, this);//user control to send data on it 
                flowLayoutPanel3.Controls.Add(UC);
            }
            electronicsFile.Close();

            // Save beauty Products product
            FileStream beautyProductsFile = new FileStream("Beauty Products.txt", FileMode.Open);
            BinaryFormatter Formatter4 = new BinaryFormatter();
            PR = new LinkedList<ItemsDetails>();
            while (beautyProductsFile.Position != beautyProductsFile.Length)
            {
                ItemsDetails PP = (ItemsDetails)Formatter.Deserialize(beautyProductsFile);
                PR.AddFirst(PP);// not important i put it for fun 

                name = PP.Product_Name;
                price = PP.Price;
                id = PP.Product_ID;
                pic = PP.productImages;
                description = PP.Product_Description;
                brand = PP.Product_brand;

                details UC = new details(name, id, price, pic, description, brand, this);//user control to send data on it 
                flowLayoutPanel4.Controls.Add(UC);
            }
            beautyProductsFile.Close();

            // Save Appliances product
            FileStream AppliancesFile = new FileStream("Appliances.txt", FileMode.Open);
            BinaryFormatter Formatter6 = new BinaryFormatter();
            PR = new LinkedList<ItemsDetails>();
            while (AppliancesFile.Position != AppliancesFile.Length)
            {
                ItemsDetails PP = (ItemsDetails)Formatter.Deserialize(AppliancesFile);
                PR.AddFirst(PP);// not important i put it for fun 

                name = PP.Product_Name;
                price = PP.Price;
                id = PP.Product_ID;
                pic = PP.productImages;
                description = PP.Product_Description;
                brand = PP.Product_brand;

                details UC = new details(name, id, price, pic, description, brand, this);//user control to send data on it 
                flowLayoutPanel5.Controls.Add(UC);
            }
            AppliancesFile.Close();

            // Save Appliances product
            FileStream furnitureFile = new FileStream("Furniture.txt", FileMode.Open);
            BinaryFormatter Formatter8 = new BinaryFormatter();
            PR = new LinkedList<ItemsDetails>();
            while (furnitureFile.Position != furnitureFile.Length)
            {
                ItemsDetails PP = (ItemsDetails)Formatter.Deserialize(furnitureFile);
                PR.AddFirst(PP);// not important i put it for fun 

                name = PP.Product_Name;
                price = PP.Price;
                id = PP.Product_ID;
                pic = PP.productImages;
                description = PP.Product_Description;
                brand = PP.Product_brand;
              

                details UC = new details(name, id, price, pic, description, brand, this);//user control to send data on it 
                flowLayoutPanel6.Controls.Add(UC);
            }
            furnitureFile.Close();




        }

        private void showCart_MenuOption_Click(object sender, EventArgs e)
        {
            home_page home = new home_page();

            if (home != null)
            {
                Application.OpenForms[home.Name].Activate();
                home.TopMost = true;
                home.Focus();
            }

            //home.Show();
            //this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void showCart_MenuItem_Click(object sender, EventArgs e)
        {
            // Switch to Cart tab
            tabControl1.SelectedTab = cart_tab;
        }

        private void beautyProducts_SwitchToTab_button_Click(object sender, EventArgs e)
        {
            // Switch to Beauty products tab
            tabControl1.SelectedTab = Beauty_Product_tab;
        }

        private void fashion_SwitchToTab_button_Click(object sender, EventArgs e)
        {
            // Switch to Fashion tab
            tabControl1.SelectedTab = Fashion_Tab;
        }


        private void mobilePhones_SwitchToTab_button_Click(object sender, EventArgs e)
        {
            // Switch to smart phones tab
            tabControl1.SelectedTab = Smart_Phones_tab;
        }

        private void appliances_SwitchToTab_button_Click(object sender, EventArgs e)
        {
            // Switch to Appliances tab
            tabControl1.SelectedTab = Appliances_tab;
        }

        private void electronics_SwitchToTab_button_Click(object sender, EventArgs e)
        {
            // Switch to Electronics tab
            tabControl1.SelectedTab = Electronics_tab;
        }

        private void furniture_SwitchToTab_button_Click(object sender, EventArgs e)
        {
            // Switch to Furniture tab
            tabControl1.SelectedTab = Furniture_tab;
        }

        private void confirmPurchase_button_Click(object sender, EventArgs e)
        {
            //temp var
            bool check_full = true;
            string name_rec = "";
            string id_rec = "";
            string brand_res = "";
            string pro_num_rec = "";
            string price_rec = "";
            int total_int = 0;
            FileStream readBuynow = new FileStream("BuyNow.txt", FileMode.Open);
            BinaryFormatter Formatter = new BinaryFormatter();
            if (readBuynow.Length == 0)
            {
                check_full = false;
                MessageBox.Show("Sorry nothing in the cart");
            }
            else
            {
                while (readBuynow.Position != readBuynow.Length)
                {
                    BuyNow Bn = (BuyNow)Formatter.Deserialize(readBuynow);
                    name_rec = Bn.name;
                    id_rec = Bn.id;
                    brand_res = Bn.brand;
                    pro_num_rec = Bn.product_num;
                    price_rec = Bn.price;
                    if (pro_num_rec == "0")
                    {
                        continue;
                    }
                    else
                    {
                        // total_int = Convert.ToInt32(Bn.product_num);
                        total_int = total_int+ Convert.ToInt32(Bn.product_num) * Convert.ToInt32(Bn.price);
                        Receipt REC = new Receipt(id_rec, name_rec, brand_res, price_rec, pro_num_rec);//user control to send data on it 
                        receipt_flowLayoutPanel.Controls.Add(REC);
                    }
                }
            }
            readBuynow.Close();
            if (check_full == true)
            {
                tabControl1.SelectedTab = receipt_tab;
                orderTotal_label.Text = Convert.ToString(total_int);
                FileStream clear = new FileStream("BuyNow.txt", FileMode.Truncate);
                clear.Close();
            }


            // Show receipt if user confirms the purchase
            //if (MessageBox.Show("Are you sure you want to confirm your purchase?\nCheck again if you want anything else.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    // Switch to Receipt tab
            //    tabControl1.SelectedTab = receipt_tab;
            //    details Cart = new details();
            //    ReceiptItem receiptItem = new ReceiptItem();

            //    for (int i = 0; i < Cart.cartLinkedList.Count; i++)
            //    {
            //        receiptItem = new ReceiptItem();
            //        receipt_flowLayoutPanel.Controls.Add(receiptItem);
            //        orderTotal += Convert.ToInt32(receiptItem.totalItemsPrice_receiptLabel.ToString());
            //    }

            //    receiptItem.totalItemsPrice_receiptLabel.Text = orderTotal.ToString();

            //}
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void Load_Cat_Click(object sender, EventArgs e)
        {
            search_flowLayoutPanel.Controls.Clear();
            products_show ps = new products_show();
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
                    details details = new details(name, id, price, pic, description, brand, ps);
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
                    details details = new details(name, id, price, pic, description, brand, ps);
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
                    details details = new details(name, id, price, pic, description, brand, ps);
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
                    details details = new details(name, id, price, pic, description, brand, ps);
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
                    details details = new details(name, id, price, pic, description, brand, ps);
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
                    details details = new details(name, id, price, pic, description, brand, ps);
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

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = search_tab;
        }

        private void searchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = search_tab;
        }
    }
}
