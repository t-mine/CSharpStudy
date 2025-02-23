using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Helper
{
    public static class DateTimeHelper
    {
        // 次の指定曜日を取得する
        public static DateTime NextWeekday(DateTime date, DayOfWeek dayOfWeek)
        {
            var thisSaturday = date.AddDays(DayOfWeek.Saturday - date.DayOfWeek);
            var nextWeekDay =  thisSaturday.AddDays((int)(dayOfWeek) + 1);
            if (nextWeekDay - date > TimeSpan.FromDays(7))
            {
                return nextWeekDay.AddDays(-7);
            }
            else
            {
                return nextWeekDay;
            }
        }

        // 指定日における年齢を取得する
        public static int GetAge(DateOnly birthday, DateOnly targetDay)
        {
            // 誕生日から指定日までの年数を取得
            var years = targetDay.Year - birthday.Year;
            // 誕生日が来ていないなら1年引く
            var age = targetDay < birthday.AddYears(years) 
                ? years - 1 
                : years;
            return age;
        }

    }
}
