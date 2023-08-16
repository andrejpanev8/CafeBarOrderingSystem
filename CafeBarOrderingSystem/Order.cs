using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBarOrderingSystem
{
    public class Order
    {
        public List<ProductRow> productRow = new List<ProductRow>();
        public int TotalWaitTime { get; set; }
        public double TotalPrice { get; set; }
        public Order()
        {
            //Nothing really necessary in constructor
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Products:");
            foreach (ProductRow row in productRow)
            {
                sb.AppendLine($"- {row}");
            }

            sb.AppendLine($"Total Wait Time: {TotalWaitTime}");
            sb.AppendLine($"Total Price: {TotalPrice:C}"); // Format as currency

            return sb.ToString();
        }

    }
}
