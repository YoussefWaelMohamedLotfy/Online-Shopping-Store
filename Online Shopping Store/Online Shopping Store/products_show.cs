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
            string name_rec="";
            string id_rec="";
            string brand_res="";
            string pro_num_rec="";
            string price_rec="";
            FileStream readBuynow = new FileStream("BuyNow.txt", FileMode.Open);
            BinaryFormatter Formatter = new BinaryFormatter();
            while (readBuynow.Position != readBuynow.Length)
            {
               BuyNow Bn= (BuyNow)Formatter.Deserialize(readBuynow);
                name_rec = Bn.name;
                id_rec = Bn.id;
                brand_res = Bn.brand;
                pro_num_rec = Bn.product_num;
                price_rec = Bn.price;
                Receipt REC = new Receipt(id_rec,name_rec,brand_res,price_rec,pro_num_rec);//user control to send data on it 
                receipt_flowLayoutPanel.Controls.Add(REC);
            }
            readBuynow.Close();
            tabControl1.SelectedTab = receipt_tab;

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
    }
}
