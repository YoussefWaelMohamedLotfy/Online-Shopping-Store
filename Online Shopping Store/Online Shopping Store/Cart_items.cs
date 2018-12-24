using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Shopping_Store
{
    public partial class Cart_items : UserControl
    {
        details item;
        //static home_page home = new home_page();
        products_show products_Show = new products_show();

        public Cart_items(string name, string id, string brand, string price)
        {
            InitializeComponent();

            namelabel.Text = name;
            idlabel.Text = id;
            brandLabel.Text = brand;
            pricelabel.Text = price;
            //this.d = form;
        }

        public Cart_items(string name, string id, string brand, string price, Image pic, string desc, products_show form)
        {
            InitializeComponent();

            namelabel.Text = name;
            idlabel.Text = id;
            brandLabel.Text = brand;
            pricelabel.Text = price;

            item = new details(name, id, price, pic, desc, brand, products_Show);
        }

        public Cart_items()
        {
            InitializeComponent();
        }

        private void Cancel_but_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            item.cartLinkedList.Remove(item.itemNode);
        }
    }
}
