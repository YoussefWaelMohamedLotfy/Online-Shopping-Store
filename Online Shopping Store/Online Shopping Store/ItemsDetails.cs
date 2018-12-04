using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Online_Shopping_Store
{
    [Serializable]
    class ItemsDetails
    {
        public List<Bitmap> productImages = new List<Bitmap>();
        public string productName;
        public string productID;
        public int productNumberOfStockAvailable;
        public int productRating;
        public string productDescription;
        private int productWeight;
        private string productOwnerName;
    }
}
