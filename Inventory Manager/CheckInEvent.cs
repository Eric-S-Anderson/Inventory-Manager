using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class frmCheckInEvent : Form
    {

        private Form mainMenu;
        private DataTable eventSet = new DataTable();

        public frmCheckInEvent(Form menuForm)
        {
            InitializeComponent();
            Styler.stylePage(this);

            mainMenu = menuForm;

            btnCheckInEvent.MouseClick += btnCheckInEvent_Click;
            btnMainMenu.MouseClick += btnMainMenu_Click;
            cbxEvent.SelectedValueChanged += cbxEventChanged;
            FormClosed += frmCheckInEvent_FormClosed;

            populateEvents();
            cbxEvent.SelectedIndex = -1;
        }

        public void populateEvents()
        {
            eventSet = DBLink.getProcedure("Get_Events_In_Progress");

            cbxEvent.DataSource = eventSet;
            cbxEvent.DisplayMember = eventSet.Columns[1].ColumnName;
        }

        public int getSelectedEventId()
        {
            DataRowView selectedRow = (DataRowView)cbxEvent.SelectedValue;
            int selectedId = (int)selectedRow[0];

            return selectedId;
        }

        private void cbxEventChanged(object sender, EventArgs e)
        {
            if (cbxEvent.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)cbxEvent.SelectedValue;
                DateTime dateField = (DateTime)selectedRow[2];

                lblNameDisplay.Text = selectedRow[1].ToString();
                lblDateDisplay.Text = dateField.ToShortDateString();
                lblLocationDisplay.Text = selectedRow[3].ToString();
                lblBoxCodeDisplay.Text = selectedRow[4].ToString();
            }
            else
            {
                lblNameDisplay.Text = "_________________";
                lblDateDisplay.Text = "_________________";
                lblLocationDisplay.Text = "_________________";
                lblBoxCodeDisplay.Text = "_________________";
            }
        }

        public void clearFields()
        {
            cbxEvent.SelectedIndex = -1;
            nudReturnQuantity.Value = 0;
            nudStayQuantity.Value = 0;
            ckbRiceOverflow.Checked = false;
            ckbSoyOverflow.Checked = false;
        }

        private void btnCheckInEvent_Click(object sender, EventArgs e)
        {
            if (cbxEvent.SelectedItem == null)
            {
                MessageBox.Show("An Event Must Be Selected!", "Inventroy Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxEvent.Focus();
            }else
            {
                if (checkInEvent())
                {
                    clearFields();
                    cbxEvent.Focus();
                }
            }
        }

        private bool checkInEvent()
        {
            bool shouldCommit = true;

            try
            {
                using (SqlConnection databaseConnection = new SqlConnection(DBLink.getConnectionString()))
                {
                    databaseConnection.Open();

                    using (TransactionScope transaction = new TransactionScope())
                    {
                        int checkInSuccess = DBLink.setProcedure("Check_In_Event", new List<Param>(new[] {
                                                                                        new Param("@Event_ID", getSelectedEventId(), typeof(int)),
                                                                                        new Param("@Return_Quantity", (int)nudReturnQuantity.Value, typeof(int)),
                                                                                        new Param("@Stay_Quantity", (int)nudStayQuantity.Value, typeof(int))
                                                                                        }));

                        if (checkInSuccess == 0)
                        {
                            shouldCommit = false;
                        }

                        if (ckbRiceOverflow.Checked)
                        {
                            int overflowSuccess = DBLink.setProcedure("Set_Rice_Overflow", new List<Param>(new[] {
                                                                                        new Param("@Event_ID", getSelectedEventId(), typeof(int))
                                                                                        }));

                            if (overflowSuccess == 0)
                            {
                                shouldCommit = false;
                            }

                        }

                        if (ckbSoyOverflow.Checked)
                        {
                            int overflowSuccess = DBLink.setProcedure("Set_Soy_Overflow", new List<Param>(new[] {
                                                                                        new Param("@Event_ID", getSelectedEventId(), typeof(int))
                                                                                        }));

                            if (overflowSuccess == 0)
                            {
                                shouldCommit = false;
                            }

                        }

                        if (shouldCommit)
                        {
                            transaction.Complete();
                            MessageBox.Show("Event Checked In!", "Inventroy Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return shouldCommit;
                        }
                        else
                        {
                            transaction.Dispose();
                            MessageBox.Show("Event Could Not Be Checked In.", "Inventroy Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return shouldCommit;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), DBLink.applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            Dispose();
        }

        private void frmCheckInEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu.Show();
        }
    }
}
