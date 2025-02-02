using CSharpStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Chapters;

public static class Chapter5
{
    public static void Do()
    {
        // 問題5.1
        var yearMonth = new YearMonth(2025, 12);
        Console.WriteLine(yearMonth.ToString());
        Console.WriteLine(yearMonth.AddOneMonth().ToString());
    }
}
