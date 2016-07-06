using System;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class frmMainMenu : Form
    {

        public frmMainMenu()
        {
            InitializeComponent();
            Styler.loadSettings();
            Styler.stylePage(this);

            btnExitApplication.Text = Properties.Resources.ButtonExit;
            btnAddEventLocation.Text = Properties.Resources.ButtonAddEventLocation;
            btnAddEventLocation.MouseClick += BtnAddEventLocation_MouseClick;
            
        }

        private void BtnAddEventLocation_MouseClick(object sender, MouseEventArgs e)
        {
            new frmAddEventLocation(this).Show();
            Hide();
        }

        private void btnAddRepository_Click(object sender, EventArgs e)
        {
            new frmAddRepository(this).Show();
            Hide();
        }

        private void btnAddTrailer_Click(object sender, EventArgs e)
        {
            new frmAddTrailer(this).Show();
            Hide();
        }

        private void btnAddDOT_Click(object sender, EventArgs e)
        {
            new frmAddDOT(this).Show();
            Hide();
        }

        private void btnAddBoxingEvent_Click(object sender, EventArgs e)
        {
            new frmAddBoxingEvent(this).Show();
            Hide();
        }

        private void btnCheckInEvent_Click(object sender, EventArgs e)
        {
            new frmCheckInEvent(this).Show();
            Hide();
        }

        private void btnAddShipment_Click(object sender, EventArgs e)
        {
            new frmAddShipment(this).Show();
            Hide();
        }

        private void btnTrackItem_Click(object sender, EventArgs e)
        {
            new frmTrackFood(this).Show();
            Hide();
        }

        private void btnTrackEvent_Click(object sender, EventArgs e)
        {
            new frmTrackEvent(this).Show();
            Hide();
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMainMenu_Shown(object sender, EventArgs e)
        {
            DBLink.testConnection();

            if (!DBLink.askedForBackup)
            {
                DBLink.askedForBackup = true;
                DBLink.shouldBackup();
            }
        }
    }
}
