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
        public int FinishedWaitTime { get; set; }
        public double TotalPrice { get; set; }

        public System.Windows.Forms.ListView lvOrder { get; set; }
        public System.Windows.Forms.ListViewItem footer { get; set; }
        public Order()  //< - Must receive a list od product rows, will remain empty until guest making order done
        {

            foreach (ProductRow row in productRow)
            {
                TotalPrice += row.quantity * row.product.price;
            }   //Setting total price to be paid on the order


            footer = new System.Windows.Forms.ListViewItem($"Pending: {TotalWaitTime} sec");
            footer.SubItems.Add("");
            footer.SubItems.Add("");
            footer.SubItems.Add($"Total: {TotalPrice} $");

            productRow.Add(new ProductRow(new Product("Apple", 25), 5, "Nothing really"));
            productRow.Add(new ProductRow(new Product("Jajce", 15), 87, "Ohne Zwiebeln"));
            productRow.Add(new ProductRow(new Product("Kaopeira", 13.4), 11, "MAndoera"));
            productRow.Add(new ProductRow(new Product("Zehneins", 12), 2, "add sauce"));
        }

    }
}
