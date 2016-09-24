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
            
        }

        private void btnAddRepository_Click(object sender, EventArgs e)
        {
            new frmAddRepository(this).Show();
            Hide();
        }

        private void btnAddTrailer_Click(object sender, EventArgs e)
        {
            new frmPrintEvent(this).Show();
        }

        private void btnAddDOT_Click(object sender, EventArgs e)
        {
            new frmPrintShipment(this).Show();
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
