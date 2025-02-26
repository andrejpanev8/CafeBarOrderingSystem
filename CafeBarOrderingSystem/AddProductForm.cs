using System;
using System.Windows.Forms;

namespace CafeBarOrderingSystem
{
    public partial class AddProductForm : Form
    {
        public Product NewProduct;
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string productName = productNameTb.Text;
            string productType = tbType.Text;
            string price = priceTb.Text;

            if (price.Contains("."))
                price = price.Replace('.', ',');

            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Product name is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(productType))
            {
                MessageBox.Show("Product type is required.");
                return;
            }

            if (!double.TryParse(price, out double productPrice))
            {
                MessageBox.Show("Invalid price value.");
                return;
            }

            NewProduct = new Product(productName, productPrice, productType);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
