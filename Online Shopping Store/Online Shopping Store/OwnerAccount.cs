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
    public partial class OwnerAccount : Form
    {
        public OwnerAccount()
        {
            InitializeComponent();
        }

        private void AddProductTB_Click(object sender, EventArgs e)
        {
            AddProduct AP = new AddProduct();
            AP.Show();
        }

        private void CancelTB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
