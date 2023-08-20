﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBarOrderingSystem
{
    public class Product
    {
        public string name { get; set; }
        public double price { get; set; }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   name == product.name;
        }

        public override int GetHashCode()
        {
            int hashCode = 552537344;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + price.GetHashCode();
            return hashCode;
        }
    }
}
