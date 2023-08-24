﻿using System;
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
            timer.Interval = 1000;
            FinishedOrders.Show();
            currentOrders.Add(new Order());
            currentOrders.Add(new Order());

            foreach (Order order in currentOrders)
            {
                UpdateOrders(order, false);
            }
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
        }   //Method to format listview cells width and height

        public void CreateOrderListView(Order order, ListView newOrderListView)
        {
            foreach (ProductRow row in order.productRow)
            {
                order.TotalPrice += row.quantity * row.product.price;
            }   //Setting total price to be paid on the order

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
            footer.SubItems.Add("");
            footer.SubItems.Add("");
            footer.SubItems.Add($"Total: {order.TotalPrice} $");
            newOrderListView.Items.Add(footer);
            order.footer = footer;

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
                layoutPanel.Controls.Add(newOrderListView);
            }
            
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            foreach (Order order in currentOrders)
            {
                order.TotalWaitTime++;
                // Update the text of the existing subitems in the footer ListViewItem
                order.footer.SubItems[0].Text = $"Pending: {order.TotalWaitTime}sec";
                order.footer.SubItems[3].Text = $"Total: {order.TotalPrice} $";
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
        }

<<<<<<< HEAD
        private void layoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

=======
>>>>>>> f165c787be891cc56957c126c17986942f68a796
        /*public MarkOrderDone()
{

}
public DeleteOrderFromPanel()
{

}*/
    }
}
