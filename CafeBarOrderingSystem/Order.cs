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
        public int TableNumber { get; set; }

        public System.Windows.Forms.ListView lvOrder { get; set; }
        public System.Windows.Forms.ListViewItem footer { get; set; }
        public Order(List<ProductRow> productRow, int tableNumber)  //< - Must receive a list od product rows
        {
            TableNumber = tableNumber;
            foreach (ProductRow row in productRow)
                this.productRow.Add(row);

            foreach (ProductRow row in productRow)
            {
                TotalPrice += row.quantity * row.product.price;
            }   //Setting total price to be paid on the order


            footer = new System.Windows.Forms.ListViewItem($"Table number {TableNumber} Pending: {TotalWaitTime} sec");
            footer.SubItems.Add("");
            footer.SubItems.Add("");
            footer.SubItems.Add($"Total: {TotalPrice} $");
        }

    }
}
