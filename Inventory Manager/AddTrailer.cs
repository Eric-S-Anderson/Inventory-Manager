using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class frmAddTrailer : Form
    {
        private static Form mainMenu;

        public frmAddTrailer(Form menuForm)
        {
            InitializeComponent();
            Styler.stylePage(this);

            mainMenu = menuForm;

            btnMainMenu.MouseClick += btnMainMenu_Click;
            btnAddTrailer.MouseClick += btnAddLocation_MouseClick;
            txtVIN.KeyDown += txtAllBoxes_PressEnter;
        }

        private void txtAllBoxes_PressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddLocation_MouseClick(sender, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
            }
        }

        private void btnAddLocation_MouseClick(object sender, MouseEventArgs e)
        {

            if (txtVIN.Text.Length != 17)
            {
                MessageBox.Show("A Proper VIN Must Be Provided.", "Inventory Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVIN.Focus();
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("A Name Must Be Provided.", "Inventory Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
            }
            else
            {

                int insertResult = DBLink.setProcedure("Add_New_Trailer", new List<Param>(new[] {
                                                                                   new Param("@Name", txtName.Text, typeof(string)),
                                                                                   new Param("@VIN", txtVIN.Text, typeof(string))
                                                                                    }));

                if (insertResult == 1)
                {
                    txtName.Clear();
                    txtVIN.Clear();
                }
                txtName.Focus();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            if (mainMenu is frmAddBoxingEvent)
            {
                frmAddBoxingEvent callingForm = (frmAddBoxingEvent)mainMenu;
                callingForm.populateTrailers();
            }

            mainMenu.Show();
            Hide();
        }

        private void frmAddTrailer_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu.Show();
        }
    }
}
