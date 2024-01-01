using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class CalendarService
    {
        private CalendarStorage storage;
        public CalendarService() {
            storage = new CalendarStorage() { Dates = new List<DateTime>() };
        }

        public CalendarService(CalendarStorage storage)
        {
            this.storage = storage;
        }

        public bool IsLeapYear(int year)
        {
            DateTime yearObj = new DateTime(year, 1, 1);
            storage.Dates.Add(yearObj);
            return DateTime.IsLeapYear(year);
        }

        public int CalcIntervalLength(DateTime from, DateTime to)
        {
            storage.Dates.Add(from);
            storage.Dates.Add(to);
            return (to - from).Days;
        }

        public string GetDayOfWeek(DateTime date)
        {
            storage.Dates.Add(date);
            return date.ToString("dddd");
        }

        public IReadOnlyList<DateTime> GetDates()
        {
            return storage.Dates;
        }
    }
}
