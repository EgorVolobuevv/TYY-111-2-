using System;
using System.Globalization;
using System.Windows.Forms;

namespace Rabota_15
{
    public partial class Kalendar : Form
    {
        public Kalendar()
        {
            InitializeComponent();
        }

        private void KalendarDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = KalendarDateTimePicker.Value;

            // Определение учебных недель

            // Первый семестр: с 1 сентября 2023 по 31 декабря 2023
            DateTime firstSemesterStart = new DateTime(2023, 9, 1);
            DateTime firstSemesterEnd = new DateTime(2023, 12, 31);

            // Второй семестр: с 7 февраля 2024 по 5 июля 2024
            DateTime secondSemesterStart = new DateTime(2024, 2, 7);
            DateTime secondSemesterEnd = new DateTime(2024, 7, 5);

            // Проверка, к какой учебной неделе относится выбранная дата
            if (selectedDate >= firstSemesterStart && selectedDate <= firstSemesterEnd)
            {
                int weekNumber = GetWeekNumber(selectedDate, firstSemesterStart, firstSemesterEnd);
                int calendarWeekNumber = GetCalendarWeekNumber(selectedDate);
                MessageLabel.Text = $"Выбранная дата относится к {2 - (weekNumber % 2)} учебной неделе  первого семестра ({calendarWeekNumber} в календарном году)";
            }
            else if (selectedDate >= secondSemesterStart && selectedDate <= secondSemesterEnd)
            {
                int weekNumber = GetWeekNumber(selectedDate, secondSemesterStart, secondSemesterEnd);
                int calendarWeekNumber = GetCalendarWeekNumber(selectedDate);
                MessageLabel.Text = $"Выбранная дата относится к  {2 - (weekNumber % 2)} учебной неделе второго семестра({calendarWeekNumber} в календарном году)";
            }
            else
            {
                MessageLabel.Text = "Выбранная дата не относится к учебным неделям";
            }
        }

        private int GetWeekNumber(DateTime selectedDate, DateTime semesterStart, DateTime semesterEnd)
        {
            TimeSpan span = selectedDate - semesterStart;
            int days = span.Days;
            int weekNumber = days / 7 + 1; 
            return weekNumber;
        }

        private int GetCalendarWeekNumber(DateTime date)
        {
            GregorianCalendar calendar = new GregorianCalendar();
            return calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
        }
    }
}

