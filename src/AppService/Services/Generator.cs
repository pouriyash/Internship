using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Internship.AppService.Services
{
    public static class Generator
    {
        public static DateTime? LicenseEndDateGenerator(DateTime? value)
        {
            if (value.HasValue)
            {
                PersianCalendar persianCalendar = new PersianCalendar();

                var year = persianCalendar.GetYear(value.Value);
                var month = persianCalendar.GetMonth(value.Value);
                var day = persianCalendar.GetDayOfMonth(value.Value);

                year += 3;

                return new DateTime(year, month, day, persianCalendar);
            }
            return null;
        }
    }
}
