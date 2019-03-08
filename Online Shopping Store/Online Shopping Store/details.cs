using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Online_Shopping_Store
{
    public partial class details : UserControl
    {
        public List<string> CartList = new List<string>();
        public Cart_items newItem;
        public LinkedList<Cart_items> cartLinkedList = new LinkedList<Cart_items>();
        public LinkedListNode<Cart_items> itemNode;
        products_show ps = new products_show();

        public details(string name, string id, string price, Image pic,string description, string brand, products_show form)
        {
            InitializeComponent();
            namelabel.Text = name;
            idllabel.Text = id;
            pricelabel.Text = price;
            pictureBox1.Image = pic;
            Desc_textbox.Text = description;
            brandLabel.Text = brand;
            this.ps = form;
        }
        public details(string name, string id, string price, Image pic, string description, string brand)
        {
            InitializeComponent();
            namelabel.Text = name;
            idllabel.Text = id;
            pricelabel.Text = price;
            pictureBox1.Image = pic;
            Desc_textbox.Text = description;
            brandLabel.Text = brand;
           
        }

        public details()
        {
            InitializeComponent();
        }

        private void Buy_Cart_Click(object sender, EventArgs e)
        {
            CartList.Add(idllabel.Text);
            CartList.Add(namelabel.Text);
            CartList.Add(brandLabel.Text);
            CartList.Add(pricelabel.Text);
            CartList.Add(numericUpDown1.Value.ToString());
                

            newItem = new Cart_items(CartList[0], CartList[1], CartList[2], CartList[3]);
            cartLinkedList.AddLast(newItem);
            ps.cart_flowLayoutPanel.Controls.Add(newItem);

            //my code to save in file then recipet
            string name=CartList[1];
            string id=CartList[0];
            string brand=CartList[2];
            string price=CartList[3];
            string pro_num=CartList[4];
            FileStream put_BuyNow = new FileStream("BuyNow.txt", FileMode.Append);
            BinaryFormatter formatter = new BinaryFormatter();
            BuyNow BN = new BuyNow(id, name, brand, price, pro_num);
            formatter.Serialize(put_BuyNow, BN);
            put_BuyNow.Close();



        }

        private void panel_usercontrol_product_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
