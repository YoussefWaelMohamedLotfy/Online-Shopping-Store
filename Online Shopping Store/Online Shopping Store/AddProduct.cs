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
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure you want to Add this Product ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string Product_Name = "";
                string Product_ID = "";
                string Price = "";
                List<string> Size = new List<string>();
                string Product_Description = "";
                string category = "";
                string Product_brand = "";
                string Availibility = "";
                List<Bitmap> productImages = new List<Bitmap>();
                List<string> color = new List<string>();
                int Quantity = 0;
                FileStream fs = new FileStream("Products.txt", FileMode.Append);
                BinaryFormatter formatter = new BinaryFormatter();
                Product_Name = ProductNameTB.Text;
                Product_ID = ProductIdTB.Text;
                Price = PriceTB.Text;

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
                ItemsDetails Item = new ItemsDetails(Product_ID, Product_Name, Price, Size, Product_Description, category, Product_brand, Availibility, color, Quantity);
                formatter.Serialize(fs, Item);
                MessageBox.Show("Successfully added ! ");
                fs.Close();
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
    }
}
