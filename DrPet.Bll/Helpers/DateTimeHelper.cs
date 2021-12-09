using System;

namespace DrPet.Bll.Helpers
{
    public static class DateTimeHelper
    {
        /// <summary>
        /// Get the first day of a week. 
        /// The first parameter is the date for which we are looking for the first day of the week.
        /// The second parameter is the first day of the week (if it's Monday: DayOfWeek.Monday).
        /// </summary>
        /// <param name="date"></param>
        /// <param name="startDayOfWeek"></param>
        /// <returns></returns>
        public static DateTime FirstDayOfWeek(this DateTime date, DayOfWeek startDayOfWeek)
        {
            int diff = (7 + (date.DayOfWeek - startDayOfWeek)) % 7;
            return date.AddDays(-1 * diff).Date;
        }
    }
}
