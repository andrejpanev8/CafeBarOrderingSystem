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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnStaffView_Click(object sender, EventArgs e)
        {
            StaffViewMainForm staffView = new StaffViewMainForm();
            staffView.ShowDialog();
        }

        private void btnGuestView_Click(object sender, EventArgs e)
        {
            GuestViewMainForm guestView = new GuestViewMainForm();
            guestView.ShowDialog();
        }
    }
}
