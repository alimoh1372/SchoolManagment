using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SchoolManagment.Utility
{
    public static class Convertor
    {
        public static string DateTimeToPersianStringShortDate(this DateTime pdt)
        {
            PersianCalendar pc = new PersianCalendar();

            return pc.GetYear(pdt).ToString("0000") + "/" + pc.GetMonth(pdt).ToString("00") + "/" + pc.GetMonth(pdt).ToString("00");
        }
        public static DateTime PersianStringShortDateToDateTime(this string persianStringDate)
        {
            PersianCalendar pc = new PersianCalendar();
            int Year = Convert.ToInt32(persianStringDate.Substring(0, 4));
            int Month = Convert.ToInt32(persianStringDate.Substring(5, 2));
            int day = Convert.ToInt32(persianStringDate.Substring(8, 2));
            return pc.ToDateTime(Year, Month, day, 0, 0, 0, 0);
        }
        public static int TotalDaysBetweenTwoDate(this string Startdate,string EndDate)
        {
            DateTime milStartDatetime = Startdate.PersianStringShortDateToDateTime();
            DateTime milEndDateTime = EndDate.PersianStringShortDateToDateTime();
            return Convert.ToInt32((milEndDateTime - milStartDatetime).TotalDays)+1;
        }
    }
}
