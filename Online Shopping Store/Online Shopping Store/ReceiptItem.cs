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
    public partial class ReceiptItem : UserControl
    {
        static home_page home = new home_page();
        products_show ps = new products_show(home);
        details item;

        //string name = item

        public ReceiptItem(string name, int price, int number, string id, string desc, string brand, Image picture, products_show form)
        {
            InitializeComponent();

            item = new details(name, id, price.ToString(), picture, desc, brand, form);

            name_receiptLabel.Text = name;
            price_receiptLabel.Text = price.ToString();
            number_receiptLabel.Text = number.ToString();

            int totalOfItem = price * number;
            totalItemsPrice_receiptLabel.Text = totalOfItem.ToString();

        }
    }
}
