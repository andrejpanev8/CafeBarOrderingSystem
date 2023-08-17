using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeBarOrderingSystem
{
    public partial class StaffViewMainForm : Form
    {
        public List<Order> currentOrders = new List<Order>(); //Current pending orders | order format
        public Timer timer;
        public StaffViewMainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            this.DoubleBuffered = true;

            //Creating a timer to count time for all orders
            timer = new System.Windows.Forms.Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            //timer.Start();
        }

        public void AutoResizeListViewColumns(ListView listView)
        {
            foreach (ColumnHeader column in listView.Columns)
            {
                column.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);

                int colWidth = column.Width;
                foreach (ListViewItem item in listView.Items)
                {
                    if (item.SubItems.Count > column.Index)
                    {
                        using (Graphics graphics = listView.CreateGraphics())
                        {
                            int subItemWidth = (int)graphics.MeasureString(item.SubItems[column.Index].Text, listView.Font).Width + 10;
                            if (subItemWidth > colWidth)
                            {
                                colWidth = subItemWidth;
                            }
                        }
                    }
                }

                column.Width = colWidth;
            }
        }   //Method to format listview cells width and height

        public void UpdateOrders(Order order)
        {
            ListView newOrderListView = new ListView();
            newOrderListView.View = View.Details;

            // Add columns to the ListView
            newOrderListView.Columns.Add("Product");
            newOrderListView.Columns.Add("Quantity");
            newOrderListView.Columns.Add("Description");
            newOrderListView.Columns.Add("Price");

            // Populate the ListView with order details
            foreach (ProductRow row in order.productRow)
            {
                ListViewItem item = new ListViewItem(row.product.name);
                item.SubItems.Add($"{row.quantity}");
                item.SubItems.Add($"{row.description}");
                item.SubItems.Add($"{row.product.price:F2} $");
                newOrderListView.Items.Add(item);
            }

            newOrderListView.Items.Add(new ListViewItem(""));


            ListViewItem footer = new ListViewItem($"Pending: {order.TotalWaitTime}sec");
            order.footer.SubItems.Add("");
            order.footer.SubItems.Add("");
            order.footer.SubItems.Add($"Total: {order.TotalPrice} $");
            newOrderListView.Items.Add(order.footer);
            //order.footer = footer;

            AutoResizeListViewColumns(newOrderListView);
            newOrderListView.Columns[1].Width = 70;

            // Set the ListView width to match the total column widths
            int totalColumnWidths = newOrderListView.Columns.Cast<ColumnHeader>().Sum(column => column.Width);
            newOrderListView.Width = totalColumnWidths + 20;

            // // Set the ListView height to match the total column height
            int totalRowHeights = newOrderListView.Items.Cast<ListViewItem>().Sum(item => item.Bounds.Height);
            newOrderListView.Height = totalRowHeights + 50;

            newOrderListView.Scrollable = false;
            layoutPanel.Controls.Add(newOrderListView);
            //updateOrders();
        }

        private void productsMenuBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
            ProductsView view = new ProductsView();
            Order newOrder = new Order();
            newOrder.productRow.Add(new ProductRow(view.getProduct(), 5, "Ohne zwiebeln"));
            newOrder.productRow.Add(new ProductRow(new Product("Chaj", 12.5), 3, "Ohne zucker"));
            newOrder.productRow.Add(new ProductRow(new Product("Zehneins", 15.5), 5, "Ohne zwiebeln"));
            currentOrders.Add(newOrder);
        }
        /*public void updateOrders()
        {
            layoutPanel.Controls.Clear();
            foreach(ListView lv in currentOrders)
            {
                layoutPanel.Controls.Add(lv);
            }
        }*/
        void Timer_Tick(object sender, EventArgs e)
        {
            foreach (Order order in currentOrders)
            {
                order.TotalWaitTime++;
                ////UNHANDLED EXCEPTION INDEX OUT OF BOUNDS (Possible soluton - find another way to access subitems)
                // Update the text of the existing subitems in the footer ListViewItem
                order.footer.SubItems[0].Text = $"Pending: {order.TotalWaitTime}sec";
                order.footer.SubItems[2].Text = $"Total: {order.TotalPrice} $";
            }
        }

        /*public MarkOrderDone()
{

}
public DeleteOrderFromPanel()
{

}*/
    }
}
