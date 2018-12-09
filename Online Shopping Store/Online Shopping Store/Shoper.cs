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

    class Shoper
    {
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Shoper(string name, string address, string city, string country, string phone, string email, string password)
        {
            this.name = name;
            this.address = address;
            this.city = city;
            this.country = country;
            this.phone = phone;
            this.email = email;
            this.password = password;
        }


    }
}
