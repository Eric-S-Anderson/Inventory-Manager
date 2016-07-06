using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class frmDBCon : Form
    {
        public frmDBCon()
        {
            InitializeComponent();
            Styler.stylePage(this);

            btnTest.Click += btnTest_Click;
            btnApply.Click += btnApply_Click;
            btnCancel.Click += btnCancel_Click;
            btnBrowse.Click += btnBrowse_Click;
        }

        private bool testConnection()
        {
            try
            {
                if (txtConnection.Text == "")
                {
                    throw new FileNotFoundException();
                }
                using (SqlConnection databaseConnection = new SqlConnection(DBLink.conStart + txtConnection.Text + DBLink.conEnd))
                {
                    databaseConnection.Open();
                    databaseConnection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), DBLink.applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (testConnection())
            {
                MessageBox.Show("Connection Was Successful!", DBLink.applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (testConnection())
            {
                DBLink.conFile = txtConnection.Text;
                Styler.settings["connectionstring"] = txtConnection.Text;
                Styler.saveSettings();
                Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofdDBCon.ShowDialog() == DialogResult.OK)
            {
                txtConnection.Text = ofdDBCon.FileName;
            }
        }
    }
}
