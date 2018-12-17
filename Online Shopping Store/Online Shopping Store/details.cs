using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Media.Imaging.BitmapImage;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Online_Shopping_Store
{
    public partial class details : UserControl
    {

        public details(String name, String id, String price, Image pic,string description, string brand)
        {
            InitializeComponent();
            namelabel.Text = name;
            idllabel.Text = id;
            pricelabel.Text = price;
            pictureBox1.Image = pic;
            Desc_textbox.Text = description;
            brandLabel.Text = brand;

        }

        private void but_readmore_Click(object sender, EventArgs e)
        {
            ViewProductDetails details = new ViewProductDetails();
            details.Show();
        }

        private void panel_usercontrol_product_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Buy_Cart_Click(object sender, EventArgs e)
        {
            List<string> CarList = new List<string>();
            CarList.Add(namelabel.Text);
            CarList.Add(idllabel.Text);
            CarList.Add(pricelabel.Text);
            CarList.Add(brandLabel.Text);

            // {
            MessageBox.Show(CarList[0]);
            //}
        }
    }
}
