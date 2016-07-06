using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class frmAddEventLocation : Form
    {
        private static Form mainMenu;
        private DataTable stateSet = new DataTable();
        private string defaultState = "MI";

        public frmAddEventLocation(Form menuForm)
        {
            InitializeComponent();
            Styler.stylePage(this);

            mainMenu = menuForm;

            btnMainMenu.MouseClick += btnMainMenu_Click;
            btnAddLocation.MouseClick += btnAddLocation_MouseClick;
            txtName.KeyDown += txtAllBoxes_PressEnter;
            txtAddress.KeyDown += txtAllBoxes_PressEnter;
            txtCity.KeyDown += txtAllBoxes_PressEnter;
            cbxState.KeyDown += txtAllBoxes_PressEnter;
            txtZip.KeyDown += txtAllBoxes_PressEnter;
            txtPhone.KeyDown += txtAllBoxes_PressEnter;

            stateSet = DBLink.getProcedure("Get_States");

            cbxState.DataSource = stateSet;
            cbxState.DisplayMember = stateSet.Columns[1].ColumnName;
            for (int i = 0; i < cbxState.Items.Count; i++)
            {
                if (cbxState.GetItemText(cbxState.Items[i]) == defaultState)
                {
                    cbxState.SelectedIndex = i;
                }
            }
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

            if (txtName.Text == "")
            {
                MessageBox.Show("A Name Must Be Provided.", "Inventory Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
            }
            else
            {
                int stateID = 0;

                for (int i = 0; i < stateSet.Rows.Count; i++)
                {
                    if (cbxState.SelectedIndex == i)
                    {
                        stateID = (int)stateSet.Rows[i][0];
                    }
                }

                int insertResult = DBLink.setProcedure("Add_New_Location", new List<Param>(new[] {
                                                                                   new Param("@Name", txtName.Text, typeof(string)),
                                                                                   new Param("@Address", txtAddress.Text, typeof(string)),
                                                                                   new Param("@City", txtCity.Text, typeof(string)),
                                                                                   new Param("@State", stateID, typeof(int)),
                                                                                   new Param("@Zip", txtZip.Text, typeof(string)),
                                                                                   new Param("@Phone", txtPhone.Text, typeof(string))
                                                                                    }));

                if (insertResult == 1)
                {
                    txtName.Clear();
                    txtAddress.Clear();
                    txtCity.Clear();
                    txtZip.Clear();
                    txtPhone.Clear();
                    for (int i = 0; i < cbxState.Items.Count; i++)
                    {
                        if (cbxState.GetItemText(cbxState.Items[i]) == defaultState)
                        {
                            cbxState.SelectedIndex = i;
                        }
                    }
                }
                txtName.Focus();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            if (mainMenu is frmAddBoxingEvent)
            {
                frmAddBoxingEvent callingForm = (frmAddBoxingEvent)mainMenu;
                callingForm.populateLocations();
            }

            mainMenu.Show();
            Hide();
        }

        private void frmAddEventLocation_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu.Show();
        }
    }
}
