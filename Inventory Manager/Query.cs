using System;
using System.Data;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class frmQuery : Form
    {
        private Form mainMenu;
        private DataTable resultSet;
        private int resultInt;

        public frmQuery(Form menuForm)
        {
            InitializeComponent();
            Styler.stylePage(this);

            mainMenu = menuForm;

            btnVoid.Click += btnVoid_Click;
            btnInteger.Click += btnInteger_Click;
            btnTable.Click += btnTable_Click;
            btnMainMenu.Click += btnMainMenu_Click;
            FormClosed += frmQuery_FormClosed;
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            DBLink.dynamicVoidQuery(txtQuery.Text);
        }

        private void btnInteger_Click(object sender, EventArgs e)
        {
            resultInt = DBLink.dynamicIntegerQuery(txtQuery.Text);
            dgvResults.DataSource = resultInt;
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            resultSet = DBLink.dynamicDataTableQuery(txtQuery.Text);
            dgvResults.DataSource = resultSet;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            Dispose();
        }

        private void frmQuery_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu.Show();
        }
    }
}
