using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Online_Shopping_Store
{
    public partial class details : UserControl
    {
        
        public details(String name, String id, String price)
        {
            InitializeComponent();
            namelabel.Text = name;
            idllabel.Text = id;
            pricelabel.Text = price;
           // Bitmap bmp = new Bitmap( System.Reflection.Assembly.GetEntryAssembly(). GetManifestResourceStream("Online_Shopping_Store.Resources.eshtry.png"));

        }
       

    }
}
