using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class frmTrackFood : Form
    {
        private static Form mainMenu;
        private DataSet resultSet;
        private string typeSelected = "";
        private string printFileName = "FoodTrack.html";

        public frmTrackFood(Form menuForm)
        {
            InitializeComponent();
            Styler.stylePage(this);

            mainMenu = menuForm;

            btnMainMenu.Click += btnMainMenu_Click;
            FormClosed += frmTrackFood_FormClosed;
            rdbRice.CheckedChanged += rdbRice_CheckedChanged;
            rdbSoy.CheckedChanged += rdbSoy_CheckedChanged;
            rdbVegetable.CheckedChanged += rdbVegetable_CheckedChanged;
            rdbVitamin.CheckedChanged += rdbVitamin_CheckedChanged;
            btnTrack.Click += btnTrack_Click;
            btnPrint.Click += btnPrint_Click;

            ckbUseBox.Checked = true;
            rdbRice.Checked = true;
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
            if (txtLotNumber.Text != "")
            {
                if (rdbRice.Checked)
                {
                    resultSet = DBLink.trackProcedure("Track_Rice", new List<Param>(new[] {
                                                                                            new Param("@Lot_Number", txtLotNumber.Text, typeof(string))
                                                                                            }));
                }
                else if (rdbSoy.Checked)
                {
                    resultSet = DBLink.trackProcedure("Track_Soy", new List<Param>(new[] {
                                                                                            new Param("@Bag_Number", txtLotNumber.Text, typeof(string))
                                                                                            }));
                }
                else if (rdbVegetable.Checked)
                {
                    if (ckbUseBox.Checked)
                    {
                        resultSet = DBLink.trackProcedure("Track_Vegetable", new List<Param>(new[] {
                                                                                            new Param("@Lot_Number", txtLotNumber.Text, typeof(string)),
                                                                                            new Param("@Box_Number", nudBoxNumber.Value.ToString(), typeof(string))
                                                                                            }));
                    }
                    else
                    {
                        resultSet = DBLink.trackProcedure("Track_Vegetable", new List<Param>(new[] {
                                                                                            new Param("@Lot_Number", txtLotNumber.Text, typeof(string))
                                                                                            }));
                    }
                }
                else if (rdbVitamin.Checked)
                {
                    if (ckbUseBox.Checked)
                    {
                        resultSet = DBLink.trackProcedure("Track_Protein", new List<Param>(new[] {
                                                                                            new Param("@Lot_Number", txtLotNumber.Text, typeof(string)),
                                                                                            new Param("@Box_Number", nudBoxNumber.Value.ToString(), typeof(string))
                                                                                            }));
                    }
                    else
                    {
                        resultSet = DBLink.trackProcedure("Track_Protein", new List<Param>(new[] {
                                                                                            new Param("@Lot_Number", txtLotNumber.Text, typeof(string))
                                                                                            }));
                    }
                }

                if (hasData())
                {
                    populateLists();
                }
                else
                {
                    MessageBox.Show("No data found.", DBLink.applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLotNumber.Focus();
                }
            }
            else
            {
                MessageBox.Show("You must enter a lot/bag number!", DBLink.applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void populateLists()
        {
            dgvOnHand.DataSource = resultSet.Tables[0];
            dgvEvent.DataSource = resultSet.Tables[1];
            dgvShipped.DataSource = resultSet.Tables[2];
        }

        private void rdbRice_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRice.Checked)
            {
                lblLotNumber.Text = "Lot Number:";
                lblBoxNumber.Enabled = false;
                nudBoxNumber.Enabled = false;
                ckbUseBox.Enabled = false;
                typeSelected = "Rice";
            }
        }

        private void rdbSoy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSoy.Checked)
            {
                lblLotNumber.Text = "Bag Number:";
                lblBoxNumber.Enabled = false;
                nudBoxNumber.Enabled = false;
                ckbUseBox.Enabled = false;
                typeSelected = "Soy";
            }
        }

        private void rdbVegetable_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVegetable.Checked)
            {
                lblLotNumber.Text = "Lot Number:";
                lblBoxNumber.Enabled = true;
                nudBoxNumber.Enabled = true;
                ckbUseBox.Enabled = true;
                typeSelected = "Vegetable";
            }
        }

        private void rdbVitamin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVitamin.Checked)
            {
                lblLotNumber.Text = "Lot Number:";
                lblBoxNumber.Enabled = true;
                nudBoxNumber.Enabled = true;
                ckbUseBox.Enabled = true;
                typeSelected = "Vitamin";
            }
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
                    sw.WriteLine("<p>Food Tracking Report</p>");
                    sw.WriteLine("<p></p>");
                    sw.WriteLine("</h2>");
                    sw.WriteLine("<p class=\"header\">Food Type: " + typeSelected + "</p>");
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

        private void frmTrackFood_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu.Show();
        }
    }
}
