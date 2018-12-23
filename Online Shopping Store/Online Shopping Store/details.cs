using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Media.Imaging.BitmapImage;

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
        public static home_page home = new home_page();
        products_show ps = new products_show(home);

        public details(String name, String id, String price, Image pic,string description, string brand, products_show form)
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

        private void but_readmore_Click(object sender, EventArgs e)
        {
            ViewProductDetails details = new ViewProductDetails();
            details.Show();
        }

        private void Buy_Cart_Click(object sender, EventArgs e)
        {
            CartList.Add(namelabel.Text);
            CartList.Add(idllabel.Text);
            CartList.Add(brandLabel.Text);
            CartList.Add(pricelabel.Text);

            newItem = new Cart_items(CartList[0], CartList[1], CartList[2], CartList[3]);
            itemNode = new LinkedListNode<Cart_items>(newItem);
            cartLinkedList.AddLast(itemNode);
            ps.cart_flowLayoutPanel.Controls.Add(newItem);
        }
    }
}
