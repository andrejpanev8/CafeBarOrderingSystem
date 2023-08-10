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
        public StaffViewMainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;

            /*TO:DO - Add Current Received Orders List
             *View menu with options : Finished orders, Earnings overview, ... add more myb
             *Order class - attributes: Order wait time, order total price, order finished/pending, list items, table nr, comment
             *Item class - attributes: Name of product, price, id
            */
        }
    }
}
