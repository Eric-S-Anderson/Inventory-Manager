using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class IcarusCalendar : UserControl
    {
        //public new int Width = 200;
        //public new int Height = 500;
        public Color BackgroundColor = Color.White;
        public Color TextColor = Color.Black;
        public Color BackgroundColorHighlighted = Color.Black;
        public Color TextColorHighlighted = Color.White;
        public Color BackgroundColorOtherMonth = Color.LightGray;
        public Color TextColorOtherMonth = Color.DarkGray;
        public Color BackgroundColorOtherMonthHighlighted = Color.LightBlue;
        public Color TextColorOtherMonthHighlighted = Color.Blue;
        public DateTime StartDate = DateTime.Today;
        public List<DateTime> HighlightedDates = new List<DateTime>();

        private DateTime CurrentDate = new DateTime();

        public IcarusCalendar()
        {
            InitializeComponent();

            CurrentDate = StartDate;
            populateDates();

            HeaderSunday.Text = "Sun";
            HeaderMonday.Text = "Mon";
            HeaderTuesday.Text = "Tue";
            HeaderWednesday.Text = "Wed";
            HeaderThursday.Text = "Thu";
            HeaderFriday.Text = "Fri";
            HeaderSaturday.Text = "Sat";

            MonthBack.Text = "";
            MonthForward.Text = "";

            MonthBack.Click += MonthBack_Click;
            MonthForward.Click += MonthForward_Click;
        }

        private void populateDates()
        {
            DateTime FirstDay = new DateTime(CurrentDate.Year, CurrentDate.Month, 1);
            FirstDay = FirstDay.AddDays(-(int)FirstDay.DayOfWeek);
            int ActiveMonth = CurrentDate.Month;
            Button FirstButton = Week0Sunday;

            for (int i = 0; i < 35; i++)
            {
                FirstButton.Text = FirstDay.Day.ToString();

                if (HighlightedDates.Contains(FirstDay))
                {
                    if (FirstDay.Month == ActiveMonth)
                    {
                        FirstButton.ForeColor = TextColorHighlighted;
                        FirstButton.BackColor = BackgroundColorHighlighted;
                    }
                    else
                    {
                        FirstButton.ForeColor = TextColorOtherMonthHighlighted;
                        FirstButton.BackColor = BackgroundColorOtherMonthHighlighted;
                    }
                }
                else
                {
                    if (FirstDay.Month == ActiveMonth)
                    {
                        FirstButton.ForeColor = TextColor;
                        FirstButton.BackColor = BackgroundColor;
                    }
                    else
                    {
                        FirstButton.ForeColor = TextColorOtherMonth;
                        FirstButton.BackColor = BackgroundColorOtherMonth;
                    }
                }

                FirstButton.Text = FirstDay.Day.ToString();

                if (i < 34)
                {
                    FirstButton = (Button)GetNextControl(FirstButton, true);
                    FirstDay = FirstDay.AddDays(1);
                }
            }

            MonthSelector.Text = CurrentDate.ToString("MMMM", CultureInfo.InvariantCulture);
            YearSelector.Text = CurrentDate.Year.ToString();
        }

        private void MonthBack_Click(object sender, EventArgs e)
        {
            CurrentDate = CurrentDate.AddMonths(-1);
            populateDates();
        }

        private void MonthForward_Click(object sendar, EventArgs e)
        {
            CurrentDate = CurrentDate.AddMonths(1);
            populateDates();
        }
    }
}
