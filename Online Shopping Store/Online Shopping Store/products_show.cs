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
           // save data in file in object mood 
            FileStream product_file_open = new FileStream("Products.txt", FileMode.Open);
            BinaryFormatter Formatter = new BinaryFormatter();
            LinkedList<ItemsDetails> PR = new LinkedList<ItemsDetails>();
            while (product_file_open.Position != product_file_open.Length)
            {
                ItemsDetails PP = (ItemsDetails)Formatter.Deserialize(product_file_open);
                PR.AddFirst(PP);// not important i put it for fun 
               
                name =PP.Product_Name;
                price = PP.Price;
                id = PP.Product_ID;
              
              
                details UC = new details(name, id, price);//user control to send data on it 
                    flowLayoutPanel1.Controls.Add(UC);
              
                
            }  
           
            product_file_open.Close();


            //private void productsDisplay_FlowLayoutPanel_Paint(object sender, PaintEventArgs e)
            //{

            //}

            //private void button1_Click(object sender, EventArgs e)
            //{

        }
    }
}
