using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class frmEditDatabase : Form
    {
        private static Form mainMenu;
        private DataTable tableSet = new DataTable();
        private DataTable currentTable = new DataTable();
        private SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection databaseConnection = new SqlConnection();

        public frmEditDatabase(Form menuForm)
        {
            InitializeComponent();
            Styler.stylePage(this);

            mainMenu = menuForm;

            btnMainMenu.MouseClick += btnMainMenu_Click;
            FormClosed += frmAddBoxingEvent_FormClosed;
            cbxTables.SelectedIndexChanged += cbxTables_SelectedIndexChanged;
            btnUpdate.Click += btnUpdate_Click;

            populateTables();

            cbxTables.SelectedIndex = -1;
            dgvEditTable.DataSource = null;
        }

        public void populateTables()
        {
            string tableQuery = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME NOT IN " + 
                "('State_List', 'Country_List', 'Protein_Box', 'Rice_Box', 'Soy_Box', 'Vegetable_Box', 'Trailer_Event')";

            tableSet = DBLink.dynamicDataTableQuery(tableQuery);

            tableSet.Columns.Add("Display", typeof(string));

            foreach (DataRow row in tableSet.Rows)
            {
                row[1] = (row[0].ToString()).Replace('_', ' ');
            }

            cbxTables.DataSource = tableSet;
            cbxTables.DisplayMember = tableSet.Columns[1].ColumnName;
        }

        private void cbxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTables.SelectedIndex >= 0)
            {
                DataRowView selectedRow = (DataRowView)cbxTables.SelectedValue;
                string selectedTable = (string)selectedRow[0];
                string tableQuery = "SELECT * FROM " + selectedTable;
                currentTable = new DataTable();

                databaseConnection = new SqlConnection(DBLink.getConnectionString());

                databaseConnection.Open();

                SqlCommand databaseCommand = new SqlCommand(tableQuery);
                databaseCommand.Connection = databaseConnection;

                adapter = new SqlDataAdapter(databaseCommand);

                adapter.Fill(currentTable);

                dgvEditTable.DataSource = currentTable;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (adapter != null)
                {

                    adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
                    adapter.Update(currentTable);
                    MessageBox.Show("Update Successful!", DBLink.applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You Must Select A Table First!", DBLink.applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), DBLink.applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            databaseConnection.Close();
            mainMenu.Show();
            Hide();
        }

        private void frmAddBoxingEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            databaseConnection.Close();
            mainMenu.Show();
        }
    }
}
