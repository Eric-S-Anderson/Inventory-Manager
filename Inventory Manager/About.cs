using System;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            Styler.stylePage(this);

            btnOK.Click += btnOK_Click;

            lblHeader.Text = "Inventory Manager \nVersion 0.9 \nDesigned by: Eric Anderson \n\nApplication is intended for use by Kids Against Hunger Coalition \n\n\nContact: codeproanderson@gmail.com";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
