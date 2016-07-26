using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class DateTimePickerExtended : UserControl
    {
        public EventHandler DateChanged;

        private MonthCalendar Calendar;

        public DateTimePickerExtended()
        {
            InitializeComponent();
            Styler.styleCompundControl(this);
            Calendar = new MonthCalendar();

            Calendar.Parent = this;
            Calendar.MaxSelectionCount = 1;
            Calendar.Hide();

            Calendar.DateSelected += Calendar_DateSelected;
            Calendar.LostFocus += Calendar_LostFocus;
            btnPopup.Click += btnPopup_Click;
            btnClear.Click += btnClear_Click;
            Click += Calendar_LostFocus;
            txtDate.TextChanged += txtDate_TextChanged;

            btnClear.Height = txtDate.Height;
            btnPopup.Height = txtDate.Height;
           
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            DateChanged(sender, e);
        }

        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            Calendar.Hide();
            txtDate.Text = Calendar.SelectionRange.Start.ToLongDateString();
        }

        private void btnPopup_Click(object sender, EventArgs e)
        {
            
            ParentForm.Controls.Add(Calendar);
            Calendar.Show();
            Calendar.BringToFront();
            Calendar.Location = new System.Drawing.Point(Left + txtDate.Right - Calendar.Width, Top);
            Calendar.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDate.Text = "";
        }

        private void Calendar_LostFocus(object sender, EventArgs e)
        {
            Calendar.Hide();
        }

        public DateTime getDate()
        {
            if (txtDate.Text == "")
            {
                return DateTime.MinValue;
            }
            else
            {
                return Convert.ToDateTime(txtDate.Text);
            }
        }

        public void setBoldDates(List<DateTime> boldDates)
        {
            Calendar.BoldedDates = boldDates.ToArray();
        }
    }
}
