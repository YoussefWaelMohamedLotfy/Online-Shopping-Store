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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure you want to Add this Product ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

            }
        }

        private void BackTB_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
