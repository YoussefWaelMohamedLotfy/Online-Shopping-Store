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
    public partial class home_page : Form
    {
        products_show ps= new products_show () ;
        public home_page( )
        {
            InitializeComponent();


        }
        public home_page( products_show p)
        {
            InitializeComponent();
            this.ps = p;
         

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void furniture_btn_Click(object sender, EventArgs e)
        {
            ps = new products_show();
            ps.Show();
            ps.tabControl1.SelectedIndex =2;
        }

        private void search_txt_OnTextChange(object sender, EventArgs e)
        {

        }

        private void search_txt_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void home_page_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void showCart_MenuOption_Click(object sender, EventArgs e)
        {
            ReceiptForm cart = new ReceiptForm();
            cart.Show();
        }

        private void beauty_btn_Click(object sender, EventArgs e)
        {
            ps = new products_show();
            ps.Show();
            ps.tabControl1.SelectedIndex = 5;
        }

        private void mobile_btn_Click(object sender, EventArgs e)
        {
            ps = new products_show();
            ps.Show();
            ps.tabControl1.SelectedIndex = 0;

        }

        private void homePage_menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fashion_btn_Click(object sender, EventArgs e)
        {
            ps = new products_show();
            ps.Show();
            ps.tabControl1.SelectedIndex = 1;
        }

        private void electronics_btn_Click(object sender, EventArgs e)
        {
            ps = new products_show();
            ps.Show();
            ps.tabControl1.SelectedIndex = 3;
        }

        private void appliances_btn_Click(object sender, EventArgs e)
        {
            ps = new products_show();
            ps.Show();
            ps.tabControl1.SelectedIndex = 4;
        }
    }
}
