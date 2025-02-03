using CSharpStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace CSharpStudy.Chapters;

public static class Chapter5
{
    public static void Do()
    {
        // 問題5.2
        // 問題5.2.1
        YearMonth[] yearMonths = [
            new YearMonth(2000, 12),
            new YearMonth(2022, 1),
            new YearMonth(2025, 2),
            new YearMonth(2300, 7),
            new YearMonth(9999, 5),
        ];
        // 問題5.2.2
        foreach(var yearMonth  in yearMonths)
        {
            Console.WriteLine(yearMonth.ToString());
        }
        // 問題5.2.3
        static YearMonth? Get21Centuty(YearMonth[] yearMonths)
        {
            foreach (var yearMonth in yearMonths)
            {
                if (yearMonth.Is21Century)
                {
                    return yearMonth;
                }
            }
            return null;
        }
        // 問題5.2.4
        var result = Get21Centuty(yearMonths);
        var message = result == null 
            ? "21世紀のデータはありません" 
            : result.ToString();
        Console.WriteLine(message);
        // 問題5.2.5
        var yearMonths2 = yearMonths.Select(x => x.AddOneMonth()).ToArray();
        yearMonths2.ToList().ForEach(x => Console.WriteLine(x.ToString()));

    }
}
