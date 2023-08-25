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
    public partial class GuestViewMainForm : Form
    {
        public GuestViewMainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void GuestViewMainForm_Load(object sender, EventArgs e)
        {

        }
        private void ConfirmTable(int tableNumber)
        {
            DialogResult dg = MessageBox.Show("Are you sure that the selected table is yours?", "Confirm table", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                Make_order ord = new Make_order(tableNumber);
                ord.ShowDialog();
            }   
        }
        private void table1_Click(object sender, EventArgs e)
        {
            ConfirmTable(1);
        }

        private void tb2_Click(object sender, EventArgs e)
        {
            ConfirmTable(2);
        }

        private void tb3_Click(object sender, EventArgs e)
        {
            ConfirmTable(3);
        }

        private void table4_Click(object sender, EventArgs e)
        {
            ConfirmTable(4);
        }

        private void table5_Click(object sender, EventArgs e)
        {
            ConfirmTable(5);
        }

        private void table6_Click(object sender, EventArgs e)
        {
            ConfirmTable(6);
        }

        private void table7_Click(object sender, EventArgs e)
        {
            ConfirmTable(7);
        }

        private void table8_Click(object sender, EventArgs e)
        {
            ConfirmTable(8);
        }

        private void table9_Click(object sender, EventArgs e)
        {
            ConfirmTable(9);
        }

        private void table10_Click(object sender, EventArgs e)
        {
            ConfirmTable(10);
        }

        private void table11_Click(object sender, EventArgs e)
        {
            ConfirmTable(11);
        }

        private void table12_Click(object sender, EventArgs e)
        {
            ConfirmTable(12);
        }

        private void table13_Click(object sender, EventArgs e)
        {
            ConfirmTable(13);
        }
    }
}
