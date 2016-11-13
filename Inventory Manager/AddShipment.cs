using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class frmAddShipment : Form
    {
        private Form mainMenu;
        private DataTable repositorySet = new DataTable();
        private int lineBoxCounter = 0;

        public frmAddShipment(Form menuForm)
        {
            InitializeComponent();
            Styler.stylePage(this);

            mainMenu = menuForm;

            btnMainMenu.Click += btnMainMenu_Click;
            FormClosed += frmAddShipment_FormClosed;
            btnAddRepository.Click += btnAddRepository_Click;
            btnAddLineBox.Click += btnAddBox_Click;
            btnAddShipment.Click += btnAddShipment_Click;

            populateRepositories();
            cbxRepository.SelectedIndex = -1;
            
        }

        public void populateRepositories()
        {
            repositorySet = DBLink.getProcedure("Get_Repositories");

            cbxRepository.DataSource = repositorySet;
            cbxRepository.DisplayMember = repositorySet.Columns[1].ColumnName;
        }

        public int getSelectedRepositoryId()
        {
            if (cbxRepository.SelectedIndex >= 0)
            {
                DataRowView selectedRow = (DataRowView)cbxRepository.SelectedValue;
                return (int)selectedRow[0];
            }
            else
            {
                return -1;
            }
        }

        private void flpLineBox_Change(object sender, EventArgs e)
        {
            Control senderControl = (Control)sender;
            LineBox changedChild = (LineBox)senderControl.Parent;
            foreach (LineBox child in flpBox.Controls)
            {
                if (child != changedChild && child.getSelectedId() == changedChild.getSelectedId())
                {
                    child.resetValues();
                }
            }
        }

        private void clearFields()
        {
            cbxRepository.SelectedIndex = -1;

            while (flpBox.Controls.Count > 0)
            {
                flpBox.Controls[0].Dispose();
            }
        }

        private void btnAddBox_Click(object sender, EventArgs e)
        {
            LineBox boxItem = new LineBox("boxItem" + lineBoxCounter);
            boxItem.cbxBoxCode.SelectedIndexChanged += flpLineBox_Change;
            flpBox.Controls.Add(boxItem);
            lineBoxCounter++;
        }

        private void btnAddShipment_Click(object sender, EventArgs e)
        {
            if (cbxRepository.SelectedIndex < 0)
            {
                MessageBox.Show("Shipment Must Have A Repository!", "Inventroy Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxRepository.Focus();
            }
            else
            {
                if (addShipment())
                {
                    clearFields();
                    cbxRepository.Focus();
                }
            }
        }

        private bool addShipment()
        {
            bool shouldCommit = true;

            try
            {
                using (SqlConnection databaseConnection = new SqlConnection(DBLink.getConnectionString()))
                {
                    databaseConnection.Open();

                    using (TransactionScope transaction = new TransactionScope())
                    {
                        int shipmentID = DBLink.setProcedure("Add_New_Shipment", new List<Param>(new[] {
                                                                                        new Param("@Shipment_Date", dtpShipmentDate.Value, typeof(DateTime)),
                                                                                        new Param("@Repository_ID", getSelectedRepositoryId(), typeof(int))
                                                                                        }));

                        if (shipmentID == 0)
                        {
                            shouldCommit = false;
                        }

                        foreach (LineBox box in flpBox.Controls)
                        {
                            if (box.getSelectedId() >= 0)
                            {
                                int linkID = DBLink.setProcedure("Link_Shipment_Box", new List<Param>(new[] {
                                                                                        new Param("@Shipment_ID", shipmentID, typeof(int)),
                                                                                        new Param("@Box_ID", box.getSelectedId(), typeof(int)),
                                                                                        new Param("@Shipment_Box_Quantity", box.getQuantity(), typeof(int))
                                                                                        }));

                                if (linkID == 0)
                                {
                                    shouldCommit = false;
                                }

                                int boxSuccess = DBLink.setProcedure("Remove_Food_Boxes", new List<Param>(new[] {
                                                                                        new Param("@Box_ID", box.getSelectedId(), typeof(int)),
                                                                                        new Param("@Quantity", box.getQuantity(), typeof(int))
                                                                                        }));

                                if (boxSuccess == 0)
                                {
                                    shouldCommit = false;
                                }

                            }
                        }

                        if (shouldCommit)
                        {
                            transaction.Complete();
                            MessageBox.Show("Shipment Created!", "Inventroy Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return shouldCommit;
                        }
                        else
                        {
                            transaction.Dispose();
                            MessageBox.Show("Shipment Could Not Be Created.", "Inventroy Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmAddShipment_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu.Show();
        }

        private void btnAddRepository_Click(object sender, EventArgs e)
        {
            new frmAddRepository(this).Show();
            Hide();
        }
    }
}
