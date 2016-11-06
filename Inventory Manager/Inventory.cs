using System;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class frmInventory : Form
    {
        private static Form mainMenu;
        public frmInventory(Form menuForm)
        {
            InitializeComponent();
            Styler.stylePage(this);

            mainMenu = menuForm;

            btnMainMenu.MouseClick += btnMainMenu_Click;
            FormClosed += frmAddBoxingEvent_FormClosed;
        }


        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            Hide();
        }

        private void frmAddBoxingEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu.Show();
        }
    }
}
