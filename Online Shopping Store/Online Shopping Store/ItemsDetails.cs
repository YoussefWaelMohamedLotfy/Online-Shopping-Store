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
        
        public Image productImages { get; set; }
        public string Product_Name { get; set; }
        public string Product_ID { get; set; }
        public string Price { get; set; }
        public List<string> Size { get; set; }
        public string Product_Description { get; set; }
        public string category { get; set; }
        public string Product_brand { get; set; }
        public string Availibility { get; set; }
        public List<string> color { get; set; }
        public int Quantity { get; set; }

        public ItemsDetails(string PRODUCT_ID, string product_name, string price, List<string> size, string description, string Category, string brand, string availible, List<string> color, int quantity,Image picture)
    {
        this.productImages = picture;
        this.Product_ID = PRODUCT_ID;
        this.Product_Name = product_name;
        this.Price = price;
        this.Size = size;
        this.Product_Description = description;
        this.category = Category;
        this.Product_brand = brand;
        this.Availibility = availible;
        this.color = color;
        this.Quantity = quantity;
    }
  }
}
