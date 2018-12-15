using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace Online_Shopping_Store
{
    public partial class AddProduct : Form
    {
        string category = "";
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure you want to Add this Product ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
             
               
               
              
              
                string Product_Name = ProductNameTB.Text;
                string  Product_ID = ProductIdTB.Text;
                string  Price = PriceTB.Text;
                List<string> Size = new List<string>();
                List<string> color = new List<string>();
                string Product_Description = DescriptionTB.Text;
                // string category ="";
                string Product_brand = BrandTB.Text;
                string Availibility = "";
                Image productImages = pictureBox1.Image;
                int Quantity =(int)quantityCount.Value;
                foreach (string item in SizeCheckedListBox.CheckedItems)
                {
                    Size.Add(item);
                }
                foreach (string item in colorCheckedListBox.CheckedItems)
                {
                    color.Add(item);
                }
                Product_Description = DescriptionTB.Text;
                category = CategoryCB.SelectedItem.ToString();
                Product_brand = BrandTB.Text;
                if (AvailableRadioButton.Checked)
                {
                    Availibility = AvailableRadioButton.Text;
                }
                else if (!AvailableRadioButton.Checked)
                {
                    Availibility = AvailableRadioButton.Text;
                }
                Quantity = Convert.ToInt32(quantityCount.Value);



                // Save product according to Category Combobox
                

                if (CategoryCB.SelectedItem.ToString()== "Smart Phones")
                {
                    FileStream smartPhonesFile = new FileStream("Smart Phones.txt", FileMode.Append);
                    BinaryFormatter formatter = new BinaryFormatter();
                    ItemsDetails Item = new ItemsDetails(Product_ID, Product_Name, Price, Size, Product_Description, category, Product_brand, Availibility, color, Quantity, productImages);
                    formatter.Serialize(smartPhonesFile, Item);
                    smartPhonesFile.Close();
                }
                else if (CategoryCB.SelectedItem.ToString() == "Fashion")
                {
                    FileStream FashionFile = new FileStream("Fashion.txt", FileMode.Append);
                    BinaryFormatter formatter = new BinaryFormatter();
                    ItemsDetails Item = new ItemsDetails(Product_ID, Product_Name, Price, Size, Product_Description, category, Product_brand, Availibility, color, Quantity, productImages);
                    formatter.Serialize(FashionFile, Item);
                    FashionFile.Close();
                }
                else if (CategoryCB.SelectedItem.ToString() == "Electronics")
                {
                    FileStream electronicsFile = new FileStream("Electronics.txt", FileMode.Append);
                    BinaryFormatter formatter = new BinaryFormatter();
                    ItemsDetails Item = new ItemsDetails(Product_ID, Product_Name, Price, Size, Product_Description, category, Product_brand, Availibility, color, Quantity, productImages);
                    formatter.Serialize(electronicsFile, Item);
                    electronicsFile.Close();
                }
                else if (CategoryCB.SelectedItem.ToString() == "Beauty Products")
                {
                    FileStream beautyproductsFile = new FileStream("Beauty Products.txt", FileMode.Append);
                    BinaryFormatter formatter = new BinaryFormatter();
                    ItemsDetails Item = new ItemsDetails(Product_ID, Product_Name, Price, Size, Product_Description, category, Product_brand, Availibility, color, Quantity, productImages);
                    formatter.Serialize(beautyproductsFile, Item);
                    beautyproductsFile.Close();
                }
                else if (CategoryCB.SelectedItem.ToString() == "Appliances")
                {
                    FileStream appliancesFile = new FileStream("Appliances.txt", FileMode.Append);
                    BinaryFormatter formatter = new BinaryFormatter();
                    ItemsDetails Item = new ItemsDetails(Product_ID, Product_Name, Price, Size, Product_Description, category, Product_brand, Availibility, color, Quantity, productImages);
                    formatter.Serialize(appliancesFile, Item);
                    appliancesFile.Close();
                }
                else if (CategoryCB.SelectedItem.ToString() == "Furniture")
                {
                    FileStream FurnitureFile = new FileStream("Furniture.txt", FileMode.Append);
                    BinaryFormatter formatter = new BinaryFormatter();
                    ItemsDetails Item = new ItemsDetails(Product_ID, Product_Name, Price, Size, Product_Description, category, Product_brand, Availibility, color, Quantity, productImages);
                    formatter.Serialize(FurnitureFile, Item);
                    FurnitureFile.Close();
                }
                //FileStream fs = new FileStream("Products.txt", FileMode.Append);
                //formatter.Serialize(fs, Item);

                MessageBox.Show("Successfully added ! ");
                //fs.Close();
                ProductNameTB.Text = null;
                ProductIdTB.Text = null;
                PriceTB.Text = null;
                Size = null;
                color = null;
                DescriptionTB.Text = null;
                category = null;
                BrandTB.Text = null;
                Availibility = null;
                pictureBox1.Image = null;
                Quantity = 1;

            }
        
           
        }

        private void BackTB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "image files (* .jpp; * .jpeg; * .gif; * .bmp ; * .png;)| * .jpp; * .jpeg; * .gif; * .bmp; * .png;* .jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void BrandTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
