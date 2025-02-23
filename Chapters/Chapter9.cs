using CSharpStudy.Helper;
using CSharpStudy.Models;
using CSharpStudy.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace CSharpStudy.Chapters;

public static class Chapter9
{
    public static void Do()
    {
        // 問題9.1
        var now = DateTime.Now;
        // 問題9.1
        Console.WriteLine(now.ToString("yyyy/MM/dd HH:mm"));
        Console.WriteLine(now.ToString("yyyy年MM月dd日HH分mm秒"));
        // 令和 6年 3月 9日(土曜日)
        var jp = new System.Globalization.CultureInfo("ja-JP");
        jp.DateTimeFormat.Calendar = new JapaneseCalendar();
        Console.WriteLine(now.ToString("ggy年M月d日(dddd)", jp));
        // 問題9.2.1
        var today = DateTime.Today;
        var nextWeekDay = DateTimeHelper.NextWeekday(today, DayOfWeek.Monday);
        Console.WriteLine(nextWeekDay.ToString("yyyy/MM/dd"));
        // 問題9.2.2
        var age = DateTimeHelper.GetAge(new DateOnly(2000, 1, 1), new DateOnly(2021, 1, 1));
        Console.WriteLine(age);
        // 問題9.3
        var timeWatch = new TimeWatch();
        timeWatch.Start();
        Thread.Sleep(1000);
        var elapsed = timeWatch.Stop();
        Console.WriteLine(elapsed.TotalMilliseconds);
    }
}
