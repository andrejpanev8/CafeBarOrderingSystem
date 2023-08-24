using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeBarOrderingSystem
{
    public class Order
    {
        public List<ProductRow> productRow = new List<ProductRow>();
        //public int tableNumber { get; set; } - we gonna need this 
        public int TotalWaitTime { get; set; }
        public int FinishedWaitTime { get; set; }
        public double TotalPrice { get; set; }

        public System.Windows.Forms.ListViewItem footer { get; set; }
        public Order()
        {
            footer = new System.Windows.Forms.ListViewItem();
            productRow.Add(new ProductRow(new Product("Apple", 25), 5, "Nothing really"));
            productRow.Add(new ProductRow(new Product("Jajce", 15), 87, "Ohne Zwiebeln"));
            productRow.Add(new ProductRow(new Product("Kaopeira", 13.4), 11, "MAndoera"));
            productRow.Add(new ProductRow(new Product("Goli", 12), 2, "Crnci"));
        }

    }
}
