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
        public Cart_items(string name, string id, string brand, string price)
        {
            InitializeComponent();
            namelabel.Text = name;
            idlabel.Text = id;
            brandLabel.Text = brand;
            pricelabel.Text = price;
        }

        private void Cancel_but_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this);
        }
    }
}
