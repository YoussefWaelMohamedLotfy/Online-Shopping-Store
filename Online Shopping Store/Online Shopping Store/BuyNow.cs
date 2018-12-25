using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Online_Shopping_Store
{[Serializable]
    public class BuyNow
    {
         public string name;
        public string id;
        public string brand;
        public string price;
        public string product_num;

        public BuyNow(string name, string id,string brand, string price,string product_num)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.brand = brand;
            this.product_num = product_num;
           
        }

    }
}
