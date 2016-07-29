using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class frmPrintShipment : Form
    {
        private string printFileName = DBLink.appDataDirectory + "shipment.html";
        private DataTable resultSet;
        private Form calledIt;

        public frmPrintShipment(Form callingForm)
        {
            InitializeComponent();
            Styler.stylePage(this);

            calledIt = callingForm;

            btnClose.Click += btnClose_Click;
            btnPrint.Click += btnPrint_Click;
            dtpeDate.DateChanged += dtpeDate_DateChanged;


            DataTable resultTable = DBLink.getProcedure("Get_Shipments", new List<Param>(new[] { new Param("@Shipment_Date", true) }));
            List<DateTime> boldDates = new List<DateTime>();

            foreach (DataRow row in resultTable.Rows)
            {
                boldDates.Add((DateTime)row[2]);
            }

            dtpeDate.setBoldDates(boldDates);

            populateShipments();
            cbxEvent.SelectedIndex = -1;
        }

        private void populateShipments()
        {
            Param shipmentDate = new Param();

            if (dtpeDate.getDate() == DateTime.MinValue)
            {
                shipmentDate = new Param("@Shipment_Date", true);
            }
            else
            {
                shipmentDate = new Param("@Shipment_Date", dtpeDate.getDate(), typeof(DateTime));
            }

            resultSet = DBLink.getProcedure("Get_Shipments", new List<Param>(new[] { shipmentDate }));

            resultSet.Columns.Add("comboDisplay", typeof(string));

            foreach (DataRow row in resultSet.Rows)
            {
                row[3] = row[1].ToString() + ", " + Convert.ToDateTime(row[2]).ToShortDateString();
            }

            cbxEvent.DataSource = resultSet;
            cbxEvent.DisplayMember = resultSet.Columns[3].ColumnName;

            if (cbxEvent.Items.Count > 0)
            {
                cbxEvent.SelectedIndex = 0;
            }
        }

        private int getSelectedShipmentId()
        {
            DataRowView selectedRow = (DataRowView)cbxEvent.SelectedValue;
            int selectedId = (int)selectedRow[0];

            return selectedId;
        }

        private void dtpeDate_DateChanged(object sender, EventArgs e)
        {
            populateShipments();
            cbxEvent.SelectedIndex = -1;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cbxEvent.SelectedIndex >= 0)
            {
                createDoc(printFileName, getSelectedShipmentId());
                printPreview(printFileName);
            }
            else
            {
                MessageBox.Show("You must select a shipment!", DBLink.applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void createDoc(string fileName, int shipmentId)
        {
            try
            {
                DataSet eventSet = DBLink.trackProcedure("Get_Shipment", new List<Param>(new[] {
                                                                                        new Param("@Shipment_ID", shipmentId, typeof(int))
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
                    sw.WriteLine("<p>Repository Shipment</p>");
                    sw.WriteLine("<p></p>");
                    sw.WriteLine("</h2>");
                    sw.WriteLine("<p class=\"header\">Report Date: " + DateTime.Today.ToShortDateString() + "</p>");

                    sw.WriteLine("<table class = 'formatting'><tr><td class = 'formatting'>");

                    if (eventSet.Tables[0] != null)
                    {
                        DateTime shortDate = (DateTime)eventSet.Tables[0].Rows[0][1];

                        sw.WriteLine("<h3>Shipment Date: " + shortDate.ToShortDateString() + "</h3>");
                    }

                    sw.WriteLine("</td><td class = 'formatting'>");

                    if (eventSet.Tables[1] != null)
                    {
                        sw.WriteLine("<h3>Repository Location</h3>"
                            + "<p>" + eventSet.Tables[1].Rows[0][0] + "<br>"
                            + eventSet.Tables[1].Rows[0][1] + "<br>"
                            + eventSet.Tables[1].Rows[0][2] + ", "
                            + eventSet.Tables[1].Rows[0][3] + "<br>"
                            + eventSet.Tables[1].Rows[0][4] + "<br>"
                            + eventSet.Tables[1].Rows[0][5] + "<p>");
                    }

                    sw.WriteLine("</td></tr><tr><td class = 'formatting' colspan = 2>");

                    if (eventSet.Tables[2] != null)
                    {
                        sw.WriteLine("<p><br></p>");
                        sw.WriteLine("<table>");
                        sw.WriteLine("<tr><th colspan = 2>Food Boxes</th></tr>");
                        sw.WriteLine("<tr><td>Box Code</td><td>Quantity</td></tr>");

                        foreach (DataRow row in eventSet.Tables[2].Rows)
                        {
                            sw.WriteLine("<tr><td>" + row[0] + "</td><td>" + row[1] + "</td></tr>");
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
