using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBarOrderingSystem
{
    public class ProductRow
    {
        public Product product;
        public int quantity;
        public string description;

        public ProductRow(Product product, int quantity, string description)
        {
            this.product = product;
            this.quantity = quantity;
            this.description = description;
        }

        public override string ToString()
        {
            return $"{product.ToString()}\t{quantity}\n{description}\n";
        }
    }
}
