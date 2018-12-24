using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Shopping_Store
{
    public partial class ReceiptForm : Form
    {
        Random rand = new Random();
        details productsLinkedList = new details();
        ReceiptItem receiptItem;

        int orderTotal;

        public ReceiptForm()
        {
            InitializeComponent();
            orderTotal = 0;
            shippingFees_label.Text = rand.Next(15, 60).ToString();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            // Show items in cart after confirmation
            for (int i = 0; i < productsLinkedList.cartLinkedList.Count; i++)
            {
                receiptItem = new ReceiptItem();
                //MessageBox.Show(productsLinkedList.CartList[0]);
                receipt_flowLayoutPanel.Controls.Add(receiptItem);
            }



        }

    }
}
