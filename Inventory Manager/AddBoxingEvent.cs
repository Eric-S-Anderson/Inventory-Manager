using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Windows.Forms;

namespace Inventory_Manager
{

    public partial class frmAddBoxingEvent : Form
    {
        private static Form mainMenu;
        private DataTable trailerSet = new DataTable();
        private DataTable locationSet = new DataTable();
        private int riceCount = 0;
        private int soyCount = 0;
        private int veggieCount = 0;
        private int vitaminCount = 0;

        public frmAddBoxingEvent(Form menuForm)
        {
            InitializeComponent();
            Styler.stylePage(this);

            mainMenu = menuForm;

            btnMainMenu.MouseClick += btnMainMenu_Click;
            FormClosed += frmAddBoxingEvent_FormClosed;
            ckbRice.CheckedChanged += ckbRice_CheckedChanged;
            ckbSoy.CheckedChanged += ckbSoy_CheckedChanged;

            populateTrailers();
            populateLocations();

            cbxPackingLocation.SelectedIndex = -1;
        }

        public int getSelectedLocationId()
        {
            DataRowView selectedRow = (DataRowView)cbxPackingLocation.SelectedValue;
            int selectedId = (int)selectedRow[0];

            return selectedId;
        }

        public List<int> getSelectedTrailers()
        {
            List<int> trailerList = new List<int>();

            for (int i = 0; i < clbTrailer.CheckedItems.Count; i++)
            {
                DataRowView selectedRow = (DataRowView)clbTrailer.CheckedItems[i];
                trailerList.Add((int)selectedRow[0]);
            }
            
            return trailerList;
        }

        public void populateTrailers()
        {
            trailerSet = DBLink.getProcedure("Get_Trailers");

            trailerSet.Columns.Add("comboDisplay", typeof(string));

            foreach (DataRow row in trailerSet.Rows)
            {
                row[3] = row[1].ToString() + ", " + row[2].ToString();
            }

            clbTrailer.DataSource = trailerSet;
            clbTrailer.DisplayMember = trailerSet.Columns[3].ColumnName;
        }

        public void populateLocations()
        {
            locationSet = DBLink.getProcedure("Get_Locations");

            cbxPackingLocation.DataSource = locationSet;
            cbxPackingLocation.DisplayMember = locationSet.Columns[1].ColumnName;
            if (cbxPackingLocation.Items.Count > 0)
            {
                cbxPackingLocation.SelectedIndex = 0;
            }
        }

        private void btnAddRice_Click(object sender, EventArgs e)
        {
            LineRice riceItem = new LineRice("riceItem" + riceCount);
            flpRice.Controls.Add(riceItem);
            riceCount++;
        }

        private void btnAddSoy_Click(object sender, EventArgs e)
        {
            LineSoy soyItem = new LineSoy("soyItem" + soyCount);
            flpSoy.Controls.Add(soyItem);
            soyCount++;
        }

        private void btnAddVitamin_Click(object sender, EventArgs e)
        {
            LineVitamin vitaminItem = new LineVitamin("vitaminItem" + vitaminCount);
            flpVitamin.Controls.Add(vitaminItem);
            vitaminCount++;
        }

