using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class frmPrintEvent : Form
    {
        private string printFileName = DBLink.appDataDirectory + "boxingEvent.html";
        private DataTable resultSet;
        private Form calledIt;

        public frmPrintEvent(Form callingForm)
        {
            InitializeComponent();
            Styler.stylePage(this);

            calledIt = callingForm;

            btnClose.Click += btnClose_Click;
            btnPrint.Click += btnPrint_Click;
            dtpeDate.DateChanged += dtpeDate_DateChanged;


            resultSet = DBLink.trackProcedure("Get_Events", new List<Param>(new[] { new Param("@Event_Date", true) })).Tables[0];
            List<DateTime> boldDates = new List<DateTime>();

            foreach (DataRow row in resultSet.Rows)
            {
                boldDates.Add((DateTime)row[2]);
            }

            dtpeDate.setBoldDates(boldDates);

            populateEvents();
            cbxEvent.SelectedIndex = -1;
        }

        public frmPrintEvent(int eventId)
        {
            InitializeComponent();
            Styler.stylePage(this);

            btnClose.Click += btnClose_Click;
            btnPrint.Click += btnPrint_Click;
            dtpeDate.DateChanged += dtpeDate_DateChanged;

            populateEvents();
            cbxEvent.SelectedValue = eventId;
        }

        private void populateEvents()
        {
            Param eventDate = new Param();

            if (dtpeDate.getDate() == DateTime.MinValue)
            {
                eventDate = new Param("@Event_Date", true);
            }
            else
            {
                eventDate = new Param("@Event_Date", dtpeDate.getDate(), typeof(DateTime));
            }

            resultSet = DBLink.trackProcedure("Get_Events", new List<Param>(new[] { eventDate })).Tables[0];

            cbxEvent.DataSource = resultSet;
            cbxEvent.DisplayMember = resultSet.Columns[1].ColumnName;

            if (cbxEvent.Items.Count > 0)
            {
                cbxEvent.SelectedIndex = 0;
            }
        }

        private int getSelectedEventId()
        {
            DataRowView selectedRow = (DataRowView)cbxEvent.SelectedValue;
            int selectedId = (int)selectedRow[0];

            return selectedId;
        }

        private void dtpeDate_DateChanged(object sender, EventArgs e)
        {
            populateEvents();
            cbxEvent.SelectedIndex = -1;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cbxEvent.SelectedIndex >= 0)
            {
                createDoc(printFileName, getSelectedEventId());
                printPreview(printFileName);
            }
            else
            {
                MessageBox.Show("You must select an event!", DBLink.applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void createDoc(string fileName, int eventID)
        {
            try
            {
                DataSet eventSet = DBLink.trackProcedure("Get_Boxing_Event", new List<Param>(new[] {
                                                                                        new Param("@Event_ID", eventID, typeof(int))
                                                                                        }));

                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine("<html>");
                    sw.WriteLine("<head>");
                    sw.WriteLine("<style>");
                    sw.WriteLine("table, th, td { border: 1px solid black; text-align: center; }");
                    sw.WriteLine("table { width: 100%; }");
                    sw.WriteLine("th { height: 35px; font-weight: bolder; }");
                    sw.WriteLine("td { height: 25px; }");
                    sw.WriteLine(".header { text-align: center; }");
                    sw.WriteLine(".formatting {border: 0px solid black; text-align: center; vertical-align: top; }");
                    sw.WriteLine("</style>");
                    sw.WriteLine("</head>");
                    sw.WriteLine("<body>");
                    sw.WriteLine("<h2 class=\"header\">");
                    sw.WriteLine("<p>Kids Against Hunger Coalition</p>");
                    sw.WriteLine("<p>Boxing Event</p>");
                    sw.WriteLine("<p></p>");
                    sw.WriteLine("</h2>");
                    sw.WriteLine("<p class=\"header\">Report Date: " + DateTime.Today.ToShortDateString() + "</p>");

                    sw.WriteLine("<table class = 'formatting'><tr><td class = 'formatting'>");

                    if (eventSet.Tables[0] != null)
                    {
                        DateTime shortDate = (DateTime)eventSet.Tables[0].Rows[0][1];

                        sw.WriteLine("<h3>Event Name: " + eventSet.Tables[0].Rows[0][0] + "</h3>");
                        sw.WriteLine("<h3>Event Date: " + shortDate.ToShortDateString() + "</h3>");
                        sw.WriteLine("<h3>Box Code: " + eventSet.Tables[0].Rows[0][2] + "</h3>");
                    }

                    sw.WriteLine("</td><td class = 'formatting'>");

                    if (eventSet.Tables[1] != null)
                    {
                        sw.WriteLine("<h3>Event Location</h3>" 
                            + "<p>" + eventSet.Tables[1].Rows[0][0] + "<br>"
                            + eventSet.Tables[1].Rows[0][1] + "<br>"
                            + eventSet.Tables[1].Rows[0][2] + ", "
                            + eventSet.Tables[1].Rows[0][3] + "<br>"
                            + eventSet.Tables[1].Rows[0][4] + "<br>"
                            + eventSet.Tables[1].Rows[0][5] + "<p>");
                    }

                    sw.WriteLine("</td></tr><tr><td class = 'formatting'>");

                    if (eventSet.Tables[2] != null)
                    {
                        sw.WriteLine("<p><br></p>");
                        sw.WriteLine("<table>");
                        sw.WriteLine("<tr><th colspan = 2>Rice</th></tr>");
                        sw.WriteLine("<tr><td>Lot Number</td><td>Quantity</td></tr>");

                        Dictionary<string, int> riceMap = new Dictionary<string, int>();

                        for (int i = 0; i < eventSet.Tables[2].Rows.Count; i++)
                        {
                            if (riceMap.ContainsKey((string)eventSet.Tables[2].Rows[i][0]))
                            {
                                riceMap[(string)eventSet.Tables[2].Rows[i][0]]++;
                            }else
                            {
                                riceMap.Add((string)eventSet.Tables[2].Rows[i][0], 1);
                            }
                        }

                        foreach (string key in riceMap.Keys)
                        {
                            sw.WriteLine("<tr><td>" + key + "</td><td>" + riceMap[key] + "</td></tr>");
                        }

                        sw.WriteLine("</table>");
                    }

                    sw.WriteLine("</td><td class = 'formatting'>");

                    if (eventSet.Tables[3] != null)
                    {
                        sw.WriteLine("<p><br></p>");
                        sw.WriteLine("<table>");
                        sw.WriteLine("<tr><th colspan = 2>Soy</th></tr>");
                        sw.WriteLine("<tr><td>Bag Number</td></tr>");

                        for (int i = 0; i < eventSet.Tables[3].Rows.Count; i++)
                        {
                            sw.WriteLine("<tr><td>" + eventSet.Tables[3].Rows[i][0] + "</td></tr>");
                        }

                        sw.WriteLine("</table>");
                    }

                    sw.WriteLine("</td></tr><tr><td class = 'formatting'>");

                    if (eventSet.Tables[4] != null)
                    {
                        sw.WriteLine("<p><br></p>");
                        sw.WriteLine("<table>");
                        sw.WriteLine("<tr><th colspan = 2>Vegetables</th></tr>");
                        sw.WriteLine("<tr><td>Lot Number</td><td>Box Number</td></tr>");

                        for (int i = 0; i < eventSet.Tables[4].Rows.Count; i++)
                        {
                            sw.WriteLine("<tr><td>" + eventSet.Tables[4].Rows[i][0] + "</td><td>" + eventSet.Tables[4].Rows[i][1] + "</td></tr>");
                        }

                        sw.WriteLine("</table>");
                    }

                    sw.WriteLine("</td><td class = 'formatting'>");

                    if (eventSet.Tables[5] != null)
                    {
                        sw.WriteLine("<p><br></p>");
                        sw.WriteLine("<table>");
                        sw.WriteLine("<tr><th colspan = 2>Vitamins</th></tr>");
                        sw.WriteLine("<tr><td>Lot Number</td><td>Box Number</td></tr>");

                        for (int i = 0; i < eventSet.Tables[5].Rows.Count; i++)
                        {
                            sw.WriteLine("<tr><td>" + eventSet.Tables[5].Rows[i][0] + "</td><td>" + eventSet.Tables[5].Rows[i][1] + "</td></tr>");
                        }

                        sw.WriteLine("</table>");
                    }

                    sw.WriteLine("</td></tr></table>");

                    sw.WriteLine("</body>");
                    sw.WriteLine("</html>");

                }

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
            hiddenBrowser.Parent = calledIt;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
