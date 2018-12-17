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
        public products_show()
        {
            InitializeComponent();
        }
      
        private void products_show_Load(object sender, EventArgs e)
        {
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

                details UC = new details(name, id, price,pic,description, brand);//user control to send data on it 
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

                details UC = new details(name, id, price, pic, description, brand);//user control to send data on it 
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

                details UC = new details(name, id, price, pic, description, brand);//user control to send data on it 
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

                details UC = new details(name, id, price, pic, description, brand);//user control to send data on it 
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

                details UC = new details(name, id, price, pic, description, brand);//user control to send data on it 
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

                details UC = new details(name, id, price, pic, description, brand);//user control to send data on it 
                flowLayoutPanel6.Controls.Add(UC);
            }
            furnitureFile.Close();




        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showCart_MenuOption_Click(object sender, EventArgs e)
        {
            ReceiptForm cart = new ReceiptForm();
            cart.Show();
        }

        private void productsShow_menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
