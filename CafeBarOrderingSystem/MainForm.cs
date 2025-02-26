using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeBarOrderingSystem
{
    public partial class MainForm : Form
    {
        StaffViewMainForm staffView;
        GuestViewMainForm guestView;
        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            btnStaffView.BackColor = Color.BurlyWood;
            btnGuestView.BackColor = Color.BurlyWood;
            staffView = new StaffViewMainForm();
            guestView = new GuestViewMainForm();
        }

        private void btnStaffView_Click(object sender, EventArgs e)
        {
            staffView.ShowDialog();
        }

        private void btnGuestView_Click(object sender, EventArgs e)
        {
            guestView.ShowDialog();
        }
    }
}
