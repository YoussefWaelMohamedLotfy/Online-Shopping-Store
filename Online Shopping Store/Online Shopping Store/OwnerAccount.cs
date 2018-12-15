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
            FileStream fs = new FileStream("Products.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<ItemsDetails> Items_Details = new List<ItemsDetails>();
            while (fs.Position != fs.Length)
            {
                ItemsDetails its = (ItemsDetails)bf.Deserialize(fs);
                Items_Details.Add(its);
            }
            dataGridView1.DataSource = Items_Details;
            fs.Close();

        }

        private void RemoveTB_Click(object sender, EventArgs e)
        {
            MyAccountTabControl.SelectedTab = RemoveTab;
            FileStream fs = new FileStream("Products.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<ItemsDetails> Items_Details = new List<ItemsDetails>();
            while (fs.Position != fs.Length)
            {
                ItemsDetails its = (ItemsDetails)bf.Deserialize(fs);
                Items_Details.Add(its);
            }
            dataGridView2.DataSource = Items_Details;
            fs.Close();
           

        }

        private void AddProductTB_Click_1(object sender, EventArgs e)
        {
            MyAccountTabControl.SelectedTab = AddTab;

        }

        private void UpdateTB_Click(object sender, EventArgs e)
        {
            MyAccountTabControl.SelectedTab = UpdateTab;
            FileStream fs = new FileStream("Products.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<ItemsDetails> Items_Details = new List<ItemsDetails>();
            while (fs.Position != fs.Length)
            {
                ItemsDetails its = (ItemsDetails)bf.Deserialize(fs);
                Items_Details.Add(its);
            }
            dataGridView3.DataSource = Items_Details;

            fs.Close();

        }

        private void CancelTB_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
                Image productImages = pictureBox1.Image;
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
                     
                ItemsDetails Item = new ItemsDetails(Product_ID, Product_Name, Price, Size, Product_Description, category, Product_brand, Availibility, color, Quantity, productImages);
                formatter.Serialize(fs, Item);
                MessageBox.Show("Successfully added ! ");
                fs.Close();
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
            this.Close();
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
            // SizeUP.SelectedItem = row.Cells[].Value.ToString();
            newDatarow.Cells[8].Value = QuantityUP.Value ;

            if (AvailableUP.Checked)
            {
                newDatarow.Cells[7].Value = "Available";
               
            }
            else if (NotAvailableUP.Checked)
            {
                newDatarow.Cells[7].Value = "Not Available";
                
            }


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
            // SizeUP.SelectedItem = row.Cells[].Value.ToString();
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
            //DataGridViewRow row_to_be_del = dataGridView3.Rows[indexRow];
            

        }

        private void bunifuThinButton21_Click_2(object sender, EventArgs e)
        {

        }

        private void final_remove_Click(object sender, EventArgs e)
        {
            DataGridViewRow row_delete = dataGridView2.Rows[indexRow];
            //foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            //{
            //    dataGridView2.Rows.RemoveAt(item.Index);
            //}
            //this.dataGridView2.Rows.RemoveAt(this.dataGridView2.CurrentRow.Index);
            //dataGridView2.Rows.Remove(row_delete);
            //dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[indexRow].Index);
        }
    }
}
