using System.Collections.Generic;

namespace CafeBarOrderingSystem
{
    public class Product
    {
        public string name { get; set; }
        public double price { get; set; }
        public string type { get; set; }
        public Product(string name, double price, string type)
        {
            this.name = name;
            this.price = price;
            this.type = type;
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
