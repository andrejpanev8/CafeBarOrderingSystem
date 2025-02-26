using System;
using System.Collections.Generic;
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
            if (Rows.Count > 0)
            {


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

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            Make_order.Instance_MakeOrder.Close();
            this.Close();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (lvProductRows.SelectedItems.Count > 0)
            {

                Rows.RemoveAll(row => row.product.name == lvProductRows.SelectedItems[0].Text);

                Make_order.Instance_MakeOrder.ProductsForOrder.RemoveAll(x => x.product.name == lvProductRows.SelectedItems[0].Text);
                lvProductRows.SelectedItems[0].Remove();
                InitiallizeMenu();
            }
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            if (Rows.Count > 0)
            {
                Order newOrder = new Order(Rows, tableNumber);
                StaffViewMainForm.InstanceStaffView.currentOrders.Add(newOrder);
                StaffViewMainForm.InstanceStaffView.UpdateOrders(newOrder, true);
                Make_order.Instance_MakeOrder.Close();
                GuestViewMainForm.GuestViewInstance.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("No products selected.", "Please select a product first!", MessageBoxButtons.OK);
            }
        }
    }
}
