using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class IcarusCalendar : UserControl
    {
        public int MaxWidth = 350;
        public int MaxHeight = 350;
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

        public DateTime SelectedDate = DateTime.Today;

        public EventHandler DateSelected;

        private DateTime CurrentDate = new DateTime();
        private int MinWidth = 150;
        private int MinHeight = 150;

        public IcarusCalendar(int CalendarWidth = 350, int CalendarHeight = 350)
        {
            InitializeComponent();

            if (CalendarWidth > MaxWidth)
                CalendarWidth = MaxWidth;

            if (CalendarWidth < MinWidth)
                CalendarWidth = MinWidth;

            if (CalendarHeight > MaxHeight)
                CalendarHeight = MaxHeight;

            if (CalendarHeight < MinHeight)
                CalendarHeight = MinHeight;


            Width = CalendarWidth;
            Height = CalendarHeight;

            foreach (Control box in Controls)
            {
                
                if (box.Name == "DayPanel")
                {
                    box.Height = (Height / 9) * 6;
                }
                else
                {
                    box.Height = Height / 9;
                }

                if (box.Name == "MonthBack")
                {
                    box.Width = Width / 7;
                    box.Top = 0;
                    box.Left = 0;
                }
                else if (box.Name == "MonthForward")
                {
                    box.Width = Width / 7;
                    box.Top = 0;
                    box.Left = (Width / 7) * 6;
                }
                else if (box.Name == "HeaderSunday")
                {
                    box.Width = Width / 7;
                    box.Top = box.Height;
                    box.Left = 0;
                }
                else if (box.Name == "HeaderMonday")
                {
                    box.Width = Width / 7;
                    box.Top = box.Height;
                    box.Left = box.Width;
                }
                else if (box.Name == "HeaderTuesday")
                {
                    box.Width = Width / 7;
                    box.Top = box.Height;
                    box.Left = box.Width * 2;
                }
                else if (box.Name == "HeaderWednesday")
                {
                    box.Width = Width / 7;
                    box.Top = box.Height;
                    box.Left = box.Width * 3;
                }
                else if (box.Name == "HeaderThursday")
                {
                    box.Width = Width / 7;
                    box.Top = box.Height;
                    box.Left = box.Width * 4;
                }
                else if (box.Name == "HeaderFriday")
                {
                    box.Width = Width / 7;
                    box.Top = box.Height;
                    box.Left = box.Width * 5;
                }
                else if (box.Name == "HeaderSaturday")
                {
                    box.Width = Width / 7;
                    box.Top = box.Height;
                    box.Left = box.Width * 6;
                }
                else if (box.Name == "CreatedBy")
                {
                    box.Width = Width;
                    box.Top = (Height / 9) * 8;
                    box.Left = 0;
                }
                else if (box.Name == "DayPanel")
                {
                    box.Width = Width;
                    box.Top = (Height / 9) * 2;
                    box.Left = 0;
                }
                else if (box.Name == "MonthSelector")
                {
                    box.Width = (Width / 7) * 3;
                    box.Top = 0;
                    box.Left = (Width / 7);
                }
                else if (box.Name == "YearSelector")
                {
                    box.Width = (Width / 7) * 2;
                    box.Top = 0;
                    box.Left = (Width / 7) * 4;
                }

                box.Margin = new Padding(0);
                box.Font = new Font("Helvetica", (Height / 50) + 3);
            }


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

        public void populateDates()
        {
            DateTime LoopDay = new DateTime(CurrentDate.Year, CurrentDate.Month, 1);
            LoopDay = LoopDay.AddDays(-(int)LoopDay.DayOfWeek);
            int ActiveMonth = CurrentDate.Month;
            int ActiveYear = CurrentDate.Year;
            DayPanel.Controls.Clear();

            for (int i = 0; i < 42; i++)
            {
                Button DynamicButton = new Button();
                DynamicButton.Width = DayPanel.Width / 7;
                DynamicButton.Height = DayPanel.Height / 6;
                DynamicButton.Margin = new Padding(0);
                DynamicButton.Name = "Day_" + i.ToString();
                DynamicButton.Text = LoopDay.Day.ToString();

                if (HighlightedDates.Contains(LoopDay))
                {
                    if (LoopDay.Month == ActiveMonth)
                    {
                        DynamicButton.ForeColor = TextColorHighlighted;
                        DynamicButton.BackColor = BackgroundColorHighlighted;
                        DynamicButton.Click += SelectDate_Click;
                    }
                    else
                    {
                        DynamicButton.ForeColor = TextColorOtherMonthHighlighted;
                        DynamicButton.BackColor = BackgroundColorOtherMonthHighlighted;

                        if ((LoopDay.Month < ActiveMonth && LoopDay.Year == ActiveYear) || (LoopDay.Month > ActiveMonth && LoopDay.Year < ActiveYear))
                        {
                            DynamicButton.Click += MonthBack_Click;
                        }
                        else
                        {
                            DynamicButton.Click += MonthForward_Click;
                        }
                    }
                    
                }
                else
                {
                    if (LoopDay.Month == ActiveMonth)
                    {
                        DynamicButton.ForeColor = TextColor;
                        DynamicButton.BackColor = BackgroundColor;
                        DynamicButton.Click += SelectDate_Click;
                    }
                    else
                    {
                        DynamicButton.ForeColor = TextColorOtherMonth;
                        DynamicButton.BackColor = BackgroundColorOtherMonth;

                        if ((LoopDay.Month < ActiveMonth && LoopDay.Year == ActiveYear) || (LoopDay.Month > ActiveMonth && LoopDay.Year < ActiveYear))
                        {
                            DynamicButton.Click += MonthBack_Click;
                        }
                        else
                        {
                            DynamicButton.Click += MonthForward_Click;
                        }
                    }
                }

                DynamicButton.Text = LoopDay.Day.ToString();
                DayPanel.Controls.Add(DynamicButton);

                LoopDay = LoopDay.AddDays(1);
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

        private void SelectDate_Click(object sender, EventArgs e)
        {
            SelectedDate = new DateTime(CurrentDate.Year, CurrentDate.Month, int.Parse(((Button)sender).Text));
            DateSelected?.Invoke(this, e);
        }
    }
}