        private void btnAddVeggie_Click(object sender, EventArgs e)
        {
            LineVeggie veggieItem = new LineVeggie("veggieItem" + veggieCount);
            flpVeggie.Controls.Add(veggieItem);
            veggieCount++;
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            if (txtEventName.Text == "")
            {
                MessageBox.Show("Event Must Have A Name!", "Inventroy Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEventName.Focus();
            }
            else if (txtBoxCode.Text == "")
            {
                MessageBox.Show("Event Must Have A Box Code!", "Inventroy Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxCode.Focus();
            }
            else if (clbTrailer.CheckedItems.Count < 1)
            {
                MessageBox.Show("Event Must Have At Least One Trailer!", "Inventroy Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clbTrailer.Focus();
            }
            else if (cbxPackingLocation.SelectedIndex < 0)
            {
                MessageBox.Show("Event Must Have A Packing Location!", "Inventroy Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxPackingLocation.Focus();
            }
            else
            {
                if (addEvent())
                {
                    clearFields();
                }
            }
        }

        private bool addEvent()
        {
            bool shouldCommit = true;

            try
            {
                using (SqlConnection databaseConnection = new SqlConnection(DBLink.getConnectionString()))
                {
                    databaseConnection.Open();

                    using (TransactionScope transaction = new TransactionScope())
                    {
                        int eventID = DBLink.setProcedure("Add_New_Event", new List<Param>(new[] {
                                                                                        new Param("@Event_Name", txtEventName.Text, typeof(string)),
                                                                                        new Param("@Event_Date", dtpEventDate.Value, typeof(DateTime)),
                                                                                        new Param("@Location_ID", getSelectedLocationId(), typeof(int))
                                                                                        }));

                        int boxID = DBLink.setProcedure("Add_New_Box", new List<Param>(new[] {
                                                                                    new Param("@Box_Code", txtBoxCode.Text, typeof(string))
                                                                                    }));

                        int eventLink = DBLink.setProcedure("Link_Event_Box", new List<Param>(new[] {
                                                                                            new Param("@Event_ID", eventID, typeof(int)),
                                                                                            new Param("@Box_ID", boxID, typeof(int))
                                                                                            }));

                        if (eventID == 0 || boxID == 0 || eventLink == 0)
                        {
                            shouldCommit = false;
                        }

                        foreach (int trailerID in getSelectedTrailers())
                        {
                            int trailerLink = DBLink.setProcedure("Link_Trailer_Event", new List<Param>(new[] {
                                                                                            new Param("@Event_ID", eventID, typeof(int)),
                                                                                            new Param("@Trailer_ID", trailerID, typeof(int))
                                                                                            }));

                            if (trailerLink == 0)
                            {
                                shouldCommit = false;
                            }
                        }

                        foreach (LineRice riceItem in flpRice.Controls)
                        {
                            if (riceItem.isOverflow)
                            {
                                int overflowId = DBLink.setProcedure("Get_Rice_Overflow_ID", new List<Param>(new[] {
                                                                                            new Param("@Lot_Number", riceItem.getLotNumber(), typeof(string))
                                                                                            }));

                                int oldRiceLink = DBLink.setProcedure("Link_Rice_Box", new List<Param>(new[] {
                                                                                            new Param("@Rice_ID", overflowId, typeof(int)),
                                                                                            new Param("@Box_ID", boxID, typeof(int))
                                                                                            }));

                                int riceRemoval = DBLink.setProcedure("Remove_Rice_Overflow", new List<Param>(new[] {
                                                                                            new Param("@Lot_Number", overflowId, typeof(int))
                                                                                            }));

                                if (oldRiceLink == 0)
                                {
                                    shouldCommit = false;
                                }
                            }
                            else
                            {
                                for (int i = 0; i < riceItem.getQuantity(); i++)
                                {
                                    int newRiceID = DBLink.setProcedure("Add_New_Rice", new List<Param>(new[] {
                                                                                            new Param("@Lot_Number", riceItem.getLotNumber(), typeof(string))
                                                                                            }));

                                    int newRiceLink = DBLink.setProcedure("Link_Rice_Box", new List<Param>(new[] {
                                                                                            new Param("@Rice_ID", newRiceID, typeof(int)),
                                                                                            new Param("@Box_ID", boxID, typeof(int))
                                                                                            }));

                                    if (newRiceID == 0 || newRiceLink == 0)
                                    {
                                        shouldCommit = false;
                                    }
                                }
                            }
                        }

                        foreach (LineSoy soyItem in flpSoy.Controls)
                        {
                            if (soyItem.isOverflow)
                            {
                                int overflowId = DBLink.setProcedure("Get_Soy_Overflow_ID", new List<Param>(new[] {
                                                                                            new Param("@Lot_Number", soyItem.getBagNumber(), typeof(string))
                                                                                            }));

                                int oldsoyLink = DBLink.setProcedure("Link_Soy_Box", new List<Param>(new[] {
                                                                                            new Param("@Rice_ID", overflowId, typeof(int)),
                                                                                            new Param("@Box_ID", boxID, typeof(int))
                                                                                            }));

                                int riceRemoval = DBLink.setProcedure("Remove_Soy_Overflow", new List<Param>(new[] {
                                                                                            new Param("@Lot_Number", overflowId, typeof(int))
                                                                                            }));

                                if (oldsoyLink == 0)
                                {
                                    shouldCommit = false;
                                }
                            }
                            else
                            {

                                int newSoyID = DBLink.setProcedure("Add_New_Soy", new List<Param>(new[] {
                                                                                            new Param("@Bag_Number", soyItem.getBagNumber(), typeof(string))
                                                                                            }));

                                int newSoyLink = DBLink.setProcedure("Link_Soy_Box", new List<Param>(new[] {
                                                                                            new Param("@Soy_ID", newSoyID, typeof(int)),
                                                                                            new Param("@Box_ID", boxID, typeof(int))
                                                                                            }));

                                if (newSoyID == 0 || newSoyLink == 0)
                                {
                                    shouldCommit = false;
                                }
                            }
                        }

                        foreach (LineVeggie veggieItem in flpVeggie.Controls)
                        {

                            int newVeggieID = DBLink.setProcedure("Add_New_Vegetable", new List<Param>(new[] {
                                                                                            new Param("@Lot_Number", veggieItem.getLotNumber(), typeof(string)),
                                                                                            new Param("@Box_Number", veggieItem.getBoxNumber(), typeof(string))
                                                                                            }));

                            int newVeggieLink = DBLink.setProcedure("Link_Vegetable_Box", new List<Param>(new[] {
                                                                                            new Param("@Vegetable_ID", newVeggieID, typeof(int)),
                                                                                            new Param("@Box_ID", boxID, typeof(int))
                                                                                            }));

                            if (newVeggieID == 0 || newVeggieLink == 0)
                            {
                                shouldCommit = false;
                            }
                        }

                        foreach (LineVitamin vitaminItem in flpVitamin.Controls)
                        {

                            int newVitaminID = DBLink.setProcedure("Add_New_Protein", new List<Param>(new[] {
                                                                                            new Param("@Lot_Number", vitaminItem.getLotNumber(), typeof(string)),
                                                                                            new Param("@Box_Number", vitaminItem.getBoxNumber(), typeof(string))
                                                                                            }));

                            int newVitaminLink = DBLink.setProcedure("Link_Protein_Box", new List<Param>(new[] {
                                                                                            new Param("@Protein_ID", newVitaminID, typeof(int)),
                                                                                            new Param("@Box_ID", boxID, typeof(int))
                                                                                            }));

                            if (newVitaminID == 0 || newVitaminLink == 0)
                            {
                                shouldCommit = false;
                            }
                        }


                        if (shouldCommit)
                        {
                            transaction.Complete();
                            MessageBox.Show("Event Created!", "Inventroy Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return shouldCommit;
                        }
                        else
                        {
                            transaction.Dispose();
                            MessageBox.Show("Event Could Not Be Created.", "Inventroy Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void clearFields()
        {
            while (flpRice.Controls.Count > 0)
            {
                flpRice.Controls[0].Dispose();
            }
            while (flpSoy.Controls.Count > 0)
            {
                flpSoy.Controls[0].Dispose();
            }
            while (flpVeggie.Controls.Count > 0)
            {
                flpVeggie.Controls[0].Dispose();
            }
            while (flpVitamin.Controls.Count > 0)
            {
                flpVitamin.Controls[0].Dispose();
            }

            ckbRice.Checked = false;
            ckbSoy.Checked = false;

            txtBoxCode.Text = "";

            txtEventName.Text = "";
            dtpEventDate.Value = DateTime.Today;
            cbxPackingLocation.SelectedIndex = -1;

            foreach (int i in clbTrailer.CheckedIndices)
            {
                clbTrailer.SetItemCheckState(i, CheckState.Unchecked);
            }

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

        private void btnAddPackingLocation_Click(object sender, EventArgs e)
        {
            new frmAddEventLocation(this).Show();
            Hide();
        }

        private void btnAddTrailer_Click(object sender, EventArgs e)
        {
            new frmAddTrailer(this).Show();
            Hide();
        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            if (getSelectedTrailers().Count < 1)
            {
                MessageBox.Show("Event Must Have At Least One Trailer!", "Inventroy Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string autoCode = "";

                autoCode += dtpEventDate.Value.Date.ToShortDateString();
                autoCode += "-";
                autoCode += getSelectedLocationId().ToString();
                autoCode += "-";
                autoCode += getSelectedTrailers()[0].ToString();

                txtBoxCode.Text = autoCode;
            }
        }


        private void ckbRice_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRice.Checked)
            {
                DataTable riceOverflow = DBLink.getProcedure("Get_Rice_Overflow");

                foreach (DataRow row in riceOverflow.Rows)
                {
                    LineRice riceItem = new LineRice("riceItem" + riceCount);
                    riceItem.isOverflow = true;
                    riceItem.setLotNumber(row[1].ToString());
                    riceItem.setQuantity(1);
                    flpRice.Controls.Add(riceItem);
                    riceCount++;
                }
            }
            else
            {
                for (int i = flpRice.Controls.Count - 1; i >= 0; i--)
                {
                    LineRice riceControl = (LineRice)flpRice.Controls[i];
                    if (riceControl.isOverflow)
                    {
                        riceControl.Dispose();
                    }
                }
            }
        }

        private void ckbSoy_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSoy.Checked)
            {
                DataTable soyOverflow = DBLink.getProcedure("Get_Soy_Overflow");

                foreach (DataRow row in soyOverflow.Rows)
                {
                    LineSoy soyItem = new LineSoy("soyItem" + soyCount);
                    soyItem.isOverflow = true;
                    soyItem.setBagNumber(row[1].ToString());
                    flpSoy.Controls.Add(soyItem);
                    soyCount++;
                }
            }
            else
            {
                for (int i = flpSoy.Controls.Count - 1; i >= 0; i--)
                {
                    LineSoy soyControl = (LineSoy)flpSoy.Controls[i];
                    if (soyControl.isOverflow)
                    {
                        soyControl.Dispose();
                    }
                }
            }
        }
    }
}
