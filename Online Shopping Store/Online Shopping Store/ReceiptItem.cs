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
        //static home_page home = new home_page();
        products_show ps = new products_show();
        details item = new details();
        Cart_items cart = new Cart_items();

        public ReceiptItem()
        {
            InitializeComponent();
            
            name_receiptLabel.Text = item.CartList[0];
            price_receiptLabel.Text = item.CartList[3];
            number_receiptLabel.Text = cart.itemsNumberCounter.ToString();
            totalItemsPrice_receiptLabel.Text = (cart.itemsNumberCounter.Value * Convert.ToInt32(price_receiptLabel.Text)).ToString();
        }
    }
}
