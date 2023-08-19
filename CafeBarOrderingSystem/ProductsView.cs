using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Everything fixed-up - next move to finishing an order.
/// </summary>

namespace CafeBarOrderingSystem
{
    public partial class ProductsView : Form
    {
        public List<Product> availableProducts = new List<Product>();
        public bool hasChanges;
        public ProductsView()
        {
            InitializeComponent();
            lvProducts.View = View.Details;
            lvProducts.Columns.Add("Product: ");
            lvProducts.Columns.Add("Price: ");
            lvProducts.Columns[0].Width = 250;
            lvProducts.Columns[1].Width = 250;
            this.Width = 500;
            this.Height = 900;
            hasChanges = false;
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
                    item.SubItems.Add(product.price.ToString());
                    lvProducts.Items.Add(item);
                }
            }
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
