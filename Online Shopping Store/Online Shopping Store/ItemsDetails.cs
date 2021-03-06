﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Online_Shopping_Store
{
    [Serializable]
    class ItemsDetails
   {
        
        public Image productImages { get; set; }
        public string Product_Name { get; set; }
        public string Product_ID { get; set; }
        public string Price { get; set; }
        public string Product_Description { get; set; }
        public string category { get; set; }
        public string Product_brand { get; set; }
        public string Availibility { get; set; }
        public int Quantity { get; set; }

        public ItemsDetails(string PRODUCT_ID, string product_name, string price, string description, string Category, string brand, string availible, int quantity,Image picture)
        {
        this.productImages = picture;
        this.Product_ID = PRODUCT_ID;
        this.Product_Name = product_name;
        this.Price = price;
        this.Product_Description = description;
        this.category = Category;
        this.Product_brand = brand;
        this.Availibility = availible;
        this.Quantity = quantity;
        }
        public ItemsDetails()
        {

        }
        public List<ItemsDetails> load(string filename)
        {
            FileStream File = new FileStream(filename, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            List<ItemsDetails> Items_Details = new List<ItemsDetails>();
            while (File.Position != File.Length)
            {
                ItemsDetails its = (ItemsDetails)formatter.Deserialize(File);
                Items_Details.Add(its);
            }
            
            File.Close();

            return Items_Details;
        }
    }
}
