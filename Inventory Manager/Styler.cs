﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Inventory_Manager
{
    static class Styler
    {
        private static Form formBuffer;
        private static string settingsFile = "Settings.txt";
        public static Dictionary<string, string> settings = new Dictionary<string, string>(); 
        private static string fontName;
        private static int fontSize;

        public static void stylePage(Form styleForm)
        {
            formBuffer = styleForm;
            formBuffer.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
            if (!(formBuffer is frmAbout) && !(formBuffer is frmDBCon))
            {
                bool hasMenu = false;

                foreach (Control formControl in formBuffer.Controls)
                {
                    if (formControl is MenuStrip)
                    {
                        hasMenu = true;
                    }
                }

                if (!hasMenu)
                {
                    addMenuStrip(formBuffer);
                }
            }
            styleControl(styleForm.Controls);
        }

        public static void styleCompundControl(UserControl styleCompund)
        {
            styleControl(styleCompund.Controls);
        }

        public static void styleCompundControl(Control styleCompund)
        {
            styleControl(styleCompund.Controls);
        }

        public static void styleControl(Control.ControlCollection styleMe)
        {
            Font mainFont = new Font(fontName, fontSize, FontStyle.Bold);

            foreach (Control formControl in styleMe)
            {
                if (formControl is Button)
                {
                    Button buttonControl = (Button)formControl;
                    buttonControl.BackgroundImageLayout = ImageLayout.Stretch;
                    buttonControl.Font = mainFont;
                    buttonControl.ForeColor = Color.White;
                    buttonControl.BackColor = Color.Transparent;
                    buttonControl.FlatStyle = FlatStyle.Flat;

                    if (buttonControl.Tag == null)
                    {
                        buttonControl.BackgroundImage = Properties.Resources.Button_14;
                        buttonControl.MouseEnter += ButtonStandard_MouseEnter;
                        buttonControl.MouseLeave += ButtonStandard_MouseLeave;
                        buttonControl.MouseDown += ButtonStandard_MouseDown;
                        buttonControl.MouseUp += ButtonStandard_MouseUp;
                    }
                    else if (buttonControl.Tag.ToString() == "Exit")
                    {
                        buttonControl.BackgroundImage = Properties.Resources.Button_7;
                        buttonControl.MouseEnter += ButtonExit_MouseEnter;
                        buttonControl.MouseLeave += ButtonExit_MouseLeave;
                        buttonControl.MouseDown += ButtonExit_MouseDown;
                        buttonControl.MouseUp += ButtonExit_MouseUp;
                    }
                    else if (buttonControl.Tag.ToString() == "Menu")
                    {
                        buttonControl.BackgroundImage = Properties.Resources.Button_4;
                        buttonControl.MouseEnter += ButtonMenu_MouseEnter;
                        buttonControl.MouseLeave += ButtonMenu_MouseLeave;
                        buttonControl.MouseDown += ButtonMenu_MouseDown;
                        buttonControl.MouseUp += ButtonMenu_MouseUp;
                        buttonControl.Text = "Back";
                    }
                    else if (buttonControl.Tag.ToString() == "Add")
                    {
                        buttonControl.BackgroundImage = Properties.Resources.Button_12;
                        buttonControl.MouseEnter += ButtonAdd_MouseEnter;
                        buttonControl.MouseLeave += ButtonAdd_MouseLeave;
                        buttonControl.MouseDown += ButtonAdd_MouseDown;
                        buttonControl.MouseUp += ButtonAdd_MouseUp;
                        buttonControl.Text = "+";
                        buttonControl.Font = mainFont;
                        buttonControl.TextAlign = ContentAlignment.TopCenter;
                    }
                    else if (buttonControl.Tag.ToString() == "Generate")
                    {
                        buttonControl.BackgroundImage = Properties.Resources.Button_12;
                        buttonControl.MouseEnter += ButtonAdd_MouseEnter;
                        buttonControl.MouseLeave += ButtonAdd_MouseLeave;
                        buttonControl.MouseDown += ButtonAdd_MouseDown;
                        buttonControl.MouseUp += ButtonAdd_MouseUp;
                    }
                }
                else if (formControl is Label)
                {

                    Label labelControl = (Label)formControl;
                    if (labelControl.Tag == null)
                    {
                        labelControl.Font = mainFont;
                        labelControl.ForeColor = Color.Black;
                    }
                    else if (labelControl.Tag.ToString() == "Checkbox")
                    {
                        labelControl.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                        labelControl.ForeColor = Color.Black;
                    }

                }
                else if (formControl is ComboBox)
                {
                    ComboBox comboControl = (ComboBox)formControl;
                    comboControl.Font = mainFont;
                    comboControl.ForeColor = Color.Black;
                }
                else if (formControl is TextBox)
                {
                    TextBox textControl = (TextBox)formControl;
                    textControl.Font = mainFont;
                    textControl.ForeColor = Color.Black;
                }
                else if (formControl is NumericUpDown)
                {
                    NumericUpDown numericControl = (NumericUpDown)formControl;
                    numericControl.Font = mainFont;
                    numericControl.ForeColor = Color.Black;
                }
                else if (formControl is GroupBox)
                {
                    styleCompundControl(formControl);
                }
            }
        }

        private static void addMenuStrip(Form currentForm)
        {
            MenuStrip mspTopLevel = new MenuStrip();

            mspTopLevel.Parent = currentForm;

            ToolStripMenuItem mspMidLevelFile = new ToolStripMenuItem("File");
            
            mspMidLevelFile.DropDownItems.Add("Main Menu", null, btnMainMenu_Click);
            mspMidLevelFile.DropDownItems.Add("Minimize", null, btnMinimize_Click);
            mspMidLevelFile.DropDownItems.Add("Exit", null, btnExitApplication_Click);

            ToolStripMenuItem mspMidLevelActions = new ToolStripMenuItem("Actions");

            ToolStripMenuItem mspDropLevelEvents = new ToolStripMenuItem("Events");
            mspDropLevelEvents.DropDownItems.Add("Add Boxing Event", null, btnAddBoxingEvent_Click);
            mspDropLevelEvents.DropDownItems.Add("Check In Event", null, btnCheckInEvent_Click);

            ToolStripMenuItem mspDropLevelShipments = new ToolStripMenuItem("Shipments");
            mspDropLevelShipments.DropDownItems.Add("Add Shipment", null, btnAddShipment_Click);

            ToolStripMenuItem mspDropLevelAdditions = new ToolStripMenuItem("Additions");
            mspDropLevelAdditions.DropDownItems.Add("Add Trailer", null, btnAddTrailer_Click);
            mspDropLevelAdditions.DropDownItems.Add("Add DOT", null, btnAddDOT_Click);
            mspDropLevelAdditions.DropDownItems.Add("Add Location", null, btnAddEventLocation_Click);
            mspDropLevelAdditions.DropDownItems.Add("Add Repository", null, btnAddRepository_Click);

            ToolStripMenuItem mspDropLevelTracking = new ToolStripMenuItem("Tracking");
            mspDropLevelTracking.DropDownItems.Add("Track Events", null, btnTrackEvent_Click);
            mspDropLevelTracking.DropDownItems.Add("Track Items", null, btnTrackItem_Click);

            mspMidLevelActions.DropDownItems.Add(mspDropLevelEvents);
            mspMidLevelActions.DropDownItems.Add(mspDropLevelShipments);
            mspMidLevelActions.DropDownItems.Add(mspDropLevelAdditions);
            mspMidLevelActions.DropDownItems.Add(mspDropLevelTracking);

            ToolStripMenuItem mspMidLevelTools = new ToolStripMenuItem("Tools");

            ToolStripMenuItem mspDropLevelDatabase = new ToolStripMenuItem("Database");
            mspDropLevelDatabase.DropDownItems.Add("Connection", null, btnConnection_Click);
            mspDropLevelDatabase.DropDownItems.Add("Backup", null, btnBackup_Click);
            mspDropLevelDatabase.DropDownItems.Add("Restore", null, btnRestore_Click);

            mspMidLevelTools.DropDownItems.Add(mspDropLevelDatabase);
            mspMidLevelTools.DropDownItems.Add("Manual Query", null, btnManualQuery_Click);
            mspMidLevelTools.DropDownItems.Add("Font", null, btnFont_Click);

            ToolStripMenuItem mspMidLevelHelp = new ToolStripMenuItem("Help");

            mspMidLevelHelp.DropDownItems.Add("About", null, btnAbout_Click);

            mspTopLevel.Items.Add(mspMidLevelFile);
            mspTopLevel.Items.Add(mspMidLevelActions);
            mspTopLevel.Items.Add(mspMidLevelTools);
            mspTopLevel.Items.Add(mspMidLevelHelp);

        }

        #region Settings Functions
        public static void loadSettings()
        {
            if (!File.Exists(settingsFile))
            {
                File.Create(settingsFile).Close();
            }

            string[] lines = File.ReadAllLines(settingsFile);

            foreach (string line in lines)
            {
                int splitter = line.IndexOf(':');
                string key = line.Substring(0, splitter);
                string value = line.Substring(splitter + 1, line.Length - splitter - 1);

                if (!settings.ContainsKey(key))
                {
                    settings.Add(key, value);
                }
            }

            setVariables();
        }

        private static void setVariables()
        {
            if (settings.ContainsKey("fontname"))
            {
                fontName = settings["fontname"];
            }
            else
            {
                fontName = "Microsoft Sans Serif";
                settings.Add("fontname", "Microsoft Sans Serif");
            }

            if (settings.ContainsKey("fontsize"))
            {
                int.TryParse((settings["fontsize"]), out fontSize);
            }
            else
            {
                fontSize = 15;
                settings.Add("fontsize", "15");
            }

            if (settings.ContainsKey("connectionstring"))
            {
                DBLink.conFile = settings["connectionstring"];
            }
            else
            {
                DBLink.conFile = "\\Data.mdf";
                settings.Add("connectionstring", "\\Data.mdf");
            }

            if (settings.ContainsKey("lastbackup"))
            {
                DBLink.lastBackupDate = Convert.ToDateTime(settings["lastbackup"]);
            }
            else
            {
                DBLink.lastBackupDate = DateTime.Today;
                settings.Add("lastbackup", DateTime.Today.ToShortDateString());
            }

            saveSettings();
        }

        public static void saveSettings()
        {
            List<string> lines = new List<string>();

            foreach (string key in settings.Keys)
            {
                lines.Add(key + ":" + settings[key]);
            }

            File.WriteAllLines(settingsFile, lines);
        }
        #endregion

        #region Menu Strip Functions
        private static Form getFormFromMenuItem(object item)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)item;

            if (menuItem.Owner is ToolStripDropDownMenu)
            {
                ToolStripDropDownMenu dropDownMenu = (ToolStripDropDownMenu)menuItem.Owner;

                if (dropDownMenu.OwnerItem is ToolStripItem)
                {
                    ToolStripItem stripItem = dropDownMenu.OwnerItem;
                    
                    if (stripItem.GetCurrentParent() is ToolStripDropDownMenu)
                    {
                        ToolStripDropDownMenu stripParent = (ToolStripDropDownMenu)stripItem.GetCurrentParent();

                        if (stripParent.OwnerItem is ToolStripMenuItem)
                        {
                            ToolStripMenuItem secondMenuItem = (ToolStripMenuItem)stripParent.OwnerItem;

                            if (secondMenuItem.Owner is ToolStrip)
                            {
                                ToolStrip secondStrip = secondMenuItem.Owner;

                                if (secondStrip.Parent is Form)
                                {
                                    return (Form)secondStrip.Parent;
                                }

                                return null;
                            }

                            return null;
                        }

                        return null;
                    }
                    else if (stripItem.GetCurrentParent() is ToolStrip)
                    {
                        ToolStrip strip = stripItem.GetCurrentParent();

                        if (strip.Parent is Form)
                        {
                            return (Form)strip.Parent;
                        }

                        return null;
                    }

                    return null;
                }

                return null;
            }

            return null;
        }

        private static void btnAddEventLocation_Click(object sender, EventArgs e)
        {
            Form currentForm = getFormFromMenuItem(sender);
            new frmAddEventLocation(currentForm).Show();
            currentForm.Hide();
        }

        private static void btnAddRepository_Click(object sender, EventArgs e)
        {
            Form currentForm = getFormFromMenuItem(sender);
            new frmAddRepository(currentForm).Show();
            currentForm.Hide();
        }

        private static void btnAddTrailer_Click(object sender, EventArgs e)
        {
            Form currentForm = getFormFromMenuItem(sender);
            new frmAddTrailer(currentForm).Show();
            currentForm.Hide();
        }

        private static void btnAddDOT_Click(object sender, EventArgs e)
        {
            Form currentForm = getFormFromMenuItem(sender);
            new frmAddDOT(currentForm).Show();
            currentForm.Hide();
        }

        private static void btnAddBoxingEvent_Click(object sender, EventArgs e)
        {
            Form currentForm = getFormFromMenuItem(sender);
            new frmAddBoxingEvent(currentForm).Show();
            currentForm.Hide();
        }

        private static void btnCheckInEvent_Click(object sender, EventArgs e)
        {
            Form currentForm = getFormFromMenuItem(sender);
            new frmCheckInEvent(currentForm).Show();
            currentForm.Hide();
        }

        private static void btnAddShipment_Click(object sender, EventArgs e)
        {
            Form currentForm = getFormFromMenuItem(sender);
            new frmAddShipment(currentForm).Show();
            currentForm.Hide();
        }

        private static void btnTrackItem_Click(object sender, EventArgs e)
        {
            Form currentForm = getFormFromMenuItem(sender);
            new frmTrackFood(currentForm).Show();
            currentForm.Hide();
        }

        private static void btnTrackEvent_Click(object sender, EventArgs e)
        {
            Form currentForm = getFormFromMenuItem(sender);
            new frmTrackEvent(currentForm).Show();
            currentForm.Hide();
        }

        private static void btnConnection_Click(object sender, EventArgs e)
        {
            new frmDBCon().Show();
        }

        private static void btnBackup_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdBackup = new SaveFileDialog();

            sfdBackup.Filter = "Database Files|*.mdf";

            if (sfdBackup.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy(DBLink.conFile, sfdBackup.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), DBLink.applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private static void btnRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdRestore = new OpenFileDialog();

            ofdRestore.Filter = "Database Files|*.mdf";

            if (ofdRestore.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy(ofdRestore.FileName, DBLink.conFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), DBLink.applicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private static void btnManualQuery_Click(object sender, EventArgs e)
        {
            Form currentForm = getFormFromMenuItem(sender);
            new frmQuery(currentForm).Show();
            currentForm.Hide();
        }

        private static void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fdFont = new FontDialog();

            fdFont.MaxSize = 18;
            fdFont.MinSize = 8;

            if (fdFont.ShowDialog() == DialogResult.OK)
            {
                settings["fontname"] = fdFont.Font.Name;
                settings["fontsize"] = ((int)fdFont.Font.Size).ToString();
                fontName = settings["fontname"];
                int.TryParse((settings["fontsize"]), out fontSize);
                saveSettings();
                stylePage(getFormFromMenuItem(sender));
            }
        }

        private static void btnAbout_Click(object sender, EventArgs e)
        {
            new frmAbout().Show();
        }

        private static void btnMainMenu_Click(object sender, EventArgs e)
        {
            Form currentForm = getFormFromMenuItem(sender);
            if (!(currentForm is frmMainMenu))
            {
                new frmMainMenu().Show();
                currentForm.Dispose();
            }
        }

        private static void btnMinimize_Click(object sender, EventArgs e)
        {
            Form currentForm = getFormFromMenuItem(sender);
            currentForm.WindowState = FormWindowState.Minimized;
        }

        private static void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Special Functions
        public static void BtnExitApplication_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Standard Button
        public static void ButtonStandard_MouseEnter(object sender, EventArgs e)
        {
            Button activeButton = (Button)sender;
            activeButton.BackgroundImage = Properties.Resources.Button_1;
            activeButton.BackColor = Color.Transparent;
        }

        public static void ButtonStandard_MouseLeave(object sender, EventArgs e)
        {
            Button activeButton = (Button)sender;
            activeButton.BackgroundImage = Properties.Resources.Button_14;
            activeButton.BackColor = Color.Transparent;
        }

        public static void ButtonStandard_MouseDown(object sender, MouseEventArgs e)
        {
            Button activeButton = (Button)sender;
            activeButton.BackgroundImage = Properties.Resources.Button_12;
            activeButton.BackColor = Color.Transparent;
        }

        public static void ButtonStandard_MouseUp(object sender, MouseEventArgs e)
        {
            Button activeButton = (Button)sender;
            if (activeButton.ClientRectangle.Contains(e.Location))
            {
                activeButton.BackgroundImage = Properties.Resources.Button_1;
            }
            else
            {
                activeButton.BackgroundImage = Properties.Resources.Button_14;
            }
            activeButton.BackColor = Color.Transparent;
        }
        #endregion

        #region Exit Button
        public static void ButtonExit_MouseEnter(object sender, EventArgs e)
        {
            Button activeButton = (Button)sender;
            activeButton.BackgroundImage = Properties.Resources.Button_6;
            activeButton.BackColor = Color.Transparent;
        }

        public static void ButtonExit_MouseLeave(object sender, EventArgs e)
        {
            Button activeButton = (Button)sender;
            activeButton.BackgroundImage = Properties.Resources.Button_7;
            activeButton.BackColor = Color.Transparent;
        }

        public static void ButtonExit_MouseDown(object sender, MouseEventArgs e)
        {
            Button activeButton = (Button)sender;
            activeButton.BackgroundImage = Properties.Resources.Button_11;
            activeButton.BackColor = Color.Transparent;
        }

        public static void ButtonExit_MouseUp(object sender, MouseEventArgs e)
        {
            Button activeButton = (Button)sender;
            if (activeButton.ClientRectangle.Contains(e.Location))
            {
                activeButton.BackgroundImage = Properties.Resources.Button_6;
            }
            else
            {
                activeButton.BackgroundImage = Properties.Resources.Button_7;
            }
            activeButton.BackColor = Color.Transparent;
        }
        #endregion

        #region Menu/Back Button
        public static void ButtonMenu_MouseEnter(object sender, EventArgs e)
        {
            Button activeButton = (Button)sender;
            activeButton.BackgroundImage = Properties.Resources.Button_3;
            activeButton.BackColor = Color.Transparent;
        }

        public static void ButtonMenu_MouseLeave(object sender, EventArgs e)
        {
            Button activeButton = (Button)sender;
            activeButton.BackgroundImage = Properties.Resources.Button_4;
            activeButton.BackColor = Color.Transparent;
        }

        public static void ButtonMenu_MouseDown(object sender, MouseEventArgs e)
        {
            Button activeButton = (Button)sender;
            activeButton.BackgroundImage = Properties.Resources.Button_9;
            activeButton.BackColor = Color.Transparent;
        }

        public static void ButtonMenu_MouseUp(object sender, MouseEventArgs e)
        {
            Button activeButton = (Button)sender;
            if (activeButton.ClientRectangle.Contains(e.Location))
            {
                activeButton.BackgroundImage = Properties.Resources.Button_3;
            }
            else
            {
                activeButton.BackgroundImage = Properties.Resources.Button_4;
            }
            activeButton.BackColor = Color.Transparent;
        }
        #endregion

        #region Add Button
        public static void ButtonAdd_MouseEnter(object sender, EventArgs e)
        {
            Button activeButton = (Button)sender;
            activeButton.BackgroundImage = Properties.Resources.Button_2;
            activeButton.BackColor = Color.Transparent;
        }

        public static void ButtonAdd_MouseLeave(object sender, EventArgs e)
        {
            Button activeButton = (Button)sender;
            activeButton.BackgroundImage = Properties.Resources.Button_12;
            activeButton.BackColor = Color.Transparent;
        }

        public static void ButtonAdd_MouseDown(object sender, MouseEventArgs e)
        {
            Button activeButton = (Button)sender;
            activeButton.BackgroundImage = Properties.Resources.Button_14;
            activeButton.BackColor = Color.Transparent;
        }

        public static void ButtonAdd_MouseUp(object sender, MouseEventArgs e)
        {
            Button activeButton = (Button)sender;
            if (activeButton.ClientRectangle.Contains(e.Location))
            {
                activeButton.BackgroundImage = Properties.Resources.Button_2;
            }
            else
            {
                activeButton.BackgroundImage = Properties.Resources.Button_12;
            }
            activeButton.BackColor = Color.Transparent;
        }
        #endregion
    }
}