using CSharpStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace CSharpStudy.Chapters;

public static class Chapter7
{
    public static void Do()
    {
        // 問題7.1.1
        int[] numbers = [5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35];
        var max = numbers.Max();
        Console.WriteLine(max);
        // 問題7.1.2
        var last2Numbers = numbers.Skip(numbers.Length - 2).ToArray();
        Console.WriteLine($"Second Last: {last2Numbers[0]}, Last: {last2Numbers[1]}");
        // 問題7.1.3
        numbers.Select(n => n.ToString("000")).ToList().ForEach(n => Console.WriteLine(n));
        // 問題7.1.4
        numbers.Order().Take(3).ToList().ForEach(n => Console.WriteLine(n));
        // 問題7.1.5
        var result = numbers.Distinct().Count(n => n > 10);
        Console.WriteLine($"result:{result}");
    }
}
