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
        public List<Product> availableProducts = new List<Product>();
        public ProductsView()
        {
            InitializeComponent();
            availableProducts.Add(new Product("Kafe", 1.45));
        }
        public Product getProduct()
        {
            return availableProducts.ElementAtOrDefault(0);
        }
    }
}
