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
        public string Product_Name;
        public string Product_ID;
        public string Price;
        public List<string> Size;
        public string Product_Description;
        public string category;
        public string Product_brand;
        public string Availibility;
        public List<string> color;
        public int Quantity;

    public ItemsDetails(string PRODUCT_ID, string product_name, string price, List<string> size, string description, string Category, string brand, string availible, List<string> color, int quantity)
    {
        this.Product_ID = PRODUCT_ID;
        this.Product_Name = product_name;
        this.Price = price;
        this.Size = size;
        this.Product_Description = description;
        this.category = Category;
        this.Product_brand = brand;
        this.Availibility = availible;
        this.color = color;
    }
  }
}
