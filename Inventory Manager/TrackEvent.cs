﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class frmTrackEvent : Form
    {
        private static Form mainMenu;
        private DataSet resultSet;
        private DataTable locationSet = new DataTable();
        private string printFileName = "EventTrack.html";

        public frmTrackEvent(Form menuForm)
        {
            InitializeComponent();
            Styler.stylePage(this);

            mainMenu = menuForm;

            btnMainMenu.Click += btnMainMenu_Click;
            FormClosed += frmTrackEvent_FormClosed;
            btnTrack.Click += btnTrack_Click;
            btnClear.Click += btnClear_Click;
            btnPrint.Click += btnPrint_Click;
            dtpEventDate.ValueChanged += dtpEventDate_ValueChanged;

            populateLocations();
            clearFields();
        }

        private int getSelectedLocationId()
        {
            DataRowView selectedRow = (DataRowView)cbxLocation.SelectedValue;
            int selectedId = (int)selectedRow[0];

            return selectedId;
        }

        private void populateLocations()
        {
            locationSet = DBLink.getProcedure("Get_Locations");

            cbxLocation.DataSource = locationSet;
            cbxLocation.DisplayMember = locationSet.Columns[1].ColumnName;
            if (cbxLocation.Items.Count > 0)
            {
                cbxLocation.SelectedIndex = 0;
            }
        }

        private bool hasData()
        {
            if (resultSet != null)
            {
                if (resultSet.Tables.Count > 0)
                {
                    if (resultSet.Tables[0].Columns.Count > 0 && resultSet.Tables[0].Rows.Count > 0)
                    {
                        if (resultSet.Tables[0].Rows[0][0].ToString() != "")
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            Param eventName = new Param();
            Param eventDate = new Param();
            Param locationId = new Param();

            if (txtEventName.Text == "")
            {
                eventName = new Param("@Event_Name", true);
            }
            else
            {
                eventName = new Param("@Event_Name", txtEventName.Text, typeof(string));
            }

            if (dtpEventDate.Text == " ")
            {
                eventDate = new Param("@Event_Date", true);
            }
            else
            {
                eventDate = new Param("@Event_Date", dtpEventDate.Value, typeof(DateTime));
            }

            if (cbxLocation.SelectedIndex == -1)
            {
                locationId = new Param("@Location_ID", true);
            }
            else
            {
                locationId = new Param("@Location_ID", getSelectedLocationId(), typeof(int));
            }

            resultSet = DBLink.trackProcedure("Track_Event", new List<Param>(new[] {eventName, eventDate, locationId}));

            if (hasData())
            {
                populateLists();
            }
            else
            {
                MessageBox.Show("No data found.", DBLink.applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEventName.Focus();
            }
        }

        private void populateLists()
        {
            dgvEvent.DataSource = resultSet.Tables[0];
            dgvBox.DataSource = resultSet.Tables[1];
            dgvLocation.DataSource = resultSet.Tables[2];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            txtEventName.Text = "";
            dtpEventDate.CustomFormat = " ";
            dtpEventDate.Format = DateTimePickerFormat.Custom;
            cbxLocation.SelectedIndex = -1;
            txtEventName.Focus();
        }

        private void dtpEventDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEventDate.Format = DateTimePickerFormat.Long;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = File.CreateText(printFileName))
                {
                    sw.WriteLine("<html>");
                    sw.WriteLine("<head>");
                    sw.WriteLine("<style>");
                    sw.WriteLine("table, th, td { border: 1px solid black; text-align: center; }");
                    sw.WriteLine("table { width: 100%; }");
                    sw.WriteLine("th { height: 35px; font-weight: bolder; }");
                    sw.WriteLine("td { height: 25px; }");
                    sw.WriteLine(".header { text-align: center; }");
                    sw.WriteLine("</style>");
                    sw.WriteLine("</head>");
                    sw.WriteLine("<body>");
                    sw.WriteLine("<h2 class=\"header\">");
                    sw.WriteLine("<p>Kids Against Hunger Coalition</p>");
                    sw.WriteLine("<p>Event Tracking Report</p>");
                    sw.WriteLine("<p></p>");
                    sw.WriteLine("</h2>");
                    sw.WriteLine("<p class=\"header\">Report Date: " + DateTime.Today.ToShortDateString() + "</p>");

                    if (hasData())
                    {
                        for (int i = 0; i < resultSet.Tables.Count; i++)
                        {
                            sw.WriteLine("<p></p><p><table>");

                            sw.WriteLine("<tr>");

                            for (int h = 0; h < resultSet.Tables[i].Columns.Count; h++)
                            {
                                sw.WriteLine("<th>");
                                sw.WriteLine(resultSet.Tables[i].Columns[h].ColumnName);
                                sw.WriteLine("</th>");
                            }

                            sw.WriteLine("</tr>");


                            for (int j = 0; j < resultSet.Tables[i].Rows.Count; j++)
                            {
                                sw.WriteLine("<tr>");

                                for (int k = 0; k < resultSet.Tables[i].Columns.Count; k++)
                                {
                                    sw.WriteLine("<td>");
                                    if (resultSet.Tables[i].Rows[j][k] is DateTime)
                                    {
                                        DateTime shortDate = (DateTime)resultSet.Tables[i].Rows[j][k];
                                        sw.WriteLine(shortDate.ToShortDateString());
                                    }
                                    else
                                    {
                                        sw.WriteLine(resultSet.Tables[i].Rows[j][k].ToString());
                                    }
                                    sw.WriteLine("</td>");
                                }

                                sw.WriteLine("</tr>");
                            }

                            sw.WriteLine("</table></p>");
                        }
                    }

                    sw.WriteLine("</body>");
                    sw.WriteLine("</html>");

                }

                printPreview(printFileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), DBLink.applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printPreview(string fileName)
        {
            WebBrowser hiddenBrowser = new WebBrowser();

            hiddenBrowser.Visible = false;
            hiddenBrowser.Parent = this;

            string applicationDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            string myFile = Path.Combine(applicationDirectory, fileName);
            hiddenBrowser.Url = new Uri("file:///" + myFile);

            hiddenBrowser.DocumentCompleted += hiddenBrowser_DocumentLoaded;
        }

        private void hiddenBrowser_DocumentLoaded(object sender, EventArgs e)
        {
            WebBrowser hiddenBrowser = (WebBrowser)sender;

            hiddenBrowser.ShowPrintPreviewDialog();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            Hide();
        }

        private void frmTrackEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu.Show();
        }
    }
}