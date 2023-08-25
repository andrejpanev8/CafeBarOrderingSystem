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
    public partial class FinishedOrders : Form
    {
        /// <summary>
        /// Finished Orders tweak time passed after finishing -> could impact update orders method in staffView.cs
        /// Check lists formatting, adding removing
        /// Figure out a way to select an 'order' in order to mark it as finished <- hard shit probably (arrows selection enter=mark myb)
        /// </summary>
        public List<Order> finishedOrders = new List<Order>();
        public FlowLayoutPanel panelFinishedOrders = new FlowLayoutPanel();
        public FinishedOrders()
        {
            InitializeComponent();
            Controls.Add(panelFinishedOrders);
            panelFinishedOrders.AutoScroll = true;
            panelFinishedOrders.Dock = DockStyle.Fill;
            panelFinishedOrders.FlowDirection = FlowDirection.LeftToRight;
            WindowState = FormWindowState.Maximized;
        }
        public void MarkFinished(Order order)
        {
            panelFinishedOrders.Controls.Clear();
            order.footer.SubItems[0].Text = $"";
            finishedOrders.Add(order);

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
