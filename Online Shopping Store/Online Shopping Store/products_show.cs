using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Online_Shopping_Store
{
    public partial class products_show : Form
    {
        public products_show()
        {
            InitializeComponent();
        }

        private void products_show_Load(object sender, EventArgs e)
        {

            FileStream product_file_open = new FileStream("Product.txt", FileMode.Open);
            BinaryFormatter Formatter = new BinaryFormatter();
            LinkedList<Product> PR = new LinkedList<Product>();
            while (product_file_open.Position != product_file_open.Length)
            {
                Product PP = (Product)Formatter.Deserialize(product_file_open);
                PR.AddFirst(PP);
            }
            product_file_open.Close();
            MessageBox.Show("num:" + PR.Count);
            UserControl UC;
            for (int I = 0; I < 10; I++)
            {
                UC = new UserControl();
                productsDisplay_FlowLayoutPanel.Controls.Add(UC);
            }
        }
    }
}
