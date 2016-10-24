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
            rdbCloud.CheckedChanged += rdbConnectionType_CheckedChanged;
            rdbLocal.CheckedChanged += rdbConnectionType_CheckedChanged;

            rdbLocal.Checked = true;
            rdbCloud.Checked = false;
        }

        private bool testConnection()
        {
            try
            {
                if (txtConnection.Text == "")
                {
                    throw new FileNotFoundException();
                }
                if (rdbLocal.Checked)
                {
                    using (SqlConnection databaseConnection = new SqlConnection(DBLink.LocalConnectionStart + txtConnection.Text + DBLink.LocalConnectionEnd))
                    {
                        databaseConnection.Open();
                        databaseConnection.Close();
                        return true;
                    }
                }
                else if (rdbCloud.Checked)
                {
                    using (SqlConnection databaseConnection = new SqlConnection(DBLink.CloudConnectionStart + txtConnection.Text + 
                        DBLink.CloudConnectionMiddle + DBLink.CloudConnectionIDStart + txtUser.Text + DBLink.CloudConnectionPasswordStart + 
                        txtPassword.Text + DBLink.CloudConnectionEnd))
                    {
                        databaseConnection.Open();
                        databaseConnection.Close();
                        return true;
                    }
                }
                else
                {
                    return false;
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
                if (rdbLocal.Checked)
                {

                    DBLink.LocalConnectionFile = txtConnection.Text;
                    DBLink.isCloudConnection = false;
                    Styler.settings["cloudconnection"] = "false";
                    Styler.settings["connectionstring"] = txtConnection.Text;
                    Styler.settings["username"] = "";
                    Styler.settings["password"] = "";
                    Styler.saveSettings();
                    Dispose();
                }
                else if (rdbCloud.Checked)
                {
                    DBLink.CloudConnectionServer = txtConnection.Text;
                    DBLink.CloudConnectionID = txtUser.Text;
                    DBLink.CloudConnectionPassword = txtPassword.Text;
                    DBLink.isCloudConnection = true;
                    Styler.settings["cloudconnection"] = "true";
                    Styler.settings["server"] = txtConnection.Text;
                    Styler.settings["username"] = txtUser.Text;
                    Styler.settings["password"] = txtPassword.Text;
                    Styler.saveSettings();
                    Dispose();
                }
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

        private void rdbConnectionType_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLocal.Checked)
            {
                txtPassword.Enabled = false;
                txtUser.Enabled = false;
                btnBrowse.Enabled = true;
            }
            else if (rdbCloud.Checked)
            {
                txtPassword.Enabled = true;
                txtUser.Enabled = true;
                btnBrowse.Enabled = false;
            }
        }
    }
}
