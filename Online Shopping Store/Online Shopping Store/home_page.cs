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
        public products_show ps;
   
        public home_page()
        {
            InitializeComponent();
        }

        //public home_page( products_show p)
        //{
        //    InitializeComponent();
        //    this.ps = p;
        //}

        private void furniture_btn_Click(object sender, EventArgs e)
        {
            ps = new products_show();
           
            ps.tabControl1.SelectedIndex =2;
            ps.Show();
        }

        private void showCart_MenuOption_Click(object sender, EventArgs e)
        {
            string filename = "instructions.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void beauty_btn_Click(object sender, EventArgs e)
        {
            ps = new products_show();
  
            ps.tabControl1.SelectedIndex = 3;
            ps.Show();
        }

        private void mobile_btn_Click(object sender, EventArgs e)
        {
            ps = new products_show();

            Form fc = Application.OpenForms["products_show"];

            if (fc != null)
            {
                ps.tabControl1.SelectedIndex = 0;
                ps.Refresh();
            }
            else
            {
                ps.tabControl1.SelectedIndex = 0;
                ps.Show();
            }

            //ps.tabControl1.SelectedIndex = 0;
            //ps.Show();
        }

        private void fashion_btn_Click(object sender, EventArgs e)
        {
            ps = new products_show();

            Form fc = Application.OpenForms["products_show"];

            if (fc != null)
            {
                ps.tabControl1.SelectedIndex = 4;
                ps.Activate();
            }
            else
            {
                ps.tabControl1.SelectedIndex = 4;
                ps.Show();
            }

            //if (ps == null || ps.IsOpen == false)
            //{
            //    ps = new products_show(this);
            //    ps.Show();
            //    ps.IsOpen = true;
            //}
            //else
            //{
            //    ps.Activate();
            //    ps.WindowState = FormWindowState.Normal;
            //}


            //ps.tabControl1.SelectedIndex = 4;
            //ps.Show();
        }

        private void electronics_btn_Click(object sender, EventArgs e)
        {
            ps = new products_show();
            ps.tabControl1.SelectedIndex = 5;
            ps.Show();
        }

        private void appliances_btn_Click(object sender, EventArgs e)
        {
            ps = new products_show();
           
            ps.tabControl1.SelectedIndex = 1;
            ps.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            incs log = new incs();
            this.Hide();
            log.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showItem_MenuItem_Click(object sender, EventArgs e)
        {
            products_show cart = new products_show();
            //this.Hide();
            cart.tabControl1.SelectedTab = cart.cart_tab;
            cart.ShowDialog();
            //this.Close();
        }
    }
}
