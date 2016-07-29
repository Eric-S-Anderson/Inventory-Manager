using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Inventory_Manager
{
    static class DBLink
    {
        public static string applicationName = "Inventory Manager";
        public static string conStart = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"";
        public static string conEnd = "\";Integrated Security=True;Connect Timeout=30";
        public static string conFile = "";
        public static string restoreWarning = "ATTENTION\n\nThis action is not recoverable.\nPlease make sure that you have backed up the current\nversion of the database before proceeding.";
        public static DateTime lastBackupDate = DateTime.Today;
        public static bool askedForBackup = false;
        public static bool backupReminder = true;
        public static string appDataDirectory = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\KAHIM\\";

        public static void testConnection()
        {
            try
            {
                using (SqlConnection databaseConnection = new SqlConnection(getConnectionString()))
                {
                    databaseConnection.Open();
                    databaseConnection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Database Connection Needs to be set!", applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                new frmDBCon().Show();
            }
        }

        public static void shouldBackup()
        {
            try
            {
                if (lastBackupDate < DateTime.Today.Subtract(TimeSpan.FromDays(7)) && backupReminder)
                {
                    if (MessageBox.Show("Your last backup was more than a week ago.  \nWould you like to perform a backup now?", applicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Styler.btnBackup_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static string getConnectionString()
        {
            return conStart + conFile + conEnd;
        }

        public static void dynamicVoidQuery(string query)
        {
            try
            {
                using (SqlConnection databaseConnection = new SqlConnection(getConnectionString()))
                {
                    databaseConnection.Open();

                    using (SqlTransaction transaction = databaseConnection.BeginTransaction())
                    {
                        SqlCommand databaseCommand = new SqlCommand(query);

                        databaseCommand.Connection = databaseConnection;
                        databaseCommand.Transaction = transaction;

                        databaseCommand.ExecuteNonQuery();
                        transaction.Commit();
                    }

                    databaseConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static int dynamicIntegerQuery(string query)
        {
            try
            {
                using (SqlConnection databaseConnection = new SqlConnection(getConnectionString()))
                {
                    databaseConnection.Open();

                    using (SqlTransaction transaction = databaseConnection.BeginTransaction())
                    {
                        SqlCommand databaseCommand = new SqlCommand(query);

                        databaseCommand.Connection = databaseConnection;
                        databaseCommand.Transaction = transaction;

                        var returnValue = databaseCommand.ExecuteScalar();

                        databaseConnection.Close();

                        if (Convert.ToBoolean(returnValue))
                        {
                            transaction.Commit();
                            return Convert.ToInt32(returnValue);
                        }
                        else
                        {
                            transaction.Rollback();
                            return -2;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
        }

        public static DataTable dynamicDataTableQuery(string query)
        {
            try
            {
                using (SqlConnection databaseConnection = new SqlConnection(getConnectionString()))
                {
                    databaseConnection.Open();

                    SqlCommand databaseCommand = new SqlCommand(query);
                    databaseCommand.Connection = databaseConnection;

                    using (SqlDataReader dataReader = databaseCommand.ExecuteReader())
                    {
                        var returnTable = new DataTable();
                        returnTable.Load(dataReader);

                        databaseConnection.Close();
                        return returnTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return new DataTable();
            }
        }

        public static void dynamicAdminQuery(string query)
        {
            try
            {
                using (SqlConnection databaseConnection = new SqlConnection(getConnectionString()))
                {
                    databaseConnection.Open();
                    SqlCommand databaseCommand = new SqlCommand(query);
                    databaseCommand.Connection = databaseConnection;
                    databaseCommand.ExecuteNonQuery();
                    databaseConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static int setProcedure(string procedureName, List<Param> parameters)
        {

            try
            {
                using (SqlConnection databaseConnection = new SqlConnection(getConnectionString()))
                {
                    databaseConnection.Open();

                    using (SqlTransaction transaction = databaseConnection.BeginTransaction())
                    {
                        SqlCommand databaseCommand = new SqlCommand(procedureName);
                        databaseCommand.CommandType = CommandType.StoredProcedure;

                        foreach (var item in parameters)
                        {
                            databaseCommand.Parameters.Add(item.SQLParam);
                        }

                        databaseCommand.Connection = databaseConnection;
                        databaseCommand.Transaction = transaction;

                        var returnValue = databaseCommand.ExecuteScalar();

                        databaseConnection.Close();

                        if (Convert.ToBoolean(returnValue))
                        {
                            transaction.Commit();
                            return Convert.ToInt32(returnValue);
                        }
                        else
                        {
                            transaction.Rollback();
                            return -2;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
        }

        public static DataTable getProcedure(string procedureName)
        {
            try
            {
                using (SqlConnection databaseConnection = new SqlConnection(getConnectionString()))
                {
                    databaseConnection.Open();

                    SqlCommand databaseCommand = new SqlCommand(procedureName);
                    databaseCommand.Connection = databaseConnection;
                    databaseCommand.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dataReader = databaseCommand.ExecuteReader())
                    {
                        var returnTable = new DataTable();
                        returnTable.Load(dataReader);

                        databaseConnection.Close();
                        return returnTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return new DataTable();
            }
        }

        public static DataTable getProcedure(string procedureName, List<Param> parameters)
        {
            try
            {
                using (SqlConnection databaseConnection = new SqlConnection(getConnectionString()))
                {
                    databaseConnection.Open();

                    SqlCommand databaseCommand = new SqlCommand(procedureName);
                    databaseCommand.Connection = databaseConnection;
                    databaseCommand.CommandType = CommandType.StoredProcedure;

                    foreach (var item in parameters)
                    {
                        databaseCommand.Parameters.Add(item.SQLParam);
                    }

                    using (SqlDataReader dataReader = databaseCommand.ExecuteReader())
                    {
                        var returnTable = new DataTable();
                        returnTable.Load(dataReader);

                        databaseConnection.Close();
                        return returnTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return new DataTable();
            }
        }

        public static DataSet trackProcedure(string procedureName, List<Param> parameters)
        {
            try
            {
                using (SqlConnection databaseConnection = new SqlConnection(getConnectionString()))
                {
                    databaseConnection.Open();

                    SqlCommand databaseCommand = new SqlCommand(procedureName);
                    databaseCommand.Connection = databaseConnection;
                    databaseCommand.CommandType = CommandType.StoredProcedure;

                    foreach (var item in parameters)
                    {
                        databaseCommand.Parameters.Add(item.SQLParam);
                    }

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(databaseCommand);

                    DataSet procedureSet = new DataSet();
                    dataAdapter.Fill(procedureSet);

                    databaseConnection.Close();

                    return procedureSet;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return new DataSet();
            }
        }

        public static int adminProcedure(string procedureName, List<Param> parameters)
        {
            try
            {
                using (SqlConnection databaseConnection = new SqlConnection(getConnectionString()))
                {
                    databaseConnection.Open();

                    SqlCommand databaseCommand = new SqlCommand(procedureName);
                    databaseCommand.Connection = databaseConnection;
                    databaseCommand.CommandType = CommandType.StoredProcedure;

                    foreach (var item in parameters)
                    {
                        databaseCommand.Parameters.Add(item.SQLParam);
                    }

                    var returnValue = databaseCommand.ExecuteScalar();

                    databaseConnection.Close();

                    if (Convert.ToBoolean(returnValue))
                    {
                        return Convert.ToInt32(returnValue);
                    }
                    else
                    {
                        return -2;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
        }

    }
}
