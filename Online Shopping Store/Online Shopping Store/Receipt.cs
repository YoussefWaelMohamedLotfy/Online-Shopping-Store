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
    public partial class Receipt : UserControl
    {
        public Receipt(string id,string name,string brand,string price, string num)
        {
            InitializeComponent();
            Idlabel_rec.Text=id;
            namelabel_rec.Text = name;
            Brandlabel_rec.Text = brand;
            Pricelabel_rec.Text = price;
            numlabel_rec.Text = num;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }
    }
}
