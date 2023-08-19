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

        public System.Windows.Forms.ListViewItem footer { get; set; }
        public Order()
        {
            footer = new System.Windows.Forms.ListViewItem();
        }

    }
}
