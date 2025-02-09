using CSharpStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace CSharpStudy.Chapters;

public static class Chapter6
{
    public static void Do()
    {
        // 問題6.1
        //var str1 = Console.ReadLine();
        //var str2 = Console.ReadLine();
        //var equal = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);
        //Console.WriteLine(equal);
        //// 問題6.2
        //var str1 = Console.ReadLine();
        //if (int.TryParse(str1, out int num2))
        //{
        //    var str2 = num2.ToString("N0");
        //    Console.WriteLine(str2);
        //}
        //else
        //{
        //    Console.WriteLine("無効な入力です。整数を入力してください。");
        //}
        // 問題6.3
        var str = "Jackdaws love my big sphinx of quartz";
        // 問題6.3,1
        var whiteSpaceCount = str.Count(c => c == ' ');
        Console.WriteLine(whiteSpaceCount);
        // 問題6.3,2
        var str2 = str.Replace("big", "small");
        Console.WriteLine(str2);
        // 問題6.3,3
        var strs = str.Split(" ");
        var sb = new StringBuilder();
        foreach ( var s in strs )
        {
            sb.Append(s);
            sb.Append(" ");
        }
        var str3 = sb.ToString().TrimEnd();
        Console.WriteLine(str3);
        // 問題6.3,4
        Console.WriteLine(strs.Count());
        // 問題6.3,5
        strs
            .Where(s=>s.Length <= 4).ToList()
            .ForEach(s => Console.WriteLine(s));
        // 問題6.4
        var str4 = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
        var dict = new Dictionary<string, string>
        {
            {"Novelist", "作家" },
            {"BestWork", "代表作" },
            {"Born", "誕生年" },
        };
        var strArray = str4.Split(";");
        strArray
            .Select(str => dict.Aggregate(str, (current, item) => current.Replace(item.Key, item.Value)))
            .Select(str => str.Replace("=", ":"))
            .ToList()
            .ForEach(Console.WriteLine);
    }
}
