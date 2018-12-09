using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Online_Shopping_Store
{
    [Serializable]

    class Product
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string ID { get; set; }
        public string Phone { get; set; }
        public string Brand_Name { get; set; }
        public string NumOfPices { get; set; }
        public string Description { get; set; }
        public Product(string name, string price, string id, string phone, string brand_name, string pices, string desc)
        {
            this.Name = name;
            this.Phone = phone;
            this.Price = price;
            this.ID = id;
            this.Brand_Name = brand_name;
            this.Description = desc;
            this.NumOfPices = pices;

        }
    }

}
