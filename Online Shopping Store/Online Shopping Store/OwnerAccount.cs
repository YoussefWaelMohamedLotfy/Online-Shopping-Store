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
    public partial class OwnerAccount : Form
    {
        string category = "";
        public OwnerAccount()
        {
            InitializeComponent();
        }

             

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void OwnerAccount_Load(object sender, EventArgs e)
        {

        }

        private void ViewTB_Click(object sender, EventArgs e)
        {
            MyAccountTabControl.SelectedTab = ViewTab;
          
        }

        private void RemoveTB_Click(object sender, EventArgs e)
        {
            MyAccountTabControl.SelectedTab = RemoveTab;
            
        }

        private void AddProductTB_Click_1(object sender, EventArgs e)
        {
            MyAccountTabControl.SelectedTab = AddTab;

        }

        private void UpdateTB_Click(object sender, EventArgs e)
        {
            MyAccountTabControl.SelectedTab = UpdateTab;
            
        }

        private void CancelTB_Click_1(object sender, EventArgs e)
        {
            incs log = new incs();
            log.Show();
            this.Hide();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure you want to Add this Product ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string Product_Name = ProductNameTB.Text;
                string Product_ID = ProductIdTB.Text;
                string Price = PriceTB.Text;
                List<string> Size = new List<string>();
                List<string> color = new List<string>();
                string Product_Description = DescriptionTB.Text;
                string Product_brand = BrandTB.Text;
                string Availibility = "";
                Image productImages = pictureBox1.Image;
                int Quantity = (int)quantityCount.Value;
              
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
            if (CategoryCB.SelectedItem.ToString() == "Smart Phones")
            {
                FileStream smartPhonesFile = new FileStream("Smart Phones.txt", FileMode.Append);
                BinaryFormatter formatter = new BinaryFormatter();
                ItemsDetails Item = new ItemsDetails(Product_ID, Product_Name, Price, Product_Description, category, Product_brand, Availibility,  Quantity, productImages);
                formatter.Serialize(smartPhonesFile, Item);
                smartPhonesFile.Close();
            }
            else if (CategoryCB.SelectedItem.ToString() == "Fashion")
            {
                FileStream FashionFile = new FileStream("Fashion.txt", FileMode.Append);
                BinaryFormatter formatter = new BinaryFormatter();
                ItemsDetails Item = new ItemsDetails(Product_ID, Product_Name, Price, Product_Description, category, Product_brand, Availibility,  Quantity, productImages);
                formatter.Serialize(FashionFile, Item);
                FashionFile.Close();
            }
            else if (CategoryCB.SelectedItem.ToString() == "Electronics")
            {
                FileStream electronicsFile = new FileStream("Electronics.txt", FileMode.Append);
                BinaryFormatter formatter = new BinaryFormatter();
                ItemsDetails Item = new ItemsDetails(Product_ID, Product_Name, Price, Product_Description, category, Product_brand, Availibility,  Quantity, productImages);
                formatter.Serialize(electronicsFile, Item);
                electronicsFile.Close();
            }
            else if (CategoryCB.SelectedItem.ToString() == "Beauty Products")
            {
                FileStream beautyproductsFile = new FileStream("Beauty Products.txt", FileMode.Append);
                BinaryFormatter formatter = new BinaryFormatter();
                ItemsDetails Item = new ItemsDetails(Product_ID, Product_Name, Price, Product_Description, category, Product_brand, Availibility, Quantity, productImages);
                formatter.Serialize(beautyproductsFile, Item);
                beautyproductsFile.Close();
            }
            else if (CategoryCB.SelectedItem.ToString() == "Appliances")
            {
                FileStream appliancesFile = new FileStream("Appliances.txt", FileMode.Append);
                BinaryFormatter formatter = new BinaryFormatter();
                ItemsDetails Item = new ItemsDetails(Product_ID, Product_Name, Price, Product_Description, category, Product_brand, Availibility,  Quantity, productImages);
                formatter.Serialize(appliancesFile, Item);
                appliancesFile.Close();
            }
            else if (CategoryCB.SelectedItem.ToString() == "Furniture")
            {
                FileStream FurnitureFile = new FileStream("Furniture.txt", FileMode.Append);
                BinaryFormatter formatter = new BinaryFormatter();
                ItemsDetails Item = new ItemsDetails(Product_ID, Product_Name, Price,Product_Description, category, Product_brand, Availibility,Quantity, productImages);
                formatter.Serialize(FurnitureFile, Item);
                FurnitureFile.Close();
            }
            

             MessageBox.Show("Successfully added ! ");
           
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

        private void AddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "image files (* .jpp; * .jpeg; * .gif; * .bmp ; * .png;)| * .jpp; * .jpeg; * .gif; * .bmp; * .png;* .jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void BackTB_Click(object sender, EventArgs e)
        {
            MyAccountTabControl.SelectedTab = OwnerTab;
           
        }

        private void bunifuCustomTextbox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow newDatarow = dataGridView3.Rows[indexRow];
            newDatarow.Cells[1].Value = NameUP.Text ;
            newDatarow.Cells[3].Value = PriceUP.Text ;
            newDatarow.Cells[4].Value = DescriptionUP.Text;
            newDatarow.Cells[6].Value= BrandUP.Text ;
            newDatarow.Cells[8].Value = QuantityUP.Value ;

            if (AvailableUP.Checked)
            {
                newDatarow.Cells[7].Value = "Available";
               
            }
            else if (NotAvailableUP.Checked)
            {
                newDatarow.Cells[7].Value = "Not Available";
                
            }

            string p_name = "";
            string p_id = "";
            string p_price = "";
            string p_descrip = "";
            string p_category = "";
            string p_brand = "";
            string p_avail = "";
            int p_quan = 0;
            Image p_image;
            List<ItemsDetails> IDET = new List<ItemsDetails>();
            string chosen_category = choose_CB.SelectedItem.ToString();
            if (chosen_category == "Smart Phones")
            {

                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {

                    p_id = dataGridView3.Rows[i].Cells[2].Value.ToString();
                    p_name = dataGridView3.Rows[i].Cells[1].Value.ToString();
                    p_price = dataGridView3.Rows[i].Cells[3].Value.ToString();
                    p_descrip = dataGridView3.Rows[i].Cells[4].Value.ToString();
                    p_category = dataGridView3.Rows[i].Cells[5].Value.ToString();
                    p_brand = dataGridView3.Rows[i].Cells[6].Value.ToString();
                    p_avail = dataGridView3.Rows[i].Cells[7].Value.ToString();
                    p_quan = Convert.ToInt32(dataGridView3.Rows[i].Cells[8].Value);
                    p_image = (Image)dataGridView3.Rows[i].Cells[0].Value;

                    ItemsDetails new_item = new ItemsDetails(p_id, p_name, p_price, p_descrip, p_category, p_brand, p_avail, p_quan, p_image);
                    IDET.Add(new_item);
                }

                FileStream SmartPhonesFile1 = new FileStream("Smart Phones.txt", FileMode.Truncate);
                SmartPhonesFile1.Close();
                FileStream SmartPhonesFile2 = new FileStream("Smart Phones.txt", FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();

                for (int i = 0; i < IDET.Count; i++)
                {
                    bf.Serialize(SmartPhonesFile2, IDET[i]);
                }
                SmartPhonesFile2.Close();

            }

            else if (chosen_category == "Fashion")
            {

                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {

                    p_id = dataGridView3.Rows[i].Cells[2].Value.ToString();
                    p_name = dataGridView3.Rows[i].Cells[1].Value.ToString();
                    p_price = dataGridView3.Rows[i].Cells[3].Value.ToString();
                    p_descrip = dataGridView3.Rows[i].Cells[4].Value.ToString();
                    p_category = dataGridView3.Rows[i].Cells[5].Value.ToString();
                    p_brand = dataGridView3.Rows[i].Cells[6].Value.ToString();
                    p_avail = dataGridView3.Rows[i].Cells[7].Value.ToString();
                    p_quan = Convert.ToInt32(dataGridView3.Rows[i].Cells[8].Value);
                    p_image = (Image)dataGridView3.Rows[i].Cells[0].Value;

                    ItemsDetails new_item = new ItemsDetails(p_id, p_name, p_price, p_descrip, p_category, p_brand, p_avail, p_quan, p_image);
                    IDET.Add(new_item);
                }

                FileStream FashionFile1 = new FileStream("Fashion.txt", FileMode.Truncate);
                FashionFile1.Close();
                FileStream FashionFile2 = new FileStream("Fashion.txt", FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();

                for (int i = 0; i < IDET.Count; i++)
                {
                    bf.Serialize(FashionFile2, IDET[i]);
                }
                FashionFile2.Close();
            }
            else if (chosen_category == "Electronics")
            {

                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {

                    p_id = dataGridView3.Rows[i].Cells[2].Value.ToString();
                    p_name = dataGridView3.Rows[i].Cells[1].Value.ToString();
                    p_price = dataGridView3.Rows[i].Cells[3].Value.ToString();
                    p_descrip = dataGridView3.Rows[i].Cells[4].Value.ToString();
                    p_category = dataGridView3.Rows[i].Cells[5].Value.ToString();
                    p_brand = dataGridView3.Rows[i].Cells[6].Value.ToString();
                    p_avail = dataGridView3.Rows[i].Cells[7].Value.ToString();
                    p_quan = Convert.ToInt32(dataGridView3.Rows[i].Cells[8].Value);
                    p_image = (Image)dataGridView3.Rows[i].Cells[0].Value;

                    ItemsDetails new_item = new ItemsDetails(p_id, p_name, p_price, p_descrip, p_category, p_brand, p_avail, p_quan, p_image);
                    IDET.Add(new_item);
                }

                FileStream ElectronicsFile1 = new FileStream("Electronics.txt", FileMode.Truncate);
                ElectronicsFile1.Close();
                FileStream ElectronicsFile2 = new FileStream("Electronics.txt", FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();
               
                for (int i = 0; i < IDET.Count; i++)
                {
                    bf.Serialize(ElectronicsFile2, IDET[i]);
                }
                ElectronicsFile2.Close();
            }
            else if (chosen_category == "Beauty Products")
            {

                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {

                    p_id = dataGridView3.Rows[i].Cells[2].Value.ToString();
                    p_name = dataGridView3.Rows[i].Cells[1].Value.ToString();
                    p_price = dataGridView3.Rows[i].Cells[3].Value.ToString();
                    p_descrip = dataGridView3.Rows[i].Cells[4].Value.ToString();
                    p_category = dataGridView3.Rows[i].Cells[5].Value.ToString();
                    p_brand = dataGridView3.Rows[i].Cells[6].Value.ToString();
                    p_avail = dataGridView3.Rows[i].Cells[7].Value.ToString();
                    p_quan = Convert.ToInt32(dataGridView3.Rows[i].Cells[8].Value);
                    p_image = (Image)dataGridView3.Rows[i].Cells[0].Value;

                    ItemsDetails new_item = new ItemsDetails(p_id, p_name, p_price, p_descrip, p_category, p_brand, p_avail, p_quan, p_image);
                    IDET.Add(new_item);
                }

                FileStream BeautyProductsFile1 = new FileStream("Beauty Products.txt", FileMode.Truncate);
                BeautyProductsFile1.Close();
                FileStream BeautyProductsFile2 = new FileStream("Beauty Products.txt", FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();
              
                for (int i = 0; i < IDET.Count; i++)
                {
                    bf.Serialize(BeautyProductsFile2, IDET[i]);
                }
                BeautyProductsFile2.Close();
            }
            else if (chosen_category == "Appliances")
            {

                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {

                    p_id = dataGridView3.Rows[i].Cells[2].Value.ToString();
                    p_name = dataGridView3.Rows[i].Cells[1].Value.ToString();
                    p_price = dataGridView3.Rows[i].Cells[3].Value.ToString();
                    p_descrip = dataGridView3.Rows[i].Cells[4].Value.ToString();
                    p_category = dataGridView3.Rows[i].Cells[5].Value.ToString();
                    p_brand = dataGridView3.Rows[i].Cells[6].Value.ToString();
                    p_avail = dataGridView3.Rows[i].Cells[7].Value.ToString();
                    p_quan = Convert.ToInt32(dataGridView3.Rows[i].Cells[8].Value);
                    p_image = (Image)dataGridView3.Rows[i].Cells[0].Value;

                    ItemsDetails new_item = new ItemsDetails(p_id, p_name, p_price, p_descrip, p_category, p_brand, p_avail, p_quan, p_image);
                    IDET.Add(new_item);
                }

                FileStream AppliancesFile1 = new FileStream("Appliances.txt", FileMode.Truncate);
                AppliancesFile1.Close();
                FileStream AppliancesFile2 = new FileStream("Appliances.txt", FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();
                
                for (int i = 0; i < IDET.Count; i++)
                {
                    bf.Serialize(AppliancesFile2, IDET[i]);
                }
                AppliancesFile2.Close();
            }
            else if (chosen_category == "Furniture")
            {

                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {

                    p_id = dataGridView3.Rows[i].Cells[2].Value.ToString();
                    p_name = dataGridView3.Rows[i].Cells[1].Value.ToString();
                    p_price = dataGridView3.Rows[i].Cells[3].Value.ToString();
                    p_descrip = dataGridView3.Rows[i].Cells[4].Value.ToString();
                    p_category = dataGridView3.Rows[i].Cells[5].Value.ToString();
                    p_brand = dataGridView3.Rows[i].Cells[6].Value.ToString();
                    p_avail = dataGridView3.Rows[i].Cells[7].Value.ToString();
                    p_quan = Convert.ToInt32(dataGridView3.Rows[i].Cells[8].Value);
                    p_image = (Image)dataGridView3.Rows[i].Cells[0].Value;

                    ItemsDetails new_item = new ItemsDetails(p_id, p_name, p_price, p_descrip, p_category, p_brand, p_avail, p_quan, p_image);
                    IDET.Add(new_item);
                }

                FileStream FurnitureFile1 = new FileStream("Furniture.txt", FileMode.Truncate);
                FurnitureFile1.Close();
                FileStream FurnitureFile2 = new FileStream("Furniture.txt", FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();
             
                for (int i = 0; i < IDET.Count; i++)
                {
                    bf.Serialize(FurnitureFile2, IDET[i]);
                }
                FurnitureFile2.Close();
            }
 
                NameUP.Text = null;
                PriceUP.Text = null;
                DescriptionUP.Text = null;
                BrandUP.Text = null;
                QuantityUP.Value = 1;


        }
        int indexRow;
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView3.Rows[indexRow];
            NameUP.Text = row.Cells[1].Value.ToString();
            PriceUP.Text = row.Cells[3].Value.ToString();
            DescriptionUP.Text = row.Cells[4].Value.ToString();
            BrandUP.Text = row.Cells[6].Value.ToString();
          
            QuantityUP.Value = Convert.ToInt32(row.Cells[8].Value);
           
            if (row.Cells[7].Value.ToString()=="Available")
            {
                
                AvailableUP.Checked=true;
            }
            else if (row.Cells[7].Value.ToString() != "Available")
            {
                NotAvailableUP.Checked = true;
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
           
        }

        private void bunifuThinButton21_Click_2(object sender, EventArgs e)
        {

        }

        private void final_remove_Click(object sender, EventArgs e)
        {
            DataGridViewRow row_delete = dataGridView2.Rows[indexRow];
            string p_name = "";
            string p_id = "";
            string p_price = "";
            string p_descrip = "";
            string p_category = "";
            string p_brand = "";
            string p_avail = "";
            int p_quan = 0;
            Image p_image;
            List<ItemsDetails> IDET = new List<ItemsDetails>();

            if (choose_cat_removecb.SelectedItem.ToString() == "Smart Phones")
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {

                if (i == indexRow)
                {
                    continue;
                }
                    p_id = dataGridView2.Rows[i].Cells[2].Value.ToString();
                    p_name = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    p_price = dataGridView2.Rows[i].Cells[3].Value.ToString();
                    p_descrip = dataGridView2.Rows[i].Cells[4].Value.ToString();
                    p_category = dataGridView2.Rows[i].Cells[5].Value.ToString();
                    p_brand = dataGridView2.Rows[i].Cells[6].Value.ToString();
                    p_avail = dataGridView2.Rows[i].Cells[7].Value.ToString();
                    p_quan = Convert.ToInt32(dataGridView2.Rows[i].Cells[8].Value);
                    p_image = (Image)dataGridView2.Rows[i].Cells[0].Value;

                    ItemsDetails new_item = new ItemsDetails(p_id, p_name, p_price, p_descrip, p_category, p_brand, p_avail, p_quan, p_image);
                    IDET.Add(new_item);
                }

                FileStream SmartPhonesFile1 = new FileStream("Smart Phones.txt", FileMode.Truncate);
                SmartPhonesFile1.Close();
                FileStream SmartPhonesFile2 = new FileStream("Smart Phones.txt", FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();

                for (int i = 0; i < IDET.Count; i++)
                {
                    bf.Serialize(SmartPhonesFile2, IDET[i]);
                }
                dataGridView2.DataSource = IDET;
                dataGridView2.Refresh();
                SmartPhonesFile2.Close();
               
            }

            else if (choose_cat_removecb.SelectedItem.ToString() == "Fashion")
            {

                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    if (i == indexRow)
                    {
                        continue;
                    }

                    p_id = dataGridView2.Rows[i].Cells[2].Value.ToString();
                    p_name = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    p_price = dataGridView2.Rows[i].Cells[3].Value.ToString();
                    p_descrip = dataGridView2.Rows[i].Cells[4].Value.ToString();
                    p_category = dataGridView2.Rows[i].Cells[5].Value.ToString();
                    p_brand = dataGridView2.Rows[i].Cells[6].Value.ToString();
                    p_avail = dataGridView2.Rows[i].Cells[7].Value.ToString();
                    p_quan = Convert.ToInt32(dataGridView2.Rows[i].Cells[8].Value);
                    p_image = (Image)dataGridView2.Rows[i].Cells[0].Value;

                    ItemsDetails new_item = new ItemsDetails(p_id, p_name, p_price, p_descrip, p_category, p_brand, p_avail, p_quan, p_image);
                    IDET.Add(new_item);
                }

                FileStream FashionFile1 = new FileStream("Fashion.txt", FileMode.Truncate);
                FashionFile1.Close();
                FileStream FashionFile2 = new FileStream("Fashion.txt", FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();
          
                for (int i = 0; i < IDET.Count; i++)
                {
                    bf.Serialize(FashionFile2, IDET[i]);
                }
                dataGridView2.DataSource = IDET;
                dataGridView2.Refresh();
                FashionFile2.Close();
            }
            else if (choose_cat_removecb.SelectedItem.ToString() == "Electronics")
            {

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (i == indexRow)
                    {
                        continue;
                    }
                    p_id = dataGridView2.Rows[i].Cells[2].Value.ToString();
                    p_name = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    p_price = dataGridView2.Rows[i].Cells[3].Value.ToString();
                    p_descrip = dataGridView2.Rows[i].Cells[4].Value.ToString();
                    p_category = dataGridView2.Rows[i].Cells[5].Value.ToString();
                    p_brand = dataGridView2.Rows[i].Cells[6].Value.ToString();
                    p_avail = dataGridView2.Rows[i].Cells[7].Value.ToString();
                    p_quan = Convert.ToInt32(dataGridView2.Rows[i].Cells[8].Value);
                    p_image = (Image)dataGridView2.Rows[i].Cells[0].Value;

                    ItemsDetails new_item = new ItemsDetails(p_id, p_name, p_price, p_descrip, p_category, p_brand, p_avail, p_quan, p_image);
                    IDET.Add(new_item);
                }

                FileStream ElectronicsFile1 = new FileStream("Electronics.txt", FileMode.Truncate);
                ElectronicsFile1.Close();
                FileStream ElectronicsFile2 = new FileStream("Electronics.txt", FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();
                for (int i = 0; i < IDET.Count; i++)
                {
                    bf.Serialize(ElectronicsFile2, IDET[i]);
                }
                dataGridView2.DataSource = IDET;
                dataGridView2.Refresh();
                ElectronicsFile2.Close();
            }
            else if (choose_cat_removecb.SelectedItem.ToString() == "Beauty Products")
            {

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (i == indexRow)
                    {
                        continue;
                    }
                    p_id = dataGridView2.Rows[i].Cells[2].Value.ToString();
                    p_name = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    p_price = dataGridView2.Rows[i].Cells[3].Value.ToString();
                    p_descrip = dataGridView2.Rows[i].Cells[4].Value.ToString();
                    p_category = dataGridView2.Rows[i].Cells[5].Value.ToString();
                    p_brand = dataGridView2.Rows[i].Cells[6].Value.ToString();
                    p_avail = dataGridView2.Rows[i].Cells[7].Value.ToString();
                    p_quan = Convert.ToInt32(dataGridView2.Rows[i].Cells[8].Value);
                    p_image = (Image)dataGridView2.Rows[i].Cells[0].Value;

                    ItemsDetails new_item = new ItemsDetails(p_id, p_name, p_price, p_descrip, p_category, p_brand, p_avail, p_quan, p_image);
                    IDET.Add(new_item);
                }

                FileStream BeautyProductsFile1 = new FileStream("Beauty Products.txt", FileMode.Truncate);
                BeautyProductsFile1.Close();
                FileStream BeautyProductsFile2 = new FileStream("Beauty Products.txt", FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();
                
                for (int i = 0; i < IDET.Count; i++)
                {
                    bf.Serialize(BeautyProductsFile2, IDET[i]);
                }
                dataGridView2.DataSource = IDET;
                dataGridView2.Refresh();
                BeautyProductsFile2.Close();
            }
            else if (choose_cat_removecb.SelectedItem.ToString() == "Appliances")
            {

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (i == indexRow)
                    {
                        continue;
                    }

                    p_id = dataGridView2.Rows[i].Cells[2].Value.ToString();
                    p_name = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    p_price = dataGridView2.Rows[i].Cells[3].Value.ToString();
                    p_descrip = dataGridView2.Rows[i].Cells[4].Value.ToString();
                    p_category = dataGridView2.Rows[i].Cells[5].Value.ToString();
                    p_brand = dataGridView2.Rows[i].Cells[6].Value.ToString();
                    p_avail = dataGridView2.Rows[i].Cells[7].Value.ToString();
                    p_quan = Convert.ToInt32(dataGridView2.Rows[i].Cells[8].Value);
                    p_image = (Image)dataGridView2.Rows[i].Cells[0].Value;

                    ItemsDetails new_item = new ItemsDetails(p_id, p_name, p_price, p_descrip, p_category, p_brand, p_avail, p_quan, p_image);
                    IDET.Add(new_item);
                }

                FileStream AppliancesFile1 = new FileStream("Appliances.txt", FileMode.Truncate);
                AppliancesFile1.Close();
                FileStream AppliancesFile2 = new FileStream("Appliances.txt", FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();
                
                for (int i = 0; i < IDET.Count; i++)
                {
                    bf.Serialize(AppliancesFile2, IDET[i]);
                }
                dataGridView2.DataSource = IDET;
                dataGridView2.Refresh();
                AppliancesFile2.Close();
            }
            else if (choose_cat_removecb.SelectedItem.ToString() == "Furniture")
            {

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (i == indexRow)
                    {
                        continue;
                    }
                    p_id = dataGridView2.Rows[i].Cells[2].Value.ToString();
                    p_name = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    p_price = dataGridView2.Rows[i].Cells[3].Value.ToString();
                    p_descrip = dataGridView2.Rows[i].Cells[4].Value.ToString();
                    p_category = dataGridView2.Rows[i].Cells[5].Value.ToString();
                    p_brand = dataGridView2.Rows[i].Cells[6].Value.ToString();
                    p_avail = dataGridView2.Rows[i].Cells[7].Value.ToString();
                    p_quan = Convert.ToInt32(dataGridView2.Rows[i].Cells[8].Value);
                    p_image = (Image)dataGridView2.Rows[i].Cells[0].Value;

                    ItemsDetails new_item = new ItemsDetails(p_id, p_name, p_price, p_descrip, p_category, p_brand, p_avail, p_quan, p_image);
                    IDET.Add(new_item);
                }

                FileStream FurnitureFile1 = new FileStream("Furniture.txt", FileMode.Truncate);
                FurnitureFile1.Close();
                FileStream FurnitureFile2 = new FileStream("Furniture.txt", FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();
                
                for (int i = 0; i < IDET.Count; i++)
                {
                    bf.Serialize(FurnitureFile2, IDET[i]);
                }
                dataGridView2.DataSource = IDET;
                dataGridView2.Refresh();
                FurnitureFile2.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_up_Click(object sender, EventArgs e)
        {
            MyAccountTabControl.SelectedTab = OwnerTab;
        }

        private void back_rem_Click(object sender, EventArgs e)
        {
            MyAccountTabControl.SelectedTab = OwnerTab;
        }

        private void back_view_Click(object sender, EventArgs e)
        {
            MyAccountTabControl.SelectedTab = OwnerTab;
        }

        private void choose_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

     
        private void Load_Cat_Click(object sender, EventArgs e)
        {
            if (choose_CB.SelectedItem.ToString() == "Smart Phones")
            {
                string filename = "Smart Phones.txt";
                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                ItemsDetails obj = new ItemsDetails();
                Items_Details = obj.load(filename);
                dataGridView3.DataSource = Items_Details;
            }
            else if (choose_CB.SelectedItem.ToString() == "Fashion")
            {
               
                string filename = "Fashion.txt";
                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                ItemsDetails obj = new ItemsDetails();
                Items_Details = obj.load(filename);
                dataGridView3.DataSource = Items_Details;
            }
            else if (choose_CB.SelectedItem.ToString() == "Electronics")
            {
               
                string filename = "Electronics.txt";
                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                ItemsDetails obj = new ItemsDetails();
                Items_Details = obj.load(filename);
                dataGridView3.DataSource = Items_Details;
            }
            else if (choose_CB.SelectedItem.ToString() == "Beauty Products")
            {
               
                string filename = "Beauty Products.txt";
                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                ItemsDetails obj = new ItemsDetails();
                Items_Details = obj.load(filename);
                dataGridView3.DataSource = Items_Details;
            }
            else if (choose_CB.SelectedItem.ToString() == "Appliances")
            {
               
                string filename = "Appliances.txt";
                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                ItemsDetails obj = new ItemsDetails();
                Items_Details = obj.load(filename);
                dataGridView3.DataSource = Items_Details;
            }
            else if (choose_CB.SelectedItem.ToString() == "Furniture")
            {
                
                string filename = "Furniture.txt";
                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                ItemsDetails obj = new ItemsDetails();
                Items_Details = obj.load(filename);
                dataGridView3.DataSource = Items_Details;
            }
        }

        private void load_view_Click(object sender, EventArgs e)
        {
            if (choose_cat_viewcb.SelectedItem.ToString() == "Smart Phones")
            {
                string filename = "Smart Phones.txt";
                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                ItemsDetails obj = new ItemsDetails();
                Items_Details = obj.load(filename);
                dataGridView1.DataSource = Items_Details;
            }
            else if (choose_cat_viewcb.SelectedItem.ToString() == "Fashion")
            {
                string filename = "Fashion.txt";
                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                ItemsDetails obj = new ItemsDetails();
                Items_Details = obj.load(filename);
                dataGridView1.DataSource = Items_Details;
            }
            else if (choose_cat_viewcb.SelectedItem.ToString() == "Electronics")
            {  //Electronics.txt
                string filename = "Electronics.txt";
                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                ItemsDetails obj = new ItemsDetails();
                Items_Details = obj.load(filename);
                dataGridView1.DataSource = Items_Details;
            }
            else if (choose_cat_viewcb.SelectedItem.ToString() == "Beauty Products")
            {  //Beauty Products.txt
                string filename = "Beauty Products.txt";
                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                ItemsDetails obj = new ItemsDetails();
                Items_Details = obj.load(filename);
                dataGridView1.DataSource = Items_Details;
            }
            else if (choose_cat_viewcb.SelectedItem.ToString() == "Appliances")
            {//Appliances.txt
                string filename = "Appliances.txt";
                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                ItemsDetails obj = new ItemsDetails();
                Items_Details = obj.load(filename);
                dataGridView1.DataSource = Items_Details;
            }
            else if (choose_cat_viewcb.SelectedItem.ToString() == "Furniture")
            {  //Furniture.txt
                string filename = "Furniture.txt";
                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                ItemsDetails obj = new ItemsDetails();
                Items_Details = obj.load(filename);
                dataGridView1.DataSource = Items_Details;
            }

        }

        private void load_removebtn_Click(object sender, EventArgs e)
        {
            if (choose_cat_removecb.SelectedItem.ToString() == "Smart Phones")
            {
                string filename = "Smart Phones.txt";
                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                ItemsDetails obj = new ItemsDetails();
                Items_Details = obj.load(filename);
                dataGridView2.DataSource = Items_Details;
            }
            else if (choose_cat_removecb.SelectedItem.ToString() == "Fashion")
            {
                string filename = "Fashion.txt";
                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                ItemsDetails obj = new ItemsDetails();
                Items_Details = obj.load(filename);
                dataGridView2.DataSource = Items_Details;
            }
            else if (choose_cat_removecb.SelectedItem.ToString() == "Electronics")
            {  //Electronics.txt
                string filename = "Electronics.txt";
                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                ItemsDetails obj = new ItemsDetails();
                Items_Details = obj.load(filename);
                dataGridView2.DataSource = Items_Details;
            }
            else if (choose_cat_removecb.SelectedItem.ToString() == "Beauty Products")
            {  //Beauty Products.txt
                string filename = "Beauty Products.txt";
                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                ItemsDetails obj = new ItemsDetails();
                Items_Details = obj.load(filename);
                dataGridView2.DataSource = Items_Details;
            }
            else if (choose_cat_removecb.SelectedItem.ToString() == "Appliances")
            {//Appliances.txt
                string filename = "Appliances.txt";
                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                ItemsDetails obj = new ItemsDetails();
                Items_Details = obj.load(filename);
                dataGridView2.DataSource = Items_Details;
            }
            else if (choose_cat_removecb.SelectedItem.ToString() == "Furniture")
            {  //Furniture.txt
                string filename = "Furniture.txt";
                List<ItemsDetails> Items_Details = new List<ItemsDetails>();
                ItemsDetails obj = new ItemsDetails();
                Items_Details = obj.load(filename);
                dataGridView2.DataSource = Items_Details;
            }
        }
    }
    
}
