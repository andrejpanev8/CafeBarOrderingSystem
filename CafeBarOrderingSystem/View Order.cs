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
    public partial class View_Order : Form
    {
        int tableNumber;
        List<ProductRow> Rows;
        public View_Order(List<ProductRow> CurrentOrder, int tableNumber)
        {
            Rows = CurrentOrder;
            this.tableNumber = tableNumber;
            InitializeComponent();
            
        }

        private void View_Order_Load(object sender, EventArgs e)
        {
            InitiallizeMenu();
        }
        private void InitiallizeMenu()
        {
            lvProductRows.Items.Clear();
            double sumOfPrice = 0;
            foreach (ProductRow row in Rows)
            {
                ListViewItem item = new ListViewItem(row.product.name);
                item.SubItems.Add(row.product.type);
                item.SubItems.Add(row.product.price.ToString());
                item.SubItems.Add(row.quantity.ToString());
                lvProductRows.Items.Add(item);
                sumOfPrice += row.product.price * row.quantity;
            }
            tbFullPrice.Text = sumOfPrice.ToString();
            tbSpeacialRequest.Text = Rows[Rows.Count - 1].description.ToString();
        }
    }
}
