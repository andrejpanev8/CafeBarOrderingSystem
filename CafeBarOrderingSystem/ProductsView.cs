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
    public partial class ProductsView : Form
    {
        public List<Product> availableProducts { get; set; } = new List<Product>();
        public bool hasChanges;
        public static ProductsView Instance { get; set; }
        public ProductsView()
        {
            InitializeComponent();
            lvProducts.View = View.Details;
            lvProducts.Columns.Add("Product: ");
            lvProducts.Columns.Add("Type: ");
            lvProducts.Columns.Add("Price: ");
            lvProducts.Columns[0].Width = 150;
            lvProducts.Columns[1].Width = 150;
            lvProducts.Columns[2].Width = 150;
            this.Width = 500;
            this.Height = 900;
            this.AutoScroll = true;
            hasChanges = false;
            Instance = this;
        }
        public void DisplayOrders()
        {
            if (hasChanges)
            {
                hasChanges = false;
                lvProducts.Items.Clear();
                foreach (Product product in availableProducts)
                {
                    ListViewItem item = new ListViewItem(product.name);
                    item.SubItems.Add(product.type.ToString());
                    item.SubItems.Add(product.price.ToString());
                    lvProducts.Items.Add(item);
                }
            }
        }
        public List<Product> getAvailableProducts()
        {
            return availableProducts;
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

        private bool selectionChangedSubscribed = true; // A flag to control subscription

        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!selectionChangedSubscribed) return; // Skip handling if not subscribed

            string product = "";
            if (lvProducts.SelectedItems.Count > 0 && lvProducts.Items.Count > 0)
            {
                ListViewItem lvItem = lvProducts.SelectedItems[0];
                product = lvItem.SubItems[0].Text;
            }
            else
            {
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete {product}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Unsubscribe temporarily to avoid re-entry
                lvProducts.SelectedIndexChanged -= lvProducts_SelectedIndexChanged;

                // Find and remove the product from the list
                Product productToRemove = availableProducts.FirstOrDefault(p => p.name == product);

                if (productToRemove != null)
                {
                    availableProducts.Remove(productToRemove);
                    hasChanges = true;
                    DisplayOrders();
                }

                // Subscribe back
                lvProducts.SelectedIndexChanged += lvProducts_SelectedIndexChanged;
            }
        }

    }
}
