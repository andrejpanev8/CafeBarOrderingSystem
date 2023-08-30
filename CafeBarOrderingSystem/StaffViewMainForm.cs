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
    /// <summary>
    /// Fix up transfer from current orders to finished orders price increases in footer, time/paid changed
    /// in StaffViewMain instead of finished orders form
    /// </summary>
    public partial class StaffViewMainForm : Form
    {
        public List<Order> currentOrders = new List<Order>(); //Current pending orders | order format
        public ProductsView AvailableProducts = new ProductsView();
        public FinishedOrders FinishedOrders = new FinishedOrders();
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


            ////////////////////Dummy code start/////////////////////////


            /*for (int i = 0; i < 5; i++)                     //Dummy Code
                currentOrders.Add(new Order());             //Dummy Code*/
            List<ProductRow> testList = new List<ProductRow>();
            testList.Add(new ProductRow(new Product("Jajce", 15, "Alcohol"), 87, "Ohne Zwiebeln"));
            testList.Add(new ProductRow(new Product("Kappa", 13, "Alcohol"), 5, "Zhanzi"));
            testList.Add(new ProductRow(new Product("Product1", 35.65, "Alcohol"), 42, "Description1"));
            testList.Add(new ProductRow(new Product("Product2", 12.23, "Alcohol"), 18, "Description2"));
            testList.Add(new ProductRow(new Product("Product3", 87.99, "Alcohol"), 7, "Description3"));
            testList.Add(new ProductRow(new Product("Product4", 50.17, "Alcohol"), 91, "Description4"));
            testList.Add(new ProductRow(new Product("Product5", 29.78, "Alcohol"), 64, "Description5"));
            testList.Add(new ProductRow(new Product("Product6", 63.41, "Alcohol"), 23, "Description6"));
            testList.Add(new ProductRow(new Product("Product7", 5.05, "Alcohol"), 77, "Description7"));
            testList.Add(new ProductRow(new Product("Product8", 88.12, "Alcohol"), 39, "Description8"));
            testList.Add(new ProductRow(new Product("Product9", 73.25, "Alcohol"), 52, "Description9"));
            testList.Add(new ProductRow(new Product("Product10", 18.90, "Alcohol"), 11, "Description10"));
            currentOrders.Add(new Order(testList));
            testList.Clear();

            testList.Add(new ProductRow(new Product("Mandrahora", 6, "Coffee"), 6, "Jako"));
            testList.Add(new ProductRow(new Product("Longo", 10, "Coffee"), 5, "Zhuriosm"));
            currentOrders.Add(new Order(testList));

            //////////////////////////////Dummy Code End//////////////////
            foreach (Order cc in currentOrders)
                UpdateOrders(cc, true);
            timer.Interval = 1000;
            timer.Start();

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
        }

        public void CreateOrderListView(Order order, ListView newOrderListView)
        {
            //################Dummy Code############
            order.TotalPrice = 0;    //<- Doesn't work
            foreach (ProductRow row in order.productRow)
            {
                order.TotalPrice += row.quantity * row.product.price;
            }   //Setting total price to be paid on the order
            //##########################################

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


            if (order.footer.SubItems[0].Text.StartsWith("Pending:"))
            {
                ListViewItem footer = new ListViewItem($"Pending: {order.TotalWaitTime} sec");
                footer.SubItems.Add("");
                footer.SubItems.Add("");
                footer.SubItems.Add($"Total: {order.TotalPrice} $");
                newOrderListView.Items.Add(footer);
                order.footer = footer;
            }
            else
            {
                ListViewItem footer = new ListViewItem($"Finished: {order.TotalWaitTime} sec");
                footer.SubItems.Add("");
                footer.SubItems.Add("");
                footer.SubItems.Add($"Paid: {order.TotalPrice} $");
                newOrderListView.Items.Add(footer);
                order.footer = footer;
            }

            AutoResizeListViewColumns(newOrderListView);
            newOrderListView.Columns[1].Width = 70;     //Shortcut for Quantity column

            // Set the ListView width to match the total column widths
            int totalColumnWidths = newOrderListView.Columns.Cast<ColumnHeader>().Sum(column => column.Width);
            newOrderListView.Width = totalColumnWidths + 20;

            // // Set the ListView height to match the total column height
            int totalRowHeights = newOrderListView.Items.Cast<ListViewItem>().Sum(item => item.Bounds.Height);
            newOrderListView.Height = totalRowHeights + 50;

            newOrderListView.Scrollable = false;
        }

        public void UpdateOrders(Order order, bool caller)    //caller flag indicates wheter the method is called from
        {                                                   //guest view or staff view | True - Guest, False - Staff |
            ListView newOrderListView = new ListView();
            newOrderListView.View = View.Details;
            CreateOrderListView(order, newOrderListView);

            if (caller == false)
            {
                FinishedOrders.panelFinishedOrders.Controls.Add(newOrderListView);
            } else
            {
                newOrderListView.Click += ListView_Click;
                layoutPanel.Controls.Add(newOrderListView);
                order.lvOrder = newOrderListView;
            }
            
        }
        private void ListView_Click(object sender, EventArgs e) //<-better way for selection if possible 
        {
            if(sender is ListView selectedListview)
            {
                for(int i = 0; i < currentOrders.Count(); i++)
                {
                    if (currentOrders[i].lvOrder.Equals(selectedListview))
                    {
                        FinishedOrders.MarkFinished(currentOrders[i]);
                        currentOrders.Remove(currentOrders[i]);
                        DisplayOrders();
                    }
                }
            }
        }

        public void DisplayOrders()
        {
            layoutPanel.Controls.Clear();   
            foreach(Order order in currentOrders)
            {
                UpdateOrders(order, true);
            }
            foreach (Order order in FinishedOrders.finishedOrders)
            {
                UpdateOrders(order, false);
            }
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            foreach (Order order in currentOrders)
            {
                order.TotalWaitTime++;
                // Update the text of the existing subitems in the footer ListViewItem
                order.footer.SubItems[0].Text = $"Pending: {order.TotalWaitTime} sec";
                //order.footer.SubItems[3].Text = $"Total: {order.TotalPrice} $";
            }
        }

        ///////////////////MENU BUTTONS////////////////////////////////
        private void productsMenuBtn_Click(object sender, EventArgs e)
        {
            AvailableProducts.DisplayOrders();
            AvailableProducts.Show();
        }

        private void addProductsMenuBtn_Click(object sender, EventArgs e)
        {
            using (AddProductForm addProductForm = new AddProductForm())
            {
                if (addProductForm.ShowDialog() == DialogResult.OK)
                {
                    Product newProduct = addProductForm.NewProduct;
                    if (!AvailableProducts.availableProducts.Contains(newProduct))
                    {
                        AvailableProducts.hasChanges = true;
                        AvailableProducts.availableProducts.Add(newProduct);
                    }
                }
            }
        }

        private void finishedOrdersMenuBtn_Click(object sender, EventArgs e)
        {
            FinishedOrders.Show();
            FinishedOrders.panelFinishedOrders.Controls.Clear();
            foreach (Order order in FinishedOrders.finishedOrders)
            {
                UpdateOrders(order, false);
            }
        }
        private void layoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void earningsMenuBtn_Click(object sender, EventArgs e)
        {
            EarningsForm earnings = new EarningsForm();
            earnings.Show();
            earnings.CreateChart(FinishedOrders.finishedOrders);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Check if the reason for closing is the user clicking the close button (X)
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Hide the form instead of disposing it
                this.Hide();
                e.Cancel = true;
            }
        }
    }
}
