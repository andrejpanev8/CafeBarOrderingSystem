using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeBarOrderingSystem
{
    public partial class Make_order : Form
    {
        public List<ProductRow> ProductsForOrder { get; set; } = new List<ProductRow>();
        int tableNumber;
        public Make_order(int tableNumber)
        {
            InitializeComponent();
            InitiallizeMenu();
            this.tableNumber = tableNumber;
        }

        private void Make_order_Load(object sender, EventArgs e)
        {
        }
        private void InitiallizeMenu()
        {
            
            this.AutoScroll = true;
            List<Product> availableProducts = ProductsView.Instance.getAvailableProducts();
            lvMenuProducts.Items.Clear();

            foreach (Product product in availableProducts)
            {
                ListViewItem item = new ListViewItem(product.name);
                item.SubItems.Add(product.type.ToString());
                item.SubItems.Add(product.price.ToString());
                lvMenuProducts.Items.Add(item);
                
            }
        }

        private void lvMenuProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            nupQuantity.Value = 1;
            if (lvMenuProducts.SelectedItems.Count == 0)
            {
                nupQuantity.Enabled = false;
            }
            else
            {
                nupQuantity.Enabled = true;
            }
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (nupQuantity.Enabled == true)
            {

                
                List<string> propertiesOfOrder = new List<string>();
                foreach(var temp in lvMenuProducts.SelectedItems[0].SubItems)
                {
                    propertiesOfOrder.Add(temp.ToString().Split('{','}')[1]);
                }
                
                double price=(double)int.Parse(propertiesOfOrder[2]);
                Product product = new Product(propertiesOfOrder[0], price , propertiesOfOrder[1]);
                ProductRow productRow = new ProductRow(product, (int)nupQuantity.Value, tbDescription.Text);
                bool flag = false;
                foreach (ProductRow row in ProductsForOrder)
                {
                    if (productRow.product.name == row.product.name)
                    {
                        row.quantity += productRow.quantity;
                        row.description = productRow.description;
                        flag = true; break;
                    }
                }
                if (flag == false)
                {
                    ProductsForOrder.Add(productRow);
                }
            }

        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            View_Order viewForm = new View_Order(ProductsForOrder , tableNumber);
            viewForm.ShowDialog();
        }
    }
}
