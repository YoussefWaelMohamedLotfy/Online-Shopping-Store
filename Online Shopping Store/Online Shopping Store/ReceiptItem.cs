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
        ReceiptItem receiptItem = new ReceiptItem();

        public ReceiptItem()
        {
            InitializeComponent();
            
            try
            {
                name_receiptLabel.Text = item.CartList[0];
                price_receiptLabel.Text = item.CartList[3];
                number_receiptLabel.Text = cart.itemsNumberCounter.ToString();
                totalItemsPrice_receiptLabel.Text = (cart.itemsNumberCounter.Value * Convert.ToInt32(price_receiptLabel.Text)).ToString();
            }
            catch(Exception e)
            {
                details Cart = new details();

                for (int i = 0; i < Cart.cartLinkedList.Count; i++)
                {
                    //receiptItem = new ReceiptItem();
                    name_receiptLabel.Text = item.CartList[0];
                    price_receiptLabel.Text = item.CartList[3];
                    number_receiptLabel.Text = cart.itemsNumberCounter.ToString();
                    totalItemsPrice_receiptLabel.Text = (cart.itemsNumberCounter.Value * Convert.ToInt32(price_receiptLabel.Text)).ToString();
                    ps.receipt_flowLayoutPanel.Controls.Add(receiptItem);
                    
                }

            }

        }
    }
}
