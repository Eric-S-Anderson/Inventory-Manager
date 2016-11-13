using System;
using System.Data;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class frmInventory : Form
    {
        private Form mainMenu;
        private DataTable boxSet = new DataTable();

        public frmInventory(Form menuForm)
        {
            InitializeComponent();
            Styler.stylePage(this);

            mainMenu = menuForm;

            btnMainMenu.MouseClick += btnMainMenu_Click;
            FormClosed += frmAddBoxingEvent_FormClosed;

            populateBoxes();
        }

        private void populateBoxes()
        {
            boxSet = DBLink.getProcedure("Get_Inventory");

            dgvBoxes.DataSource = boxSet;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            Dispose();
        }

        private void frmAddBoxingEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu.Show();
        }
    }
}
