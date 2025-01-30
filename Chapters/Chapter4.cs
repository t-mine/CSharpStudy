using CSharpStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Chapters;

public static class Chapter4
{
    public static void Do()
    {
        // 問題4.1
        List<string> langs =
        [
            "C#","Java","Ruby","PHP","Python","TypeScript","JavaScript","Swift","Go"
        ];
        // 問題4.1.1
        foreach (string lan in langs)
        {
            if (lan.Contains("S"))
            {
                Console.WriteLine(lan);
            }
        }
        for (int i = 0; i < langs.Count; i++)
        {
            var lan = langs[i];
            if (lan.Contains("S"))
            {
                Console.WriteLine(lan);
            }
        }
        int j = 0;
        while (j < langs.Count)
        {
            var lan = langs[j];
            if (lan.Contains("S"))
            {
                Console.WriteLine(lan);
            }
            j++;
        }
        // 問題4.1.2
        langs
            .Where(lan => lan.Contains("S"))
            .ToList()
            .ForEach(lan => Console.WriteLine(lan));
        // 問題4.1.3
        var lang = langs.Find(lan => lan.Length == 10) ?? "unknown";
        // 問題4.2
        var str = Console.ReadLine();
        // 問題4.2.1
        //if (int.TryParse(str, out int num))
        //{
        //    if (num < 0)
        //    {
        //        Console.WriteLine(num);
        //    }
        //    else if (0 <= num && num < 100)
        //    {
        //        Console.WriteLine(num * 2);
        //    }
        //    else if (100 <= num && num < 500)
        //    {
        //        Console.WriteLine(num * 3);
        //    }
        //    else
        //    {
        //        Console.WriteLine(num);
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("入力値に誤りがあります。");
        //}
        //if (int.TryParse(str, out int num))
        //{
        //    switch (num)
        //    {
        //        case < 0:
        //            Console.WriteLine(num);
        //            break;
        //        case >= 0 and < 100:
        //            Console.WriteLine(num * 2);
        //            break;
        //        case >= 100 and < 500:
        //            Console.WriteLine(num * 3);
        //            break;
        //        default:
        //            Console.WriteLine(num);
        //            break;
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("入力値に誤りがあります。");
        //}
        //if (int.TryParse(str, out int num))
        //{
        //    var result = num switch
        //    {
        //        < 0 => num,
        //        >= 0 and < 100 => num * 2,
        //        >= 100 and < 500 => num * 3,
        //        _ => num
        //    };
        //    Console.WriteLine(result);
        //}
        //else
        //{
        //    Console.WriteLine("入力値に誤りがあります。");
        //}
    }
}
